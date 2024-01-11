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
    /// Interaction logic for _Assets.xaml
    /// </summary>
    public partial class _Assets : Window
    {
        public _Assets()
        {
            InitializeComponent();
        }


        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxStatus_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lbxAllItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, RoutedEventArgs e)
        {
            _AddAsset add = new _AddAsset();
            add.Show();
            this.Close();
        }

        private void btnUpdateItem_Copy_Click(object sender, RoutedEventArgs e)
        {
            _UpdateAssetxaml update = new _UpdateAssetxaml();
            update.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            _Home home = new _Home();
            home.Show();
            this.Close();   
        }
    }
}
