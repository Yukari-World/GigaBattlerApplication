﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// ICommand Interface
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace CommonLibrary {
	/// <summary>
	/// ICommandインターフェイス
	/// 基本的にはこの形に収まるようだ
	/// </summary>
	/// <remarks>
	/// 以下のページより参照
	/// http://zecl.hatenablog.com/entry/20091002/p1
	/// </remarks>
	public interface ICommand {
		/// <summary>
		/// 呼び出し
		/// </summary>
		void Invoke();

		/// <summary>
		/// 元に戻す
		/// </summary>
		void Undo();

		/// <summary>
		/// やり直し
		/// </summary>
		void Redo();
	}// End Interface
}
