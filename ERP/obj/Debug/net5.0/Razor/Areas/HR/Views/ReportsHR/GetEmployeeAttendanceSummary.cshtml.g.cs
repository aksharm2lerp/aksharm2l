#pragma checksum "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "905413b95d6b74a85cff77cd8faaa86f287b7356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HR_Views_ReportsHR_GetEmployeeAttendanceSummary), @"mvc.1.0.view", @"/Areas/HR/Views/ReportsHR/GetEmployeeAttendanceSummary.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using Business.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using Business.SQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using ERP.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using ERP.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using ERP.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\_ViewImports.cshtml"
using Business.Entities.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905413b95d6b74a85cff77cd8faaa86f287b7356", @"/Areas/HR/Views/ReportsHR/GetEmployeeAttendanceSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9944a1c594c39df98753be59f62bb100aa180b8b", @"/Areas/HR/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_HR_Views_ReportsHR_GetEmployeeAttendanceSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataSet>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EmployeeCategoryID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "EmployeeCategoryID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DepartmentID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "DepartmentID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
  
    ViewData["Title"] = "Employee Attendance Summury Report";
    Layout = "~/Views/Shared/_LayoutMaster.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
  
    List<string> strTimeforRow = new List<string>();
    DateTime date = ViewBag.MonthYear;
    //string monthyear = string.Concat(date.Year + "-" + date.Month);
    string monthyear = date.ToString("yyyy-MM");
    int empCatId = ViewBag.EmployeeCategoryID;
    int deptId = ViewBag.DepartmentID;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" id=""employeePresent"">
    <div class=""row"">
        <div class=""col-sm-12 col-md-12 col-lg-12 mx-auto"">
            <div class=""card border-0 shadow rounded-3"">
                <div class=""card-body"">

                    <div class=""row"">
                        <div class=""ps-3 col-md-6"">
                            <nav aria-label=""breadcrumb"">
                                <ol class=""breadcrumb mb-0 p-0"">
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Employee Attendance</li>
                                </ol>
                            </nav>
                        </div>
                    </div>

                    <hr />
                    <div class=""row mb-1"">
                        <label class=""col-3 col-form-label"">Employee Category</label>
                        <div class=""col-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905413b95d6b74a85cff77cd8faaa86f287b73568984", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905413b95d6b74a85cff77cd8faaa86f287b73569276", async() => {
                    WriteLiteral("Select Category");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 38 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = EmployeeExtension.GetAllEmployeeCategoryMaster();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => empCatId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <label class=\"col-3 col-form-label\">Select Month & Year</label>\r\n                        <div class=\"col-3\">\r\n                            <input type=\"month\" class=\"form-control\" id=\"month\"");
            BeginWriteAttribute("value", " value=\"", 1967, "\"", 1985, 1);
#nullable restore
#line 44 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
WriteAttributeValue("", 1975, monthyear, 1975, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>

                    <div class=""row mb-1"">
                        <label class=""col-sm-3 col-form-label"">Search Keyword</label>
                        <div class=""col-sm-3"" id=""idForDropdown"">
                            <input type=""hidden"" id=""EmployeeID"" class=""form-control"" />
                            <input type=""text"" class=""form-control bs-autocomplete"" id=""employeeText"" name=""EmployeeName"" placeholder=""Enter Searching text.""");
            BeginWriteAttribute("value", " value=\"", 2496, "\"", 2525, 1);
#nullable restore
#line 52 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
WriteAttributeValue("", 2504, ViewBag.SearchString, 2504, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                            <!--    Important code block.
                            <div class=""container text-center"">
                                <input class=""form-control"" id=""EmployeeID"" oninput=""fnFindEmployee()"" list=""employeeList"" />
                                <datalist id=""employeeList""></datalist>
                            </div>
                            -->

                        </div>
                        <label class=""col-3 col-form-label"">Department</label>
                        <div class=""col-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905413b95d6b74a85cff77cd8faaa86f287b735614859", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905413b95d6b74a85cff77cd8faaa86f287b735615152", async() => {
                    WriteLiteral("Select Department");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 64 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = EmployeeExtension.GetAllDepartmentText();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 64 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => deptId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""text-end mb-3"">
                        <input type=""button"" value=""Export to excel"" class=""btn btn-outline-primary px-5 btn-sm"" onclick=""fnSearch(true)"" />

                        <button id=""btnSearchEmployeePresent"" type=""button"" onclick=""fnSearch(false)"" class=""btn btn-outline-primary px-5 btn-sm"">Search</button>
                    </div>

                    <div id=""EmployeeAddessTable"">
");
#nullable restore
#line 77 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                         if (Model.Tables[0].Columns.Count > 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"" style=""overflow:auto; height:350px; width:100%;"">
                                <table class=""table table-striped"" style=""font-size:small;"">
                                    <!--style=""display:block; overflow: auto; white-space: nowrap;""-->
                                    <thead style=""position: sticky; top: 0; background-color:darkslategrey; color:papayawhip; font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: x-small;"">
                                        <tr>
");
#nullable restore
#line 84 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                             foreach (DataColumn dataColumn in Model.Tables[0].Columns)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                           
                                                strTimeforRow.Add(dataColumn.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <th>");
#nullable restore
#line 93 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                               Write(dataColumn.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 94 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                                     
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tr>\r\n                                    </thead>\r\n");
#nullable restore
#line 98 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                     foreach (DataRow row in Model.Tables[0].Rows)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n");
#nullable restore
#line 101 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                             foreach (string timeRow in strTimeforRow)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                                 if (!string.IsNullOrEmpty(row[timeRow].ToString()))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>");
#nullable restore
#line 105 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                                   Write(row[timeRow]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 106 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>-</td>\r\n");
#nullable restore
#line 110 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tr>\r\n");
#nullable restore
#line 113 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </table>\r\n                            </div>\r\n");
#nullable restore
#line 116 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""text-center"">
                                <h1><iconify-icon icon=""mdi:text-box-remove-outline"" style=""color: #37569d;"" width=""100""></iconify-icon></h1>
                                <h3 style=""color: red;"">No Data Found</h3>
                            </div>
");
#nullable restore
#line 123 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 133 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    function fnSearch(obj) {

        var employeeCategoryId = $('#EmployeeCategoryID').val();

        var departmentId = $('#DepartmentID').val();

        var employeeId = $('#employeeText').val();

        var monthDate = $('#month').val();
        //const dateString = ""2023-03-16"";
        const year = monthDate.slice(0, 4); // ""2023""
        const month = monthDate.slice(5, 7);

        var isdownload = obj;

        var url = '");
#nullable restore
#line 150 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\HR\Views\ReportsHR\GetEmployeeAttendanceSummary.cshtml"
              Write(Url.Action("GetEmployeeAttendanceSummary","ReportsHR"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        var newurl = url + '?employeeCategoryId=' + employeeCategoryId + '&employeeId=' + employeeId + '&month=' + month + '&year=' + year + '&departmentId=' + departmentId + '&searchString=' + employeeId + '&isDownload=' + isdownload;

        window.location.href = newurl;
    };
</script>


<!--    Important Code Block
");
            WriteLiteral("-->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataSet> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
