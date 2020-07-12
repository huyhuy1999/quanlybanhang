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
    public partial class Frm_NCC : Form
    {
        //string strCon = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_NCC()
        {
            //string strCon = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "NCC_select").Tables[0];
                dgv_NCC.AutoGenerateColumns = false;
                dgv_NCC.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgv_NCC.Rows.Count; i++)
                dgv_NCC["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        
        private void FillData_sqlHelper()
        {
            //string strCon = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "Select MaNCC, NCC from NhaCC";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgv_NCC.AutoGenerateColumns = false;
                dgv_NCC.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void Frm_NCC_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
            
        }
        private bool CheckValid()
        {
            string strError = "";
            
            if (txt_tenncc.Text.Trim() == "")
                strError = "Bạn chưa nhập tên nhà cung cấp";
            if (txt_mancc.Text.Trim() == "")
                strError = "Bạn chưa nhập mã nhà cung cấp";
            if (CheckExist() == true)
                strError = "Mã này đã tồn tại";

            if (strError != "")
            {
                MessageBox.Show(strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private bool CheckExist()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "NCC_SelectByTen", txt_tenncc.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            string MaNCC = txt_mancc.Text.Trim();
            string NCC = txt_tenncc.Text.Trim();
            
            try
            {

                SqlHelper.ExecuteNonQuery(strCon, "NCC_Insert", MaNCC, NCC);
                FillData_sqlHelper();
                txt_tenncc.Clear();
                txt_mancc.Clear();
                txt_mancc.Focus();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string NCC = dgv_NCC.CurrentRow.Cells["NCC"].Value.ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + NCC, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "NCC_delete", NCC);
                FillData_SP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
