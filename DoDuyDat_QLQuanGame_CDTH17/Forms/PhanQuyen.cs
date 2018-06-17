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
    public partial class PhanQuyen : Form
    {
        DoDuyDat_QLQuanGame_17Entities db = new DoDuyDat_QLQuanGame_17Entities();
        private QuanTri currentQT;
        string flagAction = "add";
        public PhanQuyen()
        {
            InitializeComponent();
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doDuyDat_QLQuanGame_17DataSet.QuanTri' table. You can move, or remove it, as needed.
            this.quanTriTableAdapter.Fill(this.doDuyDat_QLQuanGame_17DataSet.QuanTri);
            // TODO: This line of code loads data into the 'doDuyDat_QLQuanGame_17DataSet.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.doDuyDat_QLQuanGame_17DataSet.NguoiDung);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetquyen_Click(object sender, EventArgs e)
        {
            if (currentQT != null)
            {
                flagAction = "update";
            }
            else
            {
                flagAction = "add";
            }
        }
        void reset()
        {
            cbbPhanquyen.Text = "";
            cbbUser.Text = "";
        }
        void chucnang()
        {
            if (flagAction == "add")
            {
                QuanTri qt = new QuanTri();
                qt.ID_User = cbbUser.ToString();
                qt.PhanQuyen = cbbPhanquyen.ToString();
                db.QuanTris.Add(qt);
                db.SaveChanges();
                reset();
                MessageBox.Show("Set OK", "Thông Báo");
            }
            if (flagAction == "update")
            {
                if (currentQT != null)
                {
                    QuanTri qt = db.QuanTris.Where(x => x.ID_User == currentQT.ID_User).FirstOrDefault();
                    if (qt != null)
                    {
                        qt.ID_User = cbbUser.Text;
                        qt.PhanQuyen = cbbPhanquyen.Text;
                        db.QuanTris.Add(qt);
                        db.SaveChanges();
                        currentQT = null;
                    }
                    reset();
                    MessageBox.Show("Update OK", "Thông Báo");
                }
                flagAction = "add";
            }
        }
    }
}
