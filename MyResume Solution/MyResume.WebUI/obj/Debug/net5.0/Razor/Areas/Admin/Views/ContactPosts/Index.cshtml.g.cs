#pragma checksum "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90cc7f6fe26dfda3143222184a601fe4ebd2abda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactPosts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactPosts/Index.cshtml")]
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
#line 3 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ResumeModel.Bio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ResumeModel.Experience;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Infracture;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90cc7f6fe26dfda3143222184a601fe4ebd2abda", @"/Areas/Admin/Views/ContactPosts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd3b8637dd8149de9c54feb27941a3dde6f5a1fc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ContactPosts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactPost>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Answer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.customize.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90cc7f6fe26dfda3143222184a601fe4ebd2abda8713", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"

    <div class=""page-wrapper"">
        <div class=""page-header"">
            <div class=""row align-items-end"">
                <div class=""col-lg-8"">
                    <div class=""page-header-title"">
                        <div class=""d-inline"">
                            <h4>Bootstrap Border Sizes</h4>
                            <span>
                                lorem ipsum dolor sit amet, consectetur adipisicing
                                elit
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""page-header-breadcrumb"">
                        <ul class=""breadcrumb-title"">
                            <li class=""breadcrumb-item"" style=""float: left;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90cc7f6fe26dfda3143222184a601fe4ebd2abda10833", async() => {
                WriteLiteral(" <i class=\"feather icon-home\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </li>

                            <li class=""breadcrumb-item"" style=""float: left;"">
                                <span>ContactPosts</span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""page-body"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5>Horizontal Borders</h5>
                    <span>
                        Example of <code>horizontal</code> table borders. This is a
                        default table border style attached to <code>.table</code> class.
                        All borders have the same grey color and style, table itself doesn't
                        have a border, but you can add this border using
                        <code>.table-framed</code> class added to the table with
                        <code>.table</code> class.
                    </span>
");
            WriteLiteral(@"
                </div>
                <div class=""card-block table-border-style"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 63 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 66 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 69 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 72 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 75 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.AnswerDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 80 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"ellipse\">\r\n                                        ");
#nullable restore
#line 84 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"ellipse\">\r\n                                        ");
#nullable restore
#line 87 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"ellipse\">\r\n                                        ");
#nullable restore
#line 90 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"ellipse\">\r\n                                        ");
#nullable restore
#line 93 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"ellipse \">\r\n                                        ");
#nullable restore
#line 96 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.AnswerDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"operations table-imaged\">\r\n");
#nullable restore
#line 99 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                     if(item.AnswerDate==null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90cc7f6fe26dfda3143222184a601fe4ebd2abda18821", async() => {
                WriteLiteral("Reply");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90cc7f6fe26dfda3143222184a601fe4ebd2abda21392", async() => {
                WriteLiteral("<i class=\"fa-solid fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4972, "\"", 5021, 6);
            WriteAttributeValue("", 4982, "removeEntity(", 4982, 13, true);
#nullable restore
#line 103 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
WriteAttributeValue("", 4995, item.Id, 4995, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5003, ",", 5003, 1, true);
            WriteAttributeValue(" ", 5004, "\'", 5005, 2, true);
#nullable restore
#line 103 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
WriteAttributeValue("", 5006, item.Subject, 5006, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5019, "\')", 5019, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-trash-can\"></i></a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 106 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 113 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90cc7f6fe26dfda3143222184a601fe4ebd2abda25567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90cc7f6fe26dfda3143222184a601fe4ebd2abda26667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90cc7f6fe26dfda3143222184a601fe4ebd2abda27767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script class=""removeable"">
        function removeEntity(id, name) {
            swal(`Are you sure you want to delete ${name}?`, {
                title: ""Diqqet!"",
                text: `Are you sure you want to delete ${name}?`,
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
                buttons: [""No"", ""Yes""]
            })
                .then((value) => {

                    if (value == true) {

                        let vToken = $('[name=__RequestVerificationToken]').val();

                        let formData = new FormData();
                        formData.set('__RequestVerificationToken', vToken);
                        formData.set('id', id);

                        $.ajax({
                            url: `");
#nullable restore
#line 142 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                             Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                            type: 'POST',
                            data: formData,
                            contentType: false,
                            processData: false,
                            success: function (response) {
                                console.log(response)
                                if (response.error == true) {
                                    toaster.error(response.message, ""Xeta"");
                                    showError(response.state);
                                    return;
                                }
                                toastr.success(response.message, ""Ugur!"");
                                location.reload();
                            },
                            error: function (errorResponse) {
                                console.error(errorResponse);
                            }
                        });
                    }


                });

        }

        function publishD");
                WriteLiteral(@"ate(id, name) {
            swal(`Are you sure you want to publish ${name}?`, {
                title: ""Diqqet!"",
                text: `Are you sure you want to publish ${name}?`,
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
                buttons: [""No"", ""Yes""]
            })
                .then((value) => {

                    if (value == true) {

                        let vToken = $('[name=__RequestVerificationToken]').val();

                        let formData = new FormData();
                        formData.set('__RequestVerificationToken', vToken);
                        formData.set('id', id);

                        $.ajax({
                            url: `");
#nullable restore
#line 188 "C:\Users\12345\Desktop\MyResume Solution\MyResume.WebUI\Areas\Admin\Views\ContactPosts\Index.cshtml"
                             Write(Url.Action("Publish"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                            type: 'POST',
                            data: formData,
                            contentType: false,
                            processData: false,
                            success: function (response) {
                                console.log(response)
                                if (response.error == true) {
                                    toaster.error(response.message, ""Xeta"");
                                    return;
                                }
                                toastr.success(response.message, ""Ugur!"");
                                //location.reload();
                            },
                            error: function (errorResponse) {
                                console.error(errorResponse);
                            }
                        });
                    }


                });

        }
    </script>
     ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactPost>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
