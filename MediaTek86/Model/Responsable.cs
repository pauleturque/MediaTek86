using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    /// <summary>
    /// Classe correspondant à la table responsable de la base de données
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// propriétés correspondant aux champs de la table responsable
        /// </summary>
        private string login;
        private string pwd;

        /// <summary>
        /// getters sur les propriétés de la classe
        /// </summary>
        private string Login { get => login; }
        private string Pwd { get => pwd; }

        /// <summary>
        /// constructeur volorisant les propriétés de la classe
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
