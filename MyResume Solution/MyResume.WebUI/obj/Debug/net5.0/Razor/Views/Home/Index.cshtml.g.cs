#pragma checksum "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c222694d27ed3d7734d9b68295884f76ce4049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 4 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Infracture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.WebUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c222694d27ed3d7734d9b68295884f76ce4049", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddce19b1e1012ef6db02c535ddb3f6e77303058e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "About me";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- ABOUT ME -->\r\n<div class=\"inside-sec\">\r\n    <!-- BIO AND SKILLS -->\r\n    <h5 class=\"tittle\">About Me</h5>\r\n\r\n    <!-- Blog -->\r\n    <section class=\"about-me padding-top-10\">\r\n        <!-- Personal Info -->\r\n        ");
#nullable restore
#line 13 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("About"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n        <!-- I’m Web Designer -->\r\n");
#nullable restore
#line 16 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5 class=\"tittle\">");
#nullable restore
#line 18 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Home\Index.cshtml"
                          Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <div class=\"padding-20\">\r\n                <p>\r\n                    ");
#nullable restore
#line 21 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Home\Index.cshtml"
               Write(Html.Raw(@item.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <!-- Services -->
        <h5 class=""tittle"">Services</h5>
        <div class=""row padding-20 margin-top-50"">
            <!-- Icon -->
            <div class=""col-md-4 text-center"">
                <div class=""icon-box i-large ib-black"">
                    <div class=""ib-icon"">
                        <i class=""fa fa-whatsapp""></i>
                    </div>
                    <div class=""ib-info"">
                        <h4 class=""h6"">WEB DEVELOPMENT</h4>
                        <p>
                            We have created the new macbook psd version
                            with scalable vector shapes.
                        </p>
                    </div>
                </div>
            </div>

            <!-- Icon -->
            <div class=""col-md-4 text-center"">
                <div class=""icon-box i-large ib-black"">
                    <div class=""ib-icon"">
                        <i class=""fa fa-magic""></i>
                    </div>
                ");
            WriteLiteral(@"    <div class=""ib-info"">
                        <h4 class=""h6"">WEB DESIGN</h4>
                        <p>
                            We have created the new macbook psd version
                            with scalable vector shapes.
                        </p>
                    </div>
                </div>
            </div>

            <!-- Icon -->
            <div class=""col-md-4 text-center"">
                <div class=""icon-box i-large ib-black"">
                    <div class=""ib-icon"">
                        <i class=""fa fa-smile-o""></i>
                    </div>
                    <div class=""ib-info"">
                        <h4 class=""h6"">RESPONSIVE</h4>
                        <p>
                            We have created the new macbook psd version
                            with scalable vector shapes.
                        </p>
                    </div>
                </div>
            </div>
        </div>

        <!-- Icon Row -->
        <div ");
            WriteLiteral(@"class=""row padding-20 margin-bottom-50"">
            <!-- Icon -->
            <div class=""col-md-4"">
                <div class=""icon-box i-large ib-black"">
                    <div class=""ib-icon"">
                        <i class=""fa fa-diamond""></i>
                    </div>
                    <div class=""ib-info"">
                        <h4 class=""h6"">Unique Design</h4>
                        <p>
                            We have created the new macbook psd version
                            with scalable vector shapes.
                        </p>
                    </div>
                </div>
            </div>

            <!-- Icon -->
            <div class=""col-md-4"">
                <div class=""icon-box i-large ib-black"">
                    <div class=""ib-icon"">
                        <i class=""fa fa-server""></i>
                    </div>
                    <div class=""ib-info"">
                        <h4 class=""h6"">Demos Layout</h4>
                        ");
            WriteLiteral(@"<p>
                            We have created the new macbook psd version
                            with scalable vector shapes.
                        </p>
                    </div>
                </div>
            </div>

            <!-- Icon -->
            <div class=""col-md-4"">
                <div class=""icon-box i-large ib-black"">
                    <div class=""ib-icon"">
                        <i class=""fa fa-scissors""></i>
                    </div>
                    <div class=""ib-info"">
                        <h4 class=""h6"">Clean Code</h4>
                        <p>
                            We have created the new macbook psd version
                            with scalable vector shapes.
                        </p>
                    </div>
                </div>
            </div>
        </div>

        <!-- Skills -->
        <h5 class=""tittle"">Skills</h5>

        <!-- Sound Engineering -->
        <div class=""panel-group accordion padding-20""
");
            WriteLiteral(@"             id=""accordion"">
            <div class=""panel panel-default"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <!-- PANEL HEADING -->
                        <div class=""panel-heading"">
                            <h4 class=""panel-title"">
                                <a data-toggle=""collapse""
                                   data-parent=""#accordion""
                                   href=""#collapseOne""
                                   class=""collapsed"">
                                    Photoshop
                                </a>
                            </h4>
                        </div>
                    </div>

                    <!-- Skillls Bars -->
                    <div class=""col-sm-8"">
                        <div class=""progress"">
                            <div class=""progress-bar""
                                 role=""progressbar""
                                 aria-valuenow=""80""
    ");
            WriteLiteral(@"                             aria-valuemin=""0""
                                 aria-valuemax=""100""
                                 style=""width: 80%"">
                                <span class=""sr-only"">60% Complete</span>
                            </div>
                        </div>

                        <!-- Skillls Text -->
                        <div id=""collapseOne""
                             class=""panel-collapse collapse"">
                            <div class=""panel-body"">
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit. Proin nibh augue,
                                    suscipit a, scelerisque sed, lacinia in,
                                    mi. Cras vel lorem.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

           ");
            WriteLiteral(@" <!-- Business Administration -->

            <div class=""panel panel-default"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <!-- PANEL HEADING -->
                        <div class=""panel-heading"">
                            <h4 class=""panel-title"">
                                <a data-toggle=""collapse""
                                   data-parent=""#accordion""
                                   href=""#collapsetwo""
                                   class=""collapsed"">
                                    Dreamviewer
                                </a>
                            </h4>
                        </div>
                    </div>

                    <!-- Skillls Bars -->
                    <div class=""col-sm-8"">
                        <div class=""progress"">
                            <div class=""progress-bar""
                                 role=""progressbar""
                                 aria-valuenow=""");
            WriteLiteral(@"60""
                                 aria-valuemin=""0""
                                 aria-valuemax=""100""
                                 style=""width: 60%"">
                                <span class=""sr-only"">60% Complete</span>
                            </div>
                        </div>

                        <!-- Skillls Text -->
                        <div id=""collapsetwo""
                             class=""panel-collapse collapse"">
                            <div class=""panel-body"">
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit. Proin nibh augue,
                                    suscipit a, scelerisque sed, lacinia in,
                                    mi. Cras vel lorem.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

  ");
            WriteLiteral(@"          <!-- HTML -->
            <div class=""panel panel-default"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <!-- PANEL HEADING -->
                        <div class=""panel-heading"">
                            <h4 class=""panel-title"">
                                <a data-toggle=""collapse""
                                   data-parent=""#accordion""
                                   href=""#collapsethree""
                                   class=""collapsed"">
                                    HTML5/CSS3
                                </a>
                            </h4>
                        </div>
                    </div>

                    <!-- Skillls Bars -->
                    <div class=""col-sm-8"">
                        <div class=""progress"">
                            <div class=""progress-bar""
                                 role=""progressbar""
                                 aria-valuenow=""100""
     ");
            WriteLiteral(@"                            aria-valuemin=""0""
                                 aria-valuemax=""100""
                                 style=""width: 100%"">
                                <span class=""sr-only"">60% Complete</span>
                            </div>
                        </div>

                        <!-- Skillls Text -->
                        <div id=""collapsethree""
                             class=""panel-collapse collapse"">
                            <div class=""panel-body"">
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit. Proin nibh augue,
                                    suscipit a, scelerisque sed, lacinia in,
                                    mi. Cras vel lorem.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </d");
            WriteLiteral("iv>\r\n    </section>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591