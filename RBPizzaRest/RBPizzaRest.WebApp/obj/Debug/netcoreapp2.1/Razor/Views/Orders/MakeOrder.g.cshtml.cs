#pragma checksum "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\MakeOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5988993678577ae8beee77c74b824fb4b587e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_MakeOrder), @"mvc.1.0.view", @"/Views/Orders/MakeOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/MakeOrder.cshtml", typeof(AspNetCore.Views_Orders_MakeOrder))]
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
#line 1 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\_ViewImports.cshtml"
using RBPizzaRest.WebApp;

#line default
#line hidden
#line 2 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\_ViewImports.cshtml"
using RBPizzaRest.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5988993678577ae8beee77c74b824fb4b587e7", @"/Views/Orders/MakeOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"612f32a7ffcbe65010fc980f0f8be12fea5ade26", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_MakeOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RBPizzaRest.WebApp.Models.MVPizza>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\MakeOrder.cshtml"
  

    ViewData["Title"] = "MakeOrder";

#line default
#line hidden
            BeginContext(91, 22, true);
            WriteLiteral("\r\n<h2>MakeOrder</h2>\r\n");
            EndContext();
            BeginContext(113, 1356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8588f099cd4e9cb2f9e171d6c6d62e", async() => {
                BeginContext(156, 40, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(197, 438, false);
#line 11 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\MakeOrder.cshtml"
   Write(Html.DropDownListFor(x => x.SelectedSize, new List<SelectListItem>
        {
              new SelectListItem() {Text = "Small   $5.00", Value = "Small"},
              new SelectListItem() {Text = "Medium  $10.00", Value = "Medium"},
              new SelectListItem() {Text = "Large   $15.00", Value = "Large"},
              new SelectListItem() {Text = "ExtraLarge   $20.00", Value = "ExtraLarge"},

        }, "Select A Size"));

#line default
#line hidden
                EndContext();
                BeginContext(635, 52, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(688, 337, false);
#line 21 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\MakeOrder.cshtml"
   Write(Html.DropDownListFor(x => x.SelectedTopping, new List<SelectListItem>
        {
              new SelectListItem() {Text = "Chicken", Value = "CHICKEN"},
              new SelectListItem() {Text = "Pepperoni", Value = "PEPPERONI"},
              new SelectListItem() {Text = "Bacon", Value = "BACON"},

        }, "Select A Sauce"));

#line default
#line hidden
                EndContext();
                BeginContext(1025, 52, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(1078, 248, false);
#line 30 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\MakeOrder.cshtml"
   Write(Html.DropDownListFor(x => x.SelectedCrust, new List<SelectListItem>
        {
              new SelectListItem() {Text = "Yes", Value = "True"},
              new SelectListItem() {Text = "No", Value = "False"},


        }, "Select A Crust"));

#line default
#line hidden
                EndContext();
                BeginContext(1326, 136, true);
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Add Pizzas\" class=\"btn btn-default\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1469, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1473, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "200b72791b0648c7b34e6c89586b988a", async() => {
                BeginContext(1500, 124, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Complete Order\" class=\"btn btn-default\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RBPizzaRest.WebApp.Models.MVPizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
