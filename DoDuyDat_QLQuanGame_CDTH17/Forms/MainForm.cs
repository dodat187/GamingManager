using DoDuyDat_QLQuanGame_CDTH17.Forms;
using DoDuyDat_QLQuanGame_CDTH17.Libraries;
using System;
using System.Windows.Forms;

namespace DoDuyDat_QLQuanGame_CDTH17
{
    
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void tsmInfo_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Infomation"))
            {
                Infomation frmInfo = new Infomation();
                frmInfo.MdiParent = this;
                frmInfo.Show();
            }
            else
            {
                ActiveChildForm("Infomation");
            }

        }

        private void tsmManagerAccount_Click_1(object sender, EventArgs e)
        {
            if (!CheckExistForm("UserManager"))
            {
                UserManager frmUser = new UserManager();
                frmUser.MdiParent = this;
                frmUser.Show();
            }
            else
            {
                ActiveChildForm("UserManager");
            }
        }

        private void tsmMenuManager_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("MenuManager"))
            {
                MenuManager frmMenu = new MenuManager();
                frmMenu.MdiParent = this;
                frmMenu.Show();
            }
            else
            {
                ActiveChildForm("MenuManager");
            }
        }

        private void tsmPCManager_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("PCService"))
            {
                PCService frmPC = new PCService();
                frmPC.MdiParent = this;
                frmPC.Show();
            }
            else
            {
                ActiveChildForm("PCService");
            }
        }

        private void tsmAddUser_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("AddUser"))
            {
                AddUser frmAddUser = new AddUser();
                frmAddUser.MdiParent = this;
                frmAddUser.Show();
            }
            else
            {
                ActiveChildForm("AddUser");
            }
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("ChangePassword"))
            {
                ChangePassword frmChangePassword = new ChangePassword();
                frmChangePassword.MdiParent = this;
                frmChangePassword.Show();
            }
            else
            {
                ActiveChildForm("ChangePassword");
            }
        }

        private void tsmAddMoney_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("AddMoney"))
            {
                AddMoney frmAddMoney = new AddMoney();
                frmAddMoney.MdiParent = this;
                frmAddMoney.Show();
            }
            else
            {
                ActiveChildForm("AddMoney");
            }
        }

        private void tsmBillManager_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("BillManager"))
            {
                BillManager frmBillManager = new BillManager();
                frmBillManager.MdiParent = this;
                frmBillManager.Show();
            }
            else
            {
                ActiveChildForm("BillManager");
            }
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát chương trình không ? ","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (IdAccount.Login == true)
            {
                txtID.Text = "Chào mừng quản lý: " + IdAccount.ID_User;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmPhanQuyen_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("PhanQuyen"))
            {
                PhanQuyen frmPhanQuyen = new PhanQuyen();
                frmPhanQuyen.MdiParent = this;
                frmPhanQuyen.Show();
            }
            else
            {
                ActiveChildForm("PhanQuyen");
            }
        }
    }
}
