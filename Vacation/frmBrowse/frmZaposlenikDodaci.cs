using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.customScripts;
using Vacation.modelScripts;

namespace Vacation.frmBrowse
{
    public partial class frmZaposlenikDodaci : Form
    {
        private int _zaposlenikID;
        private static frmZaposlenikDodaci _instance = null;
        public int ZaposlenikID { get => _zaposlenikID; set => _zaposlenikID = value; }
        private frmZaposlenikDodaci()
        {
            InitializeComponent();
        }
        public static frmZaposlenikDodaci Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmZaposlenikDodaci();
                }
                return _instance;
            }
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            Zaposlenik zaposlenik = new Zaposlenik();
            zaposlenik = zaposlenik.DajListu().Find(x => x.Id == ZaposlenikID);

            txtAdresa.Text = zaposlenik.Adresa;
            txtOib.Text = zaposlenik.Oib;
            txtSpol.Text = zaposlenik.DajNazivSpola(int.Parse(zaposlenik.SpolId));
            foreach (DataRow row in Upit.DajDodatkeZaposlenika(ZaposlenikID).Rows)
            {
                dataGridView1.Rows.Add(int.Parse(row["Id"].ToString()),
                                        ZaposlenikID,
                                        row["DodatakId"].ToString(),
                                        row["Naziv"].ToString(),
                                        row["BrojDana"].ToString(),
                                        row["GodinaPrava"].ToString()
                                        );
            }
            if (dataGridView1.Rows.Count > 0)
            {
                int posljednjiRed = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[0].Selected = false;
                dataGridView1.Rows[posljednjiRed].Selected = true;
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

        private void frmZaposlenikDodaci_Load(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            ZaposlenikGodisnji zaposleniciGodisnji = new ZaposlenikGodisnji();
            List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
            foreach (var item in zaposlenik.DajListu())
            {
                if (zaposleniciGodisnji.DajListu().FindIndex(x => x.ZaposlenikId == item.Id.ToString()) >= 0)
                {
                    zaposlenici.Add(item);
                }
            }
            comboBoxZaposlenici.DataSource = zaposlenici;
            comboBoxZaposlenici.DisplayMember = "ImePrezime";
            comboBoxZaposlenici.ValueMember = "Id";
            comboBoxZaposlenici.SelectedValue = 0;
        }

        private void ZaposlenikSelected(object sender, EventArgs e)
        {
            int zaposlenikId = 0;
            int.TryParse(comboBoxZaposlenici.SelectedValue.ToString(), out zaposlenikId);
            ZaposlenikID = zaposlenikId;
            UcitajPodatke();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmZaposlenikDodaci_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }
    }
}
