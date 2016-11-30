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
			this.buttonSubmitRecommend = new System.Windows.Forms.Button();
			this.labelRecommend = new System.Windows.Forms.Label();
			this.numericBase = new System.Windows.Forms.NumericUpDown();
			this.labelBase = new System.Windows.Forms.Label();
			this.labelLvPStatus = new System.Windows.Forms.Label();
			this.numericLvPStatus = new System.Windows.Forms.NumericUpDown();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.groupBasic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBasic
			// 
			this.groupBasic.Controls.Add(this.buttonSubmitRecommend);
			this.groupBasic.Controls.Add(this.labelRecommend);
			this.groupBasic.Controls.Add(this.numericBase);
			this.groupBasic.Controls.Add(this.labelBase);
			this.groupBasic.Controls.Add(this.labelLvPStatus);
			this.groupBasic.Controls.Add(this.numericLvPStatus);
			this.groupBasic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBasic.Location = new System.Drawing.Point(0, 0);
			this.groupBasic.Name = "groupBasic";
			this.groupBasic.Size = new System.Drawing.Size(650, 60);
			this.groupBasic.TabIndex = 0;
			this.groupBasic.TabStop = false;
			this.groupBasic.Text = "Label";
			// 
			// buttonSubmitRecommend
			// 
			this.buttonSubmitRecommend.Location = new System.Drawing.Point(500, 27);
			this.buttonSubmitRecommend.Name = "buttonSubmitRecommend";
			this.buttonSubmitRecommend.Size = new System.Drawing.Size(100, 23);
			this.buttonSubmitRecommend.TabIndex = 5;
			this.buttonSubmitRecommend.Text = "推奨値を使用";
			this.buttonSubmitRecommend.UseVisualStyleBackColor = true;
			this.buttonSubmitRecommend.Click += new System.EventHandler(this.buttonSubmitRecommend_Click);
			// 
			// labelRecommend
			// 
			this.labelRecommend.AutoSize = true;
			this.labelRecommend.Location = new System.Drawing.Point(400, 32);
			this.labelRecommend.Name = "labelRecommend";
			this.labelRecommend.Size = new System.Drawing.Size(63, 12);
			this.labelRecommend.TabIndex = 4;
			this.labelRecommend.Text = "推奨値:6.30";
			// 
			// numericBase
			// 
			this.numericBase.ImeMode = System.Windows.Forms.ImeMode.Off;
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
			this.numericLvPStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
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
			this.numericLvPStatus.ValueChanged += new System.EventHandler(this.numericLvPStatus_ValueChanged);
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
			// RaceStatusBasicParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupBasic);
			this.Name = "RaceStatusBasicParts";
			this.Size = new System.Drawing.Size(650, 60);
			this.Load += new System.EventHandler(this.RaceStatusBasicParts_Load);
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
		private Button buttonSubmitRecommend;
		private Label labelRecommend;
	}
}
