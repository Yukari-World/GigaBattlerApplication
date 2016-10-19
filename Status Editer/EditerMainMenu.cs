using Status_Editer.GigaBattlerDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace Status_Editer {
	public partial class EditerMainMenu : Form {
		//Initialize
		public string rootDirectory = "";
		BindingSource f;

		__table_monsterTableAdapter dds = new __table_monsterTableAdapter();
		GigaBattlerDataSet.__table_monsterDataTable tbla = new GigaBattlerDataSet.__table_monsterDataTable();

		public EditerMainMenu() {
			InitializeComponent();
		}

		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void EditerMainMenu_Load(object sender, EventArgs e) {
			//データバインドの設定。UserControlはここでしか定義できない
			unitInfomation1.checkAirType.DataBindings.Add(new Binding("CheckState", tablemonsterBindingSource, "Air", true));
			unitInfomation1.checkAirType.DataBindings.Add(new Binding("Checked", tablemonsterBindingSource, "Air", true));
			unitInfomation1.textMonsterID.DataBindings.Add(new Binding("Text", tablemonsterBindingSource, "MonsterID", true));
			unitInfomation1.textUnitName.DataBindings.Add(new Binding("Text", tablemonsterBindingSource, "MonsterName", true));
			unitInfomation1.numericRare.DataBindings.Add(new Binding("Value", tablemonsterBindingSource, "Rare", true));
			//できればデザイナープロパティに設定したいが、バグの関係でここで設定
			tabControlMonster.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
			listMonster.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			groupStatusInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			groupDropInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
			groupSkillInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
			f = new BindingSource();
			f.DataSource = GigaBattlerDataSet;
			f.DataMember = "__table_weapon";
			try {
				__table_monsterTableAdapter.Fill(GigaBattlerDataSet.@__table_monster);
				__table_weaponTableAdapter.Fill(GigaBattlerDataSet.@__table_weapon);
				__table_raceTableAdapter.Fill(GigaBattlerDataSet.@__table_race);
			} catch (Exception em) {
				MessageBox.Show("System Load Failed:\n" + em.ToString(), "Error!!");
				Application.Exit();
			}
			StripInfo.Text = "Welcome!!";
		}

		/// <summary>
		/// 「ファイル」→「開く」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuFileOpen_Click(object sender, EventArgs e) {
			//http://dobon.net/vb/dotnet/form/folderdialog.htmlより参照
			//FolderBrowserDialogクラスのインスタンスを作成
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			//上部に表示する説明テキストを指定する
			fbd.Description = "Databaseフォルダを指定してください。";

			//ルートフォルダを指定する
			//デフォルトでDesktop
			fbd.RootFolder = Environment.SpecialFolder.Desktop;

			//最初に選択するフォルダを指定する
			//RootFolder以下にあるフォルダである必要がある
			fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

			//ユーザーが新しいフォルダを作成できるようにする
			//デフォルトでTrue
			fbd.ShowNewFolderButton = false;

			//ダイアログを表示する
			if (fbd.ShowDialog(this) == DialogResult.OK) {
				//選択されたフォルダを表示する
				rootDirectory = fbd.SelectedPath;
			}
		}

		/// <summary>
		/// 「ファイル」→「アプリケーションの終了」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuExit_Click(object sender, EventArgs e) {
			var result = MessageBox.Show("終了時にデータベースをアップデートしますか?", "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
			switch (result) {
				case DialogResult.Yes:
					break;
				case DialogResult.No:
					break;
				case DialogResult.Cancel:
					return;
			}
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
	}
}
