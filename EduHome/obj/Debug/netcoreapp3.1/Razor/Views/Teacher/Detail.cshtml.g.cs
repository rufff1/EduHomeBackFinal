#pragma checksum "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29b3b9b2627f372789ed06d4ae91ecfd7a471ca5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
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
#line 2 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.Dal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\_ViewImports.cshtml"
using EduHome.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b3b9b2627f372789ed06d4ae91ecfd7a471ca5", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8956c8ef023a467bdae6c7ad0f2986b72e7f4374", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "29b3b9b2627f372789ed06d4ae91ecfd7a471ca54818", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 845, "~/assets/img/teacher/", 845, 21, true);
#nullable restore
#line 31 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 866, Model.Image, 866, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\n                <div class=\"teacher-details-content ml-50\">\n                    <h2>");
#nullable restore
#line 36 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <h5>");
#nullable restore
#line 37 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                   Write(Model.TeacherPosition.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <h4>about me</h4>\n                    <p>");
#nullable restore
#line 39 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                  Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <ul>\n                        <li><span>degree: </span>");
#nullable restore
#line 41 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span>experience: </span>");
#nullable restore
#line 42 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 43 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                             if (Model.TeacherHobbies.Count() > 0)
                           
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <li>\n                                 <span>hobbies: </span>\n");
#nullable restore
#line 48 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                        foreach (TeacherHobbie teacherHobbie in Model.TeacherHobbies)
                                          {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                        Write(teacherHobbie.Hobbie.Name + " , " );

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                                                                 

                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                  </li>\n");
#nullable restore
#line 56 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><span>faculty: </span>");
#nullable restore
#line 57 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 66 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p><span>make a call : </span>");
#nullable restore
#line 67 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p><span>skype : </span>");
#nullable restore
#line 68 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                       Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <ul>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2531, "\"", 2551, 1);
#nullable restore
#line 70 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2538, Model.Fblink, 2538, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2627, "\"", 2650, 1);
#nullable restore
#line 71 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2634, Model.PinttLink, 2634, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2727, "\"", 2750, 1);
#nullable restore
#line 72 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2734, Model.VimeoLink, 2734, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2823, "\"", 2844, 1);
#nullable restore
#line 73 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2830, Model.TwtLink, 2830, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
");
#nullable restore
#line 83 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                         foreach (TeacherSkill teacherSkill in Model.TeacherSkills)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-4\">\n                                <div class=\"skill-bar-item\">\n                                    <span>");
#nullable restore
#line 87 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                     Write(teacherSkill.Skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                    <div class=\"progress\">\n                                        <div data-wow-delay=\"1.2s\" data-wow-duration=\"1.5s\"");
            BeginWriteAttribute("style", " style=\"", 3629, "\"", 3769, 11);
            WriteAttributeValue("", 3637, "width:", 3637, 6, true);
#nullable restore
#line 89 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3643, teacherSkill.SkillDegree, 3644, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3669, "%;", 3669, 2, true);
            WriteAttributeValue(" ", 3671, "visibility:", 3672, 12, true);
            WriteAttributeValue(" ", 3683, "visible;", 3684, 9, true);
            WriteAttributeValue(" ", 3692, "animation-duration:", 3693, 20, true);
            WriteAttributeValue(" ", 3712, "1.5s;", 3713, 6, true);
            WriteAttributeValue(" ", 3718, "animation-delay:", 3719, 17, true);
            WriteAttributeValue(" ", 3735, "1.2s;", 3736, 6, true);
            WriteAttributeValue(" ", 3741, "animation-name:", 3742, 16, true);
            WriteAttributeValue(" ", 3757, "fadeInLeft;", 3758, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\n                                            <span class=\"text-top\">");
#nullable restore
#line 90 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                                                              Write(teacherSkill.SkillDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\n                                        </div>\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 95 "C:\Users\ROG\Desktop\EduHomeBackFinal-master\EduHome\Views\Teacher\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- Teacher End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591