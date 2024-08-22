using DAMTesting2.BUS.Utils.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.BUS.Utils
{
    public static class StatusPhim
    { 
        public static string GetStatusName(this StatusEnum trangThai)
        {
            return trangThai switch
            {
                StatusEnum.DangPhatHanh => "1 - Đang Phát Hành",
                StatusEnum.TamDung => "2 - Tạm Dừng",
                StatusEnum.DaNgungPhatHanh => "3 - Đã Ngừng Phát Hành",
                _ => "Ko xác định"
            };
        }
    }
}
