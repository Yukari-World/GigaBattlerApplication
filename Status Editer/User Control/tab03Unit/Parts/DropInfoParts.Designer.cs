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
			this.numericDropRate = new System.Windows.Forms.NumericUpDown();
			this.groupBoxDrop = new System.Windows.Forms.GroupBox();
			this.labelDropRate = new System.Windows.Forms.Label();
			this.comboDropTable = new System.Windows.Forms.ComboBox();
			this.labelDropTable = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericDropRate)).BeginInit();
			this.groupBoxDrop.SuspendLayout();
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
			// numericDropRate
			// 
			this.numericDropRate.Location = new System.Drawing.Point(355, 31);
			this.numericDropRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericDropRate.Name = "numericDropRate";
			this.numericDropRate.Size = new System.Drawing.Size(120, 19);
			this.numericDropRate.TabIndex = 7;
			this.numericDropRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericDropRate.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericDropRate, "ドロップ率。\r\n0だと絶対に出現せず、10,000だと必ず出現する\r\n設定値: 0 ～ 10,000");
			// 
			// groupBoxDrop
			// 
			this.groupBoxDrop.Controls.Add(this.numericDropRate);
			this.groupBoxDrop.Controls.Add(this.labelDropRate);
			this.groupBoxDrop.Controls.Add(this.comboDropTable);
			this.groupBoxDrop.Controls.Add(this.labelDropTable);
			this.groupBoxDrop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxDrop.Location = new System.Drawing.Point(0, 0);
			this.groupBoxDrop.Name = "groupBoxDrop";
			this.groupBoxDrop.Size = new System.Drawing.Size(730, 130);
			this.groupBoxDrop.TabIndex = 0;
			this.groupBoxDrop.TabStop = false;
			this.groupBoxDrop.Text = "groupBox";
			// 
			// labelDropRate
			// 
			this.labelDropRate.AutoSize = true;
			this.labelDropRate.Location = new System.Drawing.Point(355, 15);
			this.labelDropRate.Name = "labelDropRate";
			this.labelDropRate.Size = new System.Drawing.Size(57, 12);
			this.labelDropRate.TabIndex = 6;
			this.labelDropRate.Text = "Drop Rate";
			// 
			// comboDropTable
			// 
			this.comboDropTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboDropTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboDropTable.FormattingEnabled = true;
			this.comboDropTable.Location = new System.Drawing.Point(15, 30);
			this.comboDropTable.Name = "comboDropTable";
			this.comboDropTable.Size = new System.Drawing.Size(300, 20);
			this.comboDropTable.TabIndex = 5;
			// 
			// labelDropTable
			// 
			this.labelDropTable.AutoSize = true;
			this.labelDropTable.Location = new System.Drawing.Point(15, 15);
			this.labelDropTable.Name = "labelDropTable";
			this.labelDropTable.Size = new System.Drawing.Size(61, 12);
			this.labelDropTable.TabIndex = 4;
			this.labelDropTable.Text = "Drop Table";
			// 
			// DropInfoParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupBoxDrop);
			this.Name = "DropInfoParts";
			this.Size = new System.Drawing.Size(730, 130);
			((System.ComponentModel.ISupportInitialize)(this.numericDropRate)).EndInit();
			this.groupBoxDrop.ResumeLayout(false);
			this.groupBoxDrop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolTip toolTipInfo;
		private GroupBox groupBoxDrop;
		private NumericUpDown numericDropRate;
		private Label labelDropRate;
		private ComboBox comboDropTable;
		private Label labelDropTable;
	}
}
