#pragma checksum "C:\Users\LapStore\source\с#project\FirstWebapplication\FirstWebapplication\views\Order\Complete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "269ad06fd13c774e68c8fc1ead626d4e99a3dba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_Order_Complete), @"mvc.1.0.view", @"/views/Order/Complete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/views/Order/Complete.cshtml", typeof(AspNetCore.views_Order_Complete))]
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
#line 1 "C:\Users\LapStore\source\с#project\FirstWebapplication\FirstWebapplication\views\Order\Complete.cshtml"
using FirstWebapplication.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269ad06fd13c774e68c8fc1ead626d4e99a3dba1", @"/views/Order/Complete.cshtml")]
    public class views_Order_Complete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(47, 15, false);
#line 3 "C:\Users\LapStore\source\с#project\FirstWebapplication\FirstWebapplication\views\Order\Complete.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(62, 5, true);
            WriteLiteral("</h3>");
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
