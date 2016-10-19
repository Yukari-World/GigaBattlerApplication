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
		public string rootdirectory = "";

		public EditerMainMenu() {
			InitializeComponent();
		}

		private void EditerMainMenu_Load(object sender, EventArgs e) {
			// TODO: このコード行はデータを 'gigaBattlerProtocol.monster_table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
			this.monster_tableTableAdapter.Fill(this.gigaBattlerProtocol.monster_table);
		}

		/// <summary>
		/// 「ファイル」→「開く」の処理内容
		/// </summary>
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
				rootdirectory = fbd.SelectedPath;
			}
		}
	}
}
