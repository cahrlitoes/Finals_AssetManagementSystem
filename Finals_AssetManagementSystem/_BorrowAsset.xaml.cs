using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Interaction logic for _BorrowAsset.xaml
    /// </summary>
    public partial class _BorrowAsset : Window
    {
        AssetManagementDataContext db = new AssetManagementDataContext
     ();
        public static string cat = "";
        public static string stat = "Available";

        public _BorrowAsset()
        {
            InitializeComponent();
            fill();
        
        }

        private void fill()
        {
            AdminName.Content = StaticClass.storestring;
            int x = 0;
            List<ShowAllAssetsResult> showAllAssetsResults = db.ShowAllAssets().ToList();
            foreach (var item in showAllAssetsResults)
            {
                lbxAvailableItems.Items.Add(showAllAssetsResults[x].AssetName + "\t\t" + showAllAssetsResults[x].AssetCode + "\t\t" + showAllAssetsResults[x].AssetType + "\t\t" + showAllAssetsResults[x].AssetStatus);
                x++;
            }
        }

        private void btnReturnItems_Click(object sender, RoutedEventArgs e)
        {
            _ReturnAsset returnItems = new _ReturnAsset();
            returnItems.Show();
            this.Close();
        }

        private void cbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbxAvailableItems.SelectedItem = -1;
            cat = (string)cbCategory.SelectedItem;
            updateListbox();
        }

        private void updateListbox()
        {
            lbxAvailableItems.Items.Clear();
            int x = 0;
            List<ShowAssetsByFilterResult> showAssetsByFilterResults = db.ShowAssetsByFilter(cat, stat).ToList();
            foreach (var item in showAssetsByFilterResults)
            {
                lbxAvailableItems.Items.Add(showAssetsByFilterResults[x].AssetName + "\t\t" + showAssetsByFilterResults[x].AssetCode + "\t\t" + showAssetsByFilterResults[x].AssetType + "\t\t" + showAssetsByFilterResults[x].AssetStatus);
                x++;
            }
        }

        private void txtUserSearch_KeyUp(object sender, KeyEventArgs e)
        {
            cbCategory.SelectedIndex = -1;
            if (e.Key == Key.Enter)
            {
                lbxAvailableItems.Items.Clear();
                if (txtUserSearch.Text.Length > 0)
                {
                    string filter = txtUserSearch.Text;
                    List<ShowAssetsBySearchFilterResult> showAssetsBySearchFiltersResults = db.ShowAssetsBySearchFilter(filter).ToList();
                    for (int x = 0; x < showAssetsBySearchFiltersResults.Count; x++)
                    {
                        lbxAvailableItems.Items.Add(showAssetsBySearchFiltersResults[x].AssetName + "\t\t" + showAssetsBySearchFiltersResults[x].AssetCode + "\t\t" + showAssetsBySearchFiltersResults[x].AssetType + "\t\t" + showAssetsBySearchFiltersResults[x].AssetStatus);
                    }
                }
                else
                {
                    fill();
                }

            }
        }
    }
}
