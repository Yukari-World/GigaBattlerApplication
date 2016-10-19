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
	public partial class TestForm : Form {
		public TestForm() {
			InitializeComponent();
		}

		private void TestForm_Load(object sender, EventArgs e) {
			// TODO: このコード行はデータを 'gigaBattlerDataSet.__table_monster' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
			this.___table_monsterTableAdapter.Fill(this.gigaBattlerDataSet.@__table_monster);

		}
	}
}
