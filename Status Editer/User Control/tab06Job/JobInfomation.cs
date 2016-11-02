﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Job Infomation
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

namespace Status_Editer.User_Control.tab06Job {
	public partial class JobInfomation : ZUserControl {
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
		public JobInfomation() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableJobBindingSource">BindingSource</param>
		public void LoadDataBindings(BindingSource tableJobBindingSource) {
			// データバインドの設定
			jobStatusHP.SetDataBindings(tableJobBindingSource, "HP");
			jobStatusTP.SetDataBindings(tableJobBindingSource, "TP");
			jobStatusMeleeATK.SetDataBindings(tableJobBindingSource, "ATK");
			jobStatusMeleeDEF.SetDataBindings(tableJobBindingSource, "DEF");
			jobStatusRangeATK.SetDataBindings(tableJobBindingSource, "RAT");
			jobStatusRangeDEF.SetDataBindings(tableJobBindingSource, "RDF");
			jobStatusMagicATK.SetDataBindings(tableJobBindingSource, "MAT");
			jobStatusMagicDEF.SetDataBindings(tableJobBindingSource, "MDF");
			jobStatusSPD.SetDataBindings(tableJobBindingSource, "SPD");
			jobStatusLuck.SetDataBindings(tableJobBindingSource, "LUK");
			jobStatusHIT.SetDataBindings(tableJobBindingSource, "HIT");
			jobStatusEVT.SetDataBindings(tableJobBindingSource, "EVT");

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
	}
}
