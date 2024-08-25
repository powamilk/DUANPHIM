using DAMTesting2.BUS.Interface;
using DAMTesting2.BUS.ViewModel;
using DAMTesting2.DAL.Entities;
using DAMTesting2.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.BUS.Implement
{
    public class TheLoaiService : ITheLoaiService
    {
        private readonly ITheLoaiRepo _theLoaiRepo;

        public TheLoaiService(ITheLoaiRepo theLoaiRepo)
        {
            _theLoaiRepo = theLoaiRepo;
        }

        public string Create(TheLoaiVM theLoaiVM)
        {
            var theLoai = new TheLoai
            {
                TenTheLoai = theLoaiVM.TenTheLoai
            };
            return _theLoaiRepo.Create(theLoai);
        }

        public bool Delete(int theLoaiId)
        {
            return _theLoaiRepo.Delete(theLoaiId);
        }

        public bool Update(TheLoaiVM theLoaiVM)
        {
            var theLoai = new TheLoai
            {
                TheLoaiId = theLoaiVM.TheLoaiId,
                TenTheLoai = theLoaiVM.TenTheLoai
            };
            return _theLoaiRepo.Update(theLoai);
        }

        public List<TheLoaiVM> GetAll()
        {
            var theLoais = _theLoaiRepo.GetAll();
            return theLoais.Select(tl => new TheLoaiVM
            {
                TheLoaiId = tl.TheLoaiId,
                TenTheLoai = tl.TenTheLoai
            }).ToList();
        }

        public List<PhimVM> GetPhimByTheLoaiId(int theLoaiId)
        {
            var phims = _theLoaiRepo.GetPhimByTheLoaiId(theLoaiId);
            return phims.Select(p => new PhimVM
            {
                PhimId = p.PhimId,
                TenPhim = p.TenPhim,
                DaoDien = p.DaoDien,
                ThoiGianPhatHanh = p.ThoiGianPhatHanh,
                ThoiLuong = p.ThoiLuong,
                TrangThai = p.TrangThai,
                MoTa = p.MoTa
            }).ToList();
        }
    }
}
