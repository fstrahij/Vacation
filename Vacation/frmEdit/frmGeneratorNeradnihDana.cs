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
    public partial class GeneratorNeradnihDanaForm : Form
    {
        public GeneratorNeradnihDanaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxAll.Hide();
        }

        private void CheckBoxAllClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Odabir"].Value = checkBoxAll.Checked;
            }
        }

        private void DodajTemplateClick(object sender, EventArgs e)
        {
            int godina;
            if (int.TryParse(txtGodina.Text, out godina))
            {
                if (ValidirajGodinu(godina))
                {
                    groupBoxAll.Show();
                    dataGridView1.Rows.Clear();
                    UcitajPodatke();
                }
            }
        }

        private bool ValidirajGodinu(int pGodina)
        {
            return (pGodina >= 2000 && pGodina <= 2100) ? true : false;
        }

        private void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            NeradaniDanTemplate template = new NeradaniDanTemplate();
            TipNeradnihDana tip = new TipNeradnihDana();
            string datum = "";
            foreach (var lista in template.DajListu())
            {
                if (string.IsNullOrWhiteSpace(lista.Dan) || string.IsNullOrWhiteSpace(lista.Mjesec) || lista.Mjesec == "99")
                {
                    datum = "";
                }
                else
                {
                    datum = lista.Dan + "." + lista.Mjesec + "." + txtGodina.Text + ".";
                }                
                dataGridView1.Rows.Add( false,
                                        lista.Id,
                                        lista.TipId,
                                        lista.Naziv,
                                        datum,
                                        tip.DajNazivTipa(lista.TipId)
                                        );
            }
        }

        private void GenerirajNeradneDaneClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == "1")
                {
                    Console.WriteLine(row.Cells[3].Value.ToString() + " " +
                                     row.Cells[4].Value.ToString() + " " +
                                     row.Cells[2].Value.ToString()
                                    );                    
                }
            }
        }
    }
}
