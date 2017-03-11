//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Job Infomation
//
// Programed By Yukari-World
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using System.Windows.Forms;
using static CommonLibrary.GigaBattlerDataSet;
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
		// Property
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Constructor Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// コンストラクタメソッド
		/// </summary>
		public JobInfomation() {
			InitializeComponent();
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Pubilc Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// DataTableの設定をします。外部から引数を利用することでコントロール側に持ってこれることが判明。
		/// </summary>
		/// <param name="TableJobDataTable">Job Data Table</param>
		public void LoadDataBindings(__table_jobDataTable TableJobDataTable) {
			// データバインドの設定
			JobStatusHP.SetDataBindings(TableJobDataTable, "HP");
			JobStatusTP.SetDataBindings(TableJobDataTable, "TP");
			JobStatusMeleeATK.SetDataBindings(TableJobDataTable, "ATK");
			JobStatusMeleeDEF.SetDataBindings(TableJobDataTable, "DEF");
			JobStatusRangeATK.SetDataBindings(TableJobDataTable, "RAT");
			JobStatusRangeDEF.SetDataBindings(TableJobDataTable, "RDF");
			JobStatusMagicATK.SetDataBindings(TableJobDataTable, "MAT");
			JobStatusMagicDEF.SetDataBindings(TableJobDataTable, "MDF");
			JobStatusSPD.SetDataBindings(TableJobDataTable, "SPD");
			JobStatusLuck.SetDataBindings(TableJobDataTable, "LUK");
			JobStatusHIT.SetDataBindings(TableJobDataTable, "HIT");
			JobStatusEVT.SetDataBindings(TableJobDataTable, "EVT");

			//----------------------------------------------------------------------------------------------------
			// デザイナーの設定

			Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Private Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// 総ステータスコストを計算します
		/// </summary>
		private void CalcStatusCost() {
			sumCost = 0;
			for (int i = 0; i < StatusCost.Length; i++) {
				sumCost += StatusCost[i];
			}// End Loop
		}// End Method


		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		// Control Method
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// HPのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusHP_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[0] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// TPのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusTP_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[1] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// Melee ATKのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusMeleeATK_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[2] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// Melee DEFのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusMeleeDEF_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[3] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// Range ATKのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusRangeATK_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[4] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// Range DEFのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusRangeDEF_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[5] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// Magic ATKのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusMagicATK_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[6] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// Magic DEFのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusMagicDEF_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[7] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// SPDのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusSPD_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[8] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// LuckのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusLuck_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[9] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// HITのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusHIT_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[10] = e.Value;
			CalcStatusCost();
		}// End Method

		/// <summary>
		/// EVTのStatus Costが変更された時に発生するイベント
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgsとJobStatusBasicParts StatusCostの値Value</param>
		private void JobStatusEVT_CostMultiplierChanged(object sender, NumEventArgs e) {
			StatusCost[11] = e.Value;
			CalcStatusCost();
		}// End Method
	}// End Class
}
