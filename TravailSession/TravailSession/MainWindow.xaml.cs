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
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            mainFrame.Navigate(typeof(PageListeTrajetsAjd));
        }

        private void btListeTrajetAjd_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(PageListeTrajetsAjd));
        }

        private void btCreationCompteConducteur_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(CreationCompteConducteur));
        }

        private void btCreationComptePassager_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(CreationComptePassager));
        }

        private void btConnexion_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(PageConnexion));

        }

        private void btReservationTrajet_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(PageReservationTrajet));
        }

        private void btAdmin_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Admin)); 

        }
    }
}
