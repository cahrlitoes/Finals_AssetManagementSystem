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
    /// Interaction logic for _UpdateAssetxaml.xaml
    /// </summary>
    public partial class _UpdateAssetxaml : Window
    {
        AssetManagementDataContext db = new AssetManagementDataContext
        ();

        private static string AS = "";
        private static int LID = 0;
        public _UpdateAssetxaml()
        {
            InitializeComponent();
            AdminName.Content = StaticClass.storestring;
            #region filling data
            List<ShowAssetInfoByAssetCodeResult> showAssetInfoByAssetCodeResults = db.ShowAssetInfoByAssetCode(StaticClass.storeassetcode).ToList();
            tctAssetCode.Text = showAssetInfoByAssetCodeResults[0].AssetCode;

            cbStatus.Items.Clear();
            cbStatus.Items.Add(showAssetInfoByAssetCodeResults[0].AssetStatus);
            if (showAssetInfoByAssetCodeResults[0].AssetStatus == "Available")
                cbStatus.Items.Add("Unavailable");
            else if (showAssetInfoByAssetCodeResults[0].AssetStatus == "Unavailable")
                cbStatus.Items.Add("Available");
            cbStatus.SelectedIndex = 0;

            cbRoomNo.Items.Clear();
            cbRoomNo.Items.Add(showAssetInfoByAssetCodeResults[0].RoomNo);
            cbRoomNo.SelectedIndex = 0;

            cbBuildingName.Items.Clear();
            cbBuildingName.Items.Add(showAssetInfoByAssetCodeResults[0].BldgName);
            cbBuildingName.SelectedIndex = 0;

            cbFloorNo.Items.Clear();
            cbFloorNo.Items.Add(showAssetInfoByAssetCodeResults[0].FloorNo);
            cbFloorNo.SelectedIndex = 0;

            cbRoomNo.Items.Clear();
            cbRoomNo.Items.Add(showAssetInfoByAssetCodeResults[0].RoomNo);
            cbRoomNo.SelectedIndex = 0;
            #endregion
            List<AddBuildingsResult> addBuildingsResults = db.AddBuildings().ToList();
            for (int x = 0; x < addBuildingsResults.Count; x++)
            {
                if (!cbBuildingName.Items.Contains(addBuildingsResults[x].BldgName))
                {
                    cbBuildingName.Items.Add(addBuildingsResults[x].BldgName);
                }
            }
        }

        private void txtAssetCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxRoomNo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbFloorNo.SelectedIndex = cbRoomNo.SelectedIndex;
        }

        private void ComboBoxFloorNo_SelectionChanged_3(object sender, SelectionChangedEventArgs e)
        {
            cbRoomNo.SelectedIndex = cbFloorNo.SelectedIndex;
        }

        private void ComboBoxBuildingName_SelectionChanged_4(object sender, SelectionChangedEventArgs e)
        {
            cbFloorNo.SelectedIndex = -1;
            cbRoomNo.SelectedIndex= -1;
            cbFloorNo.Items.Clear();
            cbRoomNo.Items.Clear();
            string a = cbBuildingName.SelectedItem.ToString();
            List<AddDataByBuildingResult> addDataByBuildingResults = db.AddDataByBuilding(a).ToList();
            for (int x = 0;x < addDataByBuildingResults.Count; x++)
            {
                cbRoomNo.Items.Add(addDataByBuildingResults[x].RoomNo);
                cbFloorNo.Items.Add(addDataByBuildingResults[x].FloorNo);
            }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            _Assets item = new _Assets();
            item.Show(); 
            this.Close();
        }

        private void btnUpdateItems_Click(object sender, RoutedEventArgs e)
        {
            if (cbRoomNo.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill all the all fields. . .");
            }
            else
            {
                string a = cbRoomNo.SelectedItem.ToString();
                string b = cbFloorNo.SelectedItem.ToString();
                string c = cbBuildingName.SelectedItem.ToString();
                List<GrabLocationIDForUpdateViaLocFieldResult> grabLocationIDForUpdateViaLocFieldResults = db.GrabLocationIDForUpdateViaLocField(int.Parse(a), int.Parse(b), c).ToList();
                AS = cbStatus.SelectedItem.ToString();
                LID = grabLocationIDForUpdateViaLocFieldResults[0].LocationID;
                db.updateAssetInformation(AS, LID, StaticClass.storeassetcode);
                MessageBox.Show("Asset Updated!");
                _Assets item = new _Assets();
                item.Show();
                this.Close();
            }

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            _Home home = new _Home();
            home.Show();
            this.Close();
        }
    }
}
