﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Status Infomation Level Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit.Parts {
	[ToolboxItem(true)]
	[Description("Status InfomationのLevel用フォームです")]
	public partial class StatusInfoLevelParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// [R/W]最小レベルを指定します
		/// </summary>
		[Description("[R/W]最小レベルを指定します")]
		public decimal numMinLevel {
			get { return numericMinLevel.Value; }
			set { numericMinLevel.Value = value; }
		}// End Property

		/// <summary>
		/// [R/W]最大レベルを指定します
		/// </summary>
		[Description("[R/W]最大レベルを指定します")]
		public decimal numMaxLevel {
			get { return numericMaxLevel.Value; }
			set { numericMaxLevel.Value = value; }
		}// End Property


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public StatusInfoLevelParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		public void SetDataBindings(BindingSource tableUnitBindingSource) {
			numericReqLv.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Req Lv", true));
			numericMinLevel.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Min Lv", true));
			numericMaxLevel.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Max Lv", true));
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
