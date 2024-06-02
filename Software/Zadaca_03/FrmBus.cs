using DBLayer;
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
    public partial class FrmBus : Form
    {
        public FrmBus()
        {
            InitializeComponent();
        }

        private void FrmBus_Load(object sender, EventArgs e)
        {
            ShowBuses();
        }

        public void ShowBuses()
        {
            List<Bus> buses = BusRepository.GetBuses();
            dgvBus.DataSource = buses;  
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd(this);
            frmAdd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvBus.SelectedRows.Count > 0)
            {
                var selectedBus = (Bus)dgvBus.SelectedRows[0].DataBoundItem;
                FrmChange frmChange = new FrmChange(selectedBus);
                frmChange.ShowDialog();

                ShowBuses(); 
            }
            else
            {
                MessageBox.Show("Odaberite cijeli red kako bi ste uredili bus!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            {
                if (dgvBus.SelectedRows.Count > 0)
                {
                    var selectedBus = (Bus)dgvBus.SelectedRows[0].DataBoundItem;

                    var result = MessageBox.Show("Jeste sigurni da zelite obrisati bus?", "Potvrdi brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        BusRepository.DeleteBus(selectedBus.Id_bus);
                        ShowBuses();
                        MessageBox.Show("Uspjesno obrisan bus.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Odaberite cijeli red kako bi ste obrisali bus!.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            List<Bus> filteredBuses = new List<Bus>();

            foreach (Bus bus in BusRepository.GetBuses())
            {
                if (bus.Vozac.ToLower().Contains(searchText) ||
                    bus.Linija.ToLower().Contains(searchText) ||
                    bus.Status.ToLower().Contains(searchText) ||
                    bus.Naziv.ToLower().Contains(searchText))
                {
                    filteredBuses.Add(bus);
                }
            }

            dgvBus.DataSource = filteredBuses;
        }
    }
}

