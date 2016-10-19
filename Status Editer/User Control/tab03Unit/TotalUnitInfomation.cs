//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// TotalUnitInfomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit {
	public partial class TotalUnitInfomation : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// 変数
		private long minLv = 0;
		private long maxLv = 0;
		int ref_f = 0;


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public TotalUnitInfomation() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableUnitBindingSource">BindingSource</param>
		public void LoadDataBindings(BindingSource tableUnitBindingSource) {
			// データバインドの設定
			labelName.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "UnitName", true));
			labelUnitType.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "Race", true));
			labelReqLv.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "Req Lv", true, DataSourceUpdateMode.OnValidation, null, "N0"));
			labelMinLv.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "Min Lv", true, DataSourceUpdateMode.OnValidation, null, "N0"));
			labelMaxLv.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "Max Lv", true, DataSourceUpdateMode.OnValidation, null, "N0"));
			labelBaseHP.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "HP", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelLvPHP.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvHP", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelScaleHP.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "HP Per", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseMeleeATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MeleeATK", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelLvPMeleeATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvMeleeATK", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelScaleMeleeATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MeleeATKPer", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseMeleeDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MeleeDEF", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelLvPMeleeDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvMeleeDEF", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelScaleMeleeDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MeleeDEFPer", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseRangeATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "RangeATK", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelLvPRangeATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvRangeATK", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelScaleRangeATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "RangeATKPer", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseRangeDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "RangeDEF", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelLvPRangeDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvRangeDEF", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelScaleRangeDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "RangeDEFPer", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseMagicATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MagicATK", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelLvPMagicATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvMagicATK", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelScaleMagicATK.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MagicATKPer", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseMagicDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MagicDEF", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelLvPMagicDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvMagicDEF", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelScaleMagicDEF.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MagicDEFPer", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseSPD.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "SPD", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelLvPSPD.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvSPD", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelScaleSPD.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "SPD Per", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseLuck.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LUK", true));
			labelLvPLuck.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvLUK", true));
			labelBaseHIT.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "HIT", true));
			labelLvPHIT.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvHIT", true));
			labelBaseEVT.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "EVT", true));
			labelLvPEVT.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvEVT", true));
			labelBaseEXP.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "EXP", true, DataSourceUpdateMode.OnValidation, null, "N0"));
			labelLvPEXP.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvEXP", true, DataSourceUpdateMode.OnValidation, null, "N0"));
			labelScaleEXP.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "EXP Per", true, DataSourceUpdateMode.OnValidation, null, "N2"));
			labelBaseMoney.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MNY", true, DataSourceUpdateMode.OnValidation, null, "N0"));
			labelLvPMoney.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "LvMNY", true, DataSourceUpdateMode.OnValidation, null, "N0"));
			labelScaleMoney.DataBindings.Add(new Binding("Text", tableUnitBindingSource, "MNY Per", true, DataSourceUpdateMode.OnValidation, null, "N2"));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// ステータス演算関数
		/// </summary>
		private void Change_LvValue() {
			// 無駄に多い変数
			// 読み取り対象がLabelなため、一度変換が必要
			decimal BaseHP = decimal.Parse(labelBaseHP.Text.Replace(",", ""));
			decimal LvPHP = decimal.Parse(labelLvPHP.Text.Replace(",", ""));
			decimal ScaleHP = decimal.Parse(labelScaleHP.Text.Replace(",", ""));
			decimal BaseMeleeATK = decimal.Parse(labelBaseMeleeATK.Text.Replace(",", ""));
			decimal LvPMeleeATK = decimal.Parse(labelLvPMeleeATK.Text.Replace(",", ""));
			decimal ScaleMeleeATK = decimal.Parse(labelScaleMeleeATK.Text.Replace(",", ""));
			decimal BaseMeleeDEF = decimal.Parse(labelBaseMeleeDEF.Text.Replace(",", ""));
			decimal LvPMeleeDEF = decimal.Parse(labelLvPMeleeDEF.Text.Replace(",", ""));
			decimal ScaleMeleeDEF = decimal.Parse(labelScaleMeleeDEF.Text.Replace(",", ""));
			decimal BaseRangeATK = decimal.Parse(labelBaseRangeATK.Text.Replace(",", ""));
			decimal LvPRangeATK = decimal.Parse(labelLvPRangeATK.Text.Replace(",", ""));
			decimal ScaleRangeATK = decimal.Parse(labelScaleRangeATK.Text.Replace(",", ""));
			decimal BaseRangeDEF = decimal.Parse(labelBaseRangeDEF.Text.Replace(",", ""));
			decimal LvPRangeDEF = decimal.Parse(labelLvPRangeDEF.Text.Replace(",", ""));
			decimal ScaleRangeDEF = decimal.Parse(labelScaleRangeDEF.Text.Replace(",", ""));
			decimal BaseMagicATK = decimal.Parse(labelBaseMagicATK.Text.Replace(",", ""));
			decimal LvPMagicATK = decimal.Parse(labelLvPMagicATK.Text.Replace(",", ""));
			decimal ScaleMagicATK = decimal.Parse(labelScaleMagicATK.Text.Replace(",", ""));
			decimal BaseMagicDEF = decimal.Parse(labelBaseMagicDEF.Text.Replace(",", ""));
			decimal LvPMagicDEF = decimal.Parse(labelLvPMagicDEF.Text.Replace(",", ""));
			decimal ScaleMagicDEF = decimal.Parse(labelScaleMagicDEF.Text.Replace(",", ""));
			decimal BaseSPD = decimal.Parse(labelBaseSPD.Text.Replace(",", ""));
			decimal LvPSPD = decimal.Parse(labelLvPSPD.Text.Replace(",", ""));
			decimal ScaleSPD = decimal.Parse(labelScaleSPD.Text.Replace(",", ""));

			decimal BaseLuck = decimal.Parse(labelBaseLuck.Text.Replace(",", ""));
			decimal LvPLuck = decimal.Parse(labelLvPLuck.Text.Replace(",", ""));
			decimal BaseEVT = decimal.Parse(labelBaseEVT.Text.Replace(",", ""));
			decimal LvPEVT = decimal.Parse(labelLvPEVT.Text.Replace(",", ""));
			decimal BaseHIT = decimal.Parse(labelBaseHIT.Text.Replace(",", ""));
			decimal LvPHIT = decimal.Parse(labelLvPHIT.Text.Replace(",", ""));

			decimal BaseEXP = decimal.Parse(labelBaseEXP.Text.Replace(",", ""));
			decimal LvPEXP = decimal.Parse(labelLvPEXP.Text.Replace(",", ""));
			decimal ScaleEXP = decimal.Parse(labelScaleEXP.Text.Replace(",", ""));
			decimal BaseMoney = decimal.Parse(labelBaseMoney.Text.Replace(",", ""));
			decimal LvPMoney = decimal.Parse(labelLvPMoney.Text.Replace(",", ""));
			decimal ScaleMoney = decimal.Parse(labelScaleMoney.Text.Replace(",", ""));

			// 一時保管用変数
			decimal Lv1SPD = ((BaseSPD + LvPSPD) * Math.Min(102M, ScaleSPD) / 100M);
			decimal MinLvSPD = ((BaseSPD + LvPSPD * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleSPD) / 100M);
			decimal MaxLvSPD = ((BaseSPD + LvPSPD * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleSPD) / 100M);

			// Lv1の計算式。一部が簡素だが仕様
			labelLv1HP.Text = ((BaseHP + LvPHP) * Math.Min(102M, ScaleHP) / 100M).ToString("N2");
			labelLv1MeleeATK.Text = ((BaseMeleeATK + LvPMeleeATK) * Math.Min(102M, ScaleMeleeATK) / 100M).ToString("N2");
			labelLv1MeleeDEF.Text = ((BaseMeleeDEF + LvPMeleeDEF) * Math.Min(102M, ScaleMeleeDEF) / 100M).ToString("N2");
			labelLv1RangeATK.Text = ((BaseRangeATK + LvPRangeATK) * Math.Min(102M, ScaleRangeATK) / 100M).ToString("N2");
			labelLv1RangeDEF.Text = ((BaseRangeDEF + LvPRangeDEF) * Math.Min(102M, ScaleRangeDEF) / 100M).ToString("N2");
			labelLv1MagicATK.Text = ((BaseMagicATK + LvPMagicATK) * Math.Min(102M, ScaleMagicATK) / 100M).ToString("N2");
			labelLv1MagicDEF.Text = ((BaseMagicDEF + LvPMagicDEF) * Math.Min(102M, ScaleMagicDEF) / 100M).ToString("N2");
			labelLv1SPD.Text = Lv1SPD.ToString("N2");
			labelLv1Luck.Text = (BaseLuck + LvPLuck).ToString("N0");
			labelLv1HIT.Text = (BaseHIT + LvPHIT + (decimal)Math.Sqrt((double)Lv1SPD / 10D)).ToString("N0");
			labelLv1EVT.Text = (BaseEVT + LvPEVT + (decimal)Math.Sqrt((double)Lv1SPD / 10D)).ToString("N0");
			labelLv1EXP.Text = ((BaseEXP + LvPEXP) * Math.Min(102M, ScaleEXP) / 100M).ToString("N0");
			labelLv1Money.Text = ((BaseMoney + LvPMoney) * Math.Min(102M, ScaleMoney) / 100M).ToString("N0");

			// MinLv時の計算式
			labelMinLvHP.Text = ((BaseHP + LvPHP * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleHP) / 100M).ToString("N2");
			labelMinLvMeleeATK.Text = ((BaseMeleeATK + LvPMeleeATK * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleMeleeATK) / 100M).ToString("N2");
			labelMinLvMeleeDEF.Text = ((BaseMeleeDEF + LvPMeleeDEF * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleMeleeDEF) / 100M).ToString("N2");
			labelMinLvRangeATK.Text = ((BaseRangeATK + LvPRangeATK * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleRangeATK) / 100M).ToString("N2");
			labelMinLvRangeDEF.Text = ((BaseRangeDEF + LvPRangeDEF * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleRangeDEF) / 100M).ToString("N2");
			labelMinLvMagicATK.Text = ((BaseMagicATK + LvPMagicATK * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleMagicATK) / 100M).ToString("N2");
			labelMinLvMagicDEF.Text = ((BaseMagicDEF + LvPMagicDEF * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleMagicDEF) / 100M).ToString("N2");
			labelMinLvSPD.Text = MinLvSPD.ToString("N2");
			labelMinLvLuck.Text = (BaseLuck + LvPLuck * Math.Min(minLv, 100M)).ToString("N0");
			labelMinLvHIT.Text = (BaseHIT + LvPHIT * Math.Min(minLv, 100M) + (decimal)Math.Sqrt((double)MinLvSPD / 10D)).ToString("N0");
			labelMinLvEVT.Text = (BaseEVT + LvPEVT * Math.Min(minLv, 100M) + (decimal)Math.Sqrt((double)MinLvSPD / 10D)).ToString("N0");
			labelMinLvEXP.Text = ((BaseEXP + LvPEXP * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleEXP) / 100M).ToString("N0");
			labelMinLvMoney.Text = ((BaseMoney + LvPMoney * minLv) * Math.Min((decimal)(Math.Sqrt(minLv) * 2D) + 100M, ScaleMoney) / 100M).ToString("N0");

			// MaxLv時の計算式
			labelMaxLvHP.Text = ((BaseHP + LvPHP * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleHP) / 100M).ToString("N2");
			labelMaxLvMeleeATK.Text = ((BaseMeleeATK + LvPMeleeATK * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleMeleeATK) / 100M).ToString("N2");
			labelMaxLvMeleeDEF.Text = ((BaseMeleeDEF + LvPMeleeDEF * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleMeleeDEF) / 100M).ToString("N2");
			labelMaxLvRangeATK.Text = ((BaseRangeATK + LvPRangeATK * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleRangeATK) / 100M).ToString("N2");
			labelMaxLvRangeDEF.Text = ((BaseRangeDEF + LvPRangeDEF * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleRangeDEF) / 100M).ToString("N2");
			labelMaxLvMagicATK.Text = ((BaseMagicATK + LvPMagicATK * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleMagicATK) / 100M).ToString("N2");
			labelMaxLvMagicDEF.Text = ((BaseMagicDEF + LvPMagicDEF * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleMagicDEF) / 100M).ToString("N2");
			labelMaxLvSPD.Text = MaxLvSPD.ToString("N2");
			labelMaxLvLuck.Text = (BaseLuck + LvPLuck * Math.Min(maxLv, 100M)).ToString("N0");
			labelMaxLvHIT.Text = (BaseHIT + LvPHIT * Math.Min(maxLv, 100M) + (decimal)Math.Sqrt((double)MaxLvSPD / 10D)).ToString("N0");
			labelMaxLvEVT.Text = (BaseEVT + LvPEVT * Math.Min(maxLv, 100M) + (decimal)Math.Sqrt((double)MaxLvSPD / 10D)).ToString("N0");
			labelMaxLvEXP.Text = ((BaseEXP + LvPEXP * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleEXP) / 100M).ToString("N0");
			labelMaxLvMoney.Text = ((BaseMoney + LvPMoney * maxLv) * Math.Min((decimal)(Math.Sqrt(maxLv) * 2D) + 100M, ScaleMoney) / 100M).ToString("N0");
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コントロール読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void TotalUnitInfomation_Load(object sender, EventArgs e) {
		}

		/// <summary>
		/// 最小Lv.に関する処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void labelMinLv_TextChanged(object sender, EventArgs e) {
			// 処理速度の都合で更新を停止する
			tableLayoutPanel1.Invalidate(true);

			// データベース再取得時の不具合回避
			if (labelMinLv.Text == "") {
				ref_f = 1;
				return;
			}

			minLv = long.Parse(labelMinLv.Text.Replace(",", ""));
			labelLvMin.Text = "Lv." + labelMinLv.Text;
		}

		/// <summary>
		/// 最大Lv.に関する処理。-1の処理に関する仕様
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void labelLv_TextChanged(object sender, EventArgs e) {
			// 処理速度の都合で更新を停止する
			tableLayoutPanel1.Invalidate(true);

			// データベース再取得時の不具合回避
			if (ref_f == 1)
				return;


			if (labelMaxLv.Text == "-1") {
				maxLv = Math.Max(long.Parse(labelMinLv.Text.Replace(",", "")), long.Parse(labelReqLv.Text.Replace(",", ""))) * 50L;
			} else {
				maxLv = long.Parse(labelMaxLv.Text.Replace(",", ""));
			}
			labelLvMax.Text = "Lv." + maxLv.ToString("N0");
		}

		/// <summary>
		/// ステータスの値が更新された時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void labelStatus_TextChanged(object sender, EventArgs e) {
			// 処理速度の都合で更新を停止する
			tableLayoutPanel1.Invalidate(true);

			// データベース再取得時の不具合回避
			if (ref_f == 1)
				return;

			Change_LvValue();
		}
	}
}
