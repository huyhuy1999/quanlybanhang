using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class Frm_NhapHangReport : Form
    {
        public Frm_NhapHangReport()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 816;
            float HeightPerscpective = (float)Height / 488;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }
        private void Frm_NhapHangReport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

            try
            {
                if (DateTime.Parse(dpTuNgay.Text) <= DateTime.Parse(dpDenNgay.Text))
                {
                    DataSet ds = SqlHelper.ExecuteDataset(strCon, "BaoCaoNhapHang",
                    DateTime.Parse(dpTuNgay.Text),
                    DateTime.Parse(dpDenNgay.Text));

                    if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Tables[0].Columns[0].ColumnName = "Số HĐ nhập";
                        ds.Tables[0].Columns[1].ColumnName = "Ngày nhập";
                        ds.Tables[0].Columns[2].ColumnName = "Mã SP";
                        ds.Tables[0].Columns[3].ColumnName = "Tên SP";
                        ds.Tables[0].Columns[4].ColumnName = "Giá nhập";
                        ds.Tables[0].Columns[5].ColumnName = "Nhà cung cấp";
                        ds.Tables[0].Columns[6].ColumnName = "Số lượng nhập";
                        ds.Tables[0].Columns[7].ColumnName = "Đơn vị đo";
                        dgvKetQua.DataSource = ds.Tables[0];
                        btnXuatExcel.Visible = true;
                        lbldatanotfound.Visible = false;
                    }
                    else
                    {
                        lbldatanotfound.Visible = true;
                        lbldatanotfound.Text = "Không có dữ liệu hiển thị";
                    }
                }
                else
                {
                    MessageBox.Show("Từ ngày phải nhỏ hơn Đến ngày");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XuatExcel(sfd.FileName);
            }
        }
        private void XuatExcel(string file)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Nhập hàng";
                Microsoft.Office.Interop.Excel.Range head = worksheet.Range["A1", "I1"];
                head.MergeCells = true;
                head.Value2 = "Báo Cáo Nhập Hàng";
                head.Font.Bold = true;
                head.Font.Size = 20;
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                //from
                Microsoft.Office.Interop.Excel.Range fromDate = worksheet.Range["A3", "C3"];
                fromDate.MergeCells = true;
                fromDate.Value2 = "Từ ngày: " + dpTuNgay.Text;
                fromDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //to
                Microsoft.Office.Interop.Excel.Range toDate = worksheet.Range["F3", "H3"];
                toDate.MergeCells = true;
                toDate.Value2 = "Đến ngày: " + dpDenNgay.Text;
                toDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                // storing header part in Excel  
                for (int i = 1; i < dgvKetQua.Columns.Count + 1; i++)
                {
                    worksheet.Cells[5, i] = dgvKetQua.Columns[i - 1].HeaderText;
                }
                worksheet.Range["A5", "I5"].Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvKetQua.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKetQua.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 6, j + 1] = dgvKetQua.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs(file);

                // see the excel sheet behind the program  
                if (MessageBox.Show("Xuất tệp excel thành công!") == DialogResult.OK)
                    app.Visible = true;
            }
            catch
            {
                MessageBox.Show("Xuất tệp excel thất bại!");
            }
        }
    }
}
