#pragma checksum "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee51762b015c78011fcaa571617a3c2450874364"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_GetSearchResultPartialView), @"mvc.1.0.view", @"/Views/Shared/GetSearchResultPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/GetSearchResultPartialView.cshtml", typeof(AspNetCore.Views_Shared_GetSearchResultPartialView))]
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
#line 2 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\_ViewImports.cshtml"
using CodeAcademyFinal.ViewModels;

#line default
#line hidden
#line 3 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\_ViewImports.cshtml"
using CodeAcademyFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee51762b015c78011fcaa571617a3c2450874364", @"/Views/Shared/GetSearchResultPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba06cbbc13ad3efeeeb914e0251bfeaf8f3a4be", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_GetSearchResultPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Announcement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Elanlar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Elan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
 foreach (var announcement in Model)
{

#line default
#line hidden
            BeginContext(76, 121, true);
            WriteLiteral("    <div class=\"vra-col col-xs-12 col-sm-6 col-md-4\" data-aos=\"fade-up\" data-aos-duration=\"3000\">\r\n        <i data-info=\"");
            EndContext();
            BeginContext(198, 30, false);
#line 6 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                 Write(announcement.Estate.EstateName);

#line default
#line hidden
            EndContext();
            BeginContext(229, 15, false);
#line 6 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                Write(announcement.Id);

#line default
#line hidden
            EndContext();
            BeginContext(245, 25, false);
#line 6 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                                Write(announcement.CustomUserId);

#line default
#line hidden
            EndContext();
            BeginContext(270, 73, true);
            WriteLiteral("\" class=\"far fa-heart favourite-heart-empty\"></i>\r\n        <i data-info=\"");
            EndContext();
            BeginContext(344, 30, false);
#line 7 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                 Write(announcement.Estate.EstateName);

#line default
#line hidden
            EndContext();
            BeginContext(375, 15, false);
#line 7 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                Write(announcement.Id);

#line default
#line hidden
            EndContext();
            BeginContext(391, 25, false);
#line 7 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                                Write(announcement.CustomUserId);

#line default
#line hidden
            EndContext();
            BeginContext(416, 60, true);
            WriteLiteral("\" class=\"fas fa-heart favourite-heart-filled\"></i>\r\n        ");
            EndContext();
            BeginContext(476, 2108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdb5fa16ac4742b089041eb89cdf9323", async() => {
                BeginContext(583, 114, true);
                WriteLiteral("\r\n            <div class=\"vip-items-container\">\r\n                <div class=\"vip-items-top\">\r\n                    ");
                EndContext();
                BeginContext(697, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0ea50b814a26404abac21b73c6d0fb29", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 707, "~/MainPageFiles/images/announcements/", 707, 37, true);
#line 11 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
AddHtmlAttributeValue("", 744, announcement.AnnouncementPhotos.FirstOrDefault().AnnouncementPhotoURL, 744, 70, false);

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
                BeginContext(816, 279, true);
                WriteLiteral(@"
                    <div class=""vip-overlay""></div>
                    <div class=""vip-items-top-details"">
                        <div class=""photo-count-container"">
                            <i class=""fas fa-camera camera-photo""></i>
                            <span>");
                EndContext();
                BeginContext(1096, 39, false);
#line 16 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                             Write(announcement.AnnouncementPhotos.Count());

#line default
#line hidden
                EndContext();
                BeginContext(1135, 68, true);
                WriteLiteral("</span>\r\n                        </div>\r\n                        <p>");
                EndContext();
                BeginContext(1204, 18, false);
#line 18 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                      Write(announcement.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1222, 7, true);
                WriteLiteral(" AZN / ");
                EndContext();
                BeginContext(1231, 60, false);
#line 18 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                 Write(announcement.Duration.DurationType == "Aylıq" ? "ay" : "gün");

#line default
#line hidden
                EndContext();
                BeginContext(1292, 255, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"vip-items-bottom\">\r\n                    <div class=\"vip-items-bottom-details\">\r\n                        <div class=\"vip-property-name\">\r\n                            <h4>");
                EndContext();
                BeginContext(1548, 30, false);
#line 24 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                           Write(announcement.Estate.EstateName);

#line default
#line hidden
                EndContext();
                BeginContext(1578, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1583, 288, false);
#line 24 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                              Write(announcement.Estate.EstateName == "Mənzil" || announcement.Estate.EstateName == "Ev/Villa" ? announcement.Room.RoomType : (announcement.Estate.EstateName == "Torpaq" ? announcement.Area.ToString().Substring(0, announcement.Area.ToString().Length - 3) + " sot" : announcement.Area + " m²"));

#line default
#line hidden
                EndContext();
                BeginContext(1872, 136, true);
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"vip-announcement-location\">\r\n                            <h4>");
                EndContext();
                BeginContext(2009, 26, false);
#line 27 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                           Write(announcement.City.CityName);

#line default
#line hidden
                EndContext();
                BeginContext(2035, 138, true);
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"vip-announcement-datetime\">\r\n                            <span>");
                EndContext();
                BeginContext(2174, 28, false);
#line 30 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                             Write(announcement.PublishDate.Day);

#line default
#line hidden
                EndContext();
                BeginContext(2202, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2204, 28, false);
#line 30 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                           Write(announcement.Month.MonthName);

#line default
#line hidden
                EndContext();
                BeginContext(2232, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2234, 29, false);
#line 30 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                                                         Write(announcement.PublishDate.Year);

#line default
#line hidden
                EndContext();
                BeginContext(2263, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 31 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                             if (announcement.IsVIP == true)
                            {

#line default
#line hidden
                BeginContext(2365, 72, true);
                WriteLiteral("                                <i class=\"fas fa-crown vip-crown\"></i>\r\n");
                EndContext();
#line 34 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                            }

#line default
#line hidden
                BeginContext(2468, 112, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
                                                        WriteLiteral(announcement.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2584, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 41 "D:\Programming\Other\DEPLOY - Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetSearchResultPartialView.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
