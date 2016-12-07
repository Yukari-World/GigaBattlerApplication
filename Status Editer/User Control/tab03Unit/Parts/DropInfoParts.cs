//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Drop Infomation Parts
//
// アイテム毎の処理内容は同じなのである程度はコピペで対応可
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab03Unit.Parts {
	[ToolboxItem(true)]
	public partial class DropInfoParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// [R/W]グループラベルのテキストを設定します
		/// </summary>
		[Description("[R/W]グループラベルのテキストを設定します")]
		public string labelText {
			get { return groupBoxDrop.Text; }
			set { groupBoxDrop.Text = value; }
		}// End Property


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public DropInfoParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		//----------------------------------------------------------------------------------------------------
		#region Weapon
		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		/// <param name="TableWeaponDataTable">Weapon Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_weaponDataTable TableWeaponDataTable) {
			// コンボボックスの設定
			comboDropTable.DataSource = TableWeaponDataTable.Copy();
			comboDropTable.DisplayMember = "WeaponName";
			comboDropTable.ValueMember = "WeaponID";

			//----------------------------------------------------------------------------------------------------
			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", TableUnitDataTable, "Item1", true));
			numericDropRate.DataBindings.Add(new Binding("Value", TableUnitDataTable, "Per1", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------
		#region Shield
		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		/// <param name="TableShieldDataTable">Shield Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_shieldDataTable TableShieldDataTable) {
			// コンボボックスの設定
			comboDropTable.DataSource = TableShieldDataTable.Copy();
			comboDropTable.DisplayMember = "ShieldName";
			comboDropTable.ValueMember = "ShieldID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", TableUnitDataTable, "Item2", true));
			numericDropRate.DataBindings.Add(new Binding("Value", TableUnitDataTable, "Per2", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------
		#region Helmet
		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		/// <param name="TableHelmetDataTable">Helmet Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_helmetDataTable TableHelmetDataTable) {
			// コンボボックスの設定
			comboDropTable.DataSource = TableHelmetDataTable.Copy();
			comboDropTable.DisplayMember = "HelmetName";
			comboDropTable.ValueMember = "HelmetID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", TableUnitDataTable, "Item3", true));
			numericDropRate.DataBindings.Add(new Binding("Value", TableUnitDataTable, "Per3", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------
		#region Gauntlet
		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		/// <param name="TableGauntletDataTable">Gauntlet Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_gauntletDataTable TableGauntletDataTable) {
			// コンボボックスの設定
			comboDropTable.DataSource = TableGauntletDataTable.Copy();
			comboDropTable.DisplayMember = "GauntletName";
			comboDropTable.ValueMember = "GauntletID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", TableUnitDataTable, "Item4", true));
			numericDropRate.DataBindings.Add(new Binding("Value", TableUnitDataTable, "Per4", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------
		#region Armor
		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		/// <param name="TableArmorDataTable">Armor Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_armorDataTable TableArmorDataTable) {
			// コンボボックスの設定
			comboDropTable.DataSource = TableArmorDataTable.Copy();
			comboDropTable.DisplayMember = "ArmorName";
			comboDropTable.ValueMember = "ArmorID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", TableUnitDataTable, "Item5", true));
			numericDropRate.DataBindings.Add(new Binding("Value", TableUnitDataTable, "Per5", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------
		#region Accessory
		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		/// <param name="TableAccessoryDataTable">Accessory Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_accessoryDataTable TableAccessoryDataTable) {
			// コンボボックスの設定
			comboDropTable.DataSource = TableAccessoryDataTable.Copy();
			comboDropTable.DisplayMember = "AccessoryName";
			comboDropTable.ValueMember = "AccessoryID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", TableUnitDataTable, "Item6", true));
			numericDropRate.DataBindings.Add(new Binding("Value", TableUnitDataTable, "Per6", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------
		// 共通処理
		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="DataTable">対象のデータテーブル</param>
		public void ReloadBindings(DataTable DataTable) {
			comboDropTable.DataSource = DataTable.Copy();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
