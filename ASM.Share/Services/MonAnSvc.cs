//using Microsoft.AspNetCore.Http;
//using ASM.Share.Features;
//using ASM.Share.Pazing;
//using ASM.Share.RequestFeatures;
//using Microsoft.AspNetCore.WebUtilities;
using ASM.Share.Pazing;
using ASM.Share.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
//using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ASM.Share.Models
{
    
    public interface IMonAnSvc
    {
        Task<PagedList<MonAn>> GetPhanTrangMonAns(ProductParameters productParameters);
        Task<List<MonAn>> GetMonAnAllAsync();
        List<MonAn> GetMonAnAll();
        Task<List<MonAn>> GetMonAnAll_MonAnAsync();
        Task<List<MonAn>> GetMonAnAll_CombosAsync();
        Task<List<MonAn>> GetMonAnAll_NuocAsync();
        Task<List<MonAn>> FindMonAnAsync(string nameFood);

        MonAn GetMonAn(int id);

        Task<MonAn> GetMonAnAsync(int id);

        int AddMonAn(MonAn monAn);

        int EditMonAn(int id, MonAn monAn);

        void DeleteMonAn(int id);
    }
    public class MonAnSvc : IMonAnSvc
    {
        protected DataContext _context;
        //protected HttpClient _client;
        //private readonly JsonSerializerOptions _options;
        public MonAnSvc(DataContext context/*, HttpClient client*/)
        {
            _context = context;
            //_client = client;
            //_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<PagedList<MonAn>> GetPhanTrangMonAns(ProductParameters productParameters)
        {
            var monAns = await _context.MonAns.ToListAsync();

            return PagedList<MonAn>
                .ToPagedList(monAns, productParameters.PageNumber, productParameters.PageSize);
        }

        public List<MonAn> GetMonAnAll()
        {
            List<MonAn> list = new List<MonAn>();
            list = _context.MonAns.ToList();
            return list;
        }

        public async Task<List<MonAn>> GetMonAnAll_MonAnAsync()
        {
            List<MonAn> monAnList = new List<MonAn>();
            monAnList = await _context.MonAns.Where(x => x.Phanloai == Phanloai.Monan).ToListAsync();
            return monAnList;
        }

        public async Task<List<MonAn>> GetMonAnAll_CombosAsync()
        {
            List<MonAn> comboList = new List<MonAn>();
            comboList = await _context.MonAns.Where(x => x.Phanloai == Phanloai.Combo).ToListAsync();
            return comboList;
        }
              

        public async Task<List<MonAn>> GetMonAnAll_NuocAsync()
        {
            List<MonAn> nuocList = new List<MonAn>();
            nuocList = await _context.MonAns.Where(x => x.Phanloai == Phanloai.Nuoc).ToListAsync();
            return nuocList;
        }

        public async Task<List<MonAn>> FindMonAnAsync(string tenMon)
        {
            return await _context.MonAns.Where(f => f.Name.Contains(tenMon)).ToListAsync();
        }

        public async Task<List<MonAn>> GetMonAnAllAsync()
        {
            return await _context.MonAns.ToListAsync();
        }

        public MonAn GetMonAn(int id)
        {
            MonAn monAn = null;
            monAn = _context.MonAns.Find(id); //cách này chỉ dùng cho Khóa chính
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault(); //cách tổng quát
            return monAn;
        }

        public async Task<MonAn> GetMonAnAsync(int id)
        {
            return await _context.MonAns.FindAsync(id);
        }

        public int AddMonAn(MonAn monAn)
        {
            int ret = 0;
            try
            {
                _context.Add(monAn);
                _context.SaveChanges();
                ret = monAn.MonAnID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditMonAn(int id, MonAn monAn)
        {
            int ret = 0;
            try
            {
                //MonAn _monAn = null;
                //_monAn = _context.MonAns.Find(id); //cách này chỉ dùng cho Khóa chính
                //_monAn.Name = monAn.Name;
                //_monAn.Gia = monAn.Gia;
                //_monAn.Phanloai = monAn.Phanloai;
                //_monAn.Hinh = monAn.Hinh;
                //_monAn.Mota = monAn.Mota;
                //_monAn.Trangthai = monAn.Trangthai;
                //_context.Update(_monAn);

                _context.Update(monAn);
                _context.SaveChanges();
                ret = monAn.MonAnID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public void DeleteMonAn(int id)
        {
            MonAn monAn = _context.MonAns.Find(id);
            _context.Remove(monAn);
            _context.SaveChanges();
        }
    }
    
}
