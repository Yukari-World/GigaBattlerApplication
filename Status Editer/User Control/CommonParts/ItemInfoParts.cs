//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Item Infomation Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.CommonParts {
	[ToolboxItem(true)]
	public partial class ItemInfoParts : UserControl {
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
		public ItemInfoParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableWeaponDataTable">Weapon Data Table</param>
		/// <param name="TableElementDataTable">Table Element Data Table</param>
		/// <param name="TableWeaponTypeDataTable">Weapon Type Data Table</param>
		public void SetDataBindings(__table_weaponDataTable TableWeaponDataTable, __table_elementDataTable TableElementDataTable, __table_weapon_typeDataTable TableWeaponTypeDataTable) {
			// データ項目の作成
			// データ項目が少なく、わざわざデータベース化する必要のない項目

			// Target
			DataTable TargetDataTable = new DataTable();

			TargetDataTable.Columns.Add("DataID", Type.GetType("System.Int32"));
			TargetDataTable.Columns.Add("DataName", Type.GetType("System.String"));

			// 項目配列。Listでもよかったかも...?
			int[] TargetDataValue = new int[] { 0, 1 };
			string[] TargetDataName = new string[] { "単体", "全体" };

			// 項目の構築
			for (int i = 0; i < TargetDataValue.Length; i++) {
				DataRow row = TargetDataTable.NewRow();

				// カラムにデータを割り当てる
				row["DataID"] = TargetDataValue[i];
				row["DataName"] = TargetDataName[i];

				// Debug文
				Debug.WriteLine("Target Data Table Row Data:" + TargetDataValue[i] + "\t" + TargetDataName[i] + ";");

				// 追加する
				TargetDataTable.Rows.Add(row);
			}// End Loop

			// EType
			DataTable HandDataTable = new DataTable();

			HandDataTable.Columns.Add("DataID", Type.GetType("System.Int32"));
			HandDataTable.Columns.Add("DataName", Type.GetType("System.String"));

			// 項目配列。Listでもよかったかも...?
			int[] HandDataValue = new int[] { 1, 2 };
			string[] HandDataName = new string[] { "片手", "両手" };

			// 項目の構築
			for (int i = 0; i < HandDataValue.Length; i++) {
				DataRow row = HandDataTable.NewRow();

				// カラムにデータを割り当てる
				row["DataID"] = HandDataValue[i];
				row["DataName"] = HandDataName[i];

				// Debug文
				Debug.WriteLine("Hand Data Table Row Data:" + HandDataValue[i] + "\t" + HandDataName[i] + ";");

				// 追加する
				HandDataTable.Rows.Add(row);
			}// End Loop

			//----------------------------------------------------------------------------------------------------
			// コンボボックスの設定

			comboEquipItemGroup.DataSource = TableWeaponTypeDataTable.Copy();
			comboEquipItemGroup.DisplayMember = "WeaponTypeName";
			comboEquipItemGroup.ValueMember = "WeaponTypeID";

			comboAttackItemGroup.DataSource = TableWeaponTypeDataTable.Copy();
			comboAttackItemGroup.DisplayMember = "WeaponTypeName";
			comboAttackItemGroup.ValueMember = "WeaponTypeID";

			comboTarget.DataSource = TargetDataTable;
			comboTarget.DisplayMember = "DataName";
			comboTarget.ValueMember = "DataID";

			comboEType.DataSource = HandDataTable;
			comboEType.DisplayMember = "DataName";
			comboEType.ValueMember = "DataID";

			//----------------------------------------------------------------------------------------------------
			// データバインドの設定
			// Weapon Data専用で必要なもの

			textItemID.DataBindings.Add(new Binding("Text", TableWeaponDataTable, "WeaponID", true));
			textItemName.DataBindings.Add(new Binding("Text", TableWeaponDataTable, "WeaponName", true));

			numericSPC.DataBindings.Add(new Binding("Value", TableWeaponDataTable, "SPC", true));
			numericATC.DataBindings.Add(new Binding("Value", TableWeaponDataTable, "ATC", true));


			comboEquipItemGroup.DataBindings.Add(new Binding("SelectedValue", TableWeaponDataTable, "Type", true));
			comboAttackItemGroup.DataBindings.Add(new Binding("SelectedValue", TableWeaponDataTable, "AType", true));
			comboTarget.DataBindings.Add(new Binding("SelectedValue", TableWeaponDataTable, "Target", true));
			comboEType.DataBindings.Add(new Binding("SelectedValue", TableWeaponDataTable, "EType", true));

			// 共通設定
			CommonSettings(TableWeaponDataTable, TableElementDataTable);
		}// End Method

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="DataTable">対象のData Table</param>
		/// <param name="TableElementDataTable">Table Element Data Table</param>
		/// <param name="ItemTag">ターゲットのアイテムジャンル</param>
		public void SetDataBindings(DataTable DataTable, __table_elementDataTable TableElementDataTable, string ItemTag) {
			// データバインドの設定
			textItemID.DataBindings.Add(new Binding("Text", DataTable, ItemTag + "ID", true));
			textItemName.DataBindings.Add(new Binding("Text", DataTable, ItemTag + "Name", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			// 以下の要素は要らないため非表示
			labelSPC.Visible = false;
			numericSPC.Visible = false;
			labelATC.Visible = false;
			numericATC.Visible = false;
			labelTarget.Visible = false;
			comboTarget.Visible = false;
			labelEType.Visible = false;
			comboEType.Visible = false;
			labelAttackItemGroup.Visible = false;
			comboAttackItemGroup.Visible = false;
			labelEquipItemGroup.Visible = false;
			comboEquipItemGroup.Visible = false;

			// 共通設定
			CommonSettings(DataTable, TableElementDataTable);
		}// End Method

		/// <summary>
		/// バインド項目を再読み込みします。 
		/// </summary>
		/// <param name="TableElementDataTable">Table Element Data Table</param>
		/// <param name="TableWeaponTypeDataTable">Weapon Type Data Table</param>
		public void ReloadDataTable(__table_elementDataTable TableElementDataTable, __table_weapon_typeDataTable TableWeaponTypeDataTable) {
			comboEquipItemGroup.DataSource = TableWeaponTypeDataTable.Copy();
			comboAttackItemGroup.DataSource = TableWeaponTypeDataTable.Copy();

			comboElement1.DataSource = TableElementDataTable.Copy();
			comboElement2.DataSource = TableElementDataTable.Copy();
		}// End Method

		/// <summary> 
		/// バインド項目を再読み込みします。 
		/// </summary> 
		/// <param name="TableElementDataTable">Table Element Data Table</param>
		public void ReloadDataTable(__table_elementDataTable TableElementDataTable) {
			comboElement1.DataSource = TableElementDataTable.Copy();
			comboElement2.DataSource = TableElementDataTable.Copy();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// 共通するDataTableの割り当てやデザイナーの設定を行います
		/// </summary>
		/// <param name="DataTable">Item Data Table</param>
		/// <param name="TableElementDataTable">Table Element Data Table</param>
		private void CommonSettings(DataTable DataTable, __table_elementDataTable TableElementDataTable) {
			// コンボボックスの設定

			comboElement1.DataSource = TableElementDataTable.Copy();
			comboElement1.DisplayMember = "ElementName";
			comboElement1.ValueMember = "ElementID";

			comboElement2.DataSource = TableElementDataTable.Copy();
			comboElement2.DisplayMember = "ElementName";
			comboElement2.ValueMember = "ElementID";

			//----------------------------------------------------------------------------------------------------
			// データバインドの設定

			textPrice.DataBindings.Add(new Binding("Text", DataTable, "Price", true));
			textInfo.DataBindings.Add(new Binding("Text", DataTable, "Info", true));

			numericPhysicsPower.DataBindings.Add(new Binding("Value", DataTable, "PhysicsPower", true));
			numericMagicPower.DataBindings.Add(new Binding("Value", DataTable, "MagicPower", true));
			numericPhysicsDefence.DataBindings.Add(new Binding("Value", DataTable, "PhysicsDefence", true));
			numericMagicDefence.DataBindings.Add(new Binding("Value", DataTable, "MagicDefence", true));
			numericReductionRate.DataBindings.Add(new Binding("Value", DataTable, "ReductionRate", true));
			numericWT.DataBindings.Add(new Binding("Value", DataTable, "WT", true));
			numericEC.DataBindings.Add(new Binding("Value", DataTable, "EC", true));
			numericSSP.DataBindings.Add(new Binding("Value", DataTable, "SSP", true));
			numericRare.DataBindings.Add(new Binding("Value", DataTable, "Rare", true));

			comboElement1.DataBindings.Add(new Binding("SelectedValue", DataTable, "Element1", true));
			comboElement2.DataBindings.Add(new Binding("SelectedValue", DataTable, "Element2", true));

			checkBuyFlag.DataBindings.Add(new Binding("Checked", DataTable, "Buy", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Priceの入力値の検査。
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">CancelEventArgs</param>
		private void textPrice_Validating(object sender, CancelEventArgs e) {
			if (textPrice.Text == "") {
				textPrice.Text = "0";
			} else {
				// カンマの除去
				textPrice.Text = textPrice.Text.Replace(",", "");
			}// End If
		}// End Method
	}// End Class
}
