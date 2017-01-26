using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab14Skill.Parts {
	partial class ElementSelectParts {
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
			this.comboElement = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboElement
			// 
			this.comboElement.FormattingEnabled = true;
			this.comboElement.Location = new System.Drawing.Point(5, 5);
			this.comboElement.Name = "comboElement";
			this.comboElement.Size = new System.Drawing.Size(121, 20);
			this.comboElement.TabIndex = 0;
			// 
			// ElementSelectParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.comboElement);
			this.Name = "ElementSelectParts";
			this.Size = new System.Drawing.Size(300, 30);
			this.ResumeLayout(false);

		}

		#endregion

		private ComboBox comboElement;
	}
}
