#pragma checksum "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e1ac8e89238ca6b98491360f7f4ae113ae53f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/List.cshtml", typeof(AspNetCore.Views_Cars_List))]
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
#line 1 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\_ViewImports.cshtml"
using ShopAppNew;

#line default
#line hidden
#line 2 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\_ViewImports.cshtml"
using ShopAppNew.Models;

#line default
#line hidden
#line 3 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\_ViewImports.cshtml"
using ShopAppNew.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e1ac8e89238ca6b98491360f7f4ae113ae53f1", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e438eb9a88a5791ceed723d19b66ba63971287d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 2 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\Cars\List.cshtml"
      
        foreach (var car in Model.allCars)
        {

#line default
#line hidden
            BeginContext(92, 78, true);
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 170, "\"", 184, 1);
#line 6 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\Cars\List.cshtml"
WriteAttributeValue("", 176, car.img, 176, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 185, "\"", 200, 1);
#line 6 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\Cars\List.cshtml"
WriteAttributeValue("", 191, car.name, 191, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(201, 34, true);
            WriteLiteral(" />\r\n                <h3>Событие: ");
            EndContext();
            BeginContext(236, 8, false);
#line 7 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\Cars\List.cshtml"
                        Write(car.name);

#line default
#line hidden
            EndContext();
            BeginContext(244, 44, true);
            WriteLiteral("</h3>\r\n                <p>Краткое описание: ");
            EndContext();
            BeginContext(289, 13, false);
#line 8 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\Cars\List.cshtml"
                                Write(car.shortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(302, 40, true);
            WriteLiteral("</p>\r\n                <p>Призовой фонд: ");
            EndContext();
            BeginContext(343, 23, false);
#line 9 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\Cars\List.cshtml"
                             Write(car.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(366, 102, true);
            WriteLiteral("</p>\r\n                <p><a class=\"btn\" btn-warning\" href=\"#\">Подробнее:</a></p>\r\n            </div>\r\n");
            EndContext();
#line 12 "D:\ASP\ShopAppNew\ShopAppNew\ShopAppNew\Views\Cars\List.cshtml"
        }
    

#line default
#line hidden
            BeginContext(486, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
