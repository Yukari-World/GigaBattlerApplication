using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab06Job {
	partial class JobInfomation {
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
			this.groupJobInfo = new System.Windows.Forms.GroupBox();
			this.JobStatusEVT = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusHIT = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusLuck = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusSPD = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusMagicDEF = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusMagicATK = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusRangeDEF = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusRangeATK = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusMeleeDEF = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusMeleeATK = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusTP = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.JobStatusHP = new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.groupJobInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupJobInfo
			// 
			this.groupJobInfo.Controls.Add(this.JobStatusEVT);
			this.groupJobInfo.Controls.Add(this.JobStatusHIT);
			this.groupJobInfo.Controls.Add(this.JobStatusLuck);
			this.groupJobInfo.Controls.Add(this.JobStatusSPD);
			this.groupJobInfo.Controls.Add(this.JobStatusMagicDEF);
			this.groupJobInfo.Controls.Add(this.JobStatusMagicATK);
			this.groupJobInfo.Controls.Add(this.JobStatusRangeDEF);
			this.groupJobInfo.Controls.Add(this.JobStatusRangeATK);
			this.groupJobInfo.Controls.Add(this.JobStatusMeleeDEF);
			this.groupJobInfo.Controls.Add(this.JobStatusMeleeATK);
			this.groupJobInfo.Controls.Add(this.JobStatusTP);
			this.groupJobInfo.Controls.Add(this.JobStatusHP);
			this.groupJobInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupJobInfo.Location = new System.Drawing.Point(0, 0);
			this.groupJobInfo.Name = "groupJobInfo";
			this.groupJobInfo.Size = new System.Drawing.Size(1380, 820);
			this.groupJobInfo.TabIndex = 0;
			this.groupJobInfo.TabStop = false;
			this.groupJobInfo.Text = "Job Infomation";
			// 
			// JobStatusEVT
			// 
			this.JobStatusEVT.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusEVT.labelText = "EVT";
			this.JobStatusEVT.Location = new System.Drawing.Point(720, 675);
			this.JobStatusEVT.Name = "JobStatusEVT";
			this.JobStatusEVT.Size = new System.Drawing.Size(650, 60);
			this.JobStatusEVT.TabIndex = 11;
			this.JobStatusEVT.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusEVT_CostMultiplierChanged);
			// 
			// JobStatusHIT
			// 
			this.JobStatusHIT.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusHIT.labelText = "HIT";
			this.JobStatusHIT.Location = new System.Drawing.Point(720, 615);
			this.JobStatusHIT.Name = "JobStatusHIT";
			this.JobStatusHIT.Size = new System.Drawing.Size(650, 60);
			this.JobStatusHIT.TabIndex = 10;
			this.JobStatusHIT.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusHIT_CostMultiplierChanged);
			// 
			// JobStatusLuck
			// 
			this.JobStatusLuck.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusLuck.labelText = "Luck";
			this.JobStatusLuck.Location = new System.Drawing.Point(720, 555);
			this.JobStatusLuck.Name = "JobStatusLuck";
			this.JobStatusLuck.Size = new System.Drawing.Size(650, 60);
			this.JobStatusLuck.TabIndex = 9;
			this.JobStatusLuck.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusLuck_CostMultiplierChanged);
			// 
			// JobStatusSPD
			// 
			this.JobStatusSPD.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusSPD.labelText = "SPD";
			this.JobStatusSPD.Location = new System.Drawing.Point(720, 495);
			this.JobStatusSPD.Name = "JobStatusSPD";
			this.JobStatusSPD.Size = new System.Drawing.Size(650, 60);
			this.JobStatusSPD.TabIndex = 8;
			this.JobStatusSPD.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusSPD_CostMultiplierChanged);
			// 
			// JobStatusMagicDEF
			// 
			this.JobStatusMagicDEF.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusMagicDEF.labelText = "Magic DEF";
			this.JobStatusMagicDEF.Location = new System.Drawing.Point(720, 435);
			this.JobStatusMagicDEF.Name = "JobStatusMagicDEF";
			this.JobStatusMagicDEF.Size = new System.Drawing.Size(650, 60);
			this.JobStatusMagicDEF.TabIndex = 7;
			this.JobStatusMagicDEF.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusMagicDEF_CostMultiplierChanged);
			// 
			// JobStatusMagicATK
			// 
			this.JobStatusMagicATK.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusMagicATK.labelText = "Magic ATK";
			this.JobStatusMagicATK.Location = new System.Drawing.Point(720, 375);
			this.JobStatusMagicATK.Name = "JobStatusMagicATK";
			this.JobStatusMagicATK.Size = new System.Drawing.Size(650, 60);
			this.JobStatusMagicATK.TabIndex = 6;
			this.JobStatusMagicATK.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusMagicATK_CostMultiplierChanged);
			// 
			// JobStatusRangeDEF
			// 
			this.JobStatusRangeDEF.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusRangeDEF.labelText = "Range DEF";
			this.JobStatusRangeDEF.Location = new System.Drawing.Point(720, 315);
			this.JobStatusRangeDEF.Name = "JobStatusRangeDEF";
			this.JobStatusRangeDEF.Size = new System.Drawing.Size(650, 60);
			this.JobStatusRangeDEF.TabIndex = 5;
			this.JobStatusRangeDEF.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusRangeDEF_CostMultiplierChanged);
			// 
			// JobStatusRangeATK
			// 
			this.JobStatusRangeATK.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusRangeATK.labelText = "Range ATK";
			this.JobStatusRangeATK.Location = new System.Drawing.Point(720, 255);
			this.JobStatusRangeATK.Name = "JobStatusRangeATK";
			this.JobStatusRangeATK.Size = new System.Drawing.Size(650, 60);
			this.JobStatusRangeATK.TabIndex = 4;
			this.JobStatusRangeATK.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusRangeATK_CostMultiplierChanged);
			// 
			// JobStatusMeleeDEF
			// 
			this.JobStatusMeleeDEF.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusMeleeDEF.labelText = "Melee DEF";
			this.JobStatusMeleeDEF.Location = new System.Drawing.Point(720, 195);
			this.JobStatusMeleeDEF.Name = "JobStatusMeleeDEF";
			this.JobStatusMeleeDEF.Size = new System.Drawing.Size(650, 60);
			this.JobStatusMeleeDEF.TabIndex = 3;
			this.JobStatusMeleeDEF.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusMeleeDEF_CostMultiplierChanged);
			// 
			// JobStatusMeleeATK
			// 
			this.JobStatusMeleeATK.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusMeleeATK.labelText = "Melee ATK";
			this.JobStatusMeleeATK.Location = new System.Drawing.Point(720, 135);
			this.JobStatusMeleeATK.Name = "JobStatusMeleeATK";
			this.JobStatusMeleeATK.Size = new System.Drawing.Size(650, 60);
			this.JobStatusMeleeATK.TabIndex = 2;
			this.JobStatusMeleeATK.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusMeleeATK_CostMultiplierChanged);
			// 
			// JobStatusTP
			// 
			this.JobStatusTP.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusTP.labelText = "TP";
			this.JobStatusTP.Location = new System.Drawing.Point(720, 75);
			this.JobStatusTP.Name = "JobStatusTP";
			this.JobStatusTP.Size = new System.Drawing.Size(650, 60);
			this.JobStatusTP.TabIndex = 1;
			this.JobStatusTP.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusTP_CostMultiplierChanged);
			// 
			// JobStatusHP
			// 
			this.JobStatusHP.BackColor = System.Drawing.Color.Transparent;
			this.JobStatusHP.labelText = "HP";
			this.JobStatusHP.Location = new System.Drawing.Point(720, 15);
			this.JobStatusHP.Name = "JobStatusHP";
			this.JobStatusHP.Size = new System.Drawing.Size(650, 60);
			this.JobStatusHP.TabIndex = 0;
			this.JobStatusHP.CostMultiplierChanged += new Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts.BaseValueChangedEventHandler(this.JobStatusHP_CostMultiplierChanged);
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
			this.groupJobInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupJobInfo;
		private ToolTip toolTipInfo;
		private Parts.JobStatusBasicParts JobStatusHP;
		private Parts.JobStatusBasicParts JobStatusLuck;
		private Parts.JobStatusBasicParts JobStatusSPD;
		private Parts.JobStatusBasicParts JobStatusMagicDEF;
		private Parts.JobStatusBasicParts JobStatusMagicATK;
		private Parts.JobStatusBasicParts JobStatusRangeDEF;
		private Parts.JobStatusBasicParts JobStatusRangeATK;
		private Parts.JobStatusBasicParts JobStatusMeleeDEF;
		private Parts.JobStatusBasicParts JobStatusMeleeATK;
		private Parts.JobStatusBasicParts JobStatusTP;
		private Parts.JobStatusBasicParts JobStatusEVT;
		private Parts.JobStatusBasicParts JobStatusHIT;
	}
}
