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
            List<ShowAllAssetsResult> showAllAssetsResults = db.ShowAllAssets().ToList();
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            int z = 0;
            int q = 0;
            foreach (var item in showAllAssetsResults)
            {
                if (!cbCategory.Items.Contains(item.AssetType))
                {
                    cbCategory.Items.Add(item.AssetType);
                }
            }

            for (int x = 0; x < showAllAssetsResults.Count; x++)
            {
                if (!a.Contains(showAllAssetsResults[x].AssetName.ToString()) && showAllAssetsResults[x].AssetStatus.ToString() == "Available")
                {
                    a.Add(showAllAssetsResults[x].AssetName.ToString());
                    lbxAvailableItems.Items.Add(a[z] + "\t\t" + showAllAssetsResults[x].AssetType.ToString() + "\t\t" + showAllAssetsResults[x].AssetStatus.ToString());
                    z++;
                }
            }
        }

        private void fillborrow() //Missing USP for selecting all of the borrowers as well as inserting!!! 
        {

        }

        private void btnReturnItems_Click(object sender, RoutedEventArgs e)
        {
            _ReturnAsset returnItems = new _ReturnAsset();
            returnItems.Show();
            this.Close();
        }

        private void cbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        } 

        private void updateListbox()
        {
            lbxAvailableItems.Items.Clear();
            List<ShowAssetsByFilterResult> showAssetsByFilterResults = db.ShowAssetsByFilter(cat, stat).ToList();
            List<string> a = new List<string>();
            int z = 0;


            for (int x = 0; x < showAssetsByFilterResults.Count; x++)
            {
                if (!a.Contains(showAssetsByFilterResults[x].AssetName.ToString()) && showAssetsByFilterResults[x].AssetStatus.ToString() == "Available")
                {
                    a.Add(showAssetsByFilterResults[x].AssetName.ToString());
                    lbxAvailableItems.Items.Add(a[z] + "\t\t" + showAssetsByFilterResults[x].AssetType.ToString() + "\t\t" + showAssetsByFilterResults[x].AssetStatus.ToString());
                    z++;
                }
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
                    List<string> a = new List<string>();
                    int z = 0;
                    List<ShowAssetsBySearchFilterResult> showAssetsBySearchFiltersResults = db.ShowAssetsBySearchFilter(filter).ToList();
                    for (int x = 0; x < showAssetsBySearchFiltersResults.Count; x++)
                    {
                        if (!a.Contains(showAssetsBySearchFiltersResults[x].AssetName.ToString()) && showAssetsBySearchFiltersResults[x].AssetStatus.ToString() == "Available")
                        {
                            a.Add(showAssetsBySearchFiltersResults[z].AssetName.ToString());
                            lbxAvailableItems.Items.Add(showAssetsBySearchFiltersResults[x].AssetName + "\t\t" + showAssetsBySearchFiltersResults[x].AssetType + "\t\t" + showAssetsBySearchFiltersResults[x].AssetStatus);
                            z++;
                        }
                    }
                }
                else
                {
                    fill();
                }
            }
        }

        private void lbxAvailableItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] b = lbxAvailableItems.SelectedItem.ToString().Split('\t');
            int qty = (int)db.GetTotalCountByAssetName(b[0]);
            txtAvailableQty.Text = qty.ToString();
        }
    }
}
