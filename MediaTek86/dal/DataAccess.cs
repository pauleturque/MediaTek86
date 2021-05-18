using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant l'accès aux données de la base de données
    /// </summary>
    class DataAccess
    {
        /// <summary>
        /// Chaîne de connexion à la base de données
        /// </summary>
        private static string connectionString = "server = localhost; user id = root; database = bdd_mediatek";

        public static bool AuhtenticationControl(string login, string pwd)
        {
            string req = "SELECT * FROM responsable WHERE responsable.login = @login AND pwd = SHA256(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(@login, login);
            parameters.Add(pwd, pwd);
            ConnectionDB.Connect curseur = ConnectionDB.Connect.Instance(connectionString);
            curseur.ReqSelect(req, parameters);
            if (curseur.Read())
            {
                curseur.Close();
                return true;
            }
            else
            {
                curseur.Close();
                return false;
            }
        }
    }
}
