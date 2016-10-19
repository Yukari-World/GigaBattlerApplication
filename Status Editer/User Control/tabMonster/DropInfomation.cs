//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// DropInfomation
//
// Edited By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tabMonster {
	public partial class DropInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// バインド
		// WeaponTable
		private __table_weaponTableAdapter WeaponAdapter = new __table_weaponTableAdapter();
		private __table_weaponDataTable WeaponTable_3_1 = new __table_weaponDataTable();
		private __table_weaponDataTable WeaponTable_3_2 = new __table_weaponDataTable();
		private __table_weaponDataTable WeaponTable_3_3 = new __table_weaponDataTable();
		private __table_weaponDataTable WeaponTable_3_4 = new __table_weaponDataTable();
		private __table_weaponDataTable WeaponTable_3_5 = new __table_weaponDataTable();


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
		/// <param name="tableweaponBindingSource">BindingSource tableweaponBindingSource</param>
		/// <param name="tablemonsterBindingSource">BindingSource tablemonsterBindingSource</param>
		public void LoadDataBindings(BindingSource tableweaponBindingSource, BindingSource tablemonsterBindingSource ) {
			// バインド項目の設定
			WeaponAdapter.Fill(WeaponTable_3_1);
			WeaponAdapter.Fill(WeaponTable_3_2);
			WeaponAdapter.Fill(WeaponTable_3_3);
			WeaponAdapter.Fill(WeaponTable_3_4);
			WeaponAdapter.Fill(WeaponTable_3_5);

			comboDropTable1.DataBindings.Add(new Binding("SelectedValue", tablemonsterBindingSource, "Item1", true));
			comboDropTable2.DataBindings.Add(new Binding("SelectedValue", tablemonsterBindingSource, "Item2", true));
			comboDropTable3.DataBindings.Add(new Binding("SelectedValue", tablemonsterBindingSource, "Item3", true));
			comboDropTable4.DataBindings.Add(new Binding("SelectedValue", tablemonsterBindingSource, "Item4", true));
			comboDropTable5.DataBindings.Add(new Binding("SelectedValue", tablemonsterBindingSource, "Item5", true));

			numericDropRate1.DataBindings.Add(new Binding("Value", tablemonsterBindingSource, "Per1", true));
			numericDropRate2.DataBindings.Add(new Binding("Value", tablemonsterBindingSource, "Per2", true));
			numericDropRate3.DataBindings.Add(new Binding("Value", tablemonsterBindingSource, "Per3", true));
			numericDropRate4.DataBindings.Add(new Binding("Value", tablemonsterBindingSource, "Per4", true));
			numericDropRate5.DataBindings.Add(new Binding("Value", tablemonsterBindingSource, "Per5", true));

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
	}
}
