using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.frmBrowse;

namespace Vacation
{
    public partial class GlavniMeni : Form
    {
        private static GlavniMeni _instance = null;
        private GlavniMeni()
        {
            InitializeComponent();            
        }
        public static GlavniMeni Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlavniMeni();
                }
                return _instance;
            }
        }

        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratorNeradnihDanaForm forma = GeneratorNeradnihDanaForm.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void pregledNeradnihDana_Click(object sender, EventArgs e)
        {
            NeradniDaniForm forma = NeradniDaniForm.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void templejtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemplateEditorForm forma = TemplateEditorForm.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void tipoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoviNeradnihDanaForm forma = TipoviNeradnihDanaForm.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void pregledZaposlenika_Click(object sender, EventArgs e)
        {
            frmZaposlenici forma = frmZaposlenici.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }
        private void postavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPostavke forma = frmPostavke.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        public void PostaviListuOtvorenihProzora()
        {
            prozorToolStripMenuItem.DropDownItems.Clear();
            foreach (Form form in Application.OpenForms)
            {
                if (form.IsMdiChild)
                {                    
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Text = form.Text;
                    item.Name = prozorToolStripMenuItem.Name;
                    item.Click += new EventHandler(item_Click);
                    prozorToolStripMenuItem.DropDownItems.Add(item);
                }
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == item.Text)
                {
                    form.BringToFront();
                }
            }
        }

        private void GlavniMeni_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void pregledToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGodisnji forma = frmGodisnji.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void zaposlenikgodišnjiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void kalendarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKalendar forma = frmKalendar.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void zaposlenikgodišnjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposlenikGodisnji forma = frmZaposlenikGodisnji.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void zaposlenikdodaciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmZaposlenikDodaci forma = frmZaposlenikDodaci.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void statistikaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStatistika forma = frmStatistika.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }

        private void dodaciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDodaci forma = frmDodaci.Instance;
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            PostaviListuOtvorenihProzora();
        }
    }
}
