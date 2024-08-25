using DAMTesting2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.BUS.Interface
{
    public interface ITheLoaiService
    {
        string Create(TheLoaiVM theLoaiVM);
        bool Delete(int theLoaiId);
        bool Update(TheLoaiVM theLoaiVM);
        List<TheLoaiVM> GetAll();
        List<PhimVM> GetPhimByTheLoaiId(int theLoaiId);
    }
}
