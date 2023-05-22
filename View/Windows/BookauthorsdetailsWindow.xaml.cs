using Boolmaster_Samodin.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для BookauthorsdetailsWindow.xaml
    /// </summary>
    public partial class BookauthorsdetailsWindow : Window
    {
        public BookauthorsdetailsWindow(BookAuthor bookAuthor)
        {
            InitializeComponent();

            AuthorsCmb.ItemsSource = App.context.BookAuthor.Where(ba => ba.Bookid == bookAuthor.Bookid).ToList();    
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AuthorsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataContext = AuthorsCmb.SelectedItem;
        }

        private void OpenWikipediaHl_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo());
        }
    }
}
