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

namespace Zadaca_03
{
    public partial class FrmChange : Form
    {
        private Bus _bus;
        public FrmChange(Bus selectedBus)
        {
            InitializeComponent();
            _bus = selectedBus;
        }
        private void FrmChange_Load(object sender, EventArgs e)
        {
            {
                if (_bus != null)
                {
                    txtId.Text = _bus.Id_bus.ToString();
                    txtDriver.Text = _bus.Vozac;
                    txtLine.Text = _bus.Linija;
                    txtStatus.Text = _bus.Status;
                    txtName.Text = _bus.Naziv;

                    txtId.Enabled = false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtDriver.Text) ||
                string.IsNullOrWhiteSpace(txtLine.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ispunite sva polja!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _bus.Vozac = txtDriver.Text;
            _bus.Linija = txtLine.Text;
            _bus.Status = txtStatus.Text;
            _bus.Naziv = txtName.Text;

            
            BusRepository.UpdateBus(_bus);

            MessageBox.Show("Uspješno promjenjeni atributi!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriver_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
