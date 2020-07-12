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
    public partial class Frm_ThanhToanDiem : Form
    {
        public delegate void DoEventt();
        public event DoEventt ReFreashDataGridd;
        //string strCon = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_ThanhToanDiem()
        {
            InitializeComponent();
        }
        public string CUID { set; get; }
        public string CUName { set; get; }
        public string PhoneNumber { set; get; }
        public string Amount { set; get; }
        public string Point { set; get; }

        private void Frm_ThanhToanDiem_Load(object sender, EventArgs e)
        {
            txt_maKH.Text = CUID;
            txt_tenKH.Text = CUName;
            txt_SDT.Text = PhoneNumber;
            txt_tongtien.Text = Amount;
            txt_tichdiem.Text = Point;
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            string MaKH = txt_maKH.Text.Trim();
            string TenKH = txt_tenKH.Text.Trim();
            string SDT = txt_SDT.Text.Trim();
            int Tong;
            Int32.TryParse(txt_tongtien.Text, out Tong);
            int TichDiem;
            Int32.TryParse(txt_tichdiem.Text, out TichDiem);
            //string str = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            try
            {
                
                Tong -= TichDiem * 1000000;
                TichDiem -= TichDiem;
                SqlHelper.ExecuteNonQuery(strCon, "KhachHang_TichDiem", MaKH, TenKH, SDT, Tong, TichDiem);
                sqlCn.Open();
                string s = @"Select [MaKH], [TenKH], [SDT], [TongTien], [TichDiem] from [KhachHang] where MaKH=@MaKH";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@MaKH", MaKH);
                SqlDataReader read = sqlcm.ExecuteReader();
                if (read.Read())
                {
                    txt_tongtien.Text = read["TongTien"].ToString();
                    txt_tichdiem.Text = read["TichDiem"].ToString();
                    MessageBox.Show("Thanh toán điểm cho khách hàng thành công");
                    this.ReFreashDataGridd();
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
