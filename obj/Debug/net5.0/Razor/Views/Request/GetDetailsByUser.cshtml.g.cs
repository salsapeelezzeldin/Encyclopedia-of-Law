#pragma checksum "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9992bbea6f3b11e7e0ce9d3ba600ae4d7902da99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_GetDetailsByUser), @"mvc.1.0.view", @"/Views/Request/GetDetailsByUser.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9992bbea6f3b11e7e0ce9d3ba600ae4d7902da99", @"/Views/Request/GetDetailsByUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a913c27688d65fef86afce11526088ba5fdc769b", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_GetDetailsByUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Encyclopedia_Of_Laws.Models.Request>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
  
    ViewData["Title"] = "GetDetailsByUser";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""modal fade"" id=""verticalycentered Details"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Request Details</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>


            <div class=""modal-body"">
                <dl class=""row"" id=""Details"">
                    <dt class=""col-sm-4"">
                        ");
#nullable restore
#line 20 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 35 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.RequestStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayFor(model => model.RequestStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 44 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.AssignedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 47 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayFor(model => model.AssignedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.Lawyer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayFor(model => model.Lawyer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
#nullable restore
#line 60 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Request\GetDetailsByUser.cshtml"
                   Write(Html.DisplayFor(model => model.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </dd>
                </dl>

            </div>

            <div class=""modal-footer text-center"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
            </div>

        </div>
    </div>
</div><!-- End Vertically centered Modal-->

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Encyclopedia_Of_Laws.Models.Request> Html { get; private set; }
    }
}
#pragma warning restore 1591
