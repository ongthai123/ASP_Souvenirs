#pragma checksum "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fdb52e5efe7f087f88b25ccfd18c05ff15fd2f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShoppingCartViewModel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShoppingCartViewModel/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ShoppingCartViewModel/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ShoppingCartViewModel_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdb52e5efe7f087f88b25ccfd18c05ff15fd2f4", @"/Views/Shared/Components/ShoppingCartViewModel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39e01d037c4a2e8903dbc500794452ebb348c98", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShoppingCartViewModel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_Souvenirs.Models.ShoppingCartViewModel.ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderBags", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-danger btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClearCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-warning btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
  
    ViewData["Title"] = "Default";

    var cartCount = 0;
    foreach (var item in Model.CartItems)
    {
        cartCount += item.ItemCount;
    }

#line default
#line hidden
            BeginContext(239, 106, true);
            WriteLiteral("\r\n<a id=\"cart-icon\"><span class=\"fa fa-shopping-cart\"></span>&nbsp;Shopping Cart&nbsp;<span class=\"badge\">");
            EndContext();
            BeginContext(346, 9, false);
#line 13 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                                                                                                   Write(cartCount);

#line default
#line hidden
            EndContext();
            BeginContext(355, 185, true);
            WriteLiteral("</span></a>\r\n\r\n<div class=\"cart-container\" style=\"color: grey; display: none;\">\r\n\r\n    <h4 style=\"color:#FF662F;\"><span class=\"fa fa-shopping-cart\"></span>&nbsp;Shopping Cart</h4>\r\n\r\n\r\n");
            EndContext();
#line 20 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
     if (@Model.CartItems.Count > 0)
    {

#line default
#line hidden
            BeginContext(585, 242, true);
            WriteLiteral("        <table class=\"table cartTable\">\r\n            <tr>\r\n                <th>ITEMS</th>\r\n                <th>CATEGORY</th>\r\n                <th>PRICE</th>\r\n                <th>QTY</th>\r\n                <th>SUBTOTAL</th>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
             foreach (var item in Model.CartItems)
            {
                var Subtotal = item.Souvenir.Price * item.ItemCount;

#line default
#line hidden
            BeginContext(964, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1010, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9940a6fe86bc4f7788385cb0ee54b297", async() => {
                BeginContext(1103, 24, false);
#line 34 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                                                                                                               Write(item.Souvenir.SouvenirID);

#line default
#line hidden
                EndContext();
                BeginContext(1127, 2, true);
                WriteLiteral(". ");
                EndContext();
                BeginContext(1130, 18, false);
#line 34 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                                                                                                                                          Write(item.Souvenir.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                                                                             WriteLiteral(item.Souvenir.SouvenirID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1152, 32, true);
            WriteLiteral(" </td>\r\n                    <td>");
            EndContext();
            BeginContext(1185, 27, false);
#line 35 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                   Write(item.Souvenir.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1212, 32, true);
            WriteLiteral("</td>\r\n                    <td>$");
            EndContext();
            BeginContext(1245, 19, false);
#line 36 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                    Write(item.Souvenir.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1264, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1296, 14, false);
#line 37 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                   Write(item.ItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(1310, 9, true);
            WriteLiteral("         ");
            EndContext();
            BeginContext(1319, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac059e5858154443a057d1ea7427e6ed", async() => {
                BeginContext(1421, 33, true);
                WriteLiteral("<span class=\"fa fa-trash\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                                                                                                               WriteLiteral(item.Souvenir.SouvenirID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1458, 32, true);
            WriteLiteral("</td>\r\n                    <td>$");
            EndContext();
            BeginContext(1491, 8, false);
#line 38 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                    Write(Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1544, 158, true);
            WriteLiteral("\r\n            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td>SUBTOTAL:</td>\r\n                <td>$");
            EndContext();
            BeginContext(1703, 14, false);
#line 47 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                Write(Model.SubTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1717, 183, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td>GST (15%):</td>\r\n                <td>$");
            EndContext();
            BeginContext(1901, 24, false);
#line 54 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                Write(Math.Round(Model.GST, 2));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 195, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td><b>GRAND TOTAL:</b></td>\r\n                <td><b>$");
            EndContext();
            BeginContext(2121, 31, false);
#line 61 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
                   Write(Math.Round(Model.GrandTotal, 2));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 134, true);
            WriteLiteral("</b></td>\r\n            </tr>\r\n        </table>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-offset-7\">\r\n                ");
            EndContext();
            BeginContext(2286, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8961d22fa21d4671a001996d4710f8a8", async() => {
                BeginContext(2386, 84, true);
                WriteLiteral("\r\n                    Clear Cart <span class=\"fa fa-trash\"></span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2474, 36, true);
            WriteLiteral("\r\n                \r\n                ");
            EndContext();
            BeginContext(2510, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf7c5fbf4c984e03a7b21d0f67115567", async() => {
                BeginContext(2602, 106, true);
                WriteLiteral("\r\n                    Checkout&nbsp;<i class=\"fa fa-credit-card\" aria-hidden=\"true\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2712, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
            EndContext();
#line 76 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2790, 76, true);
            WriteLiteral("        <hr />\r\n        <h4>You have no items in your shopping cart. </h4>\r\n");
            EndContext();
#line 81 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Shared\Components\ShoppingCartViewModel\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(2873, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_Souvenirs.Models.ShoppingCartViewModel.ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
