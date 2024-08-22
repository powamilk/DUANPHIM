using DAMTesting2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.DAL.Repositories.Interface
{
    public interface IPhimRepo
    {
        string Create(Phim phim);
        bool Delete(int id);
        List<Phim> GetList();
        List<Phim> GetListOrderByName();
        bool Update(Phim updatedPhim);
    }
}
