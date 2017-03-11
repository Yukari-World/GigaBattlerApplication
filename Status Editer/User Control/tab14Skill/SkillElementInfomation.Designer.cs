using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab14Skill {
	partial class SkillElementInfomation {
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
			this.groupElement = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// groupElement
			// 
			this.groupElement.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupElement.Location = new System.Drawing.Point(0, 0);
			this.groupElement.Name = "groupElement";
			this.groupElement.Size = new System.Drawing.Size(760, 520);
			this.groupElement.TabIndex = 0;
			this.groupElement.TabStop = false;
			this.groupElement.Text = "Element Infomation";
			// 
			// SkillElementInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupElement);
			this.Name = "SkillElementInfomation";
			this.Size = new System.Drawing.Size(760, 520);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupElement;
	}
}
