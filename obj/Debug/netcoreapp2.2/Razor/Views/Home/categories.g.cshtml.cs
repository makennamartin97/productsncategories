#pragma checksum "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ce98d7778fbe62e019634032e127191d3e1fa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_categories), @"mvc.1.0.view", @"/Views/Home/categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/categories.cshtml", typeof(AspNetCore.Views_Home_categories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ce98d7778fbe62e019634032e127191d3e1fa1", @"/Views/Home/categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32fbb7a97ee35c96bdb9648167c6bc270cfda5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("createcategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categories.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(58, 125, true);
            WriteLiteral("\n<a href=\"/products\">Products |</a><a href=\"/categories\"> Categories</a>\n\n<h1>New Category</h1>\n<div class=\"form-group\">\n    ");
            EndContext();
            BeginContext(183, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34ce98d7778fbe62e019634032e127191d3e1fa14351", async() => {
                BeginContext(227, 173, true);
                WriteLiteral("\n        <label>Name:</label>\n        <input type=\"text\" name= \"categoryname\" class=\"form-control\">\n        <input type=\"submit\" class=\"btn btn-danger\" value=\"Submit\">\n\n    ");
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
            BeginContext(407, 76, true);
            WriteLiteral("\n</div>\n\n<div class=\"right\">\n    <h2>Existing Categories</h2>\n    <ul>\n    \n");
            EndContext();
#line 22 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categories.cshtml"
         foreach (Category c in ViewBag.allcategories)
        {

#line default
#line hidden
            BeginContext(548, 18, true);
            WriteLiteral("            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 566, "\"", 596, 2);
            WriteAttributeValue("", 573, "/category/", 573, 10, true);
#line 24 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categories.cshtml"
WriteAttributeValue("", 583, c.categoryID, 583, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(597, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(599, 14, false);
#line 24 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categories.cshtml"
                                             Write(c.categoryname);

#line default
#line hidden
            EndContext();
            BeginContext(613, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 25 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/productsncategories/Views/Home/categories.cshtml"
        }

#line default
#line hidden
            BeginContext(633, 16, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
