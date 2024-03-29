﻿using System;
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
        private static GeneratorNeradnihDanaForm _instance = null;
        private int _godina;
        public int Godina { get => _godina; set => _godina = value; }

        private GeneratorNeradnihDanaForm()
        {
            InitializeComponent();
        }
        public static GeneratorNeradnihDanaForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GeneratorNeradnihDanaForm();
                }
                return _instance;
            }
        }
        private void PostaviAlignHeader()
        {
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PostaviAlignHeader();
            groupBoxAll.Hide();            
        }

        private void CheckBoxAllClick(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell odabrano;
            if (checkBoxAll.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    odabrano = (DataGridViewCheckBoxCell)row.Cells["Odabir"];
                    row.Cells["Odabir"].Value = odabrano.TrueValue;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    odabrano = (DataGridViewCheckBoxCell)row.Cells["Odabir"];
                    row.Cells["Odabir"].Value = odabrano.FalseValue;
                }
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
                        dan.Datum = DateTime.Parse(Godina.ToString()+"-01-01", null, DateTimeStyles.None);
                        dan.TipId = row.Cells[2].Value.ToString();
                        dan.Spremi();
                    }
                    else if(DateTime.TryParseExact(row.Cells[4].Value.ToString(), pattern, null, DateTimeStyles.None, out datum))
                    {
                        dan.Naziv = row.Cells[3].Value.ToString();
                        dan.Datum = datum;
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
                            dan.Datum = datumOd;
                            dan.TipId = row.Cells[2].Value.ToString();
                            dan.Spremi();
                            datumOd = datumOd.AddDays(7);
                        }
                    }                  
                }
            }
            DialogResult dr = MessageBox.Show("Uspješno generirano!");
            txtGodina.Text = "";
            groupBoxAll.Hide();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneratorNeradnihDanaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }
    }
}
