namespace Status_Editer.User_Control.tab08Weapon {
	partial class WeaponInfomation {
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
			this.groupWeapon = new System.Windows.Forms.GroupBox();
			this.EquipItemStatusParts = new Status_Editer.User_Control.CommonParts.EquipItemStatusParts();
			this.itemInfoParts1 = new Status_Editer.User_Control.CommonParts.ItemInfoParts();
			this.groupWeapon.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupWeapon
			// 
			this.groupWeapon.Controls.Add(this.itemInfoParts1);
			this.groupWeapon.Controls.Add(this.EquipItemStatusParts);
			this.groupWeapon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupWeapon.Location = new System.Drawing.Point(0, 0);
			this.groupWeapon.Name = "groupWeapon";
			this.groupWeapon.Size = new System.Drawing.Size(1380, 820);
			this.groupWeapon.TabIndex = 0;
			this.groupWeapon.TabStop = false;
			this.groupWeapon.Text = "Weapon Infomation";
			// 
			// EquipItemStatusParts
			// 
			this.EquipItemStatusParts.BackColor = System.Drawing.Color.Transparent;
			this.EquipItemStatusParts.Location = new System.Drawing.Point(610, 15);
			this.EquipItemStatusParts.Name = "EquipItemStatusParts";
			this.EquipItemStatusParts.Size = new System.Drawing.Size(760, 300);
			this.EquipItemStatusParts.TabIndex = 0;
			// 
			// itemInfoParts1
			// 
			this.itemInfoParts1.BackColor = System.Drawing.Color.Transparent;
			this.itemInfoParts1.Location = new System.Drawing.Point(10, 15);
			this.itemInfoParts1.Name = "itemInfoParts1";
			this.itemInfoParts1.Size = new System.Drawing.Size(600, 800);
			this.itemInfoParts1.TabIndex = 1;
			// 
			// WeaponInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupWeapon);
			this.Name = "WeaponInfomation";
			this.Size = new System.Drawing.Size(1380, 820);
			this.groupWeapon.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupWeapon;
		private CommonParts.EquipItemStatusParts EquipItemStatusParts;
		private CommonParts.ItemInfoParts itemInfoParts1;
	}
}
