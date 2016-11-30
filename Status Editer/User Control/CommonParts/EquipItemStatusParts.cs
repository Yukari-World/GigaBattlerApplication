﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Equip Item Status Parts
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

namespace Status_Editer.User_Control.CommonParts {
	[ToolboxItem(true)]
	public partial class EquipItemStatusParts : UserControl {
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
		public EquipItemStatusParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableBindingSource">BindingSource</param>
		public void LoadDataBindings(BindingSource tableBindingSource) {
			// データバインドの設定
			itemStatusHP.SetDataBindings(tableBindingSource, "HP");
			itemStatusTP.SetDataBindings(tableBindingSource, "TP");
			itemStatusMeleeATK.SetDataBindings(tableBindingSource, "ATK");
			itemStatusMeleeDEF.SetDataBindings(tableBindingSource, "DEF");
			itemStatusRangeATK.SetDataBindings(tableBindingSource, "RAT");
			itemStatusRangeDEF.SetDataBindings(tableBindingSource, "RDF");
			itemStatusMagicATK.SetDataBindings(tableBindingSource, "MAT");
			itemStatusMagicDEF.SetDataBindings(tableBindingSource, "MDF");
			itemStatusSPD.SetDataBindings(tableBindingSource, "SPD");
			itemStatusLuck.SetDataBindings(tableBindingSource, "LUK");
			itemStatusHIT.SetDataBindings(tableBindingSource, "HIT");
			itemStatusEVT.SetDataBindings(tableBindingSource, "EVT");


			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
