//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Job Status Basic Parts
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

namespace Status_Editer.User_Control.tab06Job.Parts {
	public partial class JobStatusBasicParts : ZUserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		private int _StatusCost;
		private int CostMultiplier;
		private int GrooveGauge;
		private Label StatusBar = new Label();
		/// <summary>
		/// 特殊処理が必要なデータをGruopLabelから抽出
		/// </summary>
		string[] ExtraIndex = new string[] { "TP", "HIT", "EVT" };


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// [ReadOnly]ステータスコストを換算します
		/// </summary>
		public int StatusCost {
			get {
				return _StatusCost;
			}
		}

		/// <summary>
		/// [ReadOnly]Basic Statusの値を返します
		/// </summary>
		public decimal numericBaseValue {
			get {
				return numericBaseStatus.Value;
			}
		}

		/// <summary>
		/// [ReadOnly]Bonus Statusの値を返します
		/// </summary>
		public decimal numericBonusValue {
			get {
				return numericBonusStatus.Value;
			}
		}

		/// <summary>
		/// [R/W]グループラベルのテキストを設定します。
		/// </summary>
		public string labelText {
			get { return groupBase.Text; }
			set { groupBase.Text = value; }
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public JobStatusBasicParts() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableJobBindingSource">BindingSource</param>
		/// <param name="bindTag">Status Tag</param>
		public void SetDataBindings(BindingSource tableJobBindingSource, string bindTag) {
			// データバインドの設定
			numericBaseStatus.DataBindings.Add(new Binding("Value", tableJobBindingSource, bindTag, true));
			numericBonusStatus.DataBindings.Add(new Binding("Value", tableJobBindingSource, "Bonus" + bindTag, true));

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

		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void JobStatusBasicParts_Load(object sender, EventArgs e) {
			// Gaugeの長さを設定する
			if (groupBase.Text == "Luck") {
				GrooveGauge = 10;
				CostMultiplier = 5;
			} else if (Array.IndexOf(ExtraIndex, groupBase.Text) != -1) {
				GrooveGauge = 1;
				CostMultiplier = 5;
				numericBaseStatus.Increment = 5;
			} else {
				GrooveGauge = 2;
				CostMultiplier = 1;
			}// End If

			// Labelの初期化
			StatusBar.AutoSize = false;
			StatusBar.BackColor = Color.Green;
			StatusBar.BorderStyle = BorderStyle.FixedSingle;
			StatusBar.Name = "StatusBar";
			StatusBar.Location = new Point(10, 50);
			StatusBar.Size = new Size(Math.Max((int)numericBaseStatus.Value * GrooveGauge, 0), 5);

			// LabelをGroupBoxに追加する
			groupBase.Controls.Add(StatusBar);
		}

		/// <summary>
		/// Base Statusの値が変化した時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericBaseStatus_ValueChanged(object sender, EventArgs e) {
			// Gaugeの長さを変更する
			StatusBar.Size = new Size(Math.Max((int)numericBaseStatus.Value * GrooveGauge, 0), 5);

			// コストの計算
			switch (groupBase.Text) {
				case "HIT":
				case "EVT":
					_StatusCost = (int)numericBaseStatus.Value - 100;
					break;
				default:
					_StatusCost = (int)numericBaseStatus.Value * CostMultiplier;
					break;
			}// End Switch
		}
	}
}
