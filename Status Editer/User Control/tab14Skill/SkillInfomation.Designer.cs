using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab14Skill {
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
			this.components = new System.ComponentModel.Container();
			this.groupSkillInfomation = new System.Windows.Forms.GroupBox();
			this.textSkillName = new System.Windows.Forms.TextBox();
			this.labelSkillID = new System.Windows.Forms.Label();
			this.labelSkillName = new System.Windows.Forms.Label();
			this.textSkillID = new System.Windows.Forms.TextBox();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.PowerGraph = new Status_Editer.User_Control.tab14Skill.Parts.PowerGraphParts();
			this.groupSkillInfomation.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupSkillInfomation
			// 
			this.groupSkillInfomation.Controls.Add(this.PowerGraph);
			this.groupSkillInfomation.Controls.Add(this.textSkillName);
			this.groupSkillInfomation.Controls.Add(this.labelSkillID);
			this.groupSkillInfomation.Controls.Add(this.labelSkillName);
			this.groupSkillInfomation.Controls.Add(this.textSkillID);
			this.groupSkillInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupSkillInfomation.Location = new System.Drawing.Point(0, 0);
			this.groupSkillInfomation.Name = "groupSkillInfomation";
			this.groupSkillInfomation.Size = new System.Drawing.Size(600, 820);
			this.groupSkillInfomation.TabIndex = 0;
			this.groupSkillInfomation.TabStop = false;
			this.groupSkillInfomation.Text = "Skill Infomation";
			// 
			// textSkillName
			// 
			this.textSkillName.Location = new System.Drawing.Point(10, 90);
			this.textSkillName.Name = "textSkillName";
			this.textSkillName.Size = new System.Drawing.Size(465, 19);
			this.textSkillName.TabIndex = 3;
			this.toolTipInfo.SetToolTip(this.textSkillName, "ゲームユーザーが視認する名前。\r\n");
			// 
			// labelSkillID
			// 
			this.labelSkillID.AutoSize = true;
			this.labelSkillID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelSkillID.Location = new System.Drawing.Point(10, 30);
			this.labelSkillID.Name = "labelSkillID";
			this.labelSkillID.Size = new System.Drawing.Size(180, 12);
			this.labelSkillID.TabIndex = 0;
			this.labelSkillID.Text = "Skill ID(システムで識別されるデータ):";
			// 
			// labelSkillName
			// 
			this.labelSkillName.AutoSize = true;
			this.labelSkillName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelSkillName.Location = new System.Drawing.Point(10, 75);
			this.labelSkillName.Name = "labelSkillName";
			this.labelSkillName.Size = new System.Drawing.Size(122, 12);
			this.labelSkillName.TabIndex = 2;
			this.labelSkillName.Text = "Skill Name(表記データ):";
			// 
			// textSkillID
			// 
			this.textSkillID.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textSkillID.Location = new System.Drawing.Point(10, 45);
			this.textSkillID.Name = "textSkillID";
			this.textSkillID.Size = new System.Drawing.Size(300, 19);
			this.textSkillID.TabIndex = 1;
			this.toolTipInfo.SetToolTip(this.textSkillID, "ゲームシステム側で識別されるデータ。\r\nID名は英名表記で統一し、データの整合性のため、変更を行わないこと。");
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
			// PowerGraph
			// 
			this.PowerGraph.Location = new System.Drawing.Point(0, 200);
			this.PowerGraph.Name = "PowerGraph";
			this.PowerGraph.Size = new System.Drawing.Size(730, 100);
			this.PowerGraph.TabIndex = 4;
			// 
			// SkillInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupSkillInfomation);
			this.Name = "SkillInfomation";
			this.Size = new System.Drawing.Size(600, 820);
			this.groupSkillInfomation.ResumeLayout(false);
			this.groupSkillInfomation.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupSkillInfomation;
		private ToolTip toolTipInfo;
		private TextBox textSkillName;
		private Label labelSkillID;
		private Label labelSkillName;
		private TextBox textSkillID;
		private Parts.PowerGraphParts PowerGraph;
	}
}
