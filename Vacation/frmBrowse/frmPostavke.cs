using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.modelScripts;

namespace Vacation.frmBrowse
{
    public partial class frmPostavke : Form
    {
        private static frmPostavke _instance = null;
        private frmPostavke()
        {
            InitializeComponent();
        }

        public static frmPostavke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmPostavke();
                }
                return _instance;
            }
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();

            Postavka postavka = new Postavka();
            foreach (var lista in postavka.DajListu())
            {
                dataGridView1.Rows.Add(lista.Kljuc,
                                        lista.Naziv,
                                        lista.Vrijednost
                                        );
            }
        }

        private void frmPostavke_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private bool IsValidInput()
        {
            string kljuc = "GranicniDatum";
            string vrijednost = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == kljuc)
            {                
                string regex = "^([0-9]{2}).([0-9]{2}).$";
                Match match = Regex.Match(vrijednost, regex);
                if (!string.IsNullOrWhiteSpace(vrijednost)
                    && match.Success
                    && int.Parse(match.Groups[1].ToString()) <= 31
                    && int.Parse(match.Groups[2].ToString()) <= 12)
                {
                    return true;
                }
            }
            else
            {
                int vrij = 0;
                if (!string.IsNullOrWhiteSpace(vrijednost)
                    && int.TryParse(vrijednost, out vrij)
                    && vrij > 0)
                {
                    return true;
                }
            }            
            return false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr;
            if (IsValidInput())
            {
                dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string kljuc, naziv, vrijednost;
                    kljuc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    naziv = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    vrijednost = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    Postavka postavka = new Postavka(kljuc, naziv, vrijednost);
                    postavka.Spremi();
                }
                UcitajPodatke();
            }
            else
            {                
                string kljuc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string poruka = DajPoruku(kljuc);
                dr = MessageBox.Show(poruka);
                UcitajPodatke();
            }
        }

        private string DajPoruku(string kljuc) 
        {
            switch (kljuc)
            {
                case "GranicniDatum":
                    return "Neispravan unos vrijednosti Graničnog datuma. Mora biti u formatu dd.MM. \n d = dan, M = Mjesec";
                case "Godisnji": 
                    return "Neispravan unos vrijednosti Godišnjeg.";
                default: return "Neispravan unos";
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPostavke_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }
    }
}
