#pragma checksum "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a1e81d807fc189df68d484b01b6453389db6aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_GetUsersByPagePartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/GetUsersByPagePartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/GetUsersByPagePartialView.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_GetUsersByPagePartialView))]
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
#line 2 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademyFinal.ViewModels;

#line default
#line hidden
#line 3 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademyFinal.Models;

#line default
#line hidden
#line 4 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademyFinal.Areas.Admin.ViewModels;

#line default
#line hidden
#line 5 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a1e81d807fc189df68d484b01b6453389db6aa", @"/Areas/Admin/Views/Shared/GetUsersByPagePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10da9a780c3d6994d050abd5a1729a123890432e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_GetUsersByPagePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<CustomUser>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
  
    int number = ViewBag.Number;

#line default
#line hidden
            BeginContext(120, 18, true);
            WriteLiteral("\r\n<table data-id=\"");
            EndContext();
            BeginContext(139, 14, false);
#line 8 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
           Write(ViewBag.DataId);

#line default
#line hidden
            EndContext();
            BeginContext(153, 275, true);
            WriteLiteral(@""" class=""table table-hover table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th>№</th>
            <th>Ad, Soyad</th>
            <th>Email</th>
            <th>Telefon</th>
            <th>Şəkil</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
         foreach (var customUser in Model)
        {
            if (await _userManager.IsInRoleAsync(customUser, "İstifadəçi"))
            {

#line default
#line hidden
            BeginContext(575, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(623, 8, false);
#line 24 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
                    Write(number++);

#line default
#line hidden
            EndContext();
            BeginContext(632, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(664, 20, false);
#line 25 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
                   Write(customUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(684, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(686, 19, false);
#line 25 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
                                         Write(customUser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(705, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(737, 16, false);
#line 26 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
                   Write(customUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(753, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(785, 38, false);
#line 27 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
                   Write(customUser.PhoneNumber.Substring(0, 6));

#line default
#line hidden
            EndContext();
            BeginContext(823, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(825, 38, false);
#line 27 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
                                                           Write(customUser.PhoneNumber.Substring(6, 7));

#line default
#line hidden
            EndContext();
            BeginContext(863, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(920, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "493fd2fd20c548c89ce62d80bbd49146", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 930, "~/MainPageFiles/images/users/", 930, 29, true);
#line 29 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
AddHtmlAttributeValue("", 959, customUser.ProfilePictureURL, 959, 29, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(992, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 32 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetUsersByPagePartialView.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1070, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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