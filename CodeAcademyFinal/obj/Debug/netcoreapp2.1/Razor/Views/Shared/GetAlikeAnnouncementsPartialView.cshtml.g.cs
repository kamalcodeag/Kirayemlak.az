#pragma checksum "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53039cf4840cec6a2d47323f6e85ead08345d858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_GetAlikeAnnouncementsPartialView), @"mvc.1.0.view", @"/Views/Shared/GetAlikeAnnouncementsPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/GetAlikeAnnouncementsPartialView.cshtml", typeof(AspNetCore.Views_Shared_GetAlikeAnnouncementsPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53039cf4840cec6a2d47323f6e85ead08345d858", @"/Views/Shared/GetAlikeAnnouncementsPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba06cbbc13ad3efeeeb914e0251bfeaf8f3a4be", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_GetAlikeAnnouncementsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Announcement>>
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
#line 3 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
 foreach (var alikeAnnouncement in Model)
{

#line default
#line hidden
            BeginContext(81, 121, true);
            WriteLiteral("    <div class=\"vra-col col-xs-12 col-sm-6 col-md-4\" data-aos=\"fade-up\" data-aos-duration=\"3000\">\r\n        <i data-info=\"");
            EndContext();
            BeginContext(203, 35, false);
#line 6 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                 Write(alikeAnnouncement.Estate.EstateName);

#line default
#line hidden
            EndContext();
            BeginContext(239, 20, false);
#line 6 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                     Write(alikeAnnouncement.Id);

#line default
#line hidden
            EndContext();
            BeginContext(260, 30, false);
#line 6 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                                          Write(alikeAnnouncement.CustomUserId);

#line default
#line hidden
            EndContext();
            BeginContext(290, 73, true);
            WriteLiteral("\" class=\"far fa-heart favourite-heart-empty\"></i>\r\n        <i data-info=\"");
            EndContext();
            BeginContext(364, 35, false);
#line 7 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                 Write(alikeAnnouncement.Estate.EstateName);

#line default
#line hidden
            EndContext();
            BeginContext(400, 20, false);
#line 7 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                     Write(alikeAnnouncement.Id);

#line default
#line hidden
            EndContext();
            BeginContext(421, 30, false);
#line 7 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                                          Write(alikeAnnouncement.CustomUserId);

#line default
#line hidden
            EndContext();
            BeginContext(451, 60, true);
            WriteLiteral("\" class=\"fas fa-heart favourite-heart-filled\"></i>\r\n        ");
            EndContext();
            BeginContext(511, 2198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b008269bf6ef4dd0b9d9942b7ec94359", async() => {
                BeginContext(623, 114, true);
                WriteLiteral("\r\n            <div class=\"vip-items-container\">\r\n                <div class=\"vip-items-top\">\r\n                    ");
                EndContext();
                BeginContext(737, 124, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ae64bb726ab4948bab9ee2b828395e5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 747, "~/MainPageFiles/images/announcements/", 747, 37, true);
#line 11 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
AddHtmlAttributeValue("", 784, alikeAnnouncement.AnnouncementPhotos.FirstOrDefault().AnnouncementPhotoURL, 784, 75, false);

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
                BeginContext(861, 279, true);
                WriteLiteral(@"
                    <div class=""vip-overlay""></div>
                    <div class=""vip-items-top-details"">
                        <div class=""photo-count-container"">
                            <i class=""fas fa-camera camera-photo""></i>
                            <span>");
                EndContext();
                BeginContext(1141, 44, false);
#line 16 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                             Write(alikeAnnouncement.AnnouncementPhotos.Count());

#line default
#line hidden
                EndContext();
                BeginContext(1185, 68, true);
                WriteLiteral("</span>\r\n                        </div>\r\n                        <p>");
                EndContext();
                BeginContext(1254, 23, false);
#line 18 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                      Write(alikeAnnouncement.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1277, 7, true);
                WriteLiteral(" AZN / ");
                EndContext();
                BeginContext(1286, 65, false);
#line 18 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                      Write(alikeAnnouncement.Duration.DurationType == "Aylıq" ? "ay" : "gün");

#line default
#line hidden
                EndContext();
                BeginContext(1352, 255, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"vip-items-bottom\">\r\n                    <div class=\"vip-items-bottom-details\">\r\n                        <div class=\"vip-property-name\">\r\n                            <h4>");
                EndContext();
                BeginContext(1608, 35, false);
#line 24 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                           Write(alikeAnnouncement.Estate.EstateName);

#line default
#line hidden
                EndContext();
                BeginContext(1643, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1648, 323, false);
#line 24 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                                   Write(alikeAnnouncement.Estate.EstateName == "Mənzil" || alikeAnnouncement.Estate.EstateName == "Ev/Villa" ? alikeAnnouncement.Room.RoomType : (alikeAnnouncement.Estate.EstateName == "Torpaq" ? alikeAnnouncement.Area.ToString().Substring(0, alikeAnnouncement.Area.ToString().Length - 3) + " sot" : alikeAnnouncement.Area + " m²"));

#line default
#line hidden
                EndContext();
                BeginContext(1972, 136, true);
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"vip-announcement-location\">\r\n                            <h4>");
                EndContext();
                BeginContext(2109, 31, false);
#line 27 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                           Write(alikeAnnouncement.City.CityName);

#line default
#line hidden
                EndContext();
                BeginContext(2140, 138, true);
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"vip-announcement-datetime\">\r\n                            <span>");
                EndContext();
                BeginContext(2279, 33, false);
#line 30 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                             Write(alikeAnnouncement.PublishDate.Day);

#line default
#line hidden
                EndContext();
                BeginContext(2312, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2314, 33, false);
#line 30 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                                Write(alikeAnnouncement.Month.MonthName);

#line default
#line hidden
                EndContext();
                BeginContext(2347, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2349, 34, false);
#line 30 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                                                                   Write(alikeAnnouncement.PublishDate.Year);

#line default
#line hidden
                EndContext();
                BeginContext(2383, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 31 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                             if (alikeAnnouncement.IsVIP == true)
                            {

#line default
#line hidden
                BeginContext(2490, 72, true);
                WriteLiteral("                                <i class=\"fas fa-crown vip-crown\"></i>\r\n");
                EndContext();
#line 34 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                            }

#line default
#line hidden
                BeginContext(2593, 112, true);
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
#line 8 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
                                                        WriteLiteral(alikeAnnouncement.Id);

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
            BeginContext(2709, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 41 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
}

#line default
#line hidden
            BeginContext(2726, 58, true);
            WriteLiteral("<input class=\"count-for-alike-announcements\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2784, "\"", 2806, 1);
#line 42 "D:\Programming\Other\DEPLOY - Kirayemlak Final Project by KamalGuliyev CodeAcademy\CodeAcademyFinal\Views\Shared\GetAlikeAnnouncementsPartialView.cshtml"
WriteAttributeValue("", 2792, ViewBag.Count, 2792, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2807, 5, true);
            WriteLiteral(" />\r\n");
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
