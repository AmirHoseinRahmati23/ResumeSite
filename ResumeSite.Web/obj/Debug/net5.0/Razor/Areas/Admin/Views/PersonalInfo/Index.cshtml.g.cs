#pragma checksum "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aba9c0276a25744347b4079b056236835ab7437e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PersonalInfo_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/PersonalInfo/Index.cshtml")]
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
#line 1 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ResumeSite.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ResumeSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ResumeSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ResumeSite.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba9c0276a25744347b4079b056236835ab7437e", @"/Areas/Admin/Views/PersonalInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0559ada0777c20f0870bbb419657011d3b5d8301", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PersonalInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
  
    ViewData["Title"] = "?????????????? ????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>?????????????? ????????</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 15 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
         if (!string.IsNullOrEmpty(Model.Image))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-10 col-sm-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aba9c0276a25744347b4079b056236835ab7437e5879", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 388, "~/AdminImage/", 388, 13, true);
#nullable restore
#line 18 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
AddHtmlAttributeValue("", 401, Model.Image, 401, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 20 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Work));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayFor(model => model.Work));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Instagram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayFor(model => model.Instagram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Telegram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayFor(model => model.Telegram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Linkedin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayFor(model => model.Linkedin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayFor(model => model.Twitter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ResumeFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 67 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
         if (!string.IsNullOrEmpty(Model.ResumeFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba9c0276a25744347b4079b056236835ab7437e12847", async() => {
                WriteLiteral("???????????? ??????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2121, "~/ResumeFile/", 2121, 13, true);
#nullable restore
#line 70 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
AddHtmlAttributeValue("", 2134, Model.ResumeFile, 2134, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 72 "D:\Asp.netCore\ResumeSite\ResumeSite.Web\Areas\Admin\Views\PersonalInfo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba9c0276a25744347b4079b056236835ab7437e15058", async() => {
                WriteLiteral("????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
