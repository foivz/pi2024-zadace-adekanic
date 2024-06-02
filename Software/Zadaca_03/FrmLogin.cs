using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca_03.Models;
using Zadaca_03.Repository;

namespace Zadaca_03
{
    public partial class FrmLogin : Form
    {
        public static Admin LoggedAdmin { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoggedAdmin = AdministratorRepository.GetAdmin(txtUsername.Text);

                if (LoggedAdmin != null && LoggedAdmin.Password == txtPassword.Text)
                {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmBus frmBus = new FrmBus();
                    Hide();
                    frmBus.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
