using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoDuyDat_QLQuanGame_CDTH17
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private SqlConnection con;
        private DataTable dt = new DataTable("NguoiDung");
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select * From NguoiDung Where (ID_User = @iduser) And (ID_Password = @idpass)";
            command.Parameters.Add("@iduser", SqlDbType.NVarChar, 20).Value = txtTaikhoan.Text;
            command.Parameters.Add("@idpass", SqlDbType.NVarChar, 20).Value = txtMatkhau.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cn.DDL("Update NguoiDung set ID_Password='" + txtNhaplaiMK.Text.ToString() + "' where ID_User='" + txtTaikhoan.Text.ToString() + "' and ID_Password='" + txtMatkhau.Text.ToString() + "'");
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
                this.Focus();
            }
        }
    }
}
