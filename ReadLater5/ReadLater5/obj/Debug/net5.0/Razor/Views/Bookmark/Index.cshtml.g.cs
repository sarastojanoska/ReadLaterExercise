#pragma checksum "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bdcc6182361625b4fc2b42198e55b67ef0fdf86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookmark_Index), @"mvc.1.0.view", @"/Views/Bookmark/Index.cshtml")]
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
#line 1 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\_ViewImports.cshtml"
using ReadLater5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\_ViewImports.cshtml"
using ReadLater5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bdcc6182361625b4fc2b42198e55b67ef0fdf86", @"/Views/Bookmark/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347f53252b2806261dfb06daee962882bfff3bea", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookmark_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entity.Bookmark>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
#nullable restore
#line 10 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <tr>\n        <th>\n            ");
#nullable restore
#line 15 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.URL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th></th>\n    </tr>\n\n");
#nullable restore
#line 20 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 24 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.URL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 27 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 28 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 29 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 32 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entity.Bookmark>> Html { get; private set; }
    }
}
#pragma warning restore 1591
