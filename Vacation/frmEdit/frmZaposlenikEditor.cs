﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.customScripts;
using Vacation.frmBrowse;
using Vacation.modelScripts;

namespace Vacation.frmEdit
{
    public partial class frmZaposlenikEditor : Form
    {

        private int _id;
        private string _ime, _prezime, _adresa, _oib, _spolId;

        public frmZaposlenikEditor(frmZaposlenici pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox1.Text = pGbText;
            Id = 0;
            Ime = Prezime = Adresa = Oib = SpolId = "";
        }

        public int Id { get => _id; set => _id = value; }
        public string Ime { get => _ime; set => _ime = value; }
        public string Prezime { get => _prezime; set => _prezime = value; }
        public string Adresa { get => _adresa; set => _adresa = value; }
        public string Oib { get => _oib; set => _oib = value; }
        public string SpolId { get => _spolId; set => _spolId = value; }

        private void frmZaposlenikEditor_Load(object sender, EventArgs e)
        {
            txtIme.Text = Ime;
            txtPrezime.Text = Prezime;
            txtAdresa.Text = Adresa;
            txtOib.Text = Oib;
            Zaposlenik zaposlenik = new Zaposlenik();
            comboBoxSpol.DataSource = zaposlenik.Spolovi;
            comboBoxSpol.DisplayMember = "Naziv";
            comboBoxSpol.ValueMember = "Id";
            comboBoxSpol.SelectedValue = !string.IsNullOrWhiteSpace(SpolId) ? int.Parse(SpolId.ToString()) : 0;            
        }

        private frmZaposlenici Forma { get; set; }
        
        private bool IsValidInputs()
        {
            if (!string.IsNullOrWhiteSpace(txtIme.Text) 
                && !string.IsNullOrWhiteSpace(txtPrezime.Text)
                && !string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                return true;
            }
            return false;
        }
        
        private void SpremiClick(object sender, EventArgs e)
        {
            DialogResult dr;
            if (IsValidInputs())
            {
                dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int spolId = comboBoxSpol.SelectedIndex >=0 ? comboBoxSpol.SelectedIndex + 1 : int.Parse(SpolId);
                    string oib = (!string.IsNullOrWhiteSpace(txtOib.Text)) ? txtOib.Text : "NULL";
                    string ime = Trimmer.TrimString(txtIme.Text);
                    string prezime = Trimmer.TrimString(txtPrezime.Text);
                    string adresa = Trimmer.TrimString(txtAdresa.Text);
                    oib = Trimmer.TrimString(oib);
                    Zaposlenik zaposlenik = new Zaposlenik(Id,
                                                            ime,
                                                            prezime,
                                                            spolId.ToString(),
                                                            adresa,
                                                            oib
                                                            );
                    zaposlenik.Spremi();
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
            else
            {
                string poruka = "Neispravan unos u polje Ime, Prezime ili Adresa";
                dr = MessageBox.Show(poruka);
            }
        }
    }
}
