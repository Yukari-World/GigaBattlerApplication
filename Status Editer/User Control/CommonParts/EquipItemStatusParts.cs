﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Equip Item Status Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using System.Data;
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
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="ItemDataTable">Item Data Table</param>
		public void SetDataBindings(DataTable ItemDataTable) {
			// データバインドの設定
			StatusGraphHP.SetDataBindings(ItemDataTable, "HP");
			StatusGraphTP.SetDataBindings(ItemDataTable, "TP");
			StatusGraphMeleeATK.SetDataBindings(ItemDataTable, "ATK");
			StatusGraphMeleeDEF.SetDataBindings(ItemDataTable, "DEF");
			StatusGraphRangeATK.SetDataBindings(ItemDataTable, "RAT");
			StatusGraphRangeDEF.SetDataBindings(ItemDataTable, "RDF");
			StatusGraphMagicATK.SetDataBindings(ItemDataTable, "MAT");
			StatusGraphMagicDEF.SetDataBindings(ItemDataTable, "MDF");
			StatusGraphSPD.SetDataBindings(ItemDataTable, "SPD");
			StatusGraphLuck.SetDataBindings(ItemDataTable, "LUK");
			StatusGraphHIT.SetDataBindings(ItemDataTable, "HIT");
			StatusGraphEVT.SetDataBindings(ItemDataTable, "EVT");

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
