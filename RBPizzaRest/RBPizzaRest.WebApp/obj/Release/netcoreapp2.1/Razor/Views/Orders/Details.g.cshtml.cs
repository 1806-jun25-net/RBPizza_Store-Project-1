#pragma checksum "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6113eef9db6b4e1eb008e72fdde18c83020e8cb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(AspNetCore.Views_Orders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6113eef9db6b4e1eb008e72fdde18c83020e8cb0", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"612f32a7ffcbe65010fc980f0f8be12fea5ade26", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RBPizzaRest.DataAccess.Orders>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Orders</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 47, false);
#line 13 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderNumber));

#line default
#line hidden
            EndContext();
            BeginContext(249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(293, 43, false);
#line 16 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderNumber));

#line default
#line hidden
            EndContext();
            BeginContext(336, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(380, 48, false);
#line 19 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(428, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(472, 44, false);
#line 22 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(560, 52, false);
#line 25 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerLastname));

#line default
#line hidden
            EndContext();
            BeginContext(612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(656, 48, false);
#line 28 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerLastname));

#line default
#line hidden
            EndContext();
            BeginContext(704, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(748, 48, false);
#line 31 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderLocaton));

#line default
#line hidden
            EndContext();
            BeginContext(796, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(840, 44, false);
#line 34 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderLocaton));

#line default
#line hidden
            EndContext();
            BeginContext(884, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(928, 46, false);
#line 37 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PizzaPrice));

#line default
#line hidden
            EndContext();
            BeginContext(974, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1018, 42, false);
#line 40 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.PizzaPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1104, 47, false);
#line 43 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PizzaFprice));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1195, 43, false);
#line 46 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.PizzaFprice));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1282, 45, false);
#line 49 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1371, 41, false);
#line 52 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1456, 45, false);
#line 55 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1545, 41, false);
#line 58 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1630, 55, false);
#line 61 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerPhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1729, 51, false);
#line 64 "D:\Revature\RBPizza_Store-Project-1\RBPizzaRest\RBPizzaRest.WebApp\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerPhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1827, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "201e70f277f94483a4c2e48feec4064f", async() => {
                BeginContext(1849, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1865, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RBPizzaRest.DataAccess.Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591
