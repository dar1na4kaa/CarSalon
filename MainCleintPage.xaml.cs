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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Carsalon
{
    /// <summary>
    /// Логика взаимодействия для MainCleintPage.xaml
    /// </summary>
    public partial class MainCleintPage : Page
    {
        public MainCleintPage()
        {
            InitializeComponent();
            DGridClients.ItemsSource = AutoRoomEntities.GetContext().Customers.ToList();    

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainWindowFrame.Content = new ClientPage();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
