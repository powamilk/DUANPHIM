using DAMTesting2.BUS.ViewModel;
using DAMTesting2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.BUS.Interface
{
    public interface IPhimService
    {
        string Create(PhimCreateVM createVM);
        bool Delete(int id);
        List<PhimVM> GetList();
        TheLoai GetTheLoaiById(int theLoaiId);
        List<PhimVM> GetListOrderByName();
        bool Update(PhimUpdateVM updateVM);
        string GetTheLoaiName(int? theLoaiId);
        List<PhimVM> Search(string tenPhim = null, string daoDien = null, int? trangThai = null);
        List<TheLoaiVM> GetAllTheLoais();
    }
}
