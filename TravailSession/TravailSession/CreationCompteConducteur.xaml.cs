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

            if (nom.Text != "" && prenom.Text != "" && adresse.Text != "" && telephone.Text != "" && email.Text != "" && mdp.Text != "")
            {
                this.Frame.Navigate(typeof(PageListeTrajetsAjd));
            }
        }
    }
}
