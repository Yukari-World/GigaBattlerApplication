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
		// Pubilc Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableWeaponBingingSource">Weapon Binding Source</param>
		/// <param name="tableElementBindingSource">Element Binding Source</param>
		/// <param name="tableWeaponTypeBingingSource">Weapon Type Binding Source</param>
		public void LoadDataBindings(BindingSource tableWeaponBingingSource, BindingSource tableWeaponTypeBingingSource) {
			// データ項目の作成

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
			// Binding Sourceの設定

			//----------------------------------------------------------------------------------------------------
			// コンボボックスの設定

			comboElement1.DataSource = elementTable1;
			comboElement1.DisplayMember = "ElementName";
			comboElement1.ValueMember = "ElementID";

			comboElement2.DataSource = elementTable2;
			comboElement2.DisplayMember = "ElementName";
			comboElement2.ValueMember = "ElementID";

			comboEquipItemGroup.DataSource = tableWeaponTypeBingingSource;
			comboEquipItemGroup.DisplayMember = "WeaponTypeName";
			comboEquipItemGroup.ValueMember = "WeaponTypeID";

			comboAttackItemGroup.DataSource = tableWeaponTypeBingingSource;
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

			comboElement1.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "Element1", true));
			comboElement2.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "Element2", true));

			// Weapon Data専用で必要なもの
			comboEquipItemGroup.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "Type", true));
			comboAttackItemGroup.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "AType", true));
			comboTarget.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "Target", true));
			comboEType.DataBindings.Add(new Binding("SelectedValue", tableWeaponBingingSource, "EType", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
		}// End Function

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableBingingSource">Binding Source</param>
		/// <param name="tableElementBindingSource">Element Binding Source</param>
		public void LoadDataBindings(BindingSource tableBingingSource) {
			// コンボボックスの設定

			comboElement1.DataSource = elementTable1;
			comboElement1.DisplayMember = "ElementName";
			comboElement1.ValueMember = "ElementID";

			comboElement2.DataSource = elementTable2;
			comboElement2.DisplayMember = "ElementName";
			comboElement2.ValueMember = "ElementID";

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			// 以下の要素は要らないため非表示
			labelSPC.Visible = false;
			numericSPC.Visible = false;
			labelATC.Visible = false;
			numericATC.Visible = false;
			labelTarget.Visible = false;
			comboTarget.Visible = false;
			labelAttackItemGroup.Visible = false;
			comboAttackItemGroup.Visible = false;
			labelEquipItemGroup.Visible = false;
			comboEquipItemGroup.Visible = false;

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
		}// End Function

		/// <summary> 
		/// バインド項目を再読み込みします。 
		/// </summary> 
		/// <param name="ElementTableAdapter">__table_elementTableAdapter</param> 
		public void ReloadBindings(__table_elementTableAdapter ElementTableAdapter) {
			ElementTableAdapter.Fill(elementTable1);
			ElementTableAdapter.Fill(elementTable2);
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
