﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Editer Main Menu
//
// エディタのメインフォーム。
// ソースコードが長く成り気味なので#regionを利用すること。
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

		// Class in Enum
		/// <summary>
		/// 行数を数える為の列挙型。FOEは配列に充てるためのもの(明示的変換が必要なことを忘れずに!!)
		/// </summary>
		private enum RowState : int {
			Element, WeaponType, Unit, UnitType, Race, Job, Maker, Weapon, Shield, Helmet, Gauntlet, Armor, Accessory, Skill, Ability, City, BattleField, WaveData, FOE
		}

		// 変数
		/// <summary>
		/// エラー終了フラグ
		/// </summary>
		private bool isError = false;

		/// <summary>
		/// データ行の数(配列)
		/// </summary>
		private int[] RowCount = new int[(int)RowState.FOE];

		/// <summary>
		/// DataTableを使用しているUserControlの数
		/// </summary>
		private readonly int ControlCount = 8;

		/// <summary>
		/// データベースのテーブルの数
		/// </summary>
		//private readonly int TableCount = (int)RowState.FOE;
		private readonly int TableCount = 13;

		public string rootDirectory = "";

		// TableAdapter
		__table_elementTableAdapter TableElementTableAdapter = new __table_elementTableAdapter();
		__table_weapon_typeTableAdapter TableWeaponTypeTableAdapter = new __table_weapon_typeTableAdapter();
		__table_unitTableAdapter TableUnitTableAdapter = new __table_unitTableAdapter();
		__table_raceTableAdapter TableRaceTableAdapter = new __table_raceTableAdapter();
		__table_jobTableAdapter TableJobTableAdapter = new __table_jobTableAdapter();
		__table_makerTableAdapter TableMakerTableAdapter = new __table_makerTableAdapter();
		__table_weaponTableAdapter TableWeaponTableAdapter = new __table_weaponTableAdapter();
		__table_shieldTableAdapter TableShieldTableAdapter = new __table_shieldTableAdapter();
		__table_helmetTableAdapter TableHelmetTableAdapter = new __table_helmetTableAdapter();
		__table_gauntletTableAdapter TableGauntletTableAdapter = new __table_gauntletTableAdapter();
		__table_armorTableAdapter TableArmorTableAdapter = new __table_armorTableAdapter();
		__table_accessoryTableAdapter TableAccessoryTableAdapter = new __table_accessoryTableAdapter();
		__table_skillTableAdapter TableSkillTableAdapter = new __table_skillTableAdapter();

		// DataTable
		__table_elementDataTable TableElementDataTable = new __table_elementDataTable();
		__table_weapon_typeDataTable TableWeaponTypeDataTable = new __table_weapon_typeDataTable();
		__table_unitDataTable TableUnitDataTable = new __table_unitDataTable();
		__table_raceDataTable TableRaceDataTable = new __table_raceDataTable();
		__table_jobDataTable TableJobDataTable = new __table_jobDataTable();
		__table_makerDataTable TableMakerDataTable = new __table_makerDataTable();
		__table_weaponDataTable TableWeaponDataTable = new __table_weaponDataTable();
		__table_shieldDataTable TableShieldDataTable = new __table_shieldDataTable();
		__table_helmetDataTable TableHelmetDataTable = new __table_helmetDataTable();
		__table_gauntletDataTable TableGauntletDataTable = new __table_gauntletDataTable();
		__table_armorDataTable TableArmorDataTable = new __table_armorDataTable();
		__table_accessoryDataTable TableAccessoryDataTable = new __table_accessoryDataTable();
		__table_skillDataTable TableSkillDataTable = new __table_skillDataTable();

		// Form
		FormUnit FormUnitData = null;
		FormRace FormRaceData = null;


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
			DropInfomation.ReloadDataTable(TableWeaponDataTable, TableShieldDataTable, TableHelmetDataTable, TableGauntletDataTable, TableArmorDataTable, TableAccessoryDataTable);
			toolStripProgressBar1.PerformStep();    // カウント
			ActiveSkillInfomation.ReloadBindings(TableSkillDataTable);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 武器

			ItemInfoWeapon.ReloadDataTable(TableElementDataTable, TableWeaponTypeDataTable);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 盾

			ItemInfoShield.ReloadDataTable(TableElementDataTable);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 頭防具

			ItemInfoHelmet.ReloadDataTable(TableElementDataTable);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 腕防具

			ItemInfoGauntlet.ReloadDataTable(TableElementDataTable);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 体防具

			ItemInfoArmor.ReloadDataTable(TableElementDataTable);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: アクセサリー

			ItemInfoAccessory.ReloadDataTable(TableElementDataTable);
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
				sum += RowCount[(int)RowState.Element] = TableElementTableAdapter.Update(TableElementDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.WeaponType] = TableWeaponTypeTableAdapter.Update(TableWeaponTypeDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Unit] = TableUnitTableAdapter.Update(TableUnitDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Race] = TableRaceTableAdapter.Update(TableRaceDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Job] = TableJobTableAdapter.Update(TableJobDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Maker] = TableMakerTableAdapter.Update(TableMakerDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Weapon] = TableWeaponTableAdapter.Update(TableWeaponDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Shield] = TableShieldTableAdapter.Update(TableShieldDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Helmet] = TableHelmetTableAdapter.Update(TableHelmetDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Gauntlet] = TableGauntletTableAdapter.Update(TableGauntletDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Armor] = TableArmorTableAdapter.Update(TableArmorDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Accessory] = TableAccessoryTableAdapter.Update(TableAccessoryDataTable);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += RowCount[(int)RowState.Skill] = TableSkillTableAdapter.Update(TableSkillDataTable);
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
			// Initialize

			TableElementTableAdapter.ClearBeforeFill = true;
			TableWeaponTypeTableAdapter.ClearBeforeFill = true;
			TableUnitTableAdapter.ClearBeforeFill = true;
			TableRaceTableAdapter.ClearBeforeFill = true;
			TableJobTableAdapter.ClearBeforeFill = true;
			TableMakerTableAdapter.ClearBeforeFill = true;
			TableWeaponTableAdapter.ClearBeforeFill = true;
			TableShieldTableAdapter.ClearBeforeFill = true;
			TableHelmetTableAdapter.ClearBeforeFill = true;
			TableGauntletTableAdapter.ClearBeforeFill = true;
			TableArmorTableAdapter.ClearBeforeFill = true;
			TableAccessoryTableAdapter.ClearBeforeFill = true;
			TableSkillTableAdapter.ClearBeforeFill = true;

			//----------------------------------------------------------------------------------------------------
			// データの埋め込み
			// ネットワーク関連を使用するのでtryを使用
			try {
				RowCount[(int)RowState.Element] = TableElementTableAdapter.Fill(TableElementDataTable);
				RowCount[(int)RowState.WeaponType] = TableWeaponTypeTableAdapter.Fill(TableWeaponTypeDataTable);
				RowCount[(int)RowState.Unit] = TableUnitTableAdapter.Fill(TableUnitDataTable);
				RowCount[(int)RowState.Race] = TableRaceTableAdapter.Fill(TableRaceDataTable);
				RowCount[(int)RowState.Job] = TableJobTableAdapter.Fill(TableJobDataTable);
				RowCount[(int)RowState.Maker] = TableMakerTableAdapter.Fill(TableMakerDataTable);
				RowCount[(int)RowState.Weapon] = TableWeaponTableAdapter.FillSortByType(TableWeaponDataTable);
				RowCount[(int)RowState.Shield] = TableShieldTableAdapter.Fill(TableShieldDataTable);
				RowCount[(int)RowState.Helmet] = TableHelmetTableAdapter.Fill(TableHelmetDataTable);
				RowCount[(int)RowState.Gauntlet] = TableGauntletTableAdapter.Fill(TableGauntletDataTable);
				RowCount[(int)RowState.Armor] = TableArmorTableAdapter.Fill(TableArmorDataTable);
				RowCount[(int)RowState.Accessory] = TableAccessoryTableAdapter.Fill(TableAccessoryDataTable);
				RowCount[(int)RowState.Skill] = TableSkillTableAdapter.Fill(TableSkillDataTable);

				// コントロール側の処理はメソッドに移動
				ReloadControl();
				toolStripProgressBar1.Value = 0;    // 値をリセット
			} catch (Exception ex) {
				isError = true;
				Debug.WriteLine("System Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
				MessageBox.Show("System Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// 続行不可能なので終了させる
				Close();
				Dispose();
				Application.Exit();
			}// End Try

			//----------------------------------------------------------------------------------------------------
			// デザイナープロパティの設定
			// 出来ればデザイナープロパティに設定したいが、バグ(仕様?:Anchorの設定によってはフォームデザイナが勝手に書き換えられる)の関係でここで設定。
			// タスク化しているけど無意味?

			var Task1 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 1: Start.");

				// TAB: ユニット
				listUnit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				tabControlUnit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Unit Designer Setting End.");

				// TAB: 種族

				listRace.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Race Designer Setting End.");

				// TAB: ジョブ

				listJob.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Job Designer Setting End.");

				// TAB: メーカー

				listMaker.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Maker Designer Setting End.");

				// TAB: 武器

				listWeapon.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Weapon Designer Setting End.");

				// TAB: 盾

				listShield.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Shield Designer Setting End.");

				// TAB: 頭防具

				listHelmet.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Helmet Designer Setting End.");

				// TAB: 腕防具

				listGauntlet.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Gauntlet Designer Setting End.");

				// TAB: 体防具

				listArmor.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Armor Designer Setting End.");

				// TAB: アクセサリー

				listAccessory.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
				Debug.WriteLine("Task 1: List Accessory Designer Setting End.");

				Debug.WriteLine("Task 1: Finish.");
			});

			//----------------------------------------------------------------------------------------------------
			// バインド項目の設定

			var Task2 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 2: Start.");

				listUnit.DataSource = TableUnitDataTable;
				listUnit.DisplayMember = "UnitName";
				listUnit.ValueMember = "UnitID";
				Debug.WriteLine("Task 2: List Unit Data Source Setting End.");

				listRace.DataSource = TableRaceDataTable;
				listRace.DisplayMember = "RaceName";
				listRace.ValueMember = "RaceID";
				Debug.WriteLine("Task 2: List Race Data Source Setting End.");

				listJob.DataSource = TableJobDataTable;
				listJob.DisplayMember = "JobName";
				listJob.ValueMember = "JobID";
				Debug.WriteLine("Task 2: List Job Data Source Setting End.");

				listMaker.DataSource = TableMakerDataTable;
				listMaker.DisplayMember = "MakerName";
				listMaker.ValueMember = "MakerID";
				Debug.WriteLine("Task 2: List Maker Data Source Setting End.");

				listWeapon.DataSource = TableWeaponDataTable;
				listWeapon.DisplayMember = "WeaponName";
				listWeapon.ValueMember = "WeaponID";
				Debug.WriteLine("Task 2: List Weapon Data Source Setting End.");

				listShield.DataSource = TableShieldDataTable;
				listShield.DisplayMember = "ShieldName";
				listShield.ValueMember = "ShieldID";
				Debug.WriteLine("Task 2: List Shield Data Source Setting End.");

				listHelmet.DataSource = TableHelmetDataTable;
				listHelmet.DisplayMember = "HelmetName";
				listHelmet.ValueMember = "HelmetID";
				Debug.WriteLine("Task 2: List Helmet Data Source Setting End.");

				listGauntlet.DataSource = TableGauntletDataTable;
				listGauntlet.DisplayMember = "GauntletName";
				listGauntlet.ValueMember = "GauntletID";
				Debug.WriteLine("Task 2: List Gauntlet Data Source Setting End.");

				listArmor.DataSource = TableArmorDataTable;
				listArmor.DisplayMember = "ArmorName";
				listArmor.ValueMember = "ArmorID";
				Debug.WriteLine("Task 2: List Armor Data Source Setting End.");

				listAccessory.DataSource = TableAccessoryDataTable;
				listAccessory.DisplayMember = "AccessoryName";
				listAccessory.ValueMember = "AccessoryID";
				Debug.WriteLine("Task 2: List Accessory Data Source Setting End.");

				Debug.WriteLine("Task 2: Finish.");
			});

			//----------------------------------------------------------------------------------------------------
			// 別コントロールへのバインディング設定
			// TAB: ユニット

			var Task3_3 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-3: Start.");

				TotalUnitInfomation.SetDataBindings(TableUnitDataTable);
				UnitInfomation.SetDataBindings(TableUnitDataTable);
				DropInfomation.SetDataBindings(TableUnitDataTable, TableWeaponDataTable, TableShieldDataTable, TableHelmetDataTable, TableGauntletDataTable, TableArmorDataTable, TableAccessoryDataTable);
				StatusInfomation.SetDataBindings(TableUnitDataTable);
				ActiveSkillInfomation.SetDataBindings(TableUnitDataTable, TableSkillDataTable);

				Debug.WriteLine("Task 3-3: Finish.");
			});

			// TAB: ユニットタイプ

			// NULL

			// TAB: 種族

			var Task3_5 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-5: Start.");

				RaceInfomation.SetDataBindings(TableRaceDataTable);

				Debug.WriteLine("Task 3-5: Finish.");
			});

			// TAB: ジョブ

			var Task3_6 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-6: Start.");

				JobInfomation.LoadDataBindings(TableJobDataTable);

				Debug.WriteLine("Task 3-6: Finish.");
			});

			// TAB: メーカー


			var Task3_7 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-7: Start.");

				Debug.WriteLine("Task 3-7: Finish.");
			});

			// TAB: 武器

			var Task3_8 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-8: Start.");

				ItemInfoWeapon.SetDataBindings(TableWeaponDataTable, TableElementDataTable, TableWeaponTypeDataTable);
				EquipItemWeapon.SetDataBindings(TableWeaponDataTable);

				Debug.WriteLine("Task 3-8: Finish.");
			});

			// TAB: 盾

			var Task3_9 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-9: Start.");

				ItemInfoShield.SetDataBindings(TableShieldDataTable, TableElementDataTable, "Shield");
				EquipItemShield.SetDataBindings(TableShieldDataTable);

				Debug.WriteLine("Task 3-9: Finish.");
			});

			// TAB: 頭防具

			var Task3_10 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-10: Start.");

				ItemInfoHelmet.SetDataBindings(TableHelmetDataTable, TableElementDataTable, "Helmet");
				EquipItemHelmet.SetDataBindings(TableHelmetDataTable);

				Debug.WriteLine("Task 3-10: Finish.");
			});

			// TAB: 腕防具

			var Task3_11 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-11: Start.");

				ItemInfoGauntlet.SetDataBindings(TableGauntletDataTable, TableElementDataTable, "Gauntlet");
				EquipItemGauntlet.SetDataBindings(TableGauntletDataTable);

				Debug.WriteLine("Task 3-11: Finish.");
			});

			// TAB: 体防具

			var Task3_12 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-12: Start.");

				ItemInfoArmor.SetDataBindings(TableArmorDataTable, TableElementDataTable, "Armor");
				EquipItemArmor.SetDataBindings(TableArmorDataTable);

				Debug.WriteLine("Task 3-12: Finish.");
			});

			// TAB: アクセサリー

			var Task3_13 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 3-13: Start.");

				ItemInfoAccessory.SetDataBindings(TableAccessoryDataTable, TableElementDataTable, "Accessory");
				EquipItemAccessory.SetDataBindings(TableAccessoryDataTable);

				Debug.WriteLine("Task 3-13: Finish.");
			});

			// 待機～～
			Task1.Wait();
			Task2.Wait();
			Task3_3.Wait();
			Task3_5.Wait();
			Task3_6.Wait();
			Task3_7.Wait();
			Task3_8.Wait();
			Task3_9.Wait();
			Task3_10.Wait();
			Task3_11.Wait();
			Task3_12.Wait();
			Task3_13.Wait();
			Debug.WriteLine("All Task Finish.");

			// 破棄破棄
			Task1.Dispose();
			Task2.Dispose();
			Task3_3.Dispose();
			Task3_5.Dispose();
			Task3_6.Dispose();
			Task3_7.Dispose();
			Task3_8.Dispose();
			Task3_9.Dispose();
			Task3_10.Dispose();
			Task3_11.Dispose();
			Task3_12.Dispose();
			Task3_13.Dispose();

			// タイトルにバージョン番号を付与
			Text = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false) + Assembly.GetExecutingAssembly().GetName().Version.ToString();
			StripInfo.Text = "Welcome!!";
			Debug.WriteLine("System Starting Without Errors.");
		}// End Method

		#endregion

		/// <summary>
		/// フォームを閉じる直前の処理。キャンセルで閉じる動作をキャンセルする
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void EditerMainMenu_FormClosing(object sender, FormClosingEventArgs e) {
			// エラー落ちなら処理させない(無駄にエラーが増えるだけ)
			if (isError != true) {
				// 選択肢
				DialogResult result = MessageBox.Show("終了時にデータベースをアップデートしますか?", "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
				switch (result) {
					case DialogResult.Yes:
						try {
							UpdateSQL();
						} catch (Exception ex) {
							Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
							// 処理をキャンセルさせる。更新したいデータが更新されず、泣寝入りしない為にも
							e.Cancel = true;
						} finally {

						}// End Try
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
				}// End Switch
			}// End If
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
			// 閉じる。後の処理はメソッドに任せる
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
			// チェックが付いているかで切り替える
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
					sum += RowCount[(int)RowState.Element] = TableElementTableAdapter.Fill(TableElementDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.WeaponType] = TableWeaponTypeTableAdapter.Fill(TableWeaponTypeDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Unit] = TableUnitTableAdapter.Fill(TableUnitDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Race] = TableRaceTableAdapter.Fill(TableRaceDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Job] = TableJobTableAdapter.Fill(TableJobDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Maker] = TableMakerTableAdapter.Update(TableMakerDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Weapon] = TableWeaponTableAdapter.FillSortByType(TableWeaponDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Shield] = TableShieldTableAdapter.Fill(TableShieldDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Helmet] = TableHelmetTableAdapter.Fill(TableHelmetDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Gauntlet] = TableGauntletTableAdapter.Fill(TableGauntletDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Armor] = TableArmorTableAdapter.Fill(TableArmorDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Accessory] = TableAccessoryTableAdapter.Fill(TableAccessoryDataTable);
					toolStripProgressBar1.PerformStep();    // カウント
					sum += RowCount[(int)RowState.Skill] = TableSkillTableAdapter.Fill(TableSkillDataTable);
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
					sum = RowCount[(int)RowState.Unit] = TableUnitTableAdapter.Fill(TableUnitDataTable);
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
					sum = RowCount[(int)RowState.Race] = TableRaceTableAdapter.Fill(TableRaceDataTable);
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
					sum = RowCount[(int)RowState.Job] = TableJobTableAdapter.Fill(TableJobDataTable);
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
					sum += RowCount[(int)RowState.Maker] = TableMakerTableAdapter.Fill(TableMakerDataTable);
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
					sum = RowCount[(int)RowState.Weapon] = TableWeaponTableAdapter.FillSortByType(TableWeaponDataTable);
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
					sum = RowCount[(int)RowState.Shield] = TableShieldTableAdapter.Fill(TableShieldDataTable);
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
					sum = RowCount[(int)RowState.Helmet] = TableHelmetTableAdapter.Fill(TableHelmetDataTable);
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
					sum = RowCount[(int)RowState.Gauntlet] = TableGauntletTableAdapter.Fill(TableGauntletDataTable);
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
					sum = RowCount[(int)RowState.Armor] = TableArmorTableAdapter.Fill(TableArmorDataTable);
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
					sum = RowCount[(int)RowState.Accessory] = TableAccessoryTableAdapter.Fill(TableAccessoryDataTable);
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
					sum = RowCount[(int)RowState.Skill] = TableSkillTableAdapter.Fill(TableSkillDataTable);
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
				sum = TableUnitTableAdapter.Update(TableUnitDataTable);
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
				sum = TableRaceTableAdapter.Update(TableRaceDataTable);
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
				sum = TableJobTableAdapter.Update(TableJobDataTable);
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
			int sum;    // 更新件数計算用

			// 編集終了宣言
			Validate();

			try {
				sum = RowCount[(int)RowState.Maker] = TableMakerTableAdapter.Update(TableMakerDataTable);
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
				sum = TableWeaponTableAdapter.Update(TableWeaponDataTable);
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
				sum = TableShieldTableAdapter.Update(TableShieldDataTable);
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
				sum = TableHelmetTableAdapter.Update(TableHelmetDataTable);
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
				sum = TableGauntletTableAdapter.Update(TableGauntletDataTable);
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
				sum = TableArmorTableAdapter.Update(TableArmorDataTable);
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
				sum = TableAccessoryTableAdapter.Update(TableAccessoryDataTable);
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
				sum = TableSkillTableAdapter.Update(TableSkillDataTable);
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
		/// 「ウィンドウ」→「ユニット」の処理内容
		/// </summary>
		/// <remarks>
		/// 以下のページより参照
		/// http://tkmcra01.web.fc2.com/index/tajuu.html
		/// </remarks>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuWindowViewUnit_Click(object sender, EventArgs e) {
			if ((FormUnitData == null) || FormUnitData.IsDisposed) {
				FormUnitData = new FormUnit(TableUnitDataTable, TableWeaponTypeDataTable);
				FormUnitData.Show();
			}// End If
		}// End Method

		/// <summary>
		/// 「ウィンドウ」→「ユニットタイプ」の処理内容
		/// </summary>
		/// <remarks>
		/// 以下のページより参照
		/// http://tkmcra01.web.fc2.com/index/tajuu.html
		/// </remarks>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuWindowViewUnitType_Click(object sender, EventArgs e) {

		}// End Method

		/// <summary>
		/// 「ウィンドウ」→「ユニット種族」の処理内容
		/// </summary>
		/// <remarks>
		/// 以下のページより参照
		/// http://tkmcra01.web.fc2.com/index/tajuu.html
		/// </remarks>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuWindowViewRace_Click(object sender, EventArgs e) {
			if ((FormRaceData == null) || FormRaceData.IsDisposed) {
				FormRaceData = new FormRace(TableRaceDataTable);
				FormRaceData.Show();
			}// End If
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
			AboutBox Form2 = new AboutBox();
			Form2.ShowDialog();
		}// End Method

		#endregion
	}// End Class
}
