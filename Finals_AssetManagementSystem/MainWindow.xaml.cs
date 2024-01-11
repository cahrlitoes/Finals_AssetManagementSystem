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

namespace Finals_AssetManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            _AdminLogin admin = new _AdminLogin();
            admin.Show();
            this.Close();

        }

        private void btnFaculty_Click(object sender, RoutedEventArgs e)
        {
            _BorrowerLogin borrower = new _BorrowerLogin();
            borrower.Show();
            this.Close();
        }
    }
}
