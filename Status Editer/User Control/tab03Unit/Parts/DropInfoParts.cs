//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Drop Infomation Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab03Unit.Parts {
	[ToolboxItem(true)]
	public partial class DropInfoParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// [R/W]グループラベルのテキストを設定します
		/// </summary>
		[Description("[R/W]グループラベルのテキストを設定します")]
		public string labelText {
			get { return groupBoxDrop.Text; }
			set { groupBoxDrop.Text = value; }
		}// End Property


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public DropInfoParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// Weapon
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		/// <param name="bindTag">Weapon Adapter</param>
		public void SetDataBindings(BindingSource tableUnitBindingSource, __table_weaponDataTable bindTag) {
			// コンボボックスの設定
			comboDropTable.DataSource = bindTag;
			comboDropTable.DisplayMember = "WeaponName";
			comboDropTable.ValueMember = "WeaponID";

			// データバインドの設定
			comboDropTable.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item1", true));
			numericDropRate.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per1", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function

		//Shield
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		/// <param name="bindTag">Shield Adapter</param>
		public void SetDataBindings(BindingSource tableUnitBindingSource, __table_shieldDataTable bindTag) {
			// コンボボックスの設定
			comboDropTable.DataSource = bindTag;
			comboDropTable.DisplayMember = "ShieldName";
			comboDropTable.ValueMember = "ShieldID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item2", true));
			numericDropRate.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per2", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function

		// Helmet
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		/// <param name="bindTag">Helmet Adapter</param>
		public void SetDataBindings(BindingSource tableUnitBindingSource, __table_helmetDataTable bindTag) {
			// コンボボックスの設定
			comboDropTable.DataSource = bindTag;
			comboDropTable.DisplayMember = "HelmetName";
			comboDropTable.ValueMember = "HelmetID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item3", true));
			numericDropRate.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per3", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function

		// Gauntlet
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		/// <param name="bindTag">Gauntlet Adapter</param>
		public void SetDataBindings(BindingSource tableUnitBindingSource, __table_gauntletDataTable bindTag) {
			// コンボボックスの設定
			comboDropTable.DataSource = bindTag;
			comboDropTable.DisplayMember = "GauntletName";
			comboDropTable.ValueMember = "GauntletID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item4", true));
			numericDropRate.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per4", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function

		// Armor
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		/// <param name="bindTag">Armor Adapter</param>
		public void SetDataBindings(BindingSource tableUnitBindingSource, __table_armorDataTable bindTag) {
			// コンボボックスの設定
			comboDropTable.DataSource = bindTag;
			comboDropTable.DisplayMember = "ArmorName";
			comboDropTable.ValueMember = "ArmorID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item5", true));
			numericDropRate.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per5", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function

		// Accessory
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		/// <param name="bindTag">Accessory Adapter</param>
		public void SetDataBindings(BindingSource tableUnitBindingSource, __table_accessoryDataTable bindTag) {
			// コンボボックスの設定
			comboDropTable.DataSource = bindTag;
			comboDropTable.DisplayMember = "AccessoryName";
			comboDropTable.ValueMember = "AccessoryID";

			// データバインドの設定

			comboDropTable.DataBindings.Add(new Binding("SelectedValue", tableUnitBindingSource, "Item6", true));
			numericDropRate.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Per6", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}// End Class
}
