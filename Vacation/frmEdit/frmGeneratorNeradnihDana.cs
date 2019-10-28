using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.modelScripts;

namespace Vacation
{
    public partial class GeneratorNeradnihDanaForm : Form
    {
        private int _godina;

        public int Godina { get => _godina; set => _godina = value; }

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
            if (int.TryParse(txtGodina.Text, out _godina))
            {
                if (ValidirajGodinu(Godina))
                {
                    groupBoxAll.Show();
                    dataGridView1.Rows.Clear();
                    UcitajPodatke();
                }
                else
                {
                    groupBoxAll.Hide();
                }
            }
        }

        private bool ValidirajGodinu(int pGodina)
        {
            return ((pGodina >= 2000 && pGodina <= 2100)) ? true : false;
        }

        private void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            NeradaniDanTemplate template = new NeradaniDanTemplate();
            TipNeradnihDana tip = new TipNeradnihDana();
            string datum = "";
            foreach (var lista in template.DajListu())
            {
                if (string.IsNullOrWhiteSpace(lista.Dan) || string.IsNullOrWhiteSpace(lista.Mjesec))
                {
                    datum = "";
                }
                else if (lista.Mjesec == "99")
                {
                    datum = lista.Dan;
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
            string pattern = "dd.MM.yyyy.";
            DateTime datum, datumOd, datumDo;            
            NeradniDan dan = new NeradniDan();
            dan.Id = 0;
            DataGridViewCheckBoxCell odabrano;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                odabrano = (DataGridViewCheckBoxCell)row.Cells["Odabir"];
                if (odabrano.Value == odabrano.TrueValue)
                {
                    if (string.IsNullOrWhiteSpace(row.Cells[4].Value.ToString()))
                    {
                        dan.Naziv = row.Cells[3].Value.ToString();
                        dan.TipId = row.Cells[2].Value.ToString();
                        dan.Spremi();
                    }
                    else if(DateTime.TryParseExact(row.Cells[4].Value.ToString(), pattern, null, DateTimeStyles.None, out datum))
                    {
                        dan.Naziv = row.Cells[3].Value.ToString();
                        dan.Datum = datum.Month + "-" + datum.Day + "-" + datum.Year;
                        dan.TipId = row.Cells[2].Value.ToString();
                        dan.Spremi();
                    }
                    else
	                {
                        datumOd = new DateTime(Godina, 1, 1);
                        datumDo = new DateTime(Godina, 12, 31);

                        while ((int)datumOd.DayOfWeek != int.Parse(row.Cells[4].Value.ToString()))
                        {
                            datumOd = datumOd.AddDays(1);
                        }
                        while (datumOd < datumDo)
                        {                        
                            dan.Naziv = row.Cells[3].Value.ToString();
                            dan.Datum = datumOd.Month + "-" + datumOd.Day + "-" + datumOd.Year;
                            dan.TipId = row.Cells[2].Value.ToString();
                            dan.Spremi();
                            datumOd = datumOd.AddDays(7);
                        }
                    }                  
                }
            }
        }
    }
}
