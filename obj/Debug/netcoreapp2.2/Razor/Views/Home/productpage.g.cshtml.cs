#pragma checksum "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b920b85ec9191fa8b76d700e301b33f5ef5de5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_productpage), @"mvc.1.0.view", @"/Views/Home/productpage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/productpage.cshtml", typeof(AspNetCore.Views_Home_productpage))]
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
#line 4 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
using productsncategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b920b85ec9191fa8b76d700e301b33f5ef5de5e", @"/Views/Home/productpage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32fbb7a97ee35c96bdb9648167c6bc270cfda5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_productpage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
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
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(91, 63, true);
            WriteLiteral("\n<div class=\"jumbotron text-center\">\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(155, 17, false);
#line 8 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
                     Write(Model.productname);

#line default
#line hidden
            EndContext();
            BeginContext(172, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(174, 11, false);
#line 8 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
                                        Write(Model.price);

#line default
#line hidden
            EndContext();
            BeginContext(185, 48, true);
            WriteLiteral("</h1>\n</div>\n<h2>Product categories:</h2>\n<ul>\n\n");
            EndContext();
#line 13 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
     foreach(Association c in @Model.categoriesofproduct) 
    {

#line default
#line hidden
            BeginContext(298, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 312, "\"", 354, 2);
            WriteAttributeValue("", 319, "/category/", 319, 10, true);
#line 15 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
WriteAttributeValue("", 329, c.navcategory.categoryID, 329, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(355, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(357, 26, false);
#line 15 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
                                                     Write(c.navcategory.categoryname);

#line default
#line hidden
            EndContext();
            BeginContext(383, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 16 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"

    }

#line default
#line hidden
            BeginContext(400, 33, true);
            WriteLiteral("</ul>\n\n<h2>Add to Category:</h2>\n");
            EndContext();
            BeginContext(433, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b920b85ec9191fa8b76d700e301b33f5ef5de5e6360", async() => {
                BeginContext(493, 53, true);
                WriteLiteral("\n    <select name=\"categoryID\" class=\"form-control\">\n");
                EndContext();
#line 23 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
         foreach (var p in ViewBag.allcategories)
        {

#line default
#line hidden
                BeginContext(606, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(618, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b920b85ec9191fa8b76d700e301b33f5ef5de5e7119", async() => {
                    BeginContext(649, 14, false);
#line 25 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
                                     Write(p.categoryname);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 25 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
               WriteLiteral(p.categoryID);

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
                BeginContext(672, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 26 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
        }

#line default
#line hidden
                BeginContext(683, 64, true);
                WriteLiteral("    </select>\n    <input class=\"btn btn-primary\" type=\"submit\">\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 447, "/products/", 447, 10, true);
#line 21 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/productpage.cshtml"
AddHtmlAttributeValue("", 457, Model.productID, 457, 16, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 473, "/add", 473, 4, true);
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
