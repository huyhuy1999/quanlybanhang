namespace QuanLyBanHang
{
    partial class Frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap));
            this.link_DangKy = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dangnhap = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // link_DangKy
            // 
            this.link_DangKy.AutoSize = true;
            this.link_DangKy.Location = new System.Drawing.Point(177, 5);
            this.link_DangKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_DangKy.Name = "link_DangKy";
            this.link_DangKy.Size = new System.Drawing.Size(157, 17);
            this.link_DangKy.TabIndex = 1;
            this.link_DangKy.TabStop = true;
            this.link_DangKy.Text = "Bạn chưa có tài khoản?";
            this.link_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DangKy_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // tb_dangnhap
            // 
            this.tb_dangnhap.Location = new System.Drawing.Point(120, 27);
            this.tb_dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dangnhap.Name = "tb_dangnhap";
            this.tb_dangnhap.Size = new System.Drawing.Size(147, 23);
            this.tb_dangnhap.TabIndex = 2;
            this.tb_dangnhap.TextChanged += new System.EventHandler(this.tb_dangnhap_TextChanged);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(120, 57);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(2);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(147, 23);
            this.tb_matkhau.TabIndex = 3;
            this.tb_matkhau.UseSystemPasswordChar = true;
            this.tb_matkhau.TextChanged += new System.EventHandler(this.tb_matkhau_TextChanged);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(8, 81);
            this.lb_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(0, 17);
            this.lb_status.TabIndex = 4;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.status.Location = new System.Drawing.Point(49, 155);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            this.status.TabIndex = 5;
            // 
            // bt_huy
            // 
            this.bt_huy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_huy.Image = global::QuanLyBanHang.Properties.Resources.if_exit_to_app_326635;
            this.bt_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_huy.Location = new System.Drawing.Point(155, 95);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(87, 43);
            this.bt_huy.TabIndex = 5;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_dangnhap.Image = global::QuanLyBanHang.Properties.Resources.iconfinder_key_309059;
            this.bt_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dangnhap.Location = new System.Drawing.Point(43, 95);
            this.bt_dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(97, 43);
            this.bt_dangnhap.TabIndex = 4;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(392, 199);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_DangKy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_DangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dangnhap;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label status;
    }
}

