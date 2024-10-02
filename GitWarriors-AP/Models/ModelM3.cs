using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWarriors_AP.Models
{
    internal class ModelM3
    {
        private static GitwarriorsContext modelProjetM3;
        public static Visiteur currentVisiteur;
        public static int statutAjoutModif = 0; // si AJout = 1 sinon Modif = 2
        public static Fichefrai currentFicheFrai;

        public static GitwarriorsContext ModelProjetM3 { get => modelProjetM3; set => modelProjetM3 = value; }

        public static void init()
        {
            ModelProjetM3 = new GitwarriorsContext();
        }

        public static List<Visiteur> listeVisiteur()
        {
            return ModelProjetM3.Visiteurs.ToList();
        }

        public static Visiteur setCurrentVisiteur()
        {
            return currentVisiteur = listeVisiteur()[0];
        }
    }
}
