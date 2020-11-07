using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlydichvukhachsan_Design1
{
    public partial class FrmVidu : Form
    {
        public FrmVidu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbCTHoadon_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewDanhsachHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCTPh_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbTTKhachhang_Enter(object sender, EventArgs e)
        {

        }

        private void grbDanhsachDV_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKHhd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            inputInformationKH form = new inputInformationKH();
            form.Show();
        }

        private void rdDichVu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
