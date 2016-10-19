namespace Status_Editer.User_Control.tab03Unit {
	partial class TotalUnitInfomation {
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
			this.groupTotal = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// groupTotal
			// 
			this.groupTotal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupTotal.Location = new System.Drawing.Point(0, 0);
			this.groupTotal.Name = "groupTotal";
			this.groupTotal.Size = new System.Drawing.Size(1360, 800);
			this.groupTotal.TabIndex = 0;
			this.groupTotal.TabStop = false;
			this.groupTotal.Text = "Unit Infomation";
			// 
			// TotalUnitInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupTotal);
			this.Name = "TotalUnitInfomation";
			this.Size = new System.Drawing.Size(1360, 800);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupTotal;
	}
}
