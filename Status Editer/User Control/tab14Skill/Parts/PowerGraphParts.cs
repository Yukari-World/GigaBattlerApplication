//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Skill Power Graph Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static CommonLibrary.GigaBattlerDataSet;

namespace Status_Editer.User_Control.tab14Skill.Parts {
	[ToolboxItem(true)]
	public partial class PowerGraphParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// ステータスバー。ラベルを伸縮させることで利用
		/// </summary>
		private Label StatusBar = new Label();

		/// <summary>
		/// ステータスバーの開始位置
		/// </summary>
		private readonly int StartX = 10;


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public PowerGraphParts() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableSkillDataTable">Item Data Table</param>
		public void SetDataBindings(__table_skillDataTable TableSkillDataTable) {
			// データバインドの設定
			numericPower.DataBindings.Add(new Binding("Value", TableSkillDataTable, "Power", true));
			numericDamage.DataBindings.Add(new Binding("Value", TableSkillDataTable, "DamagePercent", true));
			numericBlurring.DataBindings.Add(new Binding("Value", TableSkillDataTable, "Blurring", true));

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

			StatusBar.BackColor = Color.Green;
			StatusBar.Location = new Point(StartX, 42);
			StatusBar.Size = new Size(Math.Min((int)numericPower.Value * 1, 10000), 6);

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
			Pen PenBlack, PenGray, PenRed;
			PenBlack = new Pen(Color.Black);
			PenGray = new Pen(Color.LightGray);
			PenRed = new Pen(Color.Red);
			Graphics formGraphics = CreateGraphics();

			// ブレ幅の目安ライン
			int BlurringMin = StartX + (int)numericPower.Value * (10000 - (int)numericBlurring.Value) / 10000;
			int BlurringMax = StartX + StatusBar.Size.Width;

			// ラインを X の20の倍数毎に描画。100の倍数の場合、黒で描画
			// 初期座標はX = 200、暫定で X = 1000まで
			for (int i = StartX; i <= 1000; i += 20) {
				if ((i - StartX) % 100 == 0) {
					formGraphics.DrawLine(PenBlack, i, 35, i, 55);
				} else {
					formGraphics.DrawLine(PenGray, i, 35, i, 55);
				}// End If
			}// End Loop

			// 威力のブレ幅の線を引く
			formGraphics.DrawLine(PenRed, BlurringMin, 35, BlurringMin, 70);     // 最小
			formGraphics.DrawLine(PenRed, BlurringMax, 35, BlurringMax, 70);     // 最大

			// 飾り線
			// 大体矢印の様な見た目になる
			for (int i = 0; i <= 5; i++) {
				formGraphics.DrawLine(PenRed, BlurringMin+i, 65 - i, BlurringMin + i, 65 + i);
				formGraphics.DrawLine(PenRed, BlurringMax - i, 65 - i, BlurringMax - i, 65 + i);
			}// End Loop
			formGraphics.DrawLine(PenRed, BlurringMin, 65, BlurringMax, 65);    // スケール

			// 破棄破棄
			PenBlack.Dispose();
			PenGray.Dispose();
			PenRed.Dispose();
			formGraphics.Dispose();
		}// End Method

		/// <summary>
		/// numericの何れかの値が変更された時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericValue_ValueChanged(object sender, EventArgs e) {
			StatusBar.Size = new Size(Math.Min((int)numericPower.Value * 1, 10000), 6);
			Invalidate();   // 再描画させる
		}// End Method
	}// End Class
}
