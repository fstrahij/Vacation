using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.frmEdit;
using Vacation.modelScripts;

namespace Vacation.frmBrowse
{
    public partial class frmDodaci : Form
    {
        private static frmDodaci _instance = null;
        private frmDodaci()
        {
            InitializeComponent();
        }
        public static frmDodaci Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmDodaci();
                }
                return _instance;
            }
        }

        private void frmTipoviGodisnjih_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            Dodatak dodatak = new Dodatak();
            foreach (var item in dodatak.DajListu())
            {
                dataGridView1.Rows.Add(
                                    item.Id,
                                    item.Naziv,
                                    item.BrojDana,
                                    item.GodinaPrava
                    );
            }
            HasRows();
        }

        private void HasRows()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnDeaktivirajSve.Enabled = btnDeaktiviraj.Enabled = btnUredi.Enabled = true;
            }
            else
            {
                btnDeaktivirajSve.Enabled = btnDeaktiviraj.Enabled = btnUredi.Enabled = false;
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dodaci_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }

        private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new frmDodaciEditor(this, btnNovi.Text))
            {
                forma.ShowDialog();
            }
        }

        private void UrediClick(object sender, EventArgs e)
        {
            using (var forma = new frmDodaciEditor(this, btnUredi.Text))
            {
                forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                forma.Naziv = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                forma.BrojDana = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                forma.GodinaPrava = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                forma.ShowDialog();
            }
        }

        private void DeaktivirajClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Dodatak dodatak = new Dodatak();
                dodatak.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dodatak.Deaktiviraj();
                UcitajPodatke();
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Dodatak dodatak = new Dodatak();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dodatak.Id = int.Parse(row.Cells[0].Value.ToString());
                    dodatak.Deaktiviraj();
                }
                UcitajPodatke();
            }
        }
    }
}
