#pragma checksum "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\Account\Manage\Unauthorized.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c0f0e0262cfefc65f6dacbff73a4ab73df9c73a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RapidLaunch.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_Unauthorized), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/Unauthorized.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/Unauthorized.cshtml", typeof(RapidLaunch.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_Unauthorized), null)]
namespace RapidLaunch.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity;

#line default
#line hidden
#line 3 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity.Models;

#line default
#line hidden
#line 1 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#line 2 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using RapidLaunch.Areas.Identity.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0f0e0262cfefc65f6dacbff73a4ab73df9c73a", @"/Areas/Identity/Pages/Account/Manage/Unauthorized.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b731a3c418350486a4f96adbd0291db35ecf2b3f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d025f608ad9a29252b5b9c24d48ca55bfdf1c9", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88a11afe3cb23bb3d2f085c7958e0d7d40fa585", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_Unauthorized : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\Account\Manage\Unauthorized.cshtml"
  
    Layout = "_Layout.cshtml";
    ViewData["Title"] = "Unauthorized";
    ViewData["ActivePage"] = ManageNavPages.Unauthorized;

#line default
#line hidden
            BeginContext(220, 52, true);
            WriteLiteral("\r\n<header>\r\n    <h5 class=\"text-danger text-center\">");
            EndContext();
            BeginContext(273, 17, false);
#line 10 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Areas\Identity\Pages\Account\Manage\Unauthorized.cshtml"
                                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(290, 103, true);
            WriteLiteral("</h5>\r\n    <p class=\"text-danger text-center\">You do not have access to this resource.</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RapidLaunch.Areas.Identity.Pages.Account.Manage.UnauthorizedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RapidLaunch.Areas.Identity.Pages.Account.Manage.UnauthorizedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RapidLaunch.Areas.Identity.Pages.Account.Manage.UnauthorizedModel>)PageContext?.ViewData;
        public RapidLaunch.Areas.Identity.Pages.Account.Manage.UnauthorizedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
