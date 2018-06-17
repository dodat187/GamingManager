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
    public partial class AddMoney : Form
    {
        private DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();

        public AddMoney()
        {
            InitializeComponent();
            txtAMN.KeyPress += new KeyPressEventHandler(txtAMN_keypress);
        }

        public static string lbUs2;

        void txtAMN_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void loadCbUser()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-TV115F9\\SQLEXPRESS;Initial Catalog=DoDuyDat_QLQuanGame_17;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select ID_User,ID_Money from NguoiDung", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbUS.DataSource = dt;
            cbbUS.DisplayMember = "ID_User";
            cbbUS.ValueMember = "ID_Money";


        }

        private void AddMoney_Load(object sender, EventArgs e)
        {
            loadCbUser();
            lockControl();
        }
        void lockControl()
        {
            txtPMN.Enabled = false;
            txtTMN.Enabled = false;
            txtAMN.Text = "";
        }
        private new void Update()
        {
            try
            {
                double pm = Convert.ToDouble(txtPMN.Text);
                int am = Convert.ToInt32(txtAMN.Text);
                double tong = (pm + am);
                txtTMN.Text = tong.ToString();
            }
            catch (Exception)
            {

            }
        }

        Connect cn = new Connect();

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            if (this.cbbUS.Text == "manager" || this.cbbUS.Text == "admin")
            {
                MessageBox.Show("Không thể nạp tiền cho tài khoản này.", "Thông Báo");
            }
            else
            {
                cn.DDL("Update NguoiDung set ID_Money='" + txtTMN.Text.ToString() + "' where ID_User='" + cbbUS.Text.ToString() + "'");
                MessageBox.Show("Nạp tiền thành công !!!", "Thông Báo");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPMN_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void txtAMN_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void cbbUS_SelectedValueChanged(object sender, EventArgs e)
        {
            txtPMN.Text = cbbUS.SelectedValue.ToString();
        }

        private void txtTMN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
