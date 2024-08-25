using DAMTesting2.DAL.Entities;
using DAMTesting2.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.DAL.Repositories.Implement
{
    public class PhimRepo : IPhimRepo
    {
        private readonly AppDBContext _appDbContext;

        public PhimRepo()
        {
            _appDbContext = new AppDBContext();
        }

        public string Create(Phim phim)
        {
            try
            {
                _appDbContext.Phims.Add(phim);
                _appDbContext.SaveChanges();

                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                return "Thêm thất bại: " + ex.Message;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var phim = _appDbContext.Phims
                    .Include(p => p.TheLoaiCuaPhims)
                    .FirstOrDefault(e => e.PhimId == id);

                if (phim != null)
                {
                    _appDbContext.Phims.Remove(phim);
                    _appDbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public List<Phim> GetList()
        {
            return _appDbContext.Phims
                .Include(p => p.TheLoaiCuaPhims)
                .ThenInclude(tlcp => tlcp.TheLoai)
                .ToList();
        }

        public List<Phim> GetListOrderByName()
        {
            return _appDbContext.Phims
                .Include(p => p.TheLoaiCuaPhims)
                .ThenInclude(tlcp => tlcp.TheLoai)
                .OrderBy(phim => phim.TenPhim)
                .ToList();
        }


        public bool Update(Phim updatedPhim)
        {
            try
            {
                var existingPhim = _appDbContext.Phims
                    .Include(p => p.TheLoaiCuaPhims)
                    .FirstOrDefault(e => e.PhimId == updatedPhim.PhimId);

                if (existingPhim != null)
                {
                    existingPhim.TenPhim = updatedPhim.TenPhim;
                    existingPhim.ThoiGianPhatHanh = updatedPhim.ThoiGianPhatHanh;
                    existingPhim.DaoDien = updatedPhim.DaoDien;
                    existingPhim.ThoiLuong = updatedPhim.ThoiLuong;
                    existingPhim.TrangThai = updatedPhim.TrangThai;
                    existingPhim.MoTa = updatedPhim.MoTa;

                    existingPhim.TheLoaiCuaPhims.Clear();
                    foreach (var theLoaiCuaPhim in updatedPhim.TheLoaiCuaPhims)
                    {
                        existingPhim.TheLoaiCuaPhims.Add(theLoaiCuaPhim);
                    }

                    _appDbContext.Phims.Update(existingPhim);
                    _appDbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
