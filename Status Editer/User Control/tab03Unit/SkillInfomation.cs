﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Active Skill Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System.ComponentModel;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab03Unit {
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
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable) {
			// データバインドの設定
			SkillInfomation1.SetDataBindings(TableUnitDataTable, "Skill1");
			SkillInfomation2.SetDataBindings(TableUnitDataTable, "Skill2");
			SkillInfomation3.SetDataBindings(TableUnitDataTable, "Skill3");
			SkillInfomation4.SetDataBindings(TableUnitDataTable, "Skill4");
			SkillInfomation5.SetDataBindings(TableUnitDataTable, "Skill5");
			SkillInfomation6.SetDataBindings(TableUnitDataTable, "Skill6");
			SkillInfomation7.SetDataBindings(TableUnitDataTable, "Skill7");
			SkillInfomation8.SetDataBindings(TableUnitDataTable, "Skill8");
			SkillInfomation9.SetDataBindings(TableUnitDataTable, "Skill9");
			SkillInfomation10.SetDataBindings(TableUnitDataTable, "Skill10");
			SkillInfomation11.SetDataBindings(TableUnitDataTable, "Skill11");
			SkillInfomation12.SetDataBindings(TableUnitDataTable, "Skill12");
			SkillInfomation13.SetDataBindings(TableUnitDataTable, "Skill13");
			SkillInfomation14.SetDataBindings(TableUnitDataTable, "Skill14");
			SkillInfomation15.SetDataBindings(TableUnitDataTable, "Skill15");
			SkillInfomation16.SetDataBindings(TableUnitDataTable, "Skill16");
			SkillInfomation17.SetDataBindings(TableUnitDataTable, "Skill17");
			SkillInfomation18.SetDataBindings(TableUnitDataTable, "Skill18");
			SkillInfomation19.SetDataBindings(TableUnitDataTable, "Skill19");
			SkillInfomation20.SetDataBindings(TableUnitDataTable, "Skill20");

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="SkillAdapter">__table_skillTableAdapter</param>
		public void ReloadBindings(__table_skillTableAdapter SkillAdapter) {
			SkillInfomation1.ReloadBindings(SkillAdapter);
			SkillInfomation2.ReloadBindings(SkillAdapter);
			SkillInfomation3.ReloadBindings(SkillAdapter);
			SkillInfomation4.ReloadBindings(SkillAdapter);
			SkillInfomation5.ReloadBindings(SkillAdapter);
			SkillInfomation6.ReloadBindings(SkillAdapter);
			SkillInfomation7.ReloadBindings(SkillAdapter);
			SkillInfomation8.ReloadBindings(SkillAdapter);
			SkillInfomation9.ReloadBindings(SkillAdapter);
			SkillInfomation10.ReloadBindings(SkillAdapter);
			SkillInfomation11.ReloadBindings(SkillAdapter);
			SkillInfomation12.ReloadBindings(SkillAdapter);
			SkillInfomation13.ReloadBindings(SkillAdapter);
			SkillInfomation14.ReloadBindings(SkillAdapter);
			SkillInfomation15.ReloadBindings(SkillAdapter);
			SkillInfomation16.ReloadBindings(SkillAdapter);
			SkillInfomation17.ReloadBindings(SkillAdapter);
			SkillInfomation18.ReloadBindings(SkillAdapter);
			SkillInfomation19.ReloadBindings(SkillAdapter);
			SkillInfomation20.ReloadBindings(SkillAdapter);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
