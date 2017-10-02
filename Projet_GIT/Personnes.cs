﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GIT
{
    class Personnes
    {
        public string nom { get; set; }

        // PRENOM
        public string prenom { get; set; }

        public Personnes ()
        {
            this.nom = "BARDI";
            this.prenom = "Jeff";                
        }

        public Personnes(string nom, string prenom)
        {
            this.nom = nom.ToUpper();
            this.prenom = prenom.ToLower();
        }

        // Affichage du salarié 
        public virtual string Identite()
        {
            return nom.ToUpper() + " " + prenom.ToLower();
        }

        

    }
}
