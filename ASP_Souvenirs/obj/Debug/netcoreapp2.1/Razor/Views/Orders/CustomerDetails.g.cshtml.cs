#pragma checksum "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ee04d3531668c1cea0230bf0202f6d6f5e1cef8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_CustomerDetails), @"mvc.1.0.view", @"/Views/Orders/CustomerDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/CustomerDetails.cshtml", typeof(AspNetCore.Views_Orders_CustomerDetails))]
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
#line 1 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\_ViewImports.cshtml"
using ASP_Souvenirs;

#line default
#line hidden
#line 2 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\_ViewImports.cshtml"
using ASP_Souvenirs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee04d3531668c1cea0230bf0202f6d6f5e1cef8", @"/Views/Orders/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39e01d037c4a2e8903dbc500794452ebb348c98", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_Souvenirs.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
  
    ViewData["Title"] = "Order Details";

#line default
#line hidden
            BeginContext(86, 111, true);
            WriteLiteral("\r\n<h2>Order Details</h2>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>");
            EndContext();
            BeginContext(198, 43, false);
#line 13 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(241, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(261, 39, false);
#line 14 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(300, 21, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>");
            EndContext();
            BeginContext(322, 40, false);
#line 16 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(362, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(382, 36, false);
#line 17 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(418, 52, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Order Status</dt>\r\n        <dd>");
            EndContext();
            BeginContext(471, 43, false);
#line 20 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.OrderStatus));

#line default
#line hidden
            EndContext();
            BeginContext(514, 49, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Full Name</dt>\r\n        <dd>");
            EndContext();
            BeginContext(564, 45, false);
#line 23 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(609, 21, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>");
            EndContext();
            BeginContext(631, 46, false);
#line 25 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(677, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(697, 42, false);
#line 26 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(739, 59, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Mobile Phone Number</dt>\r\n        <dd>");
            EndContext();
            BeginContext(799, 54, false);
#line 29 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.MobilePhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(853, 57, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Home Phone Number</dt>\r\n        <dd>");
            EndContext();
            BeginContext(911, 52, false);
#line 32 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.HomePhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(963, 57, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Work Phone Number</dt>\r\n        <dd>");
            EndContext();
            BeginContext(1021, 52, false);
#line 35 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.WorkPhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 21, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>");
            EndContext();
            BeginContext(1095, 48, false);
#line 37 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(1163, 44, false);
#line 38 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 220, true);
            WriteLiteral("</dd>\r\n    </dl>\r\n\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>ITEMS</th>\r\n            <th>CATEGORY</th>\r\n            <th>PRICE</th>\r\n            <th>QTY</th>\r\n            <th>SUBTOTAL</th>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
         foreach (var item in Model.OrderItems)
        {
            var Subtotal = item.Sourvenir.Price * item.Quantity;

#line default
#line hidden
            BeginContext(1553, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1614, 55, false);
#line 54 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sourvenir.SouvenirID));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 2, true);
            WriteLiteral(". ");
            EndContext();
            BeginContext(1672, 49, false);
#line 54 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Sourvenir.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1789, 58, false);
#line 57 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sourvenir.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1915, 50, false);
#line 60 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sourvenir.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2033, 43, false);
#line 63 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 68, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
            EndContext();
            BeginContext(2145, 8, false);
#line 66 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
                Write(Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(2153, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 69 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(2208, 124, true);
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>\r\n                <label>");
            EndContext();
            BeginContext(2333, 44, false);
#line 75 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 63, true);
            WriteLiteral("</label>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2441, 40, false);
#line 78 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
           Write(Html.DisplayFor(model => model.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2481, 232, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>\r\n                <label>GST (15%)</label>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2714, 35, false);
#line 89 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
           Write(Html.DisplayFor(model => model.GST));

#line default
#line hidden
            EndContext();
            BeginContext(2749, 160, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>\r\n                <label>");
            EndContext();
            BeginContext(2910, 46, false);
#line 97 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
                  Write(Html.DisplayNameFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2956, 63, true);
            WriteLiteral("</label>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3020, 42, false);
#line 100 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerDetails.cshtml"
           Write(Html.DisplayFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3062, 69, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3131, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7cad9154f94c91b250ddd321649719", async() => {
                BeginContext(3185, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3201, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_Souvenirs.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
