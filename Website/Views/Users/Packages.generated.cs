﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Users
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NuGetGallery;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Users/Packages.cshtml")]
    public class Packages : System.Web.Mvc.WebViewPage<ManagePackagesViewModel>
    {

public System.Web.WebPages.HelperResult PrintPublishedPackages(IEnumerable<PackageViewModel> packages) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 67 "..\..\Views\Users\Packages.cshtml"
                                                                        

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, @"    <table class=""packages owned"">
        <thead class=""header"">
            <tr>
                <th>Package</th>
                <th>Package ID</th>
                <th>Downloads</th>
                <th class=""ownerActions"">Actions</th>
            </tr>
        </thead>
");



#line 77 "..\..\Views\Users\Packages.cshtml"
         foreach (var package in packages) {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            <tr>\r\n                <td>\r\n                    <strong><a href=\"");



#line 80 "..\..\Views\Users\Packages.cshtml"
      WriteTo(@__razor_helper_writer, Url.Package(package));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">");



#line 80 "..\..\Views\Users\Packages.cshtml"
                             WriteTo(@__razor_helper_writer, package.Title);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</a></strong>\r\n                    <p>");



#line 81 "..\..\Views\Users\Packages.cshtml"
WriteTo(@__razor_helper_writer, package.Description);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</p>\r\n                </td>\r\n                <td>");



#line 83 "..\..\Views\Users\Packages.cshtml"
WriteTo(@__razor_helper_writer, package.Id);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</td>\r\n                <td class=\"downloads\">");



#line 84 "..\..\Views\Users\Packages.cshtml"
       WriteTo(@__razor_helper_writer, package.DownloadCount);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</td>\r\n                <td class=\"ownerActions\">\r\n                    <ul>\r\n     " +
"                   <li>\r\n                            <a href=\"");



#line 88 "..\..\Views\Users\Packages.cshtml"
      WriteTo(@__razor_helper_writer, Url.EditPackage(package));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" title=\"Edit\" class=\"editPackageLink\"><img src=\"");



#line 88 "..\..\Views\Users\Packages.cshtml"
                                                                                WriteTo(@__razor_helper_writer, Links.Content.Images.editIcon_png);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" alt=\"Edit\" /></a>\r\n                            &nbsp;\r\n                        " +
"    <a href=\"");



#line 90 "..\..\Views\Users\Packages.cshtml"
      WriteTo(@__razor_helper_writer, Url.DeletePackage(package));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" title=\"Delete\" class=\"deletePackageLink\"><img src=\"");



#line 90 "..\..\Views\Users\Packages.cshtml"
                                                                                      WriteTo(@__razor_helper_writer, Links.Content.Images.trash_png);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" alt=\"Delete\" /></a>\r\n                        </li>\r\n                    </ul>\r\n" +
"                </td>\r\n            </tr>\r\n");



#line 95 "..\..\Views\Users\Packages.cshtml"
        }

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    </table>\r\n");



#line 97 "..\..\Views\Users\Packages.cshtml"

#line default
#line hidden

});

}


        public Packages()
        {
        }
        public override void Execute()
        {


            
            #line 2 "..\..\Views\Users\Packages.cshtml"
 if (Model.UnpublishedPackages.Any()) {

            
            #line default
            #line hidden
WriteLiteral(@"    <header>
        <h2>Unpublished Packages</h2>
        <span class=""displayResults"">
            The following packages are in an <strong>unfinished state</strong>. They were uploaded, 
            but are not published in the gallery. You can choose to delete these or publish them.
        </span>
    </header>
");


            
            #line 10 "..\..\Views\Users\Packages.cshtml"


            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""packages owner"">
        <thead class=""header"">
            <tr>
                <th>Title</th>
                <th>Package ID</th>
                <th>Version</th>
                <th class=""ownerActions"">Actions</th>
            </tr>
        </thead>
");


            
            #line 20 "..\..\Views\Users\Packages.cshtml"
         foreach (var package in Model.UnpublishedPackages) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");


            
            #line 22 "..\..\Views\Users\Packages.cshtml"
               Write(package.Title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 23 "..\..\Views\Users\Packages.cshtml"
               Write(package.Id);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 24 "..\..\Views\Users\Packages.cshtml"
               Write(package.Version);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"ownerActions\">\r\n                    <ul>\r\n     " +
"                   <li>\r\n                            <a href=\"");


            
            #line 28 "..\..\Views\Users\Packages.cshtml"
                                Write(Url.Publish(package));

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Publish\"><img src=\"");


            
            #line 28 "..\..\Views\Users\Packages.cshtml"
                                                                                 Write(Links.Content.Images.greenArrow_png);

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Publish\" /></a>\r\n                        </li>\r\n                        <l" +
"i>\r\n                            <a href=\"");


            
            #line 31 "..\..\Views\Users\Packages.cshtml"
                                Write(Url.DeletePackage(package));

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Delete\" class=\"deletePackageLink\"><img src=\"");


            
            #line 31 "..\..\Views\Users\Packages.cshtml"
                                                                                                                Write(Links.Content.Images.trash_png);

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Delete\" /></a>\r\n                        </li>\r\n                    </ul>\r\n" +
"                </td>\r\n            </tr>\r\n");


            
            #line 36 "..\..\Views\Users\Packages.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");


            
            #line 38 "..\..\Views\Users\Packages.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 40 "..\..\Views\Users\Packages.cshtml"
 if (Model.PublishedPackages.Any()) {

            
            #line default
            #line hidden
WriteLiteral("    <header class=\"manage-packages\">\r\n        <h2>Manage My Packages</h2>\r\n      " +
"  <p>These packages are currently published for the world to see.</p>\r\n    </hea" +
"der>\r\n");


            
            #line 45 "..\..\Views\Users\Packages.cshtml"
    
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Users\Packages.cshtml"
Write(PrintPublishedPackages(Model.PublishedPackages.Where(p => !p.Unlisted)));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Users\Packages.cshtml"
                                                                            

    var unlistedPackages = Model.PublishedPackages.Where(p => p.Unlisted);
    if (unlistedPackages.Any()) {

            
            #line default
            #line hidden
WriteLiteral("        <header class=\"manage-packages\">\r\n            <h2>Unlisted Packages</h2>\r" +
"\n            <p>These packages are currently published but unlisted.</p>\r\n      " +
"  </header>\r\n");


            
            #line 53 "..\..\Views\Users\Packages.cshtml"
        
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Users\Packages.cshtml"
   Write(PrintPublishedPackages(unlistedPackages));

            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Users\Packages.cshtml"
                                                 
    }
}
else {

            
            #line default
            #line hidden
WriteLiteral("<header>\r\n    <h2>No Packages?</h2>\r\n</header>\r\n");



WriteLiteral("<p>\r\n    You don&#8217;t have any published packages. Maybe now is a good time to" +
" \r\n    <a href=\"");


            
            #line 62 "..\..\Views\Users\Packages.cshtml"
        Write(Url.UploadPackage());

            
            #line default
            #line hidden
WriteLiteral("\" class=\"silverButtonBig\">Upload a Package</a>\r\n</p>\r\n");


            
            #line 64 "..\..\Views\Users\Packages.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");




        }
    }
}
#pragma warning restore 1591
