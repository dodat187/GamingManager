using DoDuyDat_QLQuanGame_CDTH17.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoDuyDat_QLQuanGame_CDTH17.Forms
{
    public partial class ThemTien : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();

        public ThemTien()
        {
            InitializeComponent();
        }

        Connect cn = new Connect();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNaptien_Click(object sender, EventArgs e)
        {
            if (this.txtUS.Text == "manager" || this.txtUS.Text == "admin")
            {
                MessageBox.Show("Không thể nạp tiền cho tài khoản này.", "Thông Báo");
                this.Close();
            }
            else
            {
                cn.DDL("Update NguoiDung set ID_Money='" + txtTMN.Text.ToString() + "' where ID_User='" + txtUS.Text.ToString() + "'");
                MessageBox.Show("Nạp tiền thành công !!!", "Thông Báo");
                this.Close();
            }

            //if (currentND != null)
            //{
            //    flagAction = "update";
            //    if (flagAction == "update")
            //    {
            //        if (currentND != null)
            //        {
            //            NguoiDung nd = db.NguoiDungs.Where(x => x.ID_User == currentND.ID_User).FirstOrDefault();
            //            if (nd != null)
            //            {
            //                nd.ID_Money = int.Parse(txtTongtien.Text);
            //                db.SaveChanges();
            //                currentND = null;
            //            }
            //            flagAction = "add";
            //        }
            //    }
            //}
            //this.Close();
        }

        public void funData1(TextBox txtUser)
        {
            txtUS.Text = txtUser.Text;
        }
        public void funData2(TextBox txtMoney)
        {
            txtPMN.Text = txtMoney.Text;
        }

        private void ThemTien_Load(object sender, EventArgs e)
        {
            txtUS.Enabled = false;
            txtPMN.Enabled = false;
            txtAMN.Enabled = true;
            txtTMN.Enabled = false;
            txtAMN.Text = "0";
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

        private void txtPMN_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void txtAMN_TextChanged(object sender, EventArgs e)
        {
            Update();
        }
    }
}
