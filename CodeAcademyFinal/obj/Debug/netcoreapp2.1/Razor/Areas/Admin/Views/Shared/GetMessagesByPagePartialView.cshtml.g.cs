#pragma checksum "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8fa49bb7548447ec6ef047ec177ac304a0054f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_GetMessagesByPagePartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/GetMessagesByPagePartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/GetMessagesByPagePartialView.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_GetMessagesByPagePartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fa49bb7548447ec6ef047ec177ac304a0054f1", @"/Areas/Admin/Views/Shared/GetMessagesByPagePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10da9a780c3d6994d050abd5a1729a123890432e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_GetMessagesByPagePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gelenmektublar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Mektub", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
   
    int number = ViewBag.Number;

#line default
#line hidden
            BeginContext(73, 18, true);
            WriteLiteral("\r\n<table data-id=\"");
            EndContext();
            BeginContext(92, 14, false);
#line 7 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
           Write(ViewBag.DataId);

#line default
#line hidden
            EndContext();
            BeginContext(106, 335, true);
            WriteLiteral(@""" class=""table table-hover table-bordered "">
    <thead class=""thead-dark"">
        <tr>
            <th>№</th>
            <th>Ad, Soyad</th>
            <th>Email</th>
            <th>Telefon</th>
            <th>Tarix</th>
            <th>Mövzu</th>
            <th>Müraciət</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
         foreach (var message in Model)
        {

#line default
#line hidden
            BeginContext(493, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(525, 8, false);
#line 23 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
            Write(number++);

#line default
#line hidden
            EndContext();
            BeginContext(534, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(558, 16, false);
#line 24 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
           Write(message.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(574, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(598, 13, false);
#line 25 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
           Write(message.Email);

#line default
#line hidden
            EndContext();
            BeginContext(611, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(635, 19, false);
#line 26 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
           Write(message.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(654, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(678, 39, false);
#line 27 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
           Write(message.SentTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(717, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(741, 15, false);
#line 28 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
           Write(message.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(756, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(797, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "148c86420046436ab73473871b6f8ca2", async() => {
                BeginContext(896, 103, true);
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle info-icon\" aria-hidden=\"true\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
                                                                                          WriteLiteral(message.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1003, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 35 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Areas\Admin\Views\Shared\GetMessagesByPagePartialView.cshtml"
        }

#line default
#line hidden
            BeginContext(1050, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
