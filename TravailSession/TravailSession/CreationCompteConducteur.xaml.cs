using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TravailSession
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreationCompteConducteur : Page
    {
        public CreationCompteConducteur()
        {
            this.InitializeComponent();
        }

        private void btCreationCompteConducteurFin_Click(object sender, RoutedEventArgs e)
        {
            if (nom.Text == "")
            {
                nomErreur.Text = "Entrez un nom";
            }
            else nomErreur.Text = "";

            if (prenom.Text == "")
            {
                prenomErreur.Text = "Entrez un prénom";
            }
            else prenomErreur.Text = "";

            if (adresse.Text == "")
            {
                adresseErreur.Text = "Entrez votre adresse";
            }
            else adresseErreur.Text = "";

            if (telephone.Text == "")
            {
                telephoneErreur.Text = "Entrez un numéro de téléphone";
            }
            else telephoneErreur.Text = "";

            if (email.Text == "")
            {
                emailErreur.Text = "Entrez l'email identifiant";
            }
            else emailErreur.Text = "";

            if (mdp.Text == "")
            {
                mdpErreur.Text = "Entrez votre mot de passe";
            }
            else mdpErreur.Text = "";

            if (typeVoiture.SelectedIndex == -1)
            {
                typeVoitureErreur.Text = "Choisir un type de voiture";
            }
            else typeVoitureErreur.Text = "";

            if (idVoituree.Text == "")
            {
                idVoitureeErreur.Text = "Entrez le numero de la voiture";
            }
            else idVoitureeErreur.Text = "";

            if (nom.Text != "" && prenom.Text != "" && adresse.Text != "" && telephone.Text != "" && email.Text != "" && mdp.Text != "" && typeVoiture.SelectedIndex != -1)
            {

                string mdpHash = genererSHA256(mdp.Text);

                GestionBD.getInstance().ajouterConducteur(new Conducteur(nom.Text, prenom.Text, Convert.ToInt32(idVoituree.Text), adresse.Text, telephone.Text, email.Text, mdp.Text));

                this.Frame.Navigate(typeof(PageListeTrajetsAjd));
            }
        }

        private string genererSHA256(string texte)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texte));

            StringBuilder sb = new StringBuilder();
            foreach (Byte b in bytes)
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }



    }
}
