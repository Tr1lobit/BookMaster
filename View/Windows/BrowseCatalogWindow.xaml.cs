using Boolmaster_Samodin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Boolmaster_Samodin.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        public BrowseCatalogWindow()
        {
            InitializeComponent();
        }
        #region Manu
        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomerWindow manageCustomerWindow = new ManageCustomerWindow();
            manageCustomerWindow.Show();
        }
        

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            CirculationWindow circulationWindow = new CirculationWindow();
            circulationWindow.Show();
        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SearchResultsLv.ItemsSource = App.context.BookAuthor.Where(ba => ba.Book.Tatle.Contains(TitleTb.Text)).ToList();
        }

        private void SearchResultsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BookDetailsGrid.DataContext = SearchResultsLv.SelectedItem as BookAuthor;
        }
    }
}
