namespace Status_Editer.User_Control.tab03Unit.Parts {
	partial class SkillInfomation {
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
			this.groupSkill = new System.Windows.Forms.GroupBox();
			this.comboSkill = new System.Windows.Forms.ComboBox();
			this.groupSkill.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupSkill
			// 
			this.groupSkill.Controls.Add(this.comboSkill);
			this.groupSkill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupSkill.Location = new System.Drawing.Point(0, 0);
			this.groupSkill.Name = "groupSkill";
			this.groupSkill.Size = new System.Drawing.Size(650, 75);
			this.groupSkill.TabIndex = 1;
			this.groupSkill.TabStop = false;
			this.groupSkill.Text = "Skill**";
			// 
			// comboSkill
			// 
			this.comboSkill.DisplayMember = "SkillName";
			this.comboSkill.FormattingEnabled = true;
			this.comboSkill.Location = new System.Drawing.Point(10, 20);
			this.comboSkill.Name = "comboSkill";
			this.comboSkill.Size = new System.Drawing.Size(250, 20);
			this.comboSkill.TabIndex = 0;
			this.comboSkill.ValueMember = "SkillID";
			// 
			// SkillInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupSkill);
			this.Name = "SkillInfomation";
			this.Size = new System.Drawing.Size(650, 75);
			this.groupSkill.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupSkill;
		private System.Windows.Forms.ComboBox comboSkill;
	}
}
