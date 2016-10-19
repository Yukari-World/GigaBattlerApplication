//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// ActiveSkillInfomation
//
// Edited By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;
using Status_Editer.GigaBattlerDataSetTableAdapters;

namespace Status_Editer.User_Control.tabMonster {
	public partial class ActiveSkillInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public ActiveSkillInfomation() {
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
		public void LoadDataBindings(BindingSource tablemonsterBindingSource, __table_skillTableAdapter SkillAdapter) {
			SkillInfomation1.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill1");
			SkillInfomation2.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill2");
			SkillInfomation3.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill3");
			SkillInfomation4.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill4");
			SkillInfomation5.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill5");
			SkillInfomation6.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill6");
			SkillInfomation7.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill7");
			SkillInfomation8.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill8");
			SkillInfomation9.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill9");
			SkillInfomation10.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill10");
			SkillInfomation11.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill11");
			SkillInfomation12.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill12");
			SkillInfomation13.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill13");
			SkillInfomation14.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill14");
			SkillInfomation15.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill15");
			SkillInfomation16.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill16");
			SkillInfomation17.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill17");
			SkillInfomation18.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill18");
			SkillInfomation19.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill19");
			SkillInfomation20.SetDataBindings(tablemonsterBindingSource, SkillAdapter, "Skill20");

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定
			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}

		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="SkillAdapter">>__table_skillTableAdapter</param>
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
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}
}
