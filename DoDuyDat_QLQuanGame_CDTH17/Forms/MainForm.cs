using DoDuyDat_QLQuanGame_CDTH17.Forms;
using DoDuyDat_QLQuanGame_CDTH17.Libraries;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoDuyDat_QLQuanGame_CDTH17
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        public static string lbus;
        private SqlConnection con;
        private DataTable dt = new DataTable("QuanTri");
        private SqlDataAdapter da = new SqlDataAdapter();
        Connect cn = new Connect();
        private void connect()
        {
            string cnn = "Data Source=DESKTOP-TV115F9\\SQLEXPRESS;Initial Catalog=DoDuyDat_QLQuanGame_17;Integrated Security=True";
            try
            {
                con = new SqlConnection(cnn);
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối tới CSDL.", "Lỗi", MessageBoxButtons.OK);
            }
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
            DialogResult h = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connect();
            txtID.Text += "     " + IdAccount.ID_User;
            if (IdAccount.Login == true)
            {

            }
            else
            {
                tsmMenuManager.Enabled = false;
                tsmPCManager.Enabled = false;
            }
        }

        void loadPhanQuyen()
        {

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

        private void tsmCreatBill_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("CreatBill"))
            {
                CreatBill frmCreatBill = new CreatBill();
                frmCreatBill.MdiParent = this;
                frmCreatBill.Show();
            }
            else
            {
                ActiveChildForm("CreatBill");
            }
        }

        private void tsmPCService_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("PCService"))
            {
                PCService frmPCService = new PCService();
                frmPCService.MdiParent = this;
                frmPCService.Show();
            }
            else
            {
                ActiveChildForm("PCService");
            }
        }

        private void tsmPCManager_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("PCManager"))
            {
                PCManager frmPCManager = new PCManager();
                frmPCManager.MdiParent = this;
                frmPCManager.Show();
            }
            else
            {
                ActiveChildForm("PCManager");
            }
        }
    }
}
