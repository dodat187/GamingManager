using System;
using DoDuyDat_QLQuanGame_CDTH17.Entities;
using DoDuyDat_QLQuanGame_CDTH17.Libraries;
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
    public partial class MenuManager : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        private DichVu currentDV;
        string flagAction = "add";
        public MenuManager()
        {
            InitializeComponent();
            lockControl();
        }

        private void MenuManager_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadID();

        }
        private void loadDataGridView()
        {
            dgvDichVu.DataSource = db.DichVus.ToList();
        }
        private void loadID()
        {
            DichVu lastDV = db.DichVus.OrderByDescending(x => x.MaDV).FirstOrDefault();
            string lastID = lastDV != null ? lastDV.MaDV : "";
            string nextID = IdGenerate.genId(lastID, "DV");
            txtMaSP.Text = nextID;
        }
        void lockControl()
        {
            btnLuu.Hide();
            btnThem.Show();
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtDonGia.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReset.Enabled = true;
            btnThoat.Enabled = true;
            
        }

        void unlockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReset.Enabled = true;
            btnThoat.Enabled = true;
        }
        void resetText()
        {
            txtTenSP.Text = "";
            txtDonGia.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            unlockText();
            resetText();
            loadID();
            btnThem.Hide();
            btnLuu.Show();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flagAction == "add")
            {
                DichVu dv = new DichVu();
                dv.MaDV = txtMaSP.Text;
                dv.TenDV = txtTenSP.Text;
                dv.DonGia = int.Parse(txtDonGia.Text);
                db.DichVus.Add(dv);
                db.SaveChanges();
                reset();
            }
            if (flagAction == "update")
            {
                if (currentDV != null)
                {
                    DichVu dv = db.DichVus.Where(x => x.MaDV == currentDV.MaDV).FirstOrDefault();
                    if (dv != null)
                    {
                        dv.MaDV = txtMaSP.Text;
                        dv.TenDV = txtTenSP.Text;
                        dv.DonGia = int.Parse(txtDonGia.Text);
                        db.SaveChanges();
                        currentDV = null;
                    }
                    reset();
                    lockControl();
                    btnLuu.Enabled = false;
                    btnReset.Enabled = true;
                }
                flagAction = "add";
            }
            btnThem.Show();
            reset();
            loadID();
            loadDataGridView();
        }
        void reset()
        {
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            lockControl();
            btnThem.Enabled = true;
            btnReset.Enabled = true;
            loadID();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentDV != null)
            {
                db.DichVus.Remove(currentDV);
                db.SaveChanges();
                loadDataGridView();
                loadID();
                reset();
                currentDV = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bindToTextbox();
            unlockText();
            if (currentDV != null)
            {
                btnReset.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = false;
                flagAction = "update";
            }
            btnLuu.Show();
            btnThem.Hide();
        }


        void unlockText()
        {
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = true;
            txtDonGia.Enabled = true;
        }

        void lockText()
        {
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtDonGia.Enabled = false;
        }


        private void dgvDichVu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentDV = (dgvDichVu.DataSource as List<DichVu>).Skip(e.RowIndex).FirstOrDefault();
            bindToTextbox();
            flagAction = "update";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Show();
            btnLuu.Enabled = true;
            unlockText();
            btnThem.Hide();
        }

        void bindToTextbox()
        {
            txtMaSP.Text = currentDV.MaDV;
            txtTenSP.Text = currentDV.TenDV;
            txtDonGia.Text = Convert.ToString(currentDV.DonGia);
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentDV = (dgvDichVu.DataSource as List<DichVu>).Skip(e.RowIndex).FirstOrDefault();
            bindToTextbox();
            lockText();
            lockControl();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            
        }
    }
}
