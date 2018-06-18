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
    public partial class PhanQuyen : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        //private QuanTri currentQT;
        //string flagAction = "add";
        public PhanQuyen()
        {
            InitializeComponent();
        }

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

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            connect();
            // TODO: This line of code loads data into the 'doDuyDat_QLQuanGame_17DataSet.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.doDuyDat_QLQuanGame_17DataSet.NguoiDung);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetquyen_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select * From QuanTri Where (ID_User = @iduser)";
            command.Parameters.Add("@iduser", SqlDbType.NVarChar, 20).Value = cbbUser.Text;
            command.Parameters.Add("@phanquyen", SqlDbType.NVarChar, 20).Value = cbbPhanquyen.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //QuanTri qt = new QuanTri();
                //qt.ID_User = cbbUser.Text;
                //if (qt.ID_User != null)
                //{
                cn.DDL("Update QuanTri set PhanQuyen='" + cbbPhanquyen.Text.ToString() + "' where ID_User='" + cbbUser.Text.ToString() + "'");
                MessageBox.Show("Update quyền hạn thành công !!!", "Thông Báo");
            }
            else
            {
                cn.DDL("insert into QuanTri(ID_User, PhanQuyen) values ('" + cbbUser.Text.ToString() + "','" + cbbPhanquyen.Text.ToString() + "')");
                MessageBox.Show("Set quyền hạn thành công !!!", "Thông Báo");
            }
        }
        void reset()
        {
            cbbPhanquyen.Text = "";
            cbbUser.Text = "";
        }

    }
}
