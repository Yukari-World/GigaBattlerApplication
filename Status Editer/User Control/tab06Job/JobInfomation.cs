//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Job Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Status_Editer.User_Control.tab06Job.Parts.JobStatusBasicParts;

namespace Status_Editer.User_Control.tab06Job {
	[ToolboxItem(true)]
	public partial class JobInfomation : ZUserControl {
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Initialize
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		private int sumCost;
		private int[] StatusCost = new int[12];


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プロパティ
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コンストラクタメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public JobInfomation() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// パブリック関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataBindingsの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="tableJobBindingSource">BindingSource</param>
		public void LoadDataBindings(BindingSource tableJobBindingSource) {
			// データバインドの設定
			JobStatusHP.SetDataBindings(tableJobBindingSource, "HP");
			JobStatusTP.SetDataBindings(tableJobBindingSource, "TP");
			JobStatusMeleeATK.SetDataBindings(tableJobBindingSource, "ATK");
			JobStatusMeleeDEF.SetDataBindings(tableJobBindingSource, "DEF");
			JobStatusRangeATK.SetDataBindings(tableJobBindingSource, "RAT");
			JobStatusRangeDEF.SetDataBindings(tableJobBindingSource, "RDF");
			JobStatusMagicATK.SetDataBindings(tableJobBindingSource, "MAT");
			JobStatusMagicDEF.SetDataBindings(tableJobBindingSource, "MDF");
			JobStatusSPD.SetDataBindings(tableJobBindingSource, "SPD");
			JobStatusLuck.SetDataBindings(tableJobBindingSource, "LUK");
			JobStatusHIT.SetDataBindings(tableJobBindingSource, "HIT");
			JobStatusEVT.SetDataBindings(tableJobBindingSource, "EVT");

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// プライベート関数
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// 総ステータスコストを計算します
		/// </summary>
		private void CalcStatusCost() {
			sumCost = 0;
			for (int i = 0; i < StatusCost.Length; i++) {
				sumCost += StatusCost[i];
			}// End Loop
		}// End Function


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// コントロールメソッド
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// HPのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusHP_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[0] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// TPのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusTP_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[1] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// Melee ATKのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusMeleeATK_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[2] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// Melee DEFのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusMeleeDEF_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[3] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// Range ATKのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusRangeATK_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[4] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// Range DEFのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusRangeDEF_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[5] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// Magic ATKのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusMagicATK_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[6] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// Magic DEFのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusMagicDEF_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[7] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// SPDのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusSPD_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[8] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// LuckのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusLuck_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[9] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// HITのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusHIT_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[10] = e.Value;
			CalcStatusCost();
		}// End Function

		/// <summary>
		/// EVTのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusEVT_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[11] = e.Value;
			CalcStatusCost();
		}// End Function
	}// End Class
}
