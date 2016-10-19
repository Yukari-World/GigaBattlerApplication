using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_Editer.User_Control {
	public partial class UnitInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public UnitInfomation() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tablemonsterBindingSource">BindingSource tablemonsterBindingSource</param>
		public void LoadDataBindings(BindingSource tablemonsterBindingSource) {
			textMonsterID.DataBindings.Add(new Binding("Text", tablemonsterBindingSource, "MonsterID", true));
			checkAirType.DataBindings.Add(new Binding("CheckState", tablemonsterBindingSource, "Air", true));
			checkAirType.DataBindings.Add(new Binding("Checked", tablemonsterBindingSource, "Air", true));
			textUnitName.DataBindings.Add(new Binding("Text", tablemonsterBindingSource, "MonsterName", true));
			numericRare.DataBindings.Add(new Binding("Value", tablemonsterBindingSource, "Rare", true));
			textInfo.DataBindings.Add(new Binding("Text", tablemonsterBindingSource, "Info", true));
		}
	}
}
