using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    /// <summary>
    /// Classe correspondant à la table motif de la base de données
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Propriétés correspondant aux champs de la table motif
        /// </summary>
        private int idmotif;
        private string libelle;

        /// <summary>
        /// getters sur les propriétés de la classe
        /// </summary>
        private int IdMotif { get => idmotif; }
        private string Libelle { get => libelle; }

        /// <summary>
        /// constructeur valorisant les propriétés de la classe
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }
    }
}
