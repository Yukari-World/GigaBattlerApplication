using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit.Parts {
	partial class StatusInfoLevelParts {
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
			this.groupLv = new System.Windows.Forms.GroupBox();
			this.numericReqLv = new System.Windows.Forms.NumericUpDown();
			this.labelReqLv = new System.Windows.Forms.Label();
			this.labelMinLevel = new System.Windows.Forms.Label();
			this.numericMinLevel = new System.Windows.Forms.NumericUpDown();
			this.label = new System.Windows.Forms.Label();
			this.labelMaxLevel = new System.Windows.Forms.Label();
			this.numericMaxLevel = new System.Windows.Forms.NumericUpDown();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.groupLv.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericReqLv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMinLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxLevel)).BeginInit();
			this.SuspendLayout();
			// 
			// groupLv
			// 
			this.groupLv.Controls.Add(this.numericReqLv);
			this.groupLv.Controls.Add(this.labelReqLv);
			this.groupLv.Controls.Add(this.labelMinLevel);
			this.groupLv.Controls.Add(this.numericMinLevel);
			this.groupLv.Controls.Add(this.label);
			this.groupLv.Controls.Add(this.labelMaxLevel);
			this.groupLv.Controls.Add(this.numericMaxLevel);
			this.groupLv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupLv.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.groupLv.Location = new System.Drawing.Point(0, 0);
			this.groupLv.Name = "groupLv";
			this.groupLv.Size = new System.Drawing.Size(650, 75);
			this.groupLv.TabIndex = 1;
			this.groupLv.TabStop = false;
			this.groupLv.Text = "Level";
			// 
			// numericReqLv
			// 
			this.numericReqLv.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericReqLv.Location = new System.Drawing.Point(10, 30);
			this.numericReqLv.Maximum = new decimal(new int[] {
			-727379969,
			232,
			0,
			0});
			this.numericReqLv.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericReqLv.Name = "numericReqLv";
			this.numericReqLv.Size = new System.Drawing.Size(150, 19);
			this.numericReqLv.TabIndex = 1;
			this.numericReqLv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericReqLv.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericReqLv, "出現条件レベル。非常に高いレベルのユニットが出現することによるゲームバランスを崩さないための処置。\r\nこの条件を突破しない限り、絶対に出現することはない(出るとし" +
		"たらバグ)。\r\n設定値: 1 ～ 999,999,999,999");
			this.numericReqLv.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// labelReqLv
			// 
			this.labelReqLv.AutoSize = true;
			this.labelReqLv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelReqLv.Location = new System.Drawing.Point(10, 15);
			this.labelReqLv.Name = "labelReqLv";
			this.labelReqLv.Size = new System.Drawing.Size(60, 12);
			this.labelReqLv.TabIndex = 0;
			this.labelReqLv.Text = "Requier Lv";
			// 
			// labelMinLevel
			// 
			this.labelMinLevel.AutoSize = true;
			this.labelMinLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelMinLevel.Location = new System.Drawing.Point(200, 15);
			this.labelMinLevel.Name = "labelMinLevel";
			this.labelMinLevel.Size = new System.Drawing.Size(54, 12);
			this.labelMinLevel.TabIndex = 2;
			this.labelMinLevel.Text = "Min Level";
			// 
			// numericMinLevel
			// 
			this.numericMinLevel.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericMinLevel.Location = new System.Drawing.Point(200, 30);
			this.numericMinLevel.Maximum = new decimal(new int[] {
			-727379969,
			232,
			0,
			0});
			this.numericMinLevel.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericMinLevel.Name = "numericMinLevel";
			this.numericMinLevel.Size = new System.Drawing.Size(150, 19);
			this.numericMinLevel.TabIndex = 3;
			this.numericMinLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericMinLevel.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericMinLevel, "最低レベル。出現条件レベルにそろえる必要はない。\r\nまた、敗北した時に奪われるお金の量にも影響する。\r\n設定値:1 ～ 999,999,999,999");
			this.numericMinLevel.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label.Location = new System.Drawing.Point(367, 32);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(17, 12);
			this.label.TabIndex = 4;
			this.label.Text = "～";
			// 
			// labelMaxLevel
			// 
			this.labelMaxLevel.AutoSize = true;
			this.labelMaxLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelMaxLevel.Location = new System.Drawing.Point(400, 15);
			this.labelMaxLevel.Name = "labelMaxLevel";
			this.labelMaxLevel.Size = new System.Drawing.Size(57, 12);
			this.labelMaxLevel.TabIndex = 5;
			this.labelMaxLevel.Text = "Max Level";
			// 
			// numericMaxLevel
			// 
			this.numericMaxLevel.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericMaxLevel.Location = new System.Drawing.Point(402, 30);
			this.numericMaxLevel.Maximum = new decimal(new int[] {
			1661992959,
			1808227885,
			5,
			0});
			this.numericMaxLevel.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			-2147483648});
			this.numericMaxLevel.Name = "numericMaxLevel";
			this.numericMaxLevel.Size = new System.Drawing.Size(150, 19);
			this.numericMaxLevel.TabIndex = 6;
			this.numericMaxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericMaxLevel.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericMaxLevel, "最高レベル。限界突破補正などに影響します。\r\n-1を指定すると無制限となります。\r\nまた、最高レベルを超えるキャラクターが生成された時は、全ステータスに補正がかか" +
		"る。\r\n設定値:1 ～ 99,999,999,999,999,999,999 もしくは -1");
			this.numericMaxLevel.Value = new decimal(new int[] {
			1,
			0,
			0,
			-2147483648});
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
			// StatusInfoLevelParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupLv);
			this.Name = "StatusInfoLevelParts";
			this.Size = new System.Drawing.Size(650, 75);
			this.groupLv.ResumeLayout(false);
			this.groupLv.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericReqLv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMinLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxLevel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupLv;
		private NumericUpDown numericReqLv;
		private Label labelReqLv;
		private Label labelMinLevel;
		private NumericUpDown numericMinLevel;
		private Label label;
		private Label labelMaxLevel;
		private NumericUpDown numericMaxLevel;
		private ToolTip toolTipInfo;
	}
}
