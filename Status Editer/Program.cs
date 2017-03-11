//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Program Main
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace Status_Editer {
	static class Program {
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		/// <remarks>
		/// 以下のページより参照
		/// http://dobon.net/vb/dotnet/process/checkprevinstance.html
		/// </remarks>
		[STAThread]
		static void Main() {
			//Mutex名を決める（必ずアプリケーション固有の文字列に変更すること！）
			string mutexName = "Giga Battler Status Editer";
			//Mutexオブジェクトを作成する
			System.Threading.Mutex mutex = new System.Threading.Mutex(false, mutexName);

			bool hasHandle = false;
			try {
				try {
					//ミューテックスの所有権を要求する
					hasHandle = mutex.WaitOne(0, false);
				}
				//.NET Framework 2.0以降の場合
				catch (System.Threading.AbandonedMutexException) {
					//別のアプリケーションがミューテックスを解放しないで終了した時
					hasHandle = true;
				}// End Try
				 //ミューテックスを得られたか調べる
				if (hasHandle == false) {
					//得られなかった場合は、すでに起動していると判断して終了
					// MessageBox.Show("多重起動はできません。");
					return;
				}// End If
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new EditerMainMenu());
			} finally {
				if (hasHandle) {
					//ミューテックスを解放する
					mutex.ReleaseMutex();
				}// End If
				mutex.Close();
			}// End Try
		}// End Main
	}// End Class
}
