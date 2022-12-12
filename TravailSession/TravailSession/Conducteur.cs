using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    internal class Conducteur
    {
        int idConducteur;
        string nom;
        string prenom;
        int idVoiture;
        string adresse;
        string telephone;
        string email;
        string mdp;

        public Conducteur()
        {
            this.Nom = "Bob";
            this.Prenom = "Bob";
            this.IdVoiture = 1;
            this.Adresse = "Obazar";
            this.Telephone = "111-222-3333";
            this.Email = "abozor@gmail.com";
            this.Mdp = "password1";
        }

        public Conducteur(string nom, string prenom, int idVoiture, string adresse, string telephone, string email, string mdp)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.IdVoiture = idVoiture;
            this.Adresse = adresse;
            this.Telephone = telephone;
            this.Email = email;
            this.Mdp = mdp;
        }

        public int IdConducteur { get => idConducteur; set => idConducteur = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int IdVoiture { get => idVoiture; set => idVoiture = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Mdp { get => mdp; set => mdp = value; }
    }
}
