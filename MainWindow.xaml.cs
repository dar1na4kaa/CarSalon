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
        public MainWindow()
        {
            InitializeComponent();
            frame.Content = new MainPage();
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new ClientPage();
        }

        private void Marks_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new MarkPage();
        }

        private void Emp_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new EmployeePage();
        }

        private void Cars_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new AutoPage();
        }

        private void Sale_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new SalePage();
        }
    }
}
