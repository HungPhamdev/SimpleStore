#pragma checksum "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247835de389ee0982d2d81f202457b74c9d8bff5"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Pages.Donhang
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Donhangdialog/{id}")]
    public partial class DonhangDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h2");
            __builder.AddAttribute(1, "class", "h2 text-info font-weight-bold");
            __builder.AddMarkupContent(2, "<i class=\"fas fa-edit\"></i> ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                                                       TieuDe

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                          donhang

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                                   SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "hidden");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                        donhang.DonhangID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.DonhangID = __value, donhang.DonhangID));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label class=\"control-label\">Kh??ch h??ng</label>\r\n                ");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "disabled", "disabled");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                              donhang.Khachhang.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.Khachhang.EmailAddress = __value, donhang.Khachhang.EmailAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "style", "display:none");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                              donhang.KhachhangID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.KhachhangID = __value, donhang.KhachhangID));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "<label class=\"control-label\">Ng??y ?????t</label>\r\n                ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "date");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                          donhang.Ngaydat

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.Ngaydat = __value, donhang.Ngaydat, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __Blazor.ASM.Server.Pages.Donhang.DonhangDialog.TypeInference.CreateValidationMessage_0(__builder2, 44, 45, 
#nullable restore
#line 24 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                          ()=>donhang.Ngaydat

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "<label class=\"control-label\">T???ng ti???n</label>\r\n                ");
                __builder2.OpenElement(50, "input");
                __builder2.AddAttribute(51, "type", "number");
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                            donhang.Tongtien

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.Tongtien = __value, donhang.Tongtien, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __Blazor.ASM.Server.Pages.Donhang.DonhangDialog.TypeInference.CreateValidationMessage_1(__builder2, 56, 57, 
#nullable restore
#line 29 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                          ()=>donhang.Tongtien

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "<label class=\"control-label\">Tr???ng th??i</label>\r\n                ");
                __Blazor.ASM.Server.Pages.Donhang.DonhangDialog.TypeInference.CreateInputSelect_2(__builder2, 62, 63, "form-control", 64, 
#nullable restore
#line 33 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                           donhang.TrangthaiDonhang

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => donhang.TrangthaiDonhang = __value, donhang.TrangthaiDonhang)), 66, () => donhang.TrangthaiDonhang, 67, (__builder3) => {
#nullable restore
#line 34 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                     foreach (var trangthai in Enum.GetValues(typeof(TrangthaiDonhang)))
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(68, "option");
                    __builder3.AddAttribute(69, "value", 
#nullable restore
#line 36 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                        trangthai

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(70, 
#nullable restore
#line 36 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                                    trangthai

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 37 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "<label @bind=\"donhang.Ghichu\" class=\"control-label\"></label>\r\n                ");
                __builder2.OpenElement(75, "input");
                __builder2.AddAttribute(76, "class", "form-control");
                __builder2.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                              donhang.Ghichu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donhang.Ghichu = __value, donhang.Ghichu));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "<button type=\"submit\" class=\"btn btn-warning text-success font-weight-bold\"><i class=\"fas fa-save\"></i> L??u</button>\r\n                ");
                __builder2.OpenElement(83, "button");
                __builder2.AddAttribute(84, "type", "submit");
                __builder2.AddAttribute(85, "class", "btn btn-info font-weight-bold");
                __builder2.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                                                                       Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(87, "<i class=\"fas fa-arrow-circle-left\"></i> Tho??t");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Donhang\DonhangDialog.razor"
       
    [Parameter]
    public string id { get; set; }

    private ASM.Share.Models.Donhang donhang { get; set; }
    private string TieuDe = "";
    //IReadOnlyList<IBrowserFile> selectedFiles;

    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            navigation.NavigateTo("donhangList", true);
        }
        else
        {
            TieuDe = "Ch???nh s???a ????n h??ng";
            donhang = _donhangSvc.GetDonhang(int.Parse(id));
        }
    }

    private async Task SubmitForm()
    {
        await _donhangSvc.EditDonhangAsync(donhang.DonhangID, donhang);
        navigation.NavigateTo("DonhangList", true);
    }

    private void Cancel()
    {
        navigation.NavigateTo("DonhangList", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ASM.Share.Models.IDonhangSvc _donhangSvc { get; set; }
    }
}
namespace __Blazor.ASM.Server.Pages.Donhang.DonhangDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
