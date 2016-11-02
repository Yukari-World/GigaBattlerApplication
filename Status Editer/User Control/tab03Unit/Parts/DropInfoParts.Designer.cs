using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit.Parts {
	partial class DropInfoParts {
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
			this.numericDropRate1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelDropRate1 = new System.Windows.Forms.Label();
			this.comboDropTable1 = new System.Windows.Forms.ComboBox();
			this.labelDropTable1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericDropRate1)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			// numericDropRate1
			// 
			this.numericDropRate1.Location = new System.Drawing.Point(355, 31);
			this.numericDropRate1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericDropRate1.Name = "numericDropRate1";
			this.numericDropRate1.Size = new System.Drawing.Size(120, 19);
			this.numericDropRate1.TabIndex = 7;
			this.numericDropRate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericDropRate1.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericDropRate1, "ドロップ率。\r\n0だと絶対に出現せず、10,000だと必ず出現する\r\n設定値: 0 ～ 10,000");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericDropRate1);
			this.groupBox1.Controls.Add(this.labelDropRate1);
			this.groupBox1.Controls.Add(this.comboDropTable1);
			this.groupBox1.Controls.Add(this.labelDropTable1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(750, 130);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// labelDropRate1
			// 
			this.labelDropRate1.AutoSize = true;
			this.labelDropRate1.Location = new System.Drawing.Point(355, 15);
			this.labelDropRate1.Name = "labelDropRate1";
			this.labelDropRate1.Size = new System.Drawing.Size(67, 12);
			this.labelDropRate1.TabIndex = 6;
			this.labelDropRate1.Text = "Drop Rate 1";
			// 
			// comboDropTable1
			// 
			this.comboDropTable1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboDropTable1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboDropTable1.FormattingEnabled = true;
			this.comboDropTable1.Location = new System.Drawing.Point(15, 30);
			this.comboDropTable1.Name = "comboDropTable1";
			this.comboDropTable1.Size = new System.Drawing.Size(300, 20);
			this.comboDropTable1.TabIndex = 5;
			// 
			// labelDropTable1
			// 
			this.labelDropTable1.AutoSize = true;
			this.labelDropTable1.Location = new System.Drawing.Point(15, 15);
			this.labelDropTable1.Name = "labelDropTable1";
			this.labelDropTable1.Size = new System.Drawing.Size(71, 12);
			this.labelDropTable1.TabIndex = 4;
			this.labelDropTable1.Text = "Drop Table 1";
			// 
			// DropInfoParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupBox1);
			this.Name = "DropInfoParts";
			this.Size = new System.Drawing.Size(750, 130);
			((System.ComponentModel.ISupportInitialize)(this.numericDropRate1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolTip toolTipInfo;
		private GroupBox groupBox1;
		private NumericUpDown numericDropRate1;
		private Label labelDropRate1;
		private ComboBox comboDropTable1;
		private Label labelDropTable1;
	}
}
