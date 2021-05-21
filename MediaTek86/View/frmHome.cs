using MediaTek86.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql;

namespace MediaTek86.View
{
    public partial class frmHome : Form
    {
        private Controler.Control control;

        BindingSource bsPersonnels = new BindingSource();
        public frmHome(Controler.Control control)
        {
            InitializeComponent();
            this.control = control;
            InitListPersos();
        }

        public void InitListPersos()
        {
            UpdatePersoList();
        }

        private void btnAddPerso_Click(object sender, EventArgs e)
        {
            control.OpenPopUpPerso();
        }

        public void UpdatePersoList()
        {
            listPersonnel.Items.Clear();
            List<Personnel> lesPersonnels = control.GetPersonnels();
            for (int k = 0; k< lesPersonnels.Count; k++)
            {
                listPersonnel.Items.Add(lesPersonnels[k]);
            }
        }



        
    }
}
