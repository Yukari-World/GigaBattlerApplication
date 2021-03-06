﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Race Status Basic Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static CommonLibrary.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab05Race.Parts {
	[ToolboxItem(true)]
	public partial class RaceStatusBasicParts : ZUserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		private decimal basicRate;
		private int GrooveGauge;
		private Label StatusBar = new Label();
		private Label PlusStatusBar = new Label();

		// Class in Class
		/// <summary>
		/// 値転送データ付きEvent Args
		/// </summary>
		public class NumEventArgs : EventArgs {
			/// <summary>
			/// 付与する値(decimal)
			/// </summary>
			public decimal Value;
		}// End Class


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Delegate
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// BaseValueChangedイベントのデリゲート宣言
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">NumEventArgs</param>
		public delegate void EventBaseValueChangedHandler(object sender, NumEventArgs e);

		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// EventHandler
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// イベントの宣言
		[Browsable(true)]
		[Category("Action")]
		[Description("StatusValueの値が変動した時に発生します。")]
		public event EventBaseValueChangedHandler BaseValueChanged;


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// [R/W]グループラベルのテキストを設定します
		/// </summary>
		[Description("[R/W]グループラベルのテキストを設定します")]
		public string labelText {
			get { return groupBasic.Text; }
			set { groupBasic.Text = value; }
		}// End Property

		/// <summary>
		/// [R/W Private]ベースステータスの値を抽出します
		/// </summary>
		[Description("[R/W Private]ベースステータスの値を抽出します")]
		private decimal numericBaseValue {
			get { return numericBase.Value; }
			set {
				numericBase.Value = value;

				// 転送用準備
				NumEventArgs ex = new NumEventArgs();
				ex.Value = numericBase.Value;// 送るデータの中身
				OnBaseValueChanged(ex);
			}// End Set
		}// End Property


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public RaceStatusBasicParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableRaceDataTable">Race Data Table</param>
		/// <param name="bindTag">Status Tag</param>
		public void SetDataBindings(__table_raceDataTable TableRaceDataTable, string bindTag) {
			// データバインドの設定
			numericBase.DataBindings.Add(new Binding("Value", TableRaceDataTable, bindTag, true));
			numericLvPStatus.DataBindings.Add(new Binding("Value", TableRaceDataTable, "Lv" + bindTag, true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Protected Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// イベント『CostMultiplierChanged』のデータを転送します
		/// </summary>
		/// <param name="e">NumEventArgs</param>
		protected virtual void OnBaseValueChanged(NumEventArgs e) {
			// この1行で済むらしい……?
			BaseValueChanged?.Invoke(this, e);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void RaceStatusBasicParts_Load(object sender, EventArgs e) {
			// 特殊処理が必要なデータをGruopLabelから抽出
			string[] LongValueIndex = new string[] { "HP", "TP", "HIT", "EVT" };
			string[] ExtraIndex = new string[] { "TP", "Luck", "HIT", "EVT" };

			// Gaugeの長さを設定する
			if (Array.IndexOf(LongValueIndex, groupBasic.Text) != -1) {
				GrooveGauge = 1;
			} else {
				GrooveGauge = 20;
			}// End If

			// 1st Labelの初期化
			StatusBar.AutoSize = false;
			StatusBar.BackColor = Color.Green;
			StatusBar.BorderStyle = BorderStyle.FixedSingle;
			StatusBar.Name = "StatusBar";
			StatusBar.Location = new Point(10, 50);
			StatusBar.Size = new Size(Math.Max((int)numericBaseValue * GrooveGauge, 0), 5);

			// 2nd Labelの初期化
			PlusStatusBar.AutoSize = false;
			PlusStatusBar.BackColor = Color.Yellow;
			PlusStatusBar.BorderStyle = BorderStyle.FixedSingle;
			PlusStatusBar.Name = "PlusStatusBar";
			PlusStatusBar.Location = new Point(StatusBar.Size.Width + 10, 50);  // 10pxずらして配置
			PlusStatusBar.Size = new Size(Math.Max((int)numericLvPStatus.Value * GrooveGauge, 0), 5);

			// 各種LabelをGroupBoxに追加する
			groupBasic.Controls.Add(StatusBar);
			groupBasic.Controls.Add(PlusStatusBar);

			// コントロールの設定変更
			// ExtraIndexのいずれかならば設定
			if (Array.IndexOf(ExtraIndex, groupBasic.Text) != -1) {
				buttonSubmitRecommend.Visible = false;  // ボタンを非表示
				labelRecommend.Visible = false;         // 不要なラベルを非表示
				numericBase.Increment = 5M; // 設定変動幅を変更

				if (groupBasic.Text != "TP") {  // TPでなければ、設定可能最小値を変更
					numericBase.Minimum = -9999M;
					numericLvPStatus.Minimum = -9999.99M;
				} else {    // TPなら設定可能最小値を0にする
					numericBase.Minimum = 0M;
				}// End If
			}// End If
		}// End Method

		/// <summary>
		/// Basic Statusの値が変化した時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericBase_ValueChanged(object sender, EventArgs e) {
			// 推奨値の計算
			if (groupBasic.Text == "HP") {
				basicRate = numericBase.Value * 0.027m;
			} else {
				basicRate = numericBase.Value * 0.7m;
			}// End If
			labelRecommend.Text = "推奨値:" + basicRate.ToString("N2");

			// Gaugeの長さを変更する
			StatusBar.Size = new Size(Math.Max((int)numericBaseValue * GrooveGauge, 0), 5);
			// Gaugeの位置を変更する
			PlusStatusBar.Location = new Point(StatusBar.Size.Width + 10, 50);
		}// End Method

		/// <summary>
		/// Lv Per Statusの値が変化した時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericLvPStatus_ValueChanged(object sender, EventArgs e) {
			// Gaugeの長さを変更する
			PlusStatusBar.Size = new Size(Math.Max((int)numericLvPStatus.Value * GrooveGauge, 0), 5);
		}// End Method

		/// <summary>
		/// 「推奨値を使用」ボタンが押された時の処理。処理というほど大きな事はしていない
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void buttonSubmitRecommend_Click(object sender, EventArgs e) {
			numericLvPStatus.Value = basicRate;
		}// End Method
	}// End Class
}
