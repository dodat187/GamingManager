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
        private NguoiDung currentND;
        string flagAction = "add";

        public ThemTien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNaptien_Click(object sender, EventArgs e)
        {
            if (flagAction == "add")
            {
                NguoiDung nd = new NguoiDung();
                nd.ID_User = txtTaikhoan.Text;
                nd.ID_Password = nd.ID_Password;
                nd.ID_Money = nd.ID_Money + int.Parse(txtSotien.Text);
                db.NguoiDungs.Add(nd);
                db.SaveChanges();
            }
                if (flagAction == "update")
                {
                    if (currentND != null)
                    {
                        NguoiDung nd = db.NguoiDungs.Where(x => x.ID_User == currentND.ID_User).FirstOrDefault();
                        if (nd != null)
                        {
                            nd.ID_User = txtTaikhoan.Text;
                            nd.ID_Password = nd.ID_Password;
                            nd.ID_Money = nd.ID_Money + int.Parse(txtSotien.Text);
                            db.SaveChanges();
                            currentND = null;
                        }
                        flagAction = "add";
                    }
                }
        }
        public void funData(TextBox txtForm1)
        {
            txtTaikhoan.Text = txtForm1.Text;
        }

        private void ThemTien_Load(object sender, EventArgs e)
        {
            txtTaikhoan.Enabled = false;

        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
