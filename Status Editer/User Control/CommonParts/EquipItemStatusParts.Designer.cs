using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.CommonParts {
	partial class EquipItemStatusParts {
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
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.GroupItemStatus = new System.Windows.Forms.GroupBox();
			this.labelGraph6 = new System.Windows.Forms.Label();
			this.labelGraph5 = new System.Windows.Forms.Label();
			this.labelGraph4 = new System.Windows.Forms.Label();
			this.labelGraph3 = new System.Windows.Forms.Label();
			this.labelGraph2 = new System.Windows.Forms.Label();
			this.labelGraph1 = new System.Windows.Forms.Label();
			this.StatusGraphEVT = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphHIT = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphLuck = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphSPD = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphMagicDEF = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphMagicATK = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphRangeDEF = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphRangeATK = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphMeleeDEF = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphMeleeATK = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphTP = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.StatusGraphHP = new Status_Editer.User_Control.CommonParts.StatusGraphParts();
			this.GroupItemStatus.SuspendLayout();
			this.SuspendLayout();
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
			// GroupItemStatus
			// 
			this.GroupItemStatus.Controls.Add(this.labelGraph6);
			this.GroupItemStatus.Controls.Add(this.labelGraph5);
			this.GroupItemStatus.Controls.Add(this.labelGraph4);
			this.GroupItemStatus.Controls.Add(this.labelGraph3);
			this.GroupItemStatus.Controls.Add(this.labelGraph2);
			this.GroupItemStatus.Controls.Add(this.labelGraph1);
			this.GroupItemStatus.Controls.Add(this.StatusGraphEVT);
			this.GroupItemStatus.Controls.Add(this.StatusGraphHIT);
			this.GroupItemStatus.Controls.Add(this.StatusGraphLuck);
			this.GroupItemStatus.Controls.Add(this.StatusGraphSPD);
			this.GroupItemStatus.Controls.Add(this.StatusGraphMagicDEF);
			this.GroupItemStatus.Controls.Add(this.StatusGraphMagicATK);
			this.GroupItemStatus.Controls.Add(this.StatusGraphRangeDEF);
			this.GroupItemStatus.Controls.Add(this.StatusGraphRangeATK);
			this.GroupItemStatus.Controls.Add(this.StatusGraphMeleeDEF);
			this.GroupItemStatus.Controls.Add(this.StatusGraphMeleeATK);
			this.GroupItemStatus.Controls.Add(this.StatusGraphTP);
			this.GroupItemStatus.Controls.Add(this.StatusGraphHP);
			this.GroupItemStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupItemStatus.Location = new System.Drawing.Point(0, 0);
			this.GroupItemStatus.Name = "GroupItemStatus";
			this.GroupItemStatus.Size = new System.Drawing.Size(760, 300);
			this.GroupItemStatus.TabIndex = 0;
			this.GroupItemStatus.TabStop = false;
			this.GroupItemStatus.Text = "Item Status";
			// 
			// labelGraph6
			// 
			this.labelGraph6.Location = new System.Drawing.Point(696, 265);
			this.labelGraph6.Name = "labelGraph6";
			this.labelGraph6.Size = new System.Drawing.Size(40, 12);
			this.labelGraph6.TabIndex = 17;
			this.labelGraph6.Text = "500";
			this.labelGraph6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph5
			// 
			this.labelGraph5.Location = new System.Drawing.Point(596, 265);
			this.labelGraph5.Name = "labelGraph5";
			this.labelGraph5.Size = new System.Drawing.Size(40, 12);
			this.labelGraph5.TabIndex = 16;
			this.labelGraph5.Text = "400";
			this.labelGraph5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph4
			// 
			this.labelGraph4.Location = new System.Drawing.Point(496, 265);
			this.labelGraph4.Name = "labelGraph4";
			this.labelGraph4.Size = new System.Drawing.Size(40, 12);
			this.labelGraph4.TabIndex = 15;
			this.labelGraph4.Text = "300";
			this.labelGraph4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph3
			// 
			this.labelGraph3.Location = new System.Drawing.Point(396, 265);
			this.labelGraph3.Name = "labelGraph3";
			this.labelGraph3.Size = new System.Drawing.Size(40, 12);
			this.labelGraph3.TabIndex = 14;
			this.labelGraph3.Text = "200";
			this.labelGraph3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph2
			// 
			this.labelGraph2.Location = new System.Drawing.Point(296, 265);
			this.labelGraph2.Name = "labelGraph2";
			this.labelGraph2.Size = new System.Drawing.Size(40, 12);
			this.labelGraph2.TabIndex = 13;
			this.labelGraph2.Text = "100";
			this.labelGraph2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGraph1
			// 
			this.labelGraph1.Location = new System.Drawing.Point(196, 265);
			this.labelGraph1.Name = "labelGraph1";
			this.labelGraph1.Size = new System.Drawing.Size(40, 12);
			this.labelGraph1.TabIndex = 12;
			this.labelGraph1.Text = "0";
			this.labelGraph1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StatusGraphEVT
			// 
			this.StatusGraphEVT.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphEVT.Location = new System.Drawing.Point(15, 240);
			this.StatusGraphEVT.Name = "StatusGraphEVT";
			this.StatusGraphEVT.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphEVT.StatusLabel = "EVT";
			this.StatusGraphEVT.TabIndex = 11;
			// 
			// StatusGraphHIT
			// 
			this.StatusGraphHIT.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphHIT.Location = new System.Drawing.Point(15, 220);
			this.StatusGraphHIT.Name = "StatusGraphHIT";
			this.StatusGraphHIT.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphHIT.StatusLabel = "HIT";
			this.StatusGraphHIT.TabIndex = 10;
			// 
			// StatusGraphLuck
			// 
			this.StatusGraphLuck.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphLuck.Location = new System.Drawing.Point(15, 200);
			this.StatusGraphLuck.Name = "StatusGraphLuck";
			this.StatusGraphLuck.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphLuck.StatusLabel = "Luck";
			this.StatusGraphLuck.TabIndex = 9;
			// 
			// StatusGraphSPD
			// 
			this.StatusGraphSPD.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphSPD.Location = new System.Drawing.Point(15, 180);
			this.StatusGraphSPD.Name = "StatusGraphSPD";
			this.StatusGraphSPD.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphSPD.StatusLabel = "SPD";
			this.StatusGraphSPD.TabIndex = 8;
			// 
			// StatusGraphMagicDEF
			// 
			this.StatusGraphMagicDEF.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphMagicDEF.Location = new System.Drawing.Point(15, 160);
			this.StatusGraphMagicDEF.Name = "StatusGraphMagicDEF";
			this.StatusGraphMagicDEF.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphMagicDEF.StatusLabel = "Magic DEF";
			this.StatusGraphMagicDEF.TabIndex = 7;
			// 
			// StatusGraphMagicATK
			// 
			this.StatusGraphMagicATK.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphMagicATK.Location = new System.Drawing.Point(15, 140);
			this.StatusGraphMagicATK.Name = "StatusGraphMagicATK";
			this.StatusGraphMagicATK.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphMagicATK.StatusLabel = "Magic ATK";
			this.StatusGraphMagicATK.TabIndex = 6;
			// 
			// StatusGraphRangeDEF
			// 
			this.StatusGraphRangeDEF.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphRangeDEF.Location = new System.Drawing.Point(15, 120);
			this.StatusGraphRangeDEF.Name = "StatusGraphRangeDEF";
			this.StatusGraphRangeDEF.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphRangeDEF.StatusLabel = "Range DEF";
			this.StatusGraphRangeDEF.TabIndex = 5;
			// 
			// StatusGraphRangeATK
			// 
			this.StatusGraphRangeATK.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphRangeATK.Location = new System.Drawing.Point(15, 100);
			this.StatusGraphRangeATK.Name = "StatusGraphRangeATK";
			this.StatusGraphRangeATK.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphRangeATK.StatusLabel = "Range ATK";
			this.StatusGraphRangeATK.TabIndex = 4;
			// 
			// StatusGraphMeleeDEF
			// 
			this.StatusGraphMeleeDEF.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphMeleeDEF.Location = new System.Drawing.Point(15, 80);
			this.StatusGraphMeleeDEF.Name = "StatusGraphMeleeDEF";
			this.StatusGraphMeleeDEF.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphMeleeDEF.StatusLabel = "Melee DEF";
			this.StatusGraphMeleeDEF.TabIndex = 3;
			// 
			// StatusGraphMeleeATK
			// 
			this.StatusGraphMeleeATK.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphMeleeATK.Location = new System.Drawing.Point(15, 60);
			this.StatusGraphMeleeATK.Name = "StatusGraphMeleeATK";
			this.StatusGraphMeleeATK.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphMeleeATK.StatusLabel = "Melee ATK";
			this.StatusGraphMeleeATK.TabIndex = 2;
			// 
			// StatusGraphTP
			// 
			this.StatusGraphTP.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphTP.Location = new System.Drawing.Point(15, 40);
			this.StatusGraphTP.Name = "StatusGraphTP";
			this.StatusGraphTP.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphTP.StatusLabel = "TP";
			this.StatusGraphTP.TabIndex = 1;
			// 
			// StatusGraphHP
			// 
			this.StatusGraphHP.BackColor = System.Drawing.Color.Transparent;
			this.StatusGraphHP.Location = new System.Drawing.Point(15, 20);
			this.StatusGraphHP.Name = "StatusGraphHP";
			this.StatusGraphHP.Size = new System.Drawing.Size(1050, 20);
			this.StatusGraphHP.StatusLabel = "HP";
			this.StatusGraphHP.TabIndex = 0;
			// 
			// EquipItemStatusParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GroupItemStatus);
			this.Name = "EquipItemStatusParts";
			this.Size = new System.Drawing.Size(760, 300);
			this.GroupItemStatus.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ToolTip toolTipInfo;
		private GroupBox GroupItemStatus;
		private StatusGraphParts StatusGraphHIT;
		private StatusGraphParts StatusGraphLuck;
		private StatusGraphParts StatusGraphSPD;
		private StatusGraphParts StatusGraphMagicDEF;
		private StatusGraphParts StatusGraphMagicATK;
		private StatusGraphParts StatusGraphRangeDEF;
		private StatusGraphParts StatusGraphRangeATK;
		private StatusGraphParts StatusGraphMeleeDEF;
		private StatusGraphParts StatusGraphMeleeATK;
		private StatusGraphParts StatusGraphTP;
		private StatusGraphParts StatusGraphHP;
		private StatusGraphParts StatusGraphEVT;
		private Label labelGraph6;
		private Label labelGraph5;
		private Label labelGraph4;
		private Label labelGraph3;
		private Label labelGraph2;
		private Label labelGraph1;
	}
}
