#pragma checksum "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed8f474507db36cd174a07ef28026d25b549536c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\_ViewImports.cshtml"
using ST10090287_ProgPart2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\_ViewImports.cshtml"
using ST10090287_ProgPart2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed8f474507db36cd174a07ef28026d25b549536c", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ca7ffe70214f43b0b847dd5be63a69aacb7a4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ST10090287_ProgPart2.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .row {
        display: flex;
        flex-wrap: wrap;
        margin-bottom: 20px;
    }

    .col-sm-2,
    .col-sm-10 {
        padding: 10px;
        border: 1px solid #ccc;
    }

    .col-sm-2 {
        width: 20%;
    }

    .col-sm-10 {
        width: 80%;
    }
    .details-heading {
        color: #333;
        font-size: 24px;
        font-weight: bold;
        margin: 10px 0;
    }
</style>

<h1 class=""details-heading"">Details</h1>

<div>
    <h4>Product</h4>
    <hr />
    <dl class=""row"">
        <dt class = ""col-sm-2"">
            ");
#nullable restore
#line 41 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PRODUCT_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.PRODUCT_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PRODUCT_TYPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.PRODUCT_TYPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PRODUCT_PRICE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.PRODUCT_PRICE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PRODUCT_QTY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.PRODUCT_QTY));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FARMER_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.FARMER_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n   \r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1765, "\"", 1792, 1);
#nullable restore
#line 74 "C:\Users\jared\OneDrive\Documents\GitHub\prog7311-part2-JaredK17\ST10090287_ProgPart2\ST10090287_ProgPart2\Views\Product\Details.cshtml"
WriteAttributeValue("", 1772, Url.Action("Index"), 1772, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ST10090287_ProgPart2.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591