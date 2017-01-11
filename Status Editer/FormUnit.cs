//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Unit Form
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer {
	public partial class FormUnit : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// DataTable
		private DataTable UnitDataTable = new __table_unitDataTable();

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
		/// <param name="DataTable">Unit Data Table</param>
		/// <param name="TypeDataTable">Weapon Type Data Table</param>
		public FormUnit(__table_unitDataTable DataTable, __table_weapon_typeDataTable TypeDataTable) {
			InitializeComponent();

			// 割り当て。編集がリアルタイムに適応されるようになる
			UnitDataTable = DataTable;

			// コンボボックスの設定
			typeDataGridViewComboBoxColumn.DataSource = TypeDataTable;
			typeDataGridViewComboBoxColumn.ValueMember = "WeaponTypeID";
			typeDataGridViewComboBoxColumn.DisplayMember = "WeaponTypeName";
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
		private void FormUnit_Load(object sender, EventArgs e) {
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

			reqLvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			minLvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			maxLvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			startTPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			maxTPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			hPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;

			//----------------------------------------------------------------------------------------------------
			// データソースのすり替え

			DataGridViewUnit.DataSource = UnitDataTable;
			DataGridViewUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			DataGridViewUnit.DefaultCellStyle.BackColor = Color.FromArgb(189, 215, 238);
			DataGridViewUnit.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		}// End Method

		/// <summary>
		/// フォームを閉じる時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void FormUnit_FormClosed(object sender, FormClosedEventArgs e) {
			Dispose();
		}// End Method
	}// End Class
}
