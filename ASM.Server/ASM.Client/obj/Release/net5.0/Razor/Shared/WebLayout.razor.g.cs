#pragma checksum "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Shared\WebLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f63b36243a7a675619eaa9630264b27207ed8629"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
    public partial class WebLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.OpenElement(1, "nav");
            __builder.AddAttribute(2, "class", "navbar navbar-expand-sm navbar-toggleable-sm navbar-light border-bottom box-shadow");
            __builder.AddAttribute(3, "style", "background-color:khaki");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" asp-area href=\"/\"><img src=\"/images/simplestore.png\" style=\"width:60px\"></a>\r\n            ");
            __builder.AddMarkupContent(7, "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\".navbar-collapse\" aria-controls aria-expanded=\"false\" aria-label=\"Toggle navigation\"><span class=\"navbar-toggler-icon\"></span></button>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse");
            __builder.OpenComponent<ASM.Client.Shared.WebLoginPartial>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "d-flex justify-content-center h-100");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "searchbar");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "class", "search_input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "placeholder", "Tìm kiếm bằng tên món...");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Shared\WebLayout.razor"
                                                                        tenMon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tenMon = __value, tenMon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/FindFood/" + (
#nullable restore
#line 15 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Shared\WebLayout.razor"
                                            tenMon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "class", "search_icon");
            __builder.AddMarkupContent(26, "<i class=\"fas fa-search\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, @"<ul class=""navbar-nav flex-grow-1""><li class=""nav-link text-dark font-weight-bold""><a href=""/"" style=""text-decoration:none""><i class=""fas fa-home""></i> Trang chủ</a></li>
                    <li class=""nav-link text-dark font-weight-bold""><a href=""/Foods"" style=""text-decoration:none""><i class=""fas fa-utensils""></i> Món ăn</a></li>
                    <li class=""nav-link text-dark font-weight-bold""><a href=""/Combos"" style=""text-decoration:none""><i class=""fas fa-chart-pie""></i> Combo</a></li>
                    <li class=""nav-link text-dark font-weight-bold""><a href=""/Drinks"" style=""text-decoration:none""><i class=""fas fa-wine-bottle""></i> Nước uống</a></li></ul>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "background-color:beige");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "container");
            __builder.AddAttribute(34, "style", "background-color:beige");
            __builder.OpenElement(35, "main");
            __builder.AddAttribute(36, "class", "pb-3");
            __builder.AddAttribute(37, "role", "main");
            __builder.AddContent(38, 
#nullable restore
#line 30 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Shared\WebLayout.razor"
                                        Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.AddMarkupContent(40, "<footer class=\"border-top footer text-dark\" style=\"background-color:darkkhaki\"><div class=\"container\">\r\n        &copy; 2021 - <a href=\"/\">Simple Quán</a> - Đã đăng ký bản quyền.\r\n    </div></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Shared\WebLayout.razor"
  
    public string tenMon { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
