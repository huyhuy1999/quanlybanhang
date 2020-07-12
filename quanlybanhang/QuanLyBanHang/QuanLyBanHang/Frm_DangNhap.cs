using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang;
using System.Configuration;

namespace QuanLyBanHang
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
            //return new SqlConnection(@"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        }
        public DataTable checkLog(string user, string pass)
        {
            string sql = "Select UserName, Password From DangKyNDangNhap where UserName='" + user + "' and Password='" + pass + "' and Status=N'Đã kích hoạt'";
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        private void DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DangKy dk = new frm_DangKy();
            dk.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            //Xử lý khi nhấn enter
            this.AcceptButton = bt_dangnhap;
            try
            {
                //kiểm tra xem Form đã kết nối cơ sở dữ liệu chưa
                SqlConnection con = getConnect();
                this.status.Text = "Kết nối cơ sở dữ liệu thành công";
            }
            catch
            {
                this.status.Text = "Kết nối cơ sở dữ liệu thất bại";
            }
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            if (this.tb_dangnhap.TextLength == 0 || this.tb_matkhau.TextLength == 0)
            {
                this.lb_status.ForeColor = Color.Red;
                this.lb_status.Text = "Bạn chưa nhập tên đăng nhập hoặc mật khẩu";
            }
            
            else
            { 
                DataTable dt = new DataTable();
                dt=checkLog(this.tb_dangnhap.Text, this.tb_matkhau.Text);
                if (dt.Rows.Count > 0)
                {
                    //đăng nhập thành công, mở Frm_Main, đóng frm_Dangnhap
                    this.Hide();
                    Frm_Main main = new Frm_Main();
                    
                    main.UserPermision = tb_dangnhap.Text;
                    main.ShowDialog();
                }
                else
                {
                    //đăng nhập thất bại, báo lỗi
                    this.lb_status.ForeColor = Color.Red;
                    this.lb_status.Text = "Tài khoản không tồn tại hoặc chưa được phê duyệt";
                    //khi thông báo này xong phải đưa con nháy về ô txtdangnhap
                    this.tb_dangnhap.Clear();
                    this.tb_matkhau.Clear();
                    this.tb_dangnhap.Focus();
                }
            }
        }
        
        private void bt_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void tb_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_dangnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
