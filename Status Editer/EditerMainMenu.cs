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

		//----------------------------------------------------------------------------------------------------
		// バインド
		// WeaponTable
		private __table_weaponTableAdapter WeaponAdapter = new __table_weaponTableAdapter();
		// 数が多いが、仕様なので仕方ない
		private GigaBattlerDataSet.__table_weaponDataTable WeaponTable_3_1 = new GigaBattlerDataSet.__table_weaponDataTable();
		private GigaBattlerDataSet.__table_weaponDataTable WeaponTable_3_2 = new GigaBattlerDataSet.__table_weaponDataTable();
		private GigaBattlerDataSet.__table_weaponDataTable WeaponTable_3_3 = new GigaBattlerDataSet.__table_weaponDataTable();
		private GigaBattlerDataSet.__table_weaponDataTable WeaponTable_3_4 = new GigaBattlerDataSet.__table_weaponDataTable();
		private GigaBattlerDataSet.__table_weaponDataTable WeaponTable_3_5 = new GigaBattlerDataSet.__table_weaponDataTable();
		// 素直にExcelを使った方が効率よさそうに見えてくる。冗談のように見えるが、仕様である。
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_01 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_02 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_03 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_04 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_05 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_06 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_07 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_08 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_09 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_10 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_11 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_12 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_13 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_14 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_15 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_16 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_17 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_18 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_19 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_20 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_21 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_22 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_23 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_24 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_25 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_26 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_27 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_28 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_29 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_30 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_31 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_32 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_33 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_34 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_35 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_36 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_37 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_38 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_39 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_40 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_41 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_42 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_43 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_44 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_45 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_46 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_47 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_48 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_49 = new GigaBattlerDataSet.__table_skillDataTable();
		private GigaBattlerDataSet.__table_skillDataTable SkillTable_3_50 = new GigaBattlerDataSet.__table_skillDataTable();

		
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public decimal Pool {
			get { return numericDropRate1.Value; }
			set { numericDropRate1.Value = value; }
		}


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
		// フォームメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void EditerMainMenu_Load(object sender, EventArgs e) {
			//----------------------------------------------------------------------------------------------------
			// デザイナープロパティの設定
			// できればデザイナープロパティに設定したいが、バグの関係でここで設定。
			// TAB: モンスター
			tabControlMonster.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
			listMonster.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			StatusInfomation.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
			groupDropInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
			groupSkillInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

			// データバインドの設定
			try {
				//----------------------------------------------------------------------------------------------------
				// バインド項目の設定
				// TAB: モンスター
				WeaponAdapter.Fill(WeaponTable_3_1);
				WeaponAdapter.Fill(WeaponTable_3_2);
				WeaponAdapter.Fill(WeaponTable_3_3);
				WeaponAdapter.Fill(WeaponTable_3_4);
				WeaponAdapter.Fill(WeaponTable_3_5);


				comboDropTable1.DataSource = WeaponTable_3_1;
				comboDropTable1.DisplayMember = "WeaponName";
				comboDropTable1.ValueMember = "WeaponID";
				comboDropTable2.DataSource = WeaponTable_3_2;
				comboDropTable2.DisplayMember = "WeaponName";
				comboDropTable2.ValueMember = "WeaponID";
				comboDropTable3.DataSource = WeaponTable_3_3;
				comboDropTable3.DisplayMember = "WeaponName";
				comboDropTable3.ValueMember = "WeaponID";
				comboDropTable4.DataSource = WeaponTable_3_4;
				comboDropTable4.DisplayMember = "WeaponName";
				comboDropTable4.ValueMember = "WeaponID";
				comboDropTable5.DataSource = WeaponTable_3_5;
				comboDropTable5.DisplayMember = "WeaponName";
				comboDropTable5.ValueMember = "WeaponID";

				// 別コントロールへのバインディング設定
				unitInfomation1.LoadDataBindings(tablemonsterBindingSource);
				StatusInfomation.LoadDataBindings(tablemonsterBindingSource);

				__table_monsterTableAdapter.Fill(GigaBattlerDataSet.@__table_monster);
				__table_weaponTableAdapter.Fill(GigaBattlerDataSet.@__table_weapon);
				__table_raceTableAdapter.Fill(GigaBattlerDataSet.@__table_race);
			} catch (Exception ex) {
				MessageBox.Show("System Load Failed:\n" + ex.ToString(), "Error!!");
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
			} catch (Exception em) {
				MessageBox.Show("Database Load Failed:\n" + em.ToString(), "Error!!");
			}
		}

		/// <summary>
		/// 「データベース」→「変更の適用」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDatabaseSave_Click(object sender, EventArgs e) {
			tablemonsterBindingSource.EndEdit();
			__table_monsterTableAdapter.Update(GigaBattlerDataSet.@__table_monster);
		}

		private void StripMenuWindowView_Click(object sender, EventArgs e) {
			TestForm Form2 = new TestForm();
			Form2.Show();
			//DataBindings();
		}
		//----------------------------------------------------------------------------------------------------
		// TAB: モンスター


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}
}
