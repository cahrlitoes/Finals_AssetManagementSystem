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
    /// Interaction logic for _Requests.xaml
    /// </summary>
    public partial class _Requests : Window
    {
        public _Requests()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            _Home home = new _Home();
            home.Show();
            this.Close();
        }

        private void lbxPendingRequests_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtRequestStatusID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxRequestStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtAdminComments_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnUpdateRequests_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
