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
    public partial class frmConnection : Form
    {
        
        private Controler.Control control;

        public frmConnection(Controler.Control control)
        {
            InitializeComponent();
            this.control = control;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!control.AuthControl(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("L'identifiant ou le mot de passe sont incorrects !");
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis !");
                }
            }
        }

    }
}
