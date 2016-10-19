using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit.Parts {
	partial class SkillInfomation {
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
			this.groupSkill = new GroupBox();
			this.comboSkill = new ComboBox();
			this.groupSkill.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupSkill
			// 
			this.groupSkill.Controls.Add(this.comboSkill);
			this.groupSkill.Dock = DockStyle.Fill;
			this.groupSkill.Location = new Point(0, 0);
			this.groupSkill.Name = "groupSkill";
			this.groupSkill.Size = new Size(650, 75);
			this.groupSkill.TabIndex = 1;
			this.groupSkill.TabStop = false;
			this.groupSkill.Text = "Skill**";
			// 
			// comboSkill
			// 
			this.comboSkill.DisplayMember = "SkillName";
			this.comboSkill.FormattingEnabled = true;
			this.comboSkill.Location = new Point(10, 20);
			this.comboSkill.Name = "comboSkill";
			this.comboSkill.Size = new Size(250, 20);
			this.comboSkill.TabIndex = 0;
			this.comboSkill.ValueMember = "SkillID";
			// 
			// SkillInfomation
			// 
			this.AutoScaleDimensions = new SizeF(6F, 12F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			this.Controls.Add(this.groupSkill);
			this.Name = "SkillInfomation";
			this.Size = new Size(650, 75);
			this.groupSkill.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupSkill;
		private ComboBox comboSkill;
	}
}
