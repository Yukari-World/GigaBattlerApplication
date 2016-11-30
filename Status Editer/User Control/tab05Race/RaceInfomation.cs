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
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab05Race {
	[ToolboxItem(true)]
	public partial class RaceInfomation : ZUserControl {
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
		public RaceInfomation() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableRaceDataTable">Race Data Table</param>
		public void SetDataBindings(__table_raceDataTable TableRaceDataTable) {
			// データバインドの設定
			raceStatusHP.SetDataBindings(TableRaceDataTable, "HP");
			raceStatusTP.SetDataBindings(TableRaceDataTable, "TP");
			raceStatusMeleeATK.SetDataBindings(TableRaceDataTable, "ATK");
			raceStatusMeleeDEF.SetDataBindings(TableRaceDataTable, "DEF");
			raceStatusRangeATK.SetDataBindings(TableRaceDataTable, "RAT");
			raceStatusRangeDEF.SetDataBindings(TableRaceDataTable, "RDF");
			raceStatusMagicATK.SetDataBindings(TableRaceDataTable, "MAT");
			raceStatusMagicDEF.SetDataBindings(TableRaceDataTable, "MDF");
			raceStatusSPD.SetDataBindings(TableRaceDataTable, "SPD");
			raceStatusLuck.SetDataBindings(TableRaceDataTable, "LUK");
			raceStatusHIT.SetDataBindings(TableRaceDataTable, "HIT");
			raceStatusEVT.SetDataBindings(TableRaceDataTable, "EVT");
			//NextEXP

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
