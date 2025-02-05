#pragma checksum "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "199c4c87c2acd3acbd5e0727e52224eb50ed70d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Provider_Index), @"mvc.1.0.view", @"/Views/Provider/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Provider/Index.cshtml", typeof(AspNetCore.Views_Provider_Index))]
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
#line 1 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch;

#line default
#line hidden
#line 2 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Models;

#line default
#line hidden
#line 3 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Models.ViewModels;

#line default
#line hidden
#line 4 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity.Models;

#line default
#line hidden
#line 5 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199c4c87c2acd3acbd5e0727e52224eb50ed70d0", @"/Views/Provider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3e6e192176adfd2743d68df8803a4adaf7c8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Provider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProviderVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
            BeginContext(113, 763, true);
            WriteLiteral(@"
<h4>Rocket Launch Providers</h4>
<hr>
<!-- row -->
<div class=""row mt"">
    <div class=""col-md-12"">
        <div class=""content-panel"">
            <table class=""table table-striped table-advance table-hover"">
                <thead>
                    <tr>
                        <th>
                            <b>Name</b>
                        </th>
                        <th>
                            Description
                        </th>
                        <th>
                            Rocket Models
                        </th>
                        <th>
                            Date Established
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 32 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
                     foreach (var item in Model.Providers)
                    {

#line default
#line hidden
            BeginContext(959, 99, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <b>");
            EndContext();
            BeginContext(1059, 39, false);
#line 36 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 107, true);
            WriteLiteral("</b>\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1206, 46, false);
#line 39 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 42 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
                                   
                                    foreach (var rm in item.RocketModelLinks)
                                    {
                                        

#line default
#line hidden
            BeginContext(1519, 19, false);
#line 45 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
                                   Write(rm.RocketModel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1538, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1541, 8, true);
            WriteLiteral(" <br/>\r\n");
            EndContext();
#line 46 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(1623, 101, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1725, 48, false);
#line 50 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EstablishDate));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 53 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Provider\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1864, 157, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- /content-panel -->\r\n    </div>\r\n    <!-- /col-md-12 -->\r\n</div>\r\n<!-- /row -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProviderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
