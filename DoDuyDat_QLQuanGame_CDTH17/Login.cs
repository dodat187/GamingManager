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
            this.Close();
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

            var user = db.NguoiDungs.Find(_iduser);
            if (user != null)
            {
                if (user.ID_Password == _idpass)
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
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại ! Vui lòng thử lại");
            }
            //if (txtUser.Text == "admin" && txtPassword.Text == "admin")
            //{
            //    IdAccount.Login = true;
            //    MessageBox.Show("Đăng Nhập Thành Công !");
            //    frmMain.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Lỗi vui lòng thử lại !");
            //    this.Show();
            //}
        }
    }
}
