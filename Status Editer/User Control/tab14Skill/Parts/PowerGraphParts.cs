//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Skill Power Graph Parts
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
		private readonly int StartX = 250;


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
		/// <param name="SkillDataTable">Item Data Table</param>
		public void SetDataBindings(DataTable SkillDataTable) {
			// データバインドの設定
			numericPower.DataBindings.Add(new Binding("Value", SkillDataTable, "Power", true));
			numericDamage.DataBindings.Add(new Binding("Value", SkillDataTable, "DamagePercent", true));
			numericBlurring.DataBindings.Add(new Binding("Value", SkillDataTable, "Blurring", true));

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
			StatusBar.Location = new Point(StartX, 12);
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
					formGraphics.DrawLine(PenBlack, i, 5, i, 25);
				} else {
					formGraphics.DrawLine(PenGray, i, 5, i, 25);
				}// End If
			}// End Loop

			// 威力のブレ幅の線を引く
			formGraphics.DrawLine(PenRed, BlurringMin, 5, BlurringMin, 40);     // 最小
			formGraphics.DrawLine(PenRed, BlurringMax, 5, BlurringMax, 40);     // 最大

			// 飾り線
			// 大体矢印の様な見た目になる
			for (int i = 0; i <= 5; i++) {
				formGraphics.DrawLine(PenRed, BlurringMin+i, 35 - i, BlurringMin + i, 35 + i);
				formGraphics.DrawLine(PenRed, BlurringMax - i, 35 - i, BlurringMax - i, 35 + i);
			}// End Loop
			formGraphics.DrawLine(PenRed, BlurringMin, 35, BlurringMax, 35);    // スケール

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
