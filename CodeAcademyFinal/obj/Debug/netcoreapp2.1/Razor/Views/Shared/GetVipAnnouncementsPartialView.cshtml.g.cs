#pragma checksum "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb9cd7b52177e4b984ed483de1306db3e0a6bb24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_GetVipAnnouncementsPartialView), @"mvc.1.0.view", @"/Views/Shared/GetVipAnnouncementsPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/GetVipAnnouncementsPartialView.cshtml", typeof(AspNetCore.Views_Shared_GetVipAnnouncementsPartialView))]
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
#line 2 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\_ViewImports.cshtml"
using CodeAcademyFinal.ViewModels;

#line default
#line hidden
#line 3 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\_ViewImports.cshtml"
using CodeAcademyFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb9cd7b52177e4b984ed483de1306db3e0a6bb24", @"/Views/Shared/GetVipAnnouncementsPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba06cbbc13ad3efeeeb914e0251bfeaf8f3a4be", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_GetVipAnnouncementsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Announcement>>
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
#line 3 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
 foreach (var vipAnnouncement in Model)
{

#line default
#line hidden
            BeginContext(79, 121, true);
            WriteLiteral("    <div class=\"vra-col col-xs-12 col-sm-6 col-md-4\" data-aos=\"fade-up\" data-aos-duration=\"3000\">\r\n        <i data-info=\"");
            EndContext();
            BeginContext(201, 33, false);
#line 6 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                 Write(vipAnnouncement.Estate.EstateName);

#line default
#line hidden
            EndContext();
            BeginContext(235, 18, false);
#line 6 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                   Write(vipAnnouncement.Id);

#line default
#line hidden
            EndContext();
            BeginContext(254, 28, false);
#line 6 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                                      Write(vipAnnouncement.CustomUserId);

#line default
#line hidden
            EndContext();
            BeginContext(282, 73, true);
            WriteLiteral("\" class=\"far fa-heart favourite-heart-empty\"></i>\r\n        <i data-info=\"");
            EndContext();
            BeginContext(356, 33, false);
#line 7 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                 Write(vipAnnouncement.Estate.EstateName);

#line default
#line hidden
            EndContext();
            BeginContext(390, 18, false);
#line 7 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                   Write(vipAnnouncement.Id);

#line default
#line hidden
            EndContext();
            BeginContext(409, 28, false);
#line 7 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                                      Write(vipAnnouncement.CustomUserId);

#line default
#line hidden
            EndContext();
            BeginContext(437, 60, true);
            WriteLiteral("\" class=\"fas fa-heart favourite-heart-filled\"></i>\r\n        ");
            EndContext();
            BeginContext(497, 2162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2bbff673724a89b65e4c5440b388ee", async() => {
                BeginContext(607, 114, true);
                WriteLiteral("\r\n            <div class=\"vip-items-container\">\r\n                <div class=\"vip-items-top\">\r\n                    ");
                EndContext();
                BeginContext(721, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "443c8578519c4bf5bed320ad0652dab3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 731, "~/MainPageFiles/images/announcements/", 731, 37, true);
#line 11 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
AddHtmlAttributeValue("", 768, vipAnnouncement.AnnouncementPhotos.FirstOrDefault().AnnouncementPhotoURL, 768, 73, false);

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
                BeginContext(843, 279, true);
                WriteLiteral(@"
                    <div class=""vip-overlay""></div>
                    <div class=""vip-items-top-details"">
                        <div class=""photo-count-container"">
                            <i class=""fas fa-camera camera-photo""></i>
                            <span>");
                EndContext();
                BeginContext(1123, 42, false);
#line 16 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                             Write(vipAnnouncement.AnnouncementPhotos.Count());

#line default
#line hidden
                EndContext();
                BeginContext(1165, 68, true);
                WriteLiteral("</span>\r\n                        </div>\r\n                        <p>");
                EndContext();
                BeginContext(1234, 21, false);
#line 18 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                      Write(vipAnnouncement.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1255, 7, true);
                WriteLiteral(" AZN / ");
                EndContext();
                BeginContext(1264, 63, false);
#line 18 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                    Write(vipAnnouncement.Duration.DurationType == "Aylıq" ? "ay" : "gün");

#line default
#line hidden
                EndContext();
                BeginContext(1328, 255, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"vip-items-bottom\">\r\n                    <div class=\"vip-items-bottom-details\">\r\n                        <div class=\"vip-property-name\">\r\n                            <h4>");
                EndContext();
                BeginContext(1584, 33, false);
#line 24 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                           Write(vipAnnouncement.Estate.EstateName);

#line default
#line hidden
                EndContext();
                BeginContext(1617, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1622, 309, false);
#line 24 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                                 Write(vipAnnouncement.Estate.EstateName == "Mənzil" || vipAnnouncement.Estate.EstateName == "Ev/Villa" ? vipAnnouncement.Room.RoomType : (vipAnnouncement.Estate.EstateName == "Torpaq" ? vipAnnouncement.Area.ToString().Substring(0, vipAnnouncement.Area.ToString().Length - 3) + " sot" : vipAnnouncement.Area + " m²"));

#line default
#line hidden
                EndContext();
                BeginContext(1932, 136, true);
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"vip-announcement-location\">\r\n                            <h4>");
                EndContext();
                BeginContext(2069, 29, false);
#line 27 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                           Write(vipAnnouncement.City.CityName);

#line default
#line hidden
                EndContext();
                BeginContext(2098, 138, true);
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"vip-announcement-datetime\">\r\n                            <span>");
                EndContext();
                BeginContext(2237, 31, false);
#line 30 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                             Write(vipAnnouncement.PublishDate.Day);

#line default
#line hidden
                EndContext();
                BeginContext(2268, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2270, 31, false);
#line 30 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                              Write(vipAnnouncement.Month.MonthName);

#line default
#line hidden
                EndContext();
                BeginContext(2301, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2303, 32, false);
#line 30 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                                                               Write(vipAnnouncement.PublishDate.Year);

#line default
#line hidden
                EndContext();
                BeginContext(2335, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 31 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                             if (vipAnnouncement.IsVIP == true)
                            {

#line default
#line hidden
                BeginContext(2440, 72, true);
                WriteLiteral("                                <i class=\"fas fa-crown vip-crown\"></i>\r\n");
                EndContext();
#line 34 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                            }

#line default
#line hidden
                BeginContext(2543, 112, true);
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
#line 8 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
                                                        WriteLiteral(vipAnnouncement.Id);

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
            BeginContext(2659, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 41 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
}

#line default
#line hidden
            BeginContext(2676, 56, true);
            WriteLiteral("<input class=\"count-for-vip-announcements\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2732, "\"", 2754, 1);
#line 42 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetVipAnnouncementsPartialView.cshtml"
WriteAttributeValue("", 2740, ViewBag.Count, 2740, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2755, 7, true);
            WriteLiteral(" />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
