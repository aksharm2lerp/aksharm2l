#pragma checksum "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridReadButtonsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa082759621b35dc4e6bae1e2492767885ef789"
// <auto-generated/>
#pragma warning disable 1591
namespace GridBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridReadButtonsComponent.razor"
using GridBlazor.Resources;

#line default
#line hidden
#nullable disable
    public partial class GridReadButtonsComponent<T> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridReadButtonsComponent.razor"
 if (GridReadComponent._buttonsVisibility == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-primary btn-md");
            __builder.AddAttribute(4, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridReadButtonsComponent.razor"
                                                                   () => GridReadComponent.BackButtonClicked()

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 5 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridReadButtonsComponent.razor"
__builder.AddContent(5, Strings.Back);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridReadButtonsComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
