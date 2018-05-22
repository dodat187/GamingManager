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
    public partial class BillManager : Form
    {
        public BillManager()
        {
            InitializeComponent();
        }

        private void BillManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doDuyDat_QLQuanGame_17DataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.doDuyDat_QLQuanGame_17DataSet.ChiTietHoaDon);


        }
    }
}
