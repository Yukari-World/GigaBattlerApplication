﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Race Status Basic Parts
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

namespace Status_Editer.User_Control.tab05Race {
	[ToolboxItem(true)]
	public partial class RaceInfomation : ZUserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プロパティ
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public RaceInfomation() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableRaceBindingSource">BindingSource</param>
		public void LoadDataBindings(BindingSource tableRaceBindingSource) {
			// データバインドの設定
			raceStatusHP.SetDataBindings(tableRaceBindingSource, "HP");
			raceStatusTP.SetDataBindings(tableRaceBindingSource, "TP");
			raceStatusMeleeATK.SetDataBindings(tableRaceBindingSource, "ATK");
			raceStatusMeleeDEF.SetDataBindings(tableRaceBindingSource, "DEF");
			raceStatusRangeATK.SetDataBindings(tableRaceBindingSource, "RAT");
			raceStatusRangeDEF.SetDataBindings(tableRaceBindingSource, "RDF");
			raceStatusMagicATK.SetDataBindings(tableRaceBindingSource, "MAT");
			raceStatusMagicDEF.SetDataBindings(tableRaceBindingSource, "MDF");
			raceStatusSPD.SetDataBindings(tableRaceBindingSource, "SPD");
			raceStatusLuck.SetDataBindings(tableRaceBindingSource, "LUK");
			raceStatusHIT.SetDataBindings(tableRaceBindingSource, "HIT");
			raceStatusEVT.SetDataBindings(tableRaceBindingSource, "EVT");
			//NextEXP

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
