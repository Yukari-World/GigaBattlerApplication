using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_Editer {
	public partial class EditerMainMenu : Form {
		//Initialize
		public string rootDirectory = "";

		public EditerMainMenu() {
			InitializeComponent();
		}

		private void EditerMainMenu_Load(object sender, EventArgs e) {
			// TODO: このコード行はデータを 'gigaBattlerProtocol.monster_table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
			monster_tableTableAdapter.Fill(gigaBattlerProtocol.monster_table);
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
			fbd.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);

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
			Application.Exit();
		}

		/// <summary>
		/// 「データベース」→「変更の適用」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDatabaseSave_Click(object sender, EventArgs e) {
			monster_tableTableAdapter.Update(gigaBattlerProtocol.monster_table);
		}

		private void AirType_CheckedChanged(object sender, EventArgs e) {
			switch (AirType.Checked) {
				case true:

					break;
				case false:

					break;
			}
		}
	}
}
