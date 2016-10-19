//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// EditerMainMenu
//
// Edited By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace Status_Editer {
	public partial class EditerMainMenu : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// 変数
		public string rootDirectory = "";
		// TableAdapter
		__table_monsterTableAdapter __table_monsterTableAdapter = new __table_monsterTableAdapter();
		__table_raceTableAdapter __table_raceTableAdapter = new __table_raceTableAdapter();
		__table_weaponTableAdapter __table_weaponTableAdapter = new __table_weaponTableAdapter();
		__table_shieldTableAdapter __table_shieldTableAdapter = new __table_shieldTableAdapter();
		__table_helmetTableAdapter __table_helmetTableAdapter = new __table_helmetTableAdapter();
		__table_armorTableAdapter __table_armorTableAdapter = new __table_armorTableAdapter();
		__table_accessoryTableAdapter __table_accessoryTableAdapter = new __table_accessoryTableAdapter();
		__table_skillTableAdapter __table_skillTableAdapter = new __table_skillTableAdapter();
		// BindingSource
		BindingSource tableMonsterBindingSource = new BindingSource();
		BindingSource tableRaceBindingSource = new BindingSource();
		BindingSource tableArmorBingingSource = new BindingSource();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public EditerMainMenu() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// 変更した更新内容を適用します。
		/// </summary>
		private void UpdateSQL() {
			tableMonsterBindingSource.EndEdit();
			__table_monsterTableAdapter.Update(GigaBattlerDataSet.@__table_monster);
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void EditerMainMenu_Load(object sender, EventArgs e) {
			//----------------------------------------------------------------------------------------------------
			// 初期化
			__table_monsterTableAdapter.ClearBeforeFill = true;
			__table_raceTableAdapter.ClearBeforeFill = true;
			__table_weaponTableAdapter.ClearBeforeFill = true;
			__table_shieldTableAdapter.ClearBeforeFill = true;
			__table_helmetTableAdapter.ClearBeforeFill = true;
			__table_armorTableAdapter.ClearBeforeFill = true;
			__table_accessoryTableAdapter.ClearBeforeFill = true;
			__table_skillTableAdapter.ClearBeforeFill = true;

			//----------------------------------------------------------------------------------------------------
			// バインド項目の関連付け
			tableMonsterBindingSource.DataMember = "__table_monster";
			tableMonsterBindingSource.DataSource = GigaBattlerDataSet;
			tableRaceBindingSource.DataMember = "__table_race";
			tableRaceBindingSource.DataSource = GigaBattlerDataSet;
			tableArmorBingingSource.DataMember = "__table_armor";
			tableArmorBingingSource.DataSource = GigaBattlerDataSet;

			//----------------------------------------------------------------------------------------------------
			// デザイナープロパティの設定
			// できればデザイナープロパティに設定したいが、バグの関係でここで設定。
			// TAB: ユニット
			listUnit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			tabControlUnit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

			//----------------------------------------------------------------------------------------------------
			// バインド項目の設定
			listUnit.DataSource = tableMonsterBindingSource;
			listUnit.DisplayMember = "MonsterName";
			listUnit.ValueMember = "MonsterID";

			listRace.DataSource = tableRaceBindingSource;
			listRace.DisplayMember = "RaceName";
			listRace.ValueMember = "RaceID";

			try {
				// 別コントロールへのバインディング設定
				TotalUnitInfomation.LoadDataBindings(tableMonsterBindingSource);
				UnitInfomation.LoadDataBindings(tableMonsterBindingSource);
				DropInfomation.LoadDataBindings(tableMonsterBindingSource, __table_weaponTableAdapter);
				StatusInfomation.LoadDataBindings(tableMonsterBindingSource);
				ActiveSkillInfomation.LoadDataBindings(tableMonsterBindingSource, __table_skillTableAdapter);

				__table_monsterTableAdapter.Fill(GigaBattlerDataSet.@__table_monster);
				__table_weaponTableAdapter.Fill(GigaBattlerDataSet.@__table_weapon);
				__table_raceTableAdapter.Fill(GigaBattlerDataSet.@__table_race);
				__table_skillTableAdapter.Fill(GigaBattlerDataSet.@__table_skill);
			} catch (Exception ex) {
				MessageBox.Show("System Load Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}

			StripInfo.Text = "Welcome!!";
		}

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
			}
		}

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
			Application.Exit();
		}

		/// <summary>
		/// 「データベース」→「再読み込み」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDatabaseReload_Click(object sender, EventArgs e) {
			try {
				__table_monsterTableAdapter.Fill(GigaBattlerDataSet.@__table_monster);
				__table_weaponTableAdapter.Fill(GigaBattlerDataSet.@__table_weapon);
				__table_raceTableAdapter.Fill(GigaBattlerDataSet.@__table_race);
				__table_skillTableAdapter.Fill(GigaBattlerDataSet.@__table_skill);
			} catch (Exception ex) {
				MessageBox.Show("Database Load Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 「データベース」→「変更の適用」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDatabaseSave_Click(object sender, EventArgs e) {
			UpdateSQL();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuWindowView_Click(object sender, EventArgs e) {
			TestForm Form2 = new TestForm();
			Form2.Show();
			//DataBindings();
		}

		//----------------------------------------------------------------------------------------------------
		// TAB: ユニット
	}
}
