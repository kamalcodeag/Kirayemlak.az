#pragma checksum "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetPositionsByPagePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81067d333c58e1784a0894cdeb815df727278c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_GetPositionsByPagePartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/GetPositionsByPagePartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/GetPositionsByPagePartialView.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_GetPositionsByPagePartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81067d333c58e1784a0894cdeb815df727278c5", @"/Areas/Admin/Views/Shared/GetPositionsByPagePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10da9a780c3d6994d050abd5a1729a123890432e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_GetPositionsByPagePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<IdentityRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetPositionsByPagePartialView.cshtml"
  
    int number = ViewBag.Number;

#line default
#line hidden
            BeginContext(76, 18, true);
            WriteLiteral("\r\n<table data-id=\"");
            EndContext();
            BeginContext(95, 14, false);
#line 7 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetPositionsByPagePartialView.cshtml"
           Write(ViewBag.DataId);

#line default
#line hidden
            EndContext();
            BeginContext(109, 217, true);
            WriteLiteral("\" class=\"table table-hover table-bordered\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>№</th>\r\n            <th>Ad</th>\r\n            <th>Əməliyyatlar</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetPositionsByPagePartialView.cshtml"
         foreach (var position in Model)
        {

#line default
#line hidden
            BeginContext(379, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(419, 8, false);
#line 19 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetPositionsByPagePartialView.cshtml"
                Write(number++);

#line default
#line hidden
            EndContext();
            BeginContext(428, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(456, 13, false);
#line 20 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetPositionsByPagePartialView.cshtml"
               Write(position.Name);

#line default
#line hidden
            EndContext();
            BeginContext(469, 61, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <i data-id=\"");
            EndContext();
            BeginContext(531, 11, false);
#line 22 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetPositionsByPagePartialView.cshtml"
                           Write(position.Id);

#line default
#line hidden
            EndContext();
            BeginContext(542, 71, true);
            WriteLiteral("\" class=\"fas fa-trash\"></i>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetPositionsByPagePartialView.cshtml"
        }

#line default
#line hidden
            BeginContext(624, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
