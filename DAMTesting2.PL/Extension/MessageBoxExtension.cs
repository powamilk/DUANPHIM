using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMTesting2.PL.MessageBoxExtension
{
    public class MessageBoxExtension
    {
        public static void Notification(string title, string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK);
        }
        public static bool Confirm(string msg)
        {
            var result = MessageBox.Show($"Bạn có muốn {msg} không ?", "XÁC NHẬN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            return result == DialogResult.OK;
        }
    }
}
