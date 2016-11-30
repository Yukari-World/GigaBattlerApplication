namespace Status_Editer.User_Control.CommonParts {
	partial class ItemInfoParts {
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
			this.components = new System.ComponentModel.Container();
			this.groupInfomation = new System.Windows.Forms.GroupBox();
			this.numericSPC = new System.Windows.Forms.NumericUpDown();
			this.labelSPC = new System.Windows.Forms.Label();
			this.numericEC = new System.Windows.Forms.NumericUpDown();
			this.labelEC = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numericWT = new System.Windows.Forms.NumericUpDown();
			this.textInfo = new System.Windows.Forms.TextBox();
			this.labelWT = new System.Windows.Forms.Label();
			this.numericRare = new System.Windows.Forms.NumericUpDown();
			this.labelRare = new System.Windows.Forms.Label();
			this.textItemName = new System.Windows.Forms.TextBox();
			this.labelItemName = new System.Windows.Forms.Label();
			this.comboEquipItemGroup = new System.Windows.Forms.ComboBox();
			this.labelEquipItemGroup = new System.Windows.Forms.Label();
			this.textItemID = new System.Windows.Forms.TextBox();
			this.labelItemID = new System.Windows.Forms.Label();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.comboElement1 = new System.Windows.Forms.ComboBox();
			this.labelElement1 = new System.Windows.Forms.Label();
			this.comboElement2 = new System.Windows.Forms.ComboBox();
			this.labelElement2 = new System.Windows.Forms.Label();
			this.comboAttackItemGroup = new System.Windows.Forms.ComboBox();
			this.labelAttackItemGroup = new System.Windows.Forms.Label();
			this.groupInfomation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericSPC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRare)).BeginInit();
			this.SuspendLayout();
			// 
			// groupInfomation
			// 
			this.groupInfomation.Controls.Add(this.comboAttackItemGroup);
			this.groupInfomation.Controls.Add(this.labelAttackItemGroup);
			this.groupInfomation.Controls.Add(this.comboElement2);
			this.groupInfomation.Controls.Add(this.labelElement2);
			this.groupInfomation.Controls.Add(this.comboElement1);
			this.groupInfomation.Controls.Add(this.labelElement1);
			this.groupInfomation.Controls.Add(this.numericSPC);
			this.groupInfomation.Controls.Add(this.labelSPC);
			this.groupInfomation.Controls.Add(this.numericEC);
			this.groupInfomation.Controls.Add(this.labelEC);
			this.groupInfomation.Controls.Add(this.label1);
			this.groupInfomation.Controls.Add(this.numericWT);
			this.groupInfomation.Controls.Add(this.textInfo);
			this.groupInfomation.Controls.Add(this.labelWT);
			this.groupInfomation.Controls.Add(this.numericRare);
			this.groupInfomation.Controls.Add(this.labelRare);
			this.groupInfomation.Controls.Add(this.textItemName);
			this.groupInfomation.Controls.Add(this.labelItemName);
			this.groupInfomation.Controls.Add(this.comboEquipItemGroup);
			this.groupInfomation.Controls.Add(this.labelEquipItemGroup);
			this.groupInfomation.Controls.Add(this.textItemID);
			this.groupInfomation.Controls.Add(this.labelItemID);
			this.groupInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupInfomation.Location = new System.Drawing.Point(0, 0);
			this.groupInfomation.Name = "groupInfomation";
			this.groupInfomation.Size = new System.Drawing.Size(600, 800);
			this.groupInfomation.TabIndex = 0;
			this.groupInfomation.TabStop = false;
			this.groupInfomation.Text = "Item Infomation";
			// 
			// numericSPC
			// 
			this.numericSPC.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericSPC.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericSPC.Location = new System.Drawing.Point(390, 135);
			this.numericSPC.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericSPC.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
			this.numericSPC.Name = "numericSPC";
			this.numericSPC.Size = new System.Drawing.Size(75, 19);
			this.numericSPC.TabIndex = 32;
			this.numericSPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelSPC
			// 
			this.labelSPC.AutoSize = true;
			this.labelSPC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelSPC.Location = new System.Drawing.Point(390, 120);
			this.labelSPC.Name = "labelSPC";
			this.labelSPC.Size = new System.Drawing.Size(27, 12);
			this.labelSPC.TabIndex = 31;
			this.labelSPC.Text = "SPC";
			// 
			// numericEC
			// 
			this.numericEC.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericEC.Location = new System.Drawing.Point(270, 135);
			this.numericEC.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numericEC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericEC.Name = "numericEC";
			this.numericEC.Size = new System.Drawing.Size(100, 19);
			this.numericEC.TabIndex = 30;
			this.numericEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTipInfo.SetToolTip(this.numericEC, "装備コスト。\r\n設定値: 1 ～ 999,999,999,999");
			this.numericEC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelEC
			// 
			this.labelEC.AutoSize = true;
			this.labelEC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelEC.Location = new System.Drawing.Point(270, 120);
			this.labelEC.Name = "labelEC";
			this.labelEC.Size = new System.Drawing.Size(20, 12);
			this.labelEC.TabIndex = 29;
			this.labelEC.Text = "EC";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(10, 675);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 12);
			this.label1.TabIndex = 16;
			this.label1.Text = "Text Infomation";
			// 
			// numericWT
			// 
			this.numericWT.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericWT.Location = new System.Drawing.Point(150, 135);
			this.numericWT.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericWT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericWT.Name = "numericWT";
			this.numericWT.Size = new System.Drawing.Size(100, 19);
			this.numericWT.TabIndex = 28;
			this.numericWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericWT.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericWT, "Weight。重さ。\r\n1 = 大体1kgで換算。攻撃の優先順位やフィールドの重力などに影響。\r\n先制値: SPD / (WT * (Gravity ** 2 +" +
        " 100) / 100)\r\n設定値: 1 ～ 9,999,999");
			this.numericWT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// textInfo
			// 
			this.textInfo.Location = new System.Drawing.Point(10, 690);
			this.textInfo.Multiline = true;
			this.textInfo.Name = "textInfo";
			this.textInfo.Size = new System.Drawing.Size(580, 100);
			this.textInfo.TabIndex = 17;
			this.toolTipInfo.SetToolTip(this.textInfo, "ゲーム内の図鑑等で表示される説明文。特に長さの制限はないが、長すぎるのも問題なので適度に調節すること。");
			// 
			// labelWT
			// 
			this.labelWT.AutoSize = true;
			this.labelWT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelWT.Location = new System.Drawing.Point(150, 120);
			this.labelWT.Name = "labelWT";
			this.labelWT.Size = new System.Drawing.Size(21, 12);
			this.labelWT.TabIndex = 27;
			this.labelWT.Text = "WT";
			// 
			// numericRare
			// 
			this.numericRare.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericRare.Location = new System.Drawing.Point(485, 135);
			this.numericRare.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numericRare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericRare.Name = "numericRare";
			this.numericRare.Size = new System.Drawing.Size(50, 19);
			this.numericRare.TabIndex = 24;
			this.numericRare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericRare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelRare
			// 
			this.labelRare.AutoSize = true;
			this.labelRare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelRare.Location = new System.Drawing.Point(485, 120);
			this.labelRare.Name = "labelRare";
			this.labelRare.Size = new System.Drawing.Size(29, 12);
			this.labelRare.TabIndex = 23;
			this.labelRare.Text = "Rare";
			// 
			// textItemName
			// 
			this.textItemName.Location = new System.Drawing.Point(10, 90);
			this.textItemName.Name = "textItemName";
			this.textItemName.Size = new System.Drawing.Size(465, 19);
			this.textItemName.TabIndex = 22;
			this.toolTipInfo.SetToolTip(this.textItemName, "ゲームユーザーが視認する名前。\r\n");
			// 
			// labelItemName
			// 
			this.labelItemName.AutoSize = true;
			this.labelItemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelItemName.Location = new System.Drawing.Point(10, 75);
			this.labelItemName.Name = "labelItemName";
			this.labelItemName.Size = new System.Drawing.Size(122, 12);
			this.labelItemName.TabIndex = 21;
			this.labelItemName.Text = "Item Name(表記データ):";
			// 
			// comboEquipItemGroup
			// 
			this.comboEquipItemGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboEquipItemGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboEquipItemGroup.FormattingEnabled = true;
			this.comboEquipItemGroup.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.comboEquipItemGroup.Location = new System.Drawing.Point(10, 179);
			this.comboEquipItemGroup.MaxDropDownItems = 10;
			this.comboEquipItemGroup.Name = "comboEquipItemGroup";
			this.comboEquipItemGroup.Size = new System.Drawing.Size(100, 20);
			this.comboEquipItemGroup.TabIndex = 19;
			this.toolTipInfo.SetToolTip(this.comboEquipItemGroup, "装備時に影響する装備の種類。");
			// 
			// labelEquipItemGroup
			// 
			this.labelEquipItemGroup.AutoSize = true;
			this.labelEquipItemGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelEquipItemGroup.Location = new System.Drawing.Point(10, 164);
			this.labelEquipItemGroup.Name = "labelEquipItemGroup";
			this.labelEquipItemGroup.Size = new System.Drawing.Size(93, 12);
			this.labelEquipItemGroup.TabIndex = 18;
			this.labelEquipItemGroup.Text = "Equip Item Group";
			// 
			// textItemID
			// 
			this.textItemID.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textItemID.Location = new System.Drawing.Point(10, 45);
			this.textItemID.Name = "textItemID";
			this.textItemID.Size = new System.Drawing.Size(300, 19);
			this.textItemID.TabIndex = 17;
			this.toolTipInfo.SetToolTip(this.textItemID, "ゲームシステム側で識別されるデータ。\r\nID名は英名表記で統一し、データの整合性のため、変更を行わないこと。");
			// 
			// labelItemID
			// 
			this.labelItemID.AutoSize = true;
			this.labelItemID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelItemID.Location = new System.Drawing.Point(10, 30);
			this.labelItemID.Name = "labelItemID";
			this.labelItemID.Size = new System.Drawing.Size(180, 12);
			this.labelItemID.TabIndex = 16;
			this.labelItemID.Text = "Item ID(システムで識別されるデータ):";
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
			// comboElement1
			// 
			this.comboElement1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboElement1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboElement1.FormattingEnabled = true;
			this.comboElement1.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.comboElement1.Location = new System.Drawing.Point(10, 134);
			this.comboElement1.MaxDropDownItems = 10;
			this.comboElement1.Name = "comboElement1";
			this.comboElement1.Size = new System.Drawing.Size(50, 20);
			this.comboElement1.TabIndex = 34;
			this.toolTipInfo.SetToolTip(this.comboElement1, "属性情報。");
			// 
			// labelElement1
			// 
			this.labelElement1.AutoSize = true;
			this.labelElement1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelElement1.Location = new System.Drawing.Point(10, 119);
			this.labelElement1.Name = "labelElement1";
			this.labelElement1.Size = new System.Drawing.Size(35, 12);
			this.labelElement1.TabIndex = 33;
			this.labelElement1.Text = "属性1";
			// 
			// comboElement2
			// 
			this.comboElement2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboElement2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboElement2.FormattingEnabled = true;
			this.comboElement2.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.comboElement2.Location = new System.Drawing.Point(80, 134);
			this.comboElement2.MaxDropDownItems = 10;
			this.comboElement2.Name = "comboElement2";
			this.comboElement2.Size = new System.Drawing.Size(50, 20);
			this.comboElement2.TabIndex = 36;
			this.toolTipInfo.SetToolTip(this.comboElement2, "属性情報。");
			// 
			// labelElement2
			// 
			this.labelElement2.AutoSize = true;
			this.labelElement2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelElement2.Location = new System.Drawing.Point(80, 119);
			this.labelElement2.Name = "labelElement2";
			this.labelElement2.Size = new System.Drawing.Size(35, 12);
			this.labelElement2.TabIndex = 35;
			this.labelElement2.Text = "属性2";
			// 
			// comboAttackItemGroup
			// 
			this.comboAttackItemGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboAttackItemGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboAttackItemGroup.FormattingEnabled = true;
			this.comboAttackItemGroup.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.comboAttackItemGroup.Location = new System.Drawing.Point(130, 179);
			this.comboAttackItemGroup.MaxDropDownItems = 10;
			this.comboAttackItemGroup.Name = "comboAttackItemGroup";
			this.comboAttackItemGroup.Size = new System.Drawing.Size(100, 20);
			this.comboAttackItemGroup.TabIndex = 38;
			this.toolTipInfo.SetToolTip(this.comboAttackItemGroup, "攻撃時に影響する装備の種類。");
			// 
			// labelAttackItemGroup
			// 
			this.labelAttackItemGroup.AutoSize = true;
			this.labelAttackItemGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelAttackItemGroup.Location = new System.Drawing.Point(130, 164);
			this.labelAttackItemGroup.Name = "labelAttackItemGroup";
			this.labelAttackItemGroup.Size = new System.Drawing.Size(99, 12);
			this.labelAttackItemGroup.TabIndex = 37;
			this.labelAttackItemGroup.Text = "Attack Item Group";
			// 
			// ItemInfoParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupInfomation);
			this.Name = "ItemInfoParts";
			this.Size = new System.Drawing.Size(600, 800);
			this.groupInfomation.ResumeLayout(false);
			this.groupInfomation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericSPC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRare)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupInfomation;
		private System.Windows.Forms.ToolTip toolTipInfo;
		private System.Windows.Forms.NumericUpDown numericWT;
		private System.Windows.Forms.Label labelWT;
		private System.Windows.Forms.NumericUpDown numericRare;
		private System.Windows.Forms.Label labelRare;
		private System.Windows.Forms.TextBox textItemName;
		private System.Windows.Forms.Label labelItemName;
		private System.Windows.Forms.TextBox textItemID;
		private System.Windows.Forms.Label labelItemID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textInfo;
		private System.Windows.Forms.NumericUpDown numericSPC;
		private System.Windows.Forms.Label labelSPC;
		private System.Windows.Forms.NumericUpDown numericEC;
		private System.Windows.Forms.Label labelEC;
		private System.Windows.Forms.ComboBox comboEquipItemGroup;
		private System.Windows.Forms.Label labelEquipItemGroup;
		private System.Windows.Forms.ComboBox comboElement2;
		private System.Windows.Forms.Label labelElement2;
		private System.Windows.Forms.ComboBox comboElement1;
		private System.Windows.Forms.Label labelElement1;
		private System.Windows.Forms.ComboBox comboAttackItemGroup;
		private System.Windows.Forms.Label labelAttackItemGroup;
	}
}
