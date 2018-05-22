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
    public partial class PCManager : Form
    {
        public PCManager()
        {
            InitializeComponent();
        }

        private void OrderMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doDuyDat_QLQuanGame_17DataSet.ThietBi' table. You can move, or remove it, as needed.
            this.thietBiTableAdapter.Fill(this.doDuyDat_QLQuanGame_17DataSet.ThietBi);

        }
    }
}
