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
    /// Interaction logic for _Assets.xaml
    /// </summary>
    public partial class _Assets : Window
    {
        AssetManagementDataContext db = new AssetManagementDataContext
      ();
        public static string cat = "";
        public static string stat = "Available";
        public _Assets()
        {
            InitializeComponent();
            fill();
        }

        private void updateListbox()
        {
            lbxAllItems.Items.Clear();
            int x = 0;
            List<ShowAssetsByFilterResult> showAssetsByFilterResults = db.ShowAssetsByFilter(cat, stat).ToList();
            foreach (var item in showAssetsByFilterResults)
            {
                lbxAllItems.Items.Add(showAssetsByFilterResults[x].AssetName + "\t\t" + showAssetsByFilterResults[x].AssetCode + "\t\t" + showAssetsByFilterResults[x].AssetType + "\t\t" + showAssetsByFilterResults[x].AssetStatus);
                x++;
            }
        }


        private void ComboBoxCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbxAllItems.SelectedItem = -1;
            cat = (string)cbCategory.SelectedItem;
            updateListbox();

        }

        private void ComboBoxStatus_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            lbxAllItems.SelectedItem = -1;
           stat = (string)cbStatus.SelectedItem;
           updateListbox();
        }

        private void btnAddItems_Click(object sender, RoutedEventArgs e)
        {
            _AddAsset add = new _AddAsset();
            add.Show();
            this.Close();
        }

        private void btnUpdateItem_Copy_Click(object sender, RoutedEventArgs e)
        {
            string[] a = lbxAllItems.SelectedItem.ToString().Split('\t');
            StaticClass.storeassetcode = a[2];
            _UpdateAssetxaml update = new _UpdateAssetxaml();
            update.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            _Home home = new _Home();
            home.Show();
            this.Close();   
        }
        private void fill()
        {
             AdminName.Content = StaticClass.storestring;
            int x = 0;
            List<ShowAllAssetsResult> showAllAssetsResults = db.ShowAllAssets().ToList();
            foreach (var item in showAllAssetsResults)
            {
                lbxAllItems.Items.Add(showAllAssetsResults[x].AssetName + "\t\t" + showAllAssetsResults[x].AssetCode + "\t\t" + showAllAssetsResults[x].AssetType + "\t\t" + showAllAssetsResults[x].AssetStatus);
                x++;
            }
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            cbCategory.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            if (e.Key == Key.Enter)
            {
                lbxAllItems.Items.Clear();
                if (txtSearch.Text.Length > 0 ) 
                {
                    string filter = txtSearch.Text;
                    List<ShowAssetsBySearchFilterResult> showAssetsBySearchFiltersResults = db.ShowAssetsBySearchFilter(filter).ToList();
                    for (int x = 0; x < showAssetsBySearchFiltersResults.Count; x++)
                    {
                        lbxAllItems.Items.Add(showAssetsBySearchFiltersResults[x].AssetName + "\t\t" + showAssetsBySearchFiltersResults[x].AssetCode + "\t\t" + showAssetsBySearchFiltersResults[x].AssetType + "\t\t" + showAssetsBySearchFiltersResults[x].AssetStatus);
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
