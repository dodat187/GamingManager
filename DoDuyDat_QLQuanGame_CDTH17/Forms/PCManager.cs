using DoDuyDat_QLQuanGame_CDTH17.Entities;
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

namespace DoDuyDat_QLQuanGame_CDTH17.Forms
{
    public partial class PCManager : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        private ThietBi currentTB;
        string flagAction = "add";

        public PCManager()
        {
            InitializeComponent();
            lockControl();
        }

        private void PCManager_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadID();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenPC.Enabled = true;
            loadID();
            btnThem.Hide();
            btnLuu.Show();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void lockControl()
        {
            txtMaPC.Enabled = false;
            txtTenPC.Enabled = false;
            btnLuu.Hide();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void unlockControl()
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        void reset()
        {
            loadID();
            txtTenPC.Enabled = false;
            txtTenPC.Text = "";
            btnLuu.Hide();
            btnThem.Show();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void loadDataGridView()
        {
            dgvPC.DataSource = db.ThietBis.ToList();
        }
        private void loadID()
        {
            ThietBi lastDV = db.ThietBis.OrderByDescending(x => x.ID_PC).FirstOrDefault();
            string lastID = lastDV != null ? lastDV.ID_PC : "";
            string nextID = IdGenerate.genId(lastID, "PC");
            txtMaPC.Text = nextID;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentTB = (dgvPC.DataSource as List<ThietBi>).Skip(e.RowIndex).FirstOrDefault();
            bindToTextbox();
            btnThem.Hide();
            btnLuu.Show();
            btnLuu.Enabled = false;
            unlockControl();
        }

        private void dgvPC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentTB = (dgvPC.DataSource as List<ThietBi>).Skip(e.RowIndex).FirstOrDefault();
            bindToTextbox();
            btnThem.Hide();
            btnLuu.Show();
            btnLuu.Enabled = false;
            unlockControl();
        }

        void bindToTextbox()
        {
            txtMaPC.Text = currentTB.ID_PC;
            txtTenPC.Text = currentTB.TenPC;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flagAction == "add")
            {
                ThietBi tb = new ThietBi();
                tb.ID_PC = txtMaPC.Text;
                tb.TenPC = txtTenPC.Text;
                db.ThietBis.Add(tb);
                db.SaveChanges();
                reset();
                lockControl();
                MessageBox.Show("Thêm thiết bị thành công.", "Thông Báo");
            }
            if (flagAction == "update")
            {
                if (currentTB != null)
                {
                    ThietBi tb = db.ThietBis.Where(x => x.ID_PC == currentTB.ID_PC).FirstOrDefault();
                    if (tb != null)
                    {
                        tb.ID_PC = txtMaPC.Text;
                        tb.TenPC = txtTenPC.Text;
                        db.SaveChanges();
                        currentTB = null;
                        MessageBox.Show("Sửa thiết bị thành công.", "Thông Báo");
                    }
                }
                flagAction = "add";
                reset();
                lockControl();
            }
            btnThem.Show();
            btnLuu.Hide();
            loadID();
            loadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenPC.Enabled = true;
            btnLuu.Show();
            btnLuu.Enabled = true;
            btnThem.Hide();
            if (currentTB != null)
            {
                btnReset.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = false;
                flagAction = "update";
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentTB != null)
            {
                db.ThietBis.Remove(currentTB);
                db.SaveChanges();
                MessageBox.Show("Xóa thiết bị thành công.", "Thông Báo");
                loadDataGridView();
                loadID();
                currentTB = null;
            }
            lockControl();
            btnThem.Show();
            reset();
        }
    }
}
