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
    /// Interaction logic for _Home.xaml
    /// </summary>
    public partial class _Home : Window
    {
        public _Home()
        {
            InitializeComponent();
        }

        private void btnItems_Click(object sender, RoutedEventArgs e)
        {
            _Assets items = new _Assets();
            items.Show();
            this.Close();
        }

        private void btnMaintenance_Click(object sender, RoutedEventArgs e)
        {
            _MaintenanceSched maintenance = new _MaintenanceSched();
            maintenance.Show();
            this.Close();
        }

        private void btnBorrowers_Click(object sender, RoutedEventArgs e)
        {
            _BorrowersHistory faculty = new _BorrowersHistory();
            faculty.Show();
            this.Close();
        }

        private void btnPendings_Click(object sender, RoutedEventArgs e)
        {
            _Requests pending = new _Requests();
            pending.Show();
            this.Close();
        }
    }
}
