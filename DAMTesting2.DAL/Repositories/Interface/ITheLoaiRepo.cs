using DAMTesting2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.DAL.Repositories.Interface
{
    public interface ITheLoaiRepo
    {
        string Create(TheLoai theLoai);
        bool Delete(int theLoaiId);
        bool Update(TheLoai updatedTheLoai);
        List<TheLoai> GetAll();
        List<Phim> GetPhimByTheLoaiId(int theLoaiId);
    }
}
