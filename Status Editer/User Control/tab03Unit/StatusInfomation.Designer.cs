﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Status_Editer.User_Control.tab03Unit {
	partial class StatusInfomation {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusInfomation));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.numericScaleMoney = new System.Windows.Forms.NumericUpDown();
			this.numericLvPEVT = new System.Windows.Forms.NumericUpDown();
			this.numericEVT = new System.Windows.Forms.NumericUpDown();
			this.numericLvPHIT = new System.Windows.Forms.NumericUpDown();
			this.numericScaleEXP = new System.Windows.Forms.NumericUpDown();
			this.numericHIT = new System.Windows.Forms.NumericUpDown();
			this.numericLvPLuck = new System.Windows.Forms.NumericUpDown();
			this.numericLuck = new System.Windows.Forms.NumericUpDown();
			this.numericScaleSPD = new System.Windows.Forms.NumericUpDown();
			this.numericScaleMagicDEF = new System.Windows.Forms.NumericUpDown();
			this.numericScaleMagicATK = new System.Windows.Forms.NumericUpDown();
			this.numericScaleRangeDEF = new System.Windows.Forms.NumericUpDown();
			this.numericScaleRangeATK = new System.Windows.Forms.NumericUpDown();
			this.numericScaleMeleeDEF = new System.Windows.Forms.NumericUpDown();
			this.numericScaleMeleeATK = new System.Windows.Forms.NumericUpDown();
			this.numericScaleHP = new System.Windows.Forms.NumericUpDown();
			this.numericMinLevel = new System.Windows.Forms.NumericUpDown();
			this.numericMaxLevel = new System.Windows.Forms.NumericUpDown();
			this.numericReqLv = new System.Windows.Forms.NumericUpDown();
			this.groupStatusInfo = new System.Windows.Forms.GroupBox();
			this.labelTestLv = new System.Windows.Forms.Label();
			this.numericTestLv = new System.Windows.Forms.NumericUpDown();
			this.chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupMoney = new System.Windows.Forms.GroupBox();
			this.labelMoney = new System.Windows.Forms.Label();
			this.numericMoney = new System.Windows.Forms.NumericUpDown();
			this.labelLvPMoney = new System.Windows.Forms.Label();
			this.numericLvPMoney = new System.Windows.Forms.NumericUpDown();
			this.labelScaleMoney = new System.Windows.Forms.Label();
			this.groupEXP = new System.Windows.Forms.GroupBox();
			this.labelEXP = new System.Windows.Forms.Label();
			this.numericEXP = new System.Windows.Forms.NumericUpDown();
			this.labelLvPEXP = new System.Windows.Forms.Label();
			this.numericLvPEXP = new System.Windows.Forms.NumericUpDown();
			this.labelScaleEXP = new System.Windows.Forms.Label();
			this.groupEVT = new System.Windows.Forms.GroupBox();
			this.labelEVT = new System.Windows.Forms.Label();
			this.labelLvPEVT = new System.Windows.Forms.Label();
			this.groupHIT = new System.Windows.Forms.GroupBox();
			this.labelHIT = new System.Windows.Forms.Label();
			this.labelLvPHIT = new System.Windows.Forms.Label();
			this.groupLuck = new System.Windows.Forms.GroupBox();
			this.labelLuck = new System.Windows.Forms.Label();
			this.labelLvPLuck = new System.Windows.Forms.Label();
			this.groupSPD = new System.Windows.Forms.GroupBox();
			this.labelSPD = new System.Windows.Forms.Label();
			this.numericSPD = new System.Windows.Forms.NumericUpDown();
			this.labelLvPSPD = new System.Windows.Forms.Label();
			this.numericLvPSPD = new System.Windows.Forms.NumericUpDown();
			this.labelScaleSPD = new System.Windows.Forms.Label();
			this.groupMagicDEF = new System.Windows.Forms.GroupBox();
			this.labelMagicDEF = new System.Windows.Forms.Label();
			this.numericMagicDEF = new System.Windows.Forms.NumericUpDown();
			this.labelLvPMagicDEF = new System.Windows.Forms.Label();
			this.numericLvPMagicDEF = new System.Windows.Forms.NumericUpDown();
			this.labelScaleMagicDEF = new System.Windows.Forms.Label();
			this.groupMagicATK = new System.Windows.Forms.GroupBox();
			this.numericMagicATK = new System.Windows.Forms.NumericUpDown();
			this.labelMagicATK = new System.Windows.Forms.Label();
			this.labelLvPMagicATK = new System.Windows.Forms.Label();
			this.numericLvPMagicATK = new System.Windows.Forms.NumericUpDown();
			this.labelScaleMagicATK = new System.Windows.Forms.Label();
			this.groupRangeDEF = new System.Windows.Forms.GroupBox();
			this.numericRangeDEF = new System.Windows.Forms.NumericUpDown();
			this.labelRangeDEF = new System.Windows.Forms.Label();
			this.labelLvPRangeDEF = new System.Windows.Forms.Label();
			this.numericLvPRangeDEF = new System.Windows.Forms.NumericUpDown();
			this.labelScaleRangeDEF = new System.Windows.Forms.Label();
			this.groupRangeATK = new System.Windows.Forms.GroupBox();
			this.numericRangeATK = new System.Windows.Forms.NumericUpDown();
			this.labelRangeATK = new System.Windows.Forms.Label();
			this.labelLvPRangeATK = new System.Windows.Forms.Label();
			this.numericLvPRangeATK = new System.Windows.Forms.NumericUpDown();
			this.labelScaleRangeATK = new System.Windows.Forms.Label();
			this.groupMeleeDEF = new System.Windows.Forms.GroupBox();
			this.numericMeleeDEF = new System.Windows.Forms.NumericUpDown();
			this.labelMeleeDEF = new System.Windows.Forms.Label();
			this.labelLvPMeleeDEF = new System.Windows.Forms.Label();
			this.numericLvPMeleeDEF = new System.Windows.Forms.NumericUpDown();
			this.labelScaleDEF = new System.Windows.Forms.Label();
			this.groupMeleeATK = new System.Windows.Forms.GroupBox();
			this.numericMeleeATK = new System.Windows.Forms.NumericUpDown();
			this.labelMeleeATK = new System.Windows.Forms.Label();
			this.labelLvPMeleeATK = new System.Windows.Forms.Label();
			this.numericLvPMeleeATK = new System.Windows.Forms.NumericUpDown();
			this.labelScaleATK = new System.Windows.Forms.Label();
			this.groupTP = new System.Windows.Forms.GroupBox();
			this.numericTP = new System.Windows.Forms.NumericUpDown();
			this.labelTP = new System.Windows.Forms.Label();
			this.labelMaxTP = new System.Windows.Forms.Label();
			this.numericMaxTP = new System.Windows.Forms.NumericUpDown();
			this.groupHP = new System.Windows.Forms.GroupBox();
			this.numericHP = new System.Windows.Forms.NumericUpDown();
			this.labelHP = new System.Windows.Forms.Label();
			this.labelLvPHP = new System.Windows.Forms.Label();
			this.numericLvPHP = new System.Windows.Forms.NumericUpDown();
			this.labelScaleHP = new System.Windows.Forms.Label();
			this.groupLv = new System.Windows.Forms.GroupBox();
			this.labelReqLv = new System.Windows.Forms.Label();
			this.labelMinLevel = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.labelMaxLevel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMoney)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPEVT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEVT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPHIT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleEXP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericHIT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPLuck)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLuck)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleSPD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMagicDEF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMagicATK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleRangeDEF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleRangeATK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMeleeDEF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMeleeATK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleHP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMinLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericReqLv)).BeginInit();
			this.groupStatusInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericTestLv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartStatus)).BeginInit();
			this.groupMoney.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMoney)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMoney)).BeginInit();
			this.groupEXP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericEXP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPEXP)).BeginInit();
			this.groupEVT.SuspendLayout();
			this.groupHIT.SuspendLayout();
			this.groupLuck.SuspendLayout();
			this.groupSPD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericSPD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPSPD)).BeginInit();
			this.groupMagicDEF.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMagicDEF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMagicDEF)).BeginInit();
			this.groupMagicATK.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMagicATK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMagicATK)).BeginInit();
			this.groupRangeDEF.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRangeDEF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPRangeDEF)).BeginInit();
			this.groupRangeATK.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRangeATK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPRangeATK)).BeginInit();
			this.groupMeleeDEF.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMeleeDEF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMeleeDEF)).BeginInit();
			this.groupMeleeATK.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMeleeATK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMeleeATK)).BeginInit();
			this.groupTP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericTP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxTP)).BeginInit();
			this.groupHP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericHP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPHP)).BeginInit();
			this.groupLv.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolTipInfo
			// 
			this.toolTipInfo.AutoPopDelay = 50000;
			this.toolTipInfo.InitialDelay = 500;
			this.toolTipInfo.IsBalloon = true;
			this.toolTipInfo.ReshowDelay = 100;
			this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipInfo.ToolTipTitle = "Infomation";
			// 
			// numericScaleMoney
			// 
			this.numericScaleMoney.DecimalPlaces = 2;
			this.numericScaleMoney.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleMoney, "numericScaleMoney");
			this.numericScaleMoney.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleMoney.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleMoney.Name = "numericScaleMoney";
			this.toolTipInfo.SetToolTip(this.numericScaleMoney, resources.GetString("numericScaleMoney.ToolTip"));
			this.numericScaleMoney.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// numericLvPEVT
			// 
			resources.ApplyResources(this.numericLvPEVT, "numericLvPEVT");
			this.numericLvPEVT.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericLvPEVT.Name = "numericLvPEVT";
			this.toolTipInfo.SetToolTip(this.numericLvPEVT, resources.GetString("numericLvPEVT.ToolTip"));
			// 
			// numericEVT
			// 
			this.numericEVT.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericEVT, "numericEVT");
			this.numericEVT.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.numericEVT.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
			this.numericEVT.Name = "numericEVT";
			this.toolTipInfo.SetToolTip(this.numericEVT, resources.GetString("numericEVT.ToolTip"));
			this.numericEVT.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// numericLvPHIT
			// 
			resources.ApplyResources(this.numericLvPHIT, "numericLvPHIT");
			this.numericLvPHIT.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericLvPHIT.Name = "numericLvPHIT";
			this.toolTipInfo.SetToolTip(this.numericLvPHIT, resources.GetString("numericLvPHIT.ToolTip"));
			// 
			// numericScaleEXP
			// 
			this.numericScaleEXP.DecimalPlaces = 2;
			this.numericScaleEXP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleEXP, "numericScaleEXP");
			this.numericScaleEXP.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleEXP.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleEXP.Name = "numericScaleEXP";
			this.toolTipInfo.SetToolTip(this.numericScaleEXP, resources.GetString("numericScaleEXP.ToolTip"));
			this.numericScaleEXP.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// numericHIT
			// 
			this.numericHIT.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericHIT, "numericHIT");
			this.numericHIT.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.numericHIT.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
			this.numericHIT.Name = "numericHIT";
			this.toolTipInfo.SetToolTip(this.numericHIT, resources.GetString("numericHIT.ToolTip"));
			this.numericHIT.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// numericLvPLuck
			// 
			resources.ApplyResources(this.numericLvPLuck, "numericLvPLuck");
			this.numericLvPLuck.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericLvPLuck.Name = "numericLvPLuck";
			this.toolTipInfo.SetToolTip(this.numericLvPLuck, resources.GetString("numericLvPLuck.ToolTip"));
			// 
			// numericLuck
			// 
			this.numericLuck.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericLuck, "numericLuck");
			this.numericLuck.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.numericLuck.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
			this.numericLuck.Name = "numericLuck";
			this.toolTipInfo.SetToolTip(this.numericLuck, resources.GetString("numericLuck.ToolTip"));
			this.numericLuck.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// numericScaleSPD
			// 
			this.numericScaleSPD.DecimalPlaces = 2;
			this.numericScaleSPD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleSPD, "numericScaleSPD");
			this.numericScaleSPD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleSPD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleSPD.Name = "numericScaleSPD";
			this.toolTipInfo.SetToolTip(this.numericScaleSPD, resources.GetString("numericScaleSPD.ToolTip"));
			this.numericScaleSPD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericScaleSPD.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// numericScaleMagicDEF
			// 
			this.numericScaleMagicDEF.DecimalPlaces = 2;
			this.numericScaleMagicDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleMagicDEF, "numericScaleMagicDEF");
			this.numericScaleMagicDEF.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleMagicDEF.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleMagicDEF.Name = "numericScaleMagicDEF";
			this.toolTipInfo.SetToolTip(this.numericScaleMagicDEF, resources.GetString("numericScaleMagicDEF.ToolTip"));
			this.numericScaleMagicDEF.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericScaleMagicDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// numericScaleMagicATK
			// 
			this.numericScaleMagicATK.DecimalPlaces = 2;
			this.numericScaleMagicATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleMagicATK, "numericScaleMagicATK");
			this.numericScaleMagicATK.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleMagicATK.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleMagicATK.Name = "numericScaleMagicATK";
			this.toolTipInfo.SetToolTip(this.numericScaleMagicATK, resources.GetString("numericScaleMagicATK.ToolTip"));
			this.numericScaleMagicATK.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericScaleMagicATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// numericScaleRangeDEF
			// 
			this.numericScaleRangeDEF.DecimalPlaces = 2;
			this.numericScaleRangeDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleRangeDEF, "numericScaleRangeDEF");
			this.numericScaleRangeDEF.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleRangeDEF.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleRangeDEF.Name = "numericScaleRangeDEF";
			this.toolTipInfo.SetToolTip(this.numericScaleRangeDEF, resources.GetString("numericScaleRangeDEF.ToolTip"));
			this.numericScaleRangeDEF.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericScaleRangeDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// numericScaleRangeATK
			// 
			this.numericScaleRangeATK.DecimalPlaces = 2;
			this.numericScaleRangeATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleRangeATK, "numericScaleRangeATK");
			this.numericScaleRangeATK.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleRangeATK.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleRangeATK.Name = "numericScaleRangeATK";
			this.toolTipInfo.SetToolTip(this.numericScaleRangeATK, resources.GetString("numericScaleRangeATK.ToolTip"));
			this.numericScaleRangeATK.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericScaleRangeATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// numericScaleMeleeDEF
			// 
			this.numericScaleMeleeDEF.DecimalPlaces = 2;
			this.numericScaleMeleeDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleMeleeDEF, "numericScaleMeleeDEF");
			this.numericScaleMeleeDEF.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleMeleeDEF.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleMeleeDEF.Name = "numericScaleMeleeDEF";
			this.toolTipInfo.SetToolTip(this.numericScaleMeleeDEF, resources.GetString("numericScaleMeleeDEF.ToolTip"));
			this.numericScaleMeleeDEF.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericScaleMeleeDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// numericScaleMeleeATK
			// 
			this.numericScaleMeleeATK.DecimalPlaces = 2;
			this.numericScaleMeleeATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleMeleeATK, "numericScaleMeleeATK");
			this.numericScaleMeleeATK.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleMeleeATK.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleMeleeATK.Name = "numericScaleMeleeATK";
			this.toolTipInfo.SetToolTip(this.numericScaleMeleeATK, resources.GetString("numericScaleMeleeATK.ToolTip"));
			this.numericScaleMeleeATK.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericScaleMeleeATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// numericScaleHP
			// 
			this.numericScaleHP.DecimalPlaces = 2;
			this.numericScaleHP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericScaleHP, "numericScaleHP");
			this.numericScaleHP.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
			this.numericScaleHP.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericScaleHP.Name = "numericScaleHP";
			this.toolTipInfo.SetToolTip(this.numericScaleHP, resources.GetString("numericScaleHP.ToolTip"));
			this.numericScaleHP.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// numericMinLevel
			// 
			resources.ApplyResources(this.numericMinLevel, "numericMinLevel");
			this.numericMinLevel.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numericMinLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMinLevel.Name = "numericMinLevel";
			this.toolTipInfo.SetToolTip(this.numericMinLevel, resources.GetString("numericMinLevel.ToolTip"));
			this.numericMinLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMinLevel.ValueChanged += new System.EventHandler(this.numericMinLevel_ValueChanged);
			// 
			// numericMaxLevel
			// 
			resources.ApplyResources(this.numericMaxLevel, "numericMaxLevel");
			this.numericMaxLevel.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
			this.numericMaxLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericMaxLevel.Name = "numericMaxLevel";
			this.toolTipInfo.SetToolTip(this.numericMaxLevel, resources.GetString("numericMaxLevel.ToolTip"));
			this.numericMaxLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			// 
			// numericReqLv
			// 
			resources.ApplyResources(this.numericReqLv, "numericReqLv");
			this.numericReqLv.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numericReqLv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericReqLv.Name = "numericReqLv";
			this.toolTipInfo.SetToolTip(this.numericReqLv, resources.GetString("numericReqLv.ToolTip"));
			this.numericReqLv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupStatusInfo
			// 
			this.groupStatusInfo.Controls.Add(this.labelTestLv);
			this.groupStatusInfo.Controls.Add(this.numericTestLv);
			this.groupStatusInfo.Controls.Add(this.chartStatus);
			this.groupStatusInfo.Controls.Add(this.groupMoney);
			this.groupStatusInfo.Controls.Add(this.groupEXP);
			this.groupStatusInfo.Controls.Add(this.groupEVT);
			this.groupStatusInfo.Controls.Add(this.groupHIT);
			this.groupStatusInfo.Controls.Add(this.groupLuck);
			this.groupStatusInfo.Controls.Add(this.groupSPD);
			this.groupStatusInfo.Controls.Add(this.groupMagicDEF);
			this.groupStatusInfo.Controls.Add(this.groupMagicATK);
			this.groupStatusInfo.Controls.Add(this.groupRangeDEF);
			this.groupStatusInfo.Controls.Add(this.groupRangeATK);
			this.groupStatusInfo.Controls.Add(this.groupMeleeDEF);
			this.groupStatusInfo.Controls.Add(this.groupMeleeATK);
			this.groupStatusInfo.Controls.Add(this.groupTP);
			this.groupStatusInfo.Controls.Add(this.groupHP);
			this.groupStatusInfo.Controls.Add(this.groupLv);
			resources.ApplyResources(this.groupStatusInfo, "groupStatusInfo");
			this.groupStatusInfo.Name = "groupStatusInfo";
			this.groupStatusInfo.TabStop = false;
			// 
			// labelTestLv
			// 
			resources.ApplyResources(this.labelTestLv, "labelTestLv");
			this.labelTestLv.Name = "labelTestLv";
			// 
			// numericTestLv
			// 
			resources.ApplyResources(this.numericTestLv, "numericTestLv");
			this.numericTestLv.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
			this.numericTestLv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericTestLv.Name = "numericTestLv";
			this.numericTestLv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericTestLv.ValueChanged += new System.EventHandler(this.numericTestLv_ValueChanged);
			// 
			// chartStatus
			// 
			this.chartStatus.BackColor = System.Drawing.Color.Transparent;
			chartArea1.AxisY.MaximumAutoSize = 90F;
			chartArea1.Name = "ChartArea1";
			this.chartStatus.ChartAreas.Add(chartArea1);
			resources.ApplyResources(this.chartStatus, "chartStatus");
			this.chartStatus.Name = "chartStatus";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
			series1.Name = "Series1";
			this.chartStatus.Series.Add(series1);
			title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title1.Name = "ChartTitle";
			title1.Text = "Status Rader Chart";
			this.chartStatus.Titles.Add(title1);
			// 
			// groupMoney
			// 
			this.groupMoney.Controls.Add(this.labelMoney);
			this.groupMoney.Controls.Add(this.numericMoney);
			this.groupMoney.Controls.Add(this.labelLvPMoney);
			this.groupMoney.Controls.Add(this.numericLvPMoney);
			this.groupMoney.Controls.Add(this.labelScaleMoney);
			this.groupMoney.Controls.Add(this.numericScaleMoney);
			resources.ApplyResources(this.groupMoney, "groupMoney");
			this.groupMoney.Name = "groupMoney";
			this.groupMoney.TabStop = false;
			// 
			// labelMoney
			// 
			resources.ApplyResources(this.labelMoney, "labelMoney");
			this.labelMoney.Name = "labelMoney";
			// 
			// numericMoney
			// 
			this.numericMoney.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericMoney, "numericMoney");
			this.numericMoney.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
			this.numericMoney.Name = "numericMoney";
			this.numericMoney.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// labelLvPMoney
			// 
			resources.ApplyResources(this.labelLvPMoney, "labelLvPMoney");
			this.labelLvPMoney.Name = "labelLvPMoney";
			// 
			// numericLvPMoney
			// 
			this.numericLvPMoney.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericLvPMoney, "numericLvPMoney");
			this.numericLvPMoney.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericLvPMoney.Name = "numericLvPMoney";
			this.numericLvPMoney.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// labelScaleMoney
			// 
			resources.ApplyResources(this.labelScaleMoney, "labelScaleMoney");
			this.labelScaleMoney.Name = "labelScaleMoney";
			// 
			// groupEXP
			// 
			this.groupEXP.Controls.Add(this.labelEXP);
			this.groupEXP.Controls.Add(this.numericEXP);
			this.groupEXP.Controls.Add(this.labelLvPEXP);
			this.groupEXP.Controls.Add(this.numericLvPEXP);
			this.groupEXP.Controls.Add(this.labelScaleEXP);
			this.groupEXP.Controls.Add(this.numericScaleEXP);
			resources.ApplyResources(this.groupEXP, "groupEXP");
			this.groupEXP.Name = "groupEXP";
			this.groupEXP.TabStop = false;
			// 
			// labelEXP
			// 
			resources.ApplyResources(this.labelEXP, "labelEXP");
			this.labelEXP.Name = "labelEXP";
			// 
			// numericEXP
			// 
			this.numericEXP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericEXP, "numericEXP");
			this.numericEXP.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
			this.numericEXP.Name = "numericEXP";
			this.numericEXP.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// labelLvPEXP
			// 
			resources.ApplyResources(this.labelLvPEXP, "labelLvPEXP");
			this.labelLvPEXP.Name = "labelLvPEXP";
			// 
			// numericLvPEXP
			// 
			this.numericLvPEXP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericLvPEXP, "numericLvPEXP");
			this.numericLvPEXP.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericLvPEXP.Name = "numericLvPEXP";
			this.numericLvPEXP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// labelScaleEXP
			// 
			resources.ApplyResources(this.labelScaleEXP, "labelScaleEXP");
			this.labelScaleEXP.Name = "labelScaleEXP";
			// 
			// groupEVT
			// 
			this.groupEVT.Controls.Add(this.labelEVT);
			this.groupEVT.Controls.Add(this.numericEVT);
			this.groupEVT.Controls.Add(this.labelLvPEVT);
			this.groupEVT.Controls.Add(this.numericLvPEVT);
			resources.ApplyResources(this.groupEVT, "groupEVT");
			this.groupEVT.Name = "groupEVT";
			this.groupEVT.TabStop = false;
			// 
			// labelEVT
			// 
			resources.ApplyResources(this.labelEVT, "labelEVT");
			this.labelEVT.Name = "labelEVT";
			// 
			// labelLvPEVT
			// 
			resources.ApplyResources(this.labelLvPEVT, "labelLvPEVT");
			this.labelLvPEVT.Name = "labelLvPEVT";
			// 
			// groupHIT
			// 
			this.groupHIT.Controls.Add(this.labelHIT);
			this.groupHIT.Controls.Add(this.numericHIT);
			this.groupHIT.Controls.Add(this.labelLvPHIT);
			this.groupHIT.Controls.Add(this.numericLvPHIT);
			resources.ApplyResources(this.groupHIT, "groupHIT");
			this.groupHIT.Name = "groupHIT";
			this.groupHIT.TabStop = false;
			// 
			// labelHIT
			// 
			resources.ApplyResources(this.labelHIT, "labelHIT");
			this.labelHIT.Name = "labelHIT";
			// 
			// labelLvPHIT
			// 
			resources.ApplyResources(this.labelLvPHIT, "labelLvPHIT");
			this.labelLvPHIT.Name = "labelLvPHIT";
			// 
			// groupLuck
			// 
			this.groupLuck.Controls.Add(this.labelLuck);
			this.groupLuck.Controls.Add(this.numericLuck);
			this.groupLuck.Controls.Add(this.labelLvPLuck);
			this.groupLuck.Controls.Add(this.numericLvPLuck);
			resources.ApplyResources(this.groupLuck, "groupLuck");
			this.groupLuck.Name = "groupLuck";
			this.groupLuck.TabStop = false;
			// 
			// labelLuck
			// 
			resources.ApplyResources(this.labelLuck, "labelLuck");
			this.labelLuck.Name = "labelLuck";
			// 
			// labelLvPLuck
			// 
			resources.ApplyResources(this.labelLvPLuck, "labelLvPLuck");
			this.labelLvPLuck.Name = "labelLvPLuck";
			// 
			// groupSPD
			// 
			this.groupSPD.Controls.Add(this.numericScaleSPD);
			this.groupSPD.Controls.Add(this.labelSPD);
			this.groupSPD.Controls.Add(this.numericSPD);
			this.groupSPD.Controls.Add(this.labelLvPSPD);
			this.groupSPD.Controls.Add(this.numericLvPSPD);
			this.groupSPD.Controls.Add(this.labelScaleSPD);
			resources.ApplyResources(this.groupSPD, "groupSPD");
			this.groupSPD.Name = "groupSPD";
			this.groupSPD.TabStop = false;
			// 
			// labelSPD
			// 
			resources.ApplyResources(this.labelSPD, "labelSPD");
			this.labelSPD.Name = "labelSPD";
			// 
			// numericSPD
			// 
			this.numericSPD.DecimalPlaces = 2;
			this.numericSPD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericSPD, "numericSPD");
			this.numericSPD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericSPD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericSPD.Name = "numericSPD";
			this.numericSPD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericSPD.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelLvPSPD
			// 
			resources.ApplyResources(this.labelLvPSPD, "labelLvPSPD");
			this.labelLvPSPD.Name = "labelLvPSPD";
			// 
			// numericLvPSPD
			// 
			this.numericLvPSPD.DecimalPlaces = 2;
			this.numericLvPSPD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			resources.ApplyResources(this.numericLvPSPD, "numericLvPSPD");
			this.numericLvPSPD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
			this.numericLvPSPD.Name = "numericLvPSPD";
			this.numericLvPSPD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericLvPSPD.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelScaleSPD
			// 
			resources.ApplyResources(this.labelScaleSPD, "labelScaleSPD");
			this.labelScaleSPD.Name = "labelScaleSPD";
			// 
			// groupMagicDEF
			// 
			this.groupMagicDEF.Controls.Add(this.numericScaleMagicDEF);
			this.groupMagicDEF.Controls.Add(this.labelMagicDEF);
			this.groupMagicDEF.Controls.Add(this.numericMagicDEF);
			this.groupMagicDEF.Controls.Add(this.labelLvPMagicDEF);
			this.groupMagicDEF.Controls.Add(this.numericLvPMagicDEF);
			this.groupMagicDEF.Controls.Add(this.labelScaleMagicDEF);
			resources.ApplyResources(this.groupMagicDEF, "groupMagicDEF");
			this.groupMagicDEF.Name = "groupMagicDEF";
			this.groupMagicDEF.TabStop = false;
			// 
			// labelMagicDEF
			// 
			resources.ApplyResources(this.labelMagicDEF, "labelMagicDEF");
			this.labelMagicDEF.Name = "labelMagicDEF";
			// 
			// numericMagicDEF
			// 
			this.numericMagicDEF.DecimalPlaces = 2;
			this.numericMagicDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericMagicDEF, "numericMagicDEF");
			this.numericMagicDEF.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericMagicDEF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMagicDEF.Name = "numericMagicDEF";
			this.numericMagicDEF.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericMagicDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelLvPMagicDEF
			// 
			resources.ApplyResources(this.labelLvPMagicDEF, "labelLvPMagicDEF");
			this.labelLvPMagicDEF.Name = "labelLvPMagicDEF";
			// 
			// numericLvPMagicDEF
			// 
			this.numericLvPMagicDEF.DecimalPlaces = 2;
			this.numericLvPMagicDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			resources.ApplyResources(this.numericLvPMagicDEF, "numericLvPMagicDEF");
			this.numericLvPMagicDEF.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
			this.numericLvPMagicDEF.Name = "numericLvPMagicDEF";
			this.numericLvPMagicDEF.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericLvPMagicDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelScaleMagicDEF
			// 
			resources.ApplyResources(this.labelScaleMagicDEF, "labelScaleMagicDEF");
			this.labelScaleMagicDEF.Name = "labelScaleMagicDEF";
			// 
			// groupMagicATK
			// 
			this.groupMagicATK.Controls.Add(this.numericMagicATK);
			this.groupMagicATK.Controls.Add(this.labelMagicATK);
			this.groupMagicATK.Controls.Add(this.labelLvPMagicATK);
			this.groupMagicATK.Controls.Add(this.numericLvPMagicATK);
			this.groupMagicATK.Controls.Add(this.labelScaleMagicATK);
			this.groupMagicATK.Controls.Add(this.numericScaleMagicATK);
			resources.ApplyResources(this.groupMagicATK, "groupMagicATK");
			this.groupMagicATK.Name = "groupMagicATK";
			this.groupMagicATK.TabStop = false;
			// 
			// numericMagicATK
			// 
			this.numericMagicATK.DecimalPlaces = 2;
			this.numericMagicATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericMagicATK, "numericMagicATK");
			this.numericMagicATK.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericMagicATK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMagicATK.Name = "numericMagicATK";
			this.numericMagicATK.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericMagicATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelMagicATK
			// 
			resources.ApplyResources(this.labelMagicATK, "labelMagicATK");
			this.labelMagicATK.Name = "labelMagicATK";
			// 
			// labelLvPMagicATK
			// 
			resources.ApplyResources(this.labelLvPMagicATK, "labelLvPMagicATK");
			this.labelLvPMagicATK.Name = "labelLvPMagicATK";
			// 
			// numericLvPMagicATK
			// 
			this.numericLvPMagicATK.DecimalPlaces = 2;
			this.numericLvPMagicATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			resources.ApplyResources(this.numericLvPMagicATK, "numericLvPMagicATK");
			this.numericLvPMagicATK.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
			this.numericLvPMagicATK.Name = "numericLvPMagicATK";
			this.numericLvPMagicATK.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericLvPMagicATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelScaleMagicATK
			// 
			resources.ApplyResources(this.labelScaleMagicATK, "labelScaleMagicATK");
			this.labelScaleMagicATK.Name = "labelScaleMagicATK";
			// 
			// groupRangeDEF
			// 
			this.groupRangeDEF.Controls.Add(this.numericRangeDEF);
			this.groupRangeDEF.Controls.Add(this.labelRangeDEF);
			this.groupRangeDEF.Controls.Add(this.labelLvPRangeDEF);
			this.groupRangeDEF.Controls.Add(this.numericLvPRangeDEF);
			this.groupRangeDEF.Controls.Add(this.labelScaleRangeDEF);
			this.groupRangeDEF.Controls.Add(this.numericScaleRangeDEF);
			resources.ApplyResources(this.groupRangeDEF, "groupRangeDEF");
			this.groupRangeDEF.Name = "groupRangeDEF";
			this.groupRangeDEF.TabStop = false;
			// 
			// numericRangeDEF
			// 
			this.numericRangeDEF.DecimalPlaces = 2;
			this.numericRangeDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericRangeDEF, "numericRangeDEF");
			this.numericRangeDEF.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericRangeDEF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericRangeDEF.Name = "numericRangeDEF";
			this.numericRangeDEF.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericRangeDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelRangeDEF
			// 
			resources.ApplyResources(this.labelRangeDEF, "labelRangeDEF");
			this.labelRangeDEF.Name = "labelRangeDEF";
			// 
			// labelLvPRangeDEF
			// 
			resources.ApplyResources(this.labelLvPRangeDEF, "labelLvPRangeDEF");
			this.labelLvPRangeDEF.Name = "labelLvPRangeDEF";
			// 
			// numericLvPRangeDEF
			// 
			this.numericLvPRangeDEF.DecimalPlaces = 2;
			this.numericLvPRangeDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			resources.ApplyResources(this.numericLvPRangeDEF, "numericLvPRangeDEF");
			this.numericLvPRangeDEF.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
			this.numericLvPRangeDEF.Name = "numericLvPRangeDEF";
			this.numericLvPRangeDEF.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericLvPRangeDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelScaleRangeDEF
			// 
			resources.ApplyResources(this.labelScaleRangeDEF, "labelScaleRangeDEF");
			this.labelScaleRangeDEF.Name = "labelScaleRangeDEF";
			// 
			// groupRangeATK
			// 
			this.groupRangeATK.Controls.Add(this.numericRangeATK);
			this.groupRangeATK.Controls.Add(this.labelRangeATK);
			this.groupRangeATK.Controls.Add(this.labelLvPRangeATK);
			this.groupRangeATK.Controls.Add(this.numericLvPRangeATK);
			this.groupRangeATK.Controls.Add(this.labelScaleRangeATK);
			this.groupRangeATK.Controls.Add(this.numericScaleRangeATK);
			resources.ApplyResources(this.groupRangeATK, "groupRangeATK");
			this.groupRangeATK.Name = "groupRangeATK";
			this.groupRangeATK.TabStop = false;
			// 
			// numericRangeATK
			// 
			this.numericRangeATK.DecimalPlaces = 2;
			this.numericRangeATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericRangeATK, "numericRangeATK");
			this.numericRangeATK.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericRangeATK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericRangeATK.Name = "numericRangeATK";
			this.numericRangeATK.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericRangeATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelRangeATK
			// 
			resources.ApplyResources(this.labelRangeATK, "labelRangeATK");
			this.labelRangeATK.Name = "labelRangeATK";
			// 
			// labelLvPRangeATK
			// 
			resources.ApplyResources(this.labelLvPRangeATK, "labelLvPRangeATK");
			this.labelLvPRangeATK.Name = "labelLvPRangeATK";
			// 
			// numericLvPRangeATK
			// 
			this.numericLvPRangeATK.DecimalPlaces = 2;
			this.numericLvPRangeATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			resources.ApplyResources(this.numericLvPRangeATK, "numericLvPRangeATK");
			this.numericLvPRangeATK.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
			this.numericLvPRangeATK.Name = "numericLvPRangeATK";
			this.numericLvPRangeATK.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericLvPRangeATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelScaleRangeATK
			// 
			resources.ApplyResources(this.labelScaleRangeATK, "labelScaleRangeATK");
			this.labelScaleRangeATK.Name = "labelScaleRangeATK";
			// 
			// groupMeleeDEF
			// 
			this.groupMeleeDEF.Controls.Add(this.numericMeleeDEF);
			this.groupMeleeDEF.Controls.Add(this.labelMeleeDEF);
			this.groupMeleeDEF.Controls.Add(this.labelLvPMeleeDEF);
			this.groupMeleeDEF.Controls.Add(this.numericLvPMeleeDEF);
			this.groupMeleeDEF.Controls.Add(this.labelScaleDEF);
			this.groupMeleeDEF.Controls.Add(this.numericScaleMeleeDEF);
			resources.ApplyResources(this.groupMeleeDEF, "groupMeleeDEF");
			this.groupMeleeDEF.Name = "groupMeleeDEF";
			this.groupMeleeDEF.TabStop = false;
			// 
			// numericMeleeDEF
			// 
			this.numericMeleeDEF.DecimalPlaces = 2;
			this.numericMeleeDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericMeleeDEF, "numericMeleeDEF");
			this.numericMeleeDEF.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericMeleeDEF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMeleeDEF.Name = "numericMeleeDEF";
			this.numericMeleeDEF.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericMeleeDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelMeleeDEF
			// 
			resources.ApplyResources(this.labelMeleeDEF, "labelMeleeDEF");
			this.labelMeleeDEF.Name = "labelMeleeDEF";
			// 
			// labelLvPMeleeDEF
			// 
			resources.ApplyResources(this.labelLvPMeleeDEF, "labelLvPMeleeDEF");
			this.labelLvPMeleeDEF.Name = "labelLvPMeleeDEF";
			// 
			// numericLvPMeleeDEF
			// 
			this.numericLvPMeleeDEF.DecimalPlaces = 2;
			this.numericLvPMeleeDEF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			resources.ApplyResources(this.numericLvPMeleeDEF, "numericLvPMeleeDEF");
			this.numericLvPMeleeDEF.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
			this.numericLvPMeleeDEF.Name = "numericLvPMeleeDEF";
			this.numericLvPMeleeDEF.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericLvPMeleeDEF.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelScaleDEF
			// 
			resources.ApplyResources(this.labelScaleDEF, "labelScaleDEF");
			this.labelScaleDEF.Name = "labelScaleDEF";
			// 
			// groupMeleeATK
			// 
			this.groupMeleeATK.Controls.Add(this.numericMeleeATK);
			this.groupMeleeATK.Controls.Add(this.labelMeleeATK);
			this.groupMeleeATK.Controls.Add(this.labelLvPMeleeATK);
			this.groupMeleeATK.Controls.Add(this.numericLvPMeleeATK);
			this.groupMeleeATK.Controls.Add(this.labelScaleATK);
			this.groupMeleeATK.Controls.Add(this.numericScaleMeleeATK);
			resources.ApplyResources(this.groupMeleeATK, "groupMeleeATK");
			this.groupMeleeATK.Name = "groupMeleeATK";
			this.groupMeleeATK.TabStop = false;
			// 
			// numericMeleeATK
			// 
			this.numericMeleeATK.DecimalPlaces = 2;
			this.numericMeleeATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericMeleeATK, "numericMeleeATK");
			this.numericMeleeATK.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericMeleeATK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMeleeATK.Name = "numericMeleeATK";
			this.numericMeleeATK.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericMeleeATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelMeleeATK
			// 
			resources.ApplyResources(this.labelMeleeATK, "labelMeleeATK");
			this.labelMeleeATK.Name = "labelMeleeATK";
			// 
			// labelLvPMeleeATK
			// 
			resources.ApplyResources(this.labelLvPMeleeATK, "labelLvPMeleeATK");
			this.labelLvPMeleeATK.Name = "labelLvPMeleeATK";
			// 
			// numericLvPMeleeATK
			// 
			this.numericLvPMeleeATK.DecimalPlaces = 2;
			this.numericLvPMeleeATK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			resources.ApplyResources(this.numericLvPMeleeATK, "numericLvPMeleeATK");
			this.numericLvPMeleeATK.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
			this.numericLvPMeleeATK.Name = "numericLvPMeleeATK";
			this.numericLvPMeleeATK.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericLvPMeleeATK.ValueChanged += new System.EventHandler(this.Status_ValueChanged);
			// 
			// labelScaleATK
			// 
			resources.ApplyResources(this.labelScaleATK, "labelScaleATK");
			this.labelScaleATK.Name = "labelScaleATK";
			// 
			// groupTP
			// 
			this.groupTP.Controls.Add(this.numericTP);
			this.groupTP.Controls.Add(this.labelTP);
			this.groupTP.Controls.Add(this.labelMaxTP);
			this.groupTP.Controls.Add(this.numericMaxTP);
			resources.ApplyResources(this.groupTP, "groupTP");
			this.groupTP.Name = "groupTP";
			this.groupTP.TabStop = false;
			// 
			// numericTP
			// 
			this.numericTP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericTP, "numericTP");
			this.numericTP.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericTP.Name = "numericTP";
			this.numericTP.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
			// 
			// labelTP
			// 
			resources.ApplyResources(this.labelTP, "labelTP");
			this.labelTP.Name = "labelTP";
			// 
			// labelMaxTP
			// 
			resources.ApplyResources(this.labelMaxTP, "labelMaxTP");
			this.labelMaxTP.Name = "labelMaxTP";
			// 
			// numericMaxTP
			// 
			this.numericMaxTP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericMaxTP, "numericMaxTP");
			this.numericMaxTP.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericMaxTP.Name = "numericMaxTP";
			this.numericMaxTP.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// groupHP
			// 
			this.groupHP.Controls.Add(this.numericHP);
			this.groupHP.Controls.Add(this.labelHP);
			this.groupHP.Controls.Add(this.labelLvPHP);
			this.groupHP.Controls.Add(this.numericLvPHP);
			this.groupHP.Controls.Add(this.labelScaleHP);
			this.groupHP.Controls.Add(this.numericScaleHP);
			resources.ApplyResources(this.groupHP, "groupHP");
			this.groupHP.Name = "groupHP";
			this.groupHP.TabStop = false;
			// 
			// numericHP
			// 
			this.numericHP.DecimalPlaces = 2;
			this.numericHP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			resources.ApplyResources(this.numericHP, "numericHP");
			this.numericHP.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            131072});
			this.numericHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericHP.Name = "numericHP";
			this.numericHP.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// labelHP
			// 
			resources.ApplyResources(this.labelHP, "labelHP");
			this.labelHP.Name = "labelHP";
			// 
			// labelLvPHP
			// 
			resources.ApplyResources(this.labelLvPHP, "labelLvPHP");
			this.labelLvPHP.Name = "labelLvPHP";
			// 
			// numericLvPHP
			// 
			this.numericLvPHP.DecimalPlaces = 2;
			this.numericLvPHP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			resources.ApplyResources(this.numericLvPHP, "numericLvPHP");
			this.numericLvPHP.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericLvPHP.Name = "numericLvPHP";
			this.numericLvPHP.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// labelScaleHP
			// 
			resources.ApplyResources(this.labelScaleHP, "labelScaleHP");
			this.labelScaleHP.Name = "labelScaleHP";
			// 
			// groupLv
			// 
			this.groupLv.Controls.Add(this.numericReqLv);
			this.groupLv.Controls.Add(this.labelReqLv);
			this.groupLv.Controls.Add(this.labelMinLevel);
			this.groupLv.Controls.Add(this.numericMinLevel);
			this.groupLv.Controls.Add(this.label);
			this.groupLv.Controls.Add(this.labelMaxLevel);
			this.groupLv.Controls.Add(this.numericMaxLevel);
			resources.ApplyResources(this.groupLv, "groupLv");
			this.groupLv.Name = "groupLv";
			this.groupLv.TabStop = false;
			// 
			// labelReqLv
			// 
			resources.ApplyResources(this.labelReqLv, "labelReqLv");
			this.labelReqLv.Name = "labelReqLv";
			// 
			// labelMinLevel
			// 
			resources.ApplyResources(this.labelMinLevel, "labelMinLevel");
			this.labelMinLevel.Name = "labelMinLevel";
			// 
			// label
			// 
			resources.ApplyResources(this.label, "label");
			this.label.Name = "label";
			// 
			// labelMaxLevel
			// 
			resources.ApplyResources(this.labelMaxLevel, "labelMaxLevel");
			this.labelMaxLevel.Name = "labelMaxLevel";
			// 
			// StatusInfomation
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupStatusInfo);
			this.Name = "StatusInfomation";
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMoney)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPEVT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEVT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPHIT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleEXP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericHIT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPLuck)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLuck)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleSPD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMagicDEF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMagicATK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleRangeDEF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleRangeATK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMeleeDEF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleMeleeATK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericScaleHP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMinLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericReqLv)).EndInit();
			this.groupStatusInfo.ResumeLayout(false);
			this.groupStatusInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericTestLv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartStatus)).EndInit();
			this.groupMoney.ResumeLayout(false);
			this.groupMoney.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMoney)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMoney)).EndInit();
			this.groupEXP.ResumeLayout(false);
			this.groupEXP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericEXP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPEXP)).EndInit();
			this.groupEVT.ResumeLayout(false);
			this.groupEVT.PerformLayout();
			this.groupHIT.ResumeLayout(false);
			this.groupHIT.PerformLayout();
			this.groupLuck.ResumeLayout(false);
			this.groupLuck.PerformLayout();
			this.groupSPD.ResumeLayout(false);
			this.groupSPD.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericSPD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPSPD)).EndInit();
			this.groupMagicDEF.ResumeLayout(false);
			this.groupMagicDEF.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMagicDEF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMagicDEF)).EndInit();
			this.groupMagicATK.ResumeLayout(false);
			this.groupMagicATK.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMagicATK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMagicATK)).EndInit();
			this.groupRangeDEF.ResumeLayout(false);
			this.groupRangeDEF.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRangeDEF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPRangeDEF)).EndInit();
			this.groupRangeATK.ResumeLayout(false);
			this.groupRangeATK.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRangeATK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPRangeATK)).EndInit();
			this.groupMeleeDEF.ResumeLayout(false);
			this.groupMeleeDEF.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMeleeDEF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMeleeDEF)).EndInit();
			this.groupMeleeATK.ResumeLayout(false);
			this.groupMeleeATK.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMeleeATK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPMeleeATK)).EndInit();
			this.groupTP.ResumeLayout(false);
			this.groupTP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericTP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxTP)).EndInit();
			this.groupHP.ResumeLayout(false);
			this.groupHP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericHP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPHP)).EndInit();
			this.groupLv.ResumeLayout(false);
			this.groupLv.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolTip toolTipInfo;
		private GroupBox groupStatusInfo;
		private Label labelScaleMoney;
		private Label labelLvPEVT;
		private Label labelLvPMoney;
		private Label labelEVT;
		private Label labelMoney;
		private Label labelLvPHIT;
		private Label labelScaleEXP;
		private Label labelHIT;
		private Label labelLvPEXP;
		private Label labelLvPLuck;
		private Label labelEXP;
		private Label labelLuck;
		private GroupBox groupSPD;
		private Label labelSPD;
		private Label labelLvPSPD;
		private Label labelScaleSPD;
		private GroupBox groupMagicDEF;
		private Label labelMagicDEF;
		private Label labelLvPMagicDEF;
		private Label labelScaleMagicDEF;
		private GroupBox groupMagicATK;
		private Label labelMagicATK;
		private Label labelLvPMagicATK;
		private Label labelScaleMagicATK;
		private GroupBox groupRangeDEF;
		private Label labelRangeDEF;
		private Label labelLvPRangeDEF;
		private Label labelScaleRangeDEF;
		private GroupBox groupRangeATK;
		private Label labelRangeATK;
		private Label labelLvPRangeATK;
		private Label labelScaleRangeATK;
		private GroupBox groupMeleeDEF;
		private Label labelMeleeDEF;
		private Label labelLvPMeleeDEF;
		private Label labelScaleDEF;
		private GroupBox groupMeleeATK;
		private Label labelMeleeATK;
		private Label labelLvPMeleeATK;
		private Label labelScaleATK;
		private GroupBox groupTP;
		private Label labelTP;
		private Label labelMaxTP;
		private GroupBox groupHP;
		private Label labelHP;
		private Label labelLvPHP;
		private Label labelScaleHP;
		private GroupBox groupLv;
		private Label labelMinLevel;
		private Label label;
		private Label labelMaxLevel;
		private GroupBox groupMoney;
		private GroupBox groupEXP;
		private GroupBox groupEVT;
		private GroupBox groupHIT;
		private GroupBox groupLuck;
		private Chart chartStatus;
		private NumericUpDown numericTestLv;
		private Label labelTestLv;
		private NumericUpDown numericLvPRangeATK;
		private NumericUpDown numericScaleRangeATK;
		private NumericUpDown numericMeleeDEF;
		private NumericUpDown numericLvPMeleeDEF;
		private NumericUpDown numericMeleeATK;
		private NumericUpDown numericLvPMeleeATK;
		private NumericUpDown numericScaleMeleeATK;
		private NumericUpDown numericTP;
		private NumericUpDown numericMinLevel;
		private NumericUpDown numericMaxLevel;
		private NumericUpDown numericScaleMoney;
		private NumericUpDown numericLvPEVT;
		private NumericUpDown numericLvPMoney;
		private NumericUpDown numericEVT;
		private NumericUpDown numericMoney;
		private NumericUpDown numericLvPHIT;
		private NumericUpDown numericScaleEXP;
		private NumericUpDown numericHIT;
		private NumericUpDown numericLvPEXP;
		private NumericUpDown numericLvPLuck;
		private NumericUpDown numericEXP;
		private NumericUpDown numericLuck;
		private NumericUpDown numericScaleSPD;
		private NumericUpDown numericSPD;
		private NumericUpDown numericLvPSPD;
		private NumericUpDown numericScaleMagicDEF;
		private NumericUpDown numericMagicDEF;
		private NumericUpDown numericLvPMagicDEF;
		private NumericUpDown numericMagicATK;
		private NumericUpDown numericLvPMagicATK;
		private NumericUpDown numericScaleMagicATK;
		private NumericUpDown numericRangeDEF;
		private NumericUpDown numericLvPRangeDEF;
		private NumericUpDown numericScaleRangeDEF;
		private NumericUpDown numericRangeATK;
		private NumericUpDown numericScaleMeleeDEF;
		private NumericUpDown numericMaxTP;
		private NumericUpDown numericHP;
		private NumericUpDown numericLvPHP;
		private NumericUpDown numericScaleHP;
		private NumericUpDown numericReqLv;
		private Label labelReqLv;
	}
}
