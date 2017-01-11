﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Skill Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System.ComponentModel;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab03Unit.Parts {
	[ToolboxItem(true)]
	public partial class SkillInfoParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// バインド
		private __table_skillDataTable SkillTable = new __table_skillDataTable();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// [R/W]グループラベルのテキストを設定します。
		/// </summary>
		public string labelText {
			get { return groupSkill.Text; }
			set { groupSkill.Text = value; }
		}// End Property


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public SkillInfoParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		/// <param name="TableSkillDataTable">Skill Data Table</param>
		/// <param name="bindTag">string</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_skillDataTable TableSkillDataTable, string bindTag) {
			// データバインドの設定
			// ここでは「Skill*」が入る
			comboSkill.DataBindings.Add(new Binding("SelectedValue", TableUnitDataTable, bindTag, true));

			// スキルの説明を追加
			labelSkilleffect.DataBindings.Add(new Binding("Text", TableSkillDataTable, "Info", true));

			// バインド項目の設定
			comboSkill.DataSource = TableSkillDataTable.Copy();
			comboSkill.DisplayMember = "SkillName";
			comboSkill.ValueMember = "SkillID";
		}// End Method

		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="TableSkillDataTable">Skill Data Table</param>
		public void ReloadBindings(__table_skillDataTable TableSkillDataTable) {
			comboSkill.DataSource = TableSkillDataTable.Copy();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// テキスト項目が更新された時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void labelSkilleffect_TextChanged(object sender, System.EventArgs e) {
			// 表示しきれない場合の対策
			toolTipInfo.SetToolTip(labelSkilleffect, labelSkilleffect.Text);
		}// End Method
	}// End Class
}
