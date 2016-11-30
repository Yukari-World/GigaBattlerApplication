//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Editer Main Menu
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
		// Private Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// 変更した更新内容を適用します。
		/// </summary>
		private void UpdateSQL() {
			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Maximum = 110;
			StripInfo.Text = "Updating Database...";

			// 編集終了宣言
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

			//try {
				// 更新処理
				tableUnitTableAdapter.Update(GigaBattlerDataSet.@__table_unit);
				toolStripProgressBar1.PerformStep();
				tableRaceTableAdapter.Update(GigaBattlerDataSet.@__table_race);
				toolStripProgressBar1.PerformStep();
				tableJobTableAdapter.Update(GigaBattlerDataSet.@__table_job);
				toolStripProgressBar1.PerformStep();
				tableWeaponTableAdapter.Update(GigaBattlerDataSet.@__table_weapon);
				toolStripProgressBar1.PerformStep();
				tableShieldTableAdapter.Update(GigaBattlerDataSet.@__table_shield);
				toolStripProgressBar1.PerformStep();
				tableHelmetTableAdapter.Update(GigaBattlerDataSet.@__table_helmet);
				toolStripProgressBar1.PerformStep();
				tableGauntletTableAdapter.Update(GigaBattlerDataSet.@__table_gauntlet);
				toolStripProgressBar1.PerformStep();
				tableArmorTableAdapter.Update(GigaBattlerDataSet.@__table_armor);
				toolStripProgressBar1.PerformStep();
				tableAccessoryTableAdapter.Update(GigaBattlerDataSet.@__table_accessory);
				toolStripProgressBar1.PerformStep();
				tableSkillTableAdapter.Update(GigaBattlerDataSet.@__table_skill);
				toolStripProgressBar1.PerformStep();

				StripInfo.Text = "Update Succses!!";
			//} catch (Exception ex) {
			//	StripInfo.Text = "Error Info:" + ex.Message + ex.HelpLink;
			//	Debug.WriteLine("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
			//	MessageBox.Show("Database Update Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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
				// TAB: 頭防具
				// TAB: 腕防具
				// TAB: 体防具

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
			// TAB: 頭防具
			// TAB: 腕防具
			// TAB: 体防具

			Task5_3.Wait();
			Task5_5.Wait();
			Task5_6.Wait();
			Task5_8.Wait();

			//----------------------------------------------------------------------------------------------------
			// 共通
			// データの埋め込み
			// ネットワーク関連を使用するのでtryを使用
			try {
				tableElementTableAdapter.Fill(GigaBattlerDataSet.@__table_element);
				tableWeaponTypeTableAdapter.Fill(GigaBattlerDataSet.@__table_weapon_type);
				tableUnitTableAdapter.Fill(GigaBattlerDataSet.@__table_unit);
				tableRaceTableAdapter.Fill(GigaBattlerDataSet.@__table_race);
				tableJobTableAdapter.Fill(GigaBattlerDataSet.@__table_job);
				tableWeaponTableAdapter.FillSortByType(GigaBattlerDataSet.@__table_weapon);
				tableShieldTableAdapter.Fill(GigaBattlerDataSet.@__table_shield);
				tableHelmetTableAdapter.Fill(GigaBattlerDataSet.@__table_helmet);
				tableGauntletTableAdapter.Fill(GigaBattlerDataSet.@__table_gauntlet);
				tableArmorTableAdapter.Fill(GigaBattlerDataSet.@__table_armor);
				tableAccessoryTableAdapter.Fill(GigaBattlerDataSet.@__table_accessory);
				tableSkillTableAdapter.Fill(GigaBattlerDataSet.@__table_skill);

				// TAB: ユニット
				DropInfomation.ReloadBindings(tableWeaponTableAdapter, tableShieldTableAdapter, tableHelmetTableAdapter, tableGauntletTableAdapter, tableArmorTableAdapter, tableAccessoryTableAdapter);
				ActiveSkillInfomation.ReloadBindings(tableSkillTableAdapter);

				// TAB: 武器

				ItemInfoWeapon.ReloadBindings(tableElementTableAdapter, tableWeaponTypeTableAdapter);
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

			StripInfo.Text = "Welcome!!";
		}// End Function

		//----------------------------------------------------------------------------------------------------
		// Strip Menu 項目

		/// <summary>
		/// 「ファイル」→「開く」の処理内容
		/// http://dobon.net/vb/dotnet/form/folderdialog.htmlより参照
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
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
		}// End Function

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
		}// End Function

		/// <summary>
		/// 「データベース」→「再読み込み」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDatabaseReload_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				// ステータスバーの更新
				toolStripProgressBar1.Value = 0;
				toolStripProgressBar1.Maximum = 100;
				StripInfo.Text = "Reloading Database...";

				try {
					toolStripProgressBar1.Value = 0;
					tableUnitTableAdapter.Fill(GigaBattlerDataSet.@__table_unit);
					toolStripProgressBar1.PerformStep();
					tableRaceTableAdapter.Fill(GigaBattlerDataSet.@__table_race);
					toolStripProgressBar1.PerformStep();
					tableJobTableAdapter.Fill(GigaBattlerDataSet.@__table_job);
					toolStripProgressBar1.PerformStep();
					tableWeaponTableAdapter.FillSortByType(GigaBattlerDataSet.@__table_weapon);
					toolStripProgressBar1.PerformStep();
					tableShieldTableAdapter.Fill(GigaBattlerDataSet.@__table_shield);
					toolStripProgressBar1.PerformStep();
					tableHelmetTableAdapter.Fill(GigaBattlerDataSet.@__table_helmet);
					toolStripProgressBar1.PerformStep();
					tableGauntletTableAdapter.Fill(GigaBattlerDataSet.@__table_gauntlet);
					toolStripProgressBar1.PerformStep();
					tableArmorTableAdapter.Fill(GigaBattlerDataSet.@__table_armor);
					toolStripProgressBar1.PerformStep();
					tableAccessoryTableAdapter.Fill(GigaBattlerDataSet.@__table_accessory);
					toolStripProgressBar1.PerformStep();
					tableSkillTableAdapter.Fill(GigaBattlerDataSet.@__table_skill);
					toolStripProgressBar1.PerformStep();

					StripInfo.Text = "Done!!";
				} catch (Exception ex) {
					StripInfo.Text = "Error Info:" + ex.Message;
					Debug.WriteLine("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
					MessageBox.Show("Database Load Failed:\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Function

		/// <summary>
		/// 「データベース」→「変更の適用」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDatabaseSave_Click(object sender, EventArgs e) {
			UpdateSQL();
		}// End Function

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuWindowView_Click(object sender, EventArgs e) {
			TestForm Form2 = new TestForm();
			Form2.Show();
			//DataBindings();
		}// End Function

		//----------------------------------------------------------------------------------------------------
		// TAB: ユニット
	}// End Class
}
