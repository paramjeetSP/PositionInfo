#pragma checksum "D:\ResourceInfo\PositionInfo\Views\Admin\_EmpLeaves.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c55081df7c134aac3a0fc93c183603f0ac7b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__EmpLeaves), @"mvc.1.0.view", @"/Views/Admin/_EmpLeaves.cshtml")]
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
#line 1 "D:\ResourceInfo\PositionInfo\Views\_ViewImports.cshtml"
using PositionInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ResourceInfo\PositionInfo\Views\_ViewImports.cshtml"
using PositionInfo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c55081df7c134aac3a0fc93c183603f0ac7b7b", @"/Views/Admin/_EmpLeaves.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07171f48f5a04807106fd3f9c0a4f960584bc4c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__EmpLeaves : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PositionInfo.Models.SpModels.PendingLeaves>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-sm-3\">\r\n    <div class=\"d--box\">\r\n        <h2>Total Leaves Left</h2>\r\n        <h3>");
#nullable restore
#line 6 "D:\ResourceInfo\PositionInfo\Views\Admin\_EmpLeaves.cshtml"
       Write(Model.TotalLeavesLeft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n<div class=\"col-sm-3\">\r\n    <div class=\"d--box\">\r\n        <h2>Sick Leaves Left</h2>\r\n        <h3>");
#nullable restore
#line 12 "D:\ResourceInfo\PositionInfo\Views\Admin\_EmpLeaves.cshtml"
       Write(Model.SickLeavesLeft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n<div class=\"col-sm-3\">\r\n    <div class=\"d--box\">\r\n        <h2>Casual Leaves Left</h2>\r\n        <h3>");
#nullable restore
#line 18 "D:\ResourceInfo\PositionInfo\Views\Admin\_EmpLeaves.cshtml"
       Write(Model.CasualLeavesLeft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n<div class=\"col-sm-3\">\r\n    <div class=\"d--box\">\r\n        <h2>Earned Leaves Left</h2>\r\n        <h3>");
#nullable restore
#line 24 "D:\ResourceInfo\PositionInfo\Views\Admin\_EmpLeaves.cshtml"
       Write(Model.PaidLeavesLeft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n<div class=\"col-sm-12\">\r\n    <div class=\"d--box\">\r\n        <div id=\"container\" style=\"min-width: 310px; height: 400px; max-width: 600px; margin: 0 auto\"></div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PositionInfo.Models.SpModels.PendingLeaves> Html { get; private set; }
    }
}
#pragma warning restore 1591
