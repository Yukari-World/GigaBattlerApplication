﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// SkillInfomation
//
// Edited By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tabMonster.Parts {
	public partial class SkillInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// バインド
		private __table_skillDataTable SkillTable = new __table_skillDataTable();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// グループラベルのテキストを設定します。
		/// </summary>
		public string labelText {
			get { return groupSkill.Text; }
			set { groupSkill.Text = value; }
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public SkillInfomation() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tablemonsterBindingSource">BindingSource</param>
		/// <param name="SkillAdapter">__table_skillTableAdapter</param>
		/// <param name="bindTag">string</param>
		public void SetDataBindings(BindingSource tablemonsterBindingSource, __table_skillTableAdapter SkillAdapter, string bindTag) {
			SkillAdapter.Fill(SkillTable);

			// データバインドの設定
			// ここでは「Skill*」が入る
			comboSkill.DataBindings.Add(new Binding("SelectedValue", tablemonsterBindingSource, bindTag, true));

			// バインド項目の設定
			comboSkill.DataSource = SkillTable;
			comboSkill.DisplayMember = "SkillName";
			comboSkill.ValueMember = "SkillID";
		}

		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="SkillAdapter">__table_skillTableAdapter</param>
		public void ReloadBindings(__table_skillTableAdapter SkillAdapter) {
			SkillAdapter.Fill(SkillTable);
		}

		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}
}
