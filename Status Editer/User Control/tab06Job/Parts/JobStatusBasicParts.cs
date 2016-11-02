//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Job Status Basic Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab06Job.Parts {
	[ToolboxItem(true)]
	public partial class JobStatusBasicParts : ZUserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// イベントの登録を許可
		[Browsable(true)]

		private int _StatusCost;	// ステータスコスト計算用
		private int CostMultiplier;	// ステータスコスト倍率
		private int GrooveGauge;	// ステータスバーの比率
		private Label StatusBar = new Label();
		/// <summary>
		/// 特殊処理が必要なデータをGruopLabelから抽出
		/// </summary>
		string[] ExtraIndex = new string[] { "TP", "HIT", "EVT" };

		// Class in Class
		public class NumEventArgs : EventArgs {
			public int Value;
		}// End Class

		// Delegate
		/// <summary>
		/// BaseValueChangedのデリゲート宣言
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">NumEventArgs</param>
		public delegate void BaseValueChangedEventHandler(object sender, NumEventArgs e);

		// EventHandler
		// イベントデリゲートの宣言
		[Category("Action")]
		[Description("StatusCostの値が変動した時に発動するイベントです")]
		public event BaseValueChangedEventHandler CostMultiplierChanged;


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// [ReadOnly]Basic Statusの値を返します
		/// </summary>
		[Description("[ReadOnly]Basic Statusの値を返します")]
		public decimal numericBaseValue {
			get { return numericBaseStatus.Value; }
		}

		/// <summary>
		/// [ReadOnly]Bonus Statusの値を返します
		/// </summary>
		[Description("[ReadOnly]Bonus Statusの値を返します")]
		public decimal numericBonusValue {
			get { return numericBonusStatus.Value; }
		}

		/// <summary>
		/// [R/W]グループラベルのテキストを設定します
		/// </summary>
		[Description("[R/W]グループラベルのテキストを設定します")]
		public string labelText {
			get { return groupBase.Text; }
			set { groupBase.Text = value; }
		}

		/// <summary>
		/// [R/W Private]ステータスコストを換算します
		/// </summary>
		[Description("[R/W Private]ステータスコストを換算します")]
		private int StatusCost {
			get { return _StatusCost; }
			set {
				_StatusCost = value;

				// 転送用準備
				NumEventArgs ex = new NumEventArgs();
				ex.Value = _StatusCost;// 送るデータの中身
				OnCostMultiplierChanged(ex);
			}
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public JobStatusBasicParts() {
			InitializeComponent();
		}// End Method


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
		}// End Function



		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// イベント『CostMultiplierChanged』のデータを転送します
		/// </summary>
		/// <param name="e">NumEventArgs</param>
		protected virtual void OnCostMultiplierChanged(NumEventArgs e) {
			// この1行で済むらしい……?
			CostMultiplierChanged?.Invoke(this, e);
		}// End Function


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
				numericBaseStatus.Increment = 5;	// 5の倍数で指定する
			} else {
				GrooveGauge = 2;
				CostMultiplier = 1;
			}// End If

			// コストの計算
			switch (groupBase.Text) {
				case "HIT":
				case "EVT":
					StatusCost = (int)numericBaseStatus.Value;
					break;
				case "TP":
					StatusCost = (int)numericBaseStatus.Value / 5;
					break;
				default:
					StatusCost = (int)numericBaseStatus.Value * CostMultiplier;
					break;
			}// End Switch

			// Labelの初期化
			StatusBar.AutoSize = false;
			StatusBar.BackColor = Color.Green;
			StatusBar.BorderStyle = BorderStyle.FixedSingle;
			StatusBar.Name = "StatusBar";
			StatusBar.Location = new Point(10, 50);
			StatusBar.Size = new Size(Math.Max((int)numericBaseStatus.Value * GrooveGauge, 0), 5);

			// LabelをGroupBoxに追加する
			groupBase.Controls.Add(StatusBar);
		}// End Function

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
					StatusCost = (int)numericBaseStatus.Value - 100;
					break;
				case "TP":
					StatusCost = (int)numericBaseStatus.Value / 5;
					break;
				default:
					StatusCost = (int)numericBaseStatus.Value * CostMultiplier;
					break;
			}// End Switch
		}// End Function
	}// End Class
}
