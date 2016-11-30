using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.CommonParts {
	partial class ItemInfoParts {
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
			this.groupInfomation = new System.Windows.Forms.GroupBox();
			this.comboEType = new System.Windows.Forms.ComboBox();
			this.labelEType = new System.Windows.Forms.Label();
			this.comboMaker = new System.Windows.Forms.ComboBox();
			this.labelMaker = new System.Windows.Forms.Label();
			this.comboTarget = new System.Windows.Forms.ComboBox();
			this.labelTarget = new System.Windows.Forms.Label();
			this.numericATC = new System.Windows.Forms.NumericUpDown();
			this.labelATC = new System.Windows.Forms.Label();
			this.numericSPC = new System.Windows.Forms.NumericUpDown();
			this.labelSPC = new System.Windows.Forms.Label();
			this.comboAttackItemGroup = new System.Windows.Forms.ComboBox();
			this.labelAttackItemGroup = new System.Windows.Forms.Label();
			this.comboElement2 = new System.Windows.Forms.ComboBox();
			this.labelElement2 = new System.Windows.Forms.Label();
			this.comboElement1 = new System.Windows.Forms.ComboBox();
			this.labelElement1 = new System.Windows.Forms.Label();
			this.numericSSP = new System.Windows.Forms.NumericUpDown();
			this.labelSSP = new System.Windows.Forms.Label();
			this.numericEC = new System.Windows.Forms.NumericUpDown();
			this.labelEC = new System.Windows.Forms.Label();
			this.labelInfo = new System.Windows.Forms.Label();
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
			this.labelPhysicsPower = new System.Windows.Forms.Label();
			this.numericPhysicsPower = new System.Windows.Forms.NumericUpDown();
			this.labelMagicPower = new System.Windows.Forms.Label();
			this.numericMagicPower = new System.Windows.Forms.NumericUpDown();
			this.labelPhysicsDefence = new System.Windows.Forms.Label();
			this.numericPhysicsDefence = new System.Windows.Forms.NumericUpDown();
			this.labelMagicDefence = new System.Windows.Forms.Label();
			this.numericMagicDefence = new System.Windows.Forms.NumericUpDown();
			this.numericReductionRate = new System.Windows.Forms.NumericUpDown();
			this.labelReductionRate = new System.Windows.Forms.Label();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.groupInfomation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericATC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSPC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSSP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPhysicsPower)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMagicPower)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPhysicsDefence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMagicDefence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericReductionRate)).BeginInit();
			this.SuspendLayout();
			// 
			// groupInfomation
			// 
			this.groupInfomation.Controls.Add(this.textPrice);
			this.groupInfomation.Controls.Add(this.labelPrice);
			this.groupInfomation.Controls.Add(this.numericReductionRate);
			this.groupInfomation.Controls.Add(this.labelReductionRate);
			this.groupInfomation.Controls.Add(this.numericMagicDefence);
			this.groupInfomation.Controls.Add(this.labelMagicDefence);
			this.groupInfomation.Controls.Add(this.numericPhysicsDefence);
			this.groupInfomation.Controls.Add(this.labelPhysicsDefence);
			this.groupInfomation.Controls.Add(this.numericMagicPower);
			this.groupInfomation.Controls.Add(this.labelMagicPower);
			this.groupInfomation.Controls.Add(this.numericPhysicsPower);
			this.groupInfomation.Controls.Add(this.labelPhysicsPower);
			this.groupInfomation.Controls.Add(this.comboEType);
			this.groupInfomation.Controls.Add(this.labelEType);
			this.groupInfomation.Controls.Add(this.comboMaker);
			this.groupInfomation.Controls.Add(this.labelMaker);
			this.groupInfomation.Controls.Add(this.comboTarget);
			this.groupInfomation.Controls.Add(this.labelTarget);
			this.groupInfomation.Controls.Add(this.numericATC);
			this.groupInfomation.Controls.Add(this.labelATC);
			this.groupInfomation.Controls.Add(this.numericSPC);
			this.groupInfomation.Controls.Add(this.labelSPC);
			this.groupInfomation.Controls.Add(this.comboAttackItemGroup);
			this.groupInfomation.Controls.Add(this.labelAttackItemGroup);
			this.groupInfomation.Controls.Add(this.comboElement2);
			this.groupInfomation.Controls.Add(this.labelElement2);
			this.groupInfomation.Controls.Add(this.comboElement1);
			this.groupInfomation.Controls.Add(this.labelElement1);
			this.groupInfomation.Controls.Add(this.numericSSP);
			this.groupInfomation.Controls.Add(this.labelSSP);
			this.groupInfomation.Controls.Add(this.numericEC);
			this.groupInfomation.Controls.Add(this.labelEC);
			this.groupInfomation.Controls.Add(this.labelInfo);
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
			// comboEType
			// 
			this.comboEType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboEType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboEType.FormattingEnabled = true;
			this.comboEType.Location = new System.Drawing.Point(320, 179);
			this.comboEType.Name = "comboEType";
			this.comboEType.Size = new System.Drawing.Size(60, 20);
			this.comboEType.TabIndex = 48;
			// 
			// labelEType
			// 
			this.labelEType.AutoSize = true;
			this.labelEType.Location = new System.Drawing.Point(320, 165);
			this.labelEType.Name = "labelEType";
			this.labelEType.Size = new System.Drawing.Size(31, 12);
			this.labelEType.TabIndex = 47;
			this.labelEType.Text = "Hand";
			// 
			// comboMaker
			// 
			this.comboMaker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboMaker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboMaker.FormattingEnabled = true;
			this.comboMaker.Location = new System.Drawing.Point(10, 224);
			this.comboMaker.Name = "comboMaker";
			this.comboMaker.Size = new System.Drawing.Size(200, 20);
			this.comboMaker.TabIndex = 46;
			this.toolTipInfo.SetToolTip(this.comboMaker, "装備開発元。\r\n所謂RP用のデータでありあまり大きな意味を持たない。");
			// 
			// labelMaker
			// 
			this.labelMaker.AutoSize = true;
			this.labelMaker.Location = new System.Drawing.Point(10, 209);
			this.labelMaker.Name = "labelMaker";
			this.labelMaker.Size = new System.Drawing.Size(36, 12);
			this.labelMaker.TabIndex = 45;
			this.labelMaker.Text = "Maker";
			// 
			// comboTarget
			// 
			this.comboTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboTarget.FormattingEnabled = true;
			this.comboTarget.Location = new System.Drawing.Point(200, 179);
			this.comboTarget.Name = "comboTarget";
			this.comboTarget.Size = new System.Drawing.Size(100, 20);
			this.comboTarget.TabIndex = 44;
			this.toolTipInfo.SetToolTip(this.comboTarget, "攻撃対象。");
			// 
			// labelTarget
			// 
			this.labelTarget.AutoSize = true;
			this.labelTarget.Location = new System.Drawing.Point(200, 165);
			this.labelTarget.Name = "labelTarget";
			this.labelTarget.Size = new System.Drawing.Size(53, 12);
			this.labelTarget.TabIndex = 43;
			this.labelTarget.Text = "攻撃対象";
			// 
			// numericATC
			// 
			this.numericATC.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericATC.Location = new System.Drawing.Point(105, 180);
			this.numericATC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericATC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericATC.Name = "numericATC";
			this.numericATC.Size = new System.Drawing.Size(75, 19);
			this.numericATC.TabIndex = 42;
			this.numericATC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericATC.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericATC, "攻撃回数。\r\nマシンガン系は10以上指定を推奨\r\n設定値: 1 ～ 1,000");
			this.numericATC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelATC
			// 
			this.labelATC.AutoSize = true;
			this.labelATC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelATC.Location = new System.Drawing.Point(105, 165);
			this.labelATC.Name = "labelATC";
			this.labelATC.Size = new System.Drawing.Size(73, 12);
			this.labelATC.TabIndex = 41;
			this.labelATC.Text = "Attack Count";
			// 
			// numericSPC
			// 
			this.numericSPC.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericSPC.Location = new System.Drawing.Point(10, 180);
			this.numericSPC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericSPC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericSPC.Name = "numericSPC";
			this.numericSPC.Size = new System.Drawing.Size(75, 19);
			this.numericSPC.TabIndex = 40;
			this.numericSPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericSPC.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericSPC, "通常攻撃時に消費されるSPの量。\r\n略称はSPC。決してShark Panch Centerの略ではない。\r\n設定値: 1 ～ 10,000");
			this.numericSPC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelSPC
			// 
			this.labelSPC.AutoSize = true;
			this.labelSPC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelSPC.Location = new System.Drawing.Point(10, 165);
			this.labelSPC.Name = "labelSPC";
			this.labelSPC.Size = new System.Drawing.Size(47, 12);
			this.labelSPC.TabIndex = 39;
			this.labelSPC.Text = "SP Cost";
			// 
			// comboAttackItemGroup
			// 
			this.comboAttackItemGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboAttackItemGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboAttackItemGroup.FormattingEnabled = true;
			this.comboAttackItemGroup.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.comboAttackItemGroup.Location = new System.Drawing.Point(350, 224);
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
			this.labelAttackItemGroup.Location = new System.Drawing.Point(350, 209);
			this.labelAttackItemGroup.Name = "labelAttackItemGroup";
			this.labelAttackItemGroup.Size = new System.Drawing.Size(99, 12);
			this.labelAttackItemGroup.TabIndex = 37;
			this.labelAttackItemGroup.Text = "Attack Item Group";
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
			// numericSSP
			// 
			this.numericSSP.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericSSP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericSSP.Location = new System.Drawing.Point(390, 135);
			this.numericSSP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericSSP.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
			this.numericSSP.Name = "numericSSP";
			this.numericSSP.Size = new System.Drawing.Size(75, 19);
			this.numericSSP.TabIndex = 32;
			this.numericSSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericSSP.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericSSP, "戦闘開始時のSPに付与されるボーナス値。\r\n適応される範囲は 3,000 ～ 50,000 まであり、それ以上、またはそれ以下の値は切り捨てられる。\r\n設定値の範" +
        "囲が有効範囲より広いのは、装備全体で決まるためである。\r\n設定値: -100,000 ～ 100,000");
			// 
			// labelSSP
			// 
			this.labelSSP.AutoSize = true;
			this.labelSSP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelSSP.Location = new System.Drawing.Point(390, 120);
			this.labelSSP.Name = "labelSSP";
			this.labelSSP.Size = new System.Drawing.Size(48, 12);
			this.labelSSP.TabIndex = 31;
			this.labelSSP.Text = "Start SP";
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
			this.numericEC.ThousandsSeparator = true;
			this.toolTipInfo.SetToolTip(this.numericEC, "装備コスト。\r\n装備する時はトータルコストが最大値未満にしなければならない。\r\nEC = (100 + (Level - 1) * 0.73 + JobRank " +
        "* 1.67)\r\n設定値: 1 ～ 999,999,999,999");
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
			this.labelEC.Size = new System.Drawing.Size(67, 12);
			this.labelEC.TabIndex = 29;
			this.labelEC.Text = "Equip Ccost";
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelInfo.Location = new System.Drawing.Point(10, 675);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(85, 12);
			this.labelInfo.TabIndex = 16;
			this.labelInfo.Text = "Text Infomation";
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
			this.numericRare.ThousandsSeparator = true;
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
			this.comboEquipItemGroup.Location = new System.Drawing.Point(230, 224);
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
			this.labelEquipItemGroup.Location = new System.Drawing.Point(230, 209);
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
			// labelPhysicsPower
			// 
			this.labelPhysicsPower.AutoSize = true;
			this.labelPhysicsPower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelPhysicsPower.Location = new System.Drawing.Point(10, 255);
			this.labelPhysicsPower.Name = "labelPhysicsPower";
			this.labelPhysicsPower.Size = new System.Drawing.Size(53, 12);
			this.labelPhysicsPower.TabIndex = 49;
			this.labelPhysicsPower.Text = "物理威力";
			// 
			// numericPhysicsPower
			// 
			this.numericPhysicsPower.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericPhysicsPower.Location = new System.Drawing.Point(10, 270);
			this.numericPhysicsPower.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
			this.numericPhysicsPower.Minimum = new decimal(new int[] {
            150000,
            0,
            0,
            -2147483648});
			this.numericPhysicsPower.Name = "numericPhysicsPower";
			this.numericPhysicsPower.Size = new System.Drawing.Size(100, 19);
			this.numericPhysicsPower.TabIndex = 50;
			this.numericPhysicsPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericPhysicsPower.ThousandsSeparator = true;
			// 
			// labelMagicPower
			// 
			this.labelMagicPower.AutoSize = true;
			this.labelMagicPower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelMagicPower.Location = new System.Drawing.Point(120, 255);
			this.labelMagicPower.Name = "labelMagicPower";
			this.labelMagicPower.Size = new System.Drawing.Size(53, 12);
			this.labelMagicPower.TabIndex = 51;
			this.labelMagicPower.Text = "魔法威力";
			// 
			// numericMagicPower
			// 
			this.numericMagicPower.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericMagicPower.Location = new System.Drawing.Point(120, 270);
			this.numericMagicPower.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
			this.numericMagicPower.Minimum = new decimal(new int[] {
            150000,
            0,
            0,
            -2147483648});
			this.numericMagicPower.Name = "numericMagicPower";
			this.numericMagicPower.Size = new System.Drawing.Size(100, 19);
			this.numericMagicPower.TabIndex = 52;
			this.numericMagicPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericMagicPower.ThousandsSeparator = true;
			// 
			// labelPhysicsDefence
			// 
			this.labelPhysicsDefence.AutoSize = true;
			this.labelPhysicsDefence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelPhysicsDefence.Location = new System.Drawing.Point(240, 255);
			this.labelPhysicsDefence.Name = "labelPhysicsDefence";
			this.labelPhysicsDefence.Size = new System.Drawing.Size(53, 12);
			this.labelPhysicsDefence.TabIndex = 53;
			this.labelPhysicsDefence.Text = "物理耐性";
			// 
			// numericPhysicsDefence
			// 
			this.numericPhysicsDefence.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericPhysicsDefence.Location = new System.Drawing.Point(240, 270);
			this.numericPhysicsDefence.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
			this.numericPhysicsDefence.Minimum = new decimal(new int[] {
            150000,
            0,
            0,
            -2147483648});
			this.numericPhysicsDefence.Name = "numericPhysicsDefence";
			this.numericPhysicsDefence.Size = new System.Drawing.Size(100, 19);
			this.numericPhysicsDefence.TabIndex = 54;
			this.numericPhysicsDefence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericPhysicsDefence.ThousandsSeparator = true;
			// 
			// labelMagicDefence
			// 
			this.labelMagicDefence.AutoSize = true;
			this.labelMagicDefence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelMagicDefence.Location = new System.Drawing.Point(360, 255);
			this.labelMagicDefence.Name = "labelMagicDefence";
			this.labelMagicDefence.Size = new System.Drawing.Size(53, 12);
			this.labelMagicDefence.TabIndex = 55;
			this.labelMagicDefence.Text = "魔法耐性";
			// 
			// numericMagicDefence
			// 
			this.numericMagicDefence.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericMagicDefence.Location = new System.Drawing.Point(360, 270);
			this.numericMagicDefence.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
			this.numericMagicDefence.Minimum = new decimal(new int[] {
            150000,
            0,
            0,
            -2147483648});
			this.numericMagicDefence.Name = "numericMagicDefence";
			this.numericMagicDefence.Size = new System.Drawing.Size(100, 19);
			this.numericMagicDefence.TabIndex = 56;
			this.numericMagicDefence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericMagicDefence.ThousandsSeparator = true;
			// 
			// numericReductionRate
			// 
			this.numericReductionRate.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.numericReductionRate.Location = new System.Drawing.Point(480, 270);
			this.numericReductionRate.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
			this.numericReductionRate.Minimum = new decimal(new int[] {
            30000,
            0,
            0,
            -2147483648});
			this.numericReductionRate.Name = "numericReductionRate";
			this.numericReductionRate.Size = new System.Drawing.Size(100, 19);
			this.numericReductionRate.TabIndex = 58;
			this.numericReductionRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericReductionRate.ThousandsSeparator = true;
			// 
			// labelReductionRate
			// 
			this.labelReductionRate.AutoSize = true;
			this.labelReductionRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelReductionRate.Location = new System.Drawing.Point(480, 255);
			this.labelReductionRate.Name = "labelReductionRate";
			this.labelReductionRate.Size = new System.Drawing.Size(78, 12);
			this.labelReductionRate.TabIndex = 57;
			this.labelReductionRate.Text = "ダメージ軽減率";
			// 
			// textPrice
			// 
			this.textPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textPrice.Location = new System.Drawing.Point(10, 315);
			this.textPrice.Name = "textPrice";
			this.textPrice.Size = new System.Drawing.Size(400, 19);
			this.textPrice.TabIndex = 60;
			this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
			this.textPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textPrice_Validating);
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelPrice.Location = new System.Drawing.Point(10, 300);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(149, 12);
			this.labelPrice.TabIndex = 59;
			this.labelPrice.Text = "販売価格(売却額はこの半分)";
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
			((System.ComponentModel.ISupportInitialize)(this.numericATC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSPC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSSP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericEC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPhysicsPower)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMagicPower)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPhysicsDefence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMagicDefence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericReductionRate)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupInfomation;
		private ToolTip toolTipInfo;
		private NumericUpDown numericWT;
		private Label labelWT;
		private NumericUpDown numericRare;
		private Label labelRare;
		private TextBox textItemName;
		private Label labelItemName;
		private TextBox textItemID;
		private Label labelItemID;
		private Label labelInfo;
		private TextBox textInfo;
		private NumericUpDown numericSSP;
		private Label labelSSP;
		private NumericUpDown numericEC;
		private Label labelEC;
		private ComboBox comboEquipItemGroup;
		private Label labelEquipItemGroup;
		private ComboBox comboElement2;
		private Label labelElement2;
		private ComboBox comboElement1;
		private Label labelElement1;
		private ComboBox comboAttackItemGroup;
		private Label labelAttackItemGroup;
		private NumericUpDown numericSPC;
		private Label labelSPC;
		private NumericUpDown numericATC;
		private Label labelATC;
		private ComboBox comboMaker;
		private Label labelMaker;
		private ComboBox comboTarget;
		private Label labelTarget;
		private ComboBox comboEType;
		private Label labelEType;
		private NumericUpDown numericReductionRate;
		private Label labelReductionRate;
		private NumericUpDown numericMagicDefence;
		private Label labelMagicDefence;
		private NumericUpDown numericPhysicsDefence;
		private Label labelPhysicsDefence;
		private NumericUpDown numericMagicPower;
		private Label labelMagicPower;
		private NumericUpDown numericPhysicsPower;
		private Label labelPhysicsPower;
		private TextBox textPrice;
		private Label labelPrice;
	}
}
