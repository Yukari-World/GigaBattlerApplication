using CommonLibrary;
using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer {
	partial class FormJob {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.DataGridViewJob = new System.Windows.Forms.DataGridView();
			this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jobNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lUKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masterRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusRATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusRDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusMDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusSPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusLUKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusHITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bonusEVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.condition1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.condition2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.condition3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.condition4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.condition5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tablejobBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gigaBattlerDataSet = new CommonLibrary.GigaBattlerDataSet();
			this.___table_jobTableAdapter = new CommonLibrary.GigaBattlerDataSetTableAdapters.@__table_jobTableAdapter();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewJob)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablejobBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.DataGridViewJob);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1440, 785);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(1440, 810);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// DataGridViewJob
			// 
			this.DataGridViewJob.AutoGenerateColumns = false;
			this.DataGridViewJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIDDataGridViewTextBoxColumn,
            this.jobNameDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.tPDataGridViewTextBoxColumn,
            this.aTKDataGridViewTextBoxColumn,
            this.dEFDataGridViewTextBoxColumn,
            this.rATDataGridViewTextBoxColumn,
            this.rDFDataGridViewTextBoxColumn,
            this.mATDataGridViewTextBoxColumn,
            this.mDFDataGridViewTextBoxColumn,
            this.sPDDataGridViewTextBoxColumn,
            this.lUKDataGridViewTextBoxColumn,
            this.hITDataGridViewTextBoxColumn,
            this.eVTDataGridViewTextBoxColumn,
            this.skillDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.eXPDataGridViewTextBoxColumn,
            this.masterRankDataGridViewTextBoxColumn,
            this.maxRankDataGridViewTextBoxColumn,
            this.bonusHPDataGridViewTextBoxColumn,
            this.bonusTPDataGridViewTextBoxColumn,
            this.bonusATKDataGridViewTextBoxColumn,
            this.bonusDEFDataGridViewTextBoxColumn,
            this.bonusRATDataGridViewTextBoxColumn,
            this.bonusRDFDataGridViewTextBoxColumn,
            this.bonusMATDataGridViewTextBoxColumn,
            this.bonusMDFDataGridViewTextBoxColumn,
            this.bonusSPDDataGridViewTextBoxColumn,
            this.bonusLUKDataGridViewTextBoxColumn,
            this.bonusHITDataGridViewTextBoxColumn,
            this.bonusEVTDataGridViewTextBoxColumn,
            this.condition1DataGridViewTextBoxColumn,
            this.condition2DataGridViewTextBoxColumn,
            this.condition3DataGridViewTextBoxColumn,
            this.condition4DataGridViewTextBoxColumn,
            this.condition5DataGridViewTextBoxColumn});
			this.DataGridViewJob.DataSource = this.tablejobBindingSource;
			this.DataGridViewJob.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridViewJob.Location = new System.Drawing.Point(0, 0);
			this.DataGridViewJob.Name = "DataGridViewJob";
			this.DataGridViewJob.Size = new System.Drawing.Size(1440, 785);
			this.DataGridViewJob.TabIndex = 0;
			// 
			// jobIDDataGridViewTextBoxColumn
			// 
			this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
			this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
			this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
			// 
			// jobNameDataGridViewTextBoxColumn
			// 
			this.jobNameDataGridViewTextBoxColumn.DataPropertyName = "JobName";
			this.jobNameDataGridViewTextBoxColumn.HeaderText = "JobName";
			this.jobNameDataGridViewTextBoxColumn.Name = "jobNameDataGridViewTextBoxColumn";
			// 
			// hPDataGridViewTextBoxColumn
			// 
			this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
			this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
			this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
			// 
			// tPDataGridViewTextBoxColumn
			// 
			this.tPDataGridViewTextBoxColumn.DataPropertyName = "TP";
			this.tPDataGridViewTextBoxColumn.HeaderText = "TP";
			this.tPDataGridViewTextBoxColumn.Name = "tPDataGridViewTextBoxColumn";
			// 
			// aTKDataGridViewTextBoxColumn
			// 
			this.aTKDataGridViewTextBoxColumn.DataPropertyName = "ATK";
			this.aTKDataGridViewTextBoxColumn.HeaderText = "ATK";
			this.aTKDataGridViewTextBoxColumn.Name = "aTKDataGridViewTextBoxColumn";
			// 
			// dEFDataGridViewTextBoxColumn
			// 
			this.dEFDataGridViewTextBoxColumn.DataPropertyName = "DEF";
			this.dEFDataGridViewTextBoxColumn.HeaderText = "DEF";
			this.dEFDataGridViewTextBoxColumn.Name = "dEFDataGridViewTextBoxColumn";
			// 
			// rATDataGridViewTextBoxColumn
			// 
			this.rATDataGridViewTextBoxColumn.DataPropertyName = "RAT";
			this.rATDataGridViewTextBoxColumn.HeaderText = "RAT";
			this.rATDataGridViewTextBoxColumn.Name = "rATDataGridViewTextBoxColumn";
			// 
			// rDFDataGridViewTextBoxColumn
			// 
			this.rDFDataGridViewTextBoxColumn.DataPropertyName = "RDF";
			this.rDFDataGridViewTextBoxColumn.HeaderText = "RDF";
			this.rDFDataGridViewTextBoxColumn.Name = "rDFDataGridViewTextBoxColumn";
			// 
			// mATDataGridViewTextBoxColumn
			// 
			this.mATDataGridViewTextBoxColumn.DataPropertyName = "MAT";
			this.mATDataGridViewTextBoxColumn.HeaderText = "MAT";
			this.mATDataGridViewTextBoxColumn.Name = "mATDataGridViewTextBoxColumn";
			// 
			// mDFDataGridViewTextBoxColumn
			// 
			this.mDFDataGridViewTextBoxColumn.DataPropertyName = "MDF";
			this.mDFDataGridViewTextBoxColumn.HeaderText = "MDF";
			this.mDFDataGridViewTextBoxColumn.Name = "mDFDataGridViewTextBoxColumn";
			// 
			// sPDDataGridViewTextBoxColumn
			// 
			this.sPDDataGridViewTextBoxColumn.DataPropertyName = "SPD";
			this.sPDDataGridViewTextBoxColumn.HeaderText = "SPD";
			this.sPDDataGridViewTextBoxColumn.Name = "sPDDataGridViewTextBoxColumn";
			// 
			// lUKDataGridViewTextBoxColumn
			// 
			this.lUKDataGridViewTextBoxColumn.DataPropertyName = "LUK";
			this.lUKDataGridViewTextBoxColumn.HeaderText = "LUK";
			this.lUKDataGridViewTextBoxColumn.Name = "lUKDataGridViewTextBoxColumn";
			// 
			// hITDataGridViewTextBoxColumn
			// 
			this.hITDataGridViewTextBoxColumn.DataPropertyName = "HIT";
			this.hITDataGridViewTextBoxColumn.HeaderText = "HIT";
			this.hITDataGridViewTextBoxColumn.Name = "hITDataGridViewTextBoxColumn";
			// 
			// eVTDataGridViewTextBoxColumn
			// 
			this.eVTDataGridViewTextBoxColumn.DataPropertyName = "EVT";
			this.eVTDataGridViewTextBoxColumn.HeaderText = "EVT";
			this.eVTDataGridViewTextBoxColumn.Name = "eVTDataGridViewTextBoxColumn";
			// 
			// skillDataGridViewTextBoxColumn
			// 
			this.skillDataGridViewTextBoxColumn.DataPropertyName = "Skill";
			this.skillDataGridViewTextBoxColumn.HeaderText = "Skill";
			this.skillDataGridViewTextBoxColumn.Name = "skillDataGridViewTextBoxColumn";
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Class";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			// 
			// eXPDataGridViewTextBoxColumn
			// 
			this.eXPDataGridViewTextBoxColumn.DataPropertyName = "EXP";
			this.eXPDataGridViewTextBoxColumn.HeaderText = "EXP";
			this.eXPDataGridViewTextBoxColumn.Name = "eXPDataGridViewTextBoxColumn";
			// 
			// masterRankDataGridViewTextBoxColumn
			// 
			this.masterRankDataGridViewTextBoxColumn.DataPropertyName = "MasterRank";
			this.masterRankDataGridViewTextBoxColumn.HeaderText = "MasterRank";
			this.masterRankDataGridViewTextBoxColumn.Name = "masterRankDataGridViewTextBoxColumn";
			// 
			// maxRankDataGridViewTextBoxColumn
			// 
			this.maxRankDataGridViewTextBoxColumn.DataPropertyName = "MaxRank";
			this.maxRankDataGridViewTextBoxColumn.HeaderText = "MaxRank";
			this.maxRankDataGridViewTextBoxColumn.Name = "maxRankDataGridViewTextBoxColumn";
			// 
			// bonusHPDataGridViewTextBoxColumn
			// 
			this.bonusHPDataGridViewTextBoxColumn.DataPropertyName = "BonusHP";
			this.bonusHPDataGridViewTextBoxColumn.HeaderText = "BonusHP";
			this.bonusHPDataGridViewTextBoxColumn.Name = "bonusHPDataGridViewTextBoxColumn";
			// 
			// bonusTPDataGridViewTextBoxColumn
			// 
			this.bonusTPDataGridViewTextBoxColumn.DataPropertyName = "BonusTP";
			this.bonusTPDataGridViewTextBoxColumn.HeaderText = "BonusTP";
			this.bonusTPDataGridViewTextBoxColumn.Name = "bonusTPDataGridViewTextBoxColumn";
			// 
			// bonusATKDataGridViewTextBoxColumn
			// 
			this.bonusATKDataGridViewTextBoxColumn.DataPropertyName = "BonusATK";
			this.bonusATKDataGridViewTextBoxColumn.HeaderText = "BonusATK";
			this.bonusATKDataGridViewTextBoxColumn.Name = "bonusATKDataGridViewTextBoxColumn";
			// 
			// bonusDEFDataGridViewTextBoxColumn
			// 
			this.bonusDEFDataGridViewTextBoxColumn.DataPropertyName = "BonusDEF";
			this.bonusDEFDataGridViewTextBoxColumn.HeaderText = "BonusDEF";
			this.bonusDEFDataGridViewTextBoxColumn.Name = "bonusDEFDataGridViewTextBoxColumn";
			// 
			// bonusRATDataGridViewTextBoxColumn
			// 
			this.bonusRATDataGridViewTextBoxColumn.DataPropertyName = "BonusRAT";
			this.bonusRATDataGridViewTextBoxColumn.HeaderText = "BonusRAT";
			this.bonusRATDataGridViewTextBoxColumn.Name = "bonusRATDataGridViewTextBoxColumn";
			// 
			// bonusRDFDataGridViewTextBoxColumn
			// 
			this.bonusRDFDataGridViewTextBoxColumn.DataPropertyName = "BonusRDF";
			this.bonusRDFDataGridViewTextBoxColumn.HeaderText = "BonusRDF";
			this.bonusRDFDataGridViewTextBoxColumn.Name = "bonusRDFDataGridViewTextBoxColumn";
			// 
			// bonusMATDataGridViewTextBoxColumn
			// 
			this.bonusMATDataGridViewTextBoxColumn.DataPropertyName = "BonusMAT";
			this.bonusMATDataGridViewTextBoxColumn.HeaderText = "BonusMAT";
			this.bonusMATDataGridViewTextBoxColumn.Name = "bonusMATDataGridViewTextBoxColumn";
			// 
			// bonusMDFDataGridViewTextBoxColumn
			// 
			this.bonusMDFDataGridViewTextBoxColumn.DataPropertyName = "BonusMDF";
			this.bonusMDFDataGridViewTextBoxColumn.HeaderText = "BonusMDF";
			this.bonusMDFDataGridViewTextBoxColumn.Name = "bonusMDFDataGridViewTextBoxColumn";
			this.bonusMDFDataGridViewTextBoxColumn.Width = 86;
			// 
			// bonusSPDDataGridViewTextBoxColumn
			// 
			this.bonusSPDDataGridViewTextBoxColumn.DataPropertyName = "BonusSPD";
			this.bonusSPDDataGridViewTextBoxColumn.HeaderText = "BonusSPD";
			this.bonusSPDDataGridViewTextBoxColumn.Name = "bonusSPDDataGridViewTextBoxColumn";
			// 
			// bonusLUKDataGridViewTextBoxColumn
			// 
			this.bonusLUKDataGridViewTextBoxColumn.DataPropertyName = "BonusLUK";
			this.bonusLUKDataGridViewTextBoxColumn.HeaderText = "BonusLUK";
			this.bonusLUKDataGridViewTextBoxColumn.Name = "bonusLUKDataGridViewTextBoxColumn";
			// 
			// bonusHITDataGridViewTextBoxColumn
			// 
			this.bonusHITDataGridViewTextBoxColumn.DataPropertyName = "BonusHIT";
			this.bonusHITDataGridViewTextBoxColumn.HeaderText = "BonusHIT";
			this.bonusHITDataGridViewTextBoxColumn.Name = "bonusHITDataGridViewTextBoxColumn";
			// 
			// bonusEVTDataGridViewTextBoxColumn
			// 
			this.bonusEVTDataGridViewTextBoxColumn.DataPropertyName = "BonusEVT";
			this.bonusEVTDataGridViewTextBoxColumn.HeaderText = "BonusEVT";
			this.bonusEVTDataGridViewTextBoxColumn.Name = "bonusEVTDataGridViewTextBoxColumn";
			// 
			// condition1DataGridViewTextBoxColumn
			// 
			this.condition1DataGridViewTextBoxColumn.DataPropertyName = "Condition1";
			this.condition1DataGridViewTextBoxColumn.HeaderText = "Condition1";
			this.condition1DataGridViewTextBoxColumn.Name = "condition1DataGridViewTextBoxColumn";
			// 
			// condition2DataGridViewTextBoxColumn
			// 
			this.condition2DataGridViewTextBoxColumn.DataPropertyName = "Condition2";
			this.condition2DataGridViewTextBoxColumn.HeaderText = "Condition2";
			this.condition2DataGridViewTextBoxColumn.Name = "condition2DataGridViewTextBoxColumn";
			// 
			// condition3DataGridViewTextBoxColumn
			// 
			this.condition3DataGridViewTextBoxColumn.DataPropertyName = "Condition3";
			this.condition3DataGridViewTextBoxColumn.HeaderText = "Condition3";
			this.condition3DataGridViewTextBoxColumn.Name = "condition3DataGridViewTextBoxColumn";
			// 
			// condition4DataGridViewTextBoxColumn
			// 
			this.condition4DataGridViewTextBoxColumn.DataPropertyName = "Condition4";
			this.condition4DataGridViewTextBoxColumn.HeaderText = "Condition4";
			this.condition4DataGridViewTextBoxColumn.Name = "condition4DataGridViewTextBoxColumn";
			// 
			// condition5DataGridViewTextBoxColumn
			// 
			this.condition5DataGridViewTextBoxColumn.DataPropertyName = "Condition5";
			this.condition5DataGridViewTextBoxColumn.HeaderText = "Condition5";
			this.condition5DataGridViewTextBoxColumn.Name = "condition5DataGridViewTextBoxColumn";
			// 
			// tablejobBindingSource
			// 
			this.tablejobBindingSource.DataMember = "__table_job";
			this.tablejobBindingSource.DataSource = this.gigaBattlerDataSet;
			// 
			// gigaBattlerDataSet
			// 
			this.gigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.gigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ___table_jobTableAdapter
			// 
			this.___table_jobTableAdapter.ClearBeforeFill = true;
			// 
			// FormJob
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 810);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "FormJob";
			this.Text = "Job Table";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJob_FormClosed);
			this.Load += new System.EventHandler(this.FormJob_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewJob)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablejobBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolStripContainer toolStripContainer1;
		private DataGridView DataGridViewJob;
		private GigaBattlerDataSet gigaBattlerDataSet;
		private BindingSource tablejobBindingSource;
		private CommonLibrary.GigaBattlerDataSetTableAdapters.__table_jobTableAdapter ___table_jobTableAdapter;
		private DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn jobNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn tPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn aTKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rATDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rDFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mATDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mDFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sPDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lUKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hITDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn eVTDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skillDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn eXPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn masterRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn maxRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusHPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusTPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusATKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusDEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusRATDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusRDFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusMATDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusMDFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusSPDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusLUKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusHITDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bonusEVTDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn condition1DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn condition2DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn condition3DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn condition4DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn condition5DataGridViewTextBoxColumn;
	}
}