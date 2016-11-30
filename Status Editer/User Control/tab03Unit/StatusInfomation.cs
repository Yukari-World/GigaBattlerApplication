//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Status Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Status_Editer.User_Control.tab03Unit {
	[ToolboxItem(true)]
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
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		public decimal numMinLevel {
			get { return numericMinLevel.Value; }
			set { numericMinLevel.Value = value; }
		}// End Property
		public decimal numMaxLevel {
			get { return numericMaxLevel.Value; }
			set { numericMaxLevel.Value = value; }
		}// End Property
		public decimal numHP {
			get { return numericHP.Value; }
			set { numericHP.Value = value; }
		}// End Property
		public decimal numLvPHP {
			get { return numericLvPHP.Value; }
			set { numericLvPHP.Value = value; }
		}// End Property
		public decimal numTP {
			get { return numericTP.Value; }
			set { numericTP.Value = value; }
		}// End Property
		public decimal numMaxTP {
			get { return numericMaxTP.Value; }
			set { numericMaxTP.Value = value; }
		}// End Property
		public decimal numScaleHP {
			get { return numericScaleHP.Value; }
			set { numericScaleHP.Value = value; }
		}// End Property
		public decimal numMeleeATK {
			get { return numericMeleeATK.Value; }
			set { numericMeleeATK.Value = value; }
		}// End Property
		public decimal numLvPMeleeATK {
			get { return numericLvPMeleeATK.Value; }
			set { numericLvPMeleeATK.Value = value; }
		}// End Property
		public decimal numScaleMeleeATK {
			get { return numericScaleMeleeATK.Value; }
			set { numericScaleMeleeATK.Value = value; }
		}// End Property
		public decimal numMeleeDEF {
			get { return numericMeleeDEF.Value; }
			set { numericMeleeDEF.Value = value; }
		}// End Property
		public decimal numLvPMeleeDEF {
			get { return numericLvPMeleeDEF.Value; }
			set { numericLvPMeleeDEF.Value = value; }
		}// End Property
		public decimal numScaleMeleeDEF {
			get { return numericScaleMeleeDEF.Value; }
			set { numericScaleMeleeDEF.Value = value; }
		}// End Property
		public decimal numRangeATK {
			get { return numericRangeATK.Value; }
			set { numericRangeATK.Value = value; }
		}// End Property
		public decimal numLvPRangeATK {
			get { return numericLvPRangeATK.Value; }
			set { numericLvPRangeATK.Value = value; }
		}// End Property
		public decimal numScaleRangeATK {
			get { return numericScaleRangeATK.Value; }
			set { numericScaleRangeATK.Value = value; }
		}// End Property
		public decimal numRangeDEF {
			get { return numericRangeDEF.Value; }
			set { numericRangeDEF.Value = value; }
		}// End Property
		public decimal numLvPRangeDEF {
			get { return numericLvPRangeDEF.Value; }
			set { numericLvPRangeDEF.Value = value; }
		}// End Property
		public decimal numScaleRangeDEF {
			get { return numericScaleRangeDEF.Value; }
			set { numericScaleRangeDEF.Value = value; }
		}// End Property
		public decimal numMagicATK {
			get { return numericMagicATK.Value; }
			set { numericMagicATK.Value = value; }
		}// End Property
		public decimal numLvPMagicATK {
			get { return numericLvPMagicATK.Value; }
			set { numericLvPMagicATK.Value = value; }
		}// End Property
		public decimal numScaleMagicATK {
			get { return numericScaleMagicATK.Value; }
			set { numericScaleMagicATK.Value = value; }
		}// End Property
		public decimal numMagicDEF {
			get { return numericMagicDEF.Value; }
			set { numericMagicDEF.Value = value; }
		}// End Property
		public decimal numLvPMagicDEF {
			get { return numericLvPMagicDEF.Value; }
			set { numericLvPMagicDEF.Value = value; }
		}// End Property
		public decimal numScaleMagicDEF {
			get { return numericScaleMagicDEF.Value; }
			set { numericScaleMagicDEF.Value = value; }
		}// End Property
		public decimal numSPD {
			get { return numericSPD.Value; }
			set { numericSPD.Value = value; }
		}// End Property
		public decimal numLvPSPD {
			get { return numericLvPSPD.Value; }
			set { numericLvPSPD.Value = value; }
		}// End Property
		public decimal numScaleSPD {
			get { return numericScaleSPD.Value; }
			set { numericScaleSPD.Value = value; }
		}// End Property
		public decimal numLuck {
			get { return numericLuck.Value; }
			set { numericLuck.Value = value; }
		}// End Property
		public decimal numLvPLuck {
			get { return numericLvPLuck.Value; }
			set { numericLvPLuck.Value = value; }
		}// End Property
		public decimal numHIT {
			get { return numericHIT.Value; }
			set { numericHIT.Value = value; }
		}// End Property
		public decimal numLvPHIT {
			get { return numericLvPHIT.Value; }
			set { numericLvPHIT.Value = value; }
		}// End Property
		public decimal numEVT {
			get { return numericEVT.Value; }
			set { numericEVT.Value = value; }
		}// End Property
		public decimal numLvPEVT {
			get { return numericLvPEVT.Value; }
			set { numericLvPEVT.Value = value; }
		}// End Property
		public decimal numEXP {
			get { return numericEXP.Value; }
			set { numericEXP.Value = value; }
		}// End Property
		public decimal numLvPEXP {
			get { return numericLvPEXP.Value; }
			set { numericLvPEXP.Value = value; }
		}// End Property
		public decimal numScaleEXP {
			get { return numericScaleEXP.Value; }
			set { numericScaleEXP.Value = value; }
		}// End Property
		public decimal numMoney {
			get { return numericMoney.Value; }
			set { numericMoney.Value = value; }
		}// End Property
		public decimal numLvPMoney {
			get { return numericLvPMoney.Value; }
			set { numericLvPMoney.Value = value; }
		}// End Property
		public decimal numScaleMoney {
			get { return numericScaleMoney.Value; }
			set { numericScaleMoney.Value = value; }
		}// End Property


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public StatusInfomation() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		public void LoadDataBindings(BindingSource tableUnitBindingSource) {
			// データバインドの設定
			numericReqLv.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Req Lv", true));
			numericMinLevel.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Min Lv", true));
			numericMaxLevel.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "Max Lv", true));
			numericHP.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "HP", true));
			numericLvPHP.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvHP", true));
			numericScaleHP.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "HP Per", true));
			numericTP.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "StartTP", true));
			numericMaxTP.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MaxTP", true));
			numericMeleeATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MeleeATK", true));
			numericLvPMeleeATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvMeleeATK", true));
			numericScaleMeleeATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MeleeATKPer", true));
			numericMeleeDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MeleeDEF", true));
			numericLvPMeleeDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvMeleeDEF", true));
			numericScaleMeleeDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MeleeDEFPer", true));
			numericRangeATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "RangeATK", true));
			numericLvPRangeATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvRangeATK", true));
			numericScaleRangeATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "RangeATKPer", true));
			numericRangeDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "RangeDEF", true));
			numericLvPRangeDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvRangeDEF", true));
			numericScaleRangeDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "RangeDEFPer", true));
			numericMagicATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MagicATK", true));
			numericLvPMagicATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvMagicATK", true));
			numericScaleMagicATK.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MagicATKPer", true));
			numericMagicDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MagicDEF", true));
			numericLvPMagicDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvMagicDEF", true));
			numericScaleMagicDEF.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MagicDEFPer", true));
			numericSPD.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "SPD", true));
			numericLvPSPD.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvSPD", true));
			numericScaleSPD.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "SPD Per", true));
			numericLuck.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LUK", true));
			numericLvPLuck.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvLUK", true));
			numericHIT.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "HIT", true));
			numericLvPHIT.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvHIT", true));
			numericEVT.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "EVT", true));
			numericLvPEVT.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvEVT", true));
			numericEXP.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "EXP", true));
			numericLvPEXP.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvEXP", true));
			numericScaleEXP.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "EXP Per", true));
			numericMoney.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MNY", true));
			numericLvPMoney.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "LvMNY", true));
			numericScaleMoney.DataBindings.Add(new Binding("Value", tableUnitBindingSource, "MNY Per", true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
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
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// ステータス変更時の更新データ
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void numericTestLv_ValueChanged(object sender, EventArgs e) {
			ChartChanges();
		}// End Method

		private void numericMinLevel_ValueChanged(object sender, EventArgs e) {
			numericTestLv.Value = numericMinLevel.Value;
		}// End Method

		private void Status_ValueChanged(object sender, EventArgs e) {
			ChartChanges();
		}// End Method
	}// End Class
}
