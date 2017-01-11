//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Accessory Form
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer {
	public partial class FormAccessory : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// DataTable
		private DataTable AccessoryDataTable = new __table_accessoryDataTable();

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
		/// <param name="DataTable">Accessory Data Table</param>
		/// <param name="ElementDataTable">Element Data Table</param>
		public FormAccessory(__table_accessoryDataTable DataTable, __table_elementDataTable ElementDataTable) {
			InitializeComponent();

			// 割り当て。編集がリアルタイムに適応されるようになる
			AccessoryDataTable = DataTable;

			// コンボボックスの設定
			element1DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element1DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element1DataGridViewComboBoxColumn.DisplayMember = "ElementName";

			element2DataGridViewComboBoxColumn.DataSource = ElementDataTable.Copy();
			element2DataGridViewComboBoxColumn.ValueMember = "ElementID";
			element2DataGridViewComboBoxColumn.DisplayMember = "ElementName";
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
		private void FormAccessory_Load(object sender, EventArgs e) {
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

			physicsPowerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			magicPowerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			physicsDefenceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			magicDefenceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			reductionRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			wTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			eCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			sSPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			sPCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			aTCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			targetDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			rareDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			hPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			tPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			hPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			aTKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			dEFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			rATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			rDFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			mATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			mDFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			sPDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			lUKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			hITDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			eVTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			duabilityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;

			//----------------------------------------------------------------------------------------------------
			// データソースのすり替え

			DataGridViewAccessory.DataSource = AccessoryDataTable;
			DataGridViewAccessory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			DataGridViewAccessory.DefaultCellStyle.BackColor = Color.FromArgb(189, 215, 238);
			DataGridViewAccessory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		}// End Method

		/// <summary>
		/// フォームを閉じる時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void FormAccessory_FormClosed(object sender, FormClosedEventArgs e) {
			Dispose();
		}// End Method
	}// End Class
}
