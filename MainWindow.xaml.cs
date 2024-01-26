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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MainWindowFrame;

        public MainWindow()
        {

            InitializeComponent();
            MainWindowFrame = MainFrame;
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {

            MainFrame.Content = new MainCleintPage();
        }

        private void Marks_Click(object sender, RoutedEventArgs e)
        {

            MainFrame.Content = new MarkPage();
        }

        private void Emp_Click(object sender, RoutedEventArgs e)
        {

            MainFrame.Content = new EmployeePage();
        }

        private void Cars_Click(object sender, RoutedEventArgs e)
        {

            MainFrame.Content = new AutoPage();
        }

        private void Sale_Click(object sender, RoutedEventArgs e)
        {

            MainFrame.Content = new SalePage();
        }
    }
}
