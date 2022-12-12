using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    internal class Passager
    {
        int idPassager;
        string nom;
        string prenom;
        string adresse;
        string telephone;
        string email;
        string mdp;

        public Passager()
        {
            this.Nom = "Bill";
            this.Prenom = "Bill";
            this.Adresse = "Bozoar";
            this.Telephone = "111-222-3333";
            this.Email = "bazaor@gmail.com";
            this.Mdp = "password2";
        }

        public Passager(string nom, string prenom, string adresse, string telephone, string email, string mdp)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.Telephone = telephone;
            this.Email = email;
            this.Mdp = mdp;
        }

        public int IdPassager { get => idPassager; set => idPassager = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Mdp { get => mdp; set => mdp = value; }
    }
}
