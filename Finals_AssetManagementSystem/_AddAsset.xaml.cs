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
    /// Interaction logic for _AddAsset.xaml
    /// </summary>
    public partial class _AddAsset : Window
    {
        public _AddAsset()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            _Assets items = new _Assets();
            items.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtAssetName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtAssetCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtPurchaseDate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxRoomNo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxFloorNo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxBuildingName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtSupplierName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtContactPerson_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtContactNum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            _Home home = new _Home();
            home.Show();
            this.Close();
        }

        private void ComboBoxStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
