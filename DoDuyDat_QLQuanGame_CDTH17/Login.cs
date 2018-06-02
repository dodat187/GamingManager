using DoDuyDat_QLQuanGame_CDTH17.Entities;
using DoDuyDat_QLQuanGame_CDTH17.Libraries;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoDuyDat_QLQuanGame_CDTH17
{
    public partial class Login : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        private SqlConnection con;
        private DataTable dt = new DataTable("NguoiDung");
        private SqlDataAdapter da = new SqlDataAdapter();
        private void connect()
        {
            string cnn = "Data Source=DESKTOP-TV115F9\\SQLEXPRESS;Initial Catalog=DoDuyDat_QLQuanGame_17;Integrated Security=True";
            try
            {
                con = new SqlConnection(cnn);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới CSDL.", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void disconnect()
        {
            con.Close();
            con.Dispose();
            con = null;
        }

        public Login()
        {
            InitializeComponent();
        }

        MainForm frmMain = new MainForm();

        private void Login_Load(object sender, EventArgs e)
        {
            connect();
            this.AcceptButton = btnLogin;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtUser.Focus();
            this.txtPassword.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
            else
            {
                this.Focus();
            }
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
                if (txtUser.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống", "Thông Báo");
                    reset();
                }
                else
                {
                    MessageBox.Show("Tài khoản này không được phép truy cập Quản Trị !!! \n Vui lòng thử lại hoặc liên hệ Quản Lý Cửa Hàng !!!" , "Thông Báo");
                    reset();
                }
                
            }
        }
    }
}
