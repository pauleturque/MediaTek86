using MediaTek86.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.View;

namespace MediaTek86.View
{
    public partial class frmPopUpPersonnel : Form
    {
        BindingSource bsServices = new BindingSource();

        private Controler.Control control;
        public frmPopUpPersonnel(Controler.Control control)
        {
            InitializeComponent();
            this.control = control;
            InitListServices();
        }

        public void InitListServices()
        {
            ServiceList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int idpersonnel = 0;
            int idservice = 0;
            if (txtBoxLastName.Text.Equals("") || txtBoxName.Text.Equals("") || txtBoxTel.Text.Equals("") || txtBoxMail.Text.Equals("") || lstService.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs doivent être remplis");
            }
            else
            {
                Personnel personnel = new Personnel(idpersonnel, idservice, txtBoxLastName.Text, txtBoxName.Text, txtBoxTel.Text, txtBoxMail.Text);
                try
                {
                    control.AddPersonnel(personnel);
                    control.InitListPersos();
                    Close();
                }
                catch (Exception i)
                {

                    Console.WriteLine(i + "échec ajout");
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServiceList()
        {
            lstService.Items.Clear();
            List<Service> lesServices = control.GetServices();
            for (int k = 0; k < lesServices.Count; k++)
            {
                lstService.Items.Add(lesServices[k]);
                
            }


        }
    }
}
