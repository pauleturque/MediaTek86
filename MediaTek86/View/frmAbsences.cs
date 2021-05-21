using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.View
{
    public partial class frmAbsences : Form
    {
        private Controler.Control control;
        public frmAbsences(Controler.Control control)
        {
            InitializeComponent();
            this.control = control;
        }

        private void btnAddAbs_Click(object sender, EventArgs e)
        {

        }

        private void btnDelAbs_Click(object sender, EventArgs e)
        {

        }
    }
}
