﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Skill Element Infomation Parts
//
// Programed By Yukari-World
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
using static CommonLibrary.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab14Skill.Parts {
	[ToolboxItem(true)]
	public partial class ElementSelectParts : UserControl {
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
		public ElementSelectParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="SkillDataTable">Skill Data Table</param>
		/// <param name="TableElementDataTable">Table Element Data Table</param>
		/// <param name="bindtag">Skill Number</param>
		public void SetDataBindings(__table_skillDataTable SkillDataTable, __table_elementDataTable TableElementDataTable, string bindtag) {
			// データバインドの設定
			comboElement.DataBindings.Add(new Binding("SelectedValue", SkillDataTable, "Element" + bindtag, true));

			//----------------------------------------------------------------------------------------------------
			// コンボボックスの設定

			comboElement.DataSource = TableElementDataTable.Copy();
			comboElement.DisplayMember = "ElementName";
			comboElement.ValueMember = "ElementID";
		}// End Method

		 /// <summary> 
		 /// バインド項目を再読み込みします。 
		 /// </summary> 
		 /// <param name="TableElementDataTable">Table Element Data Table</param>
		public void ReloadDataTable(__table_elementDataTable TableElementDataTable) {
			comboElement.DataSource = TableElementDataTable.Copy();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
