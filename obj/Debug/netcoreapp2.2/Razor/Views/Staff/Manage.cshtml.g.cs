#pragma checksum "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f06859e28a58943f9f4322b2fe6f9043bf857b37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Manage), @"mvc.1.0.view", @"/Views/Staff/Manage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staff/Manage.cshtml", typeof(AspNetCore.Views_Staff_Manage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06859e28a58943f9f4322b2fe6f9043bf857b37", @"/Views/Staff/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3e6e192176adfd2743d68df8803a4adaf7c8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RapidLaunch.Models.Staff>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-xs tooltips"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-original-title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-xs tooltips"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-original-title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
  
    ViewData["Title"] = "Manage";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
            BeginContext(139, 128, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h4>Manage Staff</h4>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(267, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06859e28a58943f9f4322b2fe6f9043bf857b377385", async() => {
                BeginContext(325, 44, true);
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i> Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(373, 438, true);
            WriteLiteral(@"
    </div>
</div>
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
                                ");
            EndContext();
            BeginContext(812, 44, false);
#line 26 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                           Write(Html.DisplayNameFor(model => model.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(856, 210, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                Name\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1067, 44, false);
#line 32 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1215, 55, false);
#line 35 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                           Write(Html.DisplayNameFor(model => model.Position.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 237, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                Actions\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 43 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1588, 123, true);
            WriteLiteral("                            <tr class=\"gradeU\">\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1712, 43, false);
#line 47 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1871, 51, false);
#line 50 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Person.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1922, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(1925, 50, false);
#line 50 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Person.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1975, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2091, 48, false);
#line 53 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Position.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2255, 59, false);
#line 56 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Position.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2314, 263, true);
            WriteLiteral(@"
                                </td>
                                <td>
                                    <a class=""btn btn-success btn-xs tooltips"" data-placement=""left"" data-original-title=""View Contact Details"" data-toggle=""modal"" data-target=""#staff-");
            EndContext();
            BeginContext(2578, 13, false);
#line 59 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                                                                                                                                                                   Write(item.PersonID);

#line default
#line hidden
            EndContext();
            BeginContext(2591, 78, true);
            WriteLiteral("\"><i class=\"fa fa-phone-square\"></i></a>\r\n                                    ");
            EndContext();
            BeginContext(2669, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06859e28a58943f9f4322b2fe6f9043bf857b3715050", async() => {
                BeginContext(2806, 28, true);
                WriteLiteral("<i class=\"fa fa-pencil\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                                                                                                                                   WriteLiteral(item.StaffID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2838, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2876, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f06859e28a58943f9f4322b2fe6f9043bf857b3717839", async() => {
                BeginContext(3016, 30, true);
                WriteLiteral("<i class=\"fa fa-trash-o \"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                                                                                                                                      WriteLiteral(item.StaffID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3050, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 64 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                        }

#line default
#line hidden
            BeginContext(3153, 144, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n        <!-- page end-->\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
#line 73 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(3330, 47, true);
            WriteLiteral("    <!-- Modal -->\r\n    <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3377, "\"", 3402, 2);
            WriteAttributeValue("", 3382, "staff-", 3382, 6, true);
#line 76 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
WriteAttributeValue("", 3388, item.PersonID, 3388, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3403, 2136, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""ModalTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""ModalTitle"">Contact Details</h5>
                </div>
                <div class=""modal-body"">
                    <!-- row -->
                    <div class=""row mt"">
                        <div class=""col-md-12"">
                            <div class=""content-panel"">
                                <table class=""table table-striped table-advance table-hover"">
                                    <thead>
                                        <tr>
                                            <th>
                                                Name
                                            </th>
                                            <th>
                                                Phone Number
                ");
            WriteLiteral(@"                            </th>
                                            <th>
                                                Email Address
                                            </th>
                                            <th>
                                                City
                                            </th>
                                            <th>
                                                State
                                            </th>
                                            <th>
                                                Country
                                            </th>
                                            <th>
                                                Postal Code
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
          ");
            WriteLiteral("                                  <td>\r\n                                                ");
            EndContext();
            BeginContext(5540, 21, false);
#line 116 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                           Write(item.Person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(5561, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5563, 20, false);
#line 116 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                                                  Write(item.Person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(5583, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5735, 31, false);
#line 119 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                           Write(item.Person.Contact.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5766, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5918, 32, false);
#line 122 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                           Write(item.Person.Contact.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(5950, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6102, 32, false);
#line 125 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                           Write(item.Person.Contact.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(6134, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6286, 33, false);
#line 128 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                           Write(item.Person.Contact.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(6319, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6471, 35, false);
#line 131 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                           Write(item.Person.Contact.Address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(6506, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6658, 38, false);
#line 134 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
                                           Write(item.Person.Contact.Address.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(6696, 662, true);
            WriteLiteral(@"
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <!-- /content-panel -->
                        </div>
                        <!-- /col-md-12 -->
                    </div>
                    <!-- /row -->
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 152 "E:\Information Technology\211IT - Web Applications and Databases\RapidLaunch\RapidLaunch\Views\Staff\Manage.cshtml"
}

#line default
#line hidden
            BeginContext(7361, 1040, true);
            WriteLiteral(@"


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
                ""aTargets"": [0]
            }],
            ""aaSorting"": [
                [1, 'asc']
            ]
        });
    })");
            WriteLiteral(";\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RapidLaunch.Models.Staff>> Html { get; private set; }
    }
}
#pragma warning restore 1591
