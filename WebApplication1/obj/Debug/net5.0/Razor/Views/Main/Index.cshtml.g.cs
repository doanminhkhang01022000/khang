#pragma checksum "C:\Users\khang\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c54b74fbdb21d873d2c075dad45d6f5836aa6756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
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
#line 1 "C:\Users\khang\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebTinTuc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khang\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebTinTuc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54b74fbdb21d873d2c075dad45d6f5836aa6756", @"/Views/Main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc011d7db86dce61a5bccc5a0979ac88e484929c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\khang\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Main\Index.cshtml"
  
    Layout = "_CustomLayout";
    ViewData["Title"] = "Trang chủ";
    ViewData["hi"] = "hiiiii";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"p-5 alert-info text-center\">\r\n    <h1 class=\"display-5\">Quản Lý Nhân Viên</h1>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\khang\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Main\Index.cshtml"
  Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
</div>
<table class=""table table-warning"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Tên NV</th>
            <th scope=""col"">Mã số NV</th>
            <th scope=""col"">Tiền Lương</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>Doan Minh Khang</td>
            <td>191102009</td>
            <td>6.290.000 ₫ </td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>Trí</td>
            <td>191100057</td>
            <td>
                4.990.000 ₫
            </td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>Nha</td>
            <td>191100057</td>
            <td>
                5.990.000 ₫
            </td>
        </tr>
    </tbody>
</table>

");
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
