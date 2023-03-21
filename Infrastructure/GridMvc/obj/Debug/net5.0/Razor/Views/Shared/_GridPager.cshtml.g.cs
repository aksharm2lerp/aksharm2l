#pragma checksum "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c05e6f2bfd9a24cf1a7413e9b2f670f42a1c63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GridPager), @"mvc.1.0.view", @"/Views/Shared/_GridPager.cshtml")]
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
using GridCore.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
using GridCore.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c05e6f2bfd9a24cf1a7413e9b2f670f42a1c63", @"/Views/Shared/_GridPager.cshtml")]
    #nullable restore
    public class Views_Shared__GridPager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GridPager>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
 if (Model == null || Model.PageCount <= 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"grid-pager-sizer\">\r\n        &nbsp;\r\n    </div>");
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
          ;
}
else
{
    string _changePageSizeUrl = (string)ViewData["changePageSizeUrl"];
    string _goToUrl = (string)ViewData["goToUrl"];
    bool _enablePaging = (bool)ViewData["enablePaging"];
    int _pageSize = Model.ChangePageSize && Model.QueryPageSize > 0 ? Model.QueryPageSize : Model.PageSize;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"grid-pager-sizer\">\r\n        <nav class=\"grid-pager\" data-currentpage=\"");
#nullable restore
#line 17 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                             Write(Model.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 19 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                 if (Model.CurrentPage > 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a class=\"page-link grid-page-link\"");
            BeginWriteAttribute("href", " href=\"", 801, "\"", 898, 3);
#nullable restore
#line 22 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 808, Context.Request.PathBase, 808, 25, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 833, Context.Request.Path, 833, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 854, Model.GetLinkForPage(Model.CurrentPage - 1), 854, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">«</a>\r\n                    </li>\r\n");
#nullable restore
#line 24 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <span class=\"page-link grid-page-link\">«</span>\r\n                    </li>\r\n");
#nullable restore
#line 30 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                 if (Model.StartDisplayedPage > 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a class=\"page-link grid-page-link\"");
            BeginWriteAttribute("href", " href=\"", 1331, "\"", 1408, 3);
#nullable restore
#line 34 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 1338, Context.Request.PathBase, 1338, 25, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 1363, Context.Request.Path, 1363, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 1384, Model.GetLinkForPage(1), 1384, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1</a>\r\n                    </li>\r\n");
#nullable restore
#line 36 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                    if (Model.StartDisplayedPage > 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\"><a class=\"page-link grid-page-link\"");
            BeginWriteAttribute("href", " href=\"", 1603, "\"", 1707, 3);
#nullable restore
#line 38 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 1610, Context.Request.PathBase, 1610, 25, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 1635, Context.Request.Path, 1635, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 1656, Model.GetLinkForPage(Model.StartDisplayedPage - 1), 1656, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">...</a></li>\r\n");
#nullable restore
#line 39 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                 for (int i = Model.StartDisplayedPage; i <= Model.EndDisplayedPage; i++)

                {
                    if (i == Model.CurrentPage)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item active\"><span type=\"button\" class=\"page-link grid-page-link\">");
#nullable restore
#line 46 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 47 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\"><a class=\"page-link grid-page-link\"");
            BeginWriteAttribute("href", " href=\"", 2224, "\"", 2301, 3);
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2231, Context.Request.PathBase, 2231, 25, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2256, Context.Request.Path, 2256, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2277, Model.GetLinkForPage(i), 2277, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                                                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                 if (Model.EndDisplayedPage < Model.PageCount)
                {
                    if (Model.EndDisplayedPage < Model.PageCount - 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\"><a class=\"page-link grid-page-link\"");
            BeginWriteAttribute("href", " href=\"", 2616, "\"", 2718, 3);
#nullable restore
#line 57 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2623, Context.Request.PathBase, 2623, 25, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2648, Context.Request.Path, 2648, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2669, Model.GetLinkForPage(Model.EndDisplayedPage + 1), 2669, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">...</a></li>\r\n");
#nullable restore
#line 58 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link grid-page-link\"");
            BeginWriteAttribute("href", " href=\"", 2826, "\"", 2917, 3);
#nullable restore
#line 59 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2833, Context.Request.PathBase, 2833, 25, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2858, Context.Request.Path, 2858, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 2879, Model.GetLinkForPage(Model.PageCount), 2879, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                                                                                                                                             Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 60 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                 if (Model.CurrentPage < Model.PageCount)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link grid-page-link\"");
            BeginWriteAttribute("href", " href=\"", 3122, "\"", 3219, 3);
#nullable restore
#line 64 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 3129, Context.Request.PathBase, 3129, 25, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 3154, Context.Request.Path, 3154, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 3175, Model.GetLinkForPage(Model.CurrentPage + 1), 3175, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">»</a></li>\r\n");
#nullable restore
#line 65 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><span class=\"page-link grid-page-link\">»</span></li>\r\n");
#nullable restore
#line 69 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n        <div class=\"grid-goto-page form-group\" data-goto-page-url=\"");
#nullable restore
#line 72 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                                              Write(_goToUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <label class=\"control-label\"><b>");
#nullable restore
#line 73 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                       Write(Strings.Goto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\r\n            <div>\r\n                <input class=\"form-control grid-goto-page-input\"");
            BeginWriteAttribute("value", " value=\"", 3677, "\"", 3703, 1);
#nullable restore
#line 75 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 3685, Model.CurrentPage, 3685, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 78 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
         if (_enablePaging && Model.ChangePageSize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"grid-change-page-size form-group\" data-change-page-size-url=\"");
#nullable restore
#line 80 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                                                                Write(_changePageSizeUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <label class=\"control-label\"><b>");
#nullable restore
#line 81 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                           Write(Strings.Show);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\r\n                <div>\r\n                    <input class=\"form-control grid-change-page-size-input\"");
            BeginWriteAttribute("value", " value=\"", 4090, "\"", 4108, 1);
#nullable restore
#line 83 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
WriteAttributeValue("", 4098, _pageSize, 4098, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <label class=\"control-label\"><b>");
#nullable restore
#line 85 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
                                           Write(Strings.Items);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\r\n            </div>\r\n");
#nullable restore
#line 87 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 89 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridMvc\Views\Shared\_GridPager.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GridPager> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
