#pragma checksum "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4931b939fc9dfdb4de62fbe0a36f2d6f8f44d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_categorypage), @"mvc.1.0.view", @"/Views/Home/categorypage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/categorypage.cshtml", typeof(AspNetCore.Views_Home_categorypage))]
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
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/_ViewImports.cshtml"
using productsncategories;

#line default
#line hidden
#line 2 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/_ViewImports.cshtml"
using productsncategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4931b939fc9dfdb4de62fbe0a36f2d6f8f44d26", @"/Views/Home/categorypage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32fbb7a97ee35c96bdb9648167c6bc270cfda5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_categorypage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(62, 65, true);
            WriteLiteral("\r\n<div class=\"jumbotron text-center\">\r\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(128, 18, false);
#line 7 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
                     Write(Model.categoryname);

#line default
#line hidden
            EndContext();
            BeginContext(146, 43, true);
            WriteLiteral("</h1>\r\n</div>\r\n<h2>Products:</h2>\r\n<ul>\r\n\r\n");
            EndContext();
#line 12 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
     foreach(Association p in @Model.productsincategory) 
    {

#line default
#line hidden
            BeginContext(255, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 269, "\"", 309, 2);
            WriteAttributeValue("", 276, "/products/", 276, 10, true);
#line 14 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
WriteAttributeValue("", 286, p.navproduct.productID, 286, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(310, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(312, 24, false);
#line 14 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
                                                   Write(p.navproduct.productname);

#line default
#line hidden
            EndContext();
            BeginContext(336, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 15 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"

    }

#line default
#line hidden
            BeginContext(356, 32, true);
            WriteLiteral("</ul>\r\n\r\n<h2>Add Product:</h2>\r\n");
            EndContext();
            BeginContext(388, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4931b939fc9dfdb4de62fbe0a36f2d6f8f44d266008", async() => {
                BeginContext(449, 54, true);
                WriteLiteral("\r\n    <select name=\"productID\" class=\"form-control\">\r\n");
                EndContext();
#line 22 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
         foreach (var c in ViewBag.AllProducts)
        {

#line default
#line hidden
                BeginContext(563, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(575, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4931b939fc9dfdb4de62fbe0a36f2d6f8f44d266771", async() => {
                    BeginContext(605, 13, false);
#line 24 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
                                    Write(c.productname);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 24 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
               WriteLiteral(c.productID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(627, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
        }

#line default
#line hidden
                BeginContext(640, 66, true);
                WriteLiteral("    </select>\r\n    <input class=\"btn btn-primary\" type=\"submit\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 402, "/category/", 402, 10, true);
#line 20 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categorypage.cshtml"
AddHtmlAttributeValue("", 412, Model.categoryID, 412, 17, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 429, "/add", 429, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(713, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
