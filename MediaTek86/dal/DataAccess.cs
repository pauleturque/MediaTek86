using MediaTek86.ConnectionDB;
using MediaTek86.Model;
using System;
using System.Collections.Generic;

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

        public static bool AuthenticationControl(string login, string pwd)
        {
            string req = "SELECT * FROM responsable WHERE responsable.login = @login AND pwd = SHA256(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(@login, login);
            parameters.Add(pwd, pwd);
            Connect curseur = Connect.Instance(connectionString);
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

        public static List<Personnel> GetPersonnels()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            string req = "SELECT * FROM Personnel ORDER BY nom, prenom";
            ConnectionDB.Connect curseur = ConnectionDB.Connect.Instance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Personnel personnel = new Personnel((int)curseur.Field("idpersonnel"), (int)curseur.Field("idservice"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("tel"), (string)curseur.Field("mail"));
                lePersonnel.Add(personnel);
            }
            curseur.Close();
            return lePersonnel;
        }

        public static List<Service> GetServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "SELECT Service.nom FROM Service ORDER BY Service.nom ASC";
            ConnectionDB.Connect curseur = ConnectionDB.Connect.Instance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Service service = new Service((int)curseur.Field("idservice"), (string)curseur.Field("nom"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        public static List<Absence> GetAbsences()
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "SELECT a.idpersonnel, a.idmotif, a.datedebut, a.datefin ";
            req += "FROM Absence a ORDER BY a.datedebut, a.datefin DESC";
            ConnectionDB.Connect curseur = Connect.Instance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Absence absence = new Absence((int)curseur.Field("idpersonnel"), (int)curseur.Field("idmotif"), (DateTime)curseur.Field("datedebut"), (DateTime)curseur.Field("datefin"));
                lesAbsences.Add(absence);
            }
            curseur.Close();
            return lesAbsences;
        }

        public static List<Motif> GetMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "SELECT m.idmotif, m.libelle FROM Motif m ORDER BY m.libelle";
            ConnectionDB.Connect curseur = ConnectionDB.Connect.Instance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Motif motif = new Motif((int)curseur.Field("idmotif"), (string)curseur.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curseur.Close();
            return lesMotifs;
        }

        public static void AddPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO Personnel(idpersonnel, idservice, nom, prenom, tel, mail)";
            req += "values(@idpersonnel, @idservice, @nom, @prenom, @tel, @mail)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            Connect connect = Connect.Instance(connectionString);
            connect.ReqUpdate(req, parameters);
        }

        public static void DeletePersonnel(Personnel personnel)
        {
            string req = "DELETE * FROM personnel WHERE idpersonnel = @idpersonnel ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            Connect connect = Connect.Instance(connectionString);
            connect.ReqDelete(req, parameters);
        }

        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "UPDATE personnel SET idpersonnel = @idpersonnel, idservice = @idservice, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail";
            req += "WHERE idpesonnel = @idpesonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            Connect connect = Connect.Instance(connectionString);
            connect.ReqUpdate(req, parameters);
        }

        public static void AddAbsence(Absence absence)
        {
            string req = "INSERT INTO absence(idpersonnel, idmotif, datedebut, datefin)";
            req += "VALUES (@idpersonnel, @idmotif, @datedebut, @datefin)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            Connect connect = Connect.Instance(connectionString);
            connect.ReqUpdate(req, parameters);
        }

        public static void DeleteAbsence(Absence absence)
        {
            string req = "DELETE * FROM absence WHERE idpersonnel = @idpersonnel ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            Connect connect = Connect.Instance(connectionString);
            connect.ReqDelete(req, parameters);
        }

        public static void UpdateAbsence(Absence absence)
        {
            string req = "UPDATE absence SET idpersonnel = @idpersonnel, idmotife = @idmotif, datedebut = @datedebut, datefin = @datefin";
            req += "WHERE idpesonnel = @idpesonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@idservice", absence.IdMotif);
            parameters.Add("@nom", absence.DateDebut);
            parameters.Add("@prenom", absence.DateFin);
            Connect connect = Connect.Instance(connectionString);
            connect.ReqUpdate(req, parameters);
        }
    }
}
