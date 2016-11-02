namespace Status_Editer.User_Control.tab06Job.Parts {
	partial class JobStatusBasicParts {
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.groupBase = new System.Windows.Forms.GroupBox();
			this.labelBaseStatus = new System.Windows.Forms.Label();
			this.numericBasicStatus = new System.Windows.Forms.NumericUpDown();
			this.labelBonusStatus = new System.Windows.Forms.Label();
			this.numericBonusStatus = new System.Windows.Forms.NumericUpDown();
			this.groupBase.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBasicStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericBonusStatus)).BeginInit();
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
			// groupBase
			// 
			this.groupBase.Controls.Add(this.numericBonusStatus);
			this.groupBase.Controls.Add(this.labelBonusStatus);
			this.groupBase.Controls.Add(this.numericBasicStatus);
			this.groupBase.Controls.Add(this.labelBaseStatus);
			this.groupBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBase.Location = new System.Drawing.Point(0, 0);
			this.groupBase.Name = "groupBase";
			this.groupBase.Size = new System.Drawing.Size(650, 60);
			this.groupBase.TabIndex = 0;
			this.groupBase.TabStop = false;
			this.groupBase.Text = "Label";
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
			// numericBasicStatus
			// 
			this.numericBasicStatus.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericBasicStatus.Location = new System.Drawing.Point(10, 30);
			this.numericBasicStatus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericBasicStatus.Name = "numericBasicStatus";
			this.numericBasicStatus.Size = new System.Drawing.Size(120, 19);
			this.numericBasicStatus.TabIndex = 1;
			this.numericBasicStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTipInfo.SetToolTip(this.numericBasicStatus, "基本ステータスに対して影響を受ける割合(%)");
			this.numericBasicStatus.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
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
			// numericBonusStatus
			// 
			this.numericBonusStatus.Location = new System.Drawing.Point(150, 30);
			this.numericBonusStatus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericBonusStatus.Name = "numericBonusStatus";
			this.numericBonusStatus.Size = new System.Drawing.Size(120, 19);
			this.numericBonusStatus.TabIndex = 3;
			this.numericBonusStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTipInfo.SetToolTip(this.numericBonusStatus, "ジョブマスター時に獲得できるボーナスステータス");
			// 
			// JobStatusBasicParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupBase);
			this.Name = "JobStatusBasicParts";
			this.Size = new System.Drawing.Size(650, 60);
			this.groupBase.ResumeLayout(false);
			this.groupBase.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBasicStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericBonusStatus)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTipInfo;
		private System.Windows.Forms.GroupBox groupBase;
		private System.Windows.Forms.NumericUpDown numericBonusStatus;
		private System.Windows.Forms.Label labelBonusStatus;
		private System.Windows.Forms.NumericUpDown numericBasicStatus;
		private System.Windows.Forms.Label labelBaseStatus;
	}
}
