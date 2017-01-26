using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab14Skill {
	partial class SkillInfomation {
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
			this.groupSkillInfomation = new System.Windows.Forms.GroupBox();
			this.textSkillName = new System.Windows.Forms.TextBox();
			this.labelSkillID = new System.Windows.Forms.Label();
			this.labelSkillName = new System.Windows.Forms.Label();
			this.textSkillID = new System.Windows.Forms.TextBox();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.labelPercent = new System.Windows.Forms.Label();
			this.numericPercent = new System.Windows.Forms.NumericUpDown();
			this.numericFirst = new System.Windows.Forms.NumericUpDown();
			this.labelFirst = new System.Windows.Forms.Label();
			this.labelSPCost = new System.Windows.Forms.Label();
			this.numericSPCost = new System.Windows.Forms.NumericUpDown();
			this.labelTPCost = new System.Windows.Forms.Label();
			this.numericTPCost = new System.Windows.Forms.NumericUpDown();
			this.labelATCount = new System.Windows.Forms.Label();
			this.numericATCount = new System.Windows.Forms.NumericUpDown();
			this.labelHit = new System.Windows.Forms.Label();
			this.numericHit = new System.Windows.Forms.NumericUpDown();
			this.labelCritical = new System.Windows.Forms.Label();
			this.numericCritical = new System.Windows.Forms.NumericUpDown();
			this.labelWeaponType = new System.Windows.Forms.Label();
			this.comboWeaponType = new System.Windows.Forms.ComboBox();
			this.labelWeaponEffect = new System.Windows.Forms.Label();
			this.comboWeaponEffect = new System.Windows.Forms.ComboBox();
			this.labelTarget = new System.Windows.Forms.Label();
			this.comboTarget = new System.Windows.Forms.ComboBox();
			this.labelType = new System.Windows.Forms.Label();
			this.comboType = new System.Windows.Forms.ComboBox();
			this.PowerGraph = new Status_Editer.User_Control.tab14Skill.Parts.PowerGraphParts();
			this.labelAir = new System.Windows.Forms.Label();
			this.comboAir = new System.Windows.Forms.ComboBox();
			this.labelInfo = new System.Windows.Forms.Label();
			this.textInfo = new System.Windows.Forms.TextBox();
			this.groupSkillInfomation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericPercent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericFirst)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSPCost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericTPCost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericATCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericHit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCritical)).BeginInit();
			this.SuspendLayout();
			// 
			// groupSkillInfomation
			// 
			this.groupSkillInfomation.Controls.Add(this.labelInfo);
			this.groupSkillInfomation.Controls.Add(this.textInfo);
			this.groupSkillInfomation.Controls.Add(this.comboAir);
			this.groupSkillInfomation.Controls.Add(this.labelAir);
			this.groupSkillInfomation.Controls.Add(this.comboType);
			this.groupSkillInfomation.Controls.Add(this.labelType);
			this.groupSkillInfomation.Controls.Add(this.comboTarget);
			this.groupSkillInfomation.Controls.Add(this.labelTarget);
			this.groupSkillInfomation.Controls.Add(this.comboWeaponEffect);
			this.groupSkillInfomation.Controls.Add(this.labelWeaponEffect);
			this.groupSkillInfomation.Controls.Add(this.comboWeaponType);
			this.groupSkillInfomation.Controls.Add(this.labelWeaponType);
			this.groupSkillInfomation.Controls.Add(this.numericCritical);
			this.groupSkillInfomation.Controls.Add(this.labelCritical);
			this.groupSkillInfomation.Controls.Add(this.numericHit);
			this.groupSkillInfomation.Controls.Add(this.labelHit);
			this.groupSkillInfomation.Controls.Add(this.numericATCount);
			this.groupSkillInfomation.Controls.Add(this.labelATCount);
			this.groupSkillInfomation.Controls.Add(this.numericTPCost);
			this.groupSkillInfomation.Controls.Add(this.labelTPCost);
			this.groupSkillInfomation.Controls.Add(this.numericSPCost);
			this.groupSkillInfomation.Controls.Add(this.labelSPCost);
			this.groupSkillInfomation.Controls.Add(this.labelFirst);
			this.groupSkillInfomation.Controls.Add(this.numericFirst);
			this.groupSkillInfomation.Controls.Add(this.numericPercent);
			this.groupSkillInfomation.Controls.Add(this.labelPercent);
			this.groupSkillInfomation.Controls.Add(this.PowerGraph);
			this.groupSkillInfomation.Controls.Add(this.textSkillName);
			this.groupSkillInfomation.Controls.Add(this.labelSkillID);
			this.groupSkillInfomation.Controls.Add(this.labelSkillName);
			this.groupSkillInfomation.Controls.Add(this.textSkillID);
			this.groupSkillInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupSkillInfomation.Location = new System.Drawing.Point(0, 0);
			this.groupSkillInfomation.Name = "groupSkillInfomation";
			this.groupSkillInfomation.Size = new System.Drawing.Size(600, 820);
			this.groupSkillInfomation.TabIndex = 0;
			this.groupSkillInfomation.TabStop = false;
			this.groupSkillInfomation.Text = "Skill Infomation";
			// 
			// textSkillName
			// 
			this.textSkillName.Location = new System.Drawing.Point(10, 90);
			this.textSkillName.Name = "textSkillName";
			this.textSkillName.Size = new System.Drawing.Size(465, 19);
			this.textSkillName.TabIndex = 3;
			this.toolTipInfo.SetToolTip(this.textSkillName, "ゲームユーザーが視認する名前。\r\n");
			// 
			// labelSkillID
			// 
			this.labelSkillID.AutoSize = true;
			this.labelSkillID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelSkillID.Location = new System.Drawing.Point(10, 30);
			this.labelSkillID.Name = "labelSkillID";
			this.labelSkillID.Size = new System.Drawing.Size(180, 12);
			this.labelSkillID.TabIndex = 0;
			this.labelSkillID.Text = "Skill ID(システムで識別されるデータ):";
			// 
			// labelSkillName
			// 
			this.labelSkillName.AutoSize = true;
			this.labelSkillName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelSkillName.Location = new System.Drawing.Point(10, 75);
			this.labelSkillName.Name = "labelSkillName";
			this.labelSkillName.Size = new System.Drawing.Size(122, 12);
			this.labelSkillName.TabIndex = 2;
			this.labelSkillName.Text = "Skill Name(表記データ):";
			// 
			// textSkillID
			// 
			this.textSkillID.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textSkillID.Location = new System.Drawing.Point(10, 45);
			this.textSkillID.Name = "textSkillID";
			this.textSkillID.Size = new System.Drawing.Size(300, 19);
			this.textSkillID.TabIndex = 1;
			this.toolTipInfo.SetToolTip(this.textSkillID, "ゲームシステム側で識別されるデータ。\r\nID名は英名表記で統一し、データの整合性のため、変更を行わないこと。");
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
			// labelPercent
			// 
			this.labelPercent.AutoSize = true;
			this.labelPercent.Location = new System.Drawing.Point(10, 230);
			this.labelPercent.Name = "labelPercent";
			this.labelPercent.Size = new System.Drawing.Size(70, 12);
			this.labelPercent.TabIndex = 5;
			this.labelPercent.Text = "スキル発動率";
			// 
			// numericPercent
			// 
			this.numericPercent.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericPercent.Location = new System.Drawing.Point(10, 245);
			this.numericPercent.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numericPercent.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
			this.numericPercent.Name = "numericPercent";
			this.numericPercent.Size = new System.Drawing.Size(100, 19);
			this.numericPercent.TabIndex = 6;
			this.numericPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericPercent.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericPercent, "発動率。10000=100%ではあるが、必ず発動するわけではない。あくまで優先順位みたいなもの\r\n設定値: -5,000 ～ 10,000,000");
			this.numericPercent.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// numericFirst
			// 
			this.numericFirst.Location = new System.Drawing.Point(130, 245);
			this.numericFirst.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numericFirst.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
			this.numericFirst.Name = "numericFirst";
			this.numericFirst.Size = new System.Drawing.Size(75, 19);
			this.numericFirst.TabIndex = 8;
			this.numericFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTipInfo.SetToolTip(this.numericFirst, "発動優先順位。SPに1,000,000上乗せする形で攻撃順序を計算する。\r\n同一の場合はプレイヤー優先\r\n設定値: -15～ 30");
			// 
			// labelFirst
			// 
			this.labelFirst.AutoSize = true;
			this.labelFirst.Location = new System.Drawing.Point(130, 230);
			this.labelFirst.Name = "labelFirst";
			this.labelFirst.Size = new System.Drawing.Size(77, 12);
			this.labelFirst.TabIndex = 7;
			this.labelFirst.Text = "発動優先順位";
			// 
			// labelSPCost
			// 
			this.labelSPCost.AutoSize = true;
			this.labelSPCost.Location = new System.Drawing.Point(230, 230);
			this.labelSPCost.Name = "labelSPCost";
			this.labelSPCost.Size = new System.Drawing.Size(43, 12);
			this.labelSPCost.TabIndex = 9;
			this.labelSPCost.Text = "消費SP";
			// 
			// numericSPCost
			// 
			this.numericSPCost.Location = new System.Drawing.Point(230, 245);
			this.numericSPCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numericSPCost.Name = "numericSPCost";
			this.numericSPCost.Size = new System.Drawing.Size(100, 19);
			this.numericSPCost.TabIndex = 10;
			this.numericSPCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericSPCost.ThousandsSeparator = true;
			this.numericSPCost.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// labelTPCost
			// 
			this.labelTPCost.AutoSize = true;
			this.labelTPCost.Location = new System.Drawing.Point(355, 230);
			this.labelTPCost.Name = "labelTPCost";
			this.labelTPCost.Size = new System.Drawing.Size(43, 12);
			this.labelTPCost.TabIndex = 11;
			this.labelTPCost.Text = "消費TP";
			// 
			// numericTPCost
			// 
			this.numericTPCost.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericTPCost.Location = new System.Drawing.Point(355, 245);
			this.numericTPCost.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.numericTPCost.Name = "numericTPCost";
			this.numericTPCost.Size = new System.Drawing.Size(75, 19);
			this.numericTPCost.TabIndex = 12;
			this.numericTPCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericTPCost.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericTPCost, "スキル発動時に消費するTP。設定する時は5の倍数で設定すること。\r\n設定値: 0～ 50,000");
			// 
			// labelATCount
			// 
			this.labelATCount.AutoSize = true;
			this.labelATCount.Location = new System.Drawing.Point(10, 275);
			this.labelATCount.Name = "labelATCount";
			this.labelATCount.Size = new System.Drawing.Size(53, 12);
			this.labelATCount.TabIndex = 13;
			this.labelATCount.Text = "攻撃回数";
			// 
			// numericATCount
			// 
			this.numericATCount.Location = new System.Drawing.Point(10, 290);
			this.numericATCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numericATCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericATCount.Name = "numericATCount";
			this.numericATCount.Size = new System.Drawing.Size(75, 19);
			this.numericATCount.TabIndex = 14;
			this.numericATCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericATCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelHit
			// 
			this.labelHit.AutoSize = true;
			this.labelHit.Location = new System.Drawing.Point(130, 275);
			this.labelHit.Name = "labelHit";
			this.labelHit.Size = new System.Drawing.Size(41, 12);
			this.labelHit.TabIndex = 15;
			this.labelHit.Text = "命中率";
			// 
			// numericHit
			// 
			this.numericHit.Location = new System.Drawing.Point(130, 290);
			this.numericHit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericHit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericHit.Name = "numericHit";
			this.numericHit.Size = new System.Drawing.Size(75, 19);
			this.numericHit.TabIndex = 16;
			this.numericHit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericHit.ThousandsSeparator = true;
			this.numericHit.Value = new decimal(new int[] {
            7000,
            0,
            0,
            0});
			// 
			// labelCritical
			// 
			this.labelCritical.AutoSize = true;
			this.labelCritical.Location = new System.Drawing.Point(230, 275);
			this.labelCritical.Name = "labelCritical";
			this.labelCritical.Size = new System.Drawing.Size(91, 12);
			this.labelCritical.TabIndex = 17;
			this.labelCritical.Text = "クリティカル発生率";
			// 
			// numericCritical
			// 
			this.numericCritical.Location = new System.Drawing.Point(230, 290);
			this.numericCritical.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericCritical.Name = "numericCritical";
			this.numericCritical.Size = new System.Drawing.Size(100, 19);
			this.numericCritical.TabIndex = 18;
			this.numericCritical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericCritical.ThousandsSeparator = true;
			// 
			// labelWeaponType
			// 
			this.labelWeaponType.AutoSize = true;
			this.labelWeaponType.Location = new System.Drawing.Point(10, 315);
			this.labelWeaponType.Name = "labelWeaponType";
			this.labelWeaponType.Size = new System.Drawing.Size(55, 12);
			this.labelWeaponType.TabIndex = 19;
			this.labelWeaponType.Text = "武器タイプ";
			// 
			// comboWeaponType
			// 
			this.comboWeaponType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboWeaponType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboWeaponType.FormattingEnabled = true;
			this.comboWeaponType.Location = new System.Drawing.Point(10, 330);
			this.comboWeaponType.Name = "comboWeaponType";
			this.comboWeaponType.Size = new System.Drawing.Size(121, 20);
			this.comboWeaponType.TabIndex = 20;
			// 
			// labelWeaponEffect
			// 
			this.labelWeaponEffect.AutoSize = true;
			this.labelWeaponEffect.Location = new System.Drawing.Point(160, 315);
			this.labelWeaponEffect.Name = "labelWeaponEffect";
			this.labelWeaponEffect.Size = new System.Drawing.Size(115, 12);
			this.labelWeaponEffect.TabIndex = 21;
			this.labelWeaponEffect.Text = "武器効果を使用するか";
			// 
			// comboWeaponEffect
			// 
			this.comboWeaponEffect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboWeaponEffect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboWeaponEffect.FormattingEnabled = true;
			this.comboWeaponEffect.Location = new System.Drawing.Point(160, 330);
			this.comboWeaponEffect.Name = "comboWeaponEffect";
			this.comboWeaponEffect.Size = new System.Drawing.Size(121, 20);
			this.comboWeaponEffect.TabIndex = 22;
			// 
			// labelTarget
			// 
			this.labelTarget.AutoSize = true;
			this.labelTarget.Location = new System.Drawing.Point(10, 355);
			this.labelTarget.Name = "labelTarget";
			this.labelTarget.Size = new System.Drawing.Size(53, 12);
			this.labelTarget.TabIndex = 25;
			this.labelTarget.Text = "有効範囲";
			// 
			// comboTarget
			// 
			this.comboTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboTarget.FormattingEnabled = true;
			this.comboTarget.Location = new System.Drawing.Point(10, 370);
			this.comboTarget.Name = "comboTarget";
			this.comboTarget.Size = new System.Drawing.Size(121, 20);
			this.comboTarget.TabIndex = 26;
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(160, 355);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(68, 12);
			this.labelType.TabIndex = 27;
			this.labelType.Text = "スキルの種類";
			// 
			// comboType
			// 
			this.comboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboType.FormattingEnabled = true;
			this.comboType.Location = new System.Drawing.Point(160, 370);
			this.comboType.Name = "comboType";
			this.comboType.Size = new System.Drawing.Size(121, 20);
			this.comboType.TabIndex = 28;
			// 
			// PowerGraph
			// 
			this.PowerGraph.Location = new System.Drawing.Point(0, 125);
			this.PowerGraph.Name = "PowerGraph";
			this.PowerGraph.Size = new System.Drawing.Size(730, 100);
			this.PowerGraph.TabIndex = 4;
			// 
			// labelAir
			// 
			this.labelAir.AutoSize = true;
			this.labelAir.Location = new System.Drawing.Point(310, 315);
			this.labelAir.Name = "labelAir";
			this.labelAir.Size = new System.Drawing.Size(65, 12);
			this.labelAir.TabIndex = 23;
			this.labelAir.Text = "対飛行属性";
			// 
			// comboAir
			// 
			this.comboAir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboAir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboAir.FormattingEnabled = true;
			this.comboAir.Location = new System.Drawing.Point(310, 330);
			this.comboAir.Name = "comboAir";
			this.comboAir.Size = new System.Drawing.Size(121, 20);
			this.comboAir.TabIndex = 24;
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelInfo.Location = new System.Drawing.Point(10, 695);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(85, 12);
			this.labelInfo.TabIndex = 29;
			this.labelInfo.Text = "Text Infomation";
			// 
			// textInfo
			// 
			this.textInfo.Location = new System.Drawing.Point(10, 710);
			this.textInfo.Multiline = true;
			this.textInfo.Name = "textInfo";
			this.textInfo.Size = new System.Drawing.Size(580, 100);
			this.textInfo.TabIndex = 30;
			this.toolTipInfo.SetToolTip(this.textInfo, "ゲーム内の図鑑等で表示される説明文。特に長さの制限はないが、長すぎるのも問題なので適度に調節すること。");
			// 
			// SkillInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupSkillInfomation);
			this.Name = "SkillInfomation";
			this.Size = new System.Drawing.Size(600, 820);
			this.groupSkillInfomation.ResumeLayout(false);
			this.groupSkillInfomation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericPercent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericFirst)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSPCost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericTPCost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericATCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericHit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCritical)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupSkillInfomation;
		private ToolTip toolTipInfo;
		private TextBox textSkillName;
		private Label labelSkillID;
		private Label labelSkillName;
		private TextBox textSkillID;
		private Parts.PowerGraphParts PowerGraph;
		private Label labelPercent;
		private NumericUpDown numericPercent;
		private ComboBox comboWeaponEffect;
		private Label labelWeaponEffect;
		private ComboBox comboWeaponType;
		private Label labelWeaponType;
		private NumericUpDown numericCritical;
		private Label labelCritical;
		private NumericUpDown numericHit;
		private Label labelHit;
		private NumericUpDown numericATCount;
		private Label labelATCount;
		private NumericUpDown numericTPCost;
		private Label labelTPCost;
		private NumericUpDown numericSPCost;
		private Label labelSPCost;
		private Label labelFirst;
		private NumericUpDown numericFirst;
		private ComboBox comboTarget;
		private Label labelTarget;
		private ComboBox comboType;
		private Label labelType;
		private ComboBox comboAir;
		private Label labelAir;
		private Label labelInfo;
		private TextBox textInfo;
	}
}
