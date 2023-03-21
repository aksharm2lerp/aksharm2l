#pragma checksum "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70b76f162db63bf4eeb72c734b47db2e72cce61a"
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
using GridBlazor.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
using GridShared.Sorting;

#line default
#line hidden
#nullable disable
    public partial class GridExtSortHeaderComponent<T> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "grid-extsort-" + (
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                       Grid.ComponentOptions.GridName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "input-group" + " grid-extsort-droppable" + " " + (
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                                                                  _dropClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "data-extsort-url", 
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                                                                                                 _groupUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                      Grid.HiddenExtSortingHeader ? "none;" : "flex;" 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ondragenter", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                     () => HandleDragEnter()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ondragleave", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                               () => HandleDragLeave()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ondrop", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                                                                  HandleDrop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ondragover", "event.preventDefault();");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 9 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
     if (_sortedColumns.Count() == 0)
    {
        if (Grid.GroupingEnabled)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "grid-extsort-empty");
#nullable restore
#line 13 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
__builder.AddContent(13, Strings.GroupingText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 14 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "grid-extsort-empty");
#nullable restore
#line 17 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
__builder.AddContent(18, Strings.ExtSortingText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 18 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
        }
    }
    else
    {
        foreach (var column in _sortedColumns.OrderBy(r => r.Id))
        {
            var gridColumn = Grid.Columns.SingleOrDefault(r => r.Name == column.ColumnName);
            if (gridColumn == null)
            {
                continue;
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "grid-extsort-column");
            __builder.AddAttribute(23, "data-name", 
#nullable restore
#line 29 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                          column.ColumnName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "data-extsortdata", 
#nullable restore
#line 29 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                                                                JsonSerializer.Serialize(column)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", 
#nullable restore
#line 30 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                               column.Direction == GridSortDirection.Ascending ? "sorted-asc" : "sorted-desc"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "btn btn-link");
            __builder.AddAttribute(32, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                                         () => TitleButtonClicked(column)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "data-column", 
#nullable restore
#line 31 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                                                                                         column.ColumnName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 31 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
__builder.AddContent(34, gridColumn.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    <span class=\"grid-sort-arrow\"></span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-link");
            __builder.AddAttribute(40, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                                     () => CancelButtonClicked(column)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "data-column", 
#nullable restore
#line 34 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
                                                                                                                      column.ColumnName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(42, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 36 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\GridExtSortHeaderComponent.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
