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
    public partial class Frm1_DangNhap : Form
    {

        private KetNoi kn;
        public Frm1_DangNhap()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TenDangNhap.Text;
            string password = txt_MK.Text;
            string selectFomat =
                "select * from HETHONG where BINARY_CHECKSUM(TENDN) = BINARY_CHECKSUM('{0}') and BINARY_CHECKSUM(MATKHAU) = BINARY_CHECKSUM('{1}') ";
            string sql = String.Format(selectFomat, username, password);

            // kiểm tra đăng nhập
            bool logedIn = kn.ExcuteReader(sql).Read();

         

            if (logedIn)
            {
            
                MDI1_QLSV main = new MDI1_QLSV();
                main.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
