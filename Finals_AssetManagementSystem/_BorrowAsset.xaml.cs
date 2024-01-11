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
    /// Interaction logic for _BorrowAsset.xaml
    /// </summary>
    public partial class _BorrowAsset : Window
    {
        public _BorrowAsset()
        {
            InitializeComponent();
        }

        private void lbxAvailableItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lbxBorrowItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnRequestBorrow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReturnItems_Click(object sender, RoutedEventArgs e)
        {
            _ReturnAsset returnItems = new _ReturnAsset();
            returnItems.Show();
            this.Close();
        }

        private void txtUserSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
