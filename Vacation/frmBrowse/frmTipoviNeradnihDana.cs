using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacation
{
    public partial class TipoviNeradnihDanaForm : Form
    {
        private static TipoviNeradnihDanaForm _instance = null;
        private TipoviNeradnihDanaForm()
        {
            InitializeComponent();
        }

        public static TipoviNeradnihDanaForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TipoviNeradnihDanaForm();
                }
                return _instance;
            }
        }

        public void UcitajPodatke()
        {
            TipNeradnihDana tip = new TipNeradnihDana();
            dataGridView1.Rows.Clear();
            foreach (var item in tip.DajListu())
            {
                dataGridView1.Rows.Add(item.Id, item.Naziv, item.Boja);
            }
            HasRows();
            PostaviBoju();
        }

        private void PostaviBoju()
        {
            string boja = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                boja = row.Cells["Boja"].Value.ToString();
                if (!string.IsNullOrWhiteSpace(boja))
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(boja);
                }
            }
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

        private void TipoviNeradnihDanaForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new TipEditor(this, btnNovi.Text))
            {               
                forma.ShowDialog();
            }
        }

        private void UrediClick(object sender, EventArgs e)
        {
            using (var forma = new TipEditor(this, btnUredi.Text))
            {
                forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                forma.Naziv = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                forma.Boja = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                forma.ShowDialog();
            }
        }

        private void DeaktivirajClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                TipNeradnihDana tip = new TipNeradnihDana();
                tip.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                tip.Deaktiviraj();
                UcitajPodatke();
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni da želite obrisati SVE?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                TipNeradnihDana tip = new TipNeradnihDana();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    tip.Id = int.Parse(row.Cells[0].Value.ToString());
                    tip.Deaktiviraj();
                }
                UcitajPodatke();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoviNeradnihDanaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }
    }
}
