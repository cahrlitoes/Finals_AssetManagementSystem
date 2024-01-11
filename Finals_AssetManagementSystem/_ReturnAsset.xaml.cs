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
    /// Interaction logic for _ReturnAsset.xaml
    /// </summary>
    public partial class _ReturnAsset : Window
    {
        public _ReturnAsset()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            _BorrowAsset back = new _BorrowAsset();
            back.Show();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lbxBorrowedItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnReturnItems_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
