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

namespace Finals_AssetManagementSystem
{
    /// <summary>
    /// Interaction logic for _BorrowersHistory.xaml
    /// </summary>
    public partial class _BorrowersHistory : Window
    {
        public _BorrowersHistory()
        {
            InitializeComponent();
        }

        private void lbxAvailableBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtUserSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            _Home home = new _Home();
            home.Show();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lbxBorrowerName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lbxBorrowedItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
