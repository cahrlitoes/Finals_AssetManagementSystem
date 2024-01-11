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
    /// Interaction logic for _MaintenanceSched.xaml
    /// </summary>
    public partial class _MaintenanceSched : Window
    {
        public _MaintenanceSched()
        {
            InitializeComponent();
        }

        private void txtAssetID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxMaintainType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtLastMaintainDate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNextMaintainDate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMaintainDesc_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtRepairFN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtRepairLN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtRepairContactNo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtRepairEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnEditInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lbxMaintainHistory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            _Home home = new _Home();
            home.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
