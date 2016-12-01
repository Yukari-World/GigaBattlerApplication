//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Editer Main Menu
//
// エディタのメインフォーム。
// ソースコードが長く成り気味なのでregionを利用すること。
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Status_Editer.GigaBattlerDataSet;

namespace Status_Editer {
	public partial class EditerMainMenu : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// 変数
		private bool isExit = false;
		private int[] RowCount = new int[12];
		/// <summary>
		/// DataTableを使用しているUserControlの数
		/// </summary>
		private readonly int ControlCount = 8;

		/// <summary>
		/// データベースのテーブルの数
		/// </summary>
		private readonly int TableCount = 12;

		public string rootDirectory = "";

		// TableAdapter
		__table_elementTableAdapter tableElementTableAdapter = new __table_elementTableAdapter();
		__table_weapon_typeTableAdapter tableWeaponTypeTableAdapter = new __table_weapon_typeTableAdapter();
		__table_unitTableAdapter tableUnitTableAdapter = new __table_unitTableAdapter();
		__table_raceTableAdapter tableRaceTableAdapter = new __table_raceTableAdapter();
		__table_jobTableAdapter tableJobTableAdapter = new __table_jobTableAdapter();
		__table_weaponTableAdapter tableWeaponTableAdapter = new __table_weaponTableAdapter();
		__table_shieldTableAdapter tableShieldTableAdapter = new __table_shieldTableAdapter();
		__table_helmetTableAdapter tableHelmetTableAdapter = new __table_helmetTableAdapter();
		__table_gauntletTableAdapter tableGauntletTableAdapter = new __table_gauntletTableAdapter();
		__table_armorTableAdapter tableArmorTableAdapter = new __table_armorTableAdapter();
		__table_accessoryTableAdapter tableAccessoryTableAdapter = new __table_accessoryTableAdapter();
		__table_skillTableAdapter tableSkillTableAdapter = new __table_skillTableAdapter();

		// BindingSource
		__table_elementDataTable TableElementDataTable = new __table_elementDataTable();
		__table_weapon_typeDataTable TableWeaponTypeDataTable = new __table_weapon_typeDataTable();
		__table_unitDataTable TableUnitDataTable = new __table_unitDataTable();
		__table_raceDataTable TableRaceDataTable = new __table_raceDataTable();
		__table_jobDataTable TableJobDataTable = new __table_jobDataTable();
		__table_weaponDataTable TableWeaponDataTable = new __table_weaponDataTable();
		__table_shieldDataTable TableShieldDataTable = new __table_shieldDataTable();
		__table_helmetDataTable TableHelmetDataTable = new __table_helmetDataTable();
		__table_gauntletDataTable TableGauntletDataTable = new __table_gauntletDataTable();
		__table_armorDataTable TableArmorDataTable = new __table_armorDataTable();
		__table_accessoryDataTable TableAccessoryDataTable = new __table_accessoryDataTable();
		__table_skillDataTable TableSkillDataTable = new __table_skillDataTable();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public EditerMainMenu() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// 各コントロールの選択項目を再読み込みします
		/// </summary>
		private void ReloadControl() {
			// TAB: ユニット
			DropInfomation.ReloadDataTable(tableWeaponTableAdapter, tableShieldTableAdapter, tableHelmetTableAdapter, tableGauntletTableAdapter, tableArmorTableAdapter, tableAccessoryTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント
			ActiveSkillInfomation.ReloadBindings(tableSkillTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 武器

			ItemInfoWeapon.ReloadDataTable(tableElementTableAdapter, tableWeaponTypeTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 盾

			ItemInfoShield.ReloadDataTable(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 頭防具

			ItemInfoHelmet.ReloadDataTable(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 腕防具

			ItemInfoGauntlet.ReloadDataTable(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 体防具

			ItemInfoArmor.ReloadDataTable(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: アクセサリー

			ItemInfoAccessory.ReloadDataTable(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント
		}

		/// <summary>
		/// 変更した更新内容を適用します。
		/// </summary>
		private void UpdateSQL() {
			int sum = 0;    // 更新件数計算用
							// ステータスバーの更新
			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Maximum = TableCount + 1;
			StripInfo.Text = "Updating Database...";

			// 編集終了宣言
			Validate();

			toolStripProgressBar1.PerformStep();

			try {
				// 更新処理
				sum += RowCount[0] = tableElementTableAdapter.Update(TableElementDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[1] = tableWeaponTypeTableAdapter.Update(TableWeaponTypeDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[2] = tableUnitTableAdapter.Update(TableUnitDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[3] = tableRaceTableAdapter.Update(TableRaceDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[4] = tableJobTableAdapter.Update(TableJobDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[5] = tableWeaponTableAdapter.Update(TableWeaponDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[6] = tableShieldTableAdapter.Update(TableShieldDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[7] = tableHelmetTableAdapter.Update(TableHelmetDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[8] = tableGauntletTableAdapter.Update(TableGauntletDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[9] = tableArmorTableAdapter.Update(TableArmorDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[10] = tableAccessoryTableAdapter.Update(TableAccessoryDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[11] = tableSkillTableAdapter.Update(TableSkillDataTable);
				toolStripProgressBar1.PerformStep();    // カウント

				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		#region フォーム読み込み時の処理

		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void EditerMainMenu_Load(object sender, EventArgs e) {
			//----------------------------------------------------------------------------------------------------
			// 初期化
			// タスク化しているけど無意味?

			var Task1 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 1 Start.");

				tableElementTableAdapter.ClearBeforeFill = true;
				tableWeaponTypeTableAdapter.ClearBeforeFill = true;
				tableUnitTableAdapter.ClearBeforeFill = true;
				tableRaceTableAdapter.ClearBeforeFill = true;
				tableJobTableAdapter.ClearBeforeFill = true;
				tableWeaponTableAdapter.ClearBeforeFill = true;
				tableShieldTableAdapter.ClearBeforeFill = true;
				tableHelmetTableAdapter.ClearBeforeFill = true;
				tableGauntletTableAdapter.ClearBeforeFill = true;
				tableArmorTableAdapter.ClearBeforeFill = true;
				tableAccessoryTableAdapter.ClearBeforeFill = true;
				tableSkillTableAdapter.ClearBeforeFill = true;

				Debug.WriteLine("Task 1 Finish.");
			});

			//----------------------------------------------------------------------------------------------------
			// バインド項目の関連付け

			var Task2 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 2 Start.");
				// 現在空
				Debug.WriteLine("Task 2 Finish.");
			});

			//----------------------------------------------------------------------------------------------------
			// デザイナープロパティの設定
			// 出来ればデザイナープロパティに設定したいが、バグ(仕様?:Anchorの設定によってはフォームデザイナが勝手に書き換えられる)の関係でここで設定。

			var Task3 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3 Start.");

				// TAB: ユニット
				listUnit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				tabControlUnit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

				// TAB: 種族

				listRace.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				// TAB: ジョブ

				listJob.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				// TAB: メーカー

				listMaker.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				// TAB: 武器

				listWeapon.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				// TAB: 盾

				listShield.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				// TAB: 頭防具

				listHelmet.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				// TAB: 腕防具

				listGauntlet.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				// TAB: 体防具

				listArmor.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				// TAB: アクセサリー

				listAccessory.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

				Debug.WriteLine("Task 3 Finish.");
			});

			//----------------------------------------------------------------------------------------------------
			// バインド項目の設定

			var Task4 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 4 Standby.");
				// Task2の完了を待つ
				Task2.Wait();
				Debug.WriteLine("Task 4 Start.");

				listUnit.DataSource = TableUnitDataTable;
				listUnit.DisplayMember = "UnitName";
				listUnit.ValueMember = "UnitID";

				listRace.DataSource = TableRaceDataTable;
				listRace.DisplayMember = "RaceName";
				listRace.ValueMember = "RaceID";

				listJob.DataSource = TableJobDataTable;
				listJob.DisplayMember = "JobName";
				listJob.ValueMember = "JobID";

				listWeapon.DataSource = TableWeaponDataTable;
				listWeapon.DisplayMember = "WeaponName";
				listWeapon.ValueMember = "WeaponID";

				listShield.DataSource = TableShieldDataTable;
				listShield.DisplayMember = "ShieldName";
				listShield.ValueMember = "ShieldID";

				listHelmet.DataSource = TableHelmetDataTable;
				listHelmet.DisplayMember = "HelmetName";
				listHelmet.ValueMember = "HelmetID";

				listGauntlet.DataSource = TableGauntletDataTable;
				listGauntlet.DisplayMember = "GauntletName";
				listGauntlet.ValueMember = "GauntletID";

				listArmor.DataSource = TableArmorDataTable;
				listArmor.DisplayMember = "ArmorName";
				listArmor.ValueMember = "ArmorID";

				listAccessory.DataSource = TableAccessoryDataTable;
				listAccessory.DisplayMember = "AccessoryName";
				listAccessory.ValueMember = "AccessoryID";

				Debug.WriteLine("Task 4 Finish.");
			});

			//----------------------------------------------------------------------------------------------------
			// 別コントロールへのバインディング設定
			// TAB: ユニット

			var Task5_3 = Task.Factory.StartNew((Action)(() => {
				Debug.WriteLine("Task 5-3 Start.");

				TotalUnitInfomation.SetDataBindings(TableUnitDataTable);
				UnitInfomation.SetDataBindings(TableUnitDataTable);
				DropInfomation.SetDataBindings(TableUnitDataTable);
				StatusInfomation.SetDataBindings(TableUnitDataTable);
				ActiveSkillInfomation.SetDataBindings(TableUnitDataTable);

				Debug.WriteLine("Task 5-3 Finish.");
			}));

			// TAB: ユニットタイプ

			// NULL

			// TAB: 種族

			var Task5_5 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-5 Start.");

				RaceInfomation.SetDataBindings(TableRaceDataTable);

				Debug.WriteLine("Task 5-5 Finish.");
			});

			// TAB: ジョブ

			var Task5_6 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-6 Start.");
				JobInfomation.LoadDataBindings(TableJobDataTable);

				Debug.WriteLine("Task 5-6 Finish.");
			});

			// TAB: メーカー

			// NULL

			// TAB: 武器

			var Task5_8 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-8 Start.");

				ItemInfoWeapon.SetDataBindings(TableWeaponDataTable);
				EquipItemWeapon.SetDataBindings(TableWeaponDataTable);

				Debug.WriteLine("Task 5-8 Finish.");
			});

			// TAB: 盾

			var Task5_9 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-9 Start.");

				ItemInfoShield.SetDataBindings(TableShieldDataTable, "Shield");
				EquipItemShield.SetDataBindings(TableShieldDataTable);

				Debug.WriteLine("Task 5-9 Finish.");
			});

			// TAB: 頭防具

			var Task5_10 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-10 Start.");

				ItemInfoHelmet.SetDataBindings(TableHelmetDataTable, "Helmet");
				EquipItemHelmet.SetDataBindings(TableHelmetDataTable);

				Debug.WriteLine("Task 5-10 Finish.");
			});

			// TAB: 腕防具

			var Task5_11 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-11 Start.");

				ItemInfoGauntlet.SetDataBindings(TableGauntletDataTable, "Gauntlet");
				EquipItemGauntlet.SetDataBindings(TableGauntletDataTable);

				Debug.WriteLine("Task 5-11 Finish.");
			});

			// TAB: 体防具

			var Task5_12 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-12 Start.");

				ItemInfoArmor.SetDataBindings(TableArmorDataTable, "Armor");
				EquipItemArmor.SetDataBindings(TableArmorDataTable);

				Debug.WriteLine("Task 5-12 Finish.");
			});

			// TAB: アクセサリー

			var Task5_13 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-13 Start.");

				ItemInfoAccessory.SetDataBindings(TableAccessoryDataTable, "Accessory");
				EquipItemAccessory.SetDataBindings(TableAccessoryDataTable);

				Debug.WriteLine("Task 5-13 Finish.");
			});

			// 待機～～
			Task5_3.Wait();
			Task5_5.Wait();
			Task5_6.Wait();
			Task5_8.Wait();
			Task5_9.Wait();
			Task5_10.Wait();
			Task5_11.Wait();
			Task5_12.Wait();
			Task5_13.Wait();

			//----------------------------------------------------------------------------------------------------
			// 共通
			// データの埋め込み
			// ネットワーク関連を使用するのでtryを使用
			try {
				RowCount[0] = tableElementTableAdapter.Fill(TableElementDataTable);
				RowCount[1] = tableWeaponTypeTableAdapter.Fill(TableWeaponTypeDataTable);
				RowCount[2] = tableUnitTableAdapter.Fill(TableUnitDataTable);
				RowCount[3] = tableRaceTableAdapter.Fill(TableRaceDataTable);
				RowCount[4] = tableJobTableAdapter.Fill(TableJobDataTable);
				RowCount[5] = tableWeaponTableAdapter.FillSortByType(TableWeaponDataTable);
				RowCount[6] = tableShieldTableAdapter.Fill(TableShieldDataTable);
				RowCount[7] = tableHelmetTableAdapter.Fill(TableHelmetDataTable);
				RowCount[8] = tableGauntletTableAdapter.Fill(TableGauntletDataTable);
				RowCount[9] = tableArmorTableAdapter.Fill(TableArmorDataTable);
				RowCount[10] = tableAccessoryTableAdapter.Fill(TableAccessoryDataTable);
				RowCount[11] = tableSkillTableAdapter.Fill(TableSkillDataTable);

				// コントロール側の処理はメソッドに移動
				ReloadControl();
				toolStripProgressBar1.Value = 0;    // 値をリセット
			} catch (Exception ex) {
				Debug.WriteLine("System Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("System Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// 続行不可能なので終了させる
				Close();
				Dispose();
				Application.Exit();
			}// End Try

			// 破棄破棄
			Task1.Dispose();
			Task2.Dispose();
			Task3.Dispose();
			Task4.Dispose();
			Task5_3.Dispose();
			Task5_5.Dispose();
			Task5_6.Dispose();
			Task5_8.Dispose();
			Task5_9.Dispose();
			Task5_10.Dispose();
			Task5_11.Dispose();
			Task5_12.Dispose();
			Task5_13.Dispose();

			// タイトルにバージョン番号を付与
			Text += " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
			StripInfo.Text = "Welcome!!";
		}// End Method

		#endregion

		/// <summary>
		/// フォームを閉じる直前の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void EditerMainMenu_FormClosing(object sender, FormClosingEventArgs e) {
			DialogResult result = MessageBox.Show("終了時にデータベースをアップデートしますか?", "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
			switch (result) {
				case DialogResult.Yes:
					try {
						UpdateSQL();
					} catch (Exception ex) {
						Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
						e.Cancel = true;
					} finally {

					}
					break;
				case DialogResult.No:
					break;
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
			}// End Switch
		}// End Method

		//----------------------------------------------------------------------------------------------------
		// Strip Menu 項目

		#region ファイル

		/// <summary>
		/// 「ファイル」→「開く」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		/// <remarks>
		/// 以下のページより参照
		/// http://dobon.net/vb/dotnet/form/folderdialog.html
		/// </remarks>
		private void StripMenuFileOpen_Click(object sender, EventArgs e) {
			// FolderBrowserDialogクラスのインスタンスを作成
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			// 上部に表示する説明テキストを指定する
			fbd.Description = "Databaseフォルダを指定してください。";

			// ルートフォルダを指定する
			// デフォルトでDesktop
			fbd.RootFolder = Environment.SpecialFolder.Desktop;

			// 最初に選択するフォルダを指定する
			// RootFolder以下にあるフォルダである必要がある
			fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

			// ユーザーが新しいフォルダを作成できるようにする
			// デフォルトでTrue
			fbd.ShowNewFolderButton = false;

			// ダイアログを表示する
			if (fbd.ShowDialog(this) == DialogResult.OK) {
				// 選択されたフォルダを表示する
				rootDirectory = fbd.SelectedPath;
			}// End If
		}// End Method

		/// <summary>
		/// 「ファイル」→「アプリケーションの終了」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuExit_Click(object sender, EventArgs e) {
			Close();
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------
		#region 表示

		/// <summary>
		/// 「表示」→「ステータスバー」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuViwerStatusBar_Click(object sender, EventArgs e) {
			if (StripMenuViwerStatusBar.Checked == true) {
				StripMenuViwerStatusBar.Checked = false;
				ToolStripContainer.BottomToolStripPanelVisible = false;
			} else {
				StripMenuViwerStatusBar.Checked = true;
				ToolStripContainer.BottomToolStripPanelVisible = true;
			}// End If
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------
		#region データベース

		#region 新規登録

		/// <summary>
		/// 「データベース」→「新規登録」→「ユニット」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddUnit_Click(object sender, EventArgs e) {
			// ダミーデータの作成
			Random rand = new Random();
			int Dummy = rand.Next(10000);

			try {
				DataRow row = TableUnitDataTable.NewRow();
				row["UnitID"] = "Unit" + Dummy.ToString();
				row["UnitName"] = "Unit" + Dummy.ToString();
				row["Type"] = 0;
				row["Info"] = "";

				TableUnitDataTable.Rows.Add(row);
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("New Row Insert Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("New Row Insert Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「ユニットタイプ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddUnitType_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「種族」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddRace_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「ジョブ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddJob_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「メーカー」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddMaker_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「武器」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddWeapon_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「盾」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddShield_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「頭防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddHelmet_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「腕防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddGauntlet_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「体防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddArmor_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「アクセサリー」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddAccessory_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「スキル」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddSkill_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「データベース」→「新規登録」→「アビリティ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void toolStripDbAddAbility_Click(object sender, EventArgs e) {

		}// End Method

		#endregion

		#region 再読み込み

		/// <summary>
		/// 「データベース」→「再読み込み」→「全て」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadAll_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				toolStripProgressBar1.Value = 0;
				toolStripProgressBar1.Maximum = ControlCount + TableCount;
				StripInfo.Text = "Reloading Database...";

				try {
					sum += RowCount[0] = tableElementTableAdapter.Fill(TableElementDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[1] = tableWeaponTypeTableAdapter.Fill(TableWeaponTypeDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[2] = tableUnitTableAdapter.Fill(TableUnitDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[3] = tableRaceTableAdapter.Fill(TableRaceDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[4] = tableJobTableAdapter.Fill(TableJobDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[5] = tableWeaponTableAdapter.FillSortByType(TableWeaponDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[6] = tableShieldTableAdapter.Fill(TableShieldDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[7] = tableHelmetTableAdapter.Fill(TableHelmetDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[8] = tableGauntletTableAdapter.Fill(TableGauntletDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[9] = tableArmorTableAdapter.Fill(TableArmorDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[10] = tableAccessoryTableAdapter.Fill(TableAccessoryDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[11] = tableSkillTableAdapter.Fill(TableSkillDataTable);
					toolStripProgressBar1.PerformStep();    // カウント

					ReloadControl();

					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method


		/// <summary>
		/// 「データベース」→「再読み込み」→「メニュー項目のみ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadMenu_Click(object sender, EventArgs e) {
			// ステータスバーの更新
			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Maximum = ControlCount;
			StripInfo.Text = "Reloading Database...";

			// 問い合わせる必要がないので再読み込みのみ行う
			try {
				ReloadControl();
				StripInfo.Text = "Reloading Complete!!";
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message;
				Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「ユニット」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadUnit_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[2] = tableUnitTableAdapter.Fill(TableUnitDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「ユニットタイプ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadUnitType_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}

		/// <summary>
		/// 「データベース」→「再読み込み」→「種族」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadRace_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[3] = tableRaceTableAdapter.Fill(TableRaceDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「ジョブ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadJob_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[4] = tableJobTableAdapter.Fill(TableJobDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「メーカー」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadMaker_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「武器」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadWeapon_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[5] = tableWeaponTableAdapter.FillSortByType(TableWeaponDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「盾」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadShield_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[6] = tableShieldTableAdapter.Fill(TableShieldDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「頭防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadHelmet_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[7] = tableHelmetTableAdapter.Fill(TableHelmetDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「腕防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadGauntlet_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[8] = tableGauntletTableAdapter.Fill(TableGauntletDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「体防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadArmor_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[9] = tableArmorTableAdapter.Fill(TableArmorDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「アクセサリー」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadAccessory_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[10] = tableAccessoryTableAdapter.Fill(TableAccessoryDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「スキル」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadSkill_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					sum = RowCount[11] = tableSkillTableAdapter.Fill(TableSkillDataTable);
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		/// <summary>
		/// 「データベース」→「再読み込み」→「アビリティ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadAbility_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				int sum = 0;    // 更新件数計算用
								// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					StripInfo.Text = "Reloading Complete!! Record Count:" + sum.ToString("N0");
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Method

		#endregion

		#region 変更の適用

		/// <summary>
		/// 「データベース」→「変更の適用」→「全て」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveAll_Click(object sender, EventArgs e) {
			UpdateSQL();
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「ユニット」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveUnit_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableUnitTableAdapter.Update(TableUnitDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「ユニットタイプ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveUnitType_Click(object sender, EventArgs e) {
			int sum = 0;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「種族」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveRace_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableRaceTableAdapter.Update(TableRaceDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「ジョブ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveJob_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableJobTableAdapter.Update(TableJobDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「メーカー」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveMaker_Click(object sender, EventArgs e) {
			int sum = 0;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「武器」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveWeapon_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();
			//tableWeaponBingingSource.EndEdit();

			try {
				sum = tableWeaponTableAdapter.Update(TableWeaponDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「盾」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveShield_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableShieldTableAdapter.Update(TableShieldDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「頭防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveHelmet_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableHelmetTableAdapter.Update(TableHelmetDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「腕防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveGauntlet_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableGauntletTableAdapter.Update(TableGauntletDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「体防具」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveArmor_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableArmorTableAdapter.Update(TableArmorDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「アクセサリー」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveAccessory_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableAccessoryTableAdapter.Update(TableAccessoryDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「スキル」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveSkill_Click(object sender, EventArgs e) {
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = tableSkillTableAdapter.Update(TableSkillDataTable);
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		/// <summary>
		/// 「データベース」→「変更の適用」→「アビリティ」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbSaveAbility_Click(object sender, EventArgs e) {
			int sum = 0;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				StripInfo.Text = "Update Complete!! Update Count:" + sum.ToString("N0");
			} catch (Exception ex) {
				StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
				Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}// End Try
		}// End Method

		#endregion

		#endregion

		//----------------------------------------------------------------------------------------------------
		#region ウィンドウ

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuWindowView_Click(object sender, EventArgs e) {
			TestForm Form2 = new TestForm();
			Form2.Show();
			//DataBindings();
		}// End Method

		#endregion

		//----------------------------------------------------------------------------------------------------

		#region ヘルプ

		/// <summary>
		/// 「ヘルプ」→「ヘルプの表示」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuHelpHelp_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「ヘルプ」→「バージョン情報」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuHelpVersion_Click(object sender, EventArgs e) {
			AboutBox1 Form2 = new AboutBox1();
			Form2.ShowDialog();
		}// End Method

		#endregion

	}// End Class
}
