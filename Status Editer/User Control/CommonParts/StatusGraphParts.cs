//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Status Graph Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer.User_Control.CommonParts {
	[ToolboxItem(true)]
	public partial class StatusGraphParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// ステータスバー。ラベルを伸縮させることで利用
		/// </summary>
		private Label StatusBar = new Label();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// ステータスラベルを設定します
		/// </summary>
		[Description("ステータスラベルを設定します")]
		public string StatusLabel {
			get { return label1.Text; }
			set { label1.Text = value; }
		}// End Property

		/// <summary>
		/// ステータスの最小値を設定します
		/// </summary>
		[Description("ステータスの最小値を設定します")]
		public decimal MinStatusValue {
			get { return numericValue.Minimum; }
			set { numericValue.Minimum = value; }
		}// End Property


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public StatusGraphParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// ジャンル毎に必要かと思われたが、引数パラメータが全て同じなことが判明(オーバーロードの必要がない)
		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="ItemDataTable">Item Data Table</param>
		/// <param name="bindTag">Binding Tag</param>
		public void SetDataBindings(DataTable ItemDataTable, string bindTag) {
			// データバインドの設定
			numericValue.DataBindings.Add(new Binding("Value", ItemDataTable, bindTag, true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void ItemStatusParts_Load(object sender, EventArgs e) {
			// Labelの初期化
			StatusBar.AutoSize = false;
			StatusBar.BorderStyle = BorderStyle.FixedSingle;
			StatusBar.Name = "StatusBar";

			// 値が0以上かで分岐
			if (numericValue.Value >= 0) {
				StatusBar.BackColor = Color.Green;
				StatusBar.Location = new Point(200, 7);
				StatusBar.Size = new Size(Math.Max((int)numericValue.Value * 1, 0), 6);
			} else {
				StatusBar.BackColor = Color.Red;
				StatusBar.Location = new Point(200 + (int)numericValue.Value, 7);
				StatusBar.Size = new Size(Math.Abs((int)numericValue.Value * 1), 6);
			}// End If

			// LabelをUser Controlに追加する
			Controls.Add(StatusBar);

		}// End Method

		/// <summary>
		/// コントロールを再描画時に実行する処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">PaintEventArgs</param>
		private void ItemStatusParts_Paint(object sender, PaintEventArgs e) {
			// ラインを引く
			// 所謂横棒グラフのライン
			Pen PenBlack, PenGray;
			PenBlack = new Pen(Color.Black);
			PenGray = new Pen(Color.LightGray);
			Graphics formGraphics = CreateGraphics();

			// ラインを X の20の倍数毎に描画。100の倍数の場合、黒で描画
			// 初期座標はX = 200、暫定で X = 1000まで
			for (int i = 200; i <= 1000; i += 20) {
				if (i % 100 == 0) {
					formGraphics.DrawLine(PenBlack, i, 0, i, 20);
				} else {
					formGraphics.DrawLine(PenGray, i, 0, i, 20);
				}// End If
			}// End Loop

			// 破棄破棄
			PenBlack.Dispose();
			PenGray.Dispose();
			formGraphics.Dispose();
		}// End Method

		/// <summary>
		/// numericValueの値が変更された時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			// ラベルのサイズ変更
			// 値が0以上かで分岐
			if (numericValue.Value >= 0) {
				StatusBar.BackColor = Color.Green;
				StatusBar.Location = new Point(200, 7);
				StatusBar.Size = new Size(Math.Max((int)numericValue.Value * 1, 0), 6);
			} else {
				StatusBar.BackColor = Color.Red;
				StatusBar.Location = new Point(200 + (int)numericValue.Value, 7);
				StatusBar.Size = new Size(Math.Abs((int)numericValue.Value * 1), 6);
			}// End If
		}// End Method
	}// End Class
}
