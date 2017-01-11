using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit.Parts {
	partial class SkillInfoParts {
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
			this.groupSkill = new System.Windows.Forms.GroupBox();
			this.comboSkill = new System.Windows.Forms.ComboBox();
			this.labelSkilleffect = new System.Windows.Forms.Label();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.groupSkill.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupSkill
			// 
			this.groupSkill.Controls.Add(this.labelSkilleffect);
			this.groupSkill.Controls.Add(this.comboSkill);
			this.groupSkill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupSkill.Location = new System.Drawing.Point(0, 0);
			this.groupSkill.Name = "groupSkill";
			this.groupSkill.Size = new System.Drawing.Size(650, 50);
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
			// labelSkilleffect
			// 
			this.labelSkilleffect.Location = new System.Drawing.Point(280, 12);
			this.labelSkilleffect.Name = "labelSkilleffect";
			this.labelSkilleffect.Size = new System.Drawing.Size(350, 35);
			this.labelSkilleffect.TabIndex = 1;
			this.labelSkilleffect.Text = "Skill Effect";
			this.labelSkilleffect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSkilleffect.TextChanged += new System.EventHandler(this.labelSkilleffect_TextChanged);
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
			// SkillInfoParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupSkill);
			this.Name = "SkillInfoParts";
			this.Size = new System.Drawing.Size(650, 50);
			this.groupSkill.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupSkill;
		private ComboBox comboSkill;
		private Label labelSkilleffect;
		private ToolTip toolTipInfo;
	}
}
