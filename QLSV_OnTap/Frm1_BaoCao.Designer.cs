
namespace QLSV_OnTap
{
    partial class Frm1_BaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crv_SV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_SV
            // 
            this.crv_SV.ActiveViewIndex = -1;
            this.crv_SV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_SV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_SV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_SV.Location = new System.Drawing.Point(0, 0);
            this.crv_SV.Name = "crv_SV";
            this.crv_SV.Size = new System.Drawing.Size(800, 450);
            this.crv_SV.TabIndex = 0;
            // 
            // Frm1_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_SV);
            this.Name = "Frm1_BaoCao";
            this.Text = "Frm1_BaoCao";
            this.Load += new System.EventHandler(this.Frm1_BaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_SV;
    }
}