using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_OnTap
{
    public partial class Frm1_BaoCao : Form
    {
        public Frm1_BaoCao()
        {
            InitializeComponent();
        }

        private void Frm1_BaoCao_Load(object sender, EventArgs e)
        {
            BC_SinhVien bc = new BC_SinhVien();
            bc.SetDatabaseLogon("sa", "Admin1234", "101.96.66.219,8013", "QLSinhVien");
            crv_SV.ReportSource = bc;
        }
    }
}
