#pragma checksum "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d2f229156dd5b2f7413bed2605284715e3750cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_GetEmployeesByPagePartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/GetEmployeesByPagePartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/GetEmployeesByPagePartialView.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_GetEmployeesByPagePartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d2f229156dd5b2f7413bed2605284715e3750cc", @"/Areas/Admin/Views/Shared/GetEmployeesByPagePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10da9a780c3d6994d050abd5a1729a123890432e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_GetEmployeesByPagePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<CustomUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml"
   
    int number = ViewBag.Number;

#line default
#line hidden
            BeginContext(121, 18, true);
            WriteLiteral("\r\n<table data-id=\"");
            EndContext();
            BeginContext(140, 14, false);
#line 8 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml"
           Write(ViewBag.DataId);

#line default
#line hidden
            EndContext();
            BeginContext(154, 258, true);
            WriteLiteral(@""" class=""table table-hover table-bordered"">
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
#line 18 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml"
         foreach (var customUser in Model)
        {
            if (!await _userManager.IsInRoleAsync(customUser, "İstifadəçi"))
            {

#line default
#line hidden
            BeginContext(560, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(608, 8, false);
#line 23 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml"
                    Write(number++);

#line default
#line hidden
            EndContext();
            BeginContext(617, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(649, 19, false);
#line 24 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml"
                   Write(customUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(668, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(701, 63, false);
#line 25 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml"
                    Write((await _userManager.GetRolesAsync(customUser)).FirstOrDefault());

#line default
#line hidden
            EndContext();
            BeginContext(765, 69, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <i data-id=\"");
            EndContext();
            BeginContext(835, 13, false);
#line 27 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml"
                               Write(customUser.Id);

#line default
#line hidden
            EndContext();
            BeginContext(848, 79, true);
            WriteLiteral("\" class=\"fas fa-trash\"></i>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 30 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetEmployeesByPagePartialView.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(953, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
