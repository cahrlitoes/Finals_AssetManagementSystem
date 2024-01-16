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
        AssetManagementDataContext db = new AssetManagementDataContext
        ();
        public _AddAsset()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            List<AddBuildingsResult> addBuildingsResults = db.AddBuildings().ToList();
            for (int x = 0; x < addBuildingsResults.Count; x++)
            {
                if (!cbBuildingName.Items.Contains(addBuildingsResults[x].BldgName))
                {
                    cbBuildingName.Items.Add(addBuildingsResults[x].BldgName);
                }
            }

            cbCategory.Items.Add("Equipment");
            cbCategory.Items.Add("Utility");
            cbCategory.Items.Add("Furniture");

            cbStatus.Items.Add("Available");
            cbStatus.Items.Add("Unavailable");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            _Assets items = new _Assets();
            items.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string assetcode = txtAssetCode.Text;
            string assetname = txtAssetName.Text;
            string pd = txtPurchaseDate.Text;
            string sn =  txtSupplierName.Text;
            string contactnum =  txtContactNum.Text;
            string contactperson = txtContactPerson.Text;

            List<FindLocIDResult> findLocIDResults = db.FindLocID(int.Parse(cbRoomNo.SelectedItem.ToString()),int.Parse(cbFloorNo.SelectedItem.ToString()), cbBuildingName.SelectedItem.ToString()).ToList();
            List<GetSuppIdResult> getSuppIdResults = db.GetSuppId().ToList();

            db.InsertNewAsset(assetcode, assetname, cbCategory.SelectedItem.ToString(), pd, sn, findLocIDResults[0].LocationID, getSuppIdResults[getSuppIdResults.Count - 1].SupplierID++);
            db.InsertNewSupplier(sn, contactperson, contactnum);
            MessageBox.Show("Successfully added");
            btnHome_Click(sender, e);
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

        private void cbBuildingName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbFloorNo.SelectedIndex = -1;
            cbRoomNo.SelectedIndex = -1;
            cbFloorNo.Items.Clear();
            cbRoomNo.Items.Clear();
            string a = cbBuildingName.SelectedItem.ToString();
            List<AddDataByBuildingResult> addDataByBuildingResults = db.AddDataByBuilding(a).ToList();
            for (int x = 0; x < addDataByBuildingResults.Count; x++)
            {
                cbRoomNo.Items.Add(addDataByBuildingResults[x].RoomNo);
                cbFloorNo.Items.Add(addDataByBuildingResults[x].FloorNo);
            }
        }

        private void cbRoomNo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbFloorNo.SelectedIndex = cbRoomNo.SelectedIndex;
        }

        private void cbFloorNo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbRoomNo.SelectedIndex = cbFloorNo.SelectedIndex;
        }
    }
}
