using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAMTesting2.BUS.Interface;
using DAMTesting2.BUS.Utils;
using DAMTesting2.BUS.ViewModel;
using DAMTesting2.DAL;
using DAMTesting2.DAL.Entities;
using DAMTesting2.DAL.Repositories.Implement;
using DAMTesting2.DAL.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAMTesting2.BUS.Implement
{
    public class PhimServices : IPhimService
    {
        private readonly IPhimRepo _repo;
        private readonly AppDbContext _appDbContext;

        public PhimServices()
        {
            _repo = new PhimRepo();
            _appDbContext = new AppDbContext();
        }

        public string Create(PhimCreateVM createVM)
        {
            Phim entity = PhimMapping.MapCreateVMToEntity(createVM);
            var result = _repo.Create(entity);
            return result;
        }

        public bool Delete(int id)
        {
            var result = _repo.Delete(id);
            return result;
        }

        public List<PhimVM> GetList()
        {
            return _repo.GetList().Select(PhimMapping.MapEntityToVM).ToList();
        }

        public List<PhimVM> GetListOrderByName()
        {
            return _repo.GetListOrderByName().Select(PhimMapping.MapEntityToVM).ToList();
        }

        public bool Update(PhimUpdateVM updateVM)
        {
            Phim entity = PhimMapping.MapUpdateVMToEntity(updateVM);
            var result = _repo.Update(entity);
            return result;
        }

        public string GetTheLoaiName(int? theLoaiId)
        {
            if (theLoaiId == null)
                return "Không xác định";

            var theLoai = _appDbContext.TheLoais.FirstOrDefault(tl => tl.TheLoaiId == theLoaiId);
            return theLoai?.TenTheLoai ?? "Không xác định";
        }

        public List<PhimVM> Search(string tenPhim = null, string daoDien = null, int? trangThai = null)
        {
            var query = _repo.GetList().AsQueryable();

            if (!string.IsNullOrEmpty(tenPhim))
            {
                query = query.Where(p => p.TenPhim.Contains(tenPhim));
            }

            if (!string.IsNullOrEmpty(daoDien))
            {
                query = query.Where(p => p.DaoDien.Contains(daoDien));
            }

            if (trangThai.HasValue)
            {
                query = query.Where(p => p.TrangThai == trangThai);
            }

            return query.Select(PhimMapping.MapEntityToVM).ToList();
        }

        public List<TheLoaiVM> GetAllTheLoais()
        {
            var theLoais = _appDbContext.TheLoais.ToList();
            return theLoais.Select(tl => new TheLoaiVM
            {
                TheLoaiId = tl.TheLoaiId,
                TenTheLoai = tl.TenTheLoai
            }).ToList();
        }
        public TheLoai GetTheLoaiById(int theLoaiId)
        {
            return _appDbContext.TheLoais.Find(theLoaiId);
        }
    }
}
