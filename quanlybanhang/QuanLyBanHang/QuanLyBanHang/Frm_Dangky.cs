using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang;
using System.Text.RegularExpressions;
using System.Configuration;

namespace QuanLyBanHang
{
    public partial class frm_DangKy : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public frm_DangKy()
        {
            InitializeComponent();
        }
     
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if(CheckValid()==false)
                return;
            string HoTen = txt_hoten.Text.Trim();
            string TenDangNhap = txt_tendangnhap.Text.Trim();
            string MatKhau = txt_matkhau.Text.Trim();
            DateTime Ngaysinh = DateTime.Parse(date_ngaysinh.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string SDT = txt_sdt.Text.Trim();
            string DiaChi = txt_diachi.Text.Trim();
            string GioiTinh = "";
            if (radio_nam.Checked == true)
            {
                GioiTinh = "Nam";
            }
            if (radio_nu.Checked == true)
            {
                GioiTinh = "Nữ";
            }
            string Email = txt_email.Text.Trim();
            
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "Regis_Insert", TenDangNhap, MatKhau, HoTen, Ngaysinh, SDT, DiaChi, GioiTinh, Email);
                FillData_sqlHelper();
                MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        } 

        private void FillData_sqlHelper()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "SELECT * FROM DangKyNDangNhap";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông Báo");
            }
        }

        private bool CheckValid()
        {
            string strError = "";

            if (txt_email.Text.Trim() == "")
                strError = "Bạn chưa nhập địa chỉ Email";
            if (txt_diachi.Text.Trim() == "")
                strError = "Bạn chưa nhập Địa chỉ";
            if (txt_sdt.Text.Trim() == "")
                strError = "Bạn chưa nhập Số điện thoại";
            if (txt_matkhau.Text.Trim() == "")
                strError = "Bạn chưa nhập Mật khẩu";
            if (txt_tendangnhap.Text.Trim() == "")
                strError = "Bạn chưa nhập Tên đăng nhập";
            if (CheckExist() == true)
                strError = "Tên đăng nhập này đã tồn tại. Vui lòng nhập tên đăng nhập khác";
            if (txt_hoten.Text.Trim() == "")
                strError = "Bạn chưa nhập Họ và tên";
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            {
                if (reg.IsMatch(this.txt_email.Text) || (txt_email.Text.Trim() == ""))
                    this.emailstt.Text = "";
                else
                {
                    this.emailstt.Text = "Địa chỉ mail không hợp lệ";
                    
                    return false;
                }
            }
            if (strError != "")
            {
                MessageBox.Show(strError, "Thông Báo");
                return false;
            }
            return true;
        }

        public bool CheckExist()
        {
            try
            {
        SqlDataReader reader=SqlHelper.ExecuteReader(strCon,"DangNhapInfo_SelectByID",txt_tendangnhap.Text.Trim());
                 if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_huydangky_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            
        }
        
    }
}
