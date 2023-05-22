using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Boolmaster_Samodin
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Model.BookmasterDb_KOSATKAEntities context = new Model.BookmasterDb_KOSATKAEntities();
    }
}
