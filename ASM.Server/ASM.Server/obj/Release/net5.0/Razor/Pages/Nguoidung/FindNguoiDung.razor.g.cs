#pragma checksum "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be7c87d88964ac9cd9256708502efe303fbc8584"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Pages.Nguoidung
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
#line 3 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FindNguoiDung/{fullName}")]
    public partial class FindNguoiDung : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-info font-weight-bold\"><i class=\"fas fa-list-ul\"></i> Danh sách người dùng được tìm kiếm</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex justify-content-center h-100");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "searchbar");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "search_input_sv");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "placeholder", "Tìm kiếm bằng tên người dùng...");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                                                           fullName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fullName = __value, fullName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "/FindNguoiDung/" + (
#nullable restore
#line 11 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                                 fullName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "search_icon");
            __builder.AddMarkupContent(15, "<i class=\"fas fa-search\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
 if (check == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<h2 class=\"alert alert-success font-weight-bold h2\">Xóa người dùng thành công!</h2>");
#nullable restore
#line 18 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
 if (nguoidungs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<p><em><img src=\"images/loading.gif\" width=\"1200\" height=\"600\"></em></p>");
#nullable restore
#line 23 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-hover");
            __builder.AddMarkupContent(20, @"<thead><tr><th>Tên đăng nhập</th>
                <th>Họ và tên</th>
                <th>Email</th>
                <th>Chức danh</th>
                <th>Vai trò</th>
                <th><a class=""btn btn-outline-success font-weight-bold p-10"" href=""/NguoidungDialog/0""><i class=""fa fa-plus-square""></i> Thêm người dùng mới</a></th></tr></thead>
        ");
            __builder.OpenElement(21, "tbody");
#nullable restore
#line 40 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
             foreach (var item in nguoidungs)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 43 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                         item.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 44 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                         item.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 45 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                         item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 46 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                         item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 47 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                         item.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "btn btn-info font-weight-bold");
            __builder.AddAttribute(41, "href", "/NguoidungDialog/" + (
#nullable restore
#line 55 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                                                                                         item.NguoidungID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, " |\r\n                        ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "btn btn-danger text-white font-weight-bold");
            __builder.AddAttribute(46, "style", "cursor:pointer");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
                                                                                                                 ()=>Delete(item.NguoidungID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "<i class=\"fas fa-trash-alt\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\Nguoidung\FindNguoiDung.razor"
       
    [Parameter]
    public string fullName { get; set; }
    public List<Nguoidung> nguoidungs;
    public bool check { get; set; }

    protected override async Task OnInitializedAsync()
    {
        nguoidungs = await _nguoidungSvc.FindNguoidungAllAsync(fullName);
    }

    private void Delete(int id)
    {
        if (_nguoidungSvc.GetNguoidung(id).Role == Role.User)
        {
            check = true;
            _nguoidungSvc.DeleteNguoidung(id);
            nguoidungs = _nguoidungSvc.GetNguoidungAll();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ASM.Share.Models.INguoidungSvc _nguoidungSvc { get; set; }
    }
}
#pragma warning restore 1591
