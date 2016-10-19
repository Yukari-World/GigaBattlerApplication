//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// RaceStatusBasicParts
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

namespace Status_Editer.User_Control.tab05Race.Parts {
	public partial class RaceStatusBasicParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		private decimal basicRate;

		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// グループラベルのテキストを設定します。
		/// </summary>
		public string labelText {
			get { return groupBasic.Text; }
			set { groupBasic.Text = value; }
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public RaceStatusBasicParts() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableRaceBindingSource">BindingSource</param>
		/// <param name="bindTag">string</param>
		public void SetDataBindings(BindingSource tableRaceBindingSource, string bindTag) {
			// データバインドの設定
			numericBase.DataBindings.Add(new Binding("Value", tableRaceBindingSource, bindTag, true));
			numericLvPStatus.DataBindings.Add(new Binding("Value", tableRaceBindingSource, "Lv" + bindTag, true));
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RaceStatusBasicParts_Load(object sender, EventArgs e) {
			string[] ExtraIndex = new string[] { "TP", "Luck", "HIT", "EVT" };
			if (Array.IndexOf(ExtraIndex, groupBasic.Text) != -1) {
				buttonSubmitRecommend.Visible = false;
				labelRecommend.Visible = false;
				numericBase.Increment = 5M;	// 変動幅を変更
				// TPでなければ、設定可能最小値を変更
				if (groupBasic.Text != "TP") {
					numericBase.Minimum = -9999M;
					numericLvPStatus.Minimum = -9999.99M;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericBase_ValueChanged(object sender, EventArgs e) {
			if (groupBasic.Text == "HP") {
				basicRate = numericBase.Value * 0.027m;
			} else {
				basicRate = numericBase.Value * 0.7m;
			}
			labelRecommend.Text = "推奨値:" + basicRate.ToString("N2");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void buttonSubmitRecommend_Click(object sender, EventArgs e) {
			numericLvPStatus.Value = basicRate;
		}
	}
}
