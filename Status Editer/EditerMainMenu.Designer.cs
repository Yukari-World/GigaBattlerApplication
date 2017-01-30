using CommonLibrary;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer {
	partial class EditerMainMenu {
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

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.ContextListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.StripMenuContextDuplicate = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuContextDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.StripInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabControlUnit = new System.Windows.Forms.TabControl();
			this.tabPage21 = new System.Windows.Forms.TabPage();
			this.TotalUnitInfomation = new Status_Editer.User_Control.tab03Unit.TotalUnitInfomation();
			this.tabPage22 = new System.Windows.Forms.TabPage();
			this.DropInfomation = new Status_Editer.User_Control.tab03Unit.DropInfomation();
			this.UnitInfomation = new Status_Editer.User_Control.tab03Unit.UnitInfomation();
			this.tabPage23 = new System.Windows.Forms.TabPage();
			this.StatusInfomation = new Status_Editer.User_Control.tab03Unit.StatusInfomation();
			this.tabPage24 = new System.Windows.Forms.TabPage();
			this.ActiveSkillInfomation = new Status_Editer.User_Control.tab03Unit.SkillInfomation();
			this.tabPage25 = new System.Windows.Forms.TabPage();
			this.PassiveSkillInfomation = new Status_Editer.User_Control.tab03Unit.AbilityInfomation();
			this.listUnit = new System.Windows.Forms.ListBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.listUnitType = new System.Windows.Forms.ListBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.RaceInfomation = new Status_Editer.User_Control.tab05Race.RaceInfomation();
			this.listRace = new System.Windows.Forms.ListBox();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.JobInfomation = new Status_Editer.User_Control.tab06Job.JobInfomation();
			this.listJob = new System.Windows.Forms.ListBox();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.listMaker = new System.Windows.Forms.ListBox();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.ItemAbilityInfoWeapon = new Status_Editer.User_Control.CommonParts.ItemAbilityInfoParts();
			this.ItemInfoWeapon = new Status_Editer.User_Control.CommonParts.ItemInfoParts();
			this.EquipItemWeapon = new Status_Editer.User_Control.CommonParts.EquipItemStatusParts();
			this.listWeapon = new System.Windows.Forms.ListBox();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.ItemAbilityInfoShield = new Status_Editer.User_Control.CommonParts.ItemAbilityInfoParts();
			this.EquipItemShield = new Status_Editer.User_Control.CommonParts.EquipItemStatusParts();
			this.ItemInfoShield = new Status_Editer.User_Control.CommonParts.ItemInfoParts();
			this.listShield = new System.Windows.Forms.ListBox();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.ItemAbilityInfoHelmet = new Status_Editer.User_Control.CommonParts.ItemAbilityInfoParts();
			this.EquipItemHelmet = new Status_Editer.User_Control.CommonParts.EquipItemStatusParts();
			this.ItemInfoHelmet = new Status_Editer.User_Control.CommonParts.ItemInfoParts();
			this.listHelmet = new System.Windows.Forms.ListBox();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.ItemAbilityInfoGauntlet = new Status_Editer.User_Control.CommonParts.ItemAbilityInfoParts();
			this.EquipItemGauntlet = new Status_Editer.User_Control.CommonParts.EquipItemStatusParts();
			this.ItemInfoGauntlet = new Status_Editer.User_Control.CommonParts.ItemInfoParts();
			this.listGauntlet = new System.Windows.Forms.ListBox();
			this.tabPage12 = new System.Windows.Forms.TabPage();
			this.ItemAbilityInfoArmor = new Status_Editer.User_Control.CommonParts.ItemAbilityInfoParts();
			this.EquipItemArmor = new Status_Editer.User_Control.CommonParts.EquipItemStatusParts();
			this.ItemInfoArmor = new Status_Editer.User_Control.CommonParts.ItemInfoParts();
			this.listArmor = new System.Windows.Forms.ListBox();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.ItemAbilityInfoAccessory = new Status_Editer.User_Control.CommonParts.ItemAbilityInfoParts();
			this.EquipItemAccessory = new Status_Editer.User_Control.CommonParts.EquipItemStatusParts();
			this.ItemInfoAccessory = new Status_Editer.User_Control.CommonParts.ItemInfoParts();
			this.listAccessory = new System.Windows.Forms.ListBox();
			this.tabPage14 = new System.Windows.Forms.TabPage();
			this.skillElementInfomation1 = new Status_Editer.User_Control.tab14Skill.SkillElementInfomation();
			this.SkillStatusInfomation = new Status_Editer.User_Control.tab14Skill.SkillStatusInfomation();
			this.SkillInfomation = new Status_Editer.User_Control.tab14Skill.SkillInfomation();
			this.listSkill = new System.Windows.Forms.ListBox();
			this.tabPage15 = new System.Windows.Forms.TabPage();
			this.listAbility = new System.Windows.Forms.ListBox();
			this.tabPage16 = new System.Windows.Forms.TabPage();
			this.listArea = new System.Windows.Forms.ListBox();
			this.tabPage17 = new System.Windows.Forms.TabPage();
			this.listBattleField = new System.Windows.Forms.ListBox();
			this.tabPage18 = new System.Windows.Forms.TabPage();
			this.tabPage19 = new System.Windows.Forms.TabPage();
			this.tabPage20 = new System.Windows.Forms.TabPage();
			this.StripMainMenu = new System.Windows.Forms.MenuStrip();
			this.StripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuFileImport = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuFileExport = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.StripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.StripMenuEditSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuViwer = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuViwerStatusBar = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDatabase = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDatabaseAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddUnit = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddUnitType = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddRace = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddJob = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddMaker = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddWeapon = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddShield = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddHelmet = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddGauntlet = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddArmor = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddAccessory = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddSkill = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbAddAbility = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDatabaseReload = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadAll = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.StripMenuDbReloadUnit = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadUnitType = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadRace = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadJob = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadMaker = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadWeapon = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadShield = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadHelmet = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadGauntlet = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadArmor = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadAccessory = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadSkill = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbReloadAbility = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDatabaseSave = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveAll = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.StripMenuDbSaveUnit = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveUnitType = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveRace = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveJob = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveMaker = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveWeapon = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveShield = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveHelmet = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveGauntlet = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveArmor = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveAccessory = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveSkill = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuDbSaveAbility = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowView = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewUnit = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewUnitType = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewRace = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewJob = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewMaker = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewWeapon = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewShield = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewHelmet = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewGauntlet = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewArmor = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewAccessory = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewSkill = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuWindowViewAbility = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuHelpDevelop = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenuHelpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.StripMenuHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
			this.GigaBattlerDataSet = new CommonLibrary.GigaBattlerDataSet();
			this.StripMenuWindowViewArea = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextListMenu.SuspendLayout();
			this.ToolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.ToolStripContainer.ContentPanel.SuspendLayout();
			this.ToolStripContainer.TopToolStripPanel.SuspendLayout();
			this.ToolStripContainer.SuspendLayout();
			this.StatusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabControlUnit.SuspendLayout();
			this.tabPage21.SuspendLayout();
			this.tabPage22.SuspendLayout();
			this.tabPage23.SuspendLayout();
			this.tabPage24.SuspendLayout();
			this.tabPage25.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			this.tabPage11.SuspendLayout();
			this.tabPage12.SuspendLayout();
			this.tabPage13.SuspendLayout();
			this.tabPage14.SuspendLayout();
			this.tabPage15.SuspendLayout();
			this.tabPage16.SuspendLayout();
			this.tabPage17.SuspendLayout();
			this.StripMainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GigaBattlerDataSet)).BeginInit();
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
			// notifyIcon
			// 
			this.notifyIcon.Visible = true;
			// 
			// ContextListMenu
			// 
			this.ContextListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuContextDuplicate,
            this.StripMenuContextDelete});
			this.ContextListMenu.Name = "contextMenuStrip1";
			this.ContextListMenu.Size = new System.Drawing.Size(115, 48);
			// 
			// StripMenuContextDuplicate
			// 
			this.StripMenuContextDuplicate.Name = "StripMenuContextDuplicate";
			this.StripMenuContextDuplicate.Size = new System.Drawing.Size(114, 22);
			this.StripMenuContextDuplicate.Text = "複製(&C)";
			this.StripMenuContextDuplicate.Click += new System.EventHandler(this.StripMenuContextDuplicate_Click);
			// 
			// StripMenuContextDelete
			// 
			this.StripMenuContextDelete.Name = "StripMenuContextDelete";
			this.StripMenuContextDelete.Size = new System.Drawing.Size(114, 22);
			this.StripMenuContextDelete.Text = "削除(&D)";
			this.StripMenuContextDelete.Click += new System.EventHandler(this.StripMenuContextDelete_Click);
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
			this.ToolStripContainer.ContentPanel.BackColor = System.Drawing.Color.Transparent;
			this.ToolStripContainer.ContentPanel.Controls.Add(this.tabControl);
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
			this.ToolStripContainer.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
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
			this.StripInfo.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
			this.StripInfo.Name = "StripInfo";
			this.StripInfo.Size = new System.Drawing.Size(1383, 17);
			this.StripInfo.Spring = true;
			this.StripInfo.Text = "StripInfomationLabel";
			this.StripInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
			this.toolStripProgressBar1.Step = 1;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Controls.Add(this.tabPage4);
			this.tabControl.Controls.Add(this.tabPage5);
			this.tabControl.Controls.Add(this.tabPage6);
			this.tabControl.Controls.Add(this.tabPage7);
			this.tabControl.Controls.Add(this.tabPage8);
			this.tabControl.Controls.Add(this.tabPage9);
			this.tabControl.Controls.Add(this.tabPage10);
			this.tabControl.Controls.Add(this.tabPage11);
			this.tabControl.Controls.Add(this.tabPage12);
			this.tabControl.Controls.Add(this.tabPage13);
			this.tabControl.Controls.Add(this.tabPage14);
			this.tabControl.Controls.Add(this.tabPage15);
			this.tabControl.Controls.Add(this.tabPage16);
			this.tabControl.Controls.Add(this.tabPage17);
			this.tabControl.Controls.Add(this.tabPage18);
			this.tabControl.Controls.Add(this.tabPage19);
			this.tabControl.Controls.Add(this.tabPage20);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1600, 854);
			this.tabControl.TabIndex = 0;
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
			this.tabPage3.Controls.Add(this.tabControlUnit);
			this.tabPage3.Controls.Add(this.listUnit);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1592, 828);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "ユニット";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabControlUnit
			// 
			this.tabControlUnit.Controls.Add(this.tabPage21);
			this.tabControlUnit.Controls.Add(this.tabPage22);
			this.tabControlUnit.Controls.Add(this.tabPage23);
			this.tabControlUnit.Controls.Add(this.tabPage24);
			this.tabControlUnit.Controls.Add(this.tabPage25);
			this.tabControlUnit.Location = new System.Drawing.Point(209, 0);
			this.tabControlUnit.Margin = new System.Windows.Forms.Padding(0);
			this.tabControlUnit.Name = "tabControlUnit";
			this.tabControlUnit.SelectedIndex = 0;
			this.tabControlUnit.Size = new System.Drawing.Size(1387, 830);
			this.tabControlUnit.TabIndex = 1;
			// 
			// tabPage21
			// 
			this.tabPage21.Controls.Add(this.TotalUnitInfomation);
			this.tabPage21.Location = new System.Drawing.Point(4, 22);
			this.tabPage21.Name = "tabPage21";
			this.tabPage21.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage21.Size = new System.Drawing.Size(1379, 804);
			this.tabPage21.TabIndex = 0;
			this.tabPage21.Text = "概要";
			this.tabPage21.UseVisualStyleBackColor = true;
			// 
			// TotalUnitInfomation
			// 
			this.TotalUnitInfomation.Location = new System.Drawing.Point(0, 0);
			this.TotalUnitInfomation.Name = "TotalUnitInfomation";
			this.TotalUnitInfomation.Size = new System.Drawing.Size(1375, 800);
			this.TotalUnitInfomation.TabIndex = 0;
			// 
			// tabPage22
			// 
			this.tabPage22.Controls.Add(this.DropInfomation);
			this.tabPage22.Controls.Add(this.UnitInfomation);
			this.tabPage22.Location = new System.Drawing.Point(4, 22);
			this.tabPage22.Name = "tabPage22";
			this.tabPage22.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage22.Size = new System.Drawing.Size(1379, 804);
			this.tabPage22.TabIndex = 1;
			this.tabPage22.Text = "基本データ";
			this.tabPage22.UseVisualStyleBackColor = true;
			// 
			// DropInfomation
			// 
			this.DropInfomation.Location = new System.Drawing.Point(610, 0);
			this.DropInfomation.Name = "DropInfomation";
			this.DropInfomation.Size = new System.Drawing.Size(760, 800);
			this.DropInfomation.TabIndex = 1;
			// 
			// UnitInfomation
			// 
			this.UnitInfomation.Location = new System.Drawing.Point(0, 0);
			this.UnitInfomation.Name = "UnitInfomation";
			this.UnitInfomation.Size = new System.Drawing.Size(600, 800);
			this.UnitInfomation.TabIndex = 0;
			// 
			// tabPage23
			// 
			this.tabPage23.Controls.Add(this.StatusInfomation);
			this.tabPage23.Location = new System.Drawing.Point(4, 22);
			this.tabPage23.Name = "tabPage23";
			this.tabPage23.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage23.Size = new System.Drawing.Size(1379, 804);
			this.tabPage23.TabIndex = 2;
			this.tabPage23.Text = "ステータス";
			this.tabPage23.UseVisualStyleBackColor = true;
			// 
			// StatusInfomation
			// 
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
			// tabPage24
			// 
			this.tabPage24.Controls.Add(this.ActiveSkillInfomation);
			this.tabPage24.Location = new System.Drawing.Point(4, 22);
			this.tabPage24.Name = "tabPage24";
			this.tabPage24.Size = new System.Drawing.Size(1379, 804);
			this.tabPage24.TabIndex = 3;
			this.tabPage24.Text = "スキル";
			this.tabPage24.UseVisualStyleBackColor = true;
			// 
			// ActiveSkillInfomation
			// 
			this.ActiveSkillInfomation.Location = new System.Drawing.Point(0, 0);
			this.ActiveSkillInfomation.Name = "ActiveSkillInfomation";
			this.ActiveSkillInfomation.Size = new System.Drawing.Size(1375, 800);
			this.ActiveSkillInfomation.TabIndex = 0;
			// 
			// tabPage25
			// 
			this.tabPage25.Controls.Add(this.PassiveSkillInfomation);
			this.tabPage25.Location = new System.Drawing.Point(4, 22);
			this.tabPage25.Name = "tabPage25";
			this.tabPage25.Size = new System.Drawing.Size(1379, 804);
			this.tabPage25.TabIndex = 4;
			this.tabPage25.Text = "アビリティ";
			this.tabPage25.UseVisualStyleBackColor = true;
			// 
			// PassiveSkillInfomation
			// 
			this.PassiveSkillInfomation.Location = new System.Drawing.Point(0, 0);
			this.PassiveSkillInfomation.Name = "PassiveSkillInfomation";
			this.PassiveSkillInfomation.Size = new System.Drawing.Size(1375, 800);
			this.PassiveSkillInfomation.TabIndex = 0;
			// 
			// listUnit
			// 
			this.listUnit.ContextMenuStrip = this.ContextListMenu;
			this.listUnit.FormattingEnabled = true;
			this.listUnit.ItemHeight = 12;
			this.listUnit.Location = new System.Drawing.Point(3, 3);
			this.listUnit.Name = "listUnit";
			this.listUnit.Size = new System.Drawing.Size(200, 820);
			this.listUnit.TabIndex = 0;
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
			this.listUnitType.ContextMenuStrip = this.ContextListMenu;
			this.listUnitType.FormattingEnabled = true;
			this.listUnitType.ItemHeight = 12;
			this.listUnitType.Location = new System.Drawing.Point(3, 3);
			this.listUnitType.Name = "listUnitType";
			this.listUnitType.Size = new System.Drawing.Size(200, 820);
			this.listUnitType.TabIndex = 0;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.RaceInfomation);
			this.tabPage5.Controls.Add(this.listRace);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(1592, 828);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "種族";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// RaceInfomation
			// 
			this.RaceInfomation.Location = new System.Drawing.Point(210, 0);
			this.RaceInfomation.Name = "RaceInfomation";
			this.RaceInfomation.Size = new System.Drawing.Size(1380, 820);
			this.RaceInfomation.TabIndex = 1;
			// 
			// listRace
			// 
			this.listRace.ContextMenuStrip = this.ContextListMenu;
			this.listRace.FormattingEnabled = true;
			this.listRace.ItemHeight = 12;
			this.listRace.Location = new System.Drawing.Point(3, 3);
			this.listRace.Name = "listRace";
			this.listRace.Size = new System.Drawing.Size(200, 820);
			this.listRace.TabIndex = 0;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.JobInfomation);
			this.tabPage6.Controls.Add(this.listJob);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(1592, 828);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "ジョブ";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// JobInfomation
			// 
			this.JobInfomation.Location = new System.Drawing.Point(210, 0);
			this.JobInfomation.Name = "JobInfomation";
			this.JobInfomation.Size = new System.Drawing.Size(1380, 820);
			this.JobInfomation.TabIndex = 1;
			// 
			// listJob
			// 
			this.listJob.ContextMenuStrip = this.ContextListMenu;
			this.listJob.FormattingEnabled = true;
			this.listJob.ItemHeight = 12;
			this.listJob.Location = new System.Drawing.Point(3, 3);
			this.listJob.Name = "listJob";
			this.listJob.Size = new System.Drawing.Size(200, 820);
			this.listJob.TabIndex = 0;
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.listMaker);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(1592, 828);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "メーカー";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// listMaker
			// 
			this.listMaker.ContextMenuStrip = this.ContextListMenu;
			this.listMaker.FormattingEnabled = true;
			this.listMaker.ItemHeight = 12;
			this.listMaker.Location = new System.Drawing.Point(3, 3);
			this.listMaker.Name = "listMaker";
			this.listMaker.Size = new System.Drawing.Size(200, 820);
			this.listMaker.TabIndex = 0;
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.ItemAbilityInfoWeapon);
			this.tabPage8.Controls.Add(this.ItemInfoWeapon);
			this.tabPage8.Controls.Add(this.EquipItemWeapon);
			this.tabPage8.Controls.Add(this.listWeapon);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(1592, 828);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "武器";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// ItemAbilityInfoWeapon
			// 
			this.ItemAbilityInfoWeapon.Location = new System.Drawing.Point(820, 300);
			this.ItemAbilityInfoWeapon.Name = "ItemAbilityInfoWeapon";
			this.ItemAbilityInfoWeapon.Size = new System.Drawing.Size(760, 520);
			this.ItemAbilityInfoWeapon.TabIndex = 3;
			// 
			// ItemInfoWeapon
			// 
			this.ItemInfoWeapon.Location = new System.Drawing.Point(210, 0);
			this.ItemInfoWeapon.Name = "ItemInfoWeapon";
			this.ItemInfoWeapon.Size = new System.Drawing.Size(600, 820);
			this.ItemInfoWeapon.TabIndex = 1;
			// 
			// EquipItemWeapon
			// 
			this.EquipItemWeapon.Location = new System.Drawing.Point(820, 0);
			this.EquipItemWeapon.Name = "EquipItemWeapon";
			this.EquipItemWeapon.Size = new System.Drawing.Size(760, 300);
			this.EquipItemWeapon.TabIndex = 2;
			// 
			// listWeapon
			// 
			this.listWeapon.ContextMenuStrip = this.ContextListMenu;
			this.listWeapon.FormattingEnabled = true;
			this.listWeapon.ItemHeight = 12;
			this.listWeapon.Location = new System.Drawing.Point(3, 3);
			this.listWeapon.Name = "listWeapon";
			this.listWeapon.Size = new System.Drawing.Size(200, 820);
			this.listWeapon.TabIndex = 0;
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.ItemAbilityInfoShield);
			this.tabPage9.Controls.Add(this.EquipItemShield);
			this.tabPage9.Controls.Add(this.ItemInfoShield);
			this.tabPage9.Controls.Add(this.listShield);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(1592, 828);
			this.tabPage9.TabIndex = 8;
			this.tabPage9.Text = "盾";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// ItemAbilityInfoShield
			// 
			this.ItemAbilityInfoShield.Location = new System.Drawing.Point(820, 300);
			this.ItemAbilityInfoShield.Name = "ItemAbilityInfoShield";
			this.ItemAbilityInfoShield.Size = new System.Drawing.Size(760, 520);
			this.ItemAbilityInfoShield.TabIndex = 3;
			// 
			// EquipItemShield
			// 
			this.EquipItemShield.Location = new System.Drawing.Point(820, 0);
			this.EquipItemShield.Name = "EquipItemShield";
			this.EquipItemShield.Size = new System.Drawing.Size(760, 300);
			this.EquipItemShield.TabIndex = 2;
			// 
			// ItemInfoShield
			// 
			this.ItemInfoShield.Location = new System.Drawing.Point(210, 0);
			this.ItemInfoShield.Name = "ItemInfoShield";
			this.ItemInfoShield.Size = new System.Drawing.Size(600, 820);
			this.ItemInfoShield.TabIndex = 1;
			// 
			// listShield
			// 
			this.listShield.ContextMenuStrip = this.ContextListMenu;
			this.listShield.FormattingEnabled = true;
			this.listShield.ItemHeight = 12;
			this.listShield.Location = new System.Drawing.Point(3, 3);
			this.listShield.Name = "listShield";
			this.listShield.Size = new System.Drawing.Size(200, 820);
			this.listShield.TabIndex = 0;
			// 
			// tabPage10
			// 
			this.tabPage10.Controls.Add(this.ItemAbilityInfoHelmet);
			this.tabPage10.Controls.Add(this.EquipItemHelmet);
			this.tabPage10.Controls.Add(this.ItemInfoHelmet);
			this.tabPage10.Controls.Add(this.listHelmet);
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(1592, 828);
			this.tabPage10.TabIndex = 9;
			this.tabPage10.Text = "頭防具";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// ItemAbilityInfoHelmet
			// 
			this.ItemAbilityInfoHelmet.Location = new System.Drawing.Point(820, 300);
			this.ItemAbilityInfoHelmet.Name = "ItemAbilityInfoHelmet";
			this.ItemAbilityInfoHelmet.Size = new System.Drawing.Size(760, 520);
			this.ItemAbilityInfoHelmet.TabIndex = 3;
			// 
			// EquipItemHelmet
			// 
			this.EquipItemHelmet.Location = new System.Drawing.Point(820, 0);
			this.EquipItemHelmet.Name = "EquipItemHelmet";
			this.EquipItemHelmet.Size = new System.Drawing.Size(760, 300);
			this.EquipItemHelmet.TabIndex = 2;
			// 
			// ItemInfoHelmet
			// 
			this.ItemInfoHelmet.Location = new System.Drawing.Point(210, 0);
			this.ItemInfoHelmet.Name = "ItemInfoHelmet";
			this.ItemInfoHelmet.Size = new System.Drawing.Size(600, 820);
			this.ItemInfoHelmet.TabIndex = 1;
			// 
			// listHelmet
			// 
			this.listHelmet.ContextMenuStrip = this.ContextListMenu;
			this.listHelmet.FormattingEnabled = true;
			this.listHelmet.ItemHeight = 12;
			this.listHelmet.Location = new System.Drawing.Point(3, 3);
			this.listHelmet.Name = "listHelmet";
			this.listHelmet.Size = new System.Drawing.Size(200, 820);
			this.listHelmet.TabIndex = 0;
			// 
			// tabPage11
			// 
			this.tabPage11.Controls.Add(this.ItemAbilityInfoGauntlet);
			this.tabPage11.Controls.Add(this.EquipItemGauntlet);
			this.tabPage11.Controls.Add(this.ItemInfoGauntlet);
			this.tabPage11.Controls.Add(this.listGauntlet);
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Size = new System.Drawing.Size(1592, 828);
			this.tabPage11.TabIndex = 10;
			this.tabPage11.Text = "籠手";
			this.tabPage11.UseVisualStyleBackColor = true;
			// 
			// ItemAbilityInfoGauntlet
			// 
			this.ItemAbilityInfoGauntlet.Location = new System.Drawing.Point(820, 300);
			this.ItemAbilityInfoGauntlet.Name = "ItemAbilityInfoGauntlet";
			this.ItemAbilityInfoGauntlet.Size = new System.Drawing.Size(760, 520);
			this.ItemAbilityInfoGauntlet.TabIndex = 3;
			// 
			// EquipItemGauntlet
			// 
			this.EquipItemGauntlet.Location = new System.Drawing.Point(820, 0);
			this.EquipItemGauntlet.Name = "EquipItemGauntlet";
			this.EquipItemGauntlet.Size = new System.Drawing.Size(760, 300);
			this.EquipItemGauntlet.TabIndex = 2;
			// 
			// ItemInfoGauntlet
			// 
			this.ItemInfoGauntlet.Location = new System.Drawing.Point(210, 0);
			this.ItemInfoGauntlet.Name = "ItemInfoGauntlet";
			this.ItemInfoGauntlet.Size = new System.Drawing.Size(600, 820);
			this.ItemInfoGauntlet.TabIndex = 1;
			// 
			// listGauntlet
			// 
			this.listGauntlet.ContextMenuStrip = this.ContextListMenu;
			this.listGauntlet.FormattingEnabled = true;
			this.listGauntlet.ItemHeight = 12;
			this.listGauntlet.Location = new System.Drawing.Point(3, 3);
			this.listGauntlet.Name = "listGauntlet";
			this.listGauntlet.Size = new System.Drawing.Size(200, 820);
			this.listGauntlet.TabIndex = 0;
			// 
			// tabPage12
			// 
			this.tabPage12.Controls.Add(this.ItemAbilityInfoArmor);
			this.tabPage12.Controls.Add(this.EquipItemArmor);
			this.tabPage12.Controls.Add(this.ItemInfoArmor);
			this.tabPage12.Controls.Add(this.listArmor);
			this.tabPage12.Location = new System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Size = new System.Drawing.Size(1592, 828);
			this.tabPage12.TabIndex = 11;
			this.tabPage12.Text = "体防具";
			this.tabPage12.UseVisualStyleBackColor = true;
			// 
			// ItemAbilityInfoArmor
			// 
			this.ItemAbilityInfoArmor.Location = new System.Drawing.Point(820, 300);
			this.ItemAbilityInfoArmor.Name = "ItemAbilityInfoArmor";
			this.ItemAbilityInfoArmor.Size = new System.Drawing.Size(760, 520);
			this.ItemAbilityInfoArmor.TabIndex = 3;
			// 
			// EquipItemArmor
			// 
			this.EquipItemArmor.Location = new System.Drawing.Point(820, 0);
			this.EquipItemArmor.Name = "EquipItemArmor";
			this.EquipItemArmor.Size = new System.Drawing.Size(760, 300);
			this.EquipItemArmor.TabIndex = 2;
			// 
			// ItemInfoArmor
			// 
			this.ItemInfoArmor.Location = new System.Drawing.Point(210, 0);
			this.ItemInfoArmor.Name = "ItemInfoArmor";
			this.ItemInfoArmor.Size = new System.Drawing.Size(600, 820);
			this.ItemInfoArmor.TabIndex = 1;
			// 
			// listArmor
			// 
			this.listArmor.ContextMenuStrip = this.ContextListMenu;
			this.listArmor.FormattingEnabled = true;
			this.listArmor.ItemHeight = 12;
			this.listArmor.Location = new System.Drawing.Point(3, 3);
			this.listArmor.Name = "listArmor";
			this.listArmor.Size = new System.Drawing.Size(200, 820);
			this.listArmor.TabIndex = 0;
			// 
			// tabPage13
			// 
			this.tabPage13.Controls.Add(this.ItemAbilityInfoAccessory);
			this.tabPage13.Controls.Add(this.EquipItemAccessory);
			this.tabPage13.Controls.Add(this.ItemInfoAccessory);
			this.tabPage13.Controls.Add(this.listAccessory);
			this.tabPage13.Location = new System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Size = new System.Drawing.Size(1592, 828);
			this.tabPage13.TabIndex = 12;
			this.tabPage13.Text = "アクセサリー";
			this.tabPage13.UseVisualStyleBackColor = true;
			// 
			// ItemAbilityInfoAccessory
			// 
			this.ItemAbilityInfoAccessory.Location = new System.Drawing.Point(820, 300);
			this.ItemAbilityInfoAccessory.Name = "ItemAbilityInfoAccessory";
			this.ItemAbilityInfoAccessory.Size = new System.Drawing.Size(760, 520);
			this.ItemAbilityInfoAccessory.TabIndex = 3;
			// 
			// EquipItemAccessory
			// 
			this.EquipItemAccessory.Location = new System.Drawing.Point(820, 0);
			this.EquipItemAccessory.Name = "EquipItemAccessory";
			this.EquipItemAccessory.Size = new System.Drawing.Size(760, 300);
			this.EquipItemAccessory.TabIndex = 2;
			// 
			// ItemInfoAccessory
			// 
			this.ItemInfoAccessory.Location = new System.Drawing.Point(210, 0);
			this.ItemInfoAccessory.Name = "ItemInfoAccessory";
			this.ItemInfoAccessory.Size = new System.Drawing.Size(600, 820);
			this.ItemInfoAccessory.TabIndex = 1;
			// 
			// listAccessory
			// 
			this.listAccessory.ContextMenuStrip = this.ContextListMenu;
			this.listAccessory.FormattingEnabled = true;
			this.listAccessory.ItemHeight = 12;
			this.listAccessory.Location = new System.Drawing.Point(3, 3);
			this.listAccessory.Name = "listAccessory";
			this.listAccessory.Size = new System.Drawing.Size(200, 820);
			this.listAccessory.TabIndex = 0;
			// 
			// tabPage14
			// 
			this.tabPage14.Controls.Add(this.skillElementInfomation1);
			this.tabPage14.Controls.Add(this.SkillStatusInfomation);
			this.tabPage14.Controls.Add(this.SkillInfomation);
			this.tabPage14.Controls.Add(this.listSkill);
			this.tabPage14.Location = new System.Drawing.Point(4, 22);
			this.tabPage14.Name = "tabPage14";
			this.tabPage14.Size = new System.Drawing.Size(1592, 828);
			this.tabPage14.TabIndex = 13;
			this.tabPage14.Text = "スキル";
			this.tabPage14.UseVisualStyleBackColor = true;
			// 
			// skillElementInfomation1
			// 
			this.skillElementInfomation1.Location = new System.Drawing.Point(820, 300);
			this.skillElementInfomation1.Name = "skillElementInfomation1";
			this.skillElementInfomation1.Size = new System.Drawing.Size(760, 520);
			this.skillElementInfomation1.TabIndex = 3;
			// 
			// SkillStatusInfomation
			// 
			this.SkillStatusInfomation.Location = new System.Drawing.Point(820, 0);
			this.SkillStatusInfomation.Name = "SkillStatusInfomation";
			this.SkillStatusInfomation.Size = new System.Drawing.Size(760, 300);
			this.SkillStatusInfomation.TabIndex = 2;
			// 
			// SkillInfomation
			// 
			this.SkillInfomation.Location = new System.Drawing.Point(210, 0);
			this.SkillInfomation.Name = "SkillInfomation";
			this.SkillInfomation.Size = new System.Drawing.Size(600, 820);
			this.SkillInfomation.TabIndex = 1;
			// 
			// listSkill
			// 
			this.listSkill.ContextMenuStrip = this.ContextListMenu;
			this.listSkill.FormattingEnabled = true;
			this.listSkill.ItemHeight = 12;
			this.listSkill.Location = new System.Drawing.Point(3, 3);
			this.listSkill.Name = "listSkill";
			this.listSkill.Size = new System.Drawing.Size(200, 820);
			this.listSkill.TabIndex = 0;
			// 
			// tabPage15
			// 
			this.tabPage15.Controls.Add(this.listAbility);
			this.tabPage15.Location = new System.Drawing.Point(4, 22);
			this.tabPage15.Name = "tabPage15";
			this.tabPage15.Size = new System.Drawing.Size(1592, 828);
			this.tabPage15.TabIndex = 14;
			this.tabPage15.Text = "アビリティ";
			this.tabPage15.UseVisualStyleBackColor = true;
			// 
			// listAbility
			// 
			this.listAbility.ContextMenuStrip = this.ContextListMenu;
			this.listAbility.FormattingEnabled = true;
			this.listAbility.ItemHeight = 12;
			this.listAbility.Location = new System.Drawing.Point(3, 3);
			this.listAbility.Name = "listAbility";
			this.listAbility.Size = new System.Drawing.Size(200, 820);
			this.listAbility.TabIndex = 0;
			// 
			// tabPage16
			// 
			this.tabPage16.Controls.Add(this.listArea);
			this.tabPage16.Location = new System.Drawing.Point(4, 22);
			this.tabPage16.Name = "tabPage16";
			this.tabPage16.Size = new System.Drawing.Size(1592, 828);
			this.tabPage16.TabIndex = 15;
			this.tabPage16.Text = "都市名・地名";
			this.tabPage16.UseVisualStyleBackColor = true;
			// 
			// listArea
			// 
			this.listArea.ContextMenuStrip = this.ContextListMenu;
			this.listArea.FormattingEnabled = true;
			this.listArea.ItemHeight = 12;
			this.listArea.Location = new System.Drawing.Point(3, 3);
			this.listArea.Name = "listArea";
			this.listArea.Size = new System.Drawing.Size(200, 820);
			this.listArea.TabIndex = 0;
			// 
			// tabPage17
			// 
			this.tabPage17.Controls.Add(this.listBattleField);
			this.tabPage17.Location = new System.Drawing.Point(4, 22);
			this.tabPage17.Name = "tabPage17";
			this.tabPage17.Size = new System.Drawing.Size(1592, 828);
			this.tabPage17.TabIndex = 16;
			this.tabPage17.Text = "戦闘場所";
			this.tabPage17.UseVisualStyleBackColor = true;
			// 
			// listBattleField
			// 
			this.listBattleField.ContextMenuStrip = this.ContextListMenu;
			this.listBattleField.FormattingEnabled = true;
			this.listBattleField.ItemHeight = 12;
			this.listBattleField.Location = new System.Drawing.Point(3, 3);
			this.listBattleField.Name = "listBattleField";
			this.listBattleField.Size = new System.Drawing.Size(200, 820);
			this.listBattleField.TabIndex = 0;
			// 
			// tabPage18
			// 
			this.tabPage18.Location = new System.Drawing.Point(4, 22);
			this.tabPage18.Name = "tabPage18";
			this.tabPage18.Size = new System.Drawing.Size(1592, 828);
			this.tabPage18.TabIndex = 17;
			this.tabPage18.Text = "Wave管理";
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
            this.StripMenuFileImport,
            this.StripMenuFileExport,
            this.StripMenuFileSeparator1,
            this.StripMenuExit});
			this.StripMenuFile.Name = "StripMenuFile";
			this.StripMenuFile.Size = new System.Drawing.Size(66, 20);
			this.StripMenuFile.Text = "ファイル(&F)";
			// 
			// StripMenuFileImport
			// 
			this.StripMenuFileImport.Name = "StripMenuFileImport";
			this.StripMenuFileImport.ShortcutKeyDisplayString = "";
			this.StripMenuFileImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.StripMenuFileImport.Size = new System.Drawing.Size(249, 22);
			this.StripMenuFileImport.Text = "CSVファイルからインポート(&O)";
			this.StripMenuFileImport.Click += new System.EventHandler(this.StripMenuFileOpen_Click);
			// 
			// StripMenuFileExport
			// 
			this.StripMenuFileExport.Name = "StripMenuFileExport";
			this.StripMenuFileExport.Size = new System.Drawing.Size(249, 22);
			this.StripMenuFileExport.Text = "CSVファイルにエクスポート(&I)";
			// 
			// StripMenuFileSeparator1
			// 
			this.StripMenuFileSeparator1.Name = "StripMenuFileSeparator1";
			this.StripMenuFileSeparator1.Size = new System.Drawing.Size(246, 6);
			// 
			// StripMenuExit
			// 
			this.StripMenuExit.Name = "StripMenuExit";
			this.StripMenuExit.ShortcutKeyDisplayString = "";
			this.StripMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.StripMenuExit.Size = new System.Drawing.Size(249, 22);
			this.StripMenuExit.Text = "アプリケーションの終了(&X)";
			this.StripMenuExit.Click += new System.EventHandler(this.StripMenuExit_Click);
			// 
			// StripMenuEdit
			// 
			this.StripMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuEditUndo,
            this.StripMenuEditRedo,
            this.StripMenuEditSeparator1,
            this.StripMenuEditSearch});
			this.StripMenuEdit.Name = "StripMenuEdit";
			this.StripMenuEdit.Size = new System.Drawing.Size(57, 20);
			this.StripMenuEdit.Text = "編集(&E)";
			// 
			// StripMenuEditUndo
			// 
			this.StripMenuEditUndo.Name = "StripMenuEditUndo";
			this.StripMenuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.StripMenuEditUndo.Size = new System.Drawing.Size(173, 22);
			this.StripMenuEditUndo.Text = "元に戻す(&U)";
			this.StripMenuEditUndo.Click += new System.EventHandler(this.StripMenuEditUndo_Click);
			// 
			// StripMenuEditRedo
			// 
			this.StripMenuEditRedo.Name = "StripMenuEditRedo";
			this.StripMenuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.StripMenuEditRedo.Size = new System.Drawing.Size(173, 22);
			this.StripMenuEditRedo.Text = "やり直し(&R)";
			this.StripMenuEditRedo.Click += new System.EventHandler(this.StripMenuEditRedo_Click);
			// 
			// StripMenuEditSeparator1
			// 
			this.StripMenuEditSeparator1.Name = "StripMenuEditSeparator1";
			this.StripMenuEditSeparator1.Size = new System.Drawing.Size(170, 6);
			// 
			// StripMenuEditSearch
			// 
			this.StripMenuEditSearch.Name = "StripMenuEditSearch";
			this.StripMenuEditSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.StripMenuEditSearch.Size = new System.Drawing.Size(173, 22);
			this.StripMenuEditSearch.Text = "検索(&F)";
			// 
			// StripMenuViwer
			// 
			this.StripMenuViwer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuViwerStatusBar});
			this.StripMenuViwer.Name = "StripMenuViwer";
			this.StripMenuViwer.Size = new System.Drawing.Size(58, 20);
			this.StripMenuViwer.Text = "表示(&V)";
			// 
			// StripMenuViwerStatusBar
			// 
			this.StripMenuViwerStatusBar.Checked = true;
			this.StripMenuViwerStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.StripMenuViwerStatusBar.Name = "StripMenuViwerStatusBar";
			this.StripMenuViwerStatusBar.Size = new System.Drawing.Size(150, 22);
			this.StripMenuViwerStatusBar.Text = "ステータスバー(&S)";
			this.StripMenuViwerStatusBar.Click += new System.EventHandler(this.StripMenuViwerStatusBar_Click);
			// 
			// StripMenuDatabase
			// 
			this.StripMenuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuDatabaseAdd,
            this.StripMenuDatabaseReload,
            this.StripMenuDatabaseSave});
			this.StripMenuDatabase.Name = "StripMenuDatabase";
			this.StripMenuDatabase.Size = new System.Drawing.Size(88, 20);
			this.StripMenuDatabase.Text = "データベース(&D)";
			// 
			// StripMenuDatabaseAdd
			// 
			this.StripMenuDatabaseAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuDbAddUnit,
            this.StripMenuDbAddUnitType,
            this.StripMenuDbAddRace,
            this.StripMenuDbAddJob,
            this.StripMenuDbAddMaker,
            this.StripMenuDbAddWeapon,
            this.StripMenuDbAddShield,
            this.StripMenuDbAddHelmet,
            this.StripMenuDbAddGauntlet,
            this.StripMenuDbAddArmor,
            this.StripMenuDbAddAccessory,
            this.StripMenuDbAddSkill,
            this.StripMenuDbAddAbility});
			this.StripMenuDatabaseAdd.Name = "StripMenuDatabaseAdd";
			this.StripMenuDatabaseAdd.Size = new System.Drawing.Size(147, 22);
			this.StripMenuDatabaseAdd.Text = "新規登録(&N)";
			// 
			// StripMenuDbAddUnit
			// 
			this.StripMenuDbAddUnit.Name = "StripMenuDbAddUnit";
			this.StripMenuDbAddUnit.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddUnit.Text = "ユニット(&U)";
			this.StripMenuDbAddUnit.Click += new System.EventHandler(this.StripMenuDbAddUnit_Click);
			// 
			// StripMenuDbAddUnitType
			// 
			this.StripMenuDbAddUnitType.Name = "StripMenuDbAddUnitType";
			this.StripMenuDbAddUnitType.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddUnitType.Text = "ユニットタイプ(&E)";
			this.StripMenuDbAddUnitType.Click += new System.EventHandler(this.StripMenuDbAddUnitType_Click);
			// 
			// StripMenuDbAddRace
			// 
			this.StripMenuDbAddRace.Name = "StripMenuDbAddRace";
			this.StripMenuDbAddRace.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddRace.Text = "種族(&R)";
			this.StripMenuDbAddRace.Click += new System.EventHandler(this.StripMenuDbAddRace_Click);
			// 
			// StripMenuDbAddJob
			// 
			this.StripMenuDbAddJob.Name = "StripMenuDbAddJob";
			this.StripMenuDbAddJob.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddJob.Text = "ジョブ(&J)";
			this.StripMenuDbAddJob.Click += new System.EventHandler(this.StripMenuDbAddJob_Click);
			// 
			// StripMenuDbAddMaker
			// 
			this.StripMenuDbAddMaker.Name = "StripMenuDbAddMaker";
			this.StripMenuDbAddMaker.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddMaker.Text = "メーカー(&M)";
			this.StripMenuDbAddMaker.Click += new System.EventHandler(this.StripMenuDbAddMaker_Click);
			// 
			// StripMenuDbAddWeapon
			// 
			this.StripMenuDbAddWeapon.Name = "StripMenuDbAddWeapon";
			this.StripMenuDbAddWeapon.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddWeapon.Text = "武器(&W)";
			this.StripMenuDbAddWeapon.Click += new System.EventHandler(this.StripMenuDbAddWeapon_Click);
			// 
			// StripMenuDbAddShield
			// 
			this.StripMenuDbAddShield.Name = "StripMenuDbAddShield";
			this.StripMenuDbAddShield.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddShield.Text = "盾(&S)";
			this.StripMenuDbAddShield.Click += new System.EventHandler(this.StripMenuDbAddShield_Click);
			// 
			// StripMenuDbAddHelmet
			// 
			this.StripMenuDbAddHelmet.Name = "StripMenuDbAddHelmet";
			this.StripMenuDbAddHelmet.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddHelmet.Text = "頭防具(&H)";
			this.StripMenuDbAddHelmet.Click += new System.EventHandler(this.StripMenuDbAddHelmet_Click);
			// 
			// StripMenuDbAddGauntlet
			// 
			this.StripMenuDbAddGauntlet.Name = "StripMenuDbAddGauntlet";
			this.StripMenuDbAddGauntlet.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddGauntlet.Text = "腕防具(&G)";
			this.StripMenuDbAddGauntlet.Click += new System.EventHandler(this.StripMenuDbAddGauntlet_Click);
			// 
			// StripMenuDbAddArmor
			// 
			this.StripMenuDbAddArmor.Name = "StripMenuDbAddArmor";
			this.StripMenuDbAddArmor.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddArmor.Text = "体防具(&B)";
			this.StripMenuDbAddArmor.Click += new System.EventHandler(this.StripMenuDbAddArmor_Click);
			// 
			// StripMenuDbAddAccessory
			// 
			this.StripMenuDbAddAccessory.Name = "StripMenuDbAddAccessory";
			this.StripMenuDbAddAccessory.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddAccessory.Text = "アクセサリー(&A)";
			this.StripMenuDbAddAccessory.Click += new System.EventHandler(this.StripMenuDbAddAccessory_Click);
			// 
			// StripMenuDbAddSkill
			// 
			this.StripMenuDbAddSkill.Name = "StripMenuDbAddSkill";
			this.StripMenuDbAddSkill.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddSkill.Text = "スキル(&N)";
			this.StripMenuDbAddSkill.Click += new System.EventHandler(this.StripMenuDbAddSkill_Click);
			// 
			// StripMenuDbAddAbility
			// 
			this.StripMenuDbAddAbility.Name = "StripMenuDbAddAbility";
			this.StripMenuDbAddAbility.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbAddAbility.Text = "アビリティ(&P)";
			this.StripMenuDbAddAbility.Click += new System.EventHandler(this.StripMenuDbAddAbility_Click);
			// 
			// StripMenuDatabaseReload
			// 
			this.StripMenuDatabaseReload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuDbReloadAll,
            this.StripMenuDbReloadMenu,
            this.StripMenuDbReloadSeparator1,
            this.StripMenuDbReloadUnit,
            this.StripMenuDbReloadUnitType,
            this.StripMenuDbReloadRace,
            this.StripMenuDbReloadJob,
            this.StripMenuDbReloadMaker,
            this.StripMenuDbReloadWeapon,
            this.StripMenuDbReloadShield,
            this.StripMenuDbReloadHelmet,
            this.StripMenuDbReloadGauntlet,
            this.StripMenuDbReloadArmor,
            this.StripMenuDbReloadAccessory,
            this.StripMenuDbReloadSkill,
            this.StripMenuDbReloadAbility});
			this.StripMenuDatabaseReload.Name = "StripMenuDatabaseReload";
			this.StripMenuDatabaseReload.Size = new System.Drawing.Size(147, 22);
			this.StripMenuDatabaseReload.Text = "再読み込み(&R)";
			// 
			// StripMenuDbReloadAll
			// 
			this.StripMenuDbReloadAll.Name = "StripMenuDbReloadAll";
			this.StripMenuDbReloadAll.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadAll.Text = "全て(&A)";
			this.StripMenuDbReloadAll.Click += new System.EventHandler(this.StripMenuDbReloadAll_Click);
			// 
			// StripMenuDbReloadMenu
			// 
			this.StripMenuDbReloadMenu.Name = "StripMenuDbReloadMenu";
			this.StripMenuDbReloadMenu.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadMenu.Text = "メニュー項目のみ(&T)";
			this.StripMenuDbReloadMenu.Click += new System.EventHandler(this.StripMenuDbReloadMenu_Click);
			// 
			// StripMenuDbReloadSeparator1
			// 
			this.StripMenuDbReloadSeparator1.Name = "StripMenuDbReloadSeparator1";
			this.StripMenuDbReloadSeparator1.Size = new System.Drawing.Size(163, 6);
			// 
			// StripMenuDbReloadUnit
			// 
			this.StripMenuDbReloadUnit.Name = "StripMenuDbReloadUnit";
			this.StripMenuDbReloadUnit.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadUnit.Text = "ユニット(&U)";
			this.StripMenuDbReloadUnit.Click += new System.EventHandler(this.StripMenuDbReloadUnit_Click);
			// 
			// StripMenuDbReloadUnitType
			// 
			this.StripMenuDbReloadUnitType.Name = "StripMenuDbReloadUnitType";
			this.StripMenuDbReloadUnitType.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadUnitType.Text = "ユニットタイプ(&E)";
			this.StripMenuDbReloadUnitType.Click += new System.EventHandler(this.StripMenuDbReloadUnitType_Click);
			// 
			// StripMenuDbReloadRace
			// 
			this.StripMenuDbReloadRace.Name = "StripMenuDbReloadRace";
			this.StripMenuDbReloadRace.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadRace.Text = "種族(&R)";
			this.StripMenuDbReloadRace.Click += new System.EventHandler(this.StripMenuDbReloadRace_Click);
			// 
			// StripMenuDbReloadJob
			// 
			this.StripMenuDbReloadJob.Name = "StripMenuDbReloadJob";
			this.StripMenuDbReloadJob.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadJob.Text = "ジョブ(&J)";
			this.StripMenuDbReloadJob.Click += new System.EventHandler(this.StripMenuDbReloadJob_Click);
			// 
			// StripMenuDbReloadMaker
			// 
			this.StripMenuDbReloadMaker.Name = "StripMenuDbReloadMaker";
			this.StripMenuDbReloadMaker.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadMaker.Text = "メーカー(&M)";
			this.StripMenuDbReloadMaker.Click += new System.EventHandler(this.StripMenuDbReloadMaker_Click);
			// 
			// StripMenuDbReloadWeapon
			// 
			this.StripMenuDbReloadWeapon.Name = "StripMenuDbReloadWeapon";
			this.StripMenuDbReloadWeapon.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadWeapon.Text = "武器(&W)";
			this.StripMenuDbReloadWeapon.Click += new System.EventHandler(this.StripMenuDbReloadWeapon_Click);
			// 
			// StripMenuDbReloadShield
			// 
			this.StripMenuDbReloadShield.Name = "StripMenuDbReloadShield";
			this.StripMenuDbReloadShield.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadShield.Text = "盾(&S)";
			this.StripMenuDbReloadShield.Click += new System.EventHandler(this.StripMenuDbReloadShield_Click);
			// 
			// StripMenuDbReloadHelmet
			// 
			this.StripMenuDbReloadHelmet.Name = "StripMenuDbReloadHelmet";
			this.StripMenuDbReloadHelmet.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadHelmet.Text = "頭防具(&H)";
			this.StripMenuDbReloadHelmet.Click += new System.EventHandler(this.StripMenuDbReloadHelmet_Click);
			// 
			// StripMenuDbReloadGauntlet
			// 
			this.StripMenuDbReloadGauntlet.Name = "StripMenuDbReloadGauntlet";
			this.StripMenuDbReloadGauntlet.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadGauntlet.Text = "腕防具(&G)";
			this.StripMenuDbReloadGauntlet.Click += new System.EventHandler(this.StripMenuDbReloadGauntlet_Click);
			// 
			// StripMenuDbReloadArmor
			// 
			this.StripMenuDbReloadArmor.Name = "StripMenuDbReloadArmor";
			this.StripMenuDbReloadArmor.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadArmor.Text = "体防具(&B)";
			this.StripMenuDbReloadArmor.Click += new System.EventHandler(this.StripMenuDbReloadArmor_Click);
			// 
			// StripMenuDbReloadAccessory
			// 
			this.StripMenuDbReloadAccessory.Name = "StripMenuDbReloadAccessory";
			this.StripMenuDbReloadAccessory.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadAccessory.Text = "アクセサリー(&A)";
			this.StripMenuDbReloadAccessory.Click += new System.EventHandler(this.StripMenuDbReloadAccessory_Click);
			// 
			// StripMenuDbReloadSkill
			// 
			this.StripMenuDbReloadSkill.Name = "StripMenuDbReloadSkill";
			this.StripMenuDbReloadSkill.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadSkill.Text = "スキル(&N)";
			this.StripMenuDbReloadSkill.Click += new System.EventHandler(this.StripMenuDbReloadSkill_Click);
			// 
			// StripMenuDbReloadAbility
			// 
			this.StripMenuDbReloadAbility.Name = "StripMenuDbReloadAbility";
			this.StripMenuDbReloadAbility.Size = new System.Drawing.Size(166, 22);
			this.StripMenuDbReloadAbility.Text = "アビリティ(&P)";
			this.StripMenuDbReloadAbility.Click += new System.EventHandler(this.StripMenuDbReloadAbility_Click);
			// 
			// StripMenuDatabaseSave
			// 
			this.StripMenuDatabaseSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuDbSaveAll,
            this.StripMenuDbSaveSeparator1,
            this.StripMenuDbSaveUnit,
            this.StripMenuDbSaveUnitType,
            this.StripMenuDbSaveRace,
            this.StripMenuDbSaveJob,
            this.StripMenuDbSaveMaker,
            this.StripMenuDbSaveWeapon,
            this.StripMenuDbSaveShield,
            this.StripMenuDbSaveHelmet,
            this.StripMenuDbSaveGauntlet,
            this.StripMenuDbSaveArmor,
            this.StripMenuDbSaveAccessory,
            this.StripMenuDbSaveSkill,
            this.StripMenuDbSaveAbility});
			this.StripMenuDatabaseSave.Name = "StripMenuDatabaseSave";
			this.StripMenuDatabaseSave.Size = new System.Drawing.Size(147, 22);
			this.StripMenuDatabaseSave.Text = "変更を適用(&S)";
			// 
			// StripMenuDbSaveAll
			// 
			this.StripMenuDbSaveAll.Name = "StripMenuDbSaveAll";
			this.StripMenuDbSaveAll.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveAll.Text = "全て(&A)";
			this.StripMenuDbSaveAll.Click += new System.EventHandler(this.StripMenuDbSaveAll_Click);
			// 
			// StripMenuDbSaveSeparator1
			// 
			this.StripMenuDbSaveSeparator1.Name = "StripMenuDbSaveSeparator1";
			this.StripMenuDbSaveSeparator1.Size = new System.Drawing.Size(147, 6);
			// 
			// StripMenuDbSaveUnit
			// 
			this.StripMenuDbSaveUnit.Name = "StripMenuDbSaveUnit";
			this.StripMenuDbSaveUnit.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveUnit.Text = "ユニット(&U)";
			this.StripMenuDbSaveUnit.Click += new System.EventHandler(this.StripMenuDbSaveUnit_Click);
			// 
			// StripMenuDbSaveUnitType
			// 
			this.StripMenuDbSaveUnitType.Name = "StripMenuDbSaveUnitType";
			this.StripMenuDbSaveUnitType.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveUnitType.Text = "ユニットタイプ(&E)";
			this.StripMenuDbSaveUnitType.Click += new System.EventHandler(this.StripMenuDbSaveUnitType_Click);
			// 
			// StripMenuDbSaveRace
			// 
			this.StripMenuDbSaveRace.Name = "StripMenuDbSaveRace";
			this.StripMenuDbSaveRace.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveRace.Text = "種族(&R)";
			this.StripMenuDbSaveRace.Click += new System.EventHandler(this.StripMenuDbSaveRace_Click);
			// 
			// StripMenuDbSaveJob
			// 
			this.StripMenuDbSaveJob.Name = "StripMenuDbSaveJob";
			this.StripMenuDbSaveJob.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveJob.Text = "ジョブ(&J)";
			this.StripMenuDbSaveJob.Click += new System.EventHandler(this.StripMenuDbSaveJob_Click);
			// 
			// StripMenuDbSaveMaker
			// 
			this.StripMenuDbSaveMaker.Name = "StripMenuDbSaveMaker";
			this.StripMenuDbSaveMaker.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveMaker.Text = "メーカー(&M)";
			this.StripMenuDbSaveMaker.Click += new System.EventHandler(this.StripMenuDbSaveMaker_Click);
			// 
			// StripMenuDbSaveWeapon
			// 
			this.StripMenuDbSaveWeapon.Name = "StripMenuDbSaveWeapon";
			this.StripMenuDbSaveWeapon.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveWeapon.Text = "武器(&W)";
			this.StripMenuDbSaveWeapon.Click += new System.EventHandler(this.StripMenuDbSaveWeapon_Click);
			// 
			// StripMenuDbSaveShield
			// 
			this.StripMenuDbSaveShield.Name = "StripMenuDbSaveShield";
			this.StripMenuDbSaveShield.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveShield.Text = "盾(&S)";
			this.StripMenuDbSaveShield.Click += new System.EventHandler(this.StripMenuDbSaveShield_Click);
			// 
			// StripMenuDbSaveHelmet
			// 
			this.StripMenuDbSaveHelmet.Name = "StripMenuDbSaveHelmet";
			this.StripMenuDbSaveHelmet.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveHelmet.Text = "頭防具(&H)";
			this.StripMenuDbSaveHelmet.Click += new System.EventHandler(this.StripMenuDbSaveHelmet_Click);
			// 
			// StripMenuDbSaveGauntlet
			// 
			this.StripMenuDbSaveGauntlet.Name = "StripMenuDbSaveGauntlet";
			this.StripMenuDbSaveGauntlet.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveGauntlet.Text = "腕防具(&G)";
			this.StripMenuDbSaveGauntlet.Click += new System.EventHandler(this.StripMenuDbSaveGauntlet_Click);
			// 
			// StripMenuDbSaveArmor
			// 
			this.StripMenuDbSaveArmor.Name = "StripMenuDbSaveArmor";
			this.StripMenuDbSaveArmor.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveArmor.Text = "体防具(&B)";
			this.StripMenuDbSaveArmor.Click += new System.EventHandler(this.StripMenuDbSaveArmor_Click);
			// 
			// StripMenuDbSaveAccessory
			// 
			this.StripMenuDbSaveAccessory.Name = "StripMenuDbSaveAccessory";
			this.StripMenuDbSaveAccessory.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveAccessory.Text = "アクセサリー(&A)";
			this.StripMenuDbSaveAccessory.Click += new System.EventHandler(this.StripMenuDbSaveAccessory_Click);
			// 
			// StripMenuDbSaveSkill
			// 
			this.StripMenuDbSaveSkill.Name = "StripMenuDbSaveSkill";
			this.StripMenuDbSaveSkill.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveSkill.Text = "スキル(&N)";
			this.StripMenuDbSaveSkill.Click += new System.EventHandler(this.StripMenuDbSaveSkill_Click);
			// 
			// StripMenuDbSaveAbility
			// 
			this.StripMenuDbSaveAbility.Name = "StripMenuDbSaveAbility";
			this.StripMenuDbSaveAbility.Size = new System.Drawing.Size(150, 22);
			this.StripMenuDbSaveAbility.Text = "アビリティ(&P)";
			this.StripMenuDbSaveAbility.Click += new System.EventHandler(this.StripMenuDbSaveAbility_Click);
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
			this.StripMenuWindowView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuWindowViewUnit,
            this.StripMenuWindowViewUnitType,
            this.StripMenuWindowViewRace,
            this.StripMenuWindowViewJob,
            this.StripMenuWindowViewMaker,
            this.StripMenuWindowViewWeapon,
            this.StripMenuWindowViewShield,
            this.StripMenuWindowViewHelmet,
            this.StripMenuWindowViewGauntlet,
            this.StripMenuWindowViewArmor,
            this.StripMenuWindowViewAccessory,
            this.StripMenuWindowViewSkill,
            this.StripMenuWindowViewAbility,
            this.StripMenuWindowViewArea});
			this.StripMenuWindowView.Name = "StripMenuWindowView";
			this.StripMenuWindowView.Size = new System.Drawing.Size(157, 22);
			this.StripMenuWindowView.Text = "テーブルの表示(&T)";
			// 
			// StripMenuWindowViewUnit
			// 
			this.StripMenuWindowViewUnit.Name = "StripMenuWindowViewUnit";
			this.StripMenuWindowViewUnit.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewUnit.Text = "ユニット(&U)";
			this.StripMenuWindowViewUnit.Click += new System.EventHandler(this.StripMenuWindowViewUnit_Click);
			// 
			// StripMenuWindowViewUnitType
			// 
			this.StripMenuWindowViewUnitType.Name = "StripMenuWindowViewUnitType";
			this.StripMenuWindowViewUnitType.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewUnitType.Text = "ユニットタイプ(&E)";
			this.StripMenuWindowViewUnitType.Click += new System.EventHandler(this.StripMenuWindowViewUnitType_Click);
			// 
			// StripMenuWindowViewRace
			// 
			this.StripMenuWindowViewRace.Name = "StripMenuWindowViewRace";
			this.StripMenuWindowViewRace.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewRace.Text = "種族(&R)";
			this.StripMenuWindowViewRace.Click += new System.EventHandler(this.StripMenuWindowViewRace_Click);
			// 
			// StripMenuWindowViewJob
			// 
			this.StripMenuWindowViewJob.Name = "StripMenuWindowViewJob";
			this.StripMenuWindowViewJob.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewJob.Text = "ジョブ(&J)";
			this.StripMenuWindowViewJob.Click += new System.EventHandler(this.StripMenuWindowViewJob_Click);
			// 
			// StripMenuWindowViewMaker
			// 
			this.StripMenuWindowViewMaker.Name = "StripMenuWindowViewMaker";
			this.StripMenuWindowViewMaker.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewMaker.Text = "メーカー(&M)";
			this.StripMenuWindowViewMaker.Click += new System.EventHandler(this.StripMenuWindowViewMaker_Click);
			// 
			// StripMenuWindowViewWeapon
			// 
			this.StripMenuWindowViewWeapon.Name = "StripMenuWindowViewWeapon";
			this.StripMenuWindowViewWeapon.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewWeapon.Text = "武器(&W)";
			this.StripMenuWindowViewWeapon.Click += new System.EventHandler(this.StripMenuWindowViewWeapon_Click);
			// 
			// StripMenuWindowViewShield
			// 
			this.StripMenuWindowViewShield.Name = "StripMenuWindowViewShield";
			this.StripMenuWindowViewShield.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewShield.Text = "盾(&S)";
			this.StripMenuWindowViewShield.Click += new System.EventHandler(this.StripMenuWindowViewShield_Click);
			// 
			// StripMenuWindowViewHelmet
			// 
			this.StripMenuWindowViewHelmet.Name = "StripMenuWindowViewHelmet";
			this.StripMenuWindowViewHelmet.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewHelmet.Text = "頭防具(&H)";
			this.StripMenuWindowViewHelmet.Click += new System.EventHandler(this.StripMenuWindowViewHelmet_Click);
			// 
			// StripMenuWindowViewGauntlet
			// 
			this.StripMenuWindowViewGauntlet.Name = "StripMenuWindowViewGauntlet";
			this.StripMenuWindowViewGauntlet.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewGauntlet.Text = "腕防具(&G)";
			this.StripMenuWindowViewGauntlet.Click += new System.EventHandler(this.StripMenuWindowViewGauntlet_Click);
			// 
			// StripMenuWindowViewArmor
			// 
			this.StripMenuWindowViewArmor.Name = "StripMenuWindowViewArmor";
			this.StripMenuWindowViewArmor.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewArmor.Text = "体防具(&B)";
			this.StripMenuWindowViewArmor.Click += new System.EventHandler(this.StripMenuWindowViewArmor_Click);
			// 
			// StripMenuWindowViewAccessory
			// 
			this.StripMenuWindowViewAccessory.Name = "StripMenuWindowViewAccessory";
			this.StripMenuWindowViewAccessory.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewAccessory.Text = "アクセサリー(&A)";
			this.StripMenuWindowViewAccessory.Click += new System.EventHandler(this.StripMenuWindowViewAccessory_Click);
			// 
			// StripMenuWindowViewSkill
			// 
			this.StripMenuWindowViewSkill.Name = "StripMenuWindowViewSkill";
			this.StripMenuWindowViewSkill.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewSkill.Text = "スキル(&N)";
			this.StripMenuWindowViewSkill.Click += new System.EventHandler(this.StripMenuWindowViewSkill_Click);
			// 
			// StripMenuWindowViewAbility
			// 
			this.StripMenuWindowViewAbility.Name = "StripMenuWindowViewAbility";
			this.StripMenuWindowViewAbility.Size = new System.Drawing.Size(152, 22);
			this.StripMenuWindowViewAbility.Text = "アビリティ(&P)";
			this.StripMenuWindowViewAbility.Click += new System.EventHandler(this.StripMenuWindowViewAbility_Click);
			// 
			// StripMenuHelp
			// 
			this.StripMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuHelpHelp,
            this.StripMenuHelpDevelop,
            this.StripMenuHelpSeparator1,
            this.StripMenuHelpVersion});
			this.StripMenuHelp.Name = "StripMenuHelp";
			this.StripMenuHelp.Size = new System.Drawing.Size(65, 20);
			this.StripMenuHelp.Text = "ヘルプ(&H)";
			// 
			// StripMenuHelpHelp
			// 
			this.StripMenuHelpHelp.Name = "StripMenuHelpHelp";
			this.StripMenuHelpHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.StripMenuHelpHelp.Size = new System.Drawing.Size(183, 22);
			this.StripMenuHelpHelp.Text = "ヘルプの表示(&V)";
			this.StripMenuHelpHelp.Click += new System.EventHandler(this.StripMenuHelpHelp_Click);
			// 
			// StripMenuHelpDevelop
			// 
			this.StripMenuHelpDevelop.Name = "StripMenuHelpDevelop";
			this.StripMenuHelpDevelop.Size = new System.Drawing.Size(183, 22);
			this.StripMenuHelpDevelop.Text = "Githubのページへ";
			this.StripMenuHelpDevelop.Click += new System.EventHandler(this.StripMenuHelpDevelop_Click);
			// 
			// StripMenuHelpSeparator1
			// 
			this.StripMenuHelpSeparator1.Name = "StripMenuHelpSeparator1";
			this.StripMenuHelpSeparator1.Size = new System.Drawing.Size(180, 6);
			// 
			// StripMenuHelpVersion
			// 
			this.StripMenuHelpVersion.Name = "StripMenuHelpVersion";
			this.StripMenuHelpVersion.ShortcutKeys = System.Windows.Forms.Keys.F12;
			this.StripMenuHelpVersion.Size = new System.Drawing.Size(183, 22);
			this.StripMenuHelpVersion.Text = "バージョン情報(&A)";
			this.StripMenuHelpVersion.Click += new System.EventHandler(this.StripMenuHelpVersion_Click);
			// 
			// GigaBattlerDataSet
			// 
			this.GigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.GigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// StripMenuWindowViewArea
			// 
			this.StripMenuWindowViewArea.Name = "StripMenuWindowViewArea";
			this.StripMenuWindowViewArea.Size = new System.Drawing.Size(166, 22);
			this.StripMenuWindowViewArea.Text = "都市名･地域名(&T)";
			this.StripMenuWindowViewArea.Click += new System.EventHandler(this.StripMenuWindowViewArea_Click);
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditerMainMenu_FormClosing);
			this.Load += new System.EventHandler(this.EditerMainMenu_Load);
			this.ContextListMenu.ResumeLayout(false);
			this.ToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer.BottomToolStripPanel.PerformLayout();
			this.ToolStripContainer.ContentPanel.ResumeLayout(false);
			this.ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer.TopToolStripPanel.PerformLayout();
			this.ToolStripContainer.ResumeLayout(false);
			this.ToolStripContainer.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabControlUnit.ResumeLayout(false);
			this.tabPage21.ResumeLayout(false);
			this.tabPage22.ResumeLayout(false);
			this.tabPage23.ResumeLayout(false);
			this.tabPage24.ResumeLayout(false);
			this.tabPage25.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage9.ResumeLayout(false);
			this.tabPage10.ResumeLayout(false);
			this.tabPage11.ResumeLayout(false);
			this.tabPage12.ResumeLayout(false);
			this.tabPage13.ResumeLayout(false);
			this.tabPage14.ResumeLayout(false);
			this.tabPage15.ResumeLayout(false);
			this.tabPage16.ResumeLayout(false);
			this.tabPage17.ResumeLayout(false);
			this.StripMainMenu.ResumeLayout(false);
			this.StripMainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GigaBattlerDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolStripContainer ToolStripContainer;
		private TabControl tabControl;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private TabPage tabPage5;
		private TabPage tabPage6;
		private TabPage tabPage7;
		private TabPage tabPage8;
		private TabPage tabPage9;
		private TabPage tabPage10;
		private TabPage tabPage11;
		private TabPage tabPage12;
		private TabPage tabPage13;
		private TabPage tabPage14;
		private TabPage tabPage15;
		private TabPage tabPage16;
		private TabPage tabPage17;
		private TabPage tabPage18;
		private TabPage tabPage19;
		private TabPage tabPage20;
		private ListBox listUnit;
		private ToolTip toolTipInfo;
		private StatusStrip StatusStrip;
		private ToolStripStatusLabel StripInfo;
		private NotifyIcon notifyIcon;
		private ToolStripProgressBar toolStripProgressBar1;
		private GigaBattlerDataSet GigaBattlerDataSet;
		private ListBox listUnitType;
		private TabControl tabControlUnit;
		private TabPage tabPage21;
		private TabPage tabPage22;
		private TabPage tabPage23;
		private TabPage tabPage24;
		private TabPage tabPage25;
		private User_Control.tab03Unit.TotalUnitInfomation TotalUnitInfomation;
		private User_Control.tab03Unit.UnitInfomation UnitInfomation;
		private User_Control.tab03Unit.DropInfomation DropInfomation;
		private User_Control.tab03Unit.StatusInfomation StatusInfomation;
		private User_Control.tab03Unit.SkillInfomation ActiveSkillInfomation;
		private User_Control.tab03Unit.AbilityInfomation PassiveSkillInfomation;
		private ListBox listRace;
		private User_Control.tab05Race.RaceInfomation RaceInfomation;
		private ListBox listJob;
		private User_Control.tab06Job.JobInfomation JobInfomation;
		private ListBox listMaker;
		private ListBox listWeapon;
		private User_Control.CommonParts.ItemInfoParts ItemInfoWeapon;
		private User_Control.CommonParts.EquipItemStatusParts EquipItemWeapon;
		private User_Control.CommonParts.ItemAbilityInfoParts ItemAbilityInfoWeapon;
		private ListBox listShield;
		private User_Control.CommonParts.ItemInfoParts ItemInfoShield;
		private User_Control.CommonParts.EquipItemStatusParts EquipItemShield;
		private User_Control.CommonParts.ItemAbilityInfoParts ItemAbilityInfoShield;
		private ListBox listHelmet;
		private User_Control.CommonParts.ItemInfoParts ItemInfoHelmet;
		private User_Control.CommonParts.EquipItemStatusParts EquipItemHelmet;
		private User_Control.CommonParts.ItemAbilityInfoParts ItemAbilityInfoHelmet;
		private ListBox listGauntlet;
		private User_Control.CommonParts.ItemInfoParts ItemInfoGauntlet;
		private User_Control.CommonParts.EquipItemStatusParts EquipItemGauntlet;
		private User_Control.CommonParts.ItemAbilityInfoParts ItemAbilityInfoGauntlet;
		private ListBox listArmor;
		private User_Control.CommonParts.ItemInfoParts ItemInfoArmor;
		private User_Control.CommonParts.EquipItemStatusParts EquipItemArmor;
		private User_Control.CommonParts.ItemAbilityInfoParts ItemAbilityInfoArmor;
		private ListBox listAccessory;
		private User_Control.CommonParts.ItemInfoParts ItemInfoAccessory;
		private User_Control.CommonParts.EquipItemStatusParts EquipItemAccessory;
		private User_Control.CommonParts.ItemAbilityInfoParts ItemAbilityInfoAccessory;
		private MenuStrip StripMainMenu;
		private ToolStripMenuItem StripMenuFile;
		private ToolStripMenuItem StripMenuFileImport;
		private ToolStripSeparator StripMenuFileSeparator1;
		private ToolStripMenuItem StripMenuExit;
		private ToolStripMenuItem StripMenuEdit;
		private ToolStripMenuItem StripMenuViwer;
		private ToolStripMenuItem StripMenuDatabase;
		private ToolStripMenuItem StripMenuWindow;
		private ToolStripMenuItem StripMenuWindowView;
		private ToolStripMenuItem StripMenuHelp;
		private ToolStripMenuItem StripMenuHelpHelp;
		private ToolStripSeparator StripMenuHelpSeparator1;
		private ToolStripMenuItem StripMenuHelpVersion;
		private ToolStripMenuItem StripMenuDatabaseReload;
		private ToolStripMenuItem StripMenuDbReloadAll;
		private ToolStripMenuItem StripMenuDbReloadMenu;
		private ToolStripSeparator StripMenuDbReloadSeparator1;
		private ToolStripMenuItem StripMenuDbReloadUnit;
		private ToolStripMenuItem StripMenuDbReloadUnitType;
		private ToolStripMenuItem StripMenuDbReloadRace;
		private ToolStripMenuItem StripMenuDbReloadJob;
		private ToolStripMenuItem StripMenuDbReloadMaker;
		private ToolStripMenuItem StripMenuDbReloadWeapon;
		private ToolStripMenuItem StripMenuDbReloadShield;
		private ToolStripMenuItem StripMenuDbReloadHelmet;
		private ToolStripMenuItem StripMenuDbReloadGauntlet;
		private ToolStripMenuItem StripMenuDbReloadArmor;
		private ToolStripMenuItem StripMenuDbReloadAccessory;
		private ToolStripMenuItem StripMenuDbReloadSkill;
		private ToolStripMenuItem StripMenuDbReloadAbility;
		private ToolStripMenuItem StripMenuDatabaseSave;
		private ToolStripMenuItem StripMenuDbSaveAll;
		private ToolStripSeparator StripMenuDbSaveSeparator1;
		private ToolStripMenuItem StripMenuDbSaveUnit;
		private ToolStripMenuItem StripMenuDbSaveUnitType;
		private ToolStripMenuItem StripMenuDbSaveRace;
		private ToolStripMenuItem StripMenuDbSaveJob;
		private ToolStripMenuItem StripMenuDbSaveMaker;
		private ToolStripMenuItem StripMenuDbSaveWeapon;
		private ToolStripMenuItem StripMenuDbSaveShield;
		private ToolStripMenuItem StripMenuDbSaveHelmet;
		private ToolStripMenuItem StripMenuDbSaveGauntlet;
		private ToolStripMenuItem StripMenuDbSaveArmor;
		private ToolStripMenuItem StripMenuDbSaveAccessory;
		private ToolStripMenuItem StripMenuDbSaveSkill;
		private ToolStripMenuItem StripMenuDbSaveAbility;
		private ToolStripMenuItem StripMenuViwerStatusBar;
		private ToolStripMenuItem StripMenuDatabaseAdd;
		private ToolStripMenuItem StripMenuDbAddUnit;
		private ToolStripMenuItem StripMenuDbAddUnitType;
		private ToolStripMenuItem StripMenuDbAddRace;
		private ToolStripMenuItem StripMenuDbAddJob;
		private ToolStripMenuItem StripMenuDbAddMaker;
		private ToolStripMenuItem StripMenuDbAddWeapon;
		private ToolStripMenuItem StripMenuDbAddShield;
		private ToolStripMenuItem StripMenuDbAddHelmet;
		private ToolStripMenuItem StripMenuDbAddGauntlet;
		private ToolStripMenuItem StripMenuDbAddArmor;
		private ToolStripMenuItem StripMenuDbAddAccessory;
		private ToolStripMenuItem StripMenuDbAddSkill;
		private ToolStripMenuItem StripMenuDbAddAbility;
		private ToolStripMenuItem StripMenuWindowViewUnit;
		private ToolStripMenuItem StripMenuWindowViewUnitType;
		private ToolStripMenuItem StripMenuWindowViewRace;
		private ToolStripMenuItem StripMenuWindowViewJob;
		private ToolStripMenuItem StripMenuWindowViewMaker;
		private ToolStripMenuItem StripMenuWindowViewWeapon;
		private ToolStripMenuItem StripMenuWindowViewShield;
		private ToolStripMenuItem StripMenuWindowViewHelmet;
		private ToolStripMenuItem StripMenuWindowViewGauntlet;
		private ToolStripMenuItem StripMenuWindowViewArmor;
		private ToolStripMenuItem StripMenuWindowViewAccessory;
		private ToolStripMenuItem StripMenuWindowViewSkill;
		private ToolStripMenuItem StripMenuWindowViewAbility;
		private ContextMenuStrip ContextListMenu;
		private ToolStripMenuItem StripMenuContextDuplicate;
		private ToolStripMenuItem StripMenuContextDelete;
		private ToolStripMenuItem StripMenuHelpDevelop;
		private ToolStripMenuItem StripMenuFileExport;
		private ToolStripMenuItem StripMenuEditUndo;
		private ToolStripMenuItem StripMenuEditRedo;
		private ToolStripSeparator StripMenuEditSeparator1;
		private ToolStripMenuItem StripMenuEditSearch;
		private ListBox listSkill;
		private ListBox listAbility;
		private User_Control.tab14Skill.SkillStatusInfomation SkillStatusInfomation;
		private User_Control.tab14Skill.SkillInfomation SkillInfomation;
		private ListBox listArea;
		private ListBox listBattleField;
		private User_Control.tab14Skill.SkillElementInfomation skillElementInfomation1;
		private ToolStripMenuItem StripMenuWindowViewArea;
	}
}
