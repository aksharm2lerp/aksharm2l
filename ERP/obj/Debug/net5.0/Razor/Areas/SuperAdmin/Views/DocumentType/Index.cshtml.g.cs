#pragma checksum "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\Views\DocumentType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9603d23b35567565d1951921620e1cc21c447e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_DocumentType_Index), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/DocumentType/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using Business.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using ERP.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\_ViewImports.cshtml"
using Business.Entities.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\Views\DocumentType\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\Views\DocumentType\Index.cshtml"
using Business.SQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\Views\DocumentType\Index.cshtml"
using GridCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9603d23b35567565d1951921620e1cc21c447e", @"/Areas/SuperAdmin/Views/DocumentType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9944a1c594c39df98753be59f62bb100aa180b8b", @"/Areas/SuperAdmin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_SuperAdmin_Views_DocumentType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISGrid>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "SuperAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::GridMvc.TagHelpers.GridTagHelper __GridMvc_TagHelpers_GridTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\Views\DocumentType\Index.cshtml"
  
    ViewData["Title"] = "Countries";
    Layout = "~/Views/Shared/_LayoutMaster.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-breadcrumb d-none d-sm-flex align-items-center pb-2 border-bottom"">
    <div class=""ps-3 col-md-6"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb mb-0 p-0"">
                <li class=""breadcrumb-item"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9603d23b35567565d1951921620e1cc21c447e6489", async() => {
                WriteLiteral("<i class=\"bx bx-home-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Document Types</li>
            </ol>
        </nav>
    </div>
    <div class=""col-md-6 text-align-right"">
        <a class=""btn btn-primary px-5"" onclick=""fnDocumentType(this)""
           href=""javascript:void(0)""
           data-id=""0""
           data-bs-toggle=""offcanvas""
           data-bs-target=""#canvas_documenttype""
           aria-controls=""canvas_documenttype"">
            Add Document Type
        </a>
    </div>
</div>
<div class=""row pt-2"">
    <div class=""col-md-12"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb9603d23b35567565d1951921620e1cc21c447e8704", async() => {
            }
            );
            __GridMvc_TagHelpers_GridTagHelper = CreateTagHelper<global::GridMvc.TagHelpers.GridTagHelper>();
            __tagHelperExecutionContext.Add(__GridMvc_TagHelpers_GridTagHelper);
#nullable restore
#line 36 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\Views\DocumentType\Index.cshtml"
__GridMvc_TagHelpers_GridTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __GridMvc_TagHelpers_GridTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""canvas_documenttype"">
    <div class=""offcanvas-header"">
        <h5 class=""offcanvas-title"">Document Type</h5>
        <button type=""button"" class=""btn-close te  xt-reset"" data-bs-dismiss=""offcanvas"" aria-l abel=""Close""></button>
    </div>
    <div class=""offcanvas-body pt-3 pb-5"">
        <div id=""dvInfo"">
        </div>
    </div>
</div>
<script type=""text/javascript"">
    var urladd = '");
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\ERP\ERP\Areas\SuperAdmin\Views\DocumentType\Index.cshtml"
             Write(Url.Action("Get", "DocumentType"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    function fnDocumentType(obj) {
        var _id = $(obj).data('id');
        var _parameters = { id: _id };
        $.ajax({
            url: urladd,
            type: ""POST"",
            data: _parameters,
            success: function (data, textStatus, jqXHR) {
                $('#dvInfo').html(data);
                $(""#canvas_documenttype"").show();//('hide');
            }
        });
    }
    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISGrid> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
