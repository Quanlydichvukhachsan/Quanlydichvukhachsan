using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

<<<<<<< HEAD
           // Application.Run(new frmQLNV());

          //  Application.Run(new frmNhanphong());

            Application.Run(new frmSudungvathanhtoandichvu());
=======
          

            Application.Run(new frmQLNV());
>>>>>>> 7e78f053ff2a8f7cf6488a1c38de898841994583

        }
    }
}
