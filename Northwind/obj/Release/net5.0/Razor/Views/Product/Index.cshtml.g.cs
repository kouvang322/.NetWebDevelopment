#pragma checksum "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aa54fcd5542dcff5c61ebe1f6cce6c9279faf4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Product.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace Northwind.Views.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml"
using Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa54fcd5542dcff5c61ebe1f6cce6c9279faf4e", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70bf1df53b33fea91dda06fa7f9b47512c91048", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Product Name</th>\r\n            <th scope=\"col\">Unit Price</th>\r\n            <th scope=\"col\">Units in Stock</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml"
         foreach (Product product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml"
           Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml"
           Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml"
           Write(product.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <!-- <a asp-action=\"\" asp-route-id=\"");
#nullable restore
#line 19 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml"
                                           Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 19 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml"
                                                               Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> -->\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591