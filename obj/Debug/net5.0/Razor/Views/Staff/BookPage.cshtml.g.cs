#pragma checksum "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebd483a8509547919fade3d4f9dea95702ef9c2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_BookPage), @"mvc.1.0.view", @"/Views/Staff/BookPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebd483a8509547919fade3d4f9dea95702ef9c2b", @"/Views/Staff/BookPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a913c27688d65fef86afce11526088ba5fdc769b", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_BookPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Encyclopedia_Of_Laws.ViewModels.BookSectionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ChapterController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit_Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
  
    ViewData["Title"] = "BookPage";
  //  Layout = "~/Views/Shared/_StaffLayout.cshtml";
    ViewData["Action"] = "Create_Book";
    ViewData["Possible_Search"] = "أسم الكتاب";
    int i = 1;
    int k = 1;
    string blabla;

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ebd483a8509547919fade3d4f9dea95702ef9c2b6018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd483a8509547919fade3d4f9dea95702ef9c2b7196", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-body"" style=""padding: 20px;"">

        <!-- Table with hoverable rows -->
        <table class=""table table-hover"" style=""width: 100%;"">
            <thead>
                <tr>
                    <th>العمليات</th>
                    <th>");
#nullable restore
#line 25 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                   Write(Html.DisplayNameFor(model => model.أبواب));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>اسم الكتاب</th>\r\n                    <th>رقم الكتاب</th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                 foreach (var value in Model.books)
                {
                    i = 1;
                    k = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 1079, "\"", 1113, 3);
            WriteAttributeValue("", 1089, "showHideRow(", 1089, 12, true);
#nullable restore
#line 36 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
WriteAttributeValue("", 1101, value.IdB, 1101, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1111, ");", 1111, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"table-rows\">\r\n\r\n                        <td class=\"processes\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd483a8509547919fade3d4f9dea95702ef9c2b10095", async() => {
                WriteLiteral("\r\n                                تعديل\r\n                                <i class=\"bi bi-pencil\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                                                                WriteLiteral(value.IdB);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 45 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                             foreach (Sectionكتابقسم mm in Model.أبواب)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                 if (mm.IdB == value.IdB)
                                {
                                    blabla = "hidden_row" + i + "_" + value.IdB;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                     if (k == 1)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div");
            BeginWriteAttribute("id", " id=\"", 1903, "\"", 1929, 2);
            WriteAttributeValue("", 1908, "hidden_row_", 1908, 11, true);
#nullable restore
#line 53 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
WriteAttributeValue("", 1919, value.IdB, 1919, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"first-row\">");
#nullable restore
#line 53 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                                                                     Write(mm.اسمالباب);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 54 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div");
            BeginWriteAttribute("id", " id=", 2133, "", 2144, 1);
#nullable restore
#line 57 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
WriteAttributeValue("", 2137, blabla, 2137, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hidden_row\">\r\n                                            ");
#nullable restore
#line 58 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                       Write(mm.اسمالباب);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 60 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                     

                                    i++;
                                    k++;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td style=\"text-align:right\">\r\n                            ");
#nullable restore
#line 68 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                       Write(value.اسمالكتاب);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:right\">\r\n                            ");
#nullable restore
#line 71 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                       Write(value.رقمالكتاب);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 74 "C:\Users\M-S\Downloads\Encyclopedia_Of_Laws (3)\Encyclopedia_Of_Laws\Views\Staff\BookPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <!-- End Table with hoverable rows -->\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Encyclopedia_Of_Laws.ViewModels.BookSectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
