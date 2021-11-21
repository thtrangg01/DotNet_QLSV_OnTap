using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV_OnTap
{
    public partial class Frm1_SinhVien : Form
    {

        private KetNoi kn;
        public Frm1_SinhVien()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void Frm1_SinhVien_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();

        }

        private void LoadDataToForm()
        {
            data_SinhVien.DataSource = kn.GetDataTable("select * from SINHVIEN");

            cbo_Khoa.DataSource = kn.GetDataTable("select * from KHOAVIEN");
            cbo_Khoa.DisplayMember = "TENKHOA";
            cbo_Khoa.ValueMember = "MAKHOA";

            cbo_He.DataSource = kn.GetDataTable("select * from HEDAOTAO");
            cbo_He.DisplayMember = "TENHE";
            cbo_He.ValueMember = "MAHE";

            cbo_Lop.DataSource = kn.GetDataTable("select * from LOP");
            cbo_Lop.DisplayMember = "TENLOP";
            cbo_Lop.ValueMember = "MALOP";

            List<string> gt = new List<string>();
            gt.Add("0");
            gt.Add("1");
            cbo_GioiTinh.DataSource = gt;

            BindingData();

            

        }

        private void BindingData()
        {

            txt_MSV.Clear();
            txt_MSV.DataBindings.Clear();
            txt_MSV.DataBindings.Add("Text", data_SinhVien.DataSource, "MASV");

            txt_HoTen.Clear();
            txt_HoTen.DataBindings.Clear();
            txt_HoTen.DataBindings.Add("Text", data_SinhVien.DataSource, "HOTEN");

            cbo_GioiTinh.DataBindings.Clear();
            cbo_GioiTinh.DataBindings.Add("text", data_SinhVien.DataSource, "GIOITINH");

            date_NgaySinh.DataBindings.Clear();
            date_NgaySinh.DataBindings.Add("Text", data_SinhVien.DataSource, "NGAYSINH");

            txt_NoiSinh.Clear();
            txt_NoiSinh.DataBindings.Clear();
            txt_NoiSinh.DataBindings.Add("Text", data_SinhVien.DataSource, "NOISINH");

            cbo_Khoa.DataBindings.Clear();
            cbo_Khoa.DataBindings.Add("text", data_SinhVien.DataSource, "MAKHOA");

            cbo_Lop.DataBindings.Clear();
            cbo_Lop.DataBindings.Add("text", data_SinhVien.DataSource, "MALOP");

            cbo_He.DataBindings.Clear();
            cbo_He.DataBindings.Add("text", data_SinhVien.DataSource, "MAHE");

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_HoTen.Text = " ";
            txt_MSV.Text = " ";
            txt_NoiSinh.Text = " ";
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string msv = txt_MSV.Text;
            string hoTen = txt_HoTen.Text;
            string noiSinh = txt_NoiSinh.Text;
            DateTime ngaysinh = date_NgaySinh.Value;
            string gioiTinh = (string)cbo_GioiTinh.SelectedValue;
            string malop = (string)cbo_Lop.SelectedValue;
            string maKhoa = (string)cbo_Khoa.SelectedValue;
            string maHe = (string)cbo_He.SelectedValue;

            // kiểm tra trùng mã sv;
            string check_sql = "select * from SINHVIEN where MASV = '{0}'";
            bool msv_exsist = kn.ExcuteReader(String.Format(check_sql, msv)).Read();

            if (msv_exsist)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Message");
                return;
            }

            string prepare =
                "insert into SINHVIEN values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');";
            string sql = String.Format(prepare, msv, hoTen, gioiTinh, ngaysinh.ToString(), noiSinh, maKhoa, malop, maHe);

            try
            {
                kn.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
            btn_Luu.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string msv = txt_MSV.Text;
            string hoTen = txt_HoTen.Text;
            string noiSinh = txt_NoiSinh.Text;
            DateTime ngaysinh = date_NgaySinh.Value;
            string gioiTinh = (string)cbo_GioiTinh.SelectedValue;
            string malop = (string)cbo_Lop.SelectedValue;
            string maKhoa = (string)cbo_Khoa.SelectedValue;
            string maHe = (string)cbo_He.SelectedValue;

            string prepapre =
                "update SINHVIEN set HOTEN = '{0}', GIOITINH = '{1}', NGAYSINH='{2}', NOISINH='{3}', MAKHOA='{4}', MALOP = '{5}', MAHE = '{6}' where MASV='{7}' ;";

            string sql = String.Format(prepapre, hoTen, gioiTinh, ngaysinh.ToString(), noiSinh, maKhoa, malop, maHe, msv);

            try
            {
                kn.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string msv = txt_MSV.Text;
            string prepare = "delete from SINHVIEN where MASV = '{0}'";
            string sql = String.Format(prepare, msv);

            DialogResult confirmDialogResult = MessageBox.Show("Bạn muốn xóa sinh viên với msv = " + msv);
            if (confirmDialogResult == DialogResult.OK)
            {
                try
                {
                    kn.Excute(sql);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            LoadDataToForm();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
