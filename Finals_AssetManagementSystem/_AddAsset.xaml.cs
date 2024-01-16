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
