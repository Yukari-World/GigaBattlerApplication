﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// TotalUnitInfomation
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

namespace Status_Editer.User_Control.tab03Unit {
	public partial class TotalUnitInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		private NumericUpDown NumericReqLv = new NumericUpDown();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public TotalUnitInfomation() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableMonsterBindingSource">BindingSource</param>
		public void LoadDataBindings(BindingSource tableMonsterBindingSource, StatusCalc StatusCalc) {
			((ISupportInitialize)(NumericReqLv)).BeginInit();
			NumericReqLv.Name = "NumericReqLv";
			NumericReqLv.ValueChanged += new EventHandler(NumericReqLv_ValueChanged);
			NumericReqLv.BindingContextChanged += new EventHandler(NumericReqLv_ValueChanged);

			NumericReqLv = StatusCalc.NumericReqLv;

			labelName.DataBindings.Add(new Binding("Text", tableMonsterBindingSource, "MonsterName", true));
			labelUnitType.DataBindings.Add(new Binding("Text", tableMonsterBindingSource, "Race", true));
			//NumericReqLv.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "Req Lv", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定
			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// コントロール読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void TotalUnitInfomation_Load(object sender, EventArgs e) {
		}

		//----------------------------------------------------------------------------------------------------
		// Hidden
		/// <summary>
		/// 値を書式化します
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void NumericReqLv_ValueChanged(object sender, EventArgs e) {
			labelReqLv.Text = NumericReqLv.Value.ToString("#,#0");
		}
	}
}
