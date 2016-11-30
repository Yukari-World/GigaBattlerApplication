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
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_Editer {
	public partial class EditerMainMenu : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// 変数
		private readonly int ControlCount = 8;
		private readonly int TableCount = 10;

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
		BindingSource tableElementBindingSource = new BindingSource();
		BindingSource tableWeaponTypeBindingSource = new BindingSource();
		BindingSource tableUnitBindingSource = new BindingSource();
		BindingSource tableRaceBindingSource = new BindingSource();
		BindingSource tableJobBindingSource = new BindingSource();
		BindingSource tableWeaponBingingSource = new BindingSource();
		BindingSource tableShieldBingingSource = new BindingSource();
		BindingSource tableHelmetBingingSource = new BindingSource();
		BindingSource tableGauntletBingingSource = new BindingSource();
		BindingSource tableArmorBingingSource = new BindingSource();
		BindingSource tableAccessoryBingingSource = new BindingSource();
		BindingSource tableSkillBingingSource = new BindingSource();


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
			DropInfomation.ReloadBindings(tableWeaponTableAdapter, tableShieldTableAdapter, tableHelmetTableAdapter, tableGauntletTableAdapter, tableArmorTableAdapter, tableAccessoryTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント
			ActiveSkillInfomation.ReloadBindings(tableSkillTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 武器

			ItemInfoWeapon.ReloadBindings(tableElementTableAdapter, tableWeaponTypeTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 盾

			ItemInfoShield.ReloadBindings(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 頭防具

			ItemInfoHelmet.ReloadBindings(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 腕防具

			ItemInfoGauntlet.ReloadBindings(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: 体防具

			ItemInfoArmor.ReloadBindings(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント

			// TAB: アクセサリー

			ItemInfoAccessory.ReloadBindings(tableElementTableAdapter);
			toolStripProgressBar1.PerformStep();    // カウント
		}

		/// <summary>
		/// 変更した更新内容を適用します。
		/// </summary>
		private void UpdateSQL() {
			int sum = 0;    // 更新件数計算用
			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Maximum = TableCount + 1;
			StripInfo.Text = "Updating Database...";

			// 編集終了宣言
			Validate();
			tableUnitBindingSource.EndEdit();
			tableRaceBindingSource.EndEdit();
			tableJobBindingSource.EndEdit();
			tableWeaponBingingSource.EndEdit();
			tableShieldBingingSource.EndEdit();
			tableHelmetBingingSource.EndEdit();
			tableGauntletBingingSource.EndEdit();
			tableArmorBingingSource.EndEdit();
			tableAccessoryBingingSource.EndEdit();
			tableSkillBingingSource.EndEdit();

			toolStripProgressBar1.PerformStep();

			try {
				// 更新処理
				sum += tableUnitTableAdapter.Update(GigaBattlerDataSet.__table_unit);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableRaceTableAdapter.Update(GigaBattlerDataSet.__table_race);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableJobTableAdapter.Update(GigaBattlerDataSet.__table_job);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableWeaponTableAdapter.Update(GigaBattlerDataSet.__table_weapon);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableShieldTableAdapter.Update(GigaBattlerDataSet.__table_shield);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableHelmetTableAdapter.Update(GigaBattlerDataSet.__table_helmet);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableGauntletTableAdapter.Update(GigaBattlerDataSet.__table_gauntlet);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableArmorTableAdapter.Update(GigaBattlerDataSet.__table_armor);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableAccessoryTableAdapter.Update(GigaBattlerDataSet.__table_accessory);
				toolStripProgressBar1.PerformStep();    // カウント
				sum += tableSkillTableAdapter.Update(GigaBattlerDataSet.__table_skill);
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

				tableElementBindingSource.DataMember = "__table_element";
				tableElementBindingSource.DataSource = GigaBattlerDataSet;
				tableWeaponTypeBindingSource.DataMember = "__table_weapon_type";
				tableWeaponTypeBindingSource.DataSource = GigaBattlerDataSet;
				tableUnitBindingSource.DataMember = "__table_unit";
				tableUnitBindingSource.DataSource = GigaBattlerDataSet;
				tableRaceBindingSource.DataMember = "__table_race";
				tableRaceBindingSource.DataSource = GigaBattlerDataSet;
				tableJobBindingSource.DataMember = "__table_job";
				tableJobBindingSource.DataSource = GigaBattlerDataSet;
				tableWeaponBingingSource.DataMember = "__table_weapon";
				tableWeaponBingingSource.DataSource = GigaBattlerDataSet;
				tableShieldBingingSource.DataMember = "__table_shield";
				tableShieldBingingSource.DataSource = GigaBattlerDataSet;
				tableHelmetBingingSource.DataMember = "__table_helmet";
				tableHelmetBingingSource.DataSource = GigaBattlerDataSet;
				tableGauntletBingingSource.DataMember = "__table_gauntlet";
				tableGauntletBingingSource.DataSource = GigaBattlerDataSet;
				tableArmorBingingSource.DataMember = "__table_armor";
				tableArmorBingingSource.DataSource = GigaBattlerDataSet;
				tableAccessoryBingingSource.DataMember = "__table_accessory";
				tableAccessoryBingingSource.DataSource = GigaBattlerDataSet;
				tableSkillBingingSource.DataMember = "__table_skill";
				tableSkillBingingSource.DataSource = GigaBattlerDataSet;

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

				listUnit.DataSource = tableUnitBindingSource;
				listUnit.DisplayMember = "UnitName";
				listUnit.ValueMember = "UnitID";

				listRace.DataSource = tableRaceBindingSource;
				listRace.DisplayMember = "RaceName";
				listRace.ValueMember = "RaceID";

				listJob.DataSource = tableJobBindingSource;
				listJob.DisplayMember = "JobName";
				listJob.ValueMember = "JobID";

				listWeapon.DataSource = tableWeaponBingingSource;
				listWeapon.DisplayMember = "WeaponName";
				listWeapon.ValueMember = "WeaponID";

				listShield.DataSource = tableShieldBingingSource;
				listShield.DisplayMember = "ShieldName";
				listShield.ValueMember = "ShieldID";

				listHelmet.DataSource = tableHelmetBingingSource;
				listHelmet.DisplayMember = "HelmetName";
				listHelmet.ValueMember = "HelmetID";

				listGauntlet.DataSource = tableGauntletBingingSource;
				listGauntlet.DisplayMember = "GauntletName";
				listGauntlet.ValueMember = "GauntletID";

				listArmor.DataSource = tableArmorBingingSource;
				listArmor.DisplayMember = "ArmorName";
				listArmor.ValueMember = "ArmorID";

				listAccessory.DataSource = tableAccessoryBingingSource;
				listAccessory.DisplayMember = "AccessoryName";
				listAccessory.ValueMember = "AccessoryID";

				Debug.WriteLine("Task 4 Finish.");
			});

			//----------------------------------------------------------------------------------------------------
			// 別コントロールへのバインディング設定
			// TAB: ユニット

			var Task5_3 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-3 Start.");

				TotalUnitInfomation.LoadDataBindings(tableUnitBindingSource);
				UnitInfomation.LoadDataBindings(tableUnitBindingSource);
				DropInfomation.LoadDataBindings(tableUnitBindingSource, tableWeaponTableAdapter, tableShieldTableAdapter, tableHelmetTableAdapter, tableGauntletTableAdapter, tableArmorTableAdapter, tableAccessoryTableAdapter);
				StatusInfomation.LoadDataBindings(tableUnitBindingSource);
				ActiveSkillInfomation.LoadDataBindings(tableUnitBindingSource);

				Debug.WriteLine("Task 5-3 Finish.");
			});

			// TAB: ユニットタイプ

			// NULL

			// TAB: 種族

			var Task5_5 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-5 Start.");

				RaceInfomation.LoadDataBindings(tableRaceBindingSource);

				Debug.WriteLine("Task 5-5 Finish.");
			});

			// TAB: ジョブ

			var Task5_6 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-6 Start.");
				JobInfomation.LoadDataBindings(tableJobBindingSource);

				Debug.WriteLine("Task 5-6 Finish.");
			});

			// TAB: メーカー

			// NULL

			// TAB: 武器

			var Task5_8 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-8 Start.");

				ItemInfoWeapon.LoadDataBindings(tableWeaponBingingSource);
				EquipItemWeapon.LoadDataBindings(tableWeaponBingingSource);

				Debug.WriteLine("Task 5-8 Finish.");
			});

			// TAB: 盾

			var Task5_9 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-9 Start.");

				ItemInfoShield.LoadDataBindings(tableShieldBingingSource, "Shield");
				EquipItemShield.LoadDataBindings(tableShieldBingingSource);

				Debug.WriteLine("Task 5-9 Finish.");
			});

			// TAB: 頭防具

			var Task5_10 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-10 Start.");

				ItemInfoHelmet.LoadDataBindings(tableHelmetBingingSource, "Helmet");
				EquipItemHelmet.LoadDataBindings(tableHelmetBingingSource);

				Debug.WriteLine("Task 5-10 Finish.");
			});

			// TAB: 腕防具

			var Task5_11 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-11 Start.");

				ItemInfoGauntlet.LoadDataBindings(tableGauntletBingingSource, "Gauntlet");
				EquipItemGauntlet.LoadDataBindings(tableGauntletBingingSource);

				Debug.WriteLine("Task 5-11 Finish.");
			});

			// TAB: 体防具

			var Task5_12 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-12 Start.");

				ItemInfoArmor.LoadDataBindings(tableArmorBingingSource, "Armor");
				EquipItemArmor.LoadDataBindings(tableArmorBingingSource);

				Debug.WriteLine("Task 5-12 Finish.");
			});

			// TAB: アクセサリー

			var Task5_13 = Task.Factory.StartNew(() => {
				Debug.WriteLine("Task 5-13 Start.");

				ItemInfoAccessory.LoadDataBindings(tableAccessoryBingingSource, "Accessory");
				EquipItemAccessory.LoadDataBindings(tableAccessoryBingingSource);

				Debug.WriteLine("Task 5-13 Finish.");
			});


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
				tableElementTableAdapter.Fill(GigaBattlerDataSet.__table_element);
				tableWeaponTypeTableAdapter.Fill(GigaBattlerDataSet.__table_weapon_type);
				tableUnitTableAdapter.Fill(GigaBattlerDataSet.__table_unit);
				tableRaceTableAdapter.Fill(GigaBattlerDataSet.__table_race);
				tableJobTableAdapter.Fill(GigaBattlerDataSet.__table_job);
				tableWeaponTableAdapter.FillSortByType(GigaBattlerDataSet.__table_weapon);
				tableShieldTableAdapter.Fill(GigaBattlerDataSet.__table_shield);
				tableHelmetTableAdapter.Fill(GigaBattlerDataSet.__table_helmet);
				tableGauntletTableAdapter.Fill(GigaBattlerDataSet.__table_gauntlet);
				tableArmorTableAdapter.Fill(GigaBattlerDataSet.__table_armor);
				tableAccessoryTableAdapter.Fill(GigaBattlerDataSet.__table_accessory);
				tableSkillTableAdapter.Fill(GigaBattlerDataSet.__table_skill);

				// コントロール側の処理はメソッドに移動
				ReloadControl();
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

			StripInfo.Text = "Welcome!!";
		}// End Method

		#endregion

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
			DialogResult result = MessageBox.Show("終了時にデータベースをアップデートしますか?", "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
			switch (result) {
				case DialogResult.Yes:
					UpdateSQL();
					break;
				case DialogResult.No:
					break;
				case DialogResult.Cancel:
					return;
			}// End Switch
			Close();
			Application.Exit();
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

		#region 再読み込み

		/// <summary>
		/// 「データベース」→「再読み込み」→「全て」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDbReloadAll_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				// ステータスバーの更新
				toolStripProgressBar1.Value = 0;
				toolStripProgressBar1.Maximum = ControlCount + TableCount;
				StripInfo.Text = "Reloading Database...";

				try {
					toolStripProgressBar1.Value = 0;
					tableUnitTableAdapter.Fill(GigaBattlerDataSet.__table_unit);
					toolStripProgressBar1.PerformStep();
					tableRaceTableAdapter.Fill(GigaBattlerDataSet.__table_race);
					toolStripProgressBar1.PerformStep();
					tableJobTableAdapter.Fill(GigaBattlerDataSet.__table_job);
					toolStripProgressBar1.PerformStep();
					tableWeaponTableAdapter.FillSortByType(GigaBattlerDataSet.__table_weapon);
					toolStripProgressBar1.PerformStep();
					tableShieldTableAdapter.Fill(GigaBattlerDataSet.__table_shield);
					toolStripProgressBar1.PerformStep();
					tableHelmetTableAdapter.Fill(GigaBattlerDataSet.__table_helmet);
					toolStripProgressBar1.PerformStep();
					tableGauntletTableAdapter.Fill(GigaBattlerDataSet.__table_gauntlet);
					toolStripProgressBar1.PerformStep();
					tableArmorTableAdapter.Fill(GigaBattlerDataSet.__table_armor);
					toolStripProgressBar1.PerformStep();
					tableAccessoryTableAdapter.Fill(GigaBattlerDataSet.__table_accessory);
					toolStripProgressBar1.PerformStep();
					tableSkillTableAdapter.Fill(GigaBattlerDataSet.__table_skill);
					toolStripProgressBar1.PerformStep();

					ReloadControl();

					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableUnitTableAdapter.Fill(GigaBattlerDataSet.__table_unit);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableRaceTableAdapter.Fill(GigaBattlerDataSet.__table_race);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableJobTableAdapter.Fill(GigaBattlerDataSet.__table_job);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableWeaponTableAdapter.FillSortByType(GigaBattlerDataSet.__table_weapon);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableShieldTableAdapter.Fill(GigaBattlerDataSet.__table_shield);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableHelmetTableAdapter.Fill(GigaBattlerDataSet.__table_helmet);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableGauntletTableAdapter.Fill(GigaBattlerDataSet.__table_gauntlet);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableArmorTableAdapter.Fill(GigaBattlerDataSet.__table_armor);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableAccessoryTableAdapter.Fill(GigaBattlerDataSet.__table_accessory);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					tableSkillTableAdapter.Fill(GigaBattlerDataSet.__table_skill);
					StripInfo.Text = "Reloading Complete!!";
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
				// ステータスバーの更新
				StripInfo.Text = "Reloading Database...";
				try {
					StripInfo.Text = "Reloading Complete!!";
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
			tableUnitBindingSource.EndEdit();

			try {
				sum = tableUnitTableAdapter.Update(GigaBattlerDataSet.__table_unit);
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
			tableRaceBindingSource.EndEdit();

			try {
				sum = tableRaceTableAdapter.Update(GigaBattlerDataSet.__table_race);
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
			tableJobBindingSource.EndEdit();

			try {
				sum = tableJobTableAdapter.Update(GigaBattlerDataSet.__table_job);
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
			tableWeaponBingingSource.EndEdit();

			try {
				sum = tableWeaponTableAdapter.Update(GigaBattlerDataSet.__table_weapon);
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
			tableShieldBingingSource.EndEdit();

			try {
				sum = tableShieldTableAdapter.Update(GigaBattlerDataSet.__table_shield);
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
			tableHelmetBingingSource.EndEdit();

			try {
				sum = tableHelmetTableAdapter.Update(GigaBattlerDataSet.__table_helmet);
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
			tableGauntletBingingSource.EndEdit();

			try {
				sum = tableGauntletTableAdapter.Update(GigaBattlerDataSet.__table_gauntlet);
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
			tableArmorBingingSource.EndEdit();

			try {
				sum = tableArmorTableAdapter.Update(GigaBattlerDataSet.__table_armor);
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
			tableAccessoryBingingSource.EndEdit();

			try {
				sum = tableAccessoryTableAdapter.Update(GigaBattlerDataSet.__table_accessory);
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
			tableSkillBingingSource.EndEdit();

			try {
				sum = tableSkillTableAdapter.Update(GigaBattlerDataSet.__table_skill);
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
