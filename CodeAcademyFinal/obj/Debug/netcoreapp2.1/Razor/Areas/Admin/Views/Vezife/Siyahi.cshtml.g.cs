#pragma checksum "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e75bc4603fbef8430e964fecd451a6c336c8e615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Vezife_Siyahi), @"mvc.1.0.view", @"/Areas/Admin/Views/Vezife/Siyahi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Vezife/Siyahi.cshtml", typeof(AspNetCore.Areas_Admin_Views_Vezife_Siyahi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e75bc4603fbef8430e964fecd451a6c336c8e615", @"/Areas/Admin/Views/Vezife/Siyahi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10da9a780c3d6994d050abd5a1729a123890432e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Vezife_Siyahi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vezife", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
   
    int number = 1;

#line default
#line hidden
            BeginContext(80, 133, true);
            WriteLiteral("\r\n<!-- ---TEMPDATA ROLE CREATED DELETED--- -->\r\n                <div class=\"row mb-5\">\r\n                    <div class=\"col-xs-12\">\r\n");
            EndContext();
#line 10 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                         if (TempData["PositionCreated"] != null)
                        {

#line default
#line hidden
            BeginContext(307, 78, true);
            WriteLiteral("                            <p class=\"text-success\">Yeni vəzifə yarandı.</p>\r\n");
            EndContext();
#line 13 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                        }

#line default
#line hidden
            BeginContext(412, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 14 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                         if (TempData["PositionDeleted"] != null)
                        {

#line default
#line hidden
            BeginContext(506, 73, true);
            WriteLiteral("                            <p class=\"text-success\">Vəzifə silindi.</p>\r\n");
            EndContext();
#line 17 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                        }

#line default
#line hidden
            BeginContext(606, 291, true);
            WriteLiteral(@"                    </div>
                </div>
                <!-- +++TEMPDATA ROLE CREATED DELETED+++ -->

                <div class=""row"">
                    <div class=""col-12 table-container-for-positions"">
                        <h3 class=""mb-3"">Vəzifələrin siyahısı</h3>
");
            EndContext();
#line 25 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                         if ((ViewBag.AllPositions / 10) > 0)
                        {

#line default
#line hidden
            BeginContext(987, 486, true);
            WriteLiteral(@"                            <table data-id=""1"" class=""table table-hover table-bordered"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th>№</th>
                                        <th>Ad</th>
                                        <th>Əməliyyatlar</th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 36 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                                     foreach (var position in Model)
                                    {

#line default
#line hidden
            BeginContext(1582, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(1678, 8, false);
#line 39 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                                            Write(number++);

#line default
#line hidden
            EndContext();
            BeginContext(1687, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1743, 13, false);
#line 40 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                                           Write(position.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1756, 117, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <i data-id=\"");
            EndContext();
            BeginContext(1874, 11, false);
#line 42 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                                                       Write(position.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1885, 127, true);
            WriteLiteral("\" class=\"fas fa-trash\"></i>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 45 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2051, 80, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
            EndContext();
#line 48 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2215, 858, true);
            WriteLiteral(@"                            <table data-id=""1"" class=""table table-hover table-bordered active"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th>№</th>
                                        <th>Ad</th>
                                        <th>Əməliyyatlar</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td colspan=""3"" style=""text-align:center;font-size:30px;"">Siyahı boşdur</td>
                                    </tr>
                                </tbody>
                            </table>
                            <input type=""hidden"" class=""page-count"" value=""1"" />
");
            EndContext();
#line 66 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                        }

#line default
#line hidden
            BeginContext(3100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 68 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                         if ((ViewBag.AllPositions / 10).ToString().Contains("."))
                        {
                            

#line default
#line hidden
#line 70 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                             if ((((((ViewBag.AllPositions / 10) - (Math.Round(ViewBag.AllPositions / 10))) * 10) <= 5) && ((((ViewBag.AllPositions / 10) - (Math.Round(ViewBag.AllPositions / 10))) * 10) > 0)))
                            {

#line default
#line hidden
            BeginContext(3455, 71, true);
            WriteLiteral("                                <input type=\"hidden\" class=\"page-count\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3526, "\"", 3578, 1);
#line 72 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
WriteAttributeValue("", 3534, Math.Round(ViewBag.AllPositions / 10) + 1, 3534, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3579, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 73 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3680, 71, true);
            WriteLiteral("                                <input type=\"hidden\" class=\"page-count\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3751, "\"", 3799, 1);
#line 76 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
WriteAttributeValue("", 3759, Math.Round(ViewBag.AllPositions / 10), 3759, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3800, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 77 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                            }

#line default
#line hidden
#line 77 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3920, 67, true);
            WriteLiteral("                            <input type=\"hidden\" class=\"page-count\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3987, "\"", 4023, 1);
#line 81 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
WriteAttributeValue("", 3995, ViewBag.AllPositions / 10, 3995, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4024, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 82 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Vezife\Siyahi.cshtml"
                        }

#line default
#line hidden
            BeginContext(4056, 937, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""row my-5"">
                    <div class=""col-12 pagination-container-for-positions d-flex justify-content-center"">
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
            BeginContext(4993, 1052, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac93bf11b344e529bc6500e8bf24652", async() => {
                BeginContext(5113, 925, true);
                WriteLiteral(@"
                            <div class=""col-12"">
                                <p>Silməyə əminsiniz ?</p>
                            </div>
                            <div class=""col-6"">
                                <!-- Attribute 'Name' helps us to send value as a parameter -->
                                <input type=""hidden"" value="""" name=""roleId"" class=""delete-position""/>
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
            BeginContext(6045, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
