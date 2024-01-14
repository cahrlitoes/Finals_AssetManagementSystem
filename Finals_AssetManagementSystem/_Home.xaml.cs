using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

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
            UI_Initialise();
        }

        private void UI_Initialise()
        {
            DateTime datetime = DateTime.Now;
            var date = datetime;
            DateToday.Content = "Date Today: " + date;
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick (object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            var date = datetime;
            DateToday.Content = "Date Today: " + date;
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
