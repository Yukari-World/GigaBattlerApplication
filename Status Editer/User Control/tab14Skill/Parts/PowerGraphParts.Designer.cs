﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab14Skill.Parts {
	partial class PowerGraphParts {
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
			this.labelPower = new System.Windows.Forms.Label();
			this.numericPower = new System.Windows.Forms.NumericUpDown();
			this.labelDamage = new System.Windows.Forms.Label();
			this.numericDamage = new System.Windows.Forms.NumericUpDown();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.labelBlurring = new System.Windows.Forms.Label();
			this.numericBlurring = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericPower)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericDamage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericBlurring)).BeginInit();
			this.SuspendLayout();
			// 
			// labelPower
			// 
			this.labelPower.Location = new System.Drawing.Point(10, 10);
			this.labelPower.Name = "labelPower";
			this.labelPower.Size = new System.Drawing.Size(35, 15);
			this.labelPower.TabIndex = 0;
			this.labelPower.Text = "威力";
			this.labelPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericPower
			// 
			this.numericPower.Location = new System.Drawing.Point(50, 9);
			this.numericPower.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericPower.Name = "numericPower";
			this.numericPower.Size = new System.Drawing.Size(100, 19);
			this.numericPower.TabIndex = 1;
			this.numericPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericPower.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericPower, "スキルの威力。1 ≒ 1%\r\n値が大きい程ダメージが大きくなる\r\n設定値: 0～ 65,535\r\n");
			this.numericPower.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericPower.ValueChanged += new System.EventHandler(this.numericValue_ValueChanged);
			// 
			// labelDamage
			// 
			this.labelDamage.Location = new System.Drawing.Point(170, 10);
			this.labelDamage.Name = "labelDamage";
			this.labelDamage.Size = new System.Drawing.Size(75, 15);
			this.labelDamage.TabIndex = 2;
			this.labelDamage.Text = "ダメージ倍率";
			this.labelDamage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericDamage
			// 
			this.numericDamage.Location = new System.Drawing.Point(260, 9);
			this.numericDamage.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericDamage.Name = "numericDamage";
			this.numericDamage.Size = new System.Drawing.Size(100, 19);
			this.numericDamage.TabIndex = 3;
			this.numericDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericDamage.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericDamage, "ダメージ計算後に増減する倍率。1 = 0.01%\r\nダメージが大きいほどこの値の影響が大きくなる。\r\n設定値: 0～ 9,999,999");
			this.numericDamage.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericDamage.ValueChanged += new System.EventHandler(this.numericValue_ValueChanged);
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
			// labelBlurring
			// 
			this.labelBlurring.Location = new System.Drawing.Point(375, 10);
			this.labelBlurring.Name = "labelBlurring";
			this.labelBlurring.Size = new System.Drawing.Size(75, 15);
			this.labelBlurring.TabIndex = 4;
			this.labelBlurring.Text = "ダメージブレ幅";
			this.labelBlurring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericBlurring
			// 
			this.numericBlurring.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericBlurring.Location = new System.Drawing.Point(465, 9);
			this.numericBlurring.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericBlurring.Name = "numericBlurring";
			this.numericBlurring.Size = new System.Drawing.Size(100, 19);
			this.numericBlurring.TabIndex = 5;
			this.numericBlurring.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericBlurring.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericBlurring, "全ての計算後に影響するダメージのランダム幅。1 = 0.01%\r\n0で固定。100.00%で不安定ダメージとなる\r\n設定値: 0～ 10,000\r\n");
			this.numericBlurring.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
			this.numericBlurring.ValueChanged += new System.EventHandler(this.numericValue_ValueChanged);
			// 
			// PowerGraphParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericBlurring);
			this.Controls.Add(this.labelBlurring);
			this.Controls.Add(this.numericDamage);
			this.Controls.Add(this.labelDamage);
			this.Controls.Add(this.numericPower);
			this.Controls.Add(this.labelPower);
			this.Name = "PowerGraphParts";
			this.Size = new System.Drawing.Size(730, 100);
			this.Load += new System.EventHandler(this.ItemStatusParts_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemStatusParts_Paint);
			((System.ComponentModel.ISupportInitialize)(this.numericPower)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericDamage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericBlurring)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Label labelPower;
		private NumericUpDown numericPower;
		private Label labelDamage;
		private NumericUpDown numericDamage;
		private ToolTip toolTipInfo;
		private Label labelBlurring;
		private NumericUpDown numericBlurring;
	}
}
