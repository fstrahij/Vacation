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
    }
}
