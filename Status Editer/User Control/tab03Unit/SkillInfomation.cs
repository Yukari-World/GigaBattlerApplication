//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Active Skill Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System.ComponentModel;
using System.Windows.Forms;

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
		// Pubilc Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		/// <param name="SkillAdapter">__table_skillTableAdapter</param>
		public void LoadDataBindings(BindingSource tableUnitBindingSource, __table_skillTableAdapter SkillAdapter) {
			// データバインドの設定
			SkillInfomation1.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill1");
			SkillInfomation2.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill2");
			SkillInfomation3.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill3");
			SkillInfomation4.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill4");
			SkillInfomation5.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill5");
			SkillInfomation6.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill6");
			SkillInfomation7.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill7");
			SkillInfomation8.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill8");
			SkillInfomation9.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill9");
			SkillInfomation10.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill10");
			SkillInfomation11.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill11");
			SkillInfomation12.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill12");
			SkillInfomation13.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill13");
			SkillInfomation14.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill14");
			SkillInfomation15.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill15");
			SkillInfomation16.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill16");
			SkillInfomation17.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill17");
			SkillInfomation18.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill18");
			SkillInfomation19.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill19");
			SkillInfomation20.SetDataBindings(tableUnitBindingSource, SkillAdapter, "Skill20");

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定
			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function

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
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
