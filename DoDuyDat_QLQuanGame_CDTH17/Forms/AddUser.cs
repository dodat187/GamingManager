using DoDuyDat_QLQuanGame_CDTH17.Entities;
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
    public partial class AddUser : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        //string flagAction = "add";
        //private NguoiDung currentND;
        public AddUser()
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


        private void btnTaotk_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select * From NguoiDung Where (ID_User = @iduser)";
            command.Parameters.Add("@iduser", SqlDbType.NVarChar, 20).Value = txtTaikhoan.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.", "Thông báo");
                reset();
            }
            else
            {
                cn.DDL("insert into NguoiDung(ID_User, ID_Password, ID_Money) values ('" + txtTaikhoan.Text.ToString() + "','" + txtMatkhau.Text.ToString() + "','" + txtMoney.Text.ToString() + "')");
                MessageBox.Show("Tạo tài khoản thành công.", "Thông báo");
                this.Close();
            }

        }
        void reset()
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtMoney.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            connect();
        }
    }
}
