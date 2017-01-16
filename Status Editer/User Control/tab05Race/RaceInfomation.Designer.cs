using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab05Race {
	partial class RaceInfomation {
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
			this.groupRaceInfo = new System.Windows.Forms.GroupBox();
			this.raceInfoParts1 = new Status_Editer.User_Control.tab05Race.Parts.RaceInfoParts();
			this.raceStatusEVT = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusHIT = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusLuck = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusSPD = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusMagicDEF = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusMagicATK = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusRangeDEF = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusRangeATK = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusMeleeDEF = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusMeleeATK = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusTP = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.raceStatusHP = new Status_Editer.User_Control.tab05Race.Parts.RaceStatusBasicParts();
			this.groupRaceInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupRaceInfo
			// 
			this.groupRaceInfo.Controls.Add(this.raceInfoParts1);
			this.groupRaceInfo.Controls.Add(this.raceStatusEVT);
			this.groupRaceInfo.Controls.Add(this.raceStatusHIT);
			this.groupRaceInfo.Controls.Add(this.raceStatusLuck);
			this.groupRaceInfo.Controls.Add(this.raceStatusSPD);
			this.groupRaceInfo.Controls.Add(this.raceStatusMagicDEF);
			this.groupRaceInfo.Controls.Add(this.raceStatusMagicATK);
			this.groupRaceInfo.Controls.Add(this.raceStatusRangeDEF);
			this.groupRaceInfo.Controls.Add(this.raceStatusRangeATK);
			this.groupRaceInfo.Controls.Add(this.raceStatusMeleeDEF);
			this.groupRaceInfo.Controls.Add(this.raceStatusMeleeATK);
			this.groupRaceInfo.Controls.Add(this.raceStatusTP);
			this.groupRaceInfo.Controls.Add(this.raceStatusHP);
			this.groupRaceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupRaceInfo.Location = new System.Drawing.Point(0, 0);
			this.groupRaceInfo.Name = "groupRaceInfo";
			this.groupRaceInfo.Size = new System.Drawing.Size(1380, 820);
			this.groupRaceInfo.TabIndex = 0;
			this.groupRaceInfo.TabStop = false;
			this.groupRaceInfo.Text = "Race Infomation";
			// 
			// raceInfoParts1
			// 
			this.raceInfoParts1.Location = new System.Drawing.Point(10, 15);
			this.raceInfoParts1.Name = "raceInfoParts1";
			this.raceInfoParts1.Size = new System.Drawing.Size(600, 800);
			this.raceInfoParts1.TabIndex = 0;
			// 
			// raceStatusEVT
			// 
			this.raceStatusEVT.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusEVT.labelText = "EVT";
			this.raceStatusEVT.Location = new System.Drawing.Point(670, 675);
			this.raceStatusEVT.Name = "raceStatusEVT";
			this.raceStatusEVT.Size = new System.Drawing.Size(700, 60);
			this.raceStatusEVT.TabIndex = 12;
			// 
			// raceStatusHIT
			// 
			this.raceStatusHIT.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusHIT.labelText = "HIT";
			this.raceStatusHIT.Location = new System.Drawing.Point(670, 615);
			this.raceStatusHIT.Name = "raceStatusHIT";
			this.raceStatusHIT.Size = new System.Drawing.Size(700, 60);
			this.raceStatusHIT.TabIndex = 11;
			// 
			// raceStatusLuck
			// 
			this.raceStatusLuck.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusLuck.labelText = "Luck";
			this.raceStatusLuck.Location = new System.Drawing.Point(670, 555);
			this.raceStatusLuck.Name = "raceStatusLuck";
			this.raceStatusLuck.Size = new System.Drawing.Size(700, 60);
			this.raceStatusLuck.TabIndex = 10;
			// 
			// raceStatusSPD
			// 
			this.raceStatusSPD.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusSPD.labelText = "SPD";
			this.raceStatusSPD.Location = new System.Drawing.Point(670, 495);
			this.raceStatusSPD.Name = "raceStatusSPD";
			this.raceStatusSPD.Size = new System.Drawing.Size(700, 60);
			this.raceStatusSPD.TabIndex = 9;
			// 
			// raceStatusMagicDEF
			// 
			this.raceStatusMagicDEF.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusMagicDEF.labelText = "Magic DEF";
			this.raceStatusMagicDEF.Location = new System.Drawing.Point(670, 435);
			this.raceStatusMagicDEF.Name = "raceStatusMagicDEF";
			this.raceStatusMagicDEF.Size = new System.Drawing.Size(700, 60);
			this.raceStatusMagicDEF.TabIndex = 8;
			// 
			// raceStatusMagicATK
			// 
			this.raceStatusMagicATK.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusMagicATK.labelText = "Magic ATK";
			this.raceStatusMagicATK.Location = new System.Drawing.Point(670, 375);
			this.raceStatusMagicATK.Name = "raceStatusMagicATK";
			this.raceStatusMagicATK.Size = new System.Drawing.Size(700, 60);
			this.raceStatusMagicATK.TabIndex = 7;
			// 
			// raceStatusRangeDEF
			// 
			this.raceStatusRangeDEF.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusRangeDEF.labelText = "Range DEF";
			this.raceStatusRangeDEF.Location = new System.Drawing.Point(670, 315);
			this.raceStatusRangeDEF.Name = "raceStatusRangeDEF";
			this.raceStatusRangeDEF.Size = new System.Drawing.Size(700, 60);
			this.raceStatusRangeDEF.TabIndex = 6;
			// 
			// raceStatusRangeATK
			// 
			this.raceStatusRangeATK.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusRangeATK.labelText = "Range ATK";
			this.raceStatusRangeATK.Location = new System.Drawing.Point(670, 255);
			this.raceStatusRangeATK.Name = "raceStatusRangeATK";
			this.raceStatusRangeATK.Size = new System.Drawing.Size(700, 60);
			this.raceStatusRangeATK.TabIndex = 5;
			// 
			// raceStatusMeleeDEF
			// 
			this.raceStatusMeleeDEF.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusMeleeDEF.labelText = "Melee DEF";
			this.raceStatusMeleeDEF.Location = new System.Drawing.Point(670, 195);
			this.raceStatusMeleeDEF.Name = "raceStatusMeleeDEF";
			this.raceStatusMeleeDEF.Size = new System.Drawing.Size(700, 60);
			this.raceStatusMeleeDEF.TabIndex = 4;
			// 
			// raceStatusMeleeATK
			// 
			this.raceStatusMeleeATK.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusMeleeATK.labelText = "Melee ATK";
			this.raceStatusMeleeATK.Location = new System.Drawing.Point(670, 135);
			this.raceStatusMeleeATK.Name = "raceStatusMeleeATK";
			this.raceStatusMeleeATK.Size = new System.Drawing.Size(700, 60);
			this.raceStatusMeleeATK.TabIndex = 3;
			// 
			// raceStatusTP
			// 
			this.raceStatusTP.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusTP.labelText = "TP";
			this.raceStatusTP.Location = new System.Drawing.Point(670, 75);
			this.raceStatusTP.Name = "raceStatusTP";
			this.raceStatusTP.Size = new System.Drawing.Size(700, 60);
			this.raceStatusTP.TabIndex = 2;
			// 
			// raceStatusHP
			// 
			this.raceStatusHP.BackColor = System.Drawing.Color.Transparent;
			this.raceStatusHP.labelText = "HP";
			this.raceStatusHP.Location = new System.Drawing.Point(670, 15);
			this.raceStatusHP.Name = "raceStatusHP";
			this.raceStatusHP.Size = new System.Drawing.Size(700, 60);
			this.raceStatusHP.TabIndex = 1;
			// 
			// RaceInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupRaceInfo);
			this.Name = "RaceInfomation";
			this.Size = new System.Drawing.Size(1380, 820);
			this.groupRaceInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupRaceInfo;
		private Parts.RaceStatusBasicParts raceStatusHP;
		private Parts.RaceStatusBasicParts raceStatusLuck;
		private Parts.RaceStatusBasicParts raceStatusSPD;
		private Parts.RaceStatusBasicParts raceStatusMagicDEF;
		private Parts.RaceStatusBasicParts raceStatusMagicATK;
		private Parts.RaceStatusBasicParts raceStatusRangeDEF;
		private Parts.RaceStatusBasicParts raceStatusRangeATK;
		private Parts.RaceStatusBasicParts raceStatusMeleeDEF;
		private Parts.RaceStatusBasicParts raceStatusMeleeATK;
		private Parts.RaceStatusBasicParts raceStatusTP;
		private Parts.RaceStatusBasicParts raceStatusEVT;
		private Parts.RaceStatusBasicParts raceStatusHIT;
		private Parts.RaceInfoParts raceInfoParts1;
	}
}
