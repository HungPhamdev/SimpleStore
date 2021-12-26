using ASM.Share.Helpers;
//using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Share.Models
{
    public interface INguoidungSvc
    {
        List<Nguoidung> GetNguoidungAll();

        Nguoidung GetNguoidung(int id);

        Task<List<Nguoidung>> FindNguoidungAllAsync(string content);

        int AddNguoidung(Nguoidung nguoidung);

        int EditNguoidung(int id, Nguoidung nguoidung);

        void DeleteNguoidung(int id);

        bool checkEmail(string email);

        public Nguoidung Login(ViewLogin viewLogin);
    }

    public class NguoidungSvc : INguoidungSvc
    {
        protected DataContext _context;
        protected IMahoaHelper _mahoaHelper;
        public NguoidungSvc(DataContext context, IMahoaHelper mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }

        public List<Nguoidung> GetNguoidungAll()
        {
            List<Nguoidung> list = new List<Nguoidung>();
            list = _context.Nguoidungs.ToList();
            return list;
        }

        public Nguoidung GetNguoidung(int id)
        {
            Nguoidung nguoidung = null;
            nguoidung = _context.Nguoidungs.Find(id); //cách này chỉ dùng cho Khóa chính
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault(); //cách tổng quát
            return nguoidung;
        }

        public async Task<List<Nguoidung>> FindNguoidungAllAsync(string content)
        {
            return await _context.Nguoidungs.Where(f => f.FullName.Contains(content) || f.UserName.Contains(content) || f.Email.Contains(content)).ToListAsync();
        }

        public int AddNguoidung(Nguoidung nguoidung)
        {
            int ret = 0;
            try
            {
                nguoidung.Password = _mahoaHelper.Mahoa(nguoidung.Password);
                nguoidung.ConfirmPassword = nguoidung.Password;


                _context.Add(nguoidung);
                _context.SaveChanges();
                ret = nguoidung.NguoidungID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditNguoidung(int id, Nguoidung nguoidung)
        {
            int ret = 0;
            try
            {
                Nguoidung _nguoidung = null;
                _nguoidung = _context.Nguoidungs.Find(id); //cách này chỉ dùng cho Khóa chính

                _nguoidung.UserName = nguoidung.UserName;
                _nguoidung.FullName = nguoidung.FullName;
                _nguoidung.Title = nguoidung.Title;
                _nguoidung.DOB = nguoidung.DOB;
                _nguoidung.Email = nguoidung.Email;
                _nguoidung.Admin = nguoidung.Admin;
                _nguoidung.Locked = nguoidung.Locked;
                if (nguoidung.Password != null) 
                {
                    if (_nguoidung.Password == nguoidung.Password) // giữ nguyên mật khẩu cũ
                    {
                        _nguoidung.Password = nguoidung.Password;
                        _nguoidung.ConfirmPassword = nguoidung.Password;
                    }
                    else
                    {
                        nguoidung.Password = _mahoaHelper.Mahoa(nguoidung.Password);
                        _nguoidung.Password = nguoidung.Password;
                        _nguoidung.ConfirmPassword = nguoidung.Password;
                    }
                    
                }

                _context.Update(_nguoidung);
                _context.SaveChanges();
                ret = nguoidung.NguoidungID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public void DeleteNguoidung(int id)
        {
            Nguoidung nguoidung = _context.Nguoidungs.Find(id);
            if (nguoidung.Role == Role.User)
            {
                _context.Remove(nguoidung);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Không thể xóa tài khoản Admin!");
            }
        }

        public bool checkEmail(string email)
        {
            Nguoidung nguoidung = new Nguoidung();
            nguoidung = _context.Nguoidungs.Where(e => e.Email == email).FirstOrDefault();
            if (nguoidung == null)
            {
                return false;
            }
            if (nguoidung.Email==email)
            {
                return true;
            }
            return false;
        }

        public Nguoidung Login(ViewLogin viewLogin) 
        {
            var u = _context.Nguoidungs.Where(
                p => p.UserName.Equals(viewLogin.UserName) 
                && p.Password.Equals(_mahoaHelper.Mahoa(viewLogin.Password))
               ).FirstOrDefault();
            return u;            
        }
    }    
}
