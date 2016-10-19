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
			this.components = new Container();
			this.toolTipInfo = new ToolTip(this.components);
			this.groupDropInfo = new GroupBox();
			this.numericDropRate4 = new NumericUpDown();
			this.labelDropRate4 = new Label();
			this.comboDropTable4 = new ComboBox();
			this.labelDropTable4 = new Label();
			this.numericDropRate5 = new NumericUpDown();
			this.labelDropRate5 = new Label();
			this.comboDropTable5 = new ComboBox();
			this.labelDropTable5 = new Label();
			this.numericDropRate3 = new NumericUpDown();
			this.labelDropRate3 = new Label();
			this.comboDropTable3 = new ComboBox();
			this.labelDropTable3 = new Label();
			this.numericDropRate2 = new NumericUpDown();
			this.labelDropRate2 = new Label();
			this.comboDropTable2 = new ComboBox();
			this.labelDropTable2 = new Label();
			this.numericDropRate1 = new NumericUpDown();
			this.labelDropRate1 = new Label();
			this.comboDropTable1 = new ComboBox();
			this.labelDropTable1 = new Label();
			this.groupDropInfo.SuspendLayout();
			((ISupportInitialize)(this.numericDropRate4)).BeginInit();
			((ISupportInitialize)(this.numericDropRate5)).BeginInit();
			((ISupportInitialize)(this.numericDropRate3)).BeginInit();
			((ISupportInitialize)(this.numericDropRate2)).BeginInit();
			((ISupportInitialize)(this.numericDropRate1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolTipInfo
			// 
			this.toolTipInfo.AutoPopDelay = 50000;
			this.toolTipInfo.InitialDelay = 500;
			this.toolTipInfo.IsBalloon = true;
			this.toolTipInfo.ReshowDelay = 100;
			this.toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
			this.toolTipInfo.ToolTipTitle = "Infomation";
			// 
			// groupDropInfo
			// 
			this.groupDropInfo.Controls.Add(this.numericDropRate4);
			this.groupDropInfo.Controls.Add(this.labelDropRate4);
			this.groupDropInfo.Controls.Add(this.comboDropTable4);
			this.groupDropInfo.Controls.Add(this.labelDropTable4);
			this.groupDropInfo.Controls.Add(this.numericDropRate5);
			this.groupDropInfo.Controls.Add(this.labelDropRate5);
			this.groupDropInfo.Controls.Add(this.comboDropTable5);
			this.groupDropInfo.Controls.Add(this.labelDropTable5);
			this.groupDropInfo.Controls.Add(this.numericDropRate3);
			this.groupDropInfo.Controls.Add(this.labelDropRate3);
			this.groupDropInfo.Controls.Add(this.comboDropTable3);
			this.groupDropInfo.Controls.Add(this.labelDropTable3);
			this.groupDropInfo.Controls.Add(this.numericDropRate2);
			this.groupDropInfo.Controls.Add(this.labelDropRate2);
			this.groupDropInfo.Controls.Add(this.comboDropTable2);
			this.groupDropInfo.Controls.Add(this.labelDropTable2);
			this.groupDropInfo.Controls.Add(this.numericDropRate1);
			this.groupDropInfo.Controls.Add(this.labelDropRate1);
			this.groupDropInfo.Controls.Add(this.comboDropTable1);
			this.groupDropInfo.Controls.Add(this.labelDropTable1);
			this.groupDropInfo.Dock = DockStyle.Fill;
			this.groupDropInfo.Location = new Point(0, 0);
			this.groupDropInfo.Name = "groupDropInfo";
			this.groupDropInfo.Size = new Size(760, 800);
			this.groupDropInfo.TabIndex = 0;
			this.groupDropInfo.TabStop = false;
			this.groupDropInfo.Text = "Drop Infomation";
			// 
			// numericDropRate4
			// 
			this.numericDropRate4.Location = new Point(350, 466);
			this.numericDropRate4.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numericDropRate4.Name = "numericDropRate4";
			this.numericDropRate4.Size = new Size(120, 19);
			this.numericDropRate4.TabIndex = 15;
			this.numericDropRate4.TextAlign = HorizontalAlignment.Right;
			this.numericDropRate4.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericDropRate4, "ドロップ率。\r\n0だと絶対に出現せず、10,000だと必ず出現する\r\n設定値: 0 ～ 10,000");
			// 
			// labelDropRate4
			// 
			this.labelDropRate4.AutoSize = true;
			this.labelDropRate4.Location = new Point(350, 450);
			this.labelDropRate4.Name = "labelDropRate4";
			this.labelDropRate4.Size = new Size(67, 12);
			this.labelDropRate4.TabIndex = 14;
			this.labelDropRate4.Text = "Drop Rate 4";
			// 
			// comboDropTable4
			// 
			this.comboDropTable4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboDropTable4.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboDropTable4.FormattingEnabled = true;
			this.comboDropTable4.Location = new Point(10, 465);
			this.comboDropTable4.Name = "comboDropTable4";
			this.comboDropTable4.Size = new Size(300, 20);
			this.comboDropTable4.TabIndex = 13;
			// 
			// labelDropTable4
			// 
			this.labelDropTable4.AutoSize = true;
			this.labelDropTable4.Location = new Point(10, 450);
			this.labelDropTable4.Name = "labelDropTable4";
			this.labelDropTable4.Size = new Size(71, 12);
			this.labelDropTable4.TabIndex = 12;
			this.labelDropTable4.Text = "Drop Table 4";
			// 
			// numericDropRate5
			// 
			this.numericDropRate5.Location = new Point(350, 616);
			this.numericDropRate5.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numericDropRate5.Name = "numericDropRate5";
			this.numericDropRate5.Size = new Size(120, 19);
			this.numericDropRate5.TabIndex = 19;
			this.numericDropRate5.TextAlign = HorizontalAlignment.Right;
			this.numericDropRate5.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericDropRate5, "ドロップ率。\r\n0だと絶対に出現せず、10,000だと必ず出現する\r\n設定値: 0 ～ 10,000");
			// 
			// labelDropRate5
			// 
			this.labelDropRate5.AutoSize = true;
			this.labelDropRate5.Location = new Point(350, 600);
			this.labelDropRate5.Name = "labelDropRate5";
			this.labelDropRate5.Size = new Size(67, 12);
			this.labelDropRate5.TabIndex = 18;
			this.labelDropRate5.Text = "Drop Rate 5";
			// 
			// comboDropTable5
			// 
			this.comboDropTable5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboDropTable5.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboDropTable5.FormattingEnabled = true;
			this.comboDropTable5.Location = new Point(10, 615);
			this.comboDropTable5.Name = "comboDropTable5";
			this.comboDropTable5.Size = new Size(300, 20);
			this.comboDropTable5.TabIndex = 17;
			// 
			// labelDropTable5
			// 
			this.labelDropTable5.AutoSize = true;
			this.labelDropTable5.Location = new Point(10, 600);
			this.labelDropTable5.Name = "labelDropTable5";
			this.labelDropTable5.Size = new Size(71, 12);
			this.labelDropTable5.TabIndex = 16;
			this.labelDropTable5.Text = "Drop Table 5";
			// 
			// numericDropRate3
			// 
			this.numericDropRate3.Location = new Point(350, 316);
			this.numericDropRate3.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numericDropRate3.Name = "numericDropRate3";
			this.numericDropRate3.Size = new Size(120, 19);
			this.numericDropRate3.TabIndex = 11;
			this.numericDropRate3.TextAlign = HorizontalAlignment.Right;
			this.numericDropRate3.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericDropRate3, "ドロップ率。\r\n0だと絶対に出現せず、10,000だと必ず出現する\r\n設定値: 0 ～ 10,000");
			// 
			// labelDropRate3
			// 
			this.labelDropRate3.AutoSize = true;
			this.labelDropRate3.Location = new Point(350, 300);
			this.labelDropRate3.Name = "labelDropRate3";
			this.labelDropRate3.Size = new Size(67, 12);
			this.labelDropRate3.TabIndex = 10;
			this.labelDropRate3.Text = "Drop Rate 3";
			// 
			// comboDropTable3
			// 
			this.comboDropTable3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboDropTable3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboDropTable3.FormattingEnabled = true;
			this.comboDropTable3.Location = new Point(10, 315);
			this.comboDropTable3.Name = "comboDropTable3";
			this.comboDropTable3.Size = new Size(300, 20);
			this.comboDropTable3.TabIndex = 9;
			// 
			// labelDropTable3
			// 
			this.labelDropTable3.AutoSize = true;
			this.labelDropTable3.Location = new Point(10, 300);
			this.labelDropTable3.Name = "labelDropTable3";
			this.labelDropTable3.Size = new Size(71, 12);
			this.labelDropTable3.TabIndex = 8;
			this.labelDropTable3.Text = "Drop Table 3";
			// 
			// numericDropRate2
			// 
			this.numericDropRate2.Location = new Point(350, 166);
			this.numericDropRate2.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numericDropRate2.Name = "numericDropRate2";
			this.numericDropRate2.Size = new Size(120, 19);
			this.numericDropRate2.TabIndex = 7;
			this.numericDropRate2.TextAlign = HorizontalAlignment.Right;
			this.numericDropRate2.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericDropRate2, "ドロップ率。\r\n0だと絶対に出現せず、10,000だと必ず出現する\r\n設定値: 0 ～ 10,000");
			// 
			// labelDropRate2
			// 
			this.labelDropRate2.AutoSize = true;
			this.labelDropRate2.Location = new Point(350, 150);
			this.labelDropRate2.Name = "labelDropRate2";
			this.labelDropRate2.Size = new Size(67, 12);
			this.labelDropRate2.TabIndex = 6;
			this.labelDropRate2.Text = "Drop Rate 2";
			// 
			// comboDropTable2
			// 
			this.comboDropTable2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboDropTable2.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboDropTable2.FormattingEnabled = true;
			this.comboDropTable2.Location = new Point(10, 165);
			this.comboDropTable2.Name = "comboDropTable2";
			this.comboDropTable2.Size = new Size(300, 20);
			this.comboDropTable2.TabIndex = 5;
			// 
			// labelDropTable2
			// 
			this.labelDropTable2.AutoSize = true;
			this.labelDropTable2.Location = new Point(10, 150);
			this.labelDropTable2.Name = "labelDropTable2";
			this.labelDropTable2.Size = new Size(71, 12);
			this.labelDropTable2.TabIndex = 4;
			this.labelDropTable2.Text = "Drop Table 2";
			// 
			// numericDropRate1
			// 
			this.numericDropRate1.Location = new Point(350, 36);
			this.numericDropRate1.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numericDropRate1.Name = "numericDropRate1";
			this.numericDropRate1.Size = new Size(120, 19);
			this.numericDropRate1.TabIndex = 3;
			this.numericDropRate1.TextAlign = HorizontalAlignment.Right;
			this.numericDropRate1.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericDropRate1, "ドロップ率。\r\n0だと絶対に出現せず、10,000だと必ず出現する\r\n設定値: 0 ～ 10,000");
			// 
			// labelDropRate1
			// 
			this.labelDropRate1.AutoSize = true;
			this.labelDropRate1.Location = new Point(350, 20);
			this.labelDropRate1.Name = "labelDropRate1";
			this.labelDropRate1.Size = new Size(67, 12);
			this.labelDropRate1.TabIndex = 2;
			this.labelDropRate1.Text = "Drop Rate 1";
			// 
			// comboDropTable1
			// 
			this.comboDropTable1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboDropTable1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboDropTable1.FormattingEnabled = true;
			this.comboDropTable1.Location = new Point(10, 35);
			this.comboDropTable1.Name = "comboDropTable1";
			this.comboDropTable1.Size = new Size(300, 20);
			this.comboDropTable1.TabIndex = 1;
			// 
			// labelDropTable1
			// 
			this.labelDropTable1.AutoSize = true;
			this.labelDropTable1.Location = new Point(10, 20);
			this.labelDropTable1.Name = "labelDropTable1";
			this.labelDropTable1.Size = new Size(71, 12);
			this.labelDropTable1.TabIndex = 0;
			this.labelDropTable1.Text = "Drop Table 1";
			// 
			// DropInfomation
			// 
			this.AutoScaleDimensions = new SizeF(6F, 12F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			this.Controls.Add(this.groupDropInfo);
			this.Name = "DropInfomation";
			this.Size = new Size(760, 800);
			this.groupDropInfo.ResumeLayout(false);
			this.groupDropInfo.PerformLayout();
			((ISupportInitialize)(this.numericDropRate4)).EndInit();
			((ISupportInitialize)(this.numericDropRate5)).EndInit();
			((ISupportInitialize)(this.numericDropRate3)).EndInit();
			((ISupportInitialize)(this.numericDropRate2)).EndInit();
			((ISupportInitialize)(this.numericDropRate1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolTip toolTipInfo;
		private GroupBox groupDropInfo;
		private NumericUpDown numericDropRate4;
		private Label labelDropRate4;
		private ComboBox comboDropTable4;
		private Label labelDropTable4;
		private NumericUpDown numericDropRate5;
		private Label labelDropRate5;
		private ComboBox comboDropTable5;
		private Label labelDropTable5;
		private NumericUpDown numericDropRate3;
		private Label labelDropRate3;
		private ComboBox comboDropTable3;
		private Label labelDropTable3;
		private NumericUpDown numericDropRate2;
		private Label labelDropRate2;
		private ComboBox comboDropTable2;
		private Label labelDropTable2;
		private NumericUpDown numericDropRate1;
		private Label labelDropRate1;
		private ComboBox comboDropTable1;
		private Label labelDropTable1;
	}
}
