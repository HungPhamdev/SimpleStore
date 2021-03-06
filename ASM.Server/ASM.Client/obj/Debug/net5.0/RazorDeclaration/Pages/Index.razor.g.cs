// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Index.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Index.razor"
using ASM.Share.RequestFeatures;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Client\Pages\Index.razor"
      
    public List<MonAn> monAns { get; set; } = new List<MonAn>();
    private string name;
    public MonAnDTO monAnDTO;
    protected string imgUrl = "";
    protected string temp = "";

    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;

    protected override async Task OnInitializedAsync()
    {
        pagerSize = 8;
        pageSize = 4;
        curPage = 1;

        monAnDTO = new MonAnDTO();
        monAns = new List<MonAn>();
        await LoadMonAn();
    }

    public async Task LoadMonAn()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("paging?PageNumber=" + curPage + "&PageSize=" + pageSize))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                monAnDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<MonAnDTO>(apiResponse);
            }
            monAns = monAnDTO.MonAns;
            totalRecords = monAnDTO.TotalCount;

            totalPages = (int)Math.Ceiling(totalRecords / (decimal)pageSize);

            SetPagerSize("forward");
        }
    }
    public async Task NavigaToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
                await RefreshRecord(curPage);
            }
        }
        else if (direction == "prev")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
                await RefreshRecord(curPage);
            }
        }

    }
    public async Task RefreshRecord(int currentPage)
    {
        curPage = currentPage;
        await LoadMonAn();
    }
    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
    }

    private void AddCart(int id)
    {
        //var cart = HttpContent.Session.GetString("cart");// get key cart
        var cart = sessionStorage.GetItem<string>("cart");// get key cart
        if (cart == null)
        {
            var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
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
            var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
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
