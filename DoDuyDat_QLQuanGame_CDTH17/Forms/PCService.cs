using DoDuyDat_QLQuanGame_CDTH17.Entities;
using DoDuyDat_QLQuanGame_CDTH17.Libraries;
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

namespace DoDuyDat_QLQuanGame_CDTH17.Forms
{
    public partial class PCService : Form
    {

        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        private ChiTietSuDung currentCTSD;
        public PCService()
        {
            InitializeComponent();
            lockControl();
        }

        private SqlConnection con;
        private DataTable dt = new DataTable("ChiTietSuDung");
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

        private void PCService_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadID();
            loadcbbPC();
            loadcbbUser();
            btnEnd.Enabled = false;
            btnTinhtien.Enabled = false;
            txtHidden.Hide();
            connect();
        }

        private void loadDataGridView()
        {
            dgvCTSD.DataSource = db.ChiTietSuDungs.ToList();
        }

        private void loadID()
        {
            ChiTietSuDung lastDV = db.ChiTietSuDungs.OrderByDescending(x => x.MaCTSD).FirstOrDefault();
            string lastID = lastDV != null ? lastDV.MaCTSD : "";
            string nextID = IdGenerate.genId(lastID, "CTSD");
            txtMaCTSD.Text = nextID;
        }

        private void loadcbbPC()
        {
            cbbPC.DataSource = cn.XDL("select * from ThietBi");
            cbbPC.DisplayMember = "ID_PC";
        }

        private void loadcbbUser()
        {
            cbbUser.DataSource = cn.XDL("select * from NguoiDung");
            cbbUser.DisplayMember = "ID_User";
        }

        void lockControl()
        {
            txtMaCTSD.Enabled = false;
            txtStart.Enabled = false;
            txtEnd.Enabled = false;
            txtTime.Enabled = false;
            txtTien.Enabled = false;

        }

        void resetTime()
        {
            txtStart.Text = "";
            txtEnd.Text = "";
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select * From ChiTietSuDung Where (ID_User = @iduser) or (ID_PC = @idpc)";
            command.Parameters.Add("@iduser", SqlDbType.NVarChar, 20).Value = cbbUser.Text;
            command.Parameters.Add("@idpc", SqlDbType.NVarChar, 20).Value = cbbPC.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tài khoản hoặc máy đang có người sử dụng. Không thể khởi động", "Thông Báo");
            }
            else
            {
                txtStart.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtEnd.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                cn.DDL("insert into ChiTietSuDung(MaCTSD, ID_PC, ID_User, Stime, Etime) values ('" + txtMaCTSD.Text.ToString() + "','" + cbbPC.Text.ToString() + "','" + cbbUser.Text.ToString() + "','" + txtStart.Text.ToString() + "','" + txtEnd.Text.ToString() + "')");
                MessageBox.Show("Đã khởi động máy", "Thông Báo");
                resetTime();
                loadID();
                loadDataGridView();
            }
            //txtStart.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //txtEnd.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //cn.DDL("insert into ChiTietSuDung(MaCTSD, ID_PC, ID_User, Stime, Etime) values ('" + txtMaCTSD.Text.ToString() + "','" + cbbPC.Text.ToString() + "','" + cbbUser.Text.ToString() + "','" + txtStart.Text.ToString() + "','" + txtEnd.Text.ToString() + "')");
            //MessageBox.Show("Đã khởi động máy", "Thông Báo");
            //resetTime();
            //loadID();
            //loadDataGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void bindToTextbox()
        {
            txtMaCTSD.Text = currentCTSD.MaCTSD;
            cbbPC.Text = currentCTSD.ID_PC;
            cbbUser.Text = currentCTSD.ID_User;
            txtStart.Text = currentCTSD.Stime.ToString();
            txtEnd.Text = currentCTSD.Etime.ToString();
        }

        private void dgvCTSD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEnd.Enabled = true;
            btnStart.Enabled = false;
            btnTinhtien.Enabled = false;
            currentCTSD = (dgvCTSD.DataSource as List<ChiTietSuDung>).Skip(e.RowIndex).FirstOrDefault();
            bindToTextbox();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            btnTinhtien.Enabled = true;
            txtEnd.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            cn.DDL("update ChiTietSuDung set Etime ='" + txtEnd.Text.ToString() + "' where ID_PC='" + cbbPC.Text.ToString() + "'");
            loadDataGridView();
            string st = Convert.ToDateTime(txtStart.Text).ToLongTimeString();
            string et = Convert.ToDateTime(txtEnd.Text).ToLongTimeString();
            TimeSpan duration = DateTime.Parse(et).Subtract(DateTime.Parse(st));
            txtTime.Text = duration.ToString();
            txtHidden.Text = duration.TotalSeconds.ToString();
            txtTien.Text = ((Convert.ToInt32(txtHidden.Text) * 100 / 60) / 1000).ToString();
            btnEnd.Enabled = false;
            btnTinhtien.Enabled = true;
        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder(1000);
            strBuilder.Append("IT GAMING");
            strBuilder.AppendLine();
            strBuilder.Append("252 Nguyễn Trãi - Thanh Xuân - Hà Nội");
            strBuilder.AppendLine();
            strBuilder.AppendLine(new string('-', 30));
            strBuilder.Append("Thời gian vào: " + txtStart.Text.ToString() + "");
            strBuilder.AppendLine();
            strBuilder.Append("Thời gian ra: " + txtEnd.Text.ToString() + "");
            strBuilder.AppendLine();
            strBuilder.Append("Thời gian sử dụng: " + txtTime.Text.ToString() + "");
            strBuilder.AppendLine();
            strBuilder.AppendLine(new string('-', 30));
            strBuilder.Append("Thành Tiền: " + txtTien.Text.ToString() + "");
            //int tien = int.Parse(txtTien.Text);

            MessageBox.Show(strBuilder.ToString(), "Hóa Đơn");
            cn.DDL("delete from ChiTietSuDung where ID_PC='" + cbbPC.Text.ToString() + "'");
            cn.DDL("update NguoiDung set ID_Money = ID_Money - '" + txtTien.Text.ToString() + "'  where ID_User='" + cbbUser.Text.ToString() + "'");
            cbbPC.ResetText();
            cbbUser.ResetText();
            txtStart.ResetText();
            txtEnd.ResetText();
            txtTien.ResetText();
            txtTime.ResetText();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
            btnTinhtien.Enabled = false;
            loadDataGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbPC.ResetText();
            cbbUser.ResetText();
            txtStart.ResetText();
            txtEnd.ResetText();
            txtTien.ResetText();
            txtTime.ResetText();
            resetTime();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
            btnTinhtien.Enabled = false;
            loadcbbPC();
            loadcbbUser();
            loadDataGridView();
            loadID();
        }
    }
}
