#pragma checksum "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Discount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcb3e9814369eb8eca9366e5a6169d12f0522300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Product.Views_Product_Discount), @"mvc.1.0.view", @"/Views/Product/Discount.cshtml")]
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
#line 1 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Discount.cshtml"
using Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb3e9814369eb8eca9366e5a6169d12f0522300", @"/Views/Product/Discount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70bf1df53b33fea91dda06fa7f9b47512c91048", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Discount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Discount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h3>Current Discounts</h3>\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 6 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Discount.cshtml"
         foreach (Discount discount in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">\r\n                <strong>");
#nullable restore
#line 9 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Discount.cshtml"
                   Write(discount.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> - ");
#nullable restore
#line 9 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Discount.cshtml"
                                              Write(discount.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | <strong>Expires: ");
#nullable restore
#line 9 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Discount.cshtml"
                                                                                       Write(discount.EndTime.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Code: ");
#nullable restore
#line 9 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Discount.cshtml"
                                                                                                                                        Write(discount.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>\r\n            </li>\r\n");
#nullable restore
#line 11 "C:\Users\Kouva\Repo\WCTC\.NetWebDevelopment\Northwind\Views\Product\Discount.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Discount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
