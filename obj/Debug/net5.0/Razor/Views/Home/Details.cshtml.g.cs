#pragma checksum "D:\Web\Mvc\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db8cc15cd88fcf62f6cb624a42fb53a9217f723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\Web\Mvc\Views\_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web\Mvc\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db8cc15cd88fcf62f6cb624a42fb53a9217f723", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e67f7a98a2817891154f669e23d998ddc23d1bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Models.ProductView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Web\Mvc\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Chi tiet san pham";
    var models = (List<ProductView>)ViewBag.products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Web\Mvc\Views\Home\Details.cshtml"
 if(Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class = \"test\">\r\n        <p>Chi tiet san pham</p>\r\n        <p>");
#nullable restore
#line 11 "D:\Web\Mvc\Views\Home\Details.cshtml"
      Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 12 "D:\Web\Mvc\Views\Home\Details.cshtml"
      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 14 "D:\Web\Mvc\Views\Home\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class = \"test\">\r\n        Not Found !!!\r\n    </div>\r\n");
#nullable restore
#line 20 "D:\Web\Mvc\Views\Home\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"test\">\r\n    <p>Danh sach san pham tuong tu</p>\r\n");
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Models.ProductView> Html { get; private set; }
    }
}
#pragma warning restore 1591
