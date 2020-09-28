#pragma checksum "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7872450eedc6d02ade9e9f27088a2b33d8924461"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Launch_Index), @"mvc.1.0.view", @"/Views/Launch/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7872450eedc6d02ade9e9f27088a2b33d8924461", @"/Views/Launch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3e6e192176adfd2743d68df8803a4adaf7c8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Launch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RapidLaunch.Models.ViewModels.LaunchVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4>Rocket Launches</h4>
<hr>
<section class=""wrapper"">
    <div class=""row mb"">
        <!-- page start-->
        <div class=""content-panel"">
            <div class=""adv-table"">
                <table cellpadding=""0"" cellspacing=""0"" border=""0"" class=""display table table-bordered"" id=""hidden-table-info"">
                    <thead>
                        <tr>
                            <th>
                                Launch Date
                            </th>
                            <th>
                                Provider
                            </th>
                            <th>
                                Rocket
                            </th>
                            <th>
                                Launch Pad
                            </th>
                            <th>
                                Launch Orbit
                            </th>
                            <th>
                                Launch Status
     ");
            WriteLiteral("                       </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 39 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                         foreach (var item in Model.Launches)
                        {
                            string status = item.LaunchStatus;
                            string css = "";

                            switch (status)
                            {
                                case "Success":
                                    css = "gradeA";
                                    break;
                                case "Failure":
                                    css = "gradeX";
                                    break;
                                case "Scheduled":
                                    css = "gradeC";
                                    break;
                                default:
                                    css = "gradeU";
                                    break;
                            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=", 2206, "", 2217, 1);
#nullable restore
#line 60 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
WriteAttributeValue("", 2213, css, 2213, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>\r\n                                    ");
#nullable restore
#line 62 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LaunchDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 62 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                                                                               Write(Html.DisplayFor(modelItem => item.LaunchTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 65 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Provider));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 68 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Rocket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 71 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LaunchPad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 74 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LaunchOrbit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 77 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LaunchStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 80 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Launch\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <!-- page end-->
    </div>
</section>

<script type=""text/javascript"">
    /* Formating function for row details */
    function fnFormatDetails(oTable, nTr) {
        var aData = oTable.fnGetData(nTr);
        var sOut = '<table cellpadding=""5"" cellspacing=""0"" border=""0"" style=""padding-left:50px;"">';
        sOut += '<tr><td>Rendering engine:</td><td>' + aData[1] + ' ' + aData[4] + '</td></tr>';
        sOut += '<tr><td>Link to source:</td><td>Could provide a link here</td></tr>';
        sOut += '<tr><td>Extra info:</td><td>And any further details here (images etc)</td></tr>';
        sOut += '</table>';

        return sOut;
    }

    $(document).ready(function () {
        /*
        * Initialse DataTables, with no sorting on the 'details' column
        */
        var oTable = $('#hidden-table-info').dataTable({
            ""aoColumnDefs"": [{
                ""bSortable"": false,
  ");
            WriteLiteral("              \"aTargets\": [0]\r\n            }],\r\n            \"aaSorting\": [\r\n                [1, \'asc\']\r\n            ]\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RapidLaunch.Models.ViewModels.LaunchVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
