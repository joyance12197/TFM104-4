#pragma checksum "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca6d4b1e22b87a02121dae5546a4b98dfb15d056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\_ViewImports.cshtml"
using MVC_Project_220319;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\_ViewImports.cshtml"
using MVC_Project_220319.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6d4b1e22b87a02121dae5546a4b98dfb15d056", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b54b04578eefb517091c5ad5371312a0bc1bb502", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Project_220319.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
 foreach (var product in Model.Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h2>商品名稱： ");
#nullable restore
#line 15 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
             Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>商品價格： $");
#nullable restore
#line 16 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
              Write(product.OriginalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>商品敘述： ");
#nullable restore
#line 17 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
            Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>商品上架日： ");
#nullable restore
#line 18 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
             Write(product.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
 foreach (var orders in Model.Orders)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h2>訂購人姓名： ");
#nullable restore
#line 26 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
              Write(orders.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>購買日期： ");
#nullable restore
#line 27 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
            Write(orders.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\Tibame_T14\source\repos\MVC_Project_220319\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Project_220319.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591