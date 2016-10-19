using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit {
	partial class TotalUnitInfomation {
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.groupTotal = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelLevel = new System.Windows.Forms.Label();
			this.labelReqLvLabel = new System.Windows.Forms.Label();
			this.labelReqLv = new System.Windows.Forms.Label();
			this.labelMinLvLabel = new System.Windows.Forms.Label();
			this.labelMinLv = new System.Windows.Forms.Label();
			this.labelMaxLvLabel = new System.Windows.Forms.Label();
			this.labelMaxLv = new System.Windows.Forms.Label();
			this.labelBaseLabel = new System.Windows.Forms.Label();
			this.labelLvPLabel = new System.Windows.Forms.Label();
			this.labelCalcLabel = new System.Windows.Forms.Label();
			this.labelLv1 = new System.Windows.Forms.Label();
			this.labelLvMin = new System.Windows.Forms.Label();
			this.labelLvMax = new System.Windows.Forms.Label();
			this.labelHP = new System.Windows.Forms.Label();
			this.labelBaseHP = new System.Windows.Forms.Label();
			this.labelLvPHP = new System.Windows.Forms.Label();
			this.labelScaleHP = new System.Windows.Forms.Label();
			this.labelLv1HP = new System.Windows.Forms.Label();
			this.labelMaxLvHP = new System.Windows.Forms.Label();
			this.labelMinLvHP = new System.Windows.Forms.Label();
			this.labelMeleeATK = new System.Windows.Forms.Label();
			this.labelBaseMeleeATK = new System.Windows.Forms.Label();
			this.labelLvPMeleeATK = new System.Windows.Forms.Label();
			this.labelScaleMeleeATK = new System.Windows.Forms.Label();
			this.labelLv1MeleeATK = new System.Windows.Forms.Label();
			this.labelMinLvMeleeATK = new System.Windows.Forms.Label();
			this.labelMaxLvMeleeATK = new System.Windows.Forms.Label();
			this.labelMeleeDEF = new System.Windows.Forms.Label();
			this.labelBaseMeleeDEF = new System.Windows.Forms.Label();
			this.labelLvPMeleeDEF = new System.Windows.Forms.Label();
			this.labelScaleMeleeDEF = new System.Windows.Forms.Label();
			this.labelLv1MeleeDEF = new System.Windows.Forms.Label();
			this.labelMinLvMeleeDEF = new System.Windows.Forms.Label();
			this.labelMaxLvMeleeDEF = new System.Windows.Forms.Label();
			this.labelRangeATK = new System.Windows.Forms.Label();
			this.labelBaseRangeATK = new System.Windows.Forms.Label();
			this.labelLvPRangeATK = new System.Windows.Forms.Label();
			this.labelScaleRangeATK = new System.Windows.Forms.Label();
			this.labelLv1RangeATK = new System.Windows.Forms.Label();
			this.labelMinLvRangeATK = new System.Windows.Forms.Label();
			this.labelMaxLvRangeATK = new System.Windows.Forms.Label();
			this.labelRangeDEF = new System.Windows.Forms.Label();
			this.labelBaseRangeDEF = new System.Windows.Forms.Label();
			this.labelLvPRangeDEF = new System.Windows.Forms.Label();
			this.labelScaleRangeDEF = new System.Windows.Forms.Label();
			this.labelLv1RangeDEF = new System.Windows.Forms.Label();
			this.labelMinLvRangeDEF = new System.Windows.Forms.Label();
			this.labelMaxLvRangeDEF = new System.Windows.Forms.Label();
			this.labelMagicATK = new System.Windows.Forms.Label();
			this.labelBaseMagicATK = new System.Windows.Forms.Label();
			this.labelLvPMagicATK = new System.Windows.Forms.Label();
			this.labelScaleMagicATK = new System.Windows.Forms.Label();
			this.labelLv1MagicATK = new System.Windows.Forms.Label();
			this.labelMinLvMagicATK = new System.Windows.Forms.Label();
			this.labelMaxLvMagicATK = new System.Windows.Forms.Label();
			this.labelMagicDEF = new System.Windows.Forms.Label();
			this.labelBaseMagicDEF = new System.Windows.Forms.Label();
			this.labelLvPMagicDEF = new System.Windows.Forms.Label();
			this.labelScaleMagicDEF = new System.Windows.Forms.Label();
			this.labelLv1MagicDEF = new System.Windows.Forms.Label();
			this.labelMinLvMagicDEF = new System.Windows.Forms.Label();
			this.labelMaxLvMagicDEF = new System.Windows.Forms.Label();
			this.labelSPD = new System.Windows.Forms.Label();
			this.labelBaseSPD = new System.Windows.Forms.Label();
			this.labelLvPSPD = new System.Windows.Forms.Label();
			this.labelScaleSPD = new System.Windows.Forms.Label();
			this.labelLv1SPD = new System.Windows.Forms.Label();
			this.labelMinLvSPD = new System.Windows.Forms.Label();
			this.labelMaxLvSPD = new System.Windows.Forms.Label();
			this.labelLuck = new System.Windows.Forms.Label();
			this.labelBaseLuck = new System.Windows.Forms.Label();
			this.labelLvPLuck = new System.Windows.Forms.Label();
			this.labelLv1Luck = new System.Windows.Forms.Label();
			this.labelMinLvLuck = new System.Windows.Forms.Label();
			this.labelMaxLvLuck = new System.Windows.Forms.Label();
			this.labelHIT = new System.Windows.Forms.Label();
			this.labelBaseHIT = new System.Windows.Forms.Label();
			this.labelLvPHIT = new System.Windows.Forms.Label();
			this.labelLv1HIT = new System.Windows.Forms.Label();
			this.labelMinLvHIT = new System.Windows.Forms.Label();
			this.labelMaxLvHIT = new System.Windows.Forms.Label();
			this.labelEVT = new System.Windows.Forms.Label();
			this.labelBaseEVT = new System.Windows.Forms.Label();
			this.labelLvPEVT = new System.Windows.Forms.Label();
			this.labelLv1EVT = new System.Windows.Forms.Label();
			this.labelMinLvEVT = new System.Windows.Forms.Label();
			this.labelMaxLvEVT = new System.Windows.Forms.Label();
			this.labelEXP = new System.Windows.Forms.Label();
			this.labelBaseEXP = new System.Windows.Forms.Label();
			this.labelLvPEXP = new System.Windows.Forms.Label();
			this.labelScaleEXP = new System.Windows.Forms.Label();
			this.labelLv1EXP = new System.Windows.Forms.Label();
			this.labelMinLvEXP = new System.Windows.Forms.Label();
			this.labelMaxLvEXP = new System.Windows.Forms.Label();
			this.labelMoney = new System.Windows.Forms.Label();
			this.labelBaseMoney = new System.Windows.Forms.Label();
			this.labelLvPMoney = new System.Windows.Forms.Label();
			this.labelScaleMoney = new System.Windows.Forms.Label();
			this.labelLv1Money = new System.Windows.Forms.Label();
			this.labelMinLvMoney = new System.Windows.Forms.Label();
			this.labelUnitType = new System.Windows.Forms.Label();
			this.labelUnitTypeLabel = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelNameLabel = new System.Windows.Forms.Label();
			this.labelMaxLvMoney = new System.Windows.Forms.Label();
			this.groupTotal.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupTotal
			// 
			this.groupTotal.Controls.Add(this.tableLayoutPanel1);
			this.groupTotal.Controls.Add(this.labelUnitType);
			this.groupTotal.Controls.Add(this.labelUnitTypeLabel);
			this.groupTotal.Controls.Add(this.labelName);
			this.groupTotal.Controls.Add(this.labelNameLabel);
			this.groupTotal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupTotal.Location = new System.Drawing.Point(0, 0);
			this.groupTotal.Name = "groupTotal";
			this.groupTotal.Size = new System.Drawing.Size(1360, 800);
			this.groupTotal.TabIndex = 0;
			this.groupTotal.TabStop = false;
			this.groupTotal.Text = "Unit Infomation";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
			this.tableLayoutPanel1.Controls.Add(this.labelLevel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelReqLvLabel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelReqLv, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvLabel, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLv, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvLabel, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLv, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseLabel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPLabel, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelCalcLabel, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelLvMin, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelLvMax, 6, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelHP, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseHP, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPHP, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleHP, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1HP, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvHP, 6, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvHP, 5, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelMeleeATK, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseMeleeATK, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPMeleeATK, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleMeleeATK, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1MeleeATK, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvMeleeATK, 5, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvMeleeATK, 6, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelMeleeDEF, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseMeleeDEF, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPMeleeDEF, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleMeleeDEF, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1MeleeDEF, 4, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvMeleeDEF, 5, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvMeleeDEF, 6, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelRangeATK, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseRangeATK, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPRangeATK, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleRangeATK, 3, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1RangeATK, 4, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvRangeATK, 5, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvRangeATK, 6, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelRangeDEF, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseRangeDEF, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPRangeDEF, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleRangeDEF, 3, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1RangeDEF, 4, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvRangeDEF, 5, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvRangeDEF, 6, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelMagicATK, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseMagicATK, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPMagicATK, 2, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleMagicATK, 3, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1MagicATK, 4, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvMagicATK, 5, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvMagicATK, 6, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelMagicDEF, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseMagicDEF, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPMagicDEF, 2, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleMagicDEF, 3, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1MagicDEF, 4, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvMagicDEF, 5, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvMagicDEF, 6, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelSPD, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseSPD, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPSPD, 2, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleSPD, 3, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1SPD, 4, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvSPD, 5, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvSPD, 6, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelLuck, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseLuck, 1, 10);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPLuck, 2, 10);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1Luck, 4, 10);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvLuck, 5, 10);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvLuck, 6, 10);
			this.tableLayoutPanel1.Controls.Add(this.labelHIT, 0, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseHIT, 1, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPHIT, 2, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1HIT, 4, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvHIT, 5, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvHIT, 6, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelEVT, 0, 12);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseEVT, 1, 12);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPEVT, 2, 12);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1EVT, 4, 12);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvEVT, 5, 12);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvEVT, 6, 12);
			this.tableLayoutPanel1.Controls.Add(this.labelEXP, 0, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseEXP, 1, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPEXP, 2, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleEXP, 3, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1EXP, 4, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvEXP, 5, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvEXP, 6, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelMoney, 0, 14);
			this.tableLayoutPanel1.Controls.Add(this.labelBaseMoney, 1, 14);
			this.tableLayoutPanel1.Controls.Add(this.labelLvPMoney, 2, 14);
			this.tableLayoutPanel1.Controls.Add(this.labelScaleMoney, 3, 14);
			this.tableLayoutPanel1.Controls.Add(this.labelLv1Money, 4, 14);
			this.tableLayoutPanel1.Controls.Add(this.labelMinLvMoney, 5, 14);
			this.tableLayoutPanel1.Controls.Add(this.labelMaxLvMoney, 6, 14);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 100);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 15;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 316);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// labelLevel
			// 
			this.labelLevel.AutoSize = true;
			this.labelLevel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLevel.Location = new System.Drawing.Point(4, 1);
			this.labelLevel.Name = "labelLevel";
			this.labelLevel.Size = new System.Drawing.Size(63, 20);
			this.labelLevel.TabIndex = 0;
			this.labelLevel.Text = "Level";
			this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelReqLvLabel
			// 
			this.labelReqLvLabel.AutoSize = true;
			this.labelReqLvLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelReqLvLabel.Location = new System.Drawing.Point(74, 1);
			this.labelReqLvLabel.Name = "labelReqLvLabel";
			this.labelReqLvLabel.Size = new System.Drawing.Size(169, 20);
			this.labelReqLvLabel.TabIndex = 1;
			this.labelReqLvLabel.Text = "Req Lv.";
			this.labelReqLvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelReqLv
			// 
			this.labelReqLv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelReqLv.Location = new System.Drawing.Point(250, 1);
			this.labelReqLv.Name = "labelReqLv";
			this.labelReqLv.Size = new System.Drawing.Size(59, 20);
			this.labelReqLv.TabIndex = 2;
			this.labelReqLv.Text = "0";
			this.labelReqLv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelReqLv.TextChanged += new System.EventHandler(this.labelLv_TextChanged);
			// 
			// labelMinLvLabel
			// 
			this.labelMinLvLabel.AutoSize = true;
			this.labelMinLvLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvLabel.Location = new System.Drawing.Point(316, 1);
			this.labelMinLvLabel.Name = "labelMinLvLabel";
			this.labelMinLvLabel.Size = new System.Drawing.Size(64, 20);
			this.labelMinLvLabel.TabIndex = 3;
			this.labelMinLvLabel.Text = "Min Lv.";
			this.labelMinLvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMinLv
			// 
			this.labelMinLv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLv.Location = new System.Drawing.Point(387, 1);
			this.labelMinLv.Name = "labelMinLv";
			this.labelMinLv.Size = new System.Drawing.Size(169, 20);
			this.labelMinLv.TabIndex = 4;
			this.labelMinLv.Text = "0";
			this.labelMinLv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelMinLv.TextChanged += new System.EventHandler(this.labelMinLv_TextChanged);
			// 
			// labelMaxLvLabel
			// 
			this.labelMaxLvLabel.AutoSize = true;
			this.labelMaxLvLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvLabel.Location = new System.Drawing.Point(563, 1);
			this.labelMaxLvLabel.Name = "labelMaxLvLabel";
			this.labelMaxLvLabel.Size = new System.Drawing.Size(169, 20);
			this.labelMaxLvLabel.TabIndex = 5;
			this.labelMaxLvLabel.Text = "Max Lv.";
			this.labelMaxLvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMaxLv
			// 
			this.labelMaxLv.AutoSize = true;
			this.labelMaxLv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLv.Location = new System.Drawing.Point(739, 1);
			this.labelMaxLv.Name = "labelMaxLv";
			this.labelMaxLv.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLv.TabIndex = 6;
			this.labelMaxLv.Text = "0";
			this.labelMaxLv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelMaxLv.TextChanged += new System.EventHandler(this.labelLv_TextChanged);
			// 
			// labelBaseLabel
			// 
			this.labelBaseLabel.AutoSize = true;
			this.labelBaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseLabel.Location = new System.Drawing.Point(74, 22);
			this.labelBaseLabel.Name = "labelBaseLabel";
			this.labelBaseLabel.Size = new System.Drawing.Size(169, 20);
			this.labelBaseLabel.TabIndex = 7;
			this.labelBaseLabel.Text = "Base";
			this.labelBaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLvPLabel
			// 
			this.labelLvPLabel.AutoSize = true;
			this.labelLvPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPLabel.Location = new System.Drawing.Point(250, 22);
			this.labelLvPLabel.Name = "labelLvPLabel";
			this.labelLvPLabel.Size = new System.Drawing.Size(59, 20);
			this.labelLvPLabel.TabIndex = 8;
			this.labelLvPLabel.Text = "X / Lv.";
			this.labelLvPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCalcLabel
			// 
			this.labelCalcLabel.AutoSize = true;
			this.labelCalcLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCalcLabel.Location = new System.Drawing.Point(316, 22);
			this.labelCalcLabel.Name = "labelCalcLabel";
			this.labelCalcLabel.Size = new System.Drawing.Size(64, 20);
			this.labelCalcLabel.TabIndex = 9;
			this.labelCalcLabel.Text = "Rate";
			this.labelCalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLv1
			// 
			this.labelLv1.AutoSize = true;
			this.labelLv1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1.Location = new System.Drawing.Point(387, 22);
			this.labelLv1.Name = "labelLv1";
			this.labelLv1.Size = new System.Drawing.Size(169, 20);
			this.labelLv1.TabIndex = 10;
			this.labelLv1.Text = "Lv.1";
			this.labelLv1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLvMin
			// 
			this.labelLvMin.AutoSize = true;
			this.labelLvMin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvMin.Location = new System.Drawing.Point(563, 22);
			this.labelLvMin.Name = "labelLvMin";
			this.labelLvMin.Size = new System.Drawing.Size(169, 20);
			this.labelLvMin.TabIndex = 11;
			this.labelLvMin.Text = "Min Lv.";
			this.labelLvMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLvMax
			// 
			this.labelLvMax.AutoSize = true;
			this.labelLvMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvMax.Location = new System.Drawing.Point(739, 22);
			this.labelLvMax.Name = "labelLvMax";
			this.labelLvMax.Size = new System.Drawing.Size(174, 20);
			this.labelLvMax.TabIndex = 12;
			this.labelLvMax.Text = "Max Lv.";
			this.labelLvMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelHP
			// 
			this.labelHP.AutoSize = true;
			this.labelHP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelHP.Location = new System.Drawing.Point(4, 43);
			this.labelHP.Name = "labelHP";
			this.labelHP.Size = new System.Drawing.Size(63, 20);
			this.labelHP.TabIndex = 13;
			this.labelHP.Text = "HP";
			this.labelHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseHP
			// 
			this.labelBaseHP.AutoSize = true;
			this.labelBaseHP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseHP.Location = new System.Drawing.Point(74, 43);
			this.labelBaseHP.Name = "labelBaseHP";
			this.labelBaseHP.Size = new System.Drawing.Size(169, 20);
			this.labelBaseHP.TabIndex = 14;
			this.labelBaseHP.Text = "0.00";
			this.labelBaseHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseHP.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPHP
			// 
			this.labelLvPHP.AutoSize = true;
			this.labelLvPHP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPHP.Location = new System.Drawing.Point(250, 43);
			this.labelLvPHP.Name = "labelLvPHP";
			this.labelLvPHP.Size = new System.Drawing.Size(59, 20);
			this.labelLvPHP.TabIndex = 15;
			this.labelLvPHP.Text = "0.00";
			this.labelLvPHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPHP.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleHP
			// 
			this.labelScaleHP.AutoSize = true;
			this.labelScaleHP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleHP.Location = new System.Drawing.Point(316, 43);
			this.labelScaleHP.Name = "labelScaleHP";
			this.labelScaleHP.Size = new System.Drawing.Size(64, 20);
			this.labelScaleHP.TabIndex = 16;
			this.labelScaleHP.Text = "0.00";
			this.labelScaleHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleHP.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1HP
			// 
			this.labelLv1HP.AutoSize = true;
			this.labelLv1HP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1HP.Location = new System.Drawing.Point(387, 43);
			this.labelLv1HP.Name = "labelLv1HP";
			this.labelLv1HP.Size = new System.Drawing.Size(169, 20);
			this.labelLv1HP.TabIndex = 17;
			this.labelLv1HP.Text = "0.00";
			this.labelLv1HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvHP
			// 
			this.labelMinLvHP.AutoSize = true;
			this.labelMinLvHP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvHP.Location = new System.Drawing.Point(563, 43);
			this.labelMinLvHP.Name = "labelMinLvHP";
			this.labelMinLvHP.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvHP.TabIndex = 18;
			this.labelMinLvHP.Text = "0.00";
			this.labelMinLvHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvHP
			// 
			this.labelMaxLvHP.AutoSize = true;
			this.labelMaxLvHP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvHP.Location = new System.Drawing.Point(739, 43);
			this.labelMaxLvHP.Name = "labelMaxLvHP";
			this.labelMaxLvHP.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvHP.TabIndex = 19;
			this.labelMaxLvHP.Text = "0.00";
			this.labelMaxLvHP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMeleeATK
			// 
			this.labelMeleeATK.AutoSize = true;
			this.labelMeleeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeleeATK.Location = new System.Drawing.Point(4, 64);
			this.labelMeleeATK.Name = "labelMeleeATK";
			this.labelMeleeATK.Size = new System.Drawing.Size(63, 20);
			this.labelMeleeATK.TabIndex = 20;
			this.labelMeleeATK.Text = "Melee ATK";
			this.labelMeleeATK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseMeleeATK
			// 
			this.labelBaseMeleeATK.AutoSize = true;
			this.labelBaseMeleeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseMeleeATK.Location = new System.Drawing.Point(74, 64);
			this.labelBaseMeleeATK.Name = "labelBaseMeleeATK";
			this.labelBaseMeleeATK.Size = new System.Drawing.Size(169, 20);
			this.labelBaseMeleeATK.TabIndex = 21;
			this.labelBaseMeleeATK.Text = "0.00";
			this.labelBaseMeleeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseMeleeATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPMeleeATK
			// 
			this.labelLvPMeleeATK.AutoSize = true;
			this.labelLvPMeleeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPMeleeATK.Location = new System.Drawing.Point(250, 64);
			this.labelLvPMeleeATK.Name = "labelLvPMeleeATK";
			this.labelLvPMeleeATK.Size = new System.Drawing.Size(59, 20);
			this.labelLvPMeleeATK.TabIndex = 22;
			this.labelLvPMeleeATK.Text = "0.00";
			this.labelLvPMeleeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPMeleeATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleMeleeATK
			// 
			this.labelScaleMeleeATK.AutoSize = true;
			this.labelScaleMeleeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleMeleeATK.Location = new System.Drawing.Point(316, 64);
			this.labelScaleMeleeATK.Name = "labelScaleMeleeATK";
			this.labelScaleMeleeATK.Size = new System.Drawing.Size(64, 20);
			this.labelScaleMeleeATK.TabIndex = 23;
			this.labelScaleMeleeATK.Text = "0.00";
			this.labelScaleMeleeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleMeleeATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1MeleeATK
			// 
			this.labelLv1MeleeATK.AutoSize = true;
			this.labelLv1MeleeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1MeleeATK.Location = new System.Drawing.Point(387, 64);
			this.labelLv1MeleeATK.Name = "labelLv1MeleeATK";
			this.labelLv1MeleeATK.Size = new System.Drawing.Size(169, 20);
			this.labelLv1MeleeATK.TabIndex = 24;
			this.labelLv1MeleeATK.Text = "0.00";
			this.labelLv1MeleeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvMeleeATK
			// 
			this.labelMinLvMeleeATK.AutoSize = true;
			this.labelMinLvMeleeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvMeleeATK.Location = new System.Drawing.Point(563, 64);
			this.labelMinLvMeleeATK.Name = "labelMinLvMeleeATK";
			this.labelMinLvMeleeATK.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvMeleeATK.TabIndex = 25;
			this.labelMinLvMeleeATK.Text = "0.00";
			this.labelMinLvMeleeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvMeleeATK
			// 
			this.labelMaxLvMeleeATK.AutoSize = true;
			this.labelMaxLvMeleeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvMeleeATK.Location = new System.Drawing.Point(739, 64);
			this.labelMaxLvMeleeATK.Name = "labelMaxLvMeleeATK";
			this.labelMaxLvMeleeATK.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvMeleeATK.TabIndex = 26;
			this.labelMaxLvMeleeATK.Text = "0.00";
			this.labelMaxLvMeleeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMeleeDEF
			// 
			this.labelMeleeDEF.AutoSize = true;
			this.labelMeleeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMeleeDEF.Location = new System.Drawing.Point(4, 85);
			this.labelMeleeDEF.Name = "labelMeleeDEF";
			this.labelMeleeDEF.Size = new System.Drawing.Size(63, 20);
			this.labelMeleeDEF.TabIndex = 27;
			this.labelMeleeDEF.Text = "Melee DEF";
			this.labelMeleeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseMeleeDEF
			// 
			this.labelBaseMeleeDEF.AutoSize = true;
			this.labelBaseMeleeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseMeleeDEF.Location = new System.Drawing.Point(74, 85);
			this.labelBaseMeleeDEF.Name = "labelBaseMeleeDEF";
			this.labelBaseMeleeDEF.Size = new System.Drawing.Size(169, 20);
			this.labelBaseMeleeDEF.TabIndex = 28;
			this.labelBaseMeleeDEF.Text = "0.00";
			this.labelBaseMeleeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseMeleeDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPMeleeDEF
			// 
			this.labelLvPMeleeDEF.AutoSize = true;
			this.labelLvPMeleeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPMeleeDEF.Location = new System.Drawing.Point(250, 85);
			this.labelLvPMeleeDEF.Name = "labelLvPMeleeDEF";
			this.labelLvPMeleeDEF.Size = new System.Drawing.Size(59, 20);
			this.labelLvPMeleeDEF.TabIndex = 29;
			this.labelLvPMeleeDEF.Text = "0.00";
			this.labelLvPMeleeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPMeleeDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleMeleeDEF
			// 
			this.labelScaleMeleeDEF.AutoSize = true;
			this.labelScaleMeleeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleMeleeDEF.Location = new System.Drawing.Point(316, 85);
			this.labelScaleMeleeDEF.Name = "labelScaleMeleeDEF";
			this.labelScaleMeleeDEF.Size = new System.Drawing.Size(64, 20);
			this.labelScaleMeleeDEF.TabIndex = 30;
			this.labelScaleMeleeDEF.Text = "0.00";
			this.labelScaleMeleeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleMeleeDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1MeleeDEF
			// 
			this.labelLv1MeleeDEF.AutoSize = true;
			this.labelLv1MeleeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1MeleeDEF.Location = new System.Drawing.Point(387, 85);
			this.labelLv1MeleeDEF.Name = "labelLv1MeleeDEF";
			this.labelLv1MeleeDEF.Size = new System.Drawing.Size(169, 20);
			this.labelLv1MeleeDEF.TabIndex = 31;
			this.labelLv1MeleeDEF.Text = "0.00";
			this.labelLv1MeleeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvMeleeDEF
			// 
			this.labelMinLvMeleeDEF.AutoSize = true;
			this.labelMinLvMeleeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvMeleeDEF.Location = new System.Drawing.Point(563, 85);
			this.labelMinLvMeleeDEF.Name = "labelMinLvMeleeDEF";
			this.labelMinLvMeleeDEF.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvMeleeDEF.TabIndex = 32;
			this.labelMinLvMeleeDEF.Text = "0.00";
			this.labelMinLvMeleeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvMeleeDEF
			// 
			this.labelMaxLvMeleeDEF.AutoSize = true;
			this.labelMaxLvMeleeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvMeleeDEF.Location = new System.Drawing.Point(739, 85);
			this.labelMaxLvMeleeDEF.Name = "labelMaxLvMeleeDEF";
			this.labelMaxLvMeleeDEF.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvMeleeDEF.TabIndex = 33;
			this.labelMaxLvMeleeDEF.Text = "0.00";
			this.labelMaxLvMeleeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelRangeATK
			// 
			this.labelRangeATK.AutoSize = true;
			this.labelRangeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRangeATK.Location = new System.Drawing.Point(4, 106);
			this.labelRangeATK.Name = "labelRangeATK";
			this.labelRangeATK.Size = new System.Drawing.Size(63, 20);
			this.labelRangeATK.TabIndex = 34;
			this.labelRangeATK.Text = "Range ATK";
			this.labelRangeATK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseRangeATK
			// 
			this.labelBaseRangeATK.AutoSize = true;
			this.labelBaseRangeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseRangeATK.Location = new System.Drawing.Point(74, 106);
			this.labelBaseRangeATK.Name = "labelBaseRangeATK";
			this.labelBaseRangeATK.Size = new System.Drawing.Size(169, 20);
			this.labelBaseRangeATK.TabIndex = 35;
			this.labelBaseRangeATK.Text = "0.00";
			this.labelBaseRangeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseRangeATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPRangeATK
			// 
			this.labelLvPRangeATK.AutoSize = true;
			this.labelLvPRangeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPRangeATK.Location = new System.Drawing.Point(250, 106);
			this.labelLvPRangeATK.Name = "labelLvPRangeATK";
			this.labelLvPRangeATK.Size = new System.Drawing.Size(59, 20);
			this.labelLvPRangeATK.TabIndex = 36;
			this.labelLvPRangeATK.Text = "0.00";
			this.labelLvPRangeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPRangeATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleRangeATK
			// 
			this.labelScaleRangeATK.AutoSize = true;
			this.labelScaleRangeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleRangeATK.Location = new System.Drawing.Point(316, 106);
			this.labelScaleRangeATK.Name = "labelScaleRangeATK";
			this.labelScaleRangeATK.Size = new System.Drawing.Size(64, 20);
			this.labelScaleRangeATK.TabIndex = 37;
			this.labelScaleRangeATK.Text = "0.00";
			this.labelScaleRangeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleRangeATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1RangeATK
			// 
			this.labelLv1RangeATK.AutoSize = true;
			this.labelLv1RangeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1RangeATK.Location = new System.Drawing.Point(387, 106);
			this.labelLv1RangeATK.Name = "labelLv1RangeATK";
			this.labelLv1RangeATK.Size = new System.Drawing.Size(169, 20);
			this.labelLv1RangeATK.TabIndex = 38;
			this.labelLv1RangeATK.Text = "0.00";
			this.labelLv1RangeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvRangeATK
			// 
			this.labelMinLvRangeATK.AutoSize = true;
			this.labelMinLvRangeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvRangeATK.Location = new System.Drawing.Point(563, 106);
			this.labelMinLvRangeATK.Name = "labelMinLvRangeATK";
			this.labelMinLvRangeATK.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvRangeATK.TabIndex = 39;
			this.labelMinLvRangeATK.Text = "0.00";
			this.labelMinLvRangeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvRangeATK
			// 
			this.labelMaxLvRangeATK.AutoSize = true;
			this.labelMaxLvRangeATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvRangeATK.Location = new System.Drawing.Point(739, 106);
			this.labelMaxLvRangeATK.Name = "labelMaxLvRangeATK";
			this.labelMaxLvRangeATK.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvRangeATK.TabIndex = 40;
			this.labelMaxLvRangeATK.Text = "0.00";
			this.labelMaxLvRangeATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelRangeDEF
			// 
			this.labelRangeDEF.AutoSize = true;
			this.labelRangeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRangeDEF.Location = new System.Drawing.Point(4, 127);
			this.labelRangeDEF.Name = "labelRangeDEF";
			this.labelRangeDEF.Size = new System.Drawing.Size(63, 20);
			this.labelRangeDEF.TabIndex = 41;
			this.labelRangeDEF.Text = "Range DEF";
			this.labelRangeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseRangeDEF
			// 
			this.labelBaseRangeDEF.AutoSize = true;
			this.labelBaseRangeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseRangeDEF.Location = new System.Drawing.Point(74, 127);
			this.labelBaseRangeDEF.Name = "labelBaseRangeDEF";
			this.labelBaseRangeDEF.Size = new System.Drawing.Size(169, 20);
			this.labelBaseRangeDEF.TabIndex = 42;
			this.labelBaseRangeDEF.Text = "0.00";
			this.labelBaseRangeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseRangeDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPRangeDEF
			// 
			this.labelLvPRangeDEF.AutoSize = true;
			this.labelLvPRangeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPRangeDEF.Location = new System.Drawing.Point(250, 127);
			this.labelLvPRangeDEF.Name = "labelLvPRangeDEF";
			this.labelLvPRangeDEF.Size = new System.Drawing.Size(59, 20);
			this.labelLvPRangeDEF.TabIndex = 43;
			this.labelLvPRangeDEF.Text = "0.00";
			this.labelLvPRangeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPRangeDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleRangeDEF
			// 
			this.labelScaleRangeDEF.AutoSize = true;
			this.labelScaleRangeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleRangeDEF.Location = new System.Drawing.Point(316, 127);
			this.labelScaleRangeDEF.Name = "labelScaleRangeDEF";
			this.labelScaleRangeDEF.Size = new System.Drawing.Size(64, 20);
			this.labelScaleRangeDEF.TabIndex = 44;
			this.labelScaleRangeDEF.Text = "0.00";
			this.labelScaleRangeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleRangeDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1RangeDEF
			// 
			this.labelLv1RangeDEF.AutoSize = true;
			this.labelLv1RangeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1RangeDEF.Location = new System.Drawing.Point(387, 127);
			this.labelLv1RangeDEF.Name = "labelLv1RangeDEF";
			this.labelLv1RangeDEF.Size = new System.Drawing.Size(169, 20);
			this.labelLv1RangeDEF.TabIndex = 45;
			this.labelLv1RangeDEF.Text = "0.00";
			this.labelLv1RangeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvRangeDEF
			// 
			this.labelMinLvRangeDEF.AutoSize = true;
			this.labelMinLvRangeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvRangeDEF.Location = new System.Drawing.Point(563, 127);
			this.labelMinLvRangeDEF.Name = "labelMinLvRangeDEF";
			this.labelMinLvRangeDEF.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvRangeDEF.TabIndex = 46;
			this.labelMinLvRangeDEF.Text = "0.00";
			this.labelMinLvRangeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvRangeDEF
			// 
			this.labelMaxLvRangeDEF.AutoSize = true;
			this.labelMaxLvRangeDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvRangeDEF.Location = new System.Drawing.Point(739, 127);
			this.labelMaxLvRangeDEF.Name = "labelMaxLvRangeDEF";
			this.labelMaxLvRangeDEF.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvRangeDEF.TabIndex = 47;
			this.labelMaxLvRangeDEF.Text = "0.00";
			this.labelMaxLvRangeDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMagicATK
			// 
			this.labelMagicATK.AutoSize = true;
			this.labelMagicATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMagicATK.Location = new System.Drawing.Point(4, 148);
			this.labelMagicATK.Name = "labelMagicATK";
			this.labelMagicATK.Size = new System.Drawing.Size(63, 20);
			this.labelMagicATK.TabIndex = 48;
			this.labelMagicATK.Text = "Magic ATK";
			this.labelMagicATK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseMagicATK
			// 
			this.labelBaseMagicATK.AutoSize = true;
			this.labelBaseMagicATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseMagicATK.Location = new System.Drawing.Point(74, 148);
			this.labelBaseMagicATK.Name = "labelBaseMagicATK";
			this.labelBaseMagicATK.Size = new System.Drawing.Size(169, 20);
			this.labelBaseMagicATK.TabIndex = 49;
			this.labelBaseMagicATK.Text = "0.00";
			this.labelBaseMagicATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseMagicATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPMagicATK
			// 
			this.labelLvPMagicATK.AutoSize = true;
			this.labelLvPMagicATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPMagicATK.Location = new System.Drawing.Point(250, 148);
			this.labelLvPMagicATK.Name = "labelLvPMagicATK";
			this.labelLvPMagicATK.Size = new System.Drawing.Size(59, 20);
			this.labelLvPMagicATK.TabIndex = 50;
			this.labelLvPMagicATK.Text = "0.00";
			this.labelLvPMagicATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPMagicATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleMagicATK
			// 
			this.labelScaleMagicATK.AutoSize = true;
			this.labelScaleMagicATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleMagicATK.Location = new System.Drawing.Point(316, 148);
			this.labelScaleMagicATK.Name = "labelScaleMagicATK";
			this.labelScaleMagicATK.Size = new System.Drawing.Size(64, 20);
			this.labelScaleMagicATK.TabIndex = 51;
			this.labelScaleMagicATK.Text = "0.00";
			this.labelScaleMagicATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleMagicATK.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1MagicATK
			// 
			this.labelLv1MagicATK.AutoSize = true;
			this.labelLv1MagicATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1MagicATK.Location = new System.Drawing.Point(387, 148);
			this.labelLv1MagicATK.Name = "labelLv1MagicATK";
			this.labelLv1MagicATK.Size = new System.Drawing.Size(169, 20);
			this.labelLv1MagicATK.TabIndex = 52;
			this.labelLv1MagicATK.Text = "0.00";
			this.labelLv1MagicATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvMagicATK
			// 
			this.labelMinLvMagicATK.AutoSize = true;
			this.labelMinLvMagicATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvMagicATK.Location = new System.Drawing.Point(563, 148);
			this.labelMinLvMagicATK.Name = "labelMinLvMagicATK";
			this.labelMinLvMagicATK.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvMagicATK.TabIndex = 53;
			this.labelMinLvMagicATK.Text = "0.00";
			this.labelMinLvMagicATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvMagicATK
			// 
			this.labelMaxLvMagicATK.AutoSize = true;
			this.labelMaxLvMagicATK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvMagicATK.Location = new System.Drawing.Point(739, 148);
			this.labelMaxLvMagicATK.Name = "labelMaxLvMagicATK";
			this.labelMaxLvMagicATK.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvMagicATK.TabIndex = 54;
			this.labelMaxLvMagicATK.Text = "0.00";
			this.labelMaxLvMagicATK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMagicDEF
			// 
			this.labelMagicDEF.AutoSize = true;
			this.labelMagicDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMagicDEF.Location = new System.Drawing.Point(4, 169);
			this.labelMagicDEF.Name = "labelMagicDEF";
			this.labelMagicDEF.Size = new System.Drawing.Size(63, 20);
			this.labelMagicDEF.TabIndex = 55;
			this.labelMagicDEF.Text = "Magic DEF";
			this.labelMagicDEF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseMagicDEF
			// 
			this.labelBaseMagicDEF.AutoSize = true;
			this.labelBaseMagicDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseMagicDEF.Location = new System.Drawing.Point(74, 169);
			this.labelBaseMagicDEF.Name = "labelBaseMagicDEF";
			this.labelBaseMagicDEF.Size = new System.Drawing.Size(169, 20);
			this.labelBaseMagicDEF.TabIndex = 56;
			this.labelBaseMagicDEF.Text = "0.00";
			this.labelBaseMagicDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseMagicDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPMagicDEF
			// 
			this.labelLvPMagicDEF.AutoSize = true;
			this.labelLvPMagicDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPMagicDEF.Location = new System.Drawing.Point(250, 169);
			this.labelLvPMagicDEF.Name = "labelLvPMagicDEF";
			this.labelLvPMagicDEF.Size = new System.Drawing.Size(59, 20);
			this.labelLvPMagicDEF.TabIndex = 57;
			this.labelLvPMagicDEF.Text = "0.00";
			this.labelLvPMagicDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPMagicDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleMagicDEF
			// 
			this.labelScaleMagicDEF.AutoSize = true;
			this.labelScaleMagicDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleMagicDEF.Location = new System.Drawing.Point(316, 169);
			this.labelScaleMagicDEF.Name = "labelScaleMagicDEF";
			this.labelScaleMagicDEF.Size = new System.Drawing.Size(64, 20);
			this.labelScaleMagicDEF.TabIndex = 58;
			this.labelScaleMagicDEF.Text = "0.00";
			this.labelScaleMagicDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleMagicDEF.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1MagicDEF
			// 
			this.labelLv1MagicDEF.AutoSize = true;
			this.labelLv1MagicDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1MagicDEF.Location = new System.Drawing.Point(387, 169);
			this.labelLv1MagicDEF.Name = "labelLv1MagicDEF";
			this.labelLv1MagicDEF.Size = new System.Drawing.Size(169, 20);
			this.labelLv1MagicDEF.TabIndex = 59;
			this.labelLv1MagicDEF.Text = "0.00";
			this.labelLv1MagicDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvMagicDEF
			// 
			this.labelMinLvMagicDEF.AutoSize = true;
			this.labelMinLvMagicDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvMagicDEF.Location = new System.Drawing.Point(563, 169);
			this.labelMinLvMagicDEF.Name = "labelMinLvMagicDEF";
			this.labelMinLvMagicDEF.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvMagicDEF.TabIndex = 60;
			this.labelMinLvMagicDEF.Text = "0.00";
			this.labelMinLvMagicDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvMagicDEF
			// 
			this.labelMaxLvMagicDEF.AutoSize = true;
			this.labelMaxLvMagicDEF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvMagicDEF.Location = new System.Drawing.Point(739, 169);
			this.labelMaxLvMagicDEF.Name = "labelMaxLvMagicDEF";
			this.labelMaxLvMagicDEF.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvMagicDEF.TabIndex = 61;
			this.labelMaxLvMagicDEF.Text = "0.00";
			this.labelMaxLvMagicDEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelSPD
			// 
			this.labelSPD.AutoSize = true;
			this.labelSPD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSPD.Location = new System.Drawing.Point(4, 190);
			this.labelSPD.Name = "labelSPD";
			this.labelSPD.Size = new System.Drawing.Size(63, 20);
			this.labelSPD.TabIndex = 62;
			this.labelSPD.Text = "SPD";
			this.labelSPD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseSPD
			// 
			this.labelBaseSPD.AutoSize = true;
			this.labelBaseSPD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseSPD.Location = new System.Drawing.Point(74, 190);
			this.labelBaseSPD.Name = "labelBaseSPD";
			this.labelBaseSPD.Size = new System.Drawing.Size(169, 20);
			this.labelBaseSPD.TabIndex = 63;
			this.labelBaseSPD.Text = "0.00";
			this.labelBaseSPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseSPD.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPSPD
			// 
			this.labelLvPSPD.AutoSize = true;
			this.labelLvPSPD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPSPD.Location = new System.Drawing.Point(250, 190);
			this.labelLvPSPD.Name = "labelLvPSPD";
			this.labelLvPSPD.Size = new System.Drawing.Size(59, 20);
			this.labelLvPSPD.TabIndex = 64;
			this.labelLvPSPD.Text = "0.00";
			this.labelLvPSPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPSPD.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleSPD
			// 
			this.labelScaleSPD.AutoSize = true;
			this.labelScaleSPD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleSPD.Location = new System.Drawing.Point(316, 190);
			this.labelScaleSPD.Name = "labelScaleSPD";
			this.labelScaleSPD.Size = new System.Drawing.Size(64, 20);
			this.labelScaleSPD.TabIndex = 65;
			this.labelScaleSPD.Text = "0.00";
			this.labelScaleSPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleSPD.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1SPD
			// 
			this.labelLv1SPD.AutoSize = true;
			this.labelLv1SPD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1SPD.Location = new System.Drawing.Point(387, 190);
			this.labelLv1SPD.Name = "labelLv1SPD";
			this.labelLv1SPD.Size = new System.Drawing.Size(169, 20);
			this.labelLv1SPD.TabIndex = 66;
			this.labelLv1SPD.Text = "0.00";
			this.labelLv1SPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvSPD
			// 
			this.labelMinLvSPD.AutoSize = true;
			this.labelMinLvSPD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvSPD.Location = new System.Drawing.Point(563, 190);
			this.labelMinLvSPD.Name = "labelMinLvSPD";
			this.labelMinLvSPD.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvSPD.TabIndex = 67;
			this.labelMinLvSPD.Text = "0.00";
			this.labelMinLvSPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvSPD
			// 
			this.labelMaxLvSPD.AutoSize = true;
			this.labelMaxLvSPD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvSPD.Location = new System.Drawing.Point(739, 190);
			this.labelMaxLvSPD.Name = "labelMaxLvSPD";
			this.labelMaxLvSPD.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvSPD.TabIndex = 68;
			this.labelMaxLvSPD.Text = "0.00";
			this.labelMaxLvSPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelLuck
			// 
			this.labelLuck.AutoSize = true;
			this.labelLuck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLuck.Location = new System.Drawing.Point(4, 211);
			this.labelLuck.Name = "labelLuck";
			this.labelLuck.Size = new System.Drawing.Size(63, 20);
			this.labelLuck.TabIndex = 69;
			this.labelLuck.Text = "Luck";
			this.labelLuck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseLuck
			// 
			this.labelBaseLuck.AutoSize = true;
			this.labelBaseLuck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseLuck.Location = new System.Drawing.Point(74, 211);
			this.labelBaseLuck.Name = "labelBaseLuck";
			this.labelBaseLuck.Size = new System.Drawing.Size(169, 20);
			this.labelBaseLuck.TabIndex = 70;
			this.labelBaseLuck.Text = "0";
			this.labelBaseLuck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseLuck.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPLuck
			// 
			this.labelLvPLuck.AutoSize = true;
			this.labelLvPLuck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPLuck.Location = new System.Drawing.Point(250, 211);
			this.labelLvPLuck.Name = "labelLvPLuck";
			this.labelLvPLuck.Size = new System.Drawing.Size(59, 20);
			this.labelLvPLuck.TabIndex = 71;
			this.labelLvPLuck.Text = "0";
			this.labelLvPLuck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPLuck.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1Luck
			// 
			this.labelLv1Luck.AutoSize = true;
			this.labelLv1Luck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1Luck.Location = new System.Drawing.Point(387, 211);
			this.labelLv1Luck.Name = "labelLv1Luck";
			this.labelLv1Luck.Size = new System.Drawing.Size(169, 20);
			this.labelLv1Luck.TabIndex = 72;
			this.labelLv1Luck.Text = "0";
			this.labelLv1Luck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvLuck
			// 
			this.labelMinLvLuck.AutoSize = true;
			this.labelMinLvLuck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvLuck.Location = new System.Drawing.Point(563, 211);
			this.labelMinLvLuck.Name = "labelMinLvLuck";
			this.labelMinLvLuck.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvLuck.TabIndex = 73;
			this.labelMinLvLuck.Text = "0";
			this.labelMinLvLuck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvLuck
			// 
			this.labelMaxLvLuck.AutoSize = true;
			this.labelMaxLvLuck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvLuck.Location = new System.Drawing.Point(739, 211);
			this.labelMaxLvLuck.Name = "labelMaxLvLuck";
			this.labelMaxLvLuck.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvLuck.TabIndex = 74;
			this.labelMaxLvLuck.Text = "0";
			this.labelMaxLvLuck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelHIT
			// 
			this.labelHIT.AutoSize = true;
			this.labelHIT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelHIT.Location = new System.Drawing.Point(4, 232);
			this.labelHIT.Name = "labelHIT";
			this.labelHIT.Size = new System.Drawing.Size(63, 20);
			this.labelHIT.TabIndex = 75;
			this.labelHIT.Text = "HIT";
			this.labelHIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseHIT
			// 
			this.labelBaseHIT.AutoSize = true;
			this.labelBaseHIT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseHIT.Location = new System.Drawing.Point(74, 232);
			this.labelBaseHIT.Name = "labelBaseHIT";
			this.labelBaseHIT.Size = new System.Drawing.Size(169, 20);
			this.labelBaseHIT.TabIndex = 76;
			this.labelBaseHIT.Text = "0";
			this.labelBaseHIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseHIT.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPHIT
			// 
			this.labelLvPHIT.AutoSize = true;
			this.labelLvPHIT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPHIT.Location = new System.Drawing.Point(250, 232);
			this.labelLvPHIT.Name = "labelLvPHIT";
			this.labelLvPHIT.Size = new System.Drawing.Size(59, 20);
			this.labelLvPHIT.TabIndex = 77;
			this.labelLvPHIT.Text = "0";
			this.labelLvPHIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPHIT.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1HIT
			// 
			this.labelLv1HIT.AutoSize = true;
			this.labelLv1HIT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1HIT.Location = new System.Drawing.Point(387, 232);
			this.labelLv1HIT.Name = "labelLv1HIT";
			this.labelLv1HIT.Size = new System.Drawing.Size(169, 20);
			this.labelLv1HIT.TabIndex = 78;
			this.labelLv1HIT.Text = "0";
			this.labelLv1HIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvHIT
			// 
			this.labelMinLvHIT.AutoSize = true;
			this.labelMinLvHIT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvHIT.Location = new System.Drawing.Point(563, 232);
			this.labelMinLvHIT.Name = "labelMinLvHIT";
			this.labelMinLvHIT.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvHIT.TabIndex = 79;
			this.labelMinLvHIT.Text = "0";
			this.labelMinLvHIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvHIT
			// 
			this.labelMaxLvHIT.AutoSize = true;
			this.labelMaxLvHIT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvHIT.Location = new System.Drawing.Point(739, 232);
			this.labelMaxLvHIT.Name = "labelMaxLvHIT";
			this.labelMaxLvHIT.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvHIT.TabIndex = 80;
			this.labelMaxLvHIT.Text = "0";
			this.labelMaxLvHIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelEVT
			// 
			this.labelEVT.AutoSize = true;
			this.labelEVT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEVT.Location = new System.Drawing.Point(4, 253);
			this.labelEVT.Name = "labelEVT";
			this.labelEVT.Size = new System.Drawing.Size(63, 20);
			this.labelEVT.TabIndex = 81;
			this.labelEVT.Text = "EVT";
			this.labelEVT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseEVT
			// 
			this.labelBaseEVT.AutoSize = true;
			this.labelBaseEVT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseEVT.Location = new System.Drawing.Point(74, 253);
			this.labelBaseEVT.Name = "labelBaseEVT";
			this.labelBaseEVT.Size = new System.Drawing.Size(169, 20);
			this.labelBaseEVT.TabIndex = 82;
			this.labelBaseEVT.Text = "0";
			this.labelBaseEVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseEVT.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPEVT
			// 
			this.labelLvPEVT.AutoSize = true;
			this.labelLvPEVT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPEVT.Location = new System.Drawing.Point(250, 253);
			this.labelLvPEVT.Name = "labelLvPEVT";
			this.labelLvPEVT.Size = new System.Drawing.Size(59, 20);
			this.labelLvPEVT.TabIndex = 83;
			this.labelLvPEVT.Text = "0";
			this.labelLvPEVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPEVT.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1EVT
			// 
			this.labelLv1EVT.AutoSize = true;
			this.labelLv1EVT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1EVT.Location = new System.Drawing.Point(387, 253);
			this.labelLv1EVT.Name = "labelLv1EVT";
			this.labelLv1EVT.Size = new System.Drawing.Size(169, 20);
			this.labelLv1EVT.TabIndex = 84;
			this.labelLv1EVT.Text = "0";
			this.labelLv1EVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvEVT
			// 
			this.labelMinLvEVT.AutoSize = true;
			this.labelMinLvEVT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvEVT.Location = new System.Drawing.Point(563, 253);
			this.labelMinLvEVT.Name = "labelMinLvEVT";
			this.labelMinLvEVT.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvEVT.TabIndex = 85;
			this.labelMinLvEVT.Text = "0";
			this.labelMinLvEVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvEVT
			// 
			this.labelMaxLvEVT.AutoSize = true;
			this.labelMaxLvEVT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvEVT.Location = new System.Drawing.Point(739, 253);
			this.labelMaxLvEVT.Name = "labelMaxLvEVT";
			this.labelMaxLvEVT.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvEVT.TabIndex = 86;
			this.labelMaxLvEVT.Text = "0";
			this.labelMaxLvEVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelEXP
			// 
			this.labelEXP.AutoSize = true;
			this.labelEXP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEXP.Location = new System.Drawing.Point(4, 274);
			this.labelEXP.Name = "labelEXP";
			this.labelEXP.Size = new System.Drawing.Size(63, 20);
			this.labelEXP.TabIndex = 87;
			this.labelEXP.Text = "EXP";
			this.labelEXP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseEXP
			// 
			this.labelBaseEXP.AutoSize = true;
			this.labelBaseEXP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseEXP.Location = new System.Drawing.Point(74, 274);
			this.labelBaseEXP.Name = "labelBaseEXP";
			this.labelBaseEXP.Size = new System.Drawing.Size(169, 20);
			this.labelBaseEXP.TabIndex = 88;
			this.labelBaseEXP.Text = "0";
			this.labelBaseEXP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseEXP.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPEXP
			// 
			this.labelLvPEXP.AutoSize = true;
			this.labelLvPEXP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPEXP.Location = new System.Drawing.Point(250, 274);
			this.labelLvPEXP.Name = "labelLvPEXP";
			this.labelLvPEXP.Size = new System.Drawing.Size(59, 20);
			this.labelLvPEXP.TabIndex = 89;
			this.labelLvPEXP.Text = "0";
			this.labelLvPEXP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPEXP.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleEXP
			// 
			this.labelScaleEXP.AutoSize = true;
			this.labelScaleEXP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleEXP.Location = new System.Drawing.Point(316, 274);
			this.labelScaleEXP.Name = "labelScaleEXP";
			this.labelScaleEXP.Size = new System.Drawing.Size(64, 20);
			this.labelScaleEXP.TabIndex = 90;
			this.labelScaleEXP.Text = "0.00";
			this.labelScaleEXP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleEXP.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1EXP
			// 
			this.labelLv1EXP.AutoSize = true;
			this.labelLv1EXP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1EXP.Location = new System.Drawing.Point(387, 274);
			this.labelLv1EXP.Name = "labelLv1EXP";
			this.labelLv1EXP.Size = new System.Drawing.Size(169, 20);
			this.labelLv1EXP.TabIndex = 91;
			this.labelLv1EXP.Text = "0";
			this.labelLv1EXP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvEXP
			// 
			this.labelMinLvEXP.AutoSize = true;
			this.labelMinLvEXP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvEXP.Location = new System.Drawing.Point(563, 274);
			this.labelMinLvEXP.Name = "labelMinLvEXP";
			this.labelMinLvEXP.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvEXP.TabIndex = 92;
			this.labelMinLvEXP.Text = "0";
			this.labelMinLvEXP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxLvEXP
			// 
			this.labelMaxLvEXP.AutoSize = true;
			this.labelMaxLvEXP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvEXP.Location = new System.Drawing.Point(739, 274);
			this.labelMaxLvEXP.Name = "labelMaxLvEXP";
			this.labelMaxLvEXP.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvEXP.TabIndex = 93;
			this.labelMaxLvEXP.Text = "0";
			this.labelMaxLvEXP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMoney
			// 
			this.labelMoney.AutoSize = true;
			this.labelMoney.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMoney.Location = new System.Drawing.Point(4, 295);
			this.labelMoney.Name = "labelMoney";
			this.labelMoney.Size = new System.Drawing.Size(63, 20);
			this.labelMoney.TabIndex = 94;
			this.labelMoney.Text = "Money";
			this.labelMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBaseMoney
			// 
			this.labelBaseMoney.AutoSize = true;
			this.labelBaseMoney.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBaseMoney.Location = new System.Drawing.Point(74, 295);
			this.labelBaseMoney.Name = "labelBaseMoney";
			this.labelBaseMoney.Size = new System.Drawing.Size(169, 20);
			this.labelBaseMoney.TabIndex = 95;
			this.labelBaseMoney.Text = "0";
			this.labelBaseMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelBaseMoney.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLvPMoney
			// 
			this.labelLvPMoney.AutoSize = true;
			this.labelLvPMoney.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLvPMoney.Location = new System.Drawing.Point(250, 295);
			this.labelLvPMoney.Name = "labelLvPMoney";
			this.labelLvPMoney.Size = new System.Drawing.Size(59, 20);
			this.labelLvPMoney.TabIndex = 96;
			this.labelLvPMoney.Text = "0";
			this.labelLvPMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelLvPMoney.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelScaleMoney
			// 
			this.labelScaleMoney.AutoSize = true;
			this.labelScaleMoney.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelScaleMoney.Location = new System.Drawing.Point(316, 295);
			this.labelScaleMoney.Name = "labelScaleMoney";
			this.labelScaleMoney.Size = new System.Drawing.Size(64, 20);
			this.labelScaleMoney.TabIndex = 97;
			this.labelScaleMoney.Text = "0.00";
			this.labelScaleMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelScaleMoney.TextChanged += new System.EventHandler(this.labelStatus_TextChanged);
			// 
			// labelLv1Money
			// 
			this.labelLv1Money.AutoSize = true;
			this.labelLv1Money.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLv1Money.Location = new System.Drawing.Point(387, 295);
			this.labelLv1Money.Name = "labelLv1Money";
			this.labelLv1Money.Size = new System.Drawing.Size(169, 20);
			this.labelLv1Money.TabIndex = 98;
			this.labelLv1Money.Text = "0";
			this.labelLv1Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMinLvMoney
			// 
			this.labelMinLvMoney.AutoSize = true;
			this.labelMinLvMoney.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMinLvMoney.Location = new System.Drawing.Point(563, 295);
			this.labelMinLvMoney.Name = "labelMinLvMoney";
			this.labelMinLvMoney.Size = new System.Drawing.Size(169, 20);
			this.labelMinLvMoney.TabIndex = 99;
			this.labelMinLvMoney.Text = "0";
			this.labelMinLvMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelUnitType
			// 
			this.labelUnitType.AutoSize = true;
			this.labelUnitType.Location = new System.Drawing.Point(557, 40);
			this.labelUnitType.Name = "labelUnitType";
			this.labelUnitType.Size = new System.Drawing.Size(57, 12);
			this.labelUnitType.TabIndex = 3;
			this.labelUnitType.Text = "Test View";
			// 
			// labelUnitTypeLabel
			// 
			this.labelUnitTypeLabel.AutoSize = true;
			this.labelUnitTypeLabel.Location = new System.Drawing.Point(500, 40);
			this.labelUnitTypeLabel.Name = "labelUnitTypeLabel";
			this.labelUnitTypeLabel.Size = new System.Drawing.Size(57, 12);
			this.labelUnitTypeLabel.TabIndex = 2;
			this.labelUnitTypeLabel.Text = "種族タイプ:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 16F);
			this.labelName.Location = new System.Drawing.Point(95, 30);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(103, 22);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Test View";
			// 
			// labelNameLabel
			// 
			this.labelNameLabel.AutoSize = true;
			this.labelNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F);
			this.labelNameLabel.Location = new System.Drawing.Point(30, 30);
			this.labelNameLabel.Name = "labelNameLabel";
			this.labelNameLabel.Size = new System.Drawing.Size(65, 22);
			this.labelNameLabel.TabIndex = 0;
			this.labelNameLabel.Text = "Name:";
			// 
			// labelMaxLvMoney
			// 
			this.labelMaxLvMoney.AutoSize = true;
			this.labelMaxLvMoney.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxLvMoney.Location = new System.Drawing.Point(739, 295);
			this.labelMaxLvMoney.Name = "labelMaxLvMoney";
			this.labelMaxLvMoney.Size = new System.Drawing.Size(174, 20);
			this.labelMaxLvMoney.TabIndex = 100;
			this.labelMaxLvMoney.Text = "0";
			this.labelMaxLvMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TotalUnitInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupTotal);
			this.Name = "TotalUnitInfomation";
			this.Size = new System.Drawing.Size(1360, 800);
			this.Load += new System.EventHandler(this.TotalUnitInfomation_Load);
			this.groupTotal.ResumeLayout(false);
			this.groupTotal.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupTotal;
		private Label labelName;
		private Label labelNameLabel;
		private Label labelUnitType;
		private Label labelUnitTypeLabel;
		private TableLayoutPanel tableLayoutPanel1;
		private Label labelLevel;
		private Label labelReqLv;
		private Label labelReqLvLabel;
		private Label labelMinLvLabel;
		private Label labelMinLv;
		private Label labelMaxLvLabel;
		private Label labelMaxLv;
		private Label labelBaseLabel;
		private Label labelLvPLabel;
		private Label labelCalcLabel;
		private Label labelLv1;
		private Label labelLvMin;
		private Label labelLvMax;
		private Label labelHP;
		private Label labelBaseHP;
		private Label labelLvPHP;
		private Label labelScaleHP;
		private Label labelLv1HP;
		private Label labelMaxLvHP;
		private Label labelMinLvHP;
		private Label labelMeleeATK;
		private Label labelBaseMeleeATK;
		private Label labelLvPMeleeATK;
		private Label labelScaleMeleeATK;
		private Label labelLv1MeleeATK;
		private Label labelMinLvMeleeATK;
		private Label labelMaxLvMeleeATK;
		private Label labelMeleeDEF;
		private Label labelBaseMeleeDEF;
		private Label labelLvPMeleeDEF;
		private Label labelScaleMeleeDEF;
		private Label labelLv1MeleeDEF;
		private Label labelMinLvMeleeDEF;
		private Label labelMaxLvMeleeDEF;
		private Label labelRangeATK;
		private Label labelBaseRangeATK;
		private Label labelLvPRangeATK;
		private Label labelScaleRangeATK;
		private Label labelLv1RangeATK;
		private Label labelMinLvRangeATK;
		private Label labelMaxLvRangeATK;
		private Label labelRangeDEF;
		private Label labelBaseRangeDEF;
		private Label labelLvPRangeDEF;
		private Label labelScaleRangeDEF;
		private Label labelLv1RangeDEF;
		private Label labelMinLvRangeDEF;
		private Label labelMaxLvRangeDEF;
		private Label labelMagicATK;
		private Label labelBaseMagicATK;
		private Label labelLvPMagicATK;
		private Label labelScaleMagicATK;
		private Label labelLv1MagicATK;
		private Label labelMinLvMagicATK;
		private Label labelMaxLvMagicATK;
		private Label labelMagicDEF;
		private Label labelBaseMagicDEF;
		private Label labelLvPMagicDEF;
		private Label labelScaleMagicDEF;
		private Label labelLv1MagicDEF;
		private Label labelMinLvMagicDEF;
		private Label labelMaxLvMagicDEF;
		private Label labelSPD;
		private Label labelBaseSPD;
		private Label labelLvPSPD;
		private Label labelScaleSPD;
		private Label labelLv1SPD;
		private Label labelMinLvSPD;
		private Label labelMaxLvSPD;
		private Label labelLuck;
		private Label labelBaseLuck;
		private Label labelLvPLuck;
		private Label labelLv1Luck;
		private Label labelMinLvLuck;
		private Label labelMaxLvLuck;
		private Label labelHIT;
		private Label labelBaseHIT;
		private Label labelLvPHIT;
		private Label labelLv1HIT;
		private Label labelMinLvHIT;
		private Label labelMaxLvHIT;
		private Label labelEVT;
		private Label labelBaseEVT;
		private Label labelLvPEVT;
		private Label labelLv1EVT;
		private Label labelMinLvEVT;
		private Label labelMaxLvEVT;
		private Label labelEXP;
		private Label labelBaseEXP;
		private Label labelLvPEXP;
		private Label labelScaleEXP;
		private Label labelLv1EXP;
		private Label labelMinLvEXP;
		private Label labelMaxLvEXP;
		private Label labelMoney;
		private Label labelBaseMoney;
		private Label labelLvPMoney;
		private Label labelScaleMoney;
		private Label labelLv1Money;
		private Label labelMinLvMoney;
		private Label labelMaxLvMoney;
	}
}
