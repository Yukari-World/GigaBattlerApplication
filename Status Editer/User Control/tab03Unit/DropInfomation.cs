//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Drop Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System.ComponentModel;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab03Unit {
	[ToolboxItem(true)]
	public partial class DropInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// バインド
		private __table_weaponDataTable WeaponTable = new __table_weaponDataTable();
		private __table_shieldDataTable ShieldTable = new __table_shieldDataTable();
		private __table_helmetDataTable HelmetTable = new __table_helmetDataTable();
		private __table_gauntletDataTable GauntletTable = new __table_gauntletDataTable();
		private __table_armorDataTable ArmorTable = new __table_armorDataTable();
		private __table_accessoryDataTable AccresoryTable = new __table_accessoryDataTable();


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
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable) {
			// データバインドの設定
			// オーバーロードを利用して大体コピペで済むように
			dropInfoParts1.SetDataBindings(TableUnitDataTable, WeaponTable);
			dropInfoParts2.SetDataBindings(TableUnitDataTable, ShieldTable);
			dropInfoParts3.SetDataBindings(TableUnitDataTable, HelmetTable);
			dropInfoParts4.SetDataBindings(TableUnitDataTable, GauntletTable);
			dropInfoParts5.SetDataBindings(TableUnitDataTable, ArmorTable);
			dropInfoParts6.SetDataBindings(TableUnitDataTable, AccresoryTable);

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="WeaponAdapter">__table_weaponTableAdapter</param>
		/// <param name="ShieldAdapter">__table_shieldTableAdapter</param>
		/// <param name="HelmetAdapter">__table_helmetTableAdapter</param>
		/// <param name="GauntletAdapter">__table_gauntletTableAdapter</param>
		/// <param name="ArmorAdapter">__table_armorTableAdapter</param>
		/// <param name="AccessoryAdapter">__table_accessoryTableAdapter</param>
		public void ReloadDataTable(__table_weaponTableAdapter WeaponAdapter, __table_shieldTableAdapter ShieldAdapter, __table_helmetTableAdapter HelmetAdapter, __table_gauntletTableAdapter GauntletAdapter, __table_armorTableAdapter ArmorAdapter, __table_accessoryTableAdapter AccessoryAdapter) {
			WeaponAdapter.Fill(WeaponTable);
			ShieldAdapter.Fill(ShieldTable);
			HelmetAdapter.Fill(HelmetTable);
			GauntletAdapter.Fill(GauntletTable);
			ArmorAdapter.Fill(ArmorTable);
			AccessoryAdapter.Fill(AccresoryTable);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
