using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadLvKhDatDichvu();
        }
<<<<<<< HEAD:QuanLyKhachSan/QuanLyKhachSan/QuanLyKhachSan/Form1.cs
=======

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

            MessageBox.Show("Bạn chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Đặt dịch vụ thành công");
        }

        private void txtMaKHhd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            inputInformationKH form = new inputInformationKH();
            form.Show();
            // MessageBox.Show("Phòng đã có người!,vui lòng chọn phòng khách");
        }

        private void rdDichVu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelPh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm Khách Hàng thành công");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn xóa khách hàng ?", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Xóa  Khách Hàng thành công");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa Khách Hàng thành công");
           MessageBox.Show("Trùng mã khách hàng,vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
           MessageBox.Show("Bạn chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnThemLoaiDV_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Đã có dịch vụ trong danh sách!", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Thêm dịch vụ  thành công");
        }

        private void btnXoaLoaiDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn xóa dịch vụ ?", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Xóa  dịch vụ thành công!");
>>>>>>> f5387909b065bfa60de2dff130f2a12496b89933:Quanlydichvukhachsan/Quanlydichvukhachsan_Design1/QLDVKS.cs
    }

        private void btnCapnhatLoaiDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chưa điền đầy đủ thông tin?", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Cập nhật dịch vụ thành công");
        }

        private void grbCTDichvu_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chưa điền đầy đủ thông tin?", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Sửa khách hàng order dịch vụ thành công");
        }

        private void button7_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Bạn có muốn xóa order dịch vụ?", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Xóa đặt dịch vụ thành công");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công,Xem  hóa đơn bên chi tiết Hóa đơn");
        }

        public void loadLvKhDatDichvu()
        {
            ListViewItem item = new ListViewItem();
            item.Text = "KH003";
            item.SubItems.Add("Nguyễn Văn Ba");
            item.SubItems.Add("A178");
            item.SubItems.Add("Nước 7Up");
            item.SubItems.Add("2");
            item.SubItems.Add("14000");
            item.SubItems.Add("04/9/2020");
            item.SubItems.Add("07/9/2020");
            listView1.Items.Add(item);
            ListViewItem items = new ListViewItem();
            items.Text = "KH003";
            items.SubItems.Add("Nguyễn Văn Ba");
            items.SubItems.Add("A178");
            items.SubItems.Add("Giặt áo quần");
            items.SubItems.Add("5");
            items.SubItems.Add("240000");
            items.SubItems.Add("04/9/2020");
            items.SubItems.Add("07/9/2020");
            listView1.Items.Add(items);

            ListViewItem itemss = new ListViewItem();
            itemss.Text = "KH002";
            itemss.SubItems.Add("Nguyễn Huệ");
            itemss.SubItems.Add("A179");
            itemss.SubItems.Add("Cocacola");
            itemss.SubItems.Add("10");
            itemss.SubItems.Add("80000");
            itemss.SubItems.Add("01/9/2020");
            itemss.SubItems.Add("07/9/2020");
            listView1.Items.Add(itemss);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không được để trống thông tin ?", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Cập nhật hóa đơn thành công");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn xóa hóa đơn?", "Thông báo", MessageBoxButtons.YesNo);
            MessageBox.Show("Xóa hóa đơn  thành công");
        }
    }
    }

