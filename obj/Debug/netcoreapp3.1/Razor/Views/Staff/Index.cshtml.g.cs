#pragma checksum "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab4dda08e493d0a535f706f420179323cfda3a50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4dda08e493d0a535f706f420179323cfda3a50", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3e6e192176adfd2743d68df8803a4adaf7c8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RapidLaunch.Models.ViewModels.DepartmentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Executive Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 11 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.ExecutiveStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Web Design Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 20 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.WebDesignStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Software Engineering Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 29 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.SoftwareEngineeringStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Marketing Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 38 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.MarketingStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Sales Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 47 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.SalesStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Finance Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 56 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.FinanceStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Human Resources Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 65 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.HumanResourcesStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Information Services Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 74 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.InformationServicesStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Document Control Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 83 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.DocumentControlStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Quality Assurance Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 92 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.QualityAssuranceStaff)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RapidLaunch.Models.ViewModels.DepartmentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
