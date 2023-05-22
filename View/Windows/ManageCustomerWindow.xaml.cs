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
    /// Логика взаимодействия для ManageCustomerWindow.xaml
    /// </summary>
    public partial class ManageCustomerWindow : Window
    {
        public ManageCustomerWindow()
        {
            InitializeComponent();

            CustomersLv.ItemsSource = App.context.Customer.ToList();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if(SearchNameTb.Text != string.Empty)
            {
                CustomersLv.ItemsSource = App.context.Customer.Where(c => c.Name.Contains(SearchNameTb.Text)).ToList();
            }
            else
            {
                CustomersLv.ItemsSource = App.context.Customer.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if(CustomersLv.SelectedItem == null)
            {
                MessageBox.Show("Выберите читателя!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow(CustomersLv.SelectedItem as Customer);

                if (addEditCustomerWindow.ShowDialog() == true)
                {

                }
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow();

            if (addEditCustomerWindow.ShowDialog() == true)
            {
                CustomersLv.ItemsSource = App.context.Customer.ToList();
            }
        }
    }
}
