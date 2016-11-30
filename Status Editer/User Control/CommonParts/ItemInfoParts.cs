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

		// Data Table
		private __table_weapon_typeDataTable weaponType1 = new __table_weapon_typeDataTable();
		private __table_weapon_typeDataTable weaponType2 = new __table_weapon_typeDataTable();

		private __table_elementDataTable elementTable1 = new __table_elementDataTable();
		private __table_elementDataTable elementTable2 = new __table_elementDataTable();


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
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableWeaponBingingSource">Weapon Binding Source</param>
		public void LoadDataBindings(BindingSource tableWeaponBingingSource) {
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

			comboEquipItemGroup.DataSource = weaponType1;
			comboEquipItemGroup.DisplayMember = "WeaponTypeName";
			comboEquipItemGroup.ValueMember = "WeaponTypeID";

			comboAttackItemGroup.DataSource = weaponType2;
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

			textItemID.DataBindings.Add(new Binding("Text", tableWeaponBingingSource, "WeaponID", true));
			textItemName.DataBindings.Add(new Binding("Text", tableWeaponBingingSource, "WeaponName", true));

			numericSPC.DataBindings.Add(new Binding("Value", tableWeaponBingingSource, "SPC", true));
			numericATC.DataBindings.Add(new Binding("Value", tableWeaponBingingSource, "ATC", true));


			comboEquipItemGroup.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "Type", true));
			comboAttackItemGroup.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "AType", true));
			comboTarget.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "Target", true));
			comboEType.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "EType", true));

			// 共通設定
			CommonSettings(tableWeaponBingingSource);
		}// End Method

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableBingingSource">Binding Source</param>
		/// <param name="bindtag">ターゲットのアイテムジャンル</param>
		public void LoadDataBindings(BindingSource tableBingingSource, string bindtag) {
			// データバインドの設定
			textItemID.DataBindings.Add(new Binding("Text", tableBingingSource, bindtag + "ID", true));
			textItemName.DataBindings.Add(new Binding("Text", tableBingingSource, bindtag + "Name", true));

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
			CommonSettings(tableBingingSource);
		}// End Method

		/// <summary>
		/// バインド項目を再読み込みします。 
		/// </summary>
		/// <param name="ElementTableAdapter">__table_elementTableAdapter</param>
		/// <param name="WeaponTypeTableAdapter">__table_weapon_typeTableAdapter</param>
		public void ReloadBindings(__table_elementTableAdapter ElementTableAdapter, __table_weapon_typeTableAdapter WeaponTypeTableAdapter) {
			ElementTableAdapter.Fill(elementTable1);
			ElementTableAdapter.Fill(elementTable2);
			WeaponTypeTableAdapter.Fill(weaponType1);
			WeaponTypeTableAdapter.Fill(weaponType2);
		}// End Method

		/// <summary> 
		/// バインド項目を再読み込みします。 
		/// </summary> 
		/// <param name="ElementTableAdapter">__table_elementTableAdapter</param>
		public void ReloadBindings(__table_elementTableAdapter ElementTableAdapter) {
			ElementTableAdapter.Fill(elementTable1);
			ElementTableAdapter.Fill(elementTable2);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// 共通するBinding Sourceの割り当てやデザイナーの設定を行います
		/// </summary>
		/// <param name="DataBindingSource">DatBindingSource</param>
		private void CommonSettings(BindingSource DataBindingSource) {
			// コンボボックスの設定

			comboElement1.DataSource = elementTable1;
			comboElement1.DisplayMember = "ElementName";
			comboElement1.ValueMember = "ElementID";

			comboElement2.DataSource = elementTable2;
			comboElement2.DisplayMember = "ElementName";
			comboElement2.ValueMember = "ElementID";

			//----------------------------------------------------------------------------------------------------
			// データバインドの設定

			textPrice.DataBindings.Add(new Binding("Text", DataBindingSource, "Price", true));
			textInfo.DataBindings.Add(new Binding("Text", DataBindingSource, "Info", true));

			numericPhysicsPower.DataBindings.Add(new Binding("Value", DataBindingSource, "PhysicsPower", true));
			numericMagicPower.DataBindings.Add(new Binding("Value", DataBindingSource, "MagicPower", true));
			numericPhysicsDefence.DataBindings.Add(new Binding("Value", DataBindingSource, "PhysicsDefence", true));
			numericMagicDefence.DataBindings.Add(new Binding("Value", DataBindingSource, "MagicDefence", true));
			numericReductionRate.DataBindings.Add(new Binding("Value", DataBindingSource, "ReductionRate", true));
			numericWT.DataBindings.Add(new Binding("Value", DataBindingSource, "WT", true));
			numericEC.DataBindings.Add(new Binding("Value", DataBindingSource, "EC", true));
			numericSSP.DataBindings.Add(new Binding("Value", DataBindingSource, "SSP", true));
			numericRare.DataBindings.Add(new Binding("Value", DataBindingSource, "Rare", true));

			comboElement1.DataBindings.Add(new Binding("SelectedValue", DataBindingSource, "Element1", true));
			comboElement2.DataBindings.Add(new Binding("SelectedValue", DataBindingSource, "Element2", true));

			checkBuyFlag.DataBindings.Add(new Binding("Checked", DataBindingSource, "Buy", true));

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
