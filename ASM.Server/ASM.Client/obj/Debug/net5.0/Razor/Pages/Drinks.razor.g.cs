#pragma checksum "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e3463426e34b4c305973fde5f07ab679632c521"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Client.Pages
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
#line 2 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Drinks")]
    public partial class Drinks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .title {
        color: #0e0e0e;
        display: block;
        font-size: 15px;
        font-weight: bold;
        text-align: center;
        height: 60px;
    }

    .field-price {
        font-size: 24px;
        color: #d50000;
        margin-bottom: 25px;
        margin-top: -15px;
        font-weight: 700;
        text-align: center;
    }

    .addProduct {
        border: 0;
        font-weight: 700;
        padding: 9px 5px;
        background: #ffd800;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        border-radius: 5px;
        margin: -20px auto;
        color: darkgreen;
        width: 70%;
    }

        .addProduct:hover {
            background-color: green;
            color: yellow;
        }

    .welcome {
        color: brown;
        padding-top: 10px;
        text-align: center;
    }

    .menu {
        color: dodgerblue;
        text-align: center;
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "<h1 class=\"h1 font-weight-bold welcome\">K??nh ch??o qu?? kh??ch ?????n v???i Simple Qu??n</h1>\r\n    ");
            __builder.AddMarkupContent(4, "<h2 class=\"h1 font-weight-bold menu\"><i class=\"fas fa-wine-bottle\"></i> ????? u???ng</h2>\r\n    <hr>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
#nullable restore
#line 62 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
         foreach (var item in doUongs)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-3 col-md-3 col-sm-6 col-xs-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "box card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "box cardImg");
#nullable restore
#line 67 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
                          temp = imgUrl + item.Hinh;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 68 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
                                   temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "info");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "title");
            __builder.AddContent(20, 
#nullable restore
#line 71 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
                                             item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "field-price");
            __builder.AddContent(24, 
#nullable restore
#line 72 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
                                                  item.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "addProduct");
            __builder.AddAttribute(29, "onmouseup", "addCart(" + (
#nullable restore
#line 74 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
                                                    item.MonAnID

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
                                                                             () => AddCart(item.MonAnID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "<i class=\"fas fa-cart-plus\"></i> Th??m\r\n                            ");
            __builder.OpenElement(32, "img");
            __builder.AddAttribute(33, "id", "imgBusy_" + (
#nullable restore
#line 76 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
                                              item.MonAnID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "src", "images/busy.gif");
            __builder.AddAttribute(35, "style", "display:none");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "/DetailFood/" + (
#nullable restore
#line 78 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
                                              item.MonAnID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "text-primary w-100");
            __builder.AddMarkupContent(40, "<i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 82 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Drinks.razor"
      
    public List<MonAn> doUongs;
    protected string imgUrl = "";
    protected string temp = "";
    //protected void OnInitialized()
    protected override async Task OnInitializedAsync()
    {
        //sessionStorage.SetItem("name", "John Smith");
        //var name = sessionStorage.GetItem<string>("name");
        //monAns = _monAnService.GetMonAnAll();
        var apiUrl = config.GetSection("API")["APIFoodUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();

        doUongs = new List<MonAn>();
        using (var client = new HttpClient())
        {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Access-Control-Allow-Origin", "*");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("Nuoc"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                doUongs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MonAn>>(apiResponse);
            }
        }
    }

    private void AddCart(int id)
    {
        //var cart = HttpContent.Session.GetString("cart");// get key cart
        var cart = sessionStorage.GetItem<string>("cart");// get key cart
        if (cart == null)
        {
            var monAn = doUongs.Where(u => u.MonAnID == id).FirstOrDefault();
            List<CartItem> listCart = new List<CartItem>()
        {
                new CartItem
                {
                    MonAn = monAn,
                    Quantity = 1,
                    Sotien = monAn.Gia
                }
            };

            ASM.Share.Models.Cart giohang = new ASM.Share.Models.Cart()
            {
                ListViewCart = listCart,
                Tongtien = Tinhtien(listCart)
            };
            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
        }
        else
        {
            var monAn = doUongs.Where(u => u.MonAnID == id).FirstOrDefault();
            ASM.Share.Models.Cart giohang = JsonConvert.DeserializeObject<ASM.Share.Models.Cart>(cart);
            // List<Viewcart> dataCart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
            bool check = true;
            for (int i = 0; i < giohang.ListViewCart.Count; i++)
            {
                if (giohang.ListViewCart[i].MonAn.MonAnID == id)
                {
                    giohang.ListViewCart[i].Quantity++;
                    giohang.ListViewCart[i].Sotien = monAn.Gia * giohang.ListViewCart[i].Quantity;
                    check = false;
                }
            }

            if (check)
            {
                //var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
                giohang.ListViewCart.Add(new CartItem
                {
                    MonAn = monAn,
                    Quantity = 1,
                    Sotien = monAn.Gia
                });
            }
            giohang.Tongtien = Tinhtien(giohang.ListViewCart);
            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(giohang));
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
        }
    }

    private double Tinhtien(List<CartItem> listCart)
    {
        double tongTien = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                tongTien += listCart[i].Sotien;
            }
        }
        return tongTien;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
