#pragma checksum "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e993cba94d5fb173e95fdb705cb5901e03968657"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sold_SDetails), @"mvc.1.0.view", @"/Views/Sold/SDetails.cshtml")]
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
#line 1 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\_ViewImports.cshtml"
using Demo_Project_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\_ViewImports.cshtml"
using Demo_Project_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e993cba94d5fb173e95fdb705cb5901e03968657", @"/Views/Sold/SDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4021f13b61d069e7a026ba81a07073521603596e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sold_SDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo_Project_MVC.Models.Sold>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
  
    ViewBag.Title = "SDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>SDetails</h2>\r\n\r\n<div>\r\n    <h4>Sold</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
       Write(Html.DisplayFor(model => model.SName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SQunt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
       Write(Html.DisplayFor(model => model.SQunt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 30 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 34 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
       Write(Html.DisplayFor(model => model.SDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
#nullable restore
#line 40 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
Write(Html.ActionLink("Edit", "SEdit", "Sold", new { id = Model.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 41 "G:\WAD Project\Demo_Project_MVC\Demo_Project_MVC\Views\Sold\SDetails.cshtml"
Write(Html.ActionLink("Cancel", "DisplaySold", "Sold", new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo_Project_MVC.Models.Sold> Html { get; private set; }
    }
}
#pragma warning restore 1591
