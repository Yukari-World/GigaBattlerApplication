﻿//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Editer Main Menu
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using Status_Editer.GigaBattlerDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer {
	public partial class EditerMainMenu : Form {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		// 変数
		public string rootDirectory = "";

		// TableAdapter
		__table_unitTableAdapter tableUnitTableAdapter = new __table_unitTableAdapter();
		__table_raceTableAdapter tableRaceTableAdapter = new __table_raceTableAdapter();
		__table_jobTableAdapter tableJobTableAdapter = new __table_jobTableAdapter();
		__table_weaponTableAdapter tableWeaponTableAdapter = new __table_weaponTableAdapter();
		__table_shieldTableAdapter tableShieldTableAdapter = new __table_shieldTableAdapter();
		__table_gauntletTableAdapter tableGauntletTableAdapter = new __table_gauntletTableAdapter();
		__table_helmetTableAdapter tableHelmetTableAdapter = new __table_helmetTableAdapter();
		__table_armorTableAdapter tableArmorTableAdapter = new __table_armorTableAdapter();
		__table_accessoryTableAdapter tableAccessoryTableAdapter = new __table_accessoryTableAdapter();
		__table_skillTableAdapter tableSkillTableAdapter = new __table_skillTableAdapter();

		// BindingSource
		BindingSource tableUnitBindingSource = new BindingSource();
		BindingSource tableRaceBindingSource = new BindingSource();
		BindingSource tableJobBindingSource = new BindingSource();
		BindingSource tableArmorBingingSource = new BindingSource();


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public EditerMainMenu() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Function
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// 変更した更新内容を適用します。
		/// </summary>
		private void UpdateSQL() {
			tableUnitBindingSource.EndEdit();
			tableUnitTableAdapter.Update(GigaBattlerDataSet.@__table_unit);
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// フォーム読み込み時の処理
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void EditerMainMenu_Load(object sender, EventArgs e) {
			//----------------------------------------------------------------------------------------------------
			// 初期化

			tableUnitTableAdapter.ClearBeforeFill = true;
			tableRaceTableAdapter.ClearBeforeFill = true;
			tableJobTableAdapter.ClearBeforeFill = true;
			tableWeaponTableAdapter.ClearBeforeFill = true;
			tableShieldTableAdapter.ClearBeforeFill = true;
			tableGauntletTableAdapter.ClearBeforeFill = true;
			tableHelmetTableAdapter.ClearBeforeFill = true;
			tableArmorTableAdapter.ClearBeforeFill = true;
			tableAccessoryTableAdapter.ClearBeforeFill = true;
			tableSkillTableAdapter.ClearBeforeFill = true;

			//----------------------------------------------------------------------------------------------------
			// バインド項目の関連付け

			tableUnitBindingSource.DataMember = "__table_unit";
			tableUnitBindingSource.DataSource = GigaBattlerDataSet;
			tableRaceBindingSource.DataMember = "__table_race";
			tableRaceBindingSource.DataSource = GigaBattlerDataSet;
			tableJobBindingSource.DataMember = "__table_job";
			tableJobBindingSource.DataSource = GigaBattlerDataSet;
			tableArmorBingingSource.DataMember = "__table_armor";
			tableArmorBingingSource.DataSource = GigaBattlerDataSet;

			//----------------------------------------------------------------------------------------------------
			// デザイナープロパティの設定
			// できればデザイナープロパティに設定したいが、バグの関係でここで設定。
			// TAB: ユニット

			listUnit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			tabControlUnit.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

			// TAB: 種族

			listRace.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

			// TAB: ジョブ

			listJob.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

			// TAB: メーカー
			// TAB: 武器
			// TAB: 盾
			// TAB: 頭防具
			// TAB: 腕防具
			// TAB: 体防具

			//----------------------------------------------------------------------------------------------------
			// バインド項目の設定

			listUnit.DataSource = tableUnitBindingSource;
			listUnit.DisplayMember = "UnitName";
			listUnit.ValueMember = "UnitID";

			listRace.DataSource = tableRaceBindingSource;
			listRace.DisplayMember = "RaceName";
			listRace.ValueMember = "RaceID";

			listJob.DataSource = tableJobBindingSource;
			listJob.DisplayMember = "JobName";
			listJob.ValueMember = "JobID";

			try {
				// 別コントロールへのバインディング設定
				// TAB: ユニット

				TotalUnitInfomation.LoadDataBindings(tableUnitBindingSource);
				UnitInfomation.LoadDataBindings(tableUnitBindingSource);
				DropInfomation.LoadDataBindings(tableUnitBindingSource, tableWeaponTableAdapter, tableShieldTableAdapter, tableHelmetTableAdapter, tableGauntletTableAdapter, tableArmorTableAdapter, tableAccessoryTableAdapter);
				StatusInfomation.LoadDataBindings(tableUnitBindingSource);
				ActiveSkillInfomation.LoadDataBindings(tableUnitBindingSource, tableSkillTableAdapter);

				// TAB: ユニットタイプ

				// NULL

				// TAB: 種族

				RaceInfomation.LoadDataBindings(tableRaceBindingSource);

				// TAB: ジョブ

				JobInfomation.LoadDataBindings(tableJobBindingSource);

				// TAB: メーカー
				// TAB: 武器
				// TAB: 盾
				// TAB: 頭防具
				// TAB: 腕防具
				// TAB: 体防具

				// 共通

				tableUnitTableAdapter.Fill(GigaBattlerDataSet.@__table_unit);
				tableRaceTableAdapter.Fill(GigaBattlerDataSet.@__table_race);
				tableJobTableAdapter.Fill(GigaBattlerDataSet.@__table_job);
				tableWeaponTableAdapter.Fill(GigaBattlerDataSet.@__table_weapon);
				tableShieldTableAdapter.Fill(GigaBattlerDataSet.@__table_shield);
				tableGauntletTableAdapter.Fill(GigaBattlerDataSet.@__table_gauntlet);
				tableHelmetTableAdapter.Fill(GigaBattlerDataSet.@__table_helmet);
				tableArmorTableAdapter.Fill(GigaBattlerDataSet.@__table_armor);
				tableAccessoryTableAdapter.Fill(GigaBattlerDataSet.@__table_accessory);
				tableSkillTableAdapter.Fill(GigaBattlerDataSet.@__table_skill);
			} catch (Exception ex) {
				MessageBox.Show("System Load Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				Dispose();
				Application.Exit();
			}// End Try

			StripInfo.Text = "Welcome!!";
		}// End Function

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
			}// End If
		}// End Function

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
			Close();
			Application.Exit();
		}// End Function

		/// <summary>
		/// 「データベース」→「再読み込み」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDatabaseReload_Click(object sender, EventArgs e) {
			if (MessageBox.Show("データベースの再読み込みをします。保存されていない変更内容は失われてしまいますが、よろしいですか?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
				// 処理軽減のため画面更新を止める
				tabControl.Invalidate(true);

				try {
					tableUnitTableAdapter.Fill(GigaBattlerDataSet.@__table_unit);
					tableRaceTableAdapter.Fill(GigaBattlerDataSet.@__table_race);
					tableJobTableAdapter.Fill(GigaBattlerDataSet.@__table_job);
					tableWeaponTableAdapter.Fill(GigaBattlerDataSet.@__table_weapon);
					tableShieldTableAdapter.Fill(GigaBattlerDataSet.@__table_shield);
					tableGauntletTableAdapter.Fill(GigaBattlerDataSet.@__table_gauntlet);
					tableHelmetTableAdapter.Fill(GigaBattlerDataSet.@__table_helmet);
					tableArmorTableAdapter.Fill(GigaBattlerDataSet.@__table_armor);
					tableAccessoryTableAdapter.Fill(GigaBattlerDataSet.@__table_accessory);
					tableSkillTableAdapter.Fill(GigaBattlerDataSet.@__table_skill);
				} catch (Exception ex) {
					MessageBox.Show("Database Load Failed:\n" + ex.InnerException + "\n" + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}// End Try
			}// End If
		}// End Function

		/// <summary>
		/// 「データベース」→「変更の適用」の処理内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuDatabaseSave_Click(object sender, EventArgs e) {
			UpdateSQL();
		}// End Function

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void StripMenuWindowView_Click(object sender, EventArgs e) {
			TestForm Form2 = new TestForm();
			Form2.Show();
			//DataBindings();
		}// End Function

		//----------------------------------------------------------------------------------------------------
		// TAB

		/// <summary>
		/// TAB変更時に発生する内容
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
			// 処理軽減のため画面更新を止める
			tabControl.Invalidate(true);
		}// End Function

		//----------------------------------------------------------------------------------------------------
		// TAB: ユニット
	}// End Class
}
