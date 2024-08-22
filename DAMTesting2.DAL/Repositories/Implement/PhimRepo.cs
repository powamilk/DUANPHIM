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
        private readonly AppDbContext _appDbContext;

        public PhimRepo()
        {
            _appDbContext = new AppDbContext();
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
                    .Include(p => p.TheLoais) 
                    .FirstOrDefault(e => e.PhimId == id);

                if (phim != null)
                {
                    phim.TheLoais.Clear();
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
                .Include(p => p.TheLoais)
                .ToList();
        }

        public List<Phim> GetListOrderByName()
        {
            return _appDbContext.Phims
                .Include(p => p.TheLoais)
                .OrderBy(phim => phim.TenPhim)
                .ToList();
        }

        public bool Update(Phim updatedPhim)
        {
            try
            {
                var existingPhim = _appDbContext.Phims
                    .Include(p => p.TheLoais)
                    .FirstOrDefault(e => e.PhimId == updatedPhim.PhimId);

                if (existingPhim != null)
                {
                    existingPhim.TenPhim = updatedPhim.TenPhim;
                    existingPhim.ThoiGianPhatHanh = updatedPhim.ThoiGianPhatHanh;
                    existingPhim.DaoDien = updatedPhim.DaoDien;
                    existingPhim.ThoiLuong = updatedPhim.ThoiLuong;
                    existingPhim.TrangThai = updatedPhim.TrangThai;
                    existingPhim.MoTa = updatedPhim.MoTa;
                    existingPhim.TheLoais.Clear();
                    foreach (var theLoai in updatedPhim.TheLoais)
                    {
                        existingPhim.TheLoais.Add(theLoai);
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
