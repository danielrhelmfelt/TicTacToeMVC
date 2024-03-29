#pragma checksum "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5ab3550a01607e1099bcf002aec5c09bde57fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\_ViewImports.cshtml"
using MvcTicTacToe;

#line default
#line hidden
#line 2 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\_ViewImports.cshtml"
using MvcTicTacToe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5ab3550a01607e1099bcf002aec5c09bde57fa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a293647c6d134b0e50be1893b03506e835f1e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "O", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "X", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StartNewGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    ViewData["Selection"] = "Select player: ";
    ViewData["FirstMove"] = "Starting move: ";
    ViewData["Padding"] = "20px";

#line default
#line hidden
            BeginContext(176, 26, true);
            WriteLiteral("\r\n<div class=\"text-center\"");
            EndContext();
            BeginWriteAttribute("style", " style=\'", 202, "\'", 238, 2);
            WriteAttributeValue("", 210, "padding:", 210, 8, true);
#line 8 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml"
WriteAttributeValue("", 218, ViewData["Padding"], 218, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(239, 11, true);
            WriteLiteral(">\r\n    <h1>");
            EndContext();
            BeginContext(251, 17, false);
#line 9 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(268, 50, true);
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"container-fluid\">\r\n    ");
            EndContext();
            BeginContext(318, 996, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5ab3550a01607e1099bcf002aec5c09bde57fa6058", async() => {
                BeginContext(385, 26, true);
                WriteLiteral("\r\n        <div class=\"row\"");
                EndContext();
                BeginWriteAttribute("style", " style=\'", 411, "\'", 447, 2);
                WriteAttributeValue("", 419, "padding:", 419, 8, true);
#line 13 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml"
WriteAttributeValue("", 427, ViewData["Padding"], 427, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(448, 79, true);
                WriteLiteral(">\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"text-right\">");
                EndContext();
                BeginContext(528, 21, false);
#line 15 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml"
                                   Write(ViewData["Selection"]);

#line default
#line hidden
                EndContext();
                BeginContext(549, 132, true);
                WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <select name=\"selectedPlayer\">\r\n                    ");
                EndContext();
                BeginContext(681, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5ab3550a01607e1099bcf002aec5c09bde57fa7546", async() => {
                    BeginContext(699, 1, true);
                    WriteLiteral("O");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(709, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(731, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5ab3550a01607e1099bcf002aec5c09bde57fa9023", async() => {
                    BeginContext(749, 1, true);
                    WriteLiteral("X");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(759, 89, true);
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\"");
                EndContext();
                BeginWriteAttribute("style", " style=\'", 848, "\'", 884, 2);
                WriteAttributeValue("", 856, "padding:", 856, 8, true);
#line 24 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml"
WriteAttributeValue("", 864, ViewData["Padding"], 864, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(885, 79, true);
                WriteLiteral(">\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"text-right\">");
                EndContext();
                BeginContext(965, 21, false);
#line 26 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml"
                                   Write(ViewData["FirstMove"]);

#line default
#line hidden
                EndContext();
                BeginContext(986, 206, true);
                WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <input type=\"checkbox\" name=\"startingMove\" value=\"true\">\r\n            </div>\r\n        </div>\r\n        <div class=\"text-center\"");
                EndContext();
                BeginWriteAttribute("style", " style=\'", 1192, "\'", 1228, 2);
                WriteAttributeValue("", 1200, "padding:", 1200, 8, true);
#line 32 "c:\Users\USER\Documents\GitHub\MvcTicTacToe\Views\Home\Index.cshtml"
WriteAttributeValue("", 1208, ViewData["Padding"], 1208, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1229, 78, true);
                WriteLiteral(">\r\n            <input type=\"submit\" value=\"Start Game\"/>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1314, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
