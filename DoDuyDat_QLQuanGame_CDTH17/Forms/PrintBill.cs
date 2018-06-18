using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoDuyDat_QLQuanGame_CDTH17.Forms
{
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }

        Connect cn = new Connect();

        private void button1_Click(object sender, EventArgs e)
        {
            crv.PrintReport();
        }

        public void funData1(TextBox MaHD)
        {
            txtMaHD.Text = MaHD.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintBill_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadReport();
            funData1(txtMaHD);
            txtMaHD.Enabled = false;
            txtTongtien.Enabled = false;
            dgvHD.Hide();
        }
        void loadDataGridView()
        {
            DataTable t = new DataTable();
            t.Columns.Add("MaHD", typeof(string));
            t.Columns.Add("TenDV", typeof(string));
            t.Columns.Add("DonGia", typeof(float));
            t.Columns.Add("SoluongDV", typeof(float));
            t.Columns.Add("ThanhTien", typeof(float));
            dgvHD.DataSource = t;
            dgvHD.Columns["MaHD"].DefaultCellStyle.BackColor = Color.AliceBlue;
            dgvHD.Columns["TenDV"].DefaultCellStyle.BackColor = Color.AliceBlue;
            dgvHD.Columns["DonGia"].DefaultCellStyle.BackColor = Color.AliceBlue;
            dgvHD.Columns["SoluongDV"].DefaultCellStyle.BackColor = Color.AliceBlue;
            dgvHD.Columns["ThanhTien"].DefaultCellStyle.BackColor = Color.AliceBlue;
        }
        void loadReport()
        {
            dgvHD.DataSource = cn.XDL("select MaHD, TenDV, DonGia, SoluongDV, ThanhTien from DichVu, ChiTietHoaDon where ChiTietHoaDon.MaDV=DichVu.MaDV and ChiTietHoaDon.MaHD='" + txtMaHD.Text.ToString() + "'");
            txtTongtien.Text = cn.XDL("select sum(ThanhTien) as TongTien from ChiTietHoaDon where MaHD='" + txtMaHD.Text.ToString() + "'").Rows[0][0].ToString();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHD", typeof(string));
            dt.Columns.Add("TenDV", typeof(string));
            dt.Columns.Add("DonGia", typeof(float));
            dt.Columns.Add("SoluongDV", typeof(float));
            dt.Columns.Add("ThanhTien", typeof(float));
            foreach (DataGridViewRow dgv in dgvHD.Rows)
            {
                dt.Rows.Add(dgv.Cells["MaHD"].Value, dgv.Cells["TenDV"].Value, dgv.Cells["DonGia"].Value, dgv.Cells["SoluongDV"].Value, dgv.Cells["ThanhTien"].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("report.xml");
            CR cr = new CR();
            cr.SetDataSource(ds);
            crv.ReportSource = cr;
        }
    }
}
