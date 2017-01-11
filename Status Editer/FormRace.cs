//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Race Form
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer {
	public partial class FormRace : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// DataTable
		private DataTable RaceDataTable = new __table_raceDataTable();

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
		/// <param name="DataTable">Race Data Table</param>
		public FormRace(__table_raceDataTable DataTable) {
			InitializeComponent();

			// 割り当て。編集がリアルタイムに適応されるようになる
			RaceDataTable = DataTable;
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
		private void FormRace_Load(object sender, EventArgs e) {
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

			hPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			tPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			hPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			aTKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			dEFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			rATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			rDFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			mATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			mDFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			sPDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lUKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			hITDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			eVTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			lvHPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvTPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			lvHPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvATKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvDEFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvRATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvRDFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvMATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvMDFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvSPDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN2;
			lvLUKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			lvHITDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			lvEVTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;
			nextEXPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyleN0;

			//----------------------------------------------------------------------------------------------------
			// データソースのすり替え

			DataGridViewRace.DataSource = RaceDataTable;
			DataGridViewRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			DataGridViewRace.DefaultCellStyle.BackColor = Color.FromArgb(189, 215, 238);
			DataGridViewRace.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247);
		}// End Method

		/// <summary>
		/// フォームを閉じる時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void FormRace_FormClosed(object sender, FormClosedEventArgs e) {
			Dispose();
		}// End Method
	}// End Class
}
