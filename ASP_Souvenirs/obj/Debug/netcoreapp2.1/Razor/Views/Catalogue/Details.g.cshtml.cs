#pragma checksum "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "729b6e69eb8d75cb4b4351b70c99e2e8eddaba25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_Details), @"mvc.1.0.view", @"/Views/Catalogue/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogue/Details.cshtml", typeof(AspNetCore.Views_Catalogue_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729b6e69eb8d75cb4b4351b70c99e2e8eddaba25", @"/Views/Catalogue/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39e01d037c4a2e8903dbc500794452ebb348c98", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogue_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_Souvenirs.Models.Souvenir>
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Souvenir</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(206, 40, false);
#line 14 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(246, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(290, 36, false);
#line 17 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(326, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(370, 47, false);
#line 20 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(417, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(461, 43, false);
#line 23 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(548, 41, false);
#line 26 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(589, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(633, 37, false);
#line 29 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(670, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(714, 46, false);
#line 32 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PathOfFile));

#line default
#line hidden
            EndContext();
            BeginContext(760, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
            BeginContext(852, 65, true);
            WriteLiteral("            <img class=\"img-responsive\" style=\"max-width: 150px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 917, "\"", 973, 1);
#line 36 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
WriteAttributeValue("", 923, Url.Content("~/images/items/" + Model.PathOfFile), 923, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(974, 51, true);
            WriteLiteral(" alt=\"\">\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1026, 44, false);
#line 39 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1114, 53, false);
#line 42 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayFor(model => model.Supplier.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1211, 44, false);
#line 45 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1299, 45, false);
#line 48 "C:\Users\Thai\Desktop\ASP_Souvenirs\ASP_Souvenirs\Views\Catalogue\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 43, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
            BeginContext(1461, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1465, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47aecb6cbdc54a60a99103581a7cecd0", async() => {
                BeginContext(1487, 12, true);
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
            BeginContext(1503, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_Souvenirs.Models.Souvenir> Html { get; private set; }
    }
}
#pragma warning restore 1591
