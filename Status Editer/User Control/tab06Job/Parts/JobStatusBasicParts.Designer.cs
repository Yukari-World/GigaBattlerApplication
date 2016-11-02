using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab06Job.Parts {
	partial class JobStatusBasicParts {
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
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.numericBaseStatus = new System.Windows.Forms.NumericUpDown();
			this.numericBonusStatus = new System.Windows.Forms.NumericUpDown();
			this.groupBase = new System.Windows.Forms.GroupBox();
			this.labelBonusStatus = new System.Windows.Forms.Label();
			this.labelBaseStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericBaseStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericBonusStatus)).BeginInit();
			this.groupBase.SuspendLayout();
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
			// numericBaseStatus
			// 
			this.numericBaseStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericBaseStatus.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericBaseStatus.Location = new System.Drawing.Point(10, 30);
			this.numericBaseStatus.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
			this.numericBaseStatus.Name = "numericBaseStatus";
			this.numericBaseStatus.Size = new System.Drawing.Size(120, 19);
			this.numericBaseStatus.TabIndex = 1;
			this.numericBaseStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTipInfo.SetToolTip(this.numericBaseStatus, "基本ステータスに対して影響を受ける割合(%)\r\n設定値: 0 ～ 9,000");
			this.numericBaseStatus.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericBaseStatus.ValueChanged += new System.EventHandler(this.numericBaseStatus_ValueChanged);
			// 
			// numericBonusStatus
			// 
			this.numericBonusStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericBonusStatus.Location = new System.Drawing.Point(150, 30);
			this.numericBonusStatus.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.numericBonusStatus.Name = "numericBonusStatus";
			this.numericBonusStatus.Size = new System.Drawing.Size(120, 19);
			this.numericBonusStatus.TabIndex = 3;
			this.numericBonusStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTipInfo.SetToolTip(this.numericBonusStatus, "ジョブマスター時に獲得できるボーナスステータス\r\n設定値: 0 ～ 99");
			// 
			// groupBase
			// 
			this.groupBase.Controls.Add(this.numericBonusStatus);
			this.groupBase.Controls.Add(this.labelBonusStatus);
			this.groupBase.Controls.Add(this.numericBaseStatus);
			this.groupBase.Controls.Add(this.labelBaseStatus);
			this.groupBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBase.Location = new System.Drawing.Point(0, 0);
			this.groupBase.Name = "groupBase";
			this.groupBase.Size = new System.Drawing.Size(650, 60);
			this.groupBase.TabIndex = 0;
			this.groupBase.TabStop = false;
			this.groupBase.Text = "Label";
			// 
			// labelBonusStatus
			// 
			this.labelBonusStatus.AutoSize = true;
			this.labelBonusStatus.Location = new System.Drawing.Point(148, 15);
			this.labelBonusStatus.Name = "labelBonusStatus";
			this.labelBonusStatus.Size = new System.Drawing.Size(74, 12);
			this.labelBonusStatus.TabIndex = 2;
			this.labelBonusStatus.Text = "Bonus Status";
			// 
			// labelBaseStatus
			// 
			this.labelBaseStatus.AutoSize = true;
			this.labelBaseStatus.Location = new System.Drawing.Point(10, 15);
			this.labelBaseStatus.Name = "labelBaseStatus";
			this.labelBaseStatus.Size = new System.Drawing.Size(31, 12);
			this.labelBaseStatus.TabIndex = 0;
			this.labelBaseStatus.Text = "Base";
			// 
			// JobStatusBasicParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupBase);
			this.Name = "JobStatusBasicParts";
			this.Size = new System.Drawing.Size(650, 60);
			this.Load += new System.EventHandler(this.JobStatusBasicParts_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericBaseStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericBonusStatus)).EndInit();
			this.groupBase.ResumeLayout(false);
			this.groupBase.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolTip toolTipInfo;
		private GroupBox groupBase;
		private NumericUpDown numericBonusStatus;
		private Label labelBonusStatus;
		private NumericUpDown numericBaseStatus;
		private Label labelBaseStatus;
	}
}
