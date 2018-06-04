using DoDuyDat_QLQuanGame_CDTH17.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoDuyDat_QLQuanGame_CDTH17
{
    public partial class BillManager : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();

        public BillManager()
        {
            InitializeComponent();
        }

        Connect cn = new Connect();

        private void BillManager_Load(object sender, EventArgs e)
        {
            cbbMaHD.DataSource = cn.XDL("select * from HoaDon");
            cbbMaHD.DisplayMember = "MaHD";
            dgvHD.Enabled = false;
            txtTongtien.Enabled = false;
            btnInHD.Enabled = false;
            btnXoaHD.Enabled = false;
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cbbMaHD.Text.Length == 0)
            {
                MessageBox.Show("Chưa Nhập Mã Hóa Đơn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnXoaHD.Enabled = true;
                btnInHD.Enabled = true;
                dgvHD.DataSource = cn.XDL("select MaHD, TenDV, DonGia, SoluongDV, ThanhTien from DichVu, ChiTietHoaDon where ChiTietHoaDon.MaDV=DichVu.MaDV and ChiTietHoaDon.MaHD='" + cbbMaHD.Text.ToString() + "'");
                txtTongtien.Text = cn.XDL("select sum(ThanhTien) as TongTien from ChiTietHoaDon where MaHD='" + cbbMaHD.Text.ToString() + "'").Rows[0][0].ToString();
                btnXoaHD.Enabled = true;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            cn.DDL("Delete from ChiTietHoaDon where MaHD='" + cbbMaHD.Text.ToString() + "'");
            cn.DDL("Delete from HoaDon where MaHD='" + cbbMaHD.Text.ToString() + "'");
            cbbMaHD.ResetText();
            txtTongtien.ResetText();
            dgvHD.DataSource = cn.XDL("select MaHD, TenDV, DonGia, SoluongDV, ThanhTien from DichVu, ChiTietHoaDon where ChiTietHoaDon.MaDV=DichVu.MaDV and ChiTietHoaDon.MaHD='" + cbbMaHD.Text.ToString() + "'");
            btnXoaHD.Enabled = false;
            btnInHD.Enabled = false;
            cbbMaHD.DataSource = cn.XDL("select * from HoaDon");
            cbbMaHD.DisplayMember = "MaHD";
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            crv.PrintReport();
        }
    }
}
