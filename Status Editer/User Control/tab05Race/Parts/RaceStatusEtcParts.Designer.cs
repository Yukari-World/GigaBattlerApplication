using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Status_Editer.User_Control.tab05Race.Parts {
	partial class RaceStatusEtcParts {
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
			this.groupLuckHITEVT = new System.Windows.Forms.GroupBox();
			this.labelBase = new System.Windows.Forms.Label();
			this.numericBase = new System.Windows.Forms.NumericUpDown();
			this.labelLvPStatus = new System.Windows.Forms.Label();
			this.numericLvPStatus = new System.Windows.Forms.NumericUpDown();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.groupLuckHITEVT.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// groupLuckHITEVT
			// 
			this.groupLuckHITEVT.Controls.Add(this.labelBase);
			this.groupLuckHITEVT.Controls.Add(this.numericBase);
			this.groupLuckHITEVT.Controls.Add(this.labelLvPStatus);
			this.groupLuckHITEVT.Controls.Add(this.numericLvPStatus);
			this.groupLuckHITEVT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupLuckHITEVT.Location = new System.Drawing.Point(0, 0);
			this.groupLuckHITEVT.Name = "groupLuckHITEVT";
			this.groupLuckHITEVT.Size = new System.Drawing.Size(650, 75);
			this.groupLuckHITEVT.TabIndex = 0;
			this.groupLuckHITEVT.TabStop = false;
			this.groupLuckHITEVT.Text = "Label";
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
			// numericBase
			// 
			this.numericBase.DecimalPlaces = 2;
			this.numericBase.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericBase.Location = new System.Drawing.Point(10, 30);
			this.numericBase.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.numericBase.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
			this.numericBase.Name = "numericBase";
			this.numericBase.Size = new System.Drawing.Size(150, 19);
			this.numericBase.TabIndex = 1;
			this.numericBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericBase.ThousandsSeparator = true;
			this.numericBase.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// labelLvPStatus
			// 
			this.labelLvPStatus.AutoSize = true;
			this.labelLvPStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelLvPStatus.Location = new System.Drawing.Point(200, 15);
			this.labelLvPStatus.Name = "labelLvPStatus";
			this.labelLvPStatus.Size = new System.Drawing.Size(173, 12);
			this.labelLvPStatus.TabIndex = 2;
			this.labelLvPStatus.Text = "Level Per Status(Lv.100まで有効)";
			// 
			// numericLvPStatus
			// 
			this.numericLvPStatus.DecimalPlaces = 2;
			this.numericLvPStatus.Location = new System.Drawing.Point(200, 30);
			this.numericLvPStatus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericLvPStatus.Name = "numericLvPStatus";
			this.numericLvPStatus.Size = new System.Drawing.Size(150, 19);
			this.numericLvPStatus.TabIndex = 3;
			this.numericLvPStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericLvPStatus.ThousandsSeparator = true;
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
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupLuckHITEVT);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(650, 75);
			this.groupLuckHITEVT.ResumeLayout(false);
			this.groupLuckHITEVT.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericLvPStatus)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupLuckHITEVT;
		private Label labelBase;
		private NumericUpDown numericBase;
		private Label labelLvPStatus;
		private NumericUpDown numericLvPStatus;
		private ToolTip toolTipInfo;
	}
}
