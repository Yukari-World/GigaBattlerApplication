﻿namespace Status_Editer {
	partial class EditerMainMenu {
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

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.StripMainMenu = new System.Windows.Forms.MenuStrip();
			this.StripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.StripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuViwer = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDatabase = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDatabaseReload = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDatabaseSave = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowView = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.StripMenuHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabControlMonster = new System.Windows.Forms.TabControl();
			this.tabPage21 = new System.Windows.Forms.TabPage();
			this.DropInfomation = new Status_Editer.User_Control.tabMonster.DropInfomation();
			this.UnitInfomation = new Status_Editer.User_Control.tabMonster.UnitInfomation();
			this.tabPage22 = new System.Windows.Forms.TabPage();
			this.StatusInfomation = new Status_Editer.User_Control.tabMonster.StatusInfomation();
			this.tabPage23 = new System.Windows.Forms.TabPage();
			this.ActiveSkillInfomation = new Status_Editer.User_Control.tabMonster.ActiveSkillInfomation();
			this.tabPage24 = new System.Windows.Forms.TabPage();
			this.PassiveSkillInfomation = new Status_Editer.User_Control.tabMonster.PassiveSkillInfomation();
			this.listMonster = new System.Windows.Forms.ListBox();
			this.tablemonsterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.GigaBattlerDataSet = new Status_Editer.GigaBattlerDataSet();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.listUnitType = new System.Windows.Forms.ListBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.tabPage12 = new System.Windows.Forms.TabPage();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.tabPage14 = new System.Windows.Forms.TabPage();
			this.tabPage15 = new System.Windows.Forms.TabPage();
			this.tabPage16 = new System.Windows.Forms.TabPage();
			this.tabPage17 = new System.Windows.Forms.TabPage();
			this.tabPage18 = new System.Windows.Forms.TabPage();
			this.tabPage19 = new System.Windows.Forms.TabPage();
			this.tabPage20 = new System.Windows.Forms.TabPage();
			this.tableskillBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableweaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.StripInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.@__table_monsterTableAdapter = new Status_Editer.GigaBattlerDataSetTableAdapters.@__table_monsterTableAdapter();
			this.@__table_weaponTableAdapter = new Status_Editer.GigaBattlerDataSetTableAdapters.@__table_weaponTableAdapter();
			this.@__table_raceTableAdapter = new Status_Editer.GigaBattlerDataSetTableAdapters.@__table_raceTableAdapter();
			this.tableraceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.@__table_skillTableAdapter = new Status_Editer.GigaBattlerDataSetTableAdapters.@__table_skillTableAdapter();
			this.StripMainMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabControlMonster.SuspendLayout();
			this.tabPage21.SuspendLayout();
			this.tabPage22.SuspendLayout();
			this.tabPage23.SuspendLayout();
			this.tabPage24.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablemonsterBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GigaBattlerDataSet)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableskillBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableweaponBindingSource)).BeginInit();
			this.ToolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.ToolStripContainer.ContentPanel.SuspendLayout();
			this.ToolStripContainer.TopToolStripPanel.SuspendLayout();
			this.ToolStripContainer.SuspendLayout();
			this.StatusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableraceBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// StripMainMenu
			// 
			this.StripMainMenu.BackColor = System.Drawing.Color.Transparent;
			this.StripMainMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.StripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFile,
            this.StripMenuEdit,
            this.StripMenuViwer,
            this.StripMenuDatabase,
            this.StripMenuWindow,
            this.StripMenuHelp});
			this.StripMainMenu.Location = new System.Drawing.Point(0, 0);
			this.StripMainMenu.Name = "StripMainMenu";
			this.StripMainMenu.Size = new System.Drawing.Size(1600, 24);
			this.StripMainMenu.TabIndex = 0;
			// 
			// StripMenuFile
			// 
			this.StripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFileOpen,
            this.toolStripSeparator1,
            this.StripMenuExit});
			this.StripMenuFile.Name = "StripMenuFile";
			this.StripMenuFile.Size = new System.Drawing.Size(66, 20);
			this.StripMenuFile.Text = "ファイル(&F)";
			// 
			// StripMenuFileOpen
			// 
			this.StripMenuFileOpen.Name = "StripMenuFileOpen";
			this.StripMenuFileOpen.ShortcutKeyDisplayString = "";
			this.StripMenuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.StripMenuFileOpen.Size = new System.Drawing.Size(234, 22);
			this.StripMenuFileOpen.Text = "開く(&O)";
			this.StripMenuFileOpen.Click += new System.EventHandler(this.StripMenuFileOpen_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
			// 
			// StripMenuExit
			// 
			this.StripMenuExit.Name = "StripMenuExit";
			this.StripMenuExit.ShortcutKeyDisplayString = "";
			this.StripMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.StripMenuExit.Size = new System.Drawing.Size(234, 22);
			this.StripMenuExit.Text = "アプリケーションの終了(&X)";
			this.StripMenuExit.Click += new System.EventHandler(this.StripMenuExit_Click);
			// 
			// StripMenuEdit
			// 
			this.StripMenuEdit.Name = "StripMenuEdit";
			this.StripMenuEdit.Size = new System.Drawing.Size(57, 20);
			this.StripMenuEdit.Text = "編集(&E)";
			// 
			// StripMenuViwer
			// 
			this.StripMenuViwer.Name = "StripMenuViwer";
			this.StripMenuViwer.Size = new System.Drawing.Size(58, 20);
			this.StripMenuViwer.Text = "表示(&V)";
			// 
			// StripMenuDatabase
			// 
			this.StripMenuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuDatabaseReload,
            this.StripMenuDatabaseSave});
			this.StripMenuDatabase.Name = "StripMenuDatabase";
			this.StripMenuDatabase.Size = new System.Drawing.Size(88, 20);
			this.StripMenuDatabase.Text = "データベース(&D)";
			// 
			// StripMenuDatabaseReload
			// 
			this.StripMenuDatabaseReload.Name = "StripMenuDatabaseReload";
			this.StripMenuDatabaseReload.Size = new System.Drawing.Size(147, 22);
			this.StripMenuDatabaseReload.Text = "再読み込み(&R)";
			this.StripMenuDatabaseReload.Click += new System.EventHandler(this.StripMenuDatabaseReload_Click);
			// 
			// StripMenuDatabaseSave
			// 
			this.StripMenuDatabaseSave.Name = "StripMenuDatabaseSave";
			this.StripMenuDatabaseSave.Size = new System.Drawing.Size(147, 22);
			this.StripMenuDatabaseSave.Text = "変更を適用(&S)";
			this.StripMenuDatabaseSave.Click += new System.EventHandler(this.StripMenuDatabaseSave_Click);
			// 
			// StripMenuWindow
			// 
			this.StripMenuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuWindowView});
			this.StripMenuWindow.Name = "StripMenuWindow";
			this.StripMenuWindow.Size = new System.Drawing.Size(79, 20);
			this.StripMenuWindow.Text = "ウィンドウ(&W)";
			// 
			// StripMenuWindowView
			// 
			this.StripMenuWindowView.Name = "StripMenuWindowView";
			this.StripMenuWindowView.Size = new System.Drawing.Size(157, 22);
			this.StripMenuWindowView.Text = "テーブルの表示(&T)";
			this.StripMenuWindowView.Click += new System.EventHandler(this.StripMenuWindowView_Click);
			// 
			// StripMenuHelp
			// 
			this.StripMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuHelpHelp,
            this.toolStripSeparator2,
            this.StripMenuHelpVersion});
			this.StripMenuHelp.Name = "StripMenuHelp";
			this.StripMenuHelp.Size = new System.Drawing.Size(65, 20);
			this.StripMenuHelp.Text = "ヘルプ(&H)";
			// 
			// StripMenuHelpHelp
			// 
			this.StripMenuHelpHelp.Name = "StripMenuHelpHelp";
			this.StripMenuHelpHelp.Size = new System.Drawing.Size(158, 22);
			this.StripMenuHelpHelp.Text = "ヘルプの表示(&V)";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
			// 
			// StripMenuHelpVersion
			// 
			this.StripMenuHelpVersion.Name = "StripMenuHelpVersion";
			this.StripMenuHelpVersion.Size = new System.Drawing.Size(158, 22);
			this.StripMenuHelpVersion.Text = "バージョン情報(&A)";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage9);
			this.tabControl1.Controls.Add(this.tabPage10);
			this.tabControl1.Controls.Add(this.tabPage11);
			this.tabControl1.Controls.Add(this.tabPage12);
			this.tabControl1.Controls.Add(this.tabPage13);
			this.tabControl1.Controls.Add(this.tabPage14);
			this.tabControl1.Controls.Add(this.tabPage15);
			this.tabControl1.Controls.Add(this.tabPage16);
			this.tabControl1.Controls.Add(this.tabPage17);
			this.tabControl1.Controls.Add(this.tabPage18);
			this.tabControl1.Controls.Add(this.tabPage19);
			this.tabControl1.Controls.Add(this.tabPage20);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1600, 854);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1592, 828);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "メイン";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1592, 828);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "雑多";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tabControlMonster);
			this.tabPage3.Controls.Add(this.listMonster);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1592, 828);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "モンスター";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabControlMonster
			// 
			this.tabControlMonster.Controls.Add(this.tabPage21);
			this.tabControlMonster.Controls.Add(this.tabPage22);
			this.tabControlMonster.Controls.Add(this.tabPage23);
			this.tabControlMonster.Controls.Add(this.tabPage24);
			this.tabControlMonster.Location = new System.Drawing.Point(209, 0);
			this.tabControlMonster.Margin = new System.Windows.Forms.Padding(0);
			this.tabControlMonster.Name = "tabControlMonster";
			this.tabControlMonster.SelectedIndex = 0;
			this.tabControlMonster.Size = new System.Drawing.Size(1387, 830);
			this.tabControlMonster.TabIndex = 1;
			// 
			// tabPage21
			// 
			this.tabPage21.Controls.Add(this.DropInfomation);
			this.tabPage21.Controls.Add(this.UnitInfomation);
			this.tabPage21.Location = new System.Drawing.Point(4, 22);
			this.tabPage21.Name = "tabPage21";
			this.tabPage21.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage21.Size = new System.Drawing.Size(1379, 804);
			this.tabPage21.TabIndex = 0;
			this.tabPage21.Text = "基本情報";
			this.tabPage21.UseVisualStyleBackColor = true;
			// 
			// DropInfomation
			// 
			this.DropInfomation.BackColor = System.Drawing.Color.Transparent;
			this.DropInfomation.Location = new System.Drawing.Point(610, 0);
			this.DropInfomation.Name = "DropInfomation";
			this.DropInfomation.Size = new System.Drawing.Size(760, 800);
			this.DropInfomation.TabIndex = 1;
			// 
			// UnitInfomation
			// 
			this.UnitInfomation.BackColor = System.Drawing.Color.Transparent;
			this.UnitInfomation.Location = new System.Drawing.Point(0, 0);
			this.UnitInfomation.Name = "UnitInfomation";
			this.UnitInfomation.Size = new System.Drawing.Size(600, 800);
			this.UnitInfomation.TabIndex = 0;
			// 
			// tabPage22
			// 
			this.tabPage22.Controls.Add(this.StatusInfomation);
			this.tabPage22.Location = new System.Drawing.Point(4, 22);
			this.tabPage22.Name = "tabPage22";
			this.tabPage22.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage22.Size = new System.Drawing.Size(1379, 804);
			this.tabPage22.TabIndex = 1;
			this.tabPage22.Text = "パラメータ";
			this.tabPage22.UseVisualStyleBackColor = true;
			// 
			// StatusInfomation
			// 
			this.StatusInfomation.BackColor = System.Drawing.Color.Transparent;
			this.StatusInfomation.Location = new System.Drawing.Point(0, 0);
			this.StatusInfomation.Name = "StatusInfomation";
			this.StatusInfomation.numEVT = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numEXP = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numHIT = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numHP = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.StatusInfomation.numLuck = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPEVT = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusInfomation.numLvPEXP = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPHIT = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusInfomation.numLvPHP = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.StatusInfomation.numLvPLuck = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StatusInfomation.numLvPMagicATK = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPMagicDEF = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPMeleeATK = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPMeleeDEF = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPMoney = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPRangeATK = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPRangeDEF = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numLvPSPD = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StatusInfomation.numMagicATK = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numMagicDEF = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numMaxLevel = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.StatusInfomation.numMaxTP = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.StatusInfomation.numMeleeATK = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numMeleeDEF = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numMinLevel = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.StatusInfomation.numMoney = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numRangeATK = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numRangeDEF = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numScaleEXP = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleHP = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleMagicATK = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleMagicDEF = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleMeleeATK = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleMeleeDEF = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleMoney = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleRangeATK = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleRangeDEF = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numScaleSPD = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.StatusInfomation.numSPD = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StatusInfomation.numTP = new decimal(new int[] {
            250,
            0,
            0,
            0});
			this.StatusInfomation.Size = new System.Drawing.Size(1375, 800);
			this.StatusInfomation.TabIndex = 0;
			// 
			// tabPage23
			// 
			this.tabPage23.Controls.Add(this.ActiveSkillInfomation);
			this.tabPage23.Location = new System.Drawing.Point(4, 22);
			this.tabPage23.Name = "tabPage23";
			this.tabPage23.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage23.Size = new System.Drawing.Size(1379, 804);
			this.tabPage23.TabIndex = 2;
			this.tabPage23.Text = "アクティブスキル";
			this.tabPage23.UseVisualStyleBackColor = true;
			// 
			// ActiveSkillInfomation
			// 
			this.ActiveSkillInfomation.Location = new System.Drawing.Point(0, 0);
			this.ActiveSkillInfomation.Name = "ActiveSkillInfomation";
			this.ActiveSkillInfomation.Size = new System.Drawing.Size(1375, 800);
			this.ActiveSkillInfomation.TabIndex = 0;
			// 
			// tabPage24
			// 
			this.tabPage24.Controls.Add(this.PassiveSkillInfomation);
			this.tabPage24.Location = new System.Drawing.Point(4, 22);
			this.tabPage24.Name = "tabPage24";
			this.tabPage24.Size = new System.Drawing.Size(1379, 804);
			this.tabPage24.TabIndex = 3;
			this.tabPage24.Text = "パッシブスキル";
			this.tabPage24.UseVisualStyleBackColor = true;
			// 
			// PassiveSkillInfomation
			// 
			this.PassiveSkillInfomation.Location = new System.Drawing.Point(0, 0);
			this.PassiveSkillInfomation.Name = "PassiveSkillInfomation";
			this.PassiveSkillInfomation.Size = new System.Drawing.Size(1375, 800);
			this.PassiveSkillInfomation.TabIndex = 0;
			// 
			// listMonster
			// 
			this.listMonster.DataSource = this.tablemonsterBindingSource;
			this.listMonster.DisplayMember = "MonsterName";
			this.listMonster.FormattingEnabled = true;
			this.listMonster.ItemHeight = 12;
			this.listMonster.Location = new System.Drawing.Point(3, 3);
			this.listMonster.Name = "listMonster";
			this.listMonster.Size = new System.Drawing.Size(200, 820);
			this.listMonster.TabIndex = 0;
			this.listMonster.ValueMember = "MonsterID";
			// 
			// tablemonsterBindingSource
			// 
			this.tablemonsterBindingSource.DataMember = "__table_monster";
			this.tablemonsterBindingSource.DataSource = this.GigaBattlerDataSet;
			// 
			// GigaBattlerDataSet
			// 
			this.GigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.GigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.listUnitType);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1592, 828);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "ユニットタイプ";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// listUnitType
			// 
			this.listUnitType.FormattingEnabled = true;
			this.listUnitType.ItemHeight = 12;
			this.listUnitType.Location = new System.Drawing.Point(3, 3);
			this.listUnitType.Name = "listUnitType";
			this.listUnitType.Size = new System.Drawing.Size(200, 820);
			this.listUnitType.TabIndex = 0;
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(1592, 828);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "種族";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(1592, 828);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "ジョブ";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// tabPage7
			// 
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(1592, 828);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "武器";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// tabPage8
			// 
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(1592, 828);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "盾";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// tabPage9
			// 
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(1592, 828);
			this.tabPage9.TabIndex = 8;
			this.tabPage9.Text = "頭防具";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// tabPage10
			// 
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(1592, 828);
			this.tabPage10.TabIndex = 9;
			this.tabPage10.Text = "籠手";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// tabPage11
			// 
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Size = new System.Drawing.Size(1592, 828);
			this.tabPage11.TabIndex = 10;
			this.tabPage11.Text = "体防具";
			this.tabPage11.UseVisualStyleBackColor = true;
			// 
			// tabPage12
			// 
			this.tabPage12.Location = new System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Size = new System.Drawing.Size(1592, 828);
			this.tabPage12.TabIndex = 11;
			this.tabPage12.Text = "アクセサリー";
			this.tabPage12.UseVisualStyleBackColor = true;
			// 
			// tabPage13
			// 
			this.tabPage13.Location = new System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Size = new System.Drawing.Size(1592, 828);
			this.tabPage13.TabIndex = 12;
			this.tabPage13.Text = "スキル";
			this.tabPage13.UseVisualStyleBackColor = true;
			// 
			// tabPage14
			// 
			this.tabPage14.Location = new System.Drawing.Point(4, 22);
			this.tabPage14.Name = "tabPage14";
			this.tabPage14.Size = new System.Drawing.Size(1592, 828);
			this.tabPage14.TabIndex = 13;
			this.tabPage14.Text = "都市名・地名";
			this.tabPage14.UseVisualStyleBackColor = true;
			// 
			// tabPage15
			// 
			this.tabPage15.Location = new System.Drawing.Point(4, 22);
			this.tabPage15.Name = "tabPage15";
			this.tabPage15.Size = new System.Drawing.Size(1592, 828);
			this.tabPage15.TabIndex = 14;
			this.tabPage15.Text = "戦闘場所";
			this.tabPage15.UseVisualStyleBackColor = true;
			// 
			// tabPage16
			// 
			this.tabPage16.Location = new System.Drawing.Point(4, 22);
			this.tabPage16.Name = "tabPage16";
			this.tabPage16.Size = new System.Drawing.Size(1592, 828);
			this.tabPage16.TabIndex = 15;
			this.tabPage16.Text = "Wave管理";
			this.tabPage16.UseVisualStyleBackColor = true;
			// 
			// tabPage17
			// 
			this.tabPage17.Location = new System.Drawing.Point(4, 22);
			this.tabPage17.Name = "tabPage17";
			this.tabPage17.Size = new System.Drawing.Size(1592, 828);
			this.tabPage17.TabIndex = 16;
			this.tabPage17.Text = "tabPage17";
			this.tabPage17.UseVisualStyleBackColor = true;
			// 
			// tabPage18
			// 
			this.tabPage18.Location = new System.Drawing.Point(4, 22);
			this.tabPage18.Name = "tabPage18";
			this.tabPage18.Size = new System.Drawing.Size(1592, 828);
			this.tabPage18.TabIndex = 17;
			this.tabPage18.Text = "tabPage18";
			this.tabPage18.UseVisualStyleBackColor = true;
			// 
			// tabPage19
			// 
			this.tabPage19.Location = new System.Drawing.Point(4, 22);
			this.tabPage19.Name = "tabPage19";
			this.tabPage19.Size = new System.Drawing.Size(1592, 828);
			this.tabPage19.TabIndex = 18;
			this.tabPage19.Text = "tabPage19";
			this.tabPage19.UseVisualStyleBackColor = true;
			// 
			// tabPage20
			// 
			this.tabPage20.Location = new System.Drawing.Point(4, 22);
			this.tabPage20.Name = "tabPage20";
			this.tabPage20.Size = new System.Drawing.Size(1592, 828);
			this.tabPage20.TabIndex = 19;
			this.tabPage20.Text = "tabPage20";
			this.tabPage20.UseVisualStyleBackColor = true;
			// 
			// tableskillBindingSource
			// 
			this.tableskillBindingSource.DataMember = "__table_skill";
			this.tableskillBindingSource.DataSource = this.GigaBattlerDataSet;
			// 
			// tableweaponBindingSource
			// 
			this.tableweaponBindingSource.DataMember = "__table_weapon";
			this.tableweaponBindingSource.DataSource = this.GigaBattlerDataSet;
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
			// ToolStripContainer
			// 
			// 
			// ToolStripContainer.BottomToolStripPanel
			// 
			this.ToolStripContainer.BottomToolStripPanel.Controls.Add(this.StatusStrip);
			// 
			// ToolStripContainer.ContentPanel
			// 
			this.ToolStripContainer.ContentPanel.Controls.Add(this.tabControl1);
			this.ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(1600, 854);
			this.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ToolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.ToolStripContainer.Name = "ToolStripContainer";
			this.ToolStripContainer.Size = new System.Drawing.Size(1600, 900);
			this.ToolStripContainer.TabIndex = 3;
			this.ToolStripContainer.Text = "ToolStripContainer";
			// 
			// ToolStripContainer.TopToolStripPanel
			// 
			this.ToolStripContainer.TopToolStripPanel.Controls.Add(this.StripMainMenu);
			// 
			// StatusStrip
			// 
			this.StatusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripInfo,
            this.toolStripProgressBar1});
			this.StatusStrip.Location = new System.Drawing.Point(0, 0);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(1600, 22);
			this.StatusStrip.TabIndex = 2;
			// 
			// StripInfo
			// 
			this.StripInfo.Name = "StripInfo";
			this.StripInfo.Size = new System.Drawing.Size(117, 17);
			this.StripInfo.Text = "StripInfomationLabel";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
			// 
			// contextMenu
			// 
			this.contextMenu.BackColor = System.Drawing.Color.Transparent;
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(61, 4);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Visible = true;
			// 
			// __table_monsterTableAdapter
			// 
			this.@__table_monsterTableAdapter.ClearBeforeFill = true;
			// 
			// __table_weaponTableAdapter
			// 
			this.@__table_weaponTableAdapter.ClearBeforeFill = true;
			// 
			// __table_raceTableAdapter
			// 
			this.@__table_raceTableAdapter.ClearBeforeFill = true;
			// 
			// tableraceBindingSource
			// 
			this.tableraceBindingSource.DataMember = "__table_race";
			this.tableraceBindingSource.DataSource = this.GigaBattlerDataSet;
			// 
			// __table_skillTableAdapter
			// 
			this.@__table_skillTableAdapter.ClearBeforeFill = true;
			// 
			// EditerMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1600, 900);
			this.Controls.Add(this.ToolStripContainer);
			this.MainMenuStrip = this.StripMainMenu;
			this.Name = "EditerMainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giga Battler Status Editer";
			this.Load += new System.EventHandler(this.EditerMainMenu_Load);
			this.StripMainMenu.ResumeLayout(false);
			this.StripMainMenu.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabControlMonster.ResumeLayout(false);
			this.tabPage21.ResumeLayout(false);
			this.tabPage22.ResumeLayout(false);
			this.tabPage23.ResumeLayout(false);
			this.tabPage24.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tablemonsterBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GigaBattlerDataSet)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tableskillBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableweaponBindingSource)).EndInit();
			this.ToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer.BottomToolStripPanel.PerformLayout();
			this.ToolStripContainer.ContentPanel.ResumeLayout(false);
			this.ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer.TopToolStripPanel.PerformLayout();
			this.ToolStripContainer.ResumeLayout(false);
			this.ToolStripContainer.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableraceBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip StripMainMenu;
		private System.Windows.Forms.ToolStripMenuItem StripMenuFile;
		private System.Windows.Forms.ToolStripMenuItem StripMenuEdit;
		private System.Windows.Forms.ToolStripMenuItem StripMenuViwer;
		private System.Windows.Forms.ToolStripMenuItem StripMenuDatabase;
		private System.Windows.Forms.ToolStripMenuItem StripMenuHelp;
		private System.Windows.Forms.ToolStripMenuItem StripMenuFileOpen;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.TabPage tabPage10;
		private System.Windows.Forms.TabPage tabPage11;
		private System.Windows.Forms.TabPage tabPage12;
		private System.Windows.Forms.TabPage tabPage13;
		private System.Windows.Forms.TabPage tabPage14;
		private System.Windows.Forms.TabPage tabPage15;
		private System.Windows.Forms.TabPage tabPage16;
		private System.Windows.Forms.TabPage tabPage17;
		private System.Windows.Forms.TabPage tabPage18;
		private System.Windows.Forms.TabPage tabPage19;
		private System.Windows.Forms.TabPage tabPage20;
		private System.Windows.Forms.ListBox listMonster;
		private System.Windows.Forms.ToolTip toolTipInfo;
		private System.Windows.Forms.ToolStripContainer ToolStripContainer;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel StripInfo;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem StripMenuExit;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem StripMenuDatabaseReload;
		private System.Windows.Forms.ToolStripMenuItem StripMenuDatabaseSave;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private GigaBattlerDataSet GigaBattlerDataSet;
		private GigaBattlerDataSetTableAdapters.__table_monsterTableAdapter __table_monsterTableAdapter;
		private GigaBattlerDataSetTableAdapters.__table_weaponTableAdapter __table_weaponTableAdapter;
		private GigaBattlerDataSetTableAdapters.__table_raceTableAdapter __table_raceTableAdapter;
		public System.Windows.Forms.BindingSource tableraceBindingSource;
		public System.Windows.Forms.BindingSource tablemonsterBindingSource;
		private System.Windows.Forms.ToolStripMenuItem StripMenuWindow;
		private System.Windows.Forms.ToolStripMenuItem StripMenuWindowView;
		private System.Windows.Forms.BindingSource tableweaponBindingSource;
		private System.Windows.Forms.ToolStripMenuItem StripMenuHelpHelp;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem StripMenuHelpVersion;
		private System.Windows.Forms.TabControl tabControlMonster;
		private System.Windows.Forms.TabPage tabPage21;
		private User_Control.tabMonster.UnitInfomation UnitInfomation;
		private System.Windows.Forms.TabPage tabPage22;
		private System.Windows.Forms.TabPage tabPage23;
		private User_Control.tabMonster.StatusInfomation StatusInfomation;
		private User_Control.tabMonster.DropInfomation DropInfomation;
		private System.Windows.Forms.ListBox listUnitType;
		private System.Windows.Forms.BindingSource tableskillBindingSource;
		private GigaBattlerDataSetTableAdapters.__table_skillTableAdapter __table_skillTableAdapter;
		private System.Windows.Forms.TabPage tabPage24;
		private User_Control.tabMonster.ActiveSkillInfomation ActiveSkillInfomation;
		private User_Control.tabMonster.PassiveSkillInfomation PassiveSkillInfomation;
	}
}

