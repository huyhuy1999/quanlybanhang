namespace QuanLyBanHang
{
    partial class Fm_UserManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_UserManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NameOfUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdanhsachnhanvien = new System.Windows.Forms.DataGridView();
            this.btnPheduyet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbb_Status);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_NameOfUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(612, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Image = global::QuanLyBanHang.Properties.Resources.iconfinder_search_magnifying_glass_find_103857;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(496, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbb_Status
            // 
            this.cbb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Location = new System.Drawing.Point(334, 71);
            this.cbb_Status.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(142, 21);
            this.cbb_Status.TabIndex = 2;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(334, 25);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(142, 20);
            this.txt_SDT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại:";
            // 
            // txt_NameOfUser
            // 
            this.txt_NameOfUser.Location = new System.Drawing.Point(99, 74);
            this.txt_NameOfUser.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NameOfUser.Name = "txt_NameOfUser";
            this.txt_NameOfUser.Size = new System.Drawing.Size(142, 20);
            this.txt_NameOfUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên người dùng:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(99, 25);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(142, 20);
            this.txt_UserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdanhsachnhanvien);
            this.groupBox2.Location = new System.Drawing.Point(9, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(612, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvdanhsachnhanvien
            // 
            this.dgvdanhsachnhanvien.AllowUserToAddRows = false;
            this.dgvdanhsachnhanvien.AllowUserToDeleteRows = false;
            this.dgvdanhsachnhanvien.AllowUserToResizeColumns = false;
            this.dgvdanhsachnhanvien.AllowUserToResizeRows = false;
            this.dgvdanhsachnhanvien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvdanhsachnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.UserName,
            this.NameOfUser,
            this.Phone,
            this.Status});
            this.dgvdanhsachnhanvien.Location = new System.Drawing.Point(7, 17);
            this.dgvdanhsachnhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdanhsachnhanvien.Name = "dgvdanhsachnhanvien";
            this.dgvdanhsachnhanvien.ReadOnly = true;
            this.dgvdanhsachnhanvien.RowHeadersVisible = false;
            this.dgvdanhsachnhanvien.RowTemplate.Height = 24;
            this.dgvdanhsachnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdanhsachnhanvien.ShowRowErrors = false;
            this.dgvdanhsachnhanvien.Size = new System.Drawing.Size(601, 236);
            this.dgvdanhsachnhanvien.TabIndex = 0;
            // 
            // btnPheduyet
            // 
            this.btnPheduyet.BackColor = System.Drawing.Color.White;
            this.btnPheduyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPheduyet.Image = global::QuanLyBanHang.Properties.Resources.iconfinder_General_Office_35_3592854;
            this.btnPheduyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPheduyet.Location = new System.Drawing.Point(25, 185);
            this.btnPheduyet.Margin = new System.Windows.Forms.Padding(2);
            this.btnPheduyet.Name = "btnPheduyet";
            this.btnPheduyet.Size = new System.Drawing.Size(91, 39);
            this.btnPheduyet.TabIndex = 3;
            this.btnPheduyet.Text = "Xét duyệt";
            this.btnPheduyet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPheduyet.UseVisualStyleBackColor = false;
            this.btnPheduyet.Click += new System.EventHandler(this.btnPheduyet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Image = global::QuanLyBanHang.Properties.Resources.if_free_27_616650;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(144, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên đăng nhập";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // NameOfUser
            // 
            this.NameOfUser.DataPropertyName = "NameOfUser";
            this.NameOfUser.HeaderText = "Tên nhân viên";
            this.NameOfUser.Name = "NameOfUser";
            this.NameOfUser.ReadOnly = true;
            this.NameOfUser.Width = 150;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Fm_UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 505);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPheduyet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Fm_UserManage";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Fm_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachnhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdanhsachnhanvien;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPheduyet;
        private System.Windows.Forms.TextBox txt_NameOfUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}