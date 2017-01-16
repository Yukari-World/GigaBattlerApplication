using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab05Race.Parts {
	partial class RaceInfoParts {
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
			this.GroupBoxRaceInfo = new System.Windows.Forms.GroupBox();
			this.textRaceName = new System.Windows.Forms.TextBox();
			this.labelRaceName = new System.Windows.Forms.Label();
			this.textRaceID = new System.Windows.Forms.TextBox();
			this.labelRaceID = new System.Windows.Forms.Label();
			this.labelInfo = new System.Windows.Forms.Label();
			this.textInfo = new System.Windows.Forms.TextBox();
			this.GroupBoxRaceInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBoxRaceInfo
			// 
			this.GroupBoxRaceInfo.Controls.Add(this.labelInfo);
			this.GroupBoxRaceInfo.Controls.Add(this.textInfo);
			this.GroupBoxRaceInfo.Controls.Add(this.textRaceName);
			this.GroupBoxRaceInfo.Controls.Add(this.labelRaceName);
			this.GroupBoxRaceInfo.Controls.Add(this.textRaceID);
			this.GroupBoxRaceInfo.Controls.Add(this.labelRaceID);
			this.GroupBoxRaceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBoxRaceInfo.Location = new System.Drawing.Point(0, 0);
			this.GroupBoxRaceInfo.Name = "GroupBoxRaceInfo";
			this.GroupBoxRaceInfo.Size = new System.Drawing.Size(600, 800);
			this.GroupBoxRaceInfo.TabIndex = 0;
			this.GroupBoxRaceInfo.TabStop = false;
			this.GroupBoxRaceInfo.Text = "Race Infomation";
			// 
			// textRaceName
			// 
			this.textRaceName.Location = new System.Drawing.Point(10, 90);
			this.textRaceName.Name = "textRaceName";
			this.textRaceName.Size = new System.Drawing.Size(465, 19);
			this.textRaceName.TabIndex = 7;
			// 
			// labelRaceName
			// 
			this.labelRaceName.AutoSize = true;
			this.labelRaceName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelRaceName.Location = new System.Drawing.Point(10, 75);
			this.labelRaceName.Name = "labelRaceName";
			this.labelRaceName.Size = new System.Drawing.Size(126, 12);
			this.labelRaceName.TabIndex = 6;
			this.labelRaceName.Text = "Race Name(表記データ):";
			// 
			// textRaceID
			// 
			this.textRaceID.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textRaceID.Location = new System.Drawing.Point(10, 45);
			this.textRaceID.Name = "textRaceID";
			this.textRaceID.Size = new System.Drawing.Size(300, 19);
			this.textRaceID.TabIndex = 5;
			// 
			// labelRaceID
			// 
			this.labelRaceID.AutoSize = true;
			this.labelRaceID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelRaceID.Location = new System.Drawing.Point(10, 30);
			this.labelRaceID.Name = "labelRaceID";
			this.labelRaceID.Size = new System.Drawing.Size(184, 12);
			this.labelRaceID.TabIndex = 4;
			this.labelRaceID.Text = "Race ID(システムで識別されるデータ):";
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelInfo.Location = new System.Drawing.Point(10, 675);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(85, 12);
			this.labelInfo.TabIndex = 45;
			this.labelInfo.Text = "Text Infomation";
			// 
			// textInfo
			// 
			this.textInfo.Location = new System.Drawing.Point(10, 690);
			this.textInfo.Multiline = true;
			this.textInfo.Name = "textInfo";
			this.textInfo.Size = new System.Drawing.Size(580, 100);
			this.textInfo.TabIndex = 46;
			// 
			// RaceInfoParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GroupBoxRaceInfo);
			this.Name = "RaceInfoParts";
			this.Size = new System.Drawing.Size(600, 800);
			this.GroupBoxRaceInfo.ResumeLayout(false);
			this.GroupBoxRaceInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox GroupBoxRaceInfo;
		private TextBox textRaceName;
		private Label labelRaceName;
		private TextBox textRaceID;
		private Label labelRaceID;
		private Label labelInfo;
		private TextBox textInfo;
	}
}
