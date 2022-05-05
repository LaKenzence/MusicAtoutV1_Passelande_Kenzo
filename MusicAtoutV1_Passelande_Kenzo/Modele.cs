using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MusicAtoutV1_Passelande_Kenzo
{
    public static class Modele
    {
        private static connectMusicAtout maConnexion;
        private static int actionChoisie;
        private static COMPOSITEUR compositeurChoisi;
        private static UTILISATEUR utilisateurConnecte;
        private static UTILISATEUR utilisateurChoisi;



        public static COMPOSITEUR CompositeurChoisi { get => compositeurChoisi; set => compositeurChoisi = value; }
        public static int ActionChoisie { get => actionChoisie; set => actionChoisie = value; }
        public static UTILISATEUR UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static UTILISATEUR UtilisateurChoisi { get => utilisateurChoisi; set => utilisateurChoisi = value; }

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new connectMusicAtout();
        }
        public static List<VILLE> listeville()
        {
            return maConnexion.VILLE.ToList();
        }
        public static List<SALLE> listesalle()
        {
            return maConnexion.SALLE.ToList();
        }
        public static List<BATIMENT> listebatiment()
        {
            return maConnexion.BATIMENT.ToList();
        }
        public static List<TYPEOEUVRE> listetypedoeuvre()
        {
            return maConnexion.TYPEOEUVRE.ToList();
        }
        public static List<NATIONALITE> listenationalite()
        {
            return maConnexion.NATIONALITE.ToList();
        }
        public static Object listecompositeur()
        {
            var LQUERY = maConnexion.COMPOSITEUR.Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque, x.idCompositeur })
                                           .OrderBy(x => x.nomCompositeur);
            return LQUERY.ToList();
        }

        internal static UTILISATEUR trouveuserById(string id)
        {
            List<UTILISATEUR> malist = maConnexion.UTILISATEUR.Where(x => x.idUtilisateur == id).ToList();
            return malist[0]; ;
        }

        public static List<STYLE> listestyle()
        {
            return maConnexion.STYLE.ToList();

        }
        public static List<OEUVRE> listeoeuvre()
        {
            return maConnexion.OEUVRE.ToList();

        }

        public static COMPOSITEUR donneCompo(int id)
        {
            return maConnexion.COMPOSITEUR.Where(x => x.idCompositeur == id).ToList()[0];
        }

        public static List<UTILISATEUR> listeuseradmin()
        {
            return maConnexion.UTILISATEUR.ToList();
        }
        public static List<UTILISATEUR> listeonlyusers()
        {
            return maConnexion.UTILISATEUR.Where(x => x.droits < 2).ToList();
        }

        public static bool AjoutCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            if (idNation != 9 && idStyle !=1)
            try
            {
                compositeurChoisi = new COMPOSITEUR();
                compositeurChoisi.nomCompositeur = nom;
                compositeurChoisi.prenomCompositeur = prenom;
                compositeurChoisi.remarque = remarque;
                compositeurChoisi.anNais = anNais;
                compositeurChoisi.anMort = anMort;
                compositeurChoisi.idNation = idNation;
                compositeurChoisi.idStyle = idStyle;
                maConnexion.COMPOSITEUR.Add(compositeurChoisi);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            else
            {
                vretour = false;
            }
            return vretour;
        }
        public static bool ModifCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            if (idNation != 9 && idStyle != 1)
                try
            {
                
                compositeurChoisi.nomCompositeur = nom;
                compositeurChoisi.prenomCompositeur = prenom;
                compositeurChoisi.remarque = remarque;
                compositeurChoisi.anNais = anNais;
                compositeurChoisi.anMort = anMort;
                compositeurChoisi.idNation = idNation;
                compositeurChoisi.idStyle = idStyle;
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                }
            else
            {
                vretour = false;
            }

            return vretour;
        }

        public static bool SuppCompositeur()
        {
            bool vretour = true;
            try
            {
                maConnexion.COMPOSITEUR.Remove(compositeurChoisi);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.InnerException.Message);
                vretour = false;
                maConnexion.Dispose();
                init();
            }
            return vretour;
        }
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public static bool userexists(string id)
        {
            bool vretour = false;

            if (maConnexion.UTILISATEUR.Where(x => x.idUtilisateur == id).ToList().Count == 1)
            {
                vretour = true;
                UtilisateurConnecte = maConnexion.UTILISATEUR.Where(x => x.idUtilisateur == id).ToList()[0];

                if (UtilisateurConnecte.nbessais < 3)
                {
                    UtilisateurConnecte.nbessais += 1;

                }
                if (UtilisateurConnecte.nbessais == 3)
                {
                    UtilisateurConnecte.actif = false;
                }

                maConnexion.SaveChanges();

            }
            return vretour;
        }

        public static bool passexists(string mdp)
        {
            bool vretour = false;
            String mp = "0x";
            string mp1 = mp + (GetMd5Hash(mdp));
            if (UtilisateurConnecte.passwd.Equals(mp1) && UtilisateurConnecte.actif == true)
            {
                vretour = true;
                UtilisateurConnecte.nbessais = 0;
                maConnexion.SaveChanges();
            }
            return vretour;
        }

        public static bool changepass(string nouveaumdp)
        {
            bool vretour = false;
            UtilisateurConnecte.passwd = GetMd5Hash(nouveaumdp);
            maConnexion.SaveChanges();
            return vretour;
        }

        public static bool reactivateUser()
        {
            bool vretour = false;
            if (UtilisateurChoisi.actif == false)
            {
                UtilisateurChoisi.actif = true;
                vretour = true;
            }
            maConnexion.SaveChanges();
            return vretour;
        }

        public static bool desactiverUser()
        {
            bool vretour = false;
            if (UtilisateurChoisi.actif == true)
            {
                UtilisateurChoisi.actif = false;
                vretour = true;
            }
            maConnexion.SaveChanges();
            return vretour;
        }

        public static bool AddUser(string id, int droit)
        {
            bool vretour = false;

            utilisateurChoisi = new UTILISATEUR();
            utilisateurChoisi.idUtilisateur = id;
            utilisateurChoisi.passwd = GetMd5Hash(id);
            utilisateurChoisi.droits = droit;
            utilisateurChoisi.actif = true;
            utilisateurChoisi.nbessais = 0;
            maConnexion.UTILISATEUR.Add(utilisateurChoisi);
            maConnexion.SaveChanges();

            return vretour;
        }
        public static bool DelUser()
        {
            bool vretour = true;
            try
            {
                maConnexion.UTILISATEUR.Remove(utilisateurChoisi);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.InnerException.Message);
                vretour = false;
                maConnexion.Dispose();
                init();

            }
            return vretour;
        }


    }



}

