using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit {
	partial class DropInfomation {
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
			this.groupDropInfo = new System.Windows.Forms.GroupBox();
			this.dropInfoParts6 = new Status_Editer.User_Control.tab03Unit.Parts.DropInfoParts();
			this.dropInfoParts5 = new Status_Editer.User_Control.tab03Unit.Parts.DropInfoParts();
			this.dropInfoParts4 = new Status_Editer.User_Control.tab03Unit.Parts.DropInfoParts();
			this.dropInfoParts3 = new Status_Editer.User_Control.tab03Unit.Parts.DropInfoParts();
			this.dropInfoParts2 = new Status_Editer.User_Control.tab03Unit.Parts.DropInfoParts();
			this.dropInfoParts1 = new Status_Editer.User_Control.tab03Unit.Parts.DropInfoParts();
			this.groupDropInfo.SuspendLayout();
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
			// groupDropInfo
			// 
			this.groupDropInfo.Controls.Add(this.dropInfoParts6);
			this.groupDropInfo.Controls.Add(this.dropInfoParts5);
			this.groupDropInfo.Controls.Add(this.dropInfoParts4);
			this.groupDropInfo.Controls.Add(this.dropInfoParts3);
			this.groupDropInfo.Controls.Add(this.dropInfoParts2);
			this.groupDropInfo.Controls.Add(this.dropInfoParts1);
			this.groupDropInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupDropInfo.Location = new System.Drawing.Point(0, 0);
			this.groupDropInfo.Name = "groupDropInfo";
			this.groupDropInfo.Size = new System.Drawing.Size(760, 800);
			this.groupDropInfo.TabIndex = 0;
			this.groupDropInfo.TabStop = false;
			this.groupDropInfo.Text = "Drop Infomation";
			// 
			// dropInfoParts6
			// 
			this.dropInfoParts6.BackColor = System.Drawing.Color.Transparent;
			this.dropInfoParts6.labelText = "Accessory";
			this.dropInfoParts6.Location = new System.Drawing.Point(15, 665);
			this.dropInfoParts6.Name = "dropInfoParts6";
			this.dropInfoParts6.Size = new System.Drawing.Size(730, 130);
			this.dropInfoParts6.TabIndex = 5;
			// 
			// dropInfoParts5
			// 
			this.dropInfoParts5.BackColor = System.Drawing.Color.Transparent;
			this.dropInfoParts5.labelText = "Armor";
			this.dropInfoParts5.Location = new System.Drawing.Point(15, 535);
			this.dropInfoParts5.Name = "dropInfoParts5";
			this.dropInfoParts5.Size = new System.Drawing.Size(730, 130);
			this.dropInfoParts5.TabIndex = 4;
			// 
			// dropInfoParts4
			// 
			this.dropInfoParts4.BackColor = System.Drawing.Color.Transparent;
			this.dropInfoParts4.labelText = "Gauntlet";
			this.dropInfoParts4.Location = new System.Drawing.Point(15, 405);
			this.dropInfoParts4.Name = "dropInfoParts4";
			this.dropInfoParts4.Size = new System.Drawing.Size(730, 130);
			this.dropInfoParts4.TabIndex = 3;
			// 
			// dropInfoParts3
			// 
			this.dropInfoParts3.BackColor = System.Drawing.Color.Transparent;
			this.dropInfoParts3.labelText = "Helmet";
			this.dropInfoParts3.Location = new System.Drawing.Point(15, 275);
			this.dropInfoParts3.Name = "dropInfoParts3";
			this.dropInfoParts3.Size = new System.Drawing.Size(730, 130);
			this.dropInfoParts3.TabIndex = 2;
			// 
			// dropInfoParts2
			// 
			this.dropInfoParts2.BackColor = System.Drawing.Color.Transparent;
			this.dropInfoParts2.labelText = "Shield";
			this.dropInfoParts2.Location = new System.Drawing.Point(15, 145);
			this.dropInfoParts2.Name = "dropInfoParts2";
			this.dropInfoParts2.Size = new System.Drawing.Size(730, 130);
			this.dropInfoParts2.TabIndex = 1;
			// 
			// dropInfoParts1
			// 
			this.dropInfoParts1.BackColor = System.Drawing.Color.Transparent;
			this.dropInfoParts1.labelText = "Weapon";
			this.dropInfoParts1.Location = new System.Drawing.Point(15, 15);
			this.dropInfoParts1.Name = "dropInfoParts1";
			this.dropInfoParts1.Size = new System.Drawing.Size(730, 130);
			this.dropInfoParts1.TabIndex = 0;
			// 
			// DropInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupDropInfo);
			this.Name = "DropInfomation";
			this.Size = new System.Drawing.Size(760, 800);
			this.groupDropInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ToolTip toolTipInfo;
		private GroupBox groupDropInfo;
		private Parts.DropInfoParts dropInfoParts1;
		private Parts.DropInfoParts dropInfoParts6;
		private Parts.DropInfoParts dropInfoParts5;
		private Parts.DropInfoParts dropInfoParts4;
		private Parts.DropInfoParts dropInfoParts3;
		private Parts.DropInfoParts dropInfoParts2;
	}
}
