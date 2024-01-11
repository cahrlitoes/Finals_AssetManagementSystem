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

            db = new AssetManagementDataContext(Properties.Settings.Default.Asset_Management_SystemConnectionString);

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmailAddress.Text.Length > 0)
            {
                if (passComparison(getPassword()))
                {
                    MessageBox.Show("Login Success", "Welcome Back!", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show("Invalid Username and/or Password", "Login Failed", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Please input a valid password.", "Blank Password", MessageBoxButton.OK);
            }

            _BorrowAsset borrow = new _BorrowAsset();
            borrow.Show();
            this.Close();   

        }

        public string getPassword()
        {
            string uPass = "";

            var users = from s in db.Borrowers where s.BorrowerEmail == txtEmailAddress.Text select s;

            if (users.Count() == 1)
            {
                foreach (Borrower user in users)
                {
                    uPass = user.BorrowerPW;
                }
            }
            return uPass;
        }


        private bool passComparison(string uPass)
        {
            if (txtPassword.Password == uPass)
                return true;
            else
                return false;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
