using DoDuyDat_QLQuanGame_CDTH17.Entities;
using DoDuyDat_QLQuanGame_CDTH17.Forms;
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
            txtSotien.Enabled = false;
            txtMatkhau.Enabled = false;
            btnLuu.Hide();
            btnDoimk.Enabled = false;
            btnXoatk.Enabled = false;
            btnNaptien.Enabled = false;
        }

        void unlockControl()
        {
            txtTaikhoan.Enabled = true;
            txtSotien.Enabled = true;
            txtMatkhau.Enabled = true;
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
            resetText();
            unlockControl();
            btnTaotk.Hide();
            btnLuu.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "" || txtMatkhau.Text == "" )
            {
                MessageBox.Show("Các trường không được để trống !", "Thông Báo");
            }
            else { 
                if (flagAction == "add")
                {
                    NguoiDung nd = new NguoiDung();
                    QuanTri qt = new QuanTri();
                    nd.ID_User = txtTaikhoan.Text;
                    nd.ID_Password = txtMatkhau.Text;
                    qt.ID_User = txtTaikhoan.Text;
                    qt.PhanQuyen = "User";
                    System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex("[^0-9-]+");
                    if (txtSotien.Text.Length > 0)
                    {
                        if (re.IsMatch(txtSotien.Text))
                        {
                            MessageBox.Show("Số tiền phải nhập bằng số !", "Thông Báo");
                            reset();
                        }
                        else
                        {
                            nd.ID_Money = int.Parse(txtSotien.Text);
                            db.NguoiDungs.Add(nd);
                            db.QuanTris.Add(qt);
                            db.SaveChanges();
                            MessageBox.Show("Tạo tài khoản thành công !", "Thông Báo");
                        }
                    }
                    else
                    {
                        if (txtSotien.Text.Length <= 0)
                        {
                            MessageBox.Show("Số tiền không được để trống", "Thông Báo");
                            reset();
                        }
                    }
                }
            }
            btnLuu.Hide();
            btnTaotk.Show();
            reset();
            loadDataGridView();
            lockControl();
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            txtMatkhau.Enabled = true;
            if (currentND != null)
            {
                flagAction = "update";
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
            loadDataGridView();
            reset();
            lockControl();
        }
        public delegate void delPassData(TextBox text);
        private void btnNaptien_Click(object sender, EventArgs e)
        {
            ThemTien frmThemTien = new ThemTien();
            delPassData del = new delPassData(frmThemTien.funData);
            del(this.txtTaikhoan);
            frmThemTien.Show();

            
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
        void resetText()
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtSotien.Text = "";
            lockControl();
        }
        void reset()
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtSotien.Text = "";           
            lockControl();
            btnLuu.Hide();
            btnTaotk.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNguoiDung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentND = (dgvNguoiDung.DataSource as List<NguoiDung>).Skip(e.RowIndex).FirstOrDefault();
            bindToTextbox();
            btnLuu.Hide();
            btnTaotk.Show();
            unlockControl2();
        }

        void bindToTextbox()
        {
            txtTaikhoan.Text = currentND.ID_User;
            txtMatkhau.Text = currentND.ID_Password;
            txtSotien.Text = Convert.ToString(currentND.ID_Money);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

    }
}
