
namespace QLSV_OnTap
{
    partial class Frm1_DangNhap
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
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.lbl_TDN = new System.Windows.Forms.Label();
            this.lbl_MK = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.AutoSize = true;
            this.lbl_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DangNhap.Location = new System.Drawing.Point(205, 38);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(151, 31);
            this.lbl_DangNhap.TabIndex = 0;
            this.lbl_DangNhap.Text = "Đăng Nhập";
            // 
            // lbl_TDN
            // 
            this.lbl_TDN.AutoSize = true;
            this.lbl_TDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TDN.Location = new System.Drawing.Point(59, 127);
            this.lbl_TDN.Name = "lbl_TDN";
            this.lbl_TDN.Size = new System.Drawing.Size(163, 25);
            this.lbl_TDN.TabIndex = 1;
            this.lbl_TDN.Text = "Tên Đăng Nhập";
            // 
            // lbl_MK
            // 
            this.lbl_MK.AutoSize = true;
            this.lbl_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MK.Location = new System.Drawing.Point(59, 181);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(104, 25);
            this.lbl_MK.TabIndex = 1;
            this.lbl_MK.Text = "Mật Khẩu";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenDangNhap.Location = new System.Drawing.Point(237, 122);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(285, 31);
            this.txt_TenDangNhap.TabIndex = 2;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangNhap.Location = new System.Drawing.Point(137, 249);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(144, 36);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txt_MK
            // 
            this.txt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MK.Location = new System.Drawing.Point(237, 178);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(285, 31);
            this.txt_MK.TabIndex = 2;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(314, 249);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(144, 36);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Frm1_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 323);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.lbl_MK);
            this.Controls.Add(this.lbl_TDN);
            this.Controls.Add(this.lbl_DangNhap);
            this.Name = "Frm1_DangNhap";
            this.Text = "Frm1_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.Label lbl_TDN;
        private System.Windows.Forms.Label lbl_MK;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Button btn_Thoat;
    }
}