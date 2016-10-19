namespace Status_Editer.User_Control.tabMonster {
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
			this.groupSkillInfo = new System.Windows.Forms.GroupBox();
			this.comboSkill1 = new System.Windows.Forms.ComboBox();
			this.labelSkill1 = new System.Windows.Forms.Label();
			this.groupSkillInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupSkillInfo
			// 
			this.groupSkillInfo.Controls.Add(this.comboSkill1);
			this.groupSkillInfo.Controls.Add(this.labelSkill1);
			this.groupSkillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupSkillInfo.Location = new System.Drawing.Point(0, 0);
			this.groupSkillInfo.Name = "groupSkillInfo";
			this.groupSkillInfo.Size = new System.Drawing.Size(1360, 800);
			this.groupSkillInfo.TabIndex = 8;
			this.groupSkillInfo.TabStop = false;
			this.groupSkillInfo.Text = "Skill Infomation";
			// 
			// comboSkill1
			// 
			this.comboSkill1.DisplayMember = "SkillName";
			this.comboSkill1.FormattingEnabled = true;
			this.comboSkill1.Location = new System.Drawing.Point(10, 35);
			this.comboSkill1.Name = "comboSkill1";
			this.comboSkill1.Size = new System.Drawing.Size(250, 20);
			this.comboSkill1.TabIndex = 1;
			this.comboSkill1.ValueMember = "SkillID";
			// 
			// labelSkill1
			// 
			this.labelSkill1.AutoSize = true;
			this.labelSkill1.Location = new System.Drawing.Point(10, 20);
			this.labelSkill1.Name = "labelSkill1";
			this.labelSkill1.Size = new System.Drawing.Size(37, 12);
			this.labelSkill1.TabIndex = 0;
			this.labelSkill1.Text = "Skill 1";
			// 
			// SkillInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupSkillInfo);
			this.Name = "SkillInfomation";
			this.Size = new System.Drawing.Size(1360, 800);
			this.groupSkillInfo.ResumeLayout(false);
			this.groupSkillInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupSkillInfo;
		private System.Windows.Forms.ComboBox comboSkill1;
		private System.Windows.Forms.Label labelSkill1;
	}
}
