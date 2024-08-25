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
    public class TheLoaiRepo : ITheLoaiRepo
    {
        private readonly AppDBContext _appDbContext;

        public TheLoaiRepo(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string Create(TheLoai theLoai)
        {
            try
            {
                _appDbContext.TheLoais.Add(theLoai);
                _appDbContext.SaveChanges();
                return "Thêm thể loại thành công";
            }
            catch (Exception ex)
            {
                return "Thêm thể loại thất bại: " + ex.Message;
            }
        }

        public bool Delete(int theLoaiId)
        {
            try
            {
                var theLoai = _appDbContext.TheLoais
                    .Include(tl => tl.TheLoaiCuaPhims)
                    .FirstOrDefault(tl => tl.TheLoaiId == theLoaiId);

                if (theLoai != null)
                {
                    _appDbContext.TheLoais.Remove(theLoai);
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

        public bool Update(TheLoai updatedTheLoai)
        {
            try
            {
                var existingTheLoai = _appDbContext.TheLoais
                    .FirstOrDefault(tl => tl.TheLoaiId == updatedTheLoai.TheLoaiId);

                if (existingTheLoai != null)
                {
                    existingTheLoai.TenTheLoai = updatedTheLoai.TenTheLoai;
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

        public List<TheLoai> GetAll()
        {
            return _appDbContext.TheLoais
                .Include(tl => tl.TheLoaiCuaPhims)
                .ThenInclude(tlcp => tlcp.Phim)
                .ToList();
        }

        public List<Phim> GetPhimByTheLoaiId(int theLoaiId)
        {
            return _appDbContext.TheLoaiCuaPhims
                .Where(tlcp => tlcp.TheLoaiId == theLoaiId)
                .Include(tlcp => tlcp.Phim)
                .Select(tlcp => tlcp.Phim)
                .ToList();
        }
    }
}
