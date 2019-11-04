using System;
using System.Drawing;
using System.Windows.Forms;
using Vacation.frmEdit;

namespace Vacation
{
    public partial class TemplateEditorForm : Form
    {
        public TemplateEditorForm()
        {
            InitializeComponent();
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            NeradaniDanTemplate template = new NeradaniDanTemplate();
            TipNeradnihDana tip = new TipNeradnihDana();
            foreach (var lista in template.DajListu())
            {
                dataGridView1.Rows.Add(lista.Id, 
                                        lista.TipId, 
                                        lista.Naziv, 
                                        lista.Dan, 
                                        lista.Mjesec, 
                                        tip.DajNazivTipa(lista.TipId)
                                        );               
            }
            HasRows();
            PostaviBoju();
        }

        private void PostaviBoju()
        {
            TipNeradnihDana tip = new TipNeradnihDana();
            string boja = "";
            string id = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                id = row.Cells["TipId"].Value.ToString();
                boja = tip.DajBojuTipa(id);
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

        private void TemplateEditorForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();            
        }

        private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new frmTemplateEditor(this, btnNovi.Text))
            {
                forma.Id = 0;
                forma.Naziv = forma.Dan = forma.Mjesec = forma.TipId = "";                 
                forma.ShowDialog();
            }
        }

        private void UrediClick(object sender, EventArgs e)
        {
            using (var forma = new frmTemplateEditor(this, btnUredi.Text))
            {
                forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                forma.TipId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                forma.Naziv = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                forma.Dan = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                forma.Mjesec = dataGridView1.CurrentRow.Cells[4].Value.ToString();                
                forma.ShowDialog();
            }
        }

        private void DeaktivirajClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NeradaniDanTemplate template = new NeradaniDanTemplate();
                template.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                template.Deaktiviraj();
                UcitajPodatke();
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NeradaniDanTemplate template = new NeradaniDanTemplate();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    template.Id = int.Parse(row.Cells[0].Value.ToString());
                    template.Deaktiviraj();
                }
                UcitajPodatke();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
