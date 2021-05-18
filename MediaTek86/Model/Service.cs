using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    /// <summary>
    /// Classe correspondant à la table service de la base de données
    /// </summary>
    public class Service
    {
        /// <summary>
        /// propriétés correspondant aux champs de la table service
        /// </summary>
        private int idservice;
        private string nom;

        /// <summary>
        /// getters sur les propriétés
        /// </summary>
        private int IdService { get => idservice; }
        private string Nom { get => nom; }

        /// <summary>
        /// constructeur valorisant les propriétés de la classe
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }
    }
}
