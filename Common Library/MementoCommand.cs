//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// MementoCommand Class
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace CommonLibrary {
	/// <summary>
	/// 思い出更新コマンド
	/// </summary>
	/// <remarks>
	/// 以下のページより参照
	/// http://zecl.hatenablog.com/entry/20091002/p1
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	public sealed class MementoCommand<T1, T2> : ICommand {
		private Memento<T1, T2> _memento;
		private T1 _prev;
		private T1 _next;

		public MementoCommand(Memento<T1, T2> prev, Memento<T1, T2> next) {
			_memento = prev;
			_prev = prev.MementoData;
			_next = next.MementoData;
		}// End Method

		#region ICommand メンバ

		/// <summary>
		/// 呼び出し
		/// </summary>
		void ICommand.Invoke() {
			_prev = _memento.MementoData;
			_memento.SetMemento(_next);
		}// End Method

		/// <summary>
		/// 元に戻す
		/// </summary>
		void ICommand.Undo() {
			_memento.SetMemento(_prev);
		}// End Method

		/// <summary>
		/// やり直し
		/// </summary>
		void ICommand.Redo() {
			_memento.SetMemento(_next);
		}// End Method

		#endregion
	}// End Class

	/// <summary>
	/// CommandManager
	/// </summary>
	/// <remarks>
	/// 以下のページより参照
	/// http://zecl.hatenablog.com/entry/20091002/p1
	/// </remarks>
	public sealed class CommandManager {
		private int _maxStack = int.MaxValue;
		private Stack<ICommand> _undoStack;
		private Stack<ICommand> _redoStack;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CommandManager() {
			_undoStack = new Stack<ICommand>();
			_redoStack = new Stack<ICommand>();
		}// End Method

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="max">最大保存数</param>
		public CommandManager(int maxStack) : this() {
			_maxStack = maxStack;
		}// End Method

		/// <summary>
		/// 呼び出し
		/// </summary>
		/// <param name="command">コマンド</param>
		public bool Invoke(ICommand command) {
			if (_undoStack.Count >= _maxStack)
				return false;
			command.Invoke();
			_redoStack.Clear();
			_undoStack.Push(command);
			return true;
		}// End Method

		/// <summary>
		/// 元に戻す
		/// </summary>
		public void Undo() {
			if (_undoStack.Count == 0)
				return;
			var command = _undoStack.Pop();
			command.Undo();
			_redoStack.Push(command);
		}// End Method

		/// <summary>
		/// やり直し
		/// </summary>
		public void Redo() {
			if (_redoStack.Count == 0)
				return;
			var command = _redoStack.Pop();
			command.Redo();
			_undoStack.Push(command);
		}// End Method

		/// <summary>
		/// リフレッシュ
		/// </summary>
		public void Refresh() {
			_undoStack.Clear();
			_redoStack.Clear();
		}// End Method
	}// End Class
}
