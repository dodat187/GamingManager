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
    public partial class UserManager : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        private NguoiDung currentND;
        string flagAction = "add";
        public UserManager()
        {
            InitializeComponent();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            lockControl();
        }

        void lockControl()
        {
            txtTaikhoan.Enabled = false;
            txtMatkhau.Enabled = false;
            txtSotien.Enabled = false;
            btnLuu.Hide();
            btnDoimk.Enabled = false;
            btnXoatk.Enabled = false;
            btnNaptien.Enabled = false;
        }

        void unlockControl()
        {
            txtTaikhoan.Enabled = true;
            txtMatkhau.Enabled = true;
            txtSotien.Enabled = true;
        }

        void unlockControl2()
        {
            txtTaikhoan.Enabled = false;
            txtMatkhau.Enabled = true;
            txtSotien.Enabled = false;
            btnDoimk.Enabled = true;
            btnXoatk.Enabled = true;
            btnNaptien.Enabled = true;
        }

        private void loadDataGridView()
        {
            dgvNguoiDung.DataSource = db.NguoiDungs.ToList();
        }
        private void btnTaotk_Click(object sender, EventArgs e)
        {
            unlockControl();
            btnTaotk.Hide();
            btnLuu.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flagAction == "add")
            {
                NguoiDung nd = new NguoiDung();
                nd.ID_User = txtTaikhoan.Text;
                nd.ID_Password = txtMatkhau.Text;
                nd.ID_Money = int.Parse(txtSotien.Text);
                db.NguoiDungs.Add(nd);
                db.SaveChanges();
            }
            btnLuu.Hide();
            btnTaotk.Show();
            reset();
            loadDataGridView();
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            txtMatkhau.Enabled = true;
            if (flagAction == "add")
            {
                NguoiDung nd = new NguoiDung();
                nd.ID_Password = txtMatkhau.Text;
                db.NguoiDungs.Add(nd);
                db.SaveChanges();
            }
            if (flagAction == "update")
            {
                if (currentND != null)
                {
                    NguoiDung nd = db.NguoiDungs.Where(x => x.ID_User == currentND.ID_User).FirstOrDefault();
                    if (nd != null)
                    {
                        nd.ID_Password = txtMatkhau.Text;
                        db.SaveChanges();
                        currentND = null;
                    }
                    flagAction = "add";
                    btnLuu.Enabled = false;
                    btnReset.Enabled = true;
                }
            }
        }

        private void btnNaptien_Click(object sender, EventArgs e)
        {
            AddMoney frmAddMoney = new AddMoney();
            frmAddMoney.Show();
        }

        private void btnXoatk_Click(object sender, EventArgs e)
        {
            if (currentND != null)
            {
                db.NguoiDungs.Remove(currentND);
                db.SaveChanges();
                reset();
                currentND = null;
            }
            loadDataGridView();
            lockControl();
        }

        void reset()
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtSotien.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNguoiDung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentND = (dgvNguoiDung.DataSource as List<NguoiDung>).Skip(e.RowIndex).FirstOrDefault();
            bindToTextbox();
            unlockControl2();
        }

        void bindToTextbox()
        {
            txtTaikhoan.Text = currentND.ID_User;
            txtMatkhau.Text = currentND.ID_Password;
            txtSotien.Text = Convert.ToString(currentND.ID_Money); ;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
