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

namespace DoDuyDat_QLQuanGame_CDTH17
{
    public partial class AddUser : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        string flagAction = "add";
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnTaotk_Click(object sender, EventArgs e)
        {
            if (flagAction == "add")
            {
                NguoiDung nd = new NguoiDung();
                nd.ID_User = txtTaikhoan.Text;
                nd.ID_Password = txtMatkhau.Text;
                nd.ID_Money = int.Parse(txtMoney.Text);
                db.NguoiDungs.Add(nd);
                db.SaveChanges();
            }
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
