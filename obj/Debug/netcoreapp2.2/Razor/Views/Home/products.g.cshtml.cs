#pragma checksum "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0151d580fbf17a093d057923ad4ac6fe79d33fed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_products), @"mvc.1.0.view", @"/Views/Home/products.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/products.cshtml", typeof(AspNetCore.Views_Home_products))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0151d580fbf17a093d057923ad4ac6fe79d33fed", @"/Views/Home/products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32fbb7a97ee35c96bdb9648167c6bc270cfda5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("createproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/products.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(57, 124, true);
            WriteLiteral("\n<a href=\"/products\">Products |</a><a href=\"/categories\"> Categories</a>\n\n<h1>New Product</h1>\n<div class=\"form-group\">\n    ");
            EndContext();
            BeginContext(181, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0151d580fbf17a093d057923ad4ac6fe79d33fed4332", async() => {
                BeginContext(224, 267, true);
                WriteLiteral(@"
        <label>Name:</label>
        <input type=""text"" name= ""productname"" class=""form-control"">
        <label>Price:</label>
        <input type=""number"" name= ""price"" class=""form-control"">
        <input type=""submit"" class=""btn btn-danger"" value=""Submit"">

    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(498, 74, true);
            WriteLiteral("\n</div>\n\n<div class=\"right\">\n    <h2>Existing Products</h2>\n    <ul>\n    \n");
            EndContext();
#line 24 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/products.cshtml"
         foreach (Product p in ViewBag.allproducts)
        {

#line default
#line hidden
            BeginContext(634, 18, true);
            WriteLiteral("            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 652, "\"", 681, 2);
            WriteAttributeValue("", 659, "/products/", 659, 10, true);
#line 26 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/products.cshtml"
WriteAttributeValue("", 669, p.productID, 669, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(684, 13, false);
#line 26 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/products.cshtml"
                                            Write(p.productname);

#line default
#line hidden
            EndContext();
            BeginContext(697, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 27 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/products.cshtml"
        }

#line default
#line hidden
            BeginContext(717, 16, true);
            WriteLiteral("    </ul>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
