//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Area Form
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
	public partial class FormArea : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// DataTable
		private DataTable TableAreaDataTable = new __table_areaDataTable();

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
		/// <param name="TableAreaDataTable">Area Data Table</param>
		/// <param name="TableBattleAreaDataTable">Table Battle Area Data Table</param>
		public FormArea(__table_areaDataTable TableAreaDataTable, __table_battle_areaDataTable TableBattleAreaDataTable) {
			InitializeComponent();

			// 割り当て。編集がリアルタイムに適応されるようになる
			this.TableAreaDataTable = TableAreaDataTable;

			// コンボボックスの設定
			// ……というか、殆どコンボボックスなのだが……
			battleID1DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID1DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID1DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID2DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID2DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID2DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID3DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID3DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID3DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID4DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID4DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID4DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID5DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID5DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID5DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID6DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID6DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID6DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID7DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID7DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID7DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID8DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID8DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID8DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID9DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID9DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID9DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			battleID10DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID10DataGridViewComboBoxColumn.DisplayMember = "BattleAreaName";
			battleID10DataGridViewComboBoxColumn.ValueMember = "BattleAreaID";

			movetoArea1DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea1DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea1DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea2DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea2DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea2DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea3DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea3DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea3DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea4DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea4DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea4DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea5DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea5DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea5DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea6DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea6DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea6DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea7DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea7DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea7DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea8DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea8DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea8DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea9DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea9DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea9DataGridViewComboBoxColumn.ValueMember = "AreaID";

			movetoArea10DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea10DataGridViewComboBoxColumn.DisplayMember = "AreaName";
			movetoArea10DataGridViewComboBoxColumn.ValueMember = "AreaID";
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		/// <summary>
		/// Table Area Data Tableを再読み込みします
		/// </summary>
		/// <param name="TableBattleAreaDataTable">Table Battle Area Data Table</param>
		public void ReloadDataSource(__table_areaDataTable TableAreaDataTable) {
			movetoArea1DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea2DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea3DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea4DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea5DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea6DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea7DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea8DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea9DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
			movetoArea10DataGridViewComboBoxColumn.DataSource = TableAreaDataTable.Copy();
		}

		/// <summary>
		/// Table Battle Area Data Tableを再読み込みします
		/// </summary>
		/// <param name="TableBattleAreaDataTable">Table Battle Area Data Table</param>
		public void ReloadDataSource(__table_battle_areaDataTable TableBattleAreaDataTable) {
			battleID1DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID2DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID3DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID4DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID5DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID6DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID7DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID8DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID9DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
			battleID10DataGridViewComboBoxColumn.DataSource = TableBattleAreaDataTable.Copy();
		}


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
		private void FormArea_Load(object sender, EventArgs e) {
			//----------------------------------------------------------------------------------------------------
			// 共通デザイナー設定

			dataGridViewCellStyleN0.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyleN0.Format = "N0";
			dataGridViewCellStyleN0.NullValue = null;

			dataGridViewCellStyleN2.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyleN2.Format = "N2";
			dataGridViewCellStyleN2.NullValue = null;

			//----------------------------------------------------------------------------------------------------
			// カラムデザイナー設定

			//----------------------------------------------------------------------------------------------------
			// データソースのすり替え

			DataGridViewArea.DataSource = TableAreaDataTable;
			DataGridViewArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			DataGridViewArea.DefaultCellStyle.BackColor = Color.FromArgb(189, 215, 238);
			DataGridViewArea.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		}// End Method

		/// <summary>
		/// フォームを閉じる時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void FormArea_FormClosed(object sender, FormClosedEventArgs e) {
			Dispose();
		}// End Method


		/// <summary>
		/// Data Error 発生時のメッセージや処理
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">Data Grid View Data Error Event Args</param>
		private void DataGridViewArea_DataError(object sender, DataGridViewDataErrorEventArgs e) {
			string er = "Error Info: \n";
			//MessageBox.Show("Error Happened: " + e.Context.ToString());

			if (e.Context.HasFlag(DataGridViewDataErrorContexts.Commit)) {
				er += "Commit Error\n";
			}// End If
			if (e.Context.HasFlag(DataGridViewDataErrorContexts.CurrentCellChange)) {
				er += "Cell Change Error\n";
			}// End If
			if (e.Context.HasFlag(DataGridViewDataErrorContexts.Formatting)) {
				er += "Formatting Error\n";
			}// End If
			if (e.Context.HasFlag(DataGridViewDataErrorContexts.LeaveControl)) {
				er += "Leave Control Error\n";
			}// End If
			if (e.Context.HasFlag(DataGridViewDataErrorContexts.Parsing)) {
				er += "Parsing Error\n";
			}// End If
			if (e.Context.HasFlag(DataGridViewDataErrorContexts.PreferredSize)) {
				er += "Preferred Size Error\n";
			}// End If

			MessageBox.Show(er + (e.RowIndex + 1) + "行 " + (e.ColumnIndex + 1) + "列 " + e.Exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			Debug.WriteLine(er + (e.RowIndex + 1) + "行 " + (e.ColumnIndex + 1) + "列 " + e.Exception);

			if ((e.Exception) is ConstraintException) {
				DataGridView view = (DataGridView)sender;
				view.Rows[e.RowIndex].ErrorText = "an error";
				view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";

				e.ThrowException = false;
			}// End If
		}// End Method
	}// End Class
}
