//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Item Status Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer.User_Control.CommonParts {
	[ToolboxItem(true)]
	public partial class ItemStatusParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public ItemStatusParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// ジャンル毎に必要かと思われたが、引数パラメータが全て同じなことが判明(オーバーロードの必要がない)
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableBingingSource">Any Item Binding Source</param>
		/// <param name="bindTag">Binding Tag</param>
		public void SetDataBindings(BindingSource tableBingingSource, string bindTag) {
			// データバインドの設定
			numericUpDown1.DataBindings.Add(new Binding("Value", tableBingingSource, bindTag, true));

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

			if (numericUpDown1.Value >= 0) {
				StatusBar.BackColor = Color.Green;
				StatusBar.Location = new Point(200, 7);
				StatusBar.Size = new Size(Math.Max((int)numericUpDown1.Value * 1, 0), 6);
			} else {
				StatusBar.BackColor = Color.Red;
				StatusBar.Location = new Point(200 + (int)numericUpDown1.Value, 7);
				StatusBar.Size = new Size(Math.Abs((int)numericUpDown1.Value * 1), 6);
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
				}
			}// End Loop

			// 破棄破棄
			PenBlack.Dispose();
			PenGray.Dispose();
			formGraphics.Dispose();
		}// End Method

		/// <summary>
		/// numericUpDown1の値が変更された時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			// ラベルのサイズ変更
			if (numericUpDown1.Value >= 0) {
				StatusBar.BackColor = Color.Green;
				StatusBar.Location = new Point(200, 7);
				StatusBar.Size = new Size(Math.Max((int)numericUpDown1.Value * 1, 0), 6);
			} else {
				StatusBar.BackColor = Color.Red;
				StatusBar.Location = new Point(200 + (int)numericUpDown1.Value, 7);
				StatusBar.Size = new Size(Math.Abs((int)numericUpDown1.Value * 1), 6);
			}// End If
		}// End Method
	}// End Class
}
