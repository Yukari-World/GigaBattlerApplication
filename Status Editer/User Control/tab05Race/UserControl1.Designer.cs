namespace Status_Editer.User_Control.tab05Race {
	partial class UserControl1 {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.raceStatusBasicParts1 = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.raceStatusBasicParts1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1590, 820);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// raceStatusBasicParts1
			// 
			this.raceStatusBasicParts1.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusBasicParts1.labelText = "HP";
			this.raceStatusBasicParts1.Location = new System.Drawing.Point(6, 18);
			this.raceStatusBasicParts1.Name = "raceStatusBasicParts1";
			this.raceStatusBasicParts1.Size = new System.Drawing.Size(650, 75);
			this.raceStatusBasicParts1.TabIndex = 0;
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupBox1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(1590, 820);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private Parts.RaceStatusBasicParts raceStatusBasicParts1;
	}
}
