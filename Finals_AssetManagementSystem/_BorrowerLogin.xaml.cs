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
    /// Interaction logic for _BorrowerLogin.xaml
    /// </summary>
    public partial class _BorrowerLogin : Window
    {
        AssetManagementDataContext db = new AssetManagementDataContext();


        public _BorrowerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            List<BorrowerLoginResult> result = db.BorrowerLogin(txtEmailAddress.Text, txtPassword.Password).ToList();
            if (result.Count > 0 && result[0] != null)
            {
                _Home dashboard = new _Home();
                dashboard.Show();
                this.Close();
            }
            if (result.Count <= 0)
            {
                MessageBox.Show("incorrect user or password");
                txtPassword.Password = "";
                txtEmailAddress.Text = "";
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin_Click((object)sender, e);
            }
        }
    }
}
