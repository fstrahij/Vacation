using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacation.frmBrowse
{
    public partial class frmKalendar : Form
    {
        private static frmKalendar _instance = null;
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
        private void frmKalendar_Load(object sender, EventArgs e)
        {
            PostaviKalendarNaziv();
        }
        private void PostaviKalendarNaziv()
        {
            string dan;
            int mjesec = 0;
            foreach (DataGridViewColumn column in dgvKalendar.Columns)
            {
                column.Width = 28;
            }
            for (int i = 0; i < 22; i++)
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
            /*
             * dok je datumOd <= datumDo
             *     daj koordinate u kalendaru na koje su upisuje dan
             *     postavi dan na koordinate
            */
            /*string dan;
            DateTime datumOd = new DateTime(2019, 1, 1);
            DateTime datumDo = new DateTime(2019, 12, 31);
            for (int i = 0; i < 21; i++)
            {
                for (int j = 1; j < 7; j++)
                {

                    dan = ((j % 8) != 0) ? ((DayOfWeek)(j % 8)).ToString() : prazniString;
                    if (j % 7 == 0)
                    {
                        dan = DayOfWeek.Sunday.ToString();
                    }
                    if (datumOd.DayOfWeek.ToString() == dan)
                    {
                        dan = datumOd.Day.ToString();
                        datumOd = datumOd.AddDays(1);
                    }
                    else
                    {
                        dan = prazniString;
                    }
                    dgvKalendar.Rows[i].Cells[j - 1].Value = (!string.IsNullOrWhiteSpace(dan)) ? dan : dan;
                }
            } */           
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
    }
}
