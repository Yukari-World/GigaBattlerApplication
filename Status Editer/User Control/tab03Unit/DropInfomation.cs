//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Drop Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab03Unit {
	[ToolboxItem(true)]
	public partial class DropInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public DropInfomation() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		/// <param name="TableWeaponDataTable">Weapon Data Table</param>
		/// <param name="TableShieldDataTable">Shield Data Table</param>
		/// <param name="TableHelmetDataTable">Helmet Data Table</param>
		/// <param name="TableGauntletDataTable">Gauntlet Data Table</param>
		/// <param name="TableArmorDataTable">Armor Data Table</param>
		/// <param name="TableAccessoryDataTable">Accessory Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_weaponDataTable TableWeaponDataTable, __table_shieldDataTable TableShieldDataTable, __table_helmetDataTable TableHelmetDataTable, __table_gauntletDataTable TableGauntletDataTable, __table_armorDataTable TableArmorDataTable, __table_accessoryDataTable TableAccessoryDataTable) {
			// データバインドの設定
			// オーバーロードを利用して大体コピペで済むように
			dropInfoParts1.SetDataBindings(TableUnitDataTable, TableWeaponDataTable);
			dropInfoParts2.SetDataBindings(TableUnitDataTable, TableShieldDataTable);
			dropInfoParts3.SetDataBindings(TableUnitDataTable, TableHelmetDataTable);
			dropInfoParts4.SetDataBindings(TableUnitDataTable, TableGauntletDataTable);
			dropInfoParts5.SetDataBindings(TableUnitDataTable, TableArmorDataTable);
			dropInfoParts6.SetDataBindings(TableUnitDataTable, TableAccessoryDataTable);

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="TableWeaponDataTable">Weapon Data Table</param>
		/// <param name="TableShieldDataTable">Shield Data Table</param>
		/// <param name="TableHelmetDataTable">Helmet Data Table</param>
		/// <param name="TableGauntletDataTable">Gauntlet Data Table</param>
		/// <param name="TableArmorDataTable">Armor Data Table</param>
		/// <param name="TableAccessoryDataTable">Accessory Data Table</param>
		public void ReloadDataTable(__table_weaponDataTable TableWeaponDataTable, __table_shieldDataTable TableShieldDataTable, __table_helmetDataTable TableHelmetDataTable, __table_gauntletDataTable TableGauntletDataTable, __table_armorDataTable TableArmorDataTable, __table_accessoryDataTable TableAccessoryDataTable) {
			dropInfoParts1.ReloadBindings(TableWeaponDataTable);
			dropInfoParts2.ReloadBindings(TableShieldDataTable);
			dropInfoParts3.ReloadBindings(TableHelmetDataTable);
			dropInfoParts4.ReloadBindings(TableGauntletDataTable);
			dropInfoParts5.ReloadBindings(TableArmorDataTable);
			dropInfoParts6.ReloadBindings(TableAccessoryDataTable);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
