using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab14Skill {
	partial class SkillStatusInfomation {
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
			this.groupSkillPower = new System.Windows.Forms.GroupBox();
			this.labelGraph6 = new System.Windows.Forms.Label();
			this.labelGraph5 = new System.Windows.Forms.Label();
			this.labelGraph4 = new System.Windows.Forms.Label();
			this.labelGraph3 = new System.Windows.Forms.Label();
			this.labelGraph2 = new System.Windows.Forms.Label();
			this.labelGraph1 = new System.Windows.Forms.Label();
			this.StatusGraphSPD = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphMagicDEF = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphMagicATK = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphRangeDEF = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphRangeATK = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphMeleeDEF = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphMeleeATK = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.groupSkillPower.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupSkillPower
			// 
			this.groupSkillPower.Controls.Add(this.labelGraph6);
			this.groupSkillPower.Controls.Add(this.labelGraph5);
			this.groupSkillPower.Controls.Add(this.labelGraph4);
			this.groupSkillPower.Controls.Add(this.labelGraph3);
			this.groupSkillPower.Controls.Add(this.labelGraph2);
			this.groupSkillPower.Controls.Add(this.labelGraph1);
			this.groupSkillPower.Controls.Add(this.StatusGraphSPD);
			this.groupSkillPower.Controls.Add(this.StatusGraphMagicDEF);
			this.groupSkillPower.Controls.Add(this.StatusGraphMagicATK);
			this.groupSkillPower.Controls.Add(this.StatusGraphRangeDEF);
			this.groupSkillPower.Controls.Add(this.StatusGraphRangeATK);
			this.groupSkillPower.Controls.Add(this.StatusGraphMeleeDEF);
			this.groupSkillPower.Controls.Add(this.StatusGraphMeleeATK);
			this.groupSkillPower.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupSkillPower.Location = new System.Drawing.Point(0, 0);
			this.groupSkillPower.Name = "groupSkillPower";
			this.groupSkillPower.Size = new System.Drawing.Size(760, 300);
			this.groupSkillPower.TabIndex = 0;
			this.groupSkillPower.TabStop = false;
			this.groupSkillPower.Text = "Skill Power";
			// 
			// labelGraph6
			// 
			this.labelGraph6.Location = new System.Drawing.Point(696, 163);
			this.labelGraph6.Name = "labelGraph6";
			this.labelGraph6.Size = new System.Drawing.Size(40, 12);
			this.labelGraph6.TabIndex = 12;
			this.labelGraph6.Text = "500";
			this.labelGraph6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph5
			// 
			this.labelGraph5.Location = new System.Drawing.Point(596, 163);
			this.labelGraph5.Name = "labelGraph5";
			this.labelGraph5.Size = new System.Drawing.Size(40, 12);
			this.labelGraph5.TabIndex = 11;
			this.labelGraph5.Text = "400";
			this.labelGraph5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph4
			// 
			this.labelGraph4.Location = new System.Drawing.Point(496, 163);
			this.labelGraph4.Name = "labelGraph4";
			this.labelGraph4.Size = new System.Drawing.Size(40, 12);
			this.labelGraph4.TabIndex = 10;
			this.labelGraph4.Text = "300";
			this.labelGraph4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph3
			// 
			this.labelGraph3.Location = new System.Drawing.Point(396, 163);
			this.labelGraph3.Name = "labelGraph3";
			this.labelGraph3.Size = new System.Drawing.Size(40, 12);
			this.labelGraph3.TabIndex = 9;
			this.labelGraph3.Text = "200";
			this.labelGraph3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph2
			// 
			this.labelGraph2.Location = new System.Drawing.Point(296, 163);
			this.labelGraph2.Name = "labelGraph2";
			this.labelGraph2.Size = new System.Drawing.Size(40, 12);
			this.labelGraph2.TabIndex = 8;
			this.labelGraph2.Text = "100";
			this.labelGraph2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph1
			// 
			this.labelGraph1.Location = new System.Drawing.Point(196, 163);
			this.labelGraph1.Name = "labelGraph1";
			this.labelGraph1.Size = new System.Drawing.Size(40, 12);
			this.labelGraph1.TabIndex = 7;
			this.labelGraph1.Text = "0";
			this.labelGraph1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StatusGraphSPD
			// 
			this.StatusGraphSPD.Location = new System.Drawing.Point(15, 140);
			this.StatusGraphSPD.MinStatusValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusGraphSPD.Name = "StatusGraphSPD";
			this.StatusGraphSPD.Size = new System.Drawing.Size(730, 20);
			this.StatusGraphSPD.StatusLabel = "SPD";
			this.StatusGraphSPD.TabIndex = 6;
			// 
			// StatusGraphMagicDEF
			// 
			this.StatusGraphMagicDEF.Location = new System.Drawing.Point(15, 120);
			this.StatusGraphMagicDEF.MinStatusValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusGraphMagicDEF.Name = "StatusGraphMagicDEF";
			this.StatusGraphMagicDEF.Size = new System.Drawing.Size(730, 20);
			this.StatusGraphMagicDEF.StatusLabel = "Magic DEF";
			this.StatusGraphMagicDEF.TabIndex = 5;
			// 
			// StatusGraphMagicATK
			// 
			this.StatusGraphMagicATK.Location = new System.Drawing.Point(15, 100);
			this.StatusGraphMagicATK.MinStatusValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusGraphMagicATK.Name = "StatusGraphMagicATK";
			this.StatusGraphMagicATK.Size = new System.Drawing.Size(730, 20);
			this.StatusGraphMagicATK.StatusLabel = "Magic ATK";
			this.StatusGraphMagicATK.TabIndex = 4;
			// 
			// StatusGraphRangeDEF
			// 
			this.StatusGraphRangeDEF.Location = new System.Drawing.Point(15, 80);
			this.StatusGraphRangeDEF.MinStatusValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusGraphRangeDEF.Name = "StatusGraphRangeDEF";
			this.StatusGraphRangeDEF.Size = new System.Drawing.Size(730, 20);
			this.StatusGraphRangeDEF.StatusLabel = "Range DEF";
			this.StatusGraphRangeDEF.TabIndex = 3;
			// 
			// StatusGraphRangeATK
			// 
			this.StatusGraphRangeATK.Location = new System.Drawing.Point(15, 60);
			this.StatusGraphRangeATK.MinStatusValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusGraphRangeATK.Name = "StatusGraphRangeATK";
			this.StatusGraphRangeATK.Size = new System.Drawing.Size(730, 20);
			this.StatusGraphRangeATK.StatusLabel = "Range ATK";
			this.StatusGraphRangeATK.TabIndex = 2;
			// 
			// StatusGraphMeleeDEF
			// 
			this.StatusGraphMeleeDEF.Location = new System.Drawing.Point(15, 40);
			this.StatusGraphMeleeDEF.MinStatusValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusGraphMeleeDEF.Name = "StatusGraphMeleeDEF";
			this.StatusGraphMeleeDEF.Size = new System.Drawing.Size(730, 20);
			this.StatusGraphMeleeDEF.StatusLabel = "Melee DEF";
			this.StatusGraphMeleeDEF.TabIndex = 1;
			// 
			// StatusGraphMeleeATK
			// 
			this.StatusGraphMeleeATK.Location = new System.Drawing.Point(15, 20);
			this.StatusGraphMeleeATK.MinStatusValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusGraphMeleeATK.Name = "StatusGraphMeleeATK";
			this.StatusGraphMeleeATK.Size = new System.Drawing.Size(730, 20);
			this.StatusGraphMeleeATK.StatusLabel = "Melee ATK";
			this.StatusGraphMeleeATK.TabIndex = 0;
			// 
			// SkillStatusInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupSkillPower);
			this.Name = "SkillStatusInfomation";
			this.Size = new System.Drawing.Size(760, 300);
			this.groupSkillPower.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupSkillPower;
		private CommonParts.StatusGraphParts StatusGraphMeleeATK;
		private CommonParts.StatusGraphParts StatusGraphSPD;
		private CommonParts.StatusGraphParts StatusGraphMagicDEF;
		private CommonParts.StatusGraphParts StatusGraphMagicATK;
		private CommonParts.StatusGraphParts StatusGraphRangeDEF;
		private CommonParts.StatusGraphParts StatusGraphRangeATK;
		private CommonParts.StatusGraphParts StatusGraphMeleeDEF;
		private Label labelGraph6;
		private Label labelGraph5;
		private Label labelGraph4;
		private Label labelGraph3;
		private Label labelGraph2;
		private Label labelGraph1;
	}
}
