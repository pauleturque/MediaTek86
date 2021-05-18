using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    /// <summary>
    /// Classe correspondant à la table personnel de la base de données
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// propriétés correspondant aux champs de la table
        /// </summary>
        private int idpersonnel;
        private int idservice;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;

        /// <summary>
        /// getters et setters sur les propriétés
        /// </summary>
        private int IdPersonnel { get => idpersonnel; }
        private int IdService { get => idservice; }
        private string Nom { get => nom; set => nom = value; }
        private string Prenom { get => prenom; set => prenom = value; }
        private string Tel { get => tel; set => tel = value; }
        private string Mail { get => mail; set => mail = value; }

        /// <summary>
        /// constructeur valorisant les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Personnel(int idpersonnel, int idservice, string nom, string prenom, string tel, string mail)
        {
            this.idservice = idservice;
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }
    }
}
