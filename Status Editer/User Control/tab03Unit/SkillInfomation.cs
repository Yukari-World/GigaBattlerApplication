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
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable, __table_skillDataTable TableSkillDataTable) {
			// データバインドの設定
			SkillInfomation1.SetDataBindings(TableUnitDataTable,  TableSkillDataTable, "Skill1");
			SkillInfomation2.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill2");
			SkillInfomation3.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill3");
			SkillInfomation4.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill4");
			SkillInfomation5.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill5");
			SkillInfomation6.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill6");
			SkillInfomation7.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill7");
			SkillInfomation8.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill8");
			SkillInfomation9.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill9");
			SkillInfomation10.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill10");
			SkillInfomation11.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill11");
			SkillInfomation12.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill12");
			SkillInfomation13.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill13");
			SkillInfomation14.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill14");
			SkillInfomation15.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill15");
			SkillInfomation16.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill16");
			SkillInfomation17.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill17");
			SkillInfomation18.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill18");
			SkillInfomation19.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill19");
			SkillInfomation20.SetDataBindings(TableUnitDataTable, TableSkillDataTable, "Skill20");

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method

		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="TableSkillDataTable">__table_skillTableAdapter</param>
		public void ReloadBindings(__table_skillDataTable TableSkillDataTable) {
			SkillInfomation1.ReloadBindings(TableSkillDataTable);
			SkillInfomation2.ReloadBindings(TableSkillDataTable);
			SkillInfomation3.ReloadBindings(TableSkillDataTable);
			SkillInfomation4.ReloadBindings(TableSkillDataTable);
			SkillInfomation5.ReloadBindings(TableSkillDataTable);
			SkillInfomation6.ReloadBindings(TableSkillDataTable);
			SkillInfomation7.ReloadBindings(TableSkillDataTable);
			SkillInfomation8.ReloadBindings(TableSkillDataTable);
			SkillInfomation9.ReloadBindings(TableSkillDataTable);
			SkillInfomation10.ReloadBindings(TableSkillDataTable);
			SkillInfomation11.ReloadBindings(TableSkillDataTable);
			SkillInfomation12.ReloadBindings(TableSkillDataTable);
			SkillInfomation13.ReloadBindings(TableSkillDataTable);
			SkillInfomation14.ReloadBindings(TableSkillDataTable);
			SkillInfomation15.ReloadBindings(TableSkillDataTable);
			SkillInfomation16.ReloadBindings(TableSkillDataTable);
			SkillInfomation17.ReloadBindings(TableSkillDataTable);
			SkillInfomation18.ReloadBindings(TableSkillDataTable);
			SkillInfomation19.ReloadBindings(TableSkillDataTable);
			SkillInfomation20.ReloadBindings(TableSkillDataTable);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
