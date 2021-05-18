using MediaTek86.dal;
using MediaTek86.View;


namespace MediaTek86.Controler
{
    public class Control
    {
        private frmConnection frmConnection;
        private frmHome frmHome;

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
                frmHome = new frmHome(this);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
