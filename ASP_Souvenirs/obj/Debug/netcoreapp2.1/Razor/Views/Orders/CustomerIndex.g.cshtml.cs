#pragma checksum "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1019ccf8d7a7065c6164157be2e1b9ce3c7c8385"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_CustomerIndex), @"mvc.1.0.view", @"/Views/Orders/CustomerIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/CustomerIndex.cshtml", typeof(AspNetCore.Views_Orders_CustomerIndex))]
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
#line 2 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1019ccf8d7a7065c6164157be2e1b9ce3c7c8385", @"/Views/Orders/CustomerIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39e01d037c4a2e8903dbc500794452ebb348c98", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_CustomerIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP_Souvenirs.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
  
    ViewData["Title"] = "Order List";

#line default
#line hidden
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(238, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
  var user = UserManager.GetUserAsync(User).Result;

#line default
#line hidden
            BeginContext(294, 25, true);
            WriteLiteral("\r\n<h2>Order List</h2>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
 if (Model.Count() < 1)
{

#line default
#line hidden
            BeginContext(347, 46, true);
            WriteLiteral("    <hr />\r\n    <h3>You have no orders.</h3>\r\n");
            EndContext();
#line 18 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(407, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(512, 43, false);
#line 26 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(555, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(623, 40, false);
#line 29 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(663, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(731, 44, false);
#line 32 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
               Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(775, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(843, 39, false);
#line 35 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
               Write(Html.DisplayNameFor(model => model.GST));

#line default
#line hidden
            EndContext();
            BeginContext(882, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(950, 46, false);
#line 38 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
               Write(Html.DisplayNameFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(996, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1064, 47, false);
#line 41 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
             foreach (var item in Model)
            {
                if (item.User.Id == user.Id)
                {

#line default
#line hidden
            BeginContext(1339, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1424, 42, false);
#line 53 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1558, 39, false);
#line 56 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1689, 43, false);
#line 59 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SubTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1824, 38, false);
#line 62 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.GST));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1954, 45, false);
#line 65 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1999, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2091, 46, false);
#line 68 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2137, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2228, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "553e2051bb9b476e81dba5458aa7d5f1", async() => {
                BeginContext(2289, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
                                                              WriteLiteral(item.OrderID);

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
            BeginContext(2300, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 74 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2394, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 78 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Orders\CustomerIndex.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP_Souvenirs.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
