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
    /// Логика взаимодействия для CirculationWindow.xaml
    /// </summary>
    public partial class CirculationWindow : Window
    {
        private Customer selectedCustomer;
        private BookAuthor selectedBook;

        public CirculationWindow()
        {
            InitializeComponent();
        }

        private void CirculationBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataContext = FindCustomer();
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Введите корректные данные");
            }
            
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (selectedCustomer != null)
            {
                AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow(selectedCustomer);
                addEditCustomerWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private Customer FindCustomer()
        {
            int customerId = int.Parse(SearchIdTb.Text.Trim('c'));

            selectedCustomer = App.context.Customer.FirstOrDefault(c => customerId == c.CustomerId);

            if(selectedCustomer != null)
            {
              return selectedCustomer;
            }

            MessageBox.Show("Клиент с таким индентификатором не найден!");

            return null;
        }

        private BookAuthor FindBook()
        {
            int bookId = int.Parse(SearchIdTb.Text);

            selectedBook = App.context.BookAuthor.FirstOrDefault(ba => ba.Bookid == bookId);

            return selectedBook;
        }

        private void BookSearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(FindBook() != null)
            {
                BookGrid.DataContext = selectedBook;
            }
            else
            {
                IssueBtn.IsEnabled = false;
                ReturnBtn.IsEnabled = false;
            }
        }
    }
}
