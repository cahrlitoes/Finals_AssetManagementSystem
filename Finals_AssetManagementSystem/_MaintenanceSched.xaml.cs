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
        AssetManagementDataContext db = new AssetManagementDataContext();
        List<string> maintenanceHistory = new List<string>();

        public _MaintenanceSched()
        {
            InitializeComponent();
            InitializeComboBox();
            LoadMaintenanceHistory();
            AdminName.Content = StaticClass.storestring;
        }

        private void InitializeComboBox()
        {

            cbMaintenanceType.Items.Add("Preventive");
            cbMaintenanceType.Items.Add("Corrective");

            cbMaintenanceType.IsEnabled = true;

            cbMaintenanceType.SelectedIndex = -1;
        }

        public void InsertMaintenance()
        {

            //if (!int.TryParse(txtAssetID.Text, out int assetID))
            //{
            //    MessageBox.Show("Please enter a valid Asset ID.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            string assetCode = txtAssetCode.Text;
            DateTime lastMaintDate = dpLastMaintDate.SelectedDate ?? DateTime.MinValue;
            DateTime nextMaintDate = dpRepairCycle.SelectedDate ?? DateTime.MinValue;
            string maintType = cbMaintenanceType.SelectedItem as string;
            string maintDesc = txtMaintenanceDesc.Text;

            int aid = (int)db.udfGetAssetIDByAssetCode(assetCode);

            if (aid == 0)
            {
                MessageBox.Show("Asset does not exist.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (lastMaintDate == DateTime.MinValue || nextMaintDate == DateTime.MinValue || string.IsNullOrWhiteSpace(maintType) || string.IsNullOrWhiteSpace(maintDesc))
                {
                    MessageBox.Show("Please fill in all fields and select valid dates.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                db.uspInsertMaintenance(aid, lastMaintDate.Date, nextMaintDate.Date, maintType, maintDesc);
                MessageBox.Show("Maintenance information successfully updated.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                txtAssetCode.Clear();
                dpLastMaintDate.SelectedDate = null;
                dpRepairCycle.SelectedDate = null;
                cbMaintenanceType.SelectedIndex = -1;
                txtMaintenanceDesc.Clear();

                LoadMaintenanceHistory();
            }




        }

        private void LoadMaintenanceHistory()
        {
            lbxMaintenanceHistory.Items.Clear();

            maintenanceHistory.Clear();

            int x = 0;
            List<uspGetMaintenanceHistoryResult> showMaintenance = db.uspGetMaintenanceHistory().ToList();
            foreach (var item in showMaintenance)
            {
                DateTime lastdate = DateTime.Parse(item.LastMaintDate.ToString());
                string LastMaintDate = lastdate.Date.ToString("yyyy-MM-dd");

                DateTime nextdate = DateTime.Parse(item.MaintCycle.ToString());
                string MaintCycleDate = nextdate.Date.ToString("yyyy-MM-dd");

                lbxMaintenanceHistory.Items.Add(item.AssetID.ToString() +
                                     "\t\t" + item.AssetCode + "\t\t" +
                                     LastMaintDate +
                                     "\t\t" +
                                     MaintCycleDate +
                                     "\t\t" +
                                     item.MaintType +
                                     "\t\t" +
                                     item.MaintDesc);
                x++;
            }

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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            InsertMaintenance();
        }

        private void txtAssetCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lbxMaintenanceHistory.Items.Clear();
                if (txtSearch.Text.Length > 0)
                {
                    string filter = txtSearch.Text;
                    List<uspSearchByAssetCodeResult> showAssetsBySearchFiltersResults = db.uspSearchByAssetCode(filter).ToList();
                    for (int x = 0; x < showAssetsBySearchFiltersResults.Count; x++)
                    {
                        DateTime lastdate = DateTime.Parse(showAssetsBySearchFiltersResults[x].LastMaintDate.ToString());
                        string LastMaintDate = lastdate.Date.ToString("yyyy-MM-dd");

                        DateTime nextdate = DateTime.Parse(showAssetsBySearchFiltersResults[x].MaintCycle.ToString());
                        string MaintCycleDate = nextdate.Date.ToString("yyyy-MM-dd");
                        lbxMaintenanceHistory.Items.Add(showAssetsBySearchFiltersResults[x].AssetID + "\t\t" + showAssetsBySearchFiltersResults[x].AssetCode + "\t\t" + LastMaintDate + "\t\t" + MaintCycleDate + "\t\t" + showAssetsBySearchFiltersResults[x].MaintType + "\t\t" + showAssetsBySearchFiltersResults[x].MaintDesc);
                    }
                }
                else
                {
                    LoadMaintenanceHistory();
                }
                //dfsdsfdsfsd
                MessageBox.Show("aaaa");

            }
        }
    }
}