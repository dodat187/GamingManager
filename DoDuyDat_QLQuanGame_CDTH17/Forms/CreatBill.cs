using DoDuyDat_QLQuanGame_CDTH17.Entities;
using DoDuyDat_QLQuanGame_CDTH17.Forms;
using DoDuyDat_QLQuanGame_CDTH17.Libraries;
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
    public partial class CreatBill : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        Connect cn = new Connect();
        public static string MaHD;
        public string MaCTHD;
        public CreatBill()
        {
            InitializeComponent();
            lockControl();
        }

        private void CreatBill_Load(object sender, EventArgs e)
        {
            loadID();
            txtMaHD.Enabled = false;
            txtMaHD.ReadOnly = true;
            loadListDV();
            btnThoat.Enabled = false;
            btnCreatHD.Enabled = false;
            btUpdate.Enabled = false;

        }

        void loaddgvHD()
        {
            txtMaHD2.Enabled = false;
            txtMaHD2.Text = txtMaHD.Text;
            txtCTHD.Enabled = false;
            txtTenDA.Enabled = false;
            txtTongTien.Enabled = false;
            //txtMaHD2.Text = cn.XDL("select MaHD from ChiTietHoaDon where MaHD='" + txtMaHD.Text.ToString() + "'").ToString();
            dgvCTHD.DataSource = cn.XDL("select MaCTHD, TenDV, SoluongDV, ThanhTien from HoaDon, ChiTietHoaDon, DichVu where HoaDon.MaHD=ChiTietHoaDon.MaHD and ChiTietHoaDon.MaDV=DichVu.MaDV and HoaDon.MaHD='" + txtMaHD.Text.ToString() + "'");
            txtTongTien.Text = cn.XDL("select sum(ThanhTien) as TongTien from ChiTietHoaDon where MaHD='" + txtMaHD.Text.ToString() + "'").Rows[0][0].ToString();
            txtCTHD.DataBindings.Clear();
            txtTenDA.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            txtCTHD.DataBindings.Add("Text", dgvCTHD.DataSource, "MaCTHD");
            txtTenDA.DataBindings.Add("Text", dgvCTHD.DataSource, "TenDV");
            txtSL.DataBindings.Add("Text", dgvCTHD.DataSource, "SoluongDV");
        }

        void lockControl()
        {
            txtMaHD.Enabled = false;
        }

        private void loadID()
        {
            HoaDon lastDV = db.HoaDons.OrderByDescending(x => x.MaHD).FirstOrDefault();
            string lastID = lastDV != null ? lastDV.MaHD : "";
            string nextID = IdGenerate.genId(lastID, "HD");
            txtMaHD.Text = nextID;
        }


        void loadListDV()
        {
            string sql = "select * from DichVu";
            for (int i = 0; i < cn.XDL(sql).Rows.Count; i++)
            {
                ListDV.Items.Add(cn.XDL(sql).Rows[i][1].ToString());
            }
        }

        private void btPick_Click(object sender, EventArgs e)
        {
            //while (ListDV.SelectedItems.Count > 0)
            //{

            //}
            for (int i = 0; i < ListDV.SelectedItems.Count; i++)
            {
                ListDVCheck.Items.Add(ListDV.SelectedItems[0]);
                ListDV.Items.Remove(ListDV.SelectedItems[0]);
            }
        }

        private void btUnpick_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListDVCheck.SelectedItems.Count; i++)
            {
                ListDV.Items.Add(ListDVCheck.SelectedItems[0]);
                ListDVCheck.Items.Remove(ListDVCheck.SelectedItems[0]);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ListDV.Items.Clear();
            ListDVCheck.Items.Clear();
            string sql = "select * from DichVu";
            for (int i = 0; i < cn.XDL(sql).Rows.Count; i++)
            {
                ListDV.Items.Add(cn.XDL(sql).Rows[i][1].ToString());
            }
        }



        private void btnThietlap_Click(object sender, EventArgs e)
        {

            if (ListDVCheck.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa nhập món ăn.");
            }
            else
            {
                btnThoat.Enabled = true;
                button1.Enabled = false;
                btnCreatHD.Enabled = true;
                cn.DDL("insert into HoaDon values('" + txtMaHD.Text.ToString() + "','" + 0 + "')");
                for (int i = 0; i < ListDVCheck.Items.Count; i++)
                {
                    string MaDV = cn.XDL("select MaDV from DichVu where TenDV=N'" + ListDVCheck.Items[i].ToString().Trim() + "'").Rows[0][0].ToString().Trim();
                    string ThanhTien = cn.XDL("select DonGia from DichVu where MaDV='" + MaDV + "'").Rows[0][0].ToString().Trim();
                    cn.DDL("insert into ChiTietHoaDon(MaHD, MaCTHD, MaDV, SoluongDV, ThanhTien) values('" + txtMaHD.Text.ToString() + "','" + i.ToString() + "','" + MaDV + "','" + 1 + "','" + Convert.ToInt32(ThanhTien) + "')");
                }
                for (int j = 0; j == ListDVCheck.Items.Count; j++)
                {
                    cn.DDL("insert into ChiTietHoaDon(Stt) values('" + j.ToString() + "')");
                }
                loaddgvHD();
            }

        }

        private void dgvCTHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btUpdate.Enabled = true;
            txtCTHD.DataBindings.Clear();
            txtTenDA.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            txtCTHD.DataBindings.Add("Text", dgvCTHD.DataSource, "MaCTHD");
            txtTenDA.DataBindings.Add("Text", dgvCTHD.DataSource, "TenDV");
            txtSL.DataBindings.Add("Text", dgvCTHD.DataSource, "SoluongDV");
            txtMaHD2.Text = cn.XDL("select MaHD from HoaDon where MaHD='" + txtMaHD.Text.ToString() + "'").Rows[0][0].ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string MaDV = cn.XDL("select MaDV from DichVu where TenDV=N'" + txtTenDA.Text.Trim() + "'").Rows[0][0].ToString().Trim();
            float ThanhTien = Convert.ToInt32(cn.XDL("select DonGia from DichVu where MaDV='" + MaDV + "'").Rows[0][0].ToString().Trim()) * Convert.ToInt32(txtSL.Text.Trim());
            cn.DDL("update ChiTietHoaDon set SoluongDV ='" + Convert.ToInt32(txtSL.Text.ToString()) + "', ThanhTien = '" + ThanhTien + "' where MaCTHD='" + txtCTHD.Text.ToString() + "' and MaHD ='" + txtMaHD.Text.ToString() + "' and MaDV='" + MaDV + "'");
            dgvCTHD.DataSource = cn.XDL("select MaCTHD, TenDV, SoluongDV, ThanhTien from HoaDon, ChiTietHoaDon, DichVu where HoaDon.MaHD=ChiTietHoaDon.MaHD and ChiTietHoaDon.MaDV=DichVu.MaDV and HoaDon.MaHD='" + txtMaHD.Text.ToString() + "'");
            txtTongTien.Text = cn.XDL("select sum(ThanhTien) as TongTien from ChiTietHoaDon where MaHD='" + txtMaHD.Text.ToString() + "'").Rows[0][0].ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            cn.DDL("Delete from ChiTietHoaDon where MaHD='" + txtMaHD.Text.ToString() + "'");
            cn.DDL("Delete from HoaDon where MaHD='" + txtMaHD.Text.ToString() + "'");
            this.Close();
        }
        public delegate void delPassData(TextBox text);
        private void btnCreatHD_Click(object sender, EventArgs e)
        {

            cn.DDL("Update HoaDon set TongTien='" + Convert.ToInt32(txtTongTien.Text.Trim()) + "' where MaHD='" + txtMaHD.Text.ToString() + "'");
            MessageBox.Show("Ðặt món thành công, vui lòng chờ trong giây lát.");
            this.Hide();
            PrintBill frmPrint = new PrintBill();
            delPassData del1 = new delPassData(frmPrint.funData1);
            del1(this.txtMaHD);
            frmPrint.Show();
            this.Close();

        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btUpdate.Enabled = true;
            txtCTHD.DataBindings.Clear();
            txtTenDA.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            txtCTHD.DataBindings.Add("Text", dgvCTHD.DataSource, "MaCTHD");
            txtTenDA.DataBindings.Add("Text", dgvCTHD.DataSource, "TenDV");
            txtSL.DataBindings.Add("Text", dgvCTHD.DataSource, "SoluongDV");
            txtMaHD2.Text = cn.XDL("select MaHD from HoaDon where MaHD='" + txtMaHD.Text.ToString() + "'").Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
