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
    /// Логика взаимодействия для AddEditCustomerWindow.xaml
    /// </summary>
    public partial class AddEditCustomerWindow : Window
    {
        //false - dobavlyaem polzovatelya
        //true - redaktiruem polzovatelya
        bool isEdit = false;
        public AddEditCustomerWindow()
        {
            InitializeComponent();
        }
        public AddEditCustomerWindow(Customer selectedCustomer)
        {
            InitializeComponent();

            DataContext = selectedCustomer;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (isEdit == true)
            {
                App.context.SaveChanges();
            }
            else
            {
                Customer newCustomer = new Customer
                {
                    Name = NameTb.Text,
                    Address = AddressTb.Text,
                    Zip = ZipTb.Text,
                    City = CityTb.Text,
                    Phone = PhoneTb.Text,
                    Email = EmailTb.Text

                };


                App.context.Customer.Add(newCustomer);
                App.context.SaveChanges();
                MessageBox.Show("Читатель успешно добавлен!");

                DialogResult = true;
            }
        }
        private void CanelBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            App.context.Dispose();
        }
    }
}
