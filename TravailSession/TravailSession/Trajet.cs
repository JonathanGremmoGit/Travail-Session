using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    internal class Trajet
    {
        int idTrajet;
        int idVoiture;
        int idConducteur;
        int idPassager1;
        int idPassager2;
        int idPassager3;
        int idPassager4;
        int idPassager5;
        string date;
        string heureDepart;
        string heureArrive;
        string villeDepart;
        string villeArrive;
        int prixPassager;
        string nomChauffeur;
        string prenomChauffeur;

        public Trajet()
        {
            this.idTrajet = 1;
            this.idVoiture = 1;
            this.idConducteur = 1;
            this.idPassager1 = 1;
            this.idPassager2 = 2;
            this.idPassager3 = 3;
            this.idPassager4 = 4;
            this.idPassager5 = 5;
            this.date = "2023-01-01";
            this.heureDepart = "8:00 AM";
            this.heureArrive = "7:00 PM";
            this.villeDepart = "Kektown";
            this.villeArrive = "Lultown";
            this.prixPassager = 10;
            this.NomChauffeur = "A";
            this.PrenomChauffeur = "B";
        }

        public Trajet(int idTrajet, int idVoiture, int idConducteur, int idPassager1, int idPassager2, int idPassager3, int idPassager4, int idPassager5, string date, string heureDepart, string heureArrive, string villeDepart, string villeArrive, int prixPassager, 
            string nomChauffeur, string prenomChauffeur)
        {
            this.idTrajet = idTrajet;
            this.idVoiture = idVoiture;
            this.idConducteur = idConducteur;
            this.idPassager1 = idPassager1;
            this.idPassager2 = idPassager2;
            this.idPassager3 = idPassager3;
            this.idPassager4 = idPassager4;
            this.idPassager5 = idPassager5;
            this.date = date;
            this.heureDepart = heureDepart;
            this.heureArrive = heureArrive;
            this.villeDepart = villeDepart;
            this.villeArrive = villeArrive;
            this.prixPassager = prixPassager;
            this.nomChauffeur = nomChauffeur;
            this.prenomChauffeur = prenomChauffeur;
        }

        public int IdTrajet { get => idTrajet; set => idTrajet = value; }
        public int IdVoiture { get => idVoiture; set => idVoiture = value; }
        public int IdConducteur { get => idConducteur; set => idConducteur = value; }
        public int IdPassager1 { get => idPassager1; set => idPassager1 = value; }
        public int IdPassager2 { get => idPassager2; set => idPassager2 = value; }
        public int IdPassager3 { get => idPassager3; set => idPassager3 = value; }
        public int IdPassager4 { get => idPassager4; set => idPassager4 = value; }
        public int IdPassager5 { get => idPassager5; set => idPassager5 = value; }
        public string Date { get => date; set => date = value; }
        public string HeureDepart { get => heureDepart; set => heureDepart = value; }
        public string HeureArrive { get => heureArrive; set => heureArrive = value; }
        public string VilleDepart { get => villeDepart; set => villeDepart = value; }
        public string VilleArrive { get => villeArrive; set => villeArrive = value; }
        public int PrixPassager { get => prixPassager; set => prixPassager = value; }
        public string NomChauffeur { get => nomChauffeur; set => nomChauffeur = value; }
        public string PrenomChauffeur { get => prenomChauffeur; set => prenomChauffeur = value; }
        public string HeureDepart1 { get => heureDepart; set => heureDepart = value; }
        public string Date1 { get => date.Substring(0, 10); set => date = value; }
    }
}
