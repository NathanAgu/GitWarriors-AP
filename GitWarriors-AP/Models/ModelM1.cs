using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitWarriors_AP.Models
{
    internal class ModelM1
    {
        private static GitwarriorsContext modelProjetM1;
        private static bool connexionValide;
        private static Visiteur visiteurConnecte;
        private static int nbrEssaieConnexion;

        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }
        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }
        public static int NbrEssaieConnexion { get => nbrEssaieConnexion; set => nbrEssaieConnexion = value; }

        public static string getMd5Hash(string motDePasse)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(motDePasse);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static void setPassword(string password)
        {
            visiteurConnecte.Password = getMd5Hash(password);
            visiteurConnecte.NbEssai = nbrEssaieConnexion;
            modelProjetM1.SaveChanges();
        }

        public static void validationConnexion(string identifiant, string motDePasse)
        {
            string msgErreur = "Erreur(s) :";
            bool connexion = false;
            Visiteur visiteur = new Visiteur();

            if (modelProjetM1.Visiteurs.Where(x => x.Identifiant == identifiant).ToList().Count == 1)
            {
                visiteur = modelProjetM1.Visiteurs.Where(x => x.Identifiant == identifiant).ToList()[0];
                NbrEssaieConnexion = visiteur.NbEssai;

                if (visiteur.Actif && NbrEssaieConnexion != 3)
                {
                    if (visiteur.Password.Equals(getMd5Hash(motDePasse)))
                    {
                        connexion = true;
                        NbrEssaieConnexion = 0;
                    }
                    else
                    {
                        msgErreur += "\n - Identifiant ou mot de passe invalide !";
                    }
                }
                
            }
            else
            {
                msgErreur += "\n - Identifiant ou mot de passe invalide !";
            }

            if (connexion)
            {
                connexionValide = connexion;
            }
            else
            {
                NbrEssaieConnexion ++;
                msgErreur += "\n\nVous avez échoué " + NbrEssaieConnexion + " fois.";
                if (NbrEssaieConnexion == 3)
                {
                    visiteur.Actif = false;
                    msgErreur += "\nCompte désactivé, contactez un administrateur !";
                }
                MessageBox.Show(msgErreur);
            }
            visiteurConnecte = visiteur;

            modelProjetM1.SaveChanges();
        }

        public static void init()
        {
            modelProjetM1 = new GitwarriorsContext();
        }
    }
}
