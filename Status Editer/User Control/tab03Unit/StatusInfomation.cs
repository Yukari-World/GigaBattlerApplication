//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// StatusInfomation
//
// Edited By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Status_Editer.User_Control.tab03Unit {
	public partial class StatusInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// グラフコントロール関連
		private Title ChartTitle = new Title();
		private DataPoint dataPoint1 = new DataPoint();
		private DataPoint dataPoint2 = new DataPoint();
		private DataPoint dataPoint3 = new DataPoint();
		private DataPoint dataPoint4 = new DataPoint();
		private DataPoint dataPoint5 = new DataPoint();
		private DataPoint dataPoint6 = new DataPoint();
		private DataPoint dataPoint7 = new DataPoint();
		private decimal[] dataValue = new decimal[7];


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public decimal numMinLevel {
			get { return numericMinLevel.Value; }
			set { numericMinLevel.Value = value; }
		}
		public decimal numMaxLevel {
			get { return numericMaxLevel.Value; }
			set { numericMaxLevel.Value = value; }
		}
		public decimal numHP {
			get { return numericHP.Value; }
			set { numericHP.Value = value; }
		}
		public decimal numLvPHP {
			get { return numericLvPHP.Value; }
			set { numericLvPHP.Value = value; }
		}
		public decimal numTP {
			get { return numericTP.Value; }
			set { numericTP.Value = value; }
		}
		public decimal numMaxTP {
			get { return numericMaxTP.Value; }
			set { numericMaxTP.Value = value; }
		}
		public decimal numScaleHP {
			get { return numericScaleHP.Value; }
			set { numericScaleHP.Value = value; }
		}
		public decimal numMeleeATK {
			get { return numericMeleeATK.Value; }
			set { numericMeleeATK.Value = value; }
		}
		public decimal numLvPMeleeATK {
			get { return numericLvPMeleeATK.Value; }
			set { numericLvPMeleeATK.Value = value; }
		}
		public decimal numScaleMeleeATK {
			get { return numericScaleMeleeATK.Value; }
			set { numericScaleMeleeATK.Value = value; }
		}
		public decimal numMeleeDEF {
			get { return numericMeleeDEF.Value; }
			set { numericMeleeDEF.Value = value; }
		}
		public decimal numLvPMeleeDEF {
			get { return numericLvPMeleeDEF.Value; }
			set { numericLvPMeleeDEF.Value = value; }
		}
		public decimal numScaleMeleeDEF {
			get { return numericScaleMeleeDEF.Value; }
			set { numericScaleMeleeDEF.Value = value; }
		}
		public decimal numRangeATK {
			get { return numericRangeATK.Value; }
			set { numericRangeATK.Value = value; }
		}
		public decimal numLvPRangeATK {
			get { return numericLvPRangeATK.Value; }
			set { numericLvPRangeATK.Value = value; }
		}
		public decimal numScaleRangeATK {
			get { return numericScaleRangeATK.Value; }
			set { numericScaleRangeATK.Value = value; }
		}
		public decimal numRangeDEF {
			get { return numericRangeDEF.Value; }
			set { numericRangeDEF.Value = value; }
		}
		public decimal numLvPRangeDEF {
			get { return numericLvPRangeDEF.Value; }
			set { numericLvPRangeDEF.Value = value; }
		}
		public decimal numScaleRangeDEF {
			get { return numericScaleRangeDEF.Value; }
			set { numericScaleRangeDEF.Value = value; }
		}
		public decimal numMagicATK {
			get { return numericMagicATK.Value; }
			set { numericMagicATK.Value = value; }
		}
		public decimal numLvPMagicATK {
			get { return numericLvPMagicATK.Value; }
			set { numericLvPMagicATK.Value = value; }
		}
		public decimal numScaleMagicATK {
			get { return numericScaleMagicATK.Value; }
			set { numericScaleMagicATK.Value = value; }
		}
		public decimal numMagicDEF {
			get { return numericMagicDEF.Value; }
			set { numericMagicDEF.Value = value; }
		}
		public decimal numLvPMagicDEF {
			get { return numericLvPMagicDEF.Value; }
			set { numericLvPMagicDEF.Value = value; }
		}
		public decimal numScaleMagicDEF {
			get { return numericScaleMagicDEF.Value; }
			set { numericScaleMagicDEF.Value = value; }
		}
		public decimal numSPD {
			get { return numericSPD.Value; }
			set { numericSPD.Value = value; }
		}
		public decimal numLvPSPD {
			get { return numericLvPSPD.Value; }
			set { numericLvPSPD.Value = value; }
		}
		public decimal numScaleSPD {
			get { return numericScaleSPD.Value; }
			set { numericScaleSPD.Value = value; }
		}
		public decimal numLuck {
			get { return numericLuck.Value; }
			set { numericLuck.Value = value; }
		}
		public decimal numLvPLuck {
			get { return numericLvPLuck.Value; }
			set { numericLvPLuck.Value = value; }
		}
		public decimal numHIT {
			get { return numericHIT.Value; }
			set { numericHIT.Value = value; }
		}
		public decimal numLvPHIT {
			get { return numericLvPHIT.Value; }
			set { numericLvPHIT.Value = value; }
		}
		public decimal numEVT {
			get { return numericEVT.Value; }
			set { numericEVT.Value = value; }
		}
		public decimal numLvPEVT {
			get { return numericLvPEVT.Value; }
			set { numericLvPEVT.Value = value; }
		}
		public decimal numEXP {
			get { return numericEXP.Value; }
			set { numericEXP.Value = value; }
		}
		public decimal numLvPEXP {
			get { return numericLvPEXP.Value; }
			set { numericLvPEXP.Value = value; }
		}
		public decimal numScaleEXP {
			get { return numericScaleEXP.Value; }
			set { numericScaleEXP.Value = value; }
		}
		public decimal numMoney {
			get { return numericMoney.Value; }
			set { numericMoney.Value = value; }
		}
		public decimal numLvPMoney {
			get { return numericLvPMoney.Value; }
			set { numericLvPMoney.Value = value; }
		}
		public decimal numScaleMoney {
			get { return numericScaleMoney.Value; }
			set { numericScaleMoney.Value = value; }
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public StatusInfomation() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableMonsterBindingSource">BindingSource</param>
		public void LoadDataBindings(BindingSource tableMonsterBindingSource) {
			numericReqLv.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "Req Lv", true));
			numericMinLevel.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "Min Lv", true));
			numericMaxLevel.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "Max Lv", true));
			numericHP.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "HP", true));
			numericLvPHP.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvHP", true));
			numericScaleHP.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "HP Per", true));
			numericTP.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "StartTP", true));
			numericMaxTP.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MaxTP", true));
			numericMeleeATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MeleeATK", true));
			numericLvPMeleeATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvMeleeATK", true));
			numericScaleMeleeATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MeleeATKPer", true));
			numericMeleeDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MeleeDEF", true));
			numericLvPMeleeDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvMeleeDEF", true));
			numericScaleMeleeDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MeleeDEFPer", true));
			numericRangeATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "RangeATK", true));
			numericLvPRangeATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvRangeATK", true));
			numericScaleRangeATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "RangeATKPer", true));
			numericRangeDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "RangeDEF", true));
			numericLvPRangeDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvRangeDEF", true));
			numericScaleRangeDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "RangeDEFPer", true));
			numericMagicATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MagicATK", true));
			numericLvPMagicATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvMagicATK", true));
			numericScaleMagicATK.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MagicATKPer", true));
			numericMagicDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MagicDEF", true));
			numericLvPMagicDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvMagicDEF", true));
			numericScaleMagicDEF.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MagicDEFPer", true));
			numericSPD.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "SPD", true));
			numericLvPSPD.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvSPD", true));
			numericScaleSPD.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "SPD Per", true));
			numericLuck.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LUK", true));
			numericLvPLuck.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvLUK", true));
			numericHIT.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "HIT", true));
			numericLvPHIT.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvHIT", true));
			numericEVT.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "EVT", true));
			numericLvPEVT.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvEVT", true));
			numericEXP.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "EXP", true));
			numericLvPEXP.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvEXP", true));
			numericScaleEXP.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "EXP Per", true));
			numericMoney.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MNY", true));
			numericLvPMoney.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "LvMNY", true));
			numericScaleMoney.DataBindings.Add(new Binding("Value", tableMonsterBindingSource, "MNY Per", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定
			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// グラフエリアを更新します。
		/// </summary>
		private void ChartChanges() {
			//グラフデータを更新する。
			dataValue[0] = (numericMeleeATK.Value + numericLvPMeleeATK.Value * numericTestLv.Value) * Math.Min((decimal)(Math.Sqrt((double)numericTestLv.Value) * 2D) + 100M, numericScaleMeleeATK.Value) / 100M;
			dataValue[1] = (numericMeleeDEF.Value + numericLvPMeleeDEF.Value * numericTestLv.Value) * Math.Min((decimal)(Math.Sqrt((double)numericTestLv.Value) * 2D) + 100M, numericScaleMeleeDEF.Value) / 100M;
			dataValue[2] = (numericRangeATK.Value + numericLvPRangeATK.Value * numericTestLv.Value) * Math.Min((decimal)(Math.Sqrt((double)numericTestLv.Value) * 2D) + 100M, numericScaleRangeATK.Value) / 100M;
			dataValue[3] = (numericRangeDEF.Value + numericLvPRangeDEF.Value * numericTestLv.Value) * Math.Min((decimal)(Math.Sqrt((double)numericTestLv.Value) * 2D) + 100M, numericScaleRangeDEF.Value) / 100M;
			dataValue[4] = (numericMagicATK.Value + numericLvPMagicATK.Value * numericTestLv.Value) * Math.Min((decimal)(Math.Sqrt((double)numericTestLv.Value) * 2D) + 100M, numericScaleMagicATK.Value) / 100M;
			dataValue[5] = (numericMagicDEF.Value + numericLvPMagicDEF.Value * numericTestLv.Value) * Math.Min((decimal)(Math.Sqrt((double)numericTestLv.Value) * 2D) + 100M, numericScaleMagicDEF.Value) / 100M;
			dataValue[6] = (numericSPD.Value + numericLvPSPD.Value * numericTestLv.Value) * Math.Min((decimal)(Math.Sqrt((double)numericTestLv.Value) * 2D) + 100M, numericScaleSPD.Value) / 100M;

			// 更新するため内容を消し去る
			chartStatus.Titles.Clear();
			chartStatus.Series[0].Points.Clear();

			// グラフタイトル
			ChartTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			ChartTitle.Name = "ChartTitle";
			ChartTitle.Text = "Status Rader Chart";
			chartStatus.Titles.Add(ChartTitle);

			// グラフデータ
			dataPoint1.SetValueY(dataValue[0]);
			dataPoint1.Label = "Melee ATK: " + dataValue[0].ToString("N2");
			dataPoint2.SetValueY(dataValue[1]);
			dataPoint2.Label = "Melee DEF: " + dataValue[1].ToString("N2");
			dataPoint3.SetValueY(dataValue[2]);
			dataPoint3.Label = "Range ATK: " + dataValue[2].ToString("N2");
			dataPoint4.SetValueY(dataValue[3]);
			dataPoint4.Label = "Range DEF: " + dataValue[3].ToString("N2");
			dataPoint5.SetValueY(dataValue[4]);
			dataPoint5.Label = "Magic ATK: " + dataValue[4].ToString("N2");
			dataPoint6.SetValueY(dataValue[5]);
			dataPoint6.Label = "Magic DEF: " + dataValue[5].ToString("N2");
			dataPoint7.SetValueY(dataValue[6]);
			dataPoint7.Label = "SPD: " + dataValue[6].ToString("N2");

			// グラフ描画
			chartStatus.Series[0].Points.Add(dataPoint1);
			chartStatus.Series[0].Points.Add(dataPoint2);
			chartStatus.Series[0].Points.Add(dataPoint3);
			chartStatus.Series[0].Points.Add(dataPoint4);
			chartStatus.Series[0].Points.Add(dataPoint5);
			chartStatus.Series[0].Points.Add(dataPoint6);
			chartStatus.Series[0].Points.Add(dataPoint7);
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// ステータス変更時の更新データ
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericTestLv_ValueChanged(object sender, EventArgs e) {
			ChartChanges();
		}

		private void numericMinLevel_ValueChanged(object sender, EventArgs e) {
			numericTestLv.Value = numericMinLevel.Value;
		}

		private void Status_ValueChanged(object sender, EventArgs e) {
			ChartChanges();
		}
	}
}
