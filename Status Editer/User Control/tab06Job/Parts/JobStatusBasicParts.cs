﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Job Status Basic Parts
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab06Job.Parts {
	public partial class JobStatusBasicParts : UserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// private変数へのアクセス
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// [ReadOnly]Basic Statusの値を返します
		/// </summary>
		public decimal basicStatus {
			get {
				return numericBasicStatus.Value;
			}
		}

		/// <summary>
		/// [R/W]グループラベルのテキストを設定します。
		/// </summary>
		public string labelText {
			get { return groupBase.Text; }
			set { groupBase.Text = value; }
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public JobStatusBasicParts() {
			InitializeComponent();
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableJobBindingSource">BindingSource</param>
		/// <param name="bindTag">Status Tag</param>
		public void LoadDataBindings(BindingSource tableJobBindingSource, string bindTag) {
			// データバインドの設定
			//numericBase.DataBindings.Add(new Binding("Value", tableJobBindingSource, bindTag, true));
			//numericLvPStatus.DataBindings.Add(new Binding("Value", tableJobBindingSource, "Lv" + bindTag, true));

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	}
}
