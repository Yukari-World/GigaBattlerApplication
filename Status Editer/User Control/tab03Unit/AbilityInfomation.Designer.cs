namespace Status_Editer.User_Control.tab03Unit {
	partial class AbilityInfomation {
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
			this.groupActiveSkillInfo = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// groupActiveSkillInfo
			// 
			this.groupActiveSkillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupActiveSkillInfo.Location = new System.Drawing.Point(0, 0);
			this.groupActiveSkillInfo.Name = "groupActiveSkillInfo";
			this.groupActiveSkillInfo.Size = new System.Drawing.Size(1360, 800);
			this.groupActiveSkillInfo.TabIndex = 0;
			this.groupActiveSkillInfo.TabStop = false;
			this.groupActiveSkillInfo.Text = "Skill Infomation(Passive)";
			// 
			// PassiveSkillInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupActiveSkillInfo);
			this.Name = "PassiveSkillInfomation";
			this.Size = new System.Drawing.Size(1360, 800);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupActiveSkillInfo;
	}
}
