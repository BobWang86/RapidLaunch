#pragma checksum "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab4dda08e493d0a535f706f420179323cfda3a50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staff/Index.cshtml", typeof(AspNetCore.Views_Staff_Index))]
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
#line 1 "E:\GitLab\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch;

#line default
#line hidden
#line 2 "E:\GitLab\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Models;

#line default
#line hidden
#line 3 "E:\GitLab\RapidLaunch\Views\_ViewImports.cshtml"
using RapidLaunch.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4dda08e493d0a535f706f420179323cfda3a50", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34296ee667d0900d6b914c8856270a30e1c33796", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RapidLaunch.Models.ViewModels.DepartmentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
            BeginContext(145, 58, true);
            WriteLiteral("\r\n<h4>Executive Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 11 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.ExecutiveStaff)
    {
        

#line default
#line hidden
            BeginContext(268, 49, false);
#line 13 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 13 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(326, 67, true);
            WriteLiteral("</div>\r\n\r\n<h4>Web Design Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 20 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.WebDesignStaff)
    {
        

#line default
#line hidden
            BeginContext(458, 49, false);
#line 22 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 22 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(516, 77, true);
            WriteLiteral("</div>\r\n\r\n<h4>Software Engineering Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 29 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.SoftwareEngineeringStaff)
    {
        

#line default
#line hidden
            BeginContext(668, 49, false);
#line 31 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 31 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(726, 66, true);
            WriteLiteral("</div>\r\n\r\n<h4>Marketing Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 38 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.MarketingStaff)
    {
        

#line default
#line hidden
            BeginContext(857, 49, false);
#line 40 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 40 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(915, 62, true);
            WriteLiteral("</div>\r\n\r\n<h4>Sales Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 47 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.SalesStaff)
    {
        

#line default
#line hidden
            BeginContext(1038, 49, false);
#line 49 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 49 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(1096, 64, true);
            WriteLiteral("</div>\r\n\r\n<h4>Finance Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 56 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.FinanceStaff)
    {
        

#line default
#line hidden
            BeginContext(1223, 49, false);
#line 58 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 58 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(1281, 72, true);
            WriteLiteral("</div>\r\n\r\n<h4>Human Resources Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 65 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.HumanResourcesStaff)
    {
        

#line default
#line hidden
            BeginContext(1423, 49, false);
#line 67 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 67 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(1481, 77, true);
            WriteLiteral("</div>\r\n\r\n<h4>Information Services Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 74 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.InformationServicesStaff)
    {
        

#line default
#line hidden
            BeginContext(1633, 49, false);
#line 76 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 76 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(1691, 73, true);
            WriteLiteral("</div>\r\n\r\n<h4>Document Control Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 83 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.DocumentControlStaff)
    {
        

#line default
#line hidden
            BeginContext(1835, 49, false);
#line 85 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 85 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(1893, 74, true);
            WriteLiteral("</div>\r\n\r\n<h4>Quality Assurance Department</h4>\r\n<hr>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 92 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
     foreach (var item in Model.QualityAssuranceStaff)
    {
        

#line default
#line hidden
            BeginContext(2039, 49, false);
#line 94 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
   Write(await Html.PartialAsync("StaffCardPartial", item));

#line default
#line hidden
            EndContext();
#line 94 "E:\GitLab\RapidLaunch\Views\Staff\Index.cshtml"
                                                          
    }

#line default
#line hidden
            BeginContext(2097, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RapidLaunch.Models.ViewModels.DepartmentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
