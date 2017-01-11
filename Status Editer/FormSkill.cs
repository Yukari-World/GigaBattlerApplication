//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Skill Form
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

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
		/// <param name="ElementDataTable">Element Data Table</param>
		public FormSkill(__table_skillDataTable DataTable, __table_elementDataTable ElementDataTable) {
			InitializeComponent();

			// 割り当て。編集がリアルタイムに適応されるようになる
			SkillDataTable = DataTable;

			// コンボボックスの設定
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
			// TODO: このコード行はデータを 'gigaBattlerDataSet.__table_skill' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
			this.___table_skillTableAdapter.Fill(this.gigaBattlerDataSet.@__table_skill);
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
	}// End Class
}
