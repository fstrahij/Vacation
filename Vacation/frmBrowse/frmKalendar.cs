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
    public partial class frmKalendar : Form
    {
        private static frmKalendar _instance = null;
        private int _godina, _zaposlenikId;
        private string _boja;
        private List<DateTime> _godisnji;
        private frmKalendar()
        {
            InitializeComponent();
        }
        public static frmKalendar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmKalendar();
                }
                return _instance;
            }
        }

        public List<DateTime> Godisnji { get => _godisnji; set => _godisnji = value; }
        public string BojaPozadine { get => _boja; set => _boja = value; }
        public int Godina { get => _godina; set => _godina = value; }
        public int ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }

        private void frmKalendar_Load(object sender, EventArgs e)
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
            TipNeradnihDana tip = new TipNeradnihDana();
            for (int i = 0; i < tip.DajListu().Count; i++)
            {
                dgvBoja.Rows.Add(tip.DajListu()[i].Naziv, " ");
                dgvBoja.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml(tip.DajBojuTipa(tip.DajListu()[i].Id.ToString()));
            }
        }
        private void PostaviKalendarNaziv()
        {
            string dan;
            int mjesec = 0;
            foreach (DataGridViewColumn column in dgvKalendar.Columns)
            {
                column.Width = 28;
            }
            for (int i = 0; i < 23; i++)
            {
                dgvKalendar.Rows.Add();
                if (i % 8 == 0)
                {
                    for (int j = 1; j < 32; j++)
                    {                        
                        if ((j % 8) != 0)
                        {
                            mjesec = ((j - 1) % 8 == 0) ? mjesec + 1 : mjesec; 
                            dan = ((MjeseciGodine)(mjesec)).ToString();
                            dgvKalendar.Rows[i].Cells[j - 1].Value = dan;
                            //
                        }                      
                    }
                }
                if (i == 1 || i == 9 || i == 17)
                {
                    for (int j = 1; j < 32; j++)
                    {
                        if (j % 8 != 0)
                        {
                            dan = ((DaniTjedna)(j % 8)).ToString();
                            dgvKalendar.Rows[i].Cells[j - 1].Value = dan.Substring(0,3);
                        }
                    }
                }                
            }            
        }
        private void PostaviKalendarDane() 
        {
            DateTime datumOd = new DateTime(Godina, 1, 1);
            DateTime datumDo = new DateTime(Godina, 12, 31);
            int mjesec = datumOd.Month;
            int row, column, dan;
            TipNeradnihDana tip = new TipNeradnihDana();
            string boja = "5";
            Kalendar kalendar = new Kalendar();
            while (DateTime.Compare(datumOd, datumDo) <= 0)
            {
                Tuple<int, int> koordinate = kalendar.DajPocetneKoordinate(datumOd);
                row = koordinate.Item1;
                column = koordinate.Item2;                
                if (column != 0)
                {
                    dan = (column % 7) - ((mjesec - 1) % 4);
                }
                else
                {
                    dan = 7;
                    column += 7;
                }
                              
                while (datumOd.Month == mjesec)
                {
                    //Console.WriteLine(row + "  " + column);
                    dgvKalendar.Rows[row].Cells[column - 1].Value = datumOd.Day;
                    if (IsGodisnji(datumOd))
                    {
                        dgvKalendar.Rows[row].Cells[column - 1].Style.BackColor = ColorTranslator.FromHtml(tip.DajBojuTipa(boja));
                    }
                    if (IsNeradniDan(datumOd))
                    {
                        dgvKalendar.Rows[row].Cells[column - 1].Style.BackColor = ColorTranslator.FromHtml(BojaPozadine);
                    }
                    if (dan % 7 == 0)
                    {
                        row++;
                        column -= 6;
                        dan = 0;
                    }
                    else
                    {
                        column++;
                    }
                    datumOd = datumOd.AddDays(1);              
                    dan++;
                }
                mjesec = datumOd.Month;
            }          
        }

        private bool IsGodisnji(DateTime datum) 
        {
            if (Godisnji != null)
            {
                foreach (var item in Godisnji)
                {
                    if (item.CompareTo(datum) == 0)
                    {
                        return true;
                    }
                }
            }            
            return false;
        }

        private bool IsNeradniDan(DateTime datum)
        {
            NeradniDan dani = new NeradniDan();
            TipNeradnihDana tip = new TipNeradnihDana();
            foreach (var dan in dani.DajListu(Godina))
            {
                if (dan.Datum.CompareTo(datum) == 0)
                {
                    BojaPozadine = tip.DajBojuTipa(dan.TipId.ToString());
                    return true;
                }
            }
            return false;
        }
        private enum MjeseciGodine
        {
            Siječanj = 1,
            Veljača = 2,
            Ožujak = 3,
            Travanj = 4,
            Svibanj = 5,
            Lipanj = 6,
            Srpanj = 7,
            Kolovoz = 8,
            Rujan = 9,
            Listopad = 10,
            Studeni = 11,
            Prosinac = 12
        }
        private enum DaniTjedna 
        {
            Ponedjeljak = 1,
            Utorak = 2,
            Srijeda = 3,
            Četvrtak = 4,
            Petak = 5,
            Subota = 6,
            Nedjelja = 7
        }

        private void SelectionChange(object sender, EventArgs e)
        {            
            int zaposlenikId = 0;
            int.TryParse(comboBoxZaposlenici.SelectedValue.ToString(), out zaposlenikId);
            ZaposlenikId = zaposlenikId;
            comboBoxGodine.Items.Clear();
            foreach (var item in Upit.DajGodineGodisnjegZaposlenika(zaposlenikId))
            {
                comboBoxGodine.Items.Add(item);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKalendar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }

        private void dgvKalendar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;            
            if (e.RowIndex == 1 || e.RowIndex == 9 || e.RowIndex == 17)
            {
                if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                {
                    e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                }
            }
        }

        private void dgvKalendar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0 || e.RowIndex == 8 || e.RowIndex == 16)
            {
                if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        public bool IsTheSameCellValue(int column, int row)
        {
            if (column < 0)
            {
                column = 1;
            }
            if (column + 1 < dgvKalendar.Rows[row].Cells.Count)
            {
                DataGridViewCell cell1 = dgvKalendar[column, row];
                DataGridViewCell cell2 = dgvKalendar[column + 1, row];
                if (cell1.Value == null || cell2.Value == null)
                {
                    return false;
                }
                return cell1.Value.ToString() == cell2.Value.ToString();
            }
            return false;
        }

        private void comboBoxGodine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Godisnji = new List<DateTime>();
            DateTime datumOd;
            DateTime datumDo;
            string format = "d.M.yyyy. H:mm:ss";
            Godina = int.Parse(comboBoxGodine.SelectedItem.ToString());
            
            foreach (DataRow row in Upit.DajGodisnjiPoZaposlenikuIGodini(ZaposlenikId, Godina).Rows)
            {
                datumOd = DateTime.ParseExact(row["DatumOd"].ToString(), format, null);
                datumDo = DateTime.ParseExact(row["DatumDo"].ToString(), format, null);
                while (DateTime.Compare(datumOd, datumDo) <= 0)
                {
                    Godisnji.Add(datumOd);
                    datumOd = datumOd.AddDays(1);
                }
            }            
            dgvKalendar.Rows.Clear();
            PostaviKalendarNaziv();
            PostaviKalendarDane();   
        }
    }
}
