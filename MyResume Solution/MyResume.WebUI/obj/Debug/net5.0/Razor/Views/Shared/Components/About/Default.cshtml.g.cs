#pragma checksum "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d49e3554d0ae2e6e2551bad028a25f9b9d0f18e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_About_Default), @"mvc.1.0.view", @"/Views/Shared/Components/About/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d49e3554d0ae2e6e2551bad028a25f9b9d0f18e5", @"/Views/Shared/Components/About/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddce19b1e1012ef6db02c535ddb3f6e77303058e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_About_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<ul class=\"personal-info\">\r\n");
#nullable restore
#line 5 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
     foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <p> <span> Name</span>");
#nullable restore
#line 8 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p> <span> Age</span>");
#nullable restore
#line 11 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p>\r\n");
#nullable restore
#line 15 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                     if (@item.Location == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span></span>\r\n");
#nullable restore
#line 18 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span> Location</span>\r\n");
#nullable restore
#line 22 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
               Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n            </li>\r\n            <li>\r\n                <p> <span> Experience</span>");
#nullable restore
#line 29 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                       Write(item.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </li>\r\n            <li>\r\n                <p> <span> Degree</span> ");
#nullable restore
#line 32 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                    Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p> <span> Career Level</span>");
#nullable restore
#line 35 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                         Write(item.CareerLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p> <span> Phone</span>");
#nullable restore
#line 38 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                  Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p> <span> FAX</span>");
#nullable restore
#line 41 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                Write(item.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </li>\r\n            <li>\r\n                <p> <span> E-mail</span> <a href=\"#.\"></a> ");
#nullable restore
#line 44 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <li>\r\n                <p>\r\n");
#nullable restore
#line 48 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                     if (@item.Website == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span></span>\r\n");
#nullable restore
#line 51 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span> Website</span>\r\n");
#nullable restore
#line 55 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <a href=\"#.\"></a>");
#nullable restore
#line 57 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                Write(item.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </li>\r\n");
#nullable restore
#line 60 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
