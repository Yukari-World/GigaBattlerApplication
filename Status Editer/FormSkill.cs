//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Skill Form
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static CommonLibrary.GigaBattlerDataSet;

namespace Status_Editer {
	public partial class FormSkill : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// DataTable
		private DataTable SkillDataTable = new __table_skillDataTable();

		// DataGridViewCellStyle
		private DataGridViewCellStyle dataGridViewCellStyleN0 = new DataGridViewCellStyle();
		private DataGridViewCellStyle dataGridViewCellStyleN2 = new DataGridViewCellStyle();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		/// <param name="DataTable">Shield Data Table</param>
		/// <param name="TableWeaponTypeDataTable">Table Weapon Type Data Table</param>
		/// <param name="ElementDataTable">Element Data Table</param>
		public FormSkill(__table_skillDataTable DataTable, __table_weapon_typeDataTable TableWeaponTypeDataTable, __table_elementDataTable ElementDataTable) {
			InitializeComponent();

			// 割り当て。編集がリアルタイムに適応されるようになる
			SkillDataTable = DataTable;

			// コンボボックスの設定

			wTypeDataGridViewComboBoxColumn.DataSource = TableWeaponTypeDataTable.Copy();
			wTypeDataGridViewComboBoxColumn.DisplayMember = "WeaponTypeName";
			wTypeDataGridViewComboBoxColumn.ValueMember = "WeaponTypeID";

			element1DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element1DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element1DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element2DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element2DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element2DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element3DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element3DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element3DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element4DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element4DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element4DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element5DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element5DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element5DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element6DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element6DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element6DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element7DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element7DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element7DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element8DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element8DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element8DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element9DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element9DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element9DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element10DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element10DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element10DataGridViewComboBoxColumn.DisplayMember = "ElementName";
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void FormSkill_Load(object sender, EventArgs e) {
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

			TargetDataTable.Columns.Add("DataID", Type.GetType("System.SByte"));
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
			 // 共通デザイナー設定

			dataGridViewCellStyleN0.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyleN0.Format = "N0";
			dataGridViewCellStyleN0.NullValue = null;

			dataGridViewCellStyleN2.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyleN2.Format = "N2";
			dataGridViewCellStyleN2.NullValue = null;

			//----------------------------------------------------------------------------------------------------
			// コンボボックスの設定

			airDataGridViewComboBoxColumn.DataSource = AirDataTable;
			airDataGridViewComboBoxColumn.DisplayMember = "DataName";
			airDataGridViewComboBoxColumn.ValueMember = "DataID";

			useWeaponDataGridViewComboBoxColumn.DataSource = UseWeaponDataTable;
			useWeaponDataGridViewComboBoxColumn.DisplayMember = "DataName";
			useWeaponDataGridViewComboBoxColumn.ValueMember = "DataID";
			
			targetDataGridViewComboBoxColumn.DataSource = TargetDataTable;
			targetDataGridViewComboBoxColumn.DisplayMember = "DataName";
			targetDataGridViewComboBoxColumn.ValueMember = "DataID";

			typeDataGridViewComboBoxColumn.DataSource = TypeDataTable;
			typeDataGridViewComboBoxColumn.DisplayMember = "DataName";
			typeDataGridViewComboBoxColumn.ValueMember = "DataID";

			//----------------------------------------------------------------------------------------------------
			// カラムデザイナー設定

			//----------------------------------------------------------------------------------------------------
			// データソースのすり替え

			DataGridViewSkill.DataSource = SkillDataTable;
			DataGridViewSkill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			DataGridViewSkill.DefaultCellStyle.BackColor = Color.FromArgb(189, 215, 238);
			DataGridViewSkill.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		}// End Method

		/// <summary>
		/// フォームを閉じる時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void FormSkill_FormClosed(object sender, FormClosedEventArgs e) {
			Dispose();
		}// End Method

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">Data Grid View Data Error Event Args</param>
		private void DataGridViewSkill_DataError(object sender, DataGridViewDataErrorEventArgs e) {
			MessageBox.Show("Error happened " + e.Context.ToString());

			if (e.Context == DataGridViewDataErrorContexts.Commit) {
				MessageBox.Show("Commit error");
			}
			if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange) {
				MessageBox.Show("Cell change");
			}
			if (e.Context == DataGridViewDataErrorContexts.Parsing) {
				MessageBox.Show("parsing error");
			}
			if (e.Context == DataGridViewDataErrorContexts.LeaveControl) {
				MessageBox.Show("leave control error");
			}

			if ((e.Exception) is ConstraintException) {
				DataGridView view = (DataGridView)sender;
				view.Rows[e.RowIndex].ErrorText = "an error";
				view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";

				e.ThrowException = false;
			}
		}// End Method
	}// End Class
}
