﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Unit Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using System.Windows.Forms;
using static CommonLibrary.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab03Unit {
	[ToolboxItem(true)]
	public partial class UnitInfomation : ZUserControl {
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
		public UnitInfomation() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableUnitDataTable">Unit Data Table</param>
		public void SetDataBindings(__table_unitDataTable TableUnitDataTable) {
			// データバインドの設定
			textUnitID.DataBindings.Add(new Binding("Text", TableUnitDataTable, "UnitID", true));
			checkAirType.DataBindings.Add(new Binding("CheckState", TableUnitDataTable, "Air", true));
			checkAirType.DataBindings.Add(new Binding("Checked", TableUnitDataTable, "Air", true));
			textUnitName.DataBindings.Add(new Binding("Text", TableUnitDataTable, "UnitName", true));
			numericRare.DataBindings.Add(new Binding("Value", TableUnitDataTable, "Rare", true));
			numericWT.DataBindings.Add(new Binding("Value", TableUnitDataTable, "WT", true));
			textInfo.DataBindings.Add(new Binding("Text", TableUnitDataTable, "Info", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			textUnitID.MaxLength = maxIDTextSize;
			textUnitName.MaxLength = maxNameTextSize;
			textInfo.MaxLength = maxInfomationTextSize;
			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
