#pragma checksum "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acaa3ae4bec675ad43a682b72e52416b1f7985b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RocketModel_Index), @"mvc.1.0.view", @"/Views/RocketModel/Index.cshtml")]
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
#line 1 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acaa3ae4bec675ad43a682b72e52416b1f7985b1", @"/Views/RocketModel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3e6e192176adfd2743d68df8803a4adaf7c8da", @"/Views/_ViewImports.cshtml")]
    public class Views_RocketModel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RapidLaunch.Models.RocketModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4>Rocket Models</h4>
<hr>
<!-- row -->
<div class=""row mt"">
    <div class=""col-md-12"">
        <div class=""content-panel"">
            <table class=""table table-striped table-advance table-hover"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 18 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 21 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 24 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 27 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Mass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 30 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Diameter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 33 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.PayloadLEO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 36 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.PayloadGTO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 39 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 42 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.RocketCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 47 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 54 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Mass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 63 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Diameter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PayloadLEO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PayloadGTO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 72 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Manufacturer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 75 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.RocketCategory.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 78 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\RocketModel\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- /content-panel -->\r\n    </div>\r\n    <!-- /col-md-12 -->\r\n</div>\r\n<!-- /row -->\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RapidLaunch.Models.RocketModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
