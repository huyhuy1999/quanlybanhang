namespace QuanLyBanHang
{
    partial class Frm_SanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SanPham));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbmasp = new System.Windows.Forms.ComboBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.txtIDSP = new System.Windows.Forms.TextBox();
            this.cbb_loaisp1 = new System.Windows.Forms.ComboBox();
            this.cbb_donvidoluong = new System.Windows.Forms.ComboBox();
            this.num_soluong = new System.Windows.Forms.NumericUpDown();
            this.cbb_NCC = new System.Windows.Forms.ComboBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.txt_giatien = new System.Windows.Forms.TextBox();
            this.txt_tenSP = new System.Windows.Forms.TextBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dgv_danhsachsp = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvidoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.cbbmasp);
            this.groupBox1.Controls.Add(this.btnSave1);
            this.groupBox1.Controls.Add(this.txtIDSP);
            this.groupBox1.Controls.Add(this.cbb_loaisp1);
            this.groupBox1.Controls.Add(this.cbb_donvidoluong);
            this.groupBox1.Controls.Add(this.num_soluong);
            this.groupBox1.Controls.Add(this.cbb_NCC);
            this.groupBox1.Controls.Add(this.txt_mota);
            this.groupBox1.Controls.Add(this.txt_giatien);
            this.groupBox1.Controls.Add(this.txt_tenSP);
            this.groupBox1.Controls.Add(this.lbl_trangthai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Thông tin chi tiết sản phẩm";
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Image = global::QuanLyBanHang.Properties.Resources.if_Close_18910231;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(770, 38);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(56, 62);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbmasp
            // 
            this.cbbmasp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmasp.FormattingEnabled = true;
            this.cbbmasp.Location = new System.Drawing.Point(102, 33);
            this.cbbmasp.Margin = new System.Windows.Forms.Padding(2);
            this.cbbmasp.Name = "cbbmasp";
            this.cbbmasp.Size = new System.Drawing.Size(163, 21);
            this.cbbmasp.TabIndex = 10;
            this.cbbmasp.SelectedIndexChanged += new System.EventHandler(this.cbbmasp_SelectedIndexChanged);
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave1.Enabled = false;
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave1.Image = global::QuanLyBanHang.Properties.Resources.iconfinder_floppy_285657;
            this.btnSave1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave1.Location = new System.Drawing.Point(692, 38);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(50, 62);
            this.btnSave1.TabIndex = 8;
            this.btnSave1.Text = "Lưu";
            this.btnSave1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Visible = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // txtIDSP
            // 
            this.txtIDSP.Enabled = false;
            this.txtIDSP.Location = new System.Drawing.Point(102, 33);
            this.txtIDSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDSP.Name = "txtIDSP";
            this.txtIDSP.Size = new System.Drawing.Size(163, 20);
            this.txtIDSP.TabIndex = 0;
            // 
            // cbb_loaisp1
            // 
            this.cbb_loaisp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaisp1.Enabled = false;
            this.cbb_loaisp1.FormattingEnabled = true;
            this.cbb_loaisp1.Location = new System.Drawing.Point(103, 147);
            this.cbb_loaisp1.Name = "cbb_loaisp1";
            this.cbb_loaisp1.Size = new System.Drawing.Size(162, 21);
            this.cbb_loaisp1.TabIndex = 3;
            // 
            // cbb_donvidoluong
            // 
            this.cbb_donvidoluong.AllowDrop = true;
            this.cbb_donvidoluong.Enabled = false;
            this.cbb_donvidoluong.FormattingEnabled = true;
            this.cbb_donvidoluong.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Chiếc",
            "Bộ",
            "Gói",
            "Túi",
            "Miếng",
            "Hộp"});
            this.cbb_donvidoluong.Location = new System.Drawing.Point(586, 75);
            this.cbb_donvidoluong.Name = "cbb_donvidoluong";
            this.cbb_donvidoluong.Size = new System.Drawing.Size(63, 21);
            this.cbb_donvidoluong.TabIndex = 6;
            // 
            // num_soluong
            // 
            this.num_soluong.Enabled = false;
            this.num_soluong.Location = new System.Drawing.Point(519, 74);
            this.num_soluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_soluong.Name = "num_soluong";
            this.num_soluong.Size = new System.Drawing.Size(52, 20);
            this.num_soluong.TabIndex = 5;
            this.num_soluong.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NCC.Enabled = false;
            this.cbb_NCC.FormattingEnabled = true;
            this.cbb_NCC.Location = new System.Drawing.Point(519, 33);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Size = new System.Drawing.Size(121, 21);
            this.cbb_NCC.TabIndex = 4;
            this.cbb_NCC.SelectedIndexChanged += new System.EventHandler(this.cbb_NCC_SelectedIndexChanged);
            // 
            // txt_mota
            // 
            this.txt_mota.Enabled = false;
            this.txt_mota.Location = new System.Drawing.Point(528, 108);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(121, 77);
            this.txt_mota.TabIndex = 7;
            // 
            // txt_giatien
            // 
            this.txt_giatien.Enabled = false;
            this.txt_giatien.Location = new System.Drawing.Point(102, 108);
            this.txt_giatien.Name = "txt_giatien";
            this.txt_giatien.Size = new System.Drawing.Size(163, 20);
            this.txt_giatien.TabIndex = 2;
            this.txt_giatien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giatien_KeyPress);
            // 
            // txt_tenSP
            // 
            this.txt_tenSP.Enabled = false;
            this.txt_tenSP.Location = new System.Drawing.Point(103, 73);
            this.txt_tenSP.Name = "txt_tenSP";
            this.txt_tenSP.Size = new System.Drawing.Size(163, 20);
            this.txt_tenSP.TabIndex = 1;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Location = new System.Drawing.Point(525, 198);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(10, 13);
            this.lbl_trangthai.TabIndex = 0;
            this.lbl_trangthai.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá tiền/1 đơn vị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Controls.Add(this.dgv_danhsachsp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(20, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 320);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(139, 24);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(146, 20);
            this.txtTimkiem.TabIndex = 11;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // dgv_danhsachsp
            // 
            this.dgv_danhsachsp.AllowUserToAddRows = false;
            this.dgv_danhsachsp.AllowUserToDeleteRows = false;
            this.dgv_danhsachsp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_danhsachsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSP,
            this.TenSP,
            this.LoaiSP,
            this.NCC,
            this.MoTa,
            this.Gia,
            this.SoLuong,
            this.Donvidoluong});
            this.dgv_danhsachsp.Location = new System.Drawing.Point(10, 53);
            this.dgv_danhsachsp.Name = "dgv_danhsachsp";
            this.dgv_danhsachsp.ReadOnly = true;
            this.dgv_danhsachsp.RowHeadersVisible = false;
            this.dgv_danhsachsp.RowHeadersWidth = 50;
            this.dgv_danhsachsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachsp.ShowRowErrors = false;
            this.dgv_danhsachsp.Size = new System.Drawing.Size(830, 261);
            this.dgv_danhsachsp.TabIndex = 10;
            this.dgv_danhsachsp.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachsp_RowEnter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm kiếm tên sản phẩm:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(433, 26);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(11, 13);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = ".";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Image = global::QuanLyBanHang.Properties.Resources.if_f_cross_256_282471;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(224, 11);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 42);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_capnhat.Image = global::QuanLyBanHang.Properties.Resources.if_gtk_refresh_481111;
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(43, 11);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(106, 42);
            this.btn_capnhat.TabIndex = 0;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            this.STT.Width = 50;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 70;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sảm phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 150;
            // 
            // LoaiSP
            // 
            this.LoaiSP.DataPropertyName = "LoaiSP";
            this.LoaiSP.HeaderText = "Loại sản phẩm";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.ReadOnly = true;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "NCC";
            this.NCC.HeaderText = "Nhà cung cấp";
            this.NCC.Name = "NCC";
            this.NCC.ReadOnly = true;
            this.NCC.Width = 120;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Visible = false;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá tiền";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 106;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Donvidoluong
            // 
            this.Donvidoluong.DataPropertyName = "Donvidoluong";
            this.Donvidoluong.HeaderText = "Đơn vị";
            this.Donvidoluong.Name = "Donvidoluong";
            this.Donvidoluong.ReadOnly = true;
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(899, 609);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_SanPham";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_giatien;
        private System.Windows.Forms.TextBox txt_tenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_NCC;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_danhsachsp;
        private System.Windows.Forms.NumericUpDown num_soluong;
        private System.Windows.Forms.ComboBox cbb_donvidoluong;
        private System.Windows.Forms.ComboBox cbb_loaisp1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.TextBox txtIDSP;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ComboBox cbbmasp;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvidoluong;
    }
}