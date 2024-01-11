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
    /// Interaction logic for _UpdateAssetxaml.xaml
    /// </summary>
    public partial class _UpdateAssetxaml : Window
    {
        public _UpdateAssetxaml()
        {
            InitializeComponent();
        }

        private void txtAssetCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxRoomNo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxFloorNo_SelectionChanged_3(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxBuildingName_SelectionChanged_4(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            _Assets item = new _Assets();
            item.Show(); 
            this.Close();
        }

        private void btnUpdateItems_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            _Home home = new _Home();
            home.Show();
            this.Close();
        }
    }
}
