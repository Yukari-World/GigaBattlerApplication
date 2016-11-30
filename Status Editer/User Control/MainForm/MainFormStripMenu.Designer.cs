using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.MainForm {
	partial class MainFormStripMenu {
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
			this.StripMainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// StripMainMenu
			// 
			this.StripMainMenu.BackColor = System.Drawing.Color.Transparent;
			this.StripMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFile,
            this.StripMenuEdit,
            this.StripMenuViwer,
            this.StripMenuDatabase,
            this.StripMenuWindow,
            this.StripMenuHelp});
			this.StripMainMenu.Location = new System.Drawing.Point(0, 0);
			this.StripMainMenu.Name = "StripMainMenu";
			this.StripMainMenu.Size = new System.Drawing.Size(1000, 24);
			this.StripMainMenu.TabIndex = 1;
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
			// 
			// StripMenuDatabaseSave
			// 
			this.StripMenuDatabaseSave.Name = "StripMenuDatabaseSave";
			this.StripMenuDatabaseSave.Size = new System.Drawing.Size(147, 22);
			this.StripMenuDatabaseSave.Text = "変更を適用(&S)";
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
			// MainFormStripMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.StripMainMenu);
			this.Name = "MainFormStripMenu";
			this.Size = new System.Drawing.Size(1000, 24);
			this.StripMainMenu.ResumeLayout(false);
			this.StripMainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip StripMainMenu;
		private ToolStripMenuItem StripMenuFile;
		private ToolStripMenuItem StripMenuFileOpen;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem StripMenuExit;
		private ToolStripMenuItem StripMenuEdit;
		private ToolStripMenuItem StripMenuViwer;
		private ToolStripMenuItem StripMenuDatabase;
		private ToolStripMenuItem StripMenuDatabaseReload;
		private ToolStripMenuItem StripMenuDatabaseSave;
		private ToolStripMenuItem StripMenuWindow;
		private ToolStripMenuItem StripMenuWindowView;
		private ToolStripMenuItem StripMenuHelp;
		private ToolStripMenuItem StripMenuHelpHelp;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem StripMenuHelpVersion;
	}
}
