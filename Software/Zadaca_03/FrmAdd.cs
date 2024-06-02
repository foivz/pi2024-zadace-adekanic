using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca_03.Models;
using Zadaca_03.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadaca_03
{
    public partial class FrmAdd : Form
    {
        private FrmBus _frmBus;

        public FrmAdd(FrmBus frmBus)
        {
            InitializeComponent();
            _frmBus = frmBus;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBus.Text) ||
                string.IsNullOrWhiteSpace(txtDriver.Text) ||
                string.IsNullOrWhiteSpace(txtLine.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text) ||
                string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Ispunite sva polja.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtIdBus.Text, out int id))
            {
                var existingBus = BusRepository.GetBus(id);
                if (existingBus != null)
                {
                    MessageBox.Show("ID već postoji! Unesite drugi ID!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var bus = new Bus
                {
                    Id_bus = id,
                    Vozac = txtDriver.Text,
                    Linija = txtLine.Text,
                    Status = txtStatus.Text,
                    Naziv = txtNaziv.Text
                };

                BusRepository.AddBus(bus);
                MessageBox.Show("Uspjesno dodan bus!.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                _frmBus.ShowBuses();

                this.Close();
            }
            else
            {
                MessageBox.Show("Unesite ispravan ID!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtIdBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriver_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLinija_Click(object sender, EventArgs e)
        {

        }

        private void lblVozac_Click(object sender, EventArgs e)
        {

        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
