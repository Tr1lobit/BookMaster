using Bookmaster_Afonichev.Model;
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

namespace Bookmaster_Afonichev.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        public BrowseCatalogWindow()
        {
            InitializeComponent();

            SearchResultsLv.ItemsSource = App.context.BookAuthor.ToList();
        }

        #region Menu
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

        }

        private void Circulation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        

        private void SearchResultsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BookDetailsGrid.DataContext = SearchResultsLv.SelectedItem as BookAuthor;
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SearchResultsLv.ItemsSource = App.context.BookAuthor.Where(ba => ba.Book.Title.Contains(TitleTb.Text)).ToList();
        }

        
    }
}
