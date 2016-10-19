using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab05Race.Parts {
	partial class RaceStatusBasicParts {
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
			this.groupBasic = new System.Windows.Forms.GroupBox();
			this.numericBase = new System.Windows.Forms.NumericUpDown();
			this.labelBase = new System.Windows.Forms.Label();
			this.labelLvPStatus = new System.Windows.Forms.Label();
			this.numericLvPStatus = new System.Windows.Forms.NumericUpDown();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBasic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBasic
			// 
			this.groupBasic.Controls.Add(this.button1);
			this.groupBasic.Controls.Add(this.label1);
			this.groupBasic.Controls.Add(this.numericBase);
			this.groupBasic.Controls.Add(this.labelBase);
			this.groupBasic.Controls.Add(this.labelLvPStatus);
			this.groupBasic.Controls.Add(this.numericLvPStatus);
			this.groupBasic.Location = new System.Drawing.Point(0, 0);
			this.groupBasic.Name = "groupBasic";
			this.groupBasic.Size = new System.Drawing.Size(650, 75);
			this.groupBasic.TabIndex = 2;
			this.groupBasic.TabStop = false;
			this.groupBasic.Text = "Label";
			// 
			// numericBase
			// 
			this.numericBase.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericBase.Location = new System.Drawing.Point(10, 30);
			this.numericBase.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericBase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericBase.Name = "numericBase";
			this.numericBase.Size = new System.Drawing.Size(150, 19);
			this.numericBase.TabIndex = 1;
			this.numericBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericBase.ThousandsSeparator = true;
			this.numericBase.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.numericBase.ValueChanged += new System.EventHandler(this.numericBase_ValueChanged);
			// 
			// labelBase
			// 
			this.labelBase.AutoSize = true;
			this.labelBase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelBase.Location = new System.Drawing.Point(10, 15);
			this.labelBase.Name = "labelBase";
			this.labelBase.Size = new System.Drawing.Size(31, 12);
			this.labelBase.TabIndex = 0;
			this.labelBase.Text = "Base";
			// 
			// labelLvPStatus
			// 
			this.labelLvPStatus.AutoSize = true;
			this.labelLvPStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelLvPStatus.Location = new System.Drawing.Point(200, 15);
			this.labelLvPStatus.Name = "labelLvPStatus";
			this.labelLvPStatus.Size = new System.Drawing.Size(90, 12);
			this.labelLvPStatus.TabIndex = 2;
			this.labelLvPStatus.Text = "Level Per Status";
			// 
			// numericLvPStatus
			// 
			this.numericLvPStatus.DecimalPlaces = 2;
			this.numericLvPStatus.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numericLvPStatus.Location = new System.Drawing.Point(200, 30);
			this.numericLvPStatus.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
			this.numericLvPStatus.Name = "numericLvPStatus";
			this.numericLvPStatus.Size = new System.Drawing.Size(150, 19);
			this.numericLvPStatus.TabIndex = 3;
			this.numericLvPStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericLvPStatus.ThousandsSeparator = true;
			this.numericLvPStatus.Value = new decimal(new int[] {
            63,
            0,
            0,
            65536});
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(400, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "推奨値:6.30";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(550, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// RaceStatusBasicParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupBasic);
			this.Name = "RaceStatusBasicParts";
			this.Size = new System.Drawing.Size(650, 75);
			this.groupBasic.ResumeLayout(false);
			this.groupBasic.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPStatus)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBasic;
		private Label labelBase;
		private NumericUpDown numericBase;
		private Label labelLvPStatus;
		private NumericUpDown numericLvPStatus;
		private ToolTip toolTipInfo;
		private Button button1;
		private Label label1;
	}
}
