using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    internal class GestionBD
    {
        MySqlConnection con;

        ObservableCollection<Trajet> listeTrajet;

        static GestionBD gestionBD = null;

        public GestionBD()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;Database=2003317-jonathan-gremmo;Uid=2003317;Pwd=2003317;");
            listeTrajet = new ObservableCollection<Trajet>();
        }

        public static GestionBD getInstance()
        {
            if (gestionBD == null)
                gestionBD = new GestionBD();

            return gestionBD;
        }

        public ObservableCollection<Trajet> GetTrajets()
        {
            ObservableCollection<Trajet> listeTrajet = new ObservableCollection<Trajet>();

            MySqlCommand commande1 = new MySqlCommand();
            commande1.Connection = con;
            commande1.CommandText = "SELECT idTrajet, trajet.idVoiture, trajet.idConducteur, idPassager1, idPassager2, idPassager3, idPassager4, idPassager5, date, heureDepart, heureArrive, villeDepart, villeArrive, prixPassager, nom, prenom FROM trajet INNER JOIN conducteur c on trajet.idConducteur = c.idConducteur WHERE date > CURRENT_DATE;";

            con.Open();
            MySqlDataReader r = commande1.ExecuteReader();

            while (r.Read())
            {
                //listeTrajet.Add(new Trajet(r.GetInt32(["idTrajet"]) + " " + r["idVoiture"] + " " + r["idConducteur"] + " " + r["idPassager1"] + " " + r["idPassager2"] + " " + r["idPassager3"] + " " + r["idPassager4"] + " " + r["idPassager5"] + " " + r["date"] + " " + r["heureDepart"] + " " + r["heureArrive"] + " " + r["villeDepart"] + " " + r["villeArrive"] + " " + r["prixPassager"] + " " + r["nom"] + " " + r["prenom"]));
                Trajet t = new Trajet()
                {
                    IdTrajet = r.GetInt32("idTrajet"),
                    IdVoiture = r.GetInt32("idVoiture"),
                    IdConducteur = r.GetInt32("idConducteur"),
                    Date = r.GetString("date"),
                    HeureDepart = r.GetString("heureDepart"),
                    HeureArrive = r.GetString("heureArrive"),
                    VilleDepart = r.GetString("villeDepart"),
                    VilleArrive = r.GetString("villeArrive"),
                    PrixPassager = r.GetInt32("prixPassager"),
                    NomChauffeur = r.GetString("nom"),
                    PrenomChauffeur = r.GetString("prenom")
                };
                
                listeTrajet.Add(t);
            }
            r.Close();
            con.Close();

            return listeTrajet;
        }

        public int ajouterConducteur(Conducteur c)
        {
            int retour = 0;

            MySqlCommand commande2 = new MySqlCommand();
            commande2.Connection = con;
            commande2.CommandText = "INSERT INTO conducteur (nom, prenom, idVoiture, adresse, telephone, email, mdp) VALUES(@nom, @prenom, @idVoiture, @adresse, @telephone, @email, @mdp) ";

            commande2.Parameters.AddWithValue("@nom", c.Nom);
            commande2.Parameters.AddWithValue("@prenom", c.Prenom);
            commande2.Parameters.AddWithValue("@idVoiture", c.IdVoiture);
            commande2.Parameters.AddWithValue("@adresse", c.Adresse);
            commande2.Parameters.AddWithValue("@telephone", c.Telephone);
            commande2.Parameters.AddWithValue("@email", c.Email);
            commande2.Parameters.AddWithValue("@mdp", c.Mdp);


            con.Open();
            commande2.Prepare();
            retour = commande2.ExecuteNonQuery();

            con.Close();
            return retour;
        }

        public int ajouterPassager(Passager p)
        {
            int retour = 0;

            MySqlCommand commande3 = new MySqlCommand();
            commande3.Connection = con;
            commande3.CommandText = "INSERT INTO passager (nom, prenom, adresse, telephone, email, mdp) VALUES(@nom, @prenom, @adresse, @telephone, @email, @mdp) ";

            commande3.Parameters.AddWithValue("@nom", p.Nom);
            commande3.Parameters.AddWithValue("@prenom", p.Prenom);
            commande3.Parameters.AddWithValue("@adresse", p.Adresse);
            commande3.Parameters.AddWithValue("@telephone", p.Telephone);
            commande3.Parameters.AddWithValue("@email", p.Email);
            commande3.Parameters.AddWithValue("@mdp", p.Mdp);


            con.Open();
            commande3.Prepare();
            retour = commande3.ExecuteNonQuery();

            con.Close();
            return retour;
        }

    }
}
