#pragma checksum "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Shared\LoginControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ec81d34a33f98c74c7bca7270fb7d496df660b"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Shared
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
#line 2 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Shared\LoginControl.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/loginControl")]
    public partial class LoginControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "b");
                __builder2.AddAttribute(3, "class", "h3 text-success font-weight-bold");
                __builder2.AddMarkupContent(4, "<i class=\"far fa-smile\"></i> Xin chào, ");
                __builder2.AddContent(5, 
#nullable restore
#line 6 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Shared\LoginControl.razor"
                                                                                            context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(6, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<a class=\"ml-md-auto btn btn-primary font-weight-bold\" href=\"/logout?returnUrl=/\" target=\"_top\"><span class=\"oi oi-account-logout\" aria-hidden=\"true\"></span> Đăng Xuất</a>");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
