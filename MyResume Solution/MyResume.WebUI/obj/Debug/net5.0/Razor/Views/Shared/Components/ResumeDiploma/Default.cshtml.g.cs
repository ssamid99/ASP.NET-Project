#pragma checksum "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e9527a285ef8bba23b392605f7c6203a45927ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ResumeDiploma_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ResumeDiploma/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9527a285ef8bba23b392605f7c6203a45927ea", @"/Views/Shared/Components/ResumeDiploma/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddce19b1e1012ef6db02c535ddb3f6e77303058e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ResumeDiploma_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResumeDiploma>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"exp\">\r\n        <div class=\"media-left\">\r\n            <span class=\"sun\">");
#nullable restore
#line 7 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
                         Write(item.StartYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 7 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
                                         Write(item.EndYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"media-body\">\r\n            <!-- COmpany Logo -->\r\n            <div class=\"company-logo\">\r\n                <span class=\"diploma\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e9527a285ef8bba23b392605f7c6203a45927ea6018", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 389, "~/uploads/images/", 389, 17, true);
#nullable restore
#line 13 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
AddHtmlAttributeValue("", 406, item.ImagePath, 406, 15, false);

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
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n            <h6>");
#nullable restore
#line 16 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
           Write(item.UniversityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p>");
#nullable restore
#line 17 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
          Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 18 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
          Write(item.YearObtention);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"margin-top-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
           Write(item.Details.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\ResumeDiploma\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResumeDiploma>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
