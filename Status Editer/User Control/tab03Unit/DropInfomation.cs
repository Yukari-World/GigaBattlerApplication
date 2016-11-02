//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Drop Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System.ComponentModel;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab03Unit {
	[ToolboxItem(true)]
	public partial class DropInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// バインド
		// WeaponTable
		private __table_weaponDataTable WeaponTable_3_1 = new __table_weaponDataTable();
		private __table_weaponDataTable WeaponTable_3_2 = new __table_weaponDataTable();
		private __table_weaponDataTable WeaponTable_3_3 = new __table_weaponDataTable();
		private __table_weaponDataTable WeaponTable_3_4 = new __table_weaponDataTable();
		private __table_weaponDataTable WeaponTable_3_5 = new __table_weaponDataTable();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public DropInfomation() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		/// <param name="WeaponAdapter">__table_weaponTableAdapter</param>
		public void LoadDataBindings(BindingSource tableUnitBindingSource, __table_weaponTableAdapter WeaponAdapter) {
			// 項目に関する準備
			WeaponAdapter.Fill(WeaponTable_3_1);
			WeaponAdapter.Fill(WeaponTable_3_2);
			WeaponAdapter.Fill(WeaponTable_3_3);
			WeaponAdapter.Fill(WeaponTable_3_4);
			WeaponAdapter.Fill(WeaponTable_3_5);

			// データバインドの設定
			comboDropTable1.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item1", true));
			comboDropTable2.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item2", true));
			comboDropTable3.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item3", true));
			comboDropTable4.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item4", true));
			comboDropTable5.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item5", true));

			numericDropRate1.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per1", true));
			numericDropRate2.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per2", true));
			numericDropRate3.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per3", true));
			numericDropRate4.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per4", true));
			numericDropRate5.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per5", true));

			// バインド項目の設定
			comboDropTable1.DataSource = WeaponTable_3_1;
			comboDropTable1.DisplayMember = "WeaponName";
			comboDropTable1.ValueMember = "WeaponID";
			comboDropTable2.DataSource = WeaponTable_3_2;
			comboDropTable2.DisplayMember = "WeaponName";
			comboDropTable2.ValueMember = "WeaponID";
			comboDropTable3.DataSource = WeaponTable_3_3;
			comboDropTable3.DisplayMember = "WeaponName";
			comboDropTable3.ValueMember = "WeaponID";
			comboDropTable4.DataSource = WeaponTable_3_4;
			comboDropTable4.DisplayMember = "WeaponName";
			comboDropTable4.ValueMember = "WeaponID";
			comboDropTable5.DataSource = WeaponTable_3_5;
			comboDropTable5.DisplayMember = "WeaponName";
			comboDropTable5.ValueMember = "WeaponID";

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}

		/// <summary>
		/// バインド項目を再読み込みします。
		/// </summary>
		/// <param name="WeaponAdapter">__table_weaponTableAdapter</param>
		public void ReloadBindings(__table_weaponTableAdapter WeaponAdapter) {
			WeaponAdapter.Fill(WeaponTable_3_1);
			WeaponAdapter.Fill(WeaponTable_3_2);
			WeaponAdapter.Fill(WeaponTable_3_3);
			WeaponAdapter.Fill(WeaponTable_3_4);
			WeaponAdapter.Fill(WeaponTable_3_5);
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}
}
