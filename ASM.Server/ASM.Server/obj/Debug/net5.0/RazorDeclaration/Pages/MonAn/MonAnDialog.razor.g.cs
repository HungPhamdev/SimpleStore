// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ASM.Server.Pages.MonAn
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
#line 2 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\MonAn\MonAnDialog.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\MonAn\MonAnDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\MonAn\MonAnDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MonAnDialog/{id}")]
    public partial class MonAnDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\HK_Summer_2021\Block_2\Lap_trinh_C#6\PS13663_PhamLyHung_UC15302_NET106_Asm\ASM.Server\ASM.Server\Pages\MonAn\MonAnDialog.razor"
       
    [Parameter]
    public string id { get; set; }

    private ASM.Share.Models.MonAn monAn { get; set; }
    private string TieuDe = "";
    private string Style_T = "";
    private string Icon_T = "";
    private string Action = "";
    private string Style_A = "";
    private string Icon_A = "";
    private bool check = false;
    IReadOnlyList<IBrowserFile> selectedFiles;

    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            TieuDe = "Thêm món ăn";
            Style_T = "h2 text-info font-weight-bold";
            Icon_T = "fas fa-plus-square";
            Action = "Tạo";
            Style_A = "btn btn-primary font-weight-bold text-white";
            Icon_A = "fas fa-plus-circle";
            monAn = new ASM.Share.Models.MonAn();
        }
        else
        {
            TieuDe = "Chỉnh sửa món ăn";
            Style_T = "h2 text-info font-weight-bold";
            Icon_T = "fas fa-edit";
            Action = "Lưu";
            Style_A = "btn btn-warning font-weight-bold text-primary";
            Icon_A = "fas fa-save";
            monAn = _monAnSvc.GetMonAn(int.Parse(id));
        }
    }

    private async Task SubmitForm()
    {
        if (selectedFiles != null && selectedFiles.Count > 0)
        {
            var rootPath = $"{env.WebRootPath}\\images";
            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }

            string dirPath = rootPath + @"\" + "Monan";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }


            var file = selectedFiles[0];
            string filePath = dirPath + @"\" + file.Name;
            //var path = $"{env.WebRootPath}\\images\\Monan\\{file.Name}";
            //foreach(var file in selectedFiles)
            {
                Stream stream = file.OpenReadStream(); // khúc này ông sửa lại à ddungs rooi no size be qua chinh no lon bao nhieu cung apply
                FileStream fs = File.Create(filePath);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();
            }
            monAn.Hinh = file.Name;
        }
        if (monAn.MonAnID == 0)
        {
            _monAnSvc.AddMonAn(monAn);
            check = true;
        }
        else
        {
            _monAnSvc.EditMonAn(monAn.MonAnID, monAn);
            check = true;
        }
        navigation.NavigateTo("MonanList");
    }

    private void Cancel()
    {
        navigation.NavigateTo("MonanList", true);
    }

    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        //Message = $"{selectedFiles.Count} file(s) selected";
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ASM.Share.Models.IMonAnSvc _monAnSvc { get; set; }
    }
}
#pragma warning restore 1591
