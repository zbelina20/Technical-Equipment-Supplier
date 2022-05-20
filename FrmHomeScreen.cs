using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technical_Equipment_Supplier
{
    public partial class FrmHomeScreen : Form
    {
        public FrmHomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRequest frmRequest = new FrmRequest();
            frmRequest.ShowDialog();
        }
    }
}
