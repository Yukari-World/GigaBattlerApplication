using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.CommonParts {
	partial class StatusGraphParts {
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
			this.numericValue = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
			this.SuspendLayout();
			// 
			// numericValue
			// 
			this.numericValue.Location = new System.Drawing.Point(100, 1);
			this.numericValue.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.numericValue.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
			this.numericValue.Name = "numericValue";
			this.numericValue.Size = new System.Drawing.Size(80, 19);
			this.numericValue.TabIndex = 1;
			this.numericValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericValue.ThousandsSeparator = true;
			this.numericValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Label";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// StatusGraphParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericValue);
			this.Name = "StatusGraphParts";
			this.Size = new System.Drawing.Size(730, 20);
			this.Load += new System.EventHandler(this.ItemStatusParts_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemStatusParts_Paint);
			((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private NumericUpDown numericValue;
		private Label label1;
		private ToolTip toolTipInfo;
	}
}
