using DoDuyDat_QLQuanGame_CDTH17.Entities;
using DoDuyDat_QLQuanGame_CDTH17.Libraries;
using System;

using System.Windows.Forms;

namespace DoDuyDat_QLQuanGame_CDTH17
{
    public partial class Login : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        public Login()
        {
            InitializeComponent();
        }

        MainForm frmMain = new MainForm();

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void reset()
        {
            txtPassword.Text = "";
            txtUser.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _iduser = txtUser.Text;
            string _idpass = txtPassword.Text;
            string _idroles = "Admin";

            var user = db.NguoiDungs.Find(_iduser);
            var userroles = db.QuanTris.Find(_iduser);
            var roles = db.QuanTris.Find(_idroles);

            if (user != null && userroles != null)
            {
                if (user.ID_Password == _idpass && roles.PhanQuyen == "Admin")
                {
                    MainForm frmMain = new MainForm();

                    IdAccount.ID_User = _iduser;
                    IdAccount.ID_Pass = _idpass;

                    IdAccount.Login = true;
                    MessageBox.Show("Đăng nhập thành công");
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu ! Vui lòng thử lại");
                    reset();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản này không được phép truy cập Quản Trị !!! \n Vui lòng thử lại hoặc liên hệ Quản Lý Cửa Hàng !!!");
                reset();
            }
        }
    }
}
