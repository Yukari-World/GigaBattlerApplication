namespace Status_Editer.User_Control.tab06Job {
	partial class JobInfomation {
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
			this.groupJobInfo = new System.Windows.Forms.GroupBox();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// groupJobInfo
			// 
			this.groupJobInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupJobInfo.Location = new System.Drawing.Point(0, 0);
			this.groupJobInfo.Name = "groupJobInfo";
			this.groupJobInfo.Size = new System.Drawing.Size(1380, 820);
			this.groupJobInfo.TabIndex = 0;
			this.groupJobInfo.TabStop = false;
			this.groupJobInfo.Text = "Job Infomation";
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
			// JobInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupJobInfo);
			this.Name = "JobInfomation";
			this.Size = new System.Drawing.Size(1380, 820);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupJobInfo;
		private System.Windows.Forms.ToolTip toolTipInfo;
	}
}
