#pragma checksum "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eec0d5d048b5157995c7045527a0d7215305b91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookmark_Edit), @"mvc.1.0.view", @"/Views/Bookmark/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eec0d5d048b5157995c7045527a0d7215305b91", @"/Views/Bookmark/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347f53252b2806261dfb06daee962882bfff3bea", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookmark_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entity.BookmarkCreateUpdateView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
   ViewBag.Title = "Edit"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Edit</h2>\n\n");
#nullable restore
#line 7 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-horizontal\">\n                    <h4>Bookmark</h4>\n                    <hr />\n                    ");
#nullable restore
#line 14 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 16 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Bookmark.URL, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 18 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                       Write(Html.EditorFor(model => model.Bookmark.URL, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 19 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Bookmark.URL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                    <hr />\n                    ");
#nullable restore
#line 23 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 25 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Bookmark.CategoryId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 27 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                       Write(Html.DropDownListFor(m => m.Bookmark.CategoryId,
                                                         Model.CategoryList.Select(m => new SelectListItem
                                                         {
                                                             Value = m.ID.ToString(),
                                                             Text = m.Name
                                                         }),
                                                         new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 34 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Bookmark.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 38 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Bookmark.ShortDescription, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 40 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                       Write(Html.TextAreaFor(model => model.Bookmark.ShortDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 41 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Bookmark.URL, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" value=""Create"" class=""btn btn-default"" />
                        </div>
                    </div>
                </div>");
#nullable restore
#line 50 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 53 "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Bookmark\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entity.BookmarkCreateUpdateView> Html { get; private set; }
    }
}
#pragma warning restore 1591
