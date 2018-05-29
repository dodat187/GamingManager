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
    public partial class PCService : Form
    {
        public PCService()
        {
            InitializeComponent();
        }

        private void PCService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doDuyDat_QLQuanGame_17DataSet.ChiTietSuDung' table. You can move, or remove it, as needed.
            this.chiTietSuDungTableAdapter.Fill(this.doDuyDat_QLQuanGame_17DataSet.ChiTietSuDung);
            // TODO: This line of code loads data into the 'doDuyDat_QLQuanGame_17DataSet.ChiTietSuDung' table. You can move, or remove it, as needed.
            this.chiTietSuDungTableAdapter.Fill(this.doDuyDat_QLQuanGame_17DataSet.ChiTietSuDung);

        }
    }
}
