#pragma checksum "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef702c0e3e48de675606f6e2250fdc5ca51b3ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Ishchiler_Siyahi), @"mvc.1.0.view", @"/Areas/Admin/Views/Ishchiler/Siyahi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Ishchiler/Siyahi.cshtml", typeof(AspNetCore.Areas_Admin_Views_Ishchiler_Siyahi))]
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
#line 2 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademyFinal.ViewModels;

#line default
#line hidden
#line 3 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademyFinal.Models;

#line default
#line hidden
#line 4 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademyFinal.Areas.Admin.ViewModels;

#line default
#line hidden
#line 5 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef702c0e3e48de675606f6e2250fdc5ca51b3ef", @"/Areas/Admin/Views/Ishchiler/Siyahi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10da9a780c3d6994d050abd5a1729a123890432e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Ishchiler_Siyahi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<CustomUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ishchiler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row announcement-delete-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
  
    int number = 1;

#line default
#line hidden
            BeginContext(107, 129, true);
            WriteLiteral("\r\n        <!-- ---TEMPDATA EMPLOYEE CREATED DELETED--- -->\r\n        <div class=\"row mb-5\">\r\n            <div class=\"col-xs-12\">\r\n");
            EndContext();
#line 11 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                 if (TempData["EmployeeCreated"] != null)
                {

#line default
#line hidden
            BeginContext(314, 68, true);
            WriteLiteral("                    <p class=\"text-success\">Yeni işçi yarandı.</p>\r\n");
            EndContext();
#line 14 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                }

#line default
#line hidden
            BeginContext(401, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 15 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                 if (TempData["EmployeeDeleted"] != null)
                {

#line default
#line hidden
            BeginContext(479, 84, true);
            WriteLiteral("                    <p class=\"text-success\">Seçdiyiniz işçi sistemdən silindi.</p>\r\n");
            EndContext();
#line 18 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                }

#line default
#line hidden
            BeginContext(582, 245, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <!-- +++TEMPDATA EMPLOYEE CREATED DELETED+++ -->\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-12 table-container-for-employees\">\r\n                <h3 class=\"mb-3\">İşçilərin siyahısı</h3>\r\n");
            EndContext();
#line 26 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                 if ((ViewBag.AllEmployees / 10) > 0)
                {

#line default
#line hidden
            BeginContext(901, 475, true);
            WriteLiteral(@"                    <table data-id=""1"" class=""table table-hover table-bordered"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>№</th>
                                <th>İstifadəçi adı</th>
                                <th>Vəzifə</th>
                                <th>Əməliyyatlar</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 38 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                             foreach (var customUser in Model)
                            {
                                if (!await _userManager.IsInRoleAsync(customUser, "İstifadəçi"))
                                {

#line default
#line hidden
            BeginContext(1604, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1692, 8, false);
#line 43 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                                        Write(number++);

#line default
#line hidden
            EndContext();
            BeginContext(1701, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1753, 19, false);
#line 44 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                                       Write(customUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1772, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1825, 63, false);
#line 45 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                                        Write((await _userManager.GetRolesAsync(customUser)).FirstOrDefault());

#line default
#line hidden
            EndContext();
            BeginContext(1889, 109, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <i data-id=\"");
            EndContext();
            BeginContext(1999, 13, false);
#line 47 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                                                   Write(customUser.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2012, 119, true);
            WriteLiteral("\" class=\"fas fa-trash\"></i>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 50 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(2197, 64, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
            EndContext();
#line 54 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2321, 799, true);
            WriteLiteral(@"                    <table data-id=""1"" class=""table table-hover table-bordered active"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>№</th>
                                <th>İstifadəçi adı</th>
                                <th>Vəzifə</th>
                                <th>Əməliyyatlar</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td colspan=""4"" style=""text-align:center;font-size:30px;"">Siyahı boşdur</td>
                            </tr>
                        </tbody>
                    </table>
                    <input type=""hidden"" class=""page-count"" value=""1"" />
");
            EndContext();
#line 73 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                }

#line default
#line hidden
            BeginContext(3139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 75 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                 if ((ViewBag.AllEmployees / 10).ToString().Contains("."))
                {
                    

#line default
#line hidden
#line 77 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                     if ((((((ViewBag.AllEmployees / 10) - (Math.Round(ViewBag.AllEmployees / 10))) * 10) <= 5) && ((((ViewBag.AllEmployees / 10) - (Math.Round(ViewBag.AllEmployees / 10))) * 10) > 0)))
                    {

#line default
#line hidden
            BeginContext(3462, 63, true);
            WriteLiteral("                        <input type=\"hidden\" class=\"page-count\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3525, "\"", 3577, 1);
#line 79 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
WriteAttributeValue("", 3533, Math.Round(ViewBag.AllEmployees / 10) + 1, 3533, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3578, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 80 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3655, 63, true);
            WriteLiteral("                        <input type=\"hidden\" class=\"page-count\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3718, "\"", 3766, 1);
#line 83 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
WriteAttributeValue("", 3726, Math.Round(ViewBag.AllEmployees / 10), 3726, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3767, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 84 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                    }

#line default
#line hidden
#line 84 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                     
                }
                else
                {

#line default
#line hidden
            BeginContext(3855, 59, true);
            WriteLiteral("                    <input type=\"hidden\" class=\"page-count\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3914, "\"", 3950, 1);
#line 88 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
WriteAttributeValue("", 3922, ViewBag.AllEmployees / 10, 3922, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3951, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 89 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Ishchiler\Siyahi.cshtml"
                }

#line default
#line hidden
            BeginContext(3975, 801, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row my-5"">
            <div class=""col-12 pagination-container-for-employees d-flex justify-content-center"">
                <div class=""pagination-container d-flex"">
                    <div class=""prev-page d-flex justify-content-center align-items-center"">Əvvəlki</div>
                    <div class=""pagination-window"">
                        <ul class=""pagination-lent m-0 p-0 d-flex"">
                        </ul>
                    </div>
                    <div class=""next-page d-flex justify-content-center align-items-center"">Növbəti</div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 announcement-delete-container-col d-none"">
                ");
            EndContext();
            BeginContext(4776, 855, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85899e55f23b471792002f8727d73d49", async() => {
                BeginContext(4899, 725, true);
                WriteLiteral(@"
                    <div class=""col-12"">
                        <p>Silməyə əminsiniz ?</p>
                    </div>
                    <div class=""col-6"">
                        <input type=""hidden"" value="""" name=""userId"" class=""delete-position"" />
                        <input class=""announcement-delete-yes input-login-register-pages input-btn-login-register""
                               type=""submit"" value=""Bəli"">
                    </div>
                    <div class=""col-6"">
                        <input class=""announcement-delete-no input-login-register-pages input-btn-login-register""
                               type=""button"" value=""Xeyr"">
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5631, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CustomUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<CustomUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591