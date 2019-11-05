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
        public GlavniMeni()
        {
            InitializeComponent();            
        }

        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratorNeradnihDanaForm forma = new GeneratorNeradnihDanaForm();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeradniDaniForm forma = new NeradniDaniForm();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void templejtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemplateEditorForm forma = new TemplateEditorForm();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void tipoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoviNeradnihDanaForm forma = new TipoviNeradnihDanaForm();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmZaposlenici forma = new frmZaposlenici();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void firmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirme forma = new frmFirme();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void zaposlenikgodišnjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposlenikGodisnji forma = new frmZaposlenikGodisnji();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void godišnjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGodisnji forma = new frmGodisnji();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void postavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPostavke forma = new frmPostavke();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void GlavniMeni_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
