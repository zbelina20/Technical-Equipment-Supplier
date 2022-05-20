using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace Technical_Equipment_Supplier
{


    public partial class FrmLogin : Form
    {
        string username = "nastavnik";
        string password = "lozinka";
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Greška",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Greška", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmHomeScreen frmHomeScreen = new FrmHomeScreen();
                    Hide();
                    frmHomeScreen.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
