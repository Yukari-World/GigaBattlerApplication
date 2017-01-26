//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Skill Infomation Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static CommonLibrary.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab14Skill {
	[ToolboxItem(true)]
	public partial class SkillInfomation : UserControl {
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
		public SkillInfomation() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableSkillDataTable">Skill Data Table</param>
		/// <param name="TableWeaponTypeDataTable">Weapon Type Data Table</param>
		public void SetDataBindings(__table_skillDataTable TableSkillDataTable, __table_weapon_typeDataTable TableWeaponTypeDataTable) {
			// データ項目の作成
			// データ項目が少なく、わざわざデータベース化する必要のない項目

			//--------------------------------------------------
			// Air
			DataTable AirDataTable = new DataTable();

			AirDataTable.Columns.Add("DataID", Type.GetType("System.Byte"));
			AirDataTable.Columns.Add("DataName", Type.GetType("System.String"));

			// 項目配列。Listでもよかったかも...?
			byte[] AirDataValue = new byte[] { 0, 1, 2 };
			string[] AirDataName = new string[] { "無効", "有効", "特効" };

			// 項目の構築
			for (int i = 0; i < AirDataValue.Length; i++) {
				DataRow row = AirDataTable.NewRow();

				// カラムにデータを割り当てる
				row["DataID"] = AirDataValue[i];
				row["DataName"] = AirDataName[i];

				// Debug文
				Debug.WriteLine("Air Data Table Row Data:" + AirDataValue[i] + "\t" + AirDataName[i] + ";");

				// 追加する
				AirDataTable.Rows.Add(row);
			}// End Loop

			//--------------------------------------------------
			// Use Weapon
			DataTable UseWeaponDataTable = new DataTable();

			UseWeaponDataTable.Columns.Add("DataID", Type.GetType("System.Byte"));
			UseWeaponDataTable.Columns.Add("DataName", Type.GetType("System.String"));

			// 項目配列。Listでもよかったかも...?
			byte[] UseWeaponDataValue = new byte[] { 0, 1 };
			string[] UseWeaponDataName = new string[] { "無効", "有効" };

			// 項目の構築
			for (int i = 0; i < UseWeaponDataValue.Length; i++) {
				DataRow row = UseWeaponDataTable.NewRow();

				// カラムにデータを割り当てる
				row["DataID"] = UseWeaponDataValue[i];
				row["DataName"] = UseWeaponDataName[i];

				// Debug文
				Debug.WriteLine("UseWeapon Data Table Row Data:" + UseWeaponDataValue[i] + "\t" + UseWeaponDataName[i] + ";");

				// 追加する
				UseWeaponDataTable.Rows.Add(row);
			}// End Loop

			//--------------------------------------------------
			// Target
			DataTable TargetDataTable = new DataTable();

			TargetDataTable.Columns.Add("DataID", Type.GetType("System.Byte"));
			TargetDataTable.Columns.Add("DataName", Type.GetType("System.String"));

			// 項目配列。Listでもよかったかも...?
			byte[] TargetDataValue = new byte[] { 0, 1, 2, 3, 4, 5 };
			string[] TargetDataName = new string[] { "敵単体", "敵全体", "全体", "味方単体", "味方全体", "敵ランダム単体" };

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

			//--------------------------------------------------
			// Type
			DataTable TypeDataTable = new DataTable();

			TypeDataTable.Columns.Add("DataID", Type.GetType("System.SByte"));
			TypeDataTable.Columns.Add("DataName", Type.GetType("System.String"));

			// 項目配列。Listでもよかったかも...?
			// 内容を覚えていないため、未確定
			sbyte[] TypeDataValue = new sbyte[] { -1, 0, 1, 2, 3, 4, 5, 6 };
			string[] TypeDataName = new string[] { "*使用不可*", "近接", "間接", "魔法", "不明", "不明", "不明", "回復" };

			// 項目の構築
			for (int i = 0; i < TypeDataValue.Length; i++) {
				DataRow row = TypeDataTable.NewRow();

				// カラムにデータを割り当てる
				row["DataID"] = TypeDataValue[i];
				row["DataName"] = TypeDataName[i];

				// Debug文
				Debug.WriteLine("Type Data Table Row Data:" + TypeDataValue[i] + "\t" + TypeDataName[i] + ";");

				// 追加する
				TypeDataTable.Rows.Add(row);
			}// End Loop

			//----------------------------------------------------------------------------------------------------
			// コンボボックスの設定

			comboWeaponType.DataSource = TableWeaponTypeDataTable.Copy();
			comboWeaponType.DisplayMember = "WeaponTypeName";
			comboWeaponType.ValueMember = "WeaponTypeID";

			comboWeaponEffect.DataSource = UseWeaponDataTable;
			comboWeaponEffect.DisplayMember = "DataName";
			comboWeaponEffect.ValueMember = "DataID";

			comboAir.DataSource = AirDataTable;
			comboAir.DisplayMember = "DataName";
			comboAir.ValueMember = "DataID";

			comboTarget.DataSource = TargetDataTable;
			comboTarget.DisplayMember = "DataName";
			comboTarget.ValueMember = "DataID";

			comboType.DataSource = TypeDataTable;
			comboType.DisplayMember = "DataName";
			comboType.ValueMember = "DataID";

			//----------------------------------------------------------------------------------------------------
			// データバインドの設定

			textSkillID.DataBindings.Add(new Binding("Text", TableSkillDataTable, "SkillID", true));
			textSkillName.DataBindings.Add(new Binding("Text", TableSkillDataTable, "SkillName", true));

			numericPercent.DataBindings.Add(new Binding("Value", TableSkillDataTable, "Percent", true));
			numericFirst.DataBindings.Add(new Binding("Value", TableSkillDataTable, "First", true));
			numericSPCost.DataBindings.Add(new Binding("Value", TableSkillDataTable, "SPCost", true));
			numericTPCost.DataBindings.Add(new Binding("Value", TableSkillDataTable, "TPCost", true));
			numericATCount.DataBindings.Add(new Binding("Value", TableSkillDataTable, "ATCount", true));
			numericHit.DataBindings.Add(new Binding("Value", TableSkillDataTable, "SHit", true));
			numericCritical.DataBindings.Add(new Binding("Value", TableSkillDataTable, "Critical", true));

			comboWeaponType.DataBindings.Add(new Binding("SelectedValue", TableSkillDataTable, "WType", true));
			comboWeaponEffect.DataBindings.Add(new Binding("SelectedValue", TableSkillDataTable, "UseWeapon", true));
			comboAir.DataBindings.Add(new Binding("SelectedValue", TableSkillDataTable, "Air", true));
			comboTarget.DataBindings.Add(new Binding("SelectedValue", TableSkillDataTable, "Target", true));
			comboType.DataBindings.Add(new Binding("SelectedValue", TableSkillDataTable, "Type", true));

			textInfo.DataBindings.Add(new Binding("Text", TableSkillDataTable, "Info", true));

			PowerGraph.SetDataBindings(TableSkillDataTable);

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
		}// End Method

		/// <summary>
		/// バインド項目を再読み込みします。 
		/// </summary>
		/// <param name="TableElementDataTable">Table Element Data Table</param>
		/// <param name="TableWeaponTypeDataTable">Weapon Type Data Table</param>
		public void ReloadDataTable(__table_weapon_typeDataTable TableWeaponTypeDataTable) {
			comboWeaponType.DataSource = TableWeaponTypeDataTable.Copy();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
