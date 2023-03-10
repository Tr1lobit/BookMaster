using Bookmaster_Afonichev.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bookmaster_Afonichev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Bookmaster_AfonichevEntities context = new Bookmaster_AfonichevEntities();
    }
}
