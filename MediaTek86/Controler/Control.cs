//using MediaTek86.dal;
using MediaTek86.dal;
using MediaTek86.Model;
using MediaTek86.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.Controler
{
    public class Control
    {
        private frmConnection frmConnection;
        private frmHome frmHome;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetCompatibleTextRenderingDefault(false);
            new Control();


        }

        public Control()
        {
            frmConnection = new frmConnection(this);
            frmConnection.ShowDialog();
        }

        public bool AuthControl(string login, string pwd)
        {
            if (DataAccess.AuthenticationControl(login, pwd))
            {
                frmConnection.Hide();
                new frmHome(this).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Personnel> GetPersonnels()
        {
            return DataAccess.GetPersonnels();
        }

        public void AddPersonnel(Personnel personnel)
        {
            DataAccess.AddPersonnel(personnel);
        }

        public void DeletePersonnel(Personnel personnel)
        {
            DataAccess.DeletePersonnel(personnel);
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            DataAccess.UpdatePersonnel(personnel);
        }

        public List<Motif> GetMotifs()
        {
            return DataAccess.GetMotifs();
        }

        public List <Service> GetServices()
        {
            return DataAccess.GetServices();
        }

        public List <Absence> GetAbsences()
        {
            return DataAccess.GetAbsences();
        }

        public void AddAbsence(Absence absence)
        {
            DataAccess.UpdateAbsence(absence);
        }

        public void DeleteAbsence(Absence absence)
        {
            DataAccess.DeleteAbsence(absence);
        }

        public void ModifAbsence(Absence absence)
        {
            DataAccess.UpdateAbsence(absence);
        }

        public void OpenPopUpPerso()
        {
            new frmPopUpPersonnel(this).ShowDialog();
        }

        public void InitListPersos()
        {
            new frmHome(this).InitListPersos();
            
        }
        
    }
}
