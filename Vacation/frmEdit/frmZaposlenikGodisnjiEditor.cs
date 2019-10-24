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

namespace Vacation.frmEdit
{
    public partial class frmZaposlenikGodisnjiEditor : Form
    {
        public frmZaposlenikGodisnjiEditor(frmZaposlenikGodisnji pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox2.Text = pGbText;
        }

        private frmZaposlenikGodisnji Forma { get; set; }

        private void frmZaposlenikGodisnjiEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
