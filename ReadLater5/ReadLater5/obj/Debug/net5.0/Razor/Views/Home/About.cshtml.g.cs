#pragma checksum "D:\SARA DOKUMENTI\Documents\ReadLater5-master\ReadLater5\ReadLater5\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c0a830692fd44ec6429027fb7c3ae558dfb3572"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c0a830692fd44ec6429027fb7c3ae558dfb3572", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347f53252b2806261dfb06daee962882bfff3bea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<hgroup class=""title"">
    <h1>About Read Later</h1>
</hgroup>

<article>
    <h3>Overview</h3>
    <p>
        Read Later is a fictional service designed to allow users to bookmark webpages they want to read later.  It has been designed to follow general good practices within
        coding and to test your knowledge of these.  Thesolution uses a multi tiered approach, with POCO entities being used to represent objects in the system and a service layer to handle all functionality.
    </p>

    <h3>Visual Studio 2019 solution</h3>
    <p>
        The solution consists of 4 projects:
    </p>
    <ul>
        <li>
            <h5>Data</h5>
            The data project handles the communication with the database and is using Entity Framework (Code first approach).
            Migrations are enabled already - to initialise your database you will need to enter a connection string to Sql Server in appsettings.json, then in package manager console ensure that Data is the selected project and
            enter the ");
            WriteLiteral(@"command update-database.  this will create the database (if it is not there already), and generate the tables based on the existing entities.
        </li>
        <li>
            <h5>Entities</h5>
            The Entities project contains the <a href=""http://en.wikipedia.org/wiki/Plain_Old_CLR_Object"" target=""_BLANK"">POCO</a> classes that represent the system objects. 
        </li>       
        <li>
            <h5>Services</h5>
            Services expose the functionality to the UI layer.
        </li>
        <li>
            <h5>MVC</h5>
            The web layer is an .net core 5 MVC project using the standard templates provided.  It uses standard .net core 5 Dependency Injection 
        </li>
    </ul>

    <h3>Quick Start</h3>
    <ol>
        <li>Open solution in Visual Studio 2019</li>
        <li>Update the connection string in appsettings.json to point to a Sql Server / Sql Server Express instance (no need to create a database)</li>
        <li>In Package Manager Console, ensure the Data proj");
            WriteLiteral(@"ect is selected and run the command 'update-database'</li>
        <li>Your database will be created if necessary, and the tables created</li>
    </ol>

</article>

<aside>
    <h3>Questions?</h3>
    <p>
        If you have any questions or need any further information, please email rob@sopro.io
    </p>
</aside>");
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
