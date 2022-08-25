using Encyclopedia_Of_Laws.Data;
using Encyclopedia_Of_Laws.Models;
using Encyclopedia_Of_Laws.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encyclopedia_Of_Laws.Controllers
{

    public class AdministrationController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly EncyclopediaOfLawsContext _context;
        private readonly IToastNotification _toastNotification;


        public AdministrationController(UserManager<ApplicationUser> userManager,
            EncyclopediaOfLawsContext context, IToastNotification toastNotification,
           RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            _context = context;
            _toastNotification = toastNotification;
            this.roleManager = roleManager;
        }
    


        //MANAGE ROLES
        [HttpGet]
        public async Task<IActionResult> ListRoles()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(roles);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRole(AddRoleViewModel model)
        {
            if (!ModelState.IsValid)
                return View("ListRoles", await roleManager.Roles.ToListAsync());

            if (await roleManager.RoleExistsAsync(model.RoleName))
            {
                ModelState.AddModelError("Name", "Role is already exists!");
                return View("ListRoles", await roleManager.Roles.ToListAsync());
            }

            await roleManager.CreateAsync(new IdentityRole(model.RoleName.Trim()));

            return RedirectToAction(nameof(ListRoles));

        }



        //MANAGE USERS

        public async Task<IActionResult> ListUsers()
        {
            var users = await userManager.Users.Select(user => new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth,
                Country = user.Country,
                City = user.City,
                Address = user.Address,
                Roles = userManager.GetRolesAsync(user).Result
            }).ToListAsync();

            return View(users);
        }



        public async Task<IActionResult> AddStaff()
        {
            var roles = await roleManager.Roles.Select(role => new RoleViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name,
            }).ToListAsync();

            var viewmodel = new AddStaff
            {
                Roles = roles

            };
            return View(viewmodel);
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddStaff(AddStaff model)
        {
            if (ModelState.IsValid)
            {
                if (model.Role == "-1")
                {
                    ModelState.AddModelError("Roles", "Please select a role from the list!");
                    return View(model);
                }

                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser
                {
                    Email = model.Email,
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Gender = model.Gender
                };

                // Store user data in Users database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {

                    await userManager.AddToRoleAsync(user, "Staff");

                    return RedirectToAction("ListUsers", "administration");
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            if (id == null)
            {
                Response.StatusCode = 404;
                return View("RequestNotFound", id);
            }

            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("RequestNotFound", id);
            }

            await userManager.DeleteAsync(user);
            return Ok();

        }


        //USERS ISSUES

        public async Task<IActionResult> ListUserIssues()
        {
            var UserIssues = await _context.UserIssues.ToListAsync();
            return View(UserIssues);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendIssue(UserIssue issues)
        {
            if (!ModelState.IsValid)
                return PartialView("_Contact", issues);

            issues.IssueDate = DateTime.Now;
            _context.Attach(issues);
            _context.Entry(issues).State = EntityState.Added;
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Message sent successfully");
            return RedirectToAction("Index", "Home");

        }


    }
}
