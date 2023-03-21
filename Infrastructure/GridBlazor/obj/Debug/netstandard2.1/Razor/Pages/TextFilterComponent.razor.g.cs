#pragma checksum "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b16774313dc0793a86c1b2972e7d38daed65e63f"
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
using GridBlazor.Resources;

#line default
#line hidden
#nullable disable
    public partial class TextFilterComponent<T> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
 if (Visible)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dropdown dropdown-menu grid-dropdown opened");
            __builder.AddAttribute(2, "style", "display:block;position:relative;" + (
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                  "margin-left:" + _offset.ToString() + "px;"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onkeyup", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                                                                                            FilterKeyup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(4, "onclick", true);
            __builder.AddEventStopPropagationAttribute(5, "onkeyup", true);
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                                                                      textFilter = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "grid-dropdown-arrow");
            __builder.AddAttribute(10, "style", 
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                              "margin-left:" + (-_offset).ToString() + "px;"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "grid-dropdown-inner");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "grid-popup-widget");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "grid-filter-body");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 12 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                 for (int i = 0; i < _filters.Count(); i++)
                {
                    int j = i;
                    if (j == 1)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddAttribute(24, "style", "display:flex;justify-content:center;");
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "div");
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "select");
            __builder.AddAttribute(29, "class", "grid-filter-cond form-control");
            __builder.AddAttribute(30, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                     _condition

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _condition = __value, _condition));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(32, "\r\n                                    ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "1");
#nullable restore
#line 20 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(35, Strings.And);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                    ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "2");
#nullable restore
#line 21 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(39, Strings.Or);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 25 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                    }
                    else if (j > 1)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "form-group");
            __builder.AddAttribute(47, "style", "display:flex;justify-content:center;");
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "div");
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.OpenElement(51, "select");
            __builder.AddAttribute(52, "class", "grid-filter-cond form-control");
            __builder.AddAttribute(53, "disabled", "disabled");
            __builder.AddAttribute(54, "value", 
#nullable restore
#line 30 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                          _condition

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(55, "\r\n                                    ");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", "1");
#nullable restore
#line 31 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(58, Strings.And);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                                    ");
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", "2");
#nullable restore
#line 32 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(62, Strings.Or);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 36 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group row");
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col-md-6 my-2");
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 39 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                             if (j == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                                ");
            __builder.OpenElement(75, "label");
            __builder.AddAttribute(76, "class", "control-label");
            __builder.OpenElement(77, "b");
#nullable restore
#line 41 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(78, Strings.FilterTypeLabel);

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, ":");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.OpenElement(81, "div");
            __builder.AddMarkupContent(82, "\r\n                                    ");
            __builder.OpenElement(83, "select");
            __builder.AddAttribute(84, "class", "grid-filter-type form-control");
            __builder.AddAttribute(85, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                            _filters[j].Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filters[j].Type = __value, _filters[j].Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(87, (__value) => {
#nullable restore
#line 43 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                  firstSelect = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(88, "\r\n                                        ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", "2");
#nullable restore
#line 44 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(91, Strings.Contains);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                        ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", "1");
#nullable restore
#line 45 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(95, Strings.Equal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                                        ");
            __builder.OpenElement(97, "option");
            __builder.AddAttribute(98, "value", "10");
#nullable restore
#line 46 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(99, Strings.NotEqual);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                                        ");
            __builder.OpenElement(101, "option");
            __builder.AddAttribute(102, "value", "3");
#nullable restore
#line 47 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(103, Strings.StartsWith);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                        ");
            __builder.OpenElement(105, "option");
            __builder.AddAttribute(106, "value", "4");
#nullable restore
#line 48 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(107, Strings.EndsWith);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                        ");
            __builder.OpenElement(109, "option");
            __builder.AddAttribute(110, "value", "11");
#nullable restore
#line 49 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(111, Strings.IsNull);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                                        ");
            __builder.OpenElement(113, "option");
            __builder.AddAttribute(114, "value", "12");
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(115, Strings.IsNotNull);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 53 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "                                ");
            __builder.OpenElement(120, "div");
            __builder.AddMarkupContent(121, "\r\n                                    ");
            __builder.OpenElement(122, "select");
            __builder.AddAttribute(123, "class", "grid-filter-type form-control");
            __builder.AddAttribute(124, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                         _filters[j].Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filters[j].Type = __value, _filters[j].Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(126, "\r\n                                        ");
            __builder.OpenElement(127, "option");
            __builder.AddAttribute(128, "value", "2");
#nullable restore
#line 58 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(129, Strings.Contains);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                                        ");
            __builder.OpenElement(131, "option");
            __builder.AddAttribute(132, "value", "1");
#nullable restore
#line 59 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(133, Strings.Equal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                                        ");
            __builder.OpenElement(135, "option");
            __builder.AddAttribute(136, "value", "10");
#nullable restore
#line 60 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(137, Strings.NotEqual);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                        ");
            __builder.OpenElement(139, "option");
            __builder.AddAttribute(140, "value", "3");
#nullable restore
#line 61 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(141, Strings.StartsWith);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                                        ");
            __builder.OpenElement(143, "option");
            __builder.AddAttribute(144, "value", "4");
#nullable restore
#line 62 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(145, Strings.EndsWith);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                                        ");
            __builder.OpenElement(147, "option");
            __builder.AddAttribute(148, "value", "11");
#nullable restore
#line 63 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(149, Strings.IsNull);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                                        ");
            __builder.OpenElement(151, "option");
            __builder.AddAttribute(152, "value", "12");
#nullable restore
#line 64 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(153, Strings.IsNotNull);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
#nullable restore
#line 67 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(157, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                        ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "col-md-6 my-2");
            __builder.AddMarkupContent(161, "\r\n");
#nullable restore
#line 70 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                             if (j == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(162, "                                ");
            __builder.OpenElement(163, "label");
            __builder.AddAttribute(164, "class", "control-label");
            __builder.OpenElement(165, "b");
#nullable restore
#line 72 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(166, Strings.FilterValueLabel);

#line default
#line hidden
#nullable disable
            __builder.AddContent(167, ":");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n");
#nullable restore
#line 73 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(169, "                            ");
            __builder.OpenElement(170, "div");
            __builder.AddMarkupContent(171, "\r\n                                ");
            __builder.OpenElement(172, "input");
            __builder.AddAttribute(173, "type", "text");
            __builder.AddAttribute(174, "class", "grid-filter-input form-control");
            __builder.AddAttribute(175, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                                 _filters[j].Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(176, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _filters[j].Value = __value, _filters[j].Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n");
#nullable restore
#line 79 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(181, "                ");
            __builder.OpenElement(182, "div");
            __builder.AddAttribute(183, "class", "grid-buttons");
            __builder.AddMarkupContent(184, "\r\n                    ");
            __builder.OpenElement(185, "div");
            __builder.AddAttribute(186, "class", "grid-filter-buttons");
            __builder.AddMarkupContent(187, "\r\n                        ");
            __builder.OpenElement(188, "button");
            __builder.AddAttribute(189, "type", "button");
            __builder.AddAttribute(190, "class", "btn btn-primary");
            __builder.AddAttribute(191, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                ApplyButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(192, "\r\n                            ");
#nullable restore
#line 83 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(193, Strings.ApplyFilterButtonText);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(194, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                    ");
            __builder.OpenElement(197, "div");
            __builder.AddAttribute(198, "class", "grid-filter-buttons");
            __builder.AddMarkupContent(199, "\r\n                        ");
            __builder.OpenElement(200, "button");
            __builder.AddAttribute(201, "type", "button");
            __builder.AddAttribute(202, "class", "btn btn-primary");
            __builder.AddAttribute(203, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                () => AddColumnFilterValue()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(204, "<b>+</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n");
#nullable restore
#line 88 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                         if (_filters.Length > 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(206, "                            ");
            __builder.OpenElement(207, "button");
            __builder.AddAttribute(208, "type", "button");
            __builder.AddAttribute(209, "class", "btn btn-primary");
            __builder.AddAttribute(210, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                    () => RemoveColumnFilterValue()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(211, "<b>-</b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n");
#nullable restore
#line 91 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(213, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(214, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(215, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n        ");
            __builder.OpenElement(218, "div");
            __builder.AddAttribute(219, "class", "grid-popup-additional");
            __builder.AddMarkupContent(220, "\r\n");
#nullable restore
#line 97 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
             if (_clearVisible)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(221, "                ");
            __builder.OpenElement(222, "ul");
            __builder.AddAttribute(223, "class", "menu-list");
            __builder.AddMarkupContent(224, "\r\n                    ");
            __builder.OpenElement(225, "li");
            __builder.AddMarkupContent(226, "\r\n                        ");
            __builder.OpenElement(227, "a");
            __builder.AddAttribute(228, "class", "grid-filter-clear");
            __builder.AddAttribute(229, "href", "javascript:void(0);");
            __builder.AddAttribute(230, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
                                                                                          ClearButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(231, "\r\n                            ");
#nullable restore
#line 102 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
__builder.AddContent(232, Strings.ClearFilterLabel);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(233, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(234, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "\r\n");
#nullable restore
#line 106 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(237, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(238, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(239, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(240, "\r\n");
#nullable restore
#line 110 "C:\Users\Lenovo\Documents\GitHub\ERP\Infrastructure\GridBlazor\Pages\TextFilterComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
