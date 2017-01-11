using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer {
	partial class FormMaker {
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
			this.DataGridViewMaker = new System.Windows.Forms.DataGridView();
			this.tablemakerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gigaBattlerDataSet = new Status_Editer.GigaBattlerDataSet();
			this.___table_makerTableAdapter = new Status_Editer.GigaBattlerDataSetTableAdapters.@__table_makerTableAdapter();
			this.makerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sHitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.criticalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.blurringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewMaker)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablemakerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.DataGridViewMaker);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1440, 785);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(1440, 810);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// DataGridViewMaker
			// 
			this.DataGridViewMaker.AutoGenerateColumns = false;
			this.DataGridViewMaker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makerIDDataGridViewTextBoxColumn,
            this.makerNameDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.sHitDataGridViewTextBoxColumn,
            this.criticalDataGridViewTextBoxColumn,
            this.blurringDataGridViewTextBoxColumn,
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
            this.infoDataGridViewTextBoxColumn});
			this.DataGridViewMaker.DataSource = this.tablemakerBindingSource;
			this.DataGridViewMaker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridViewMaker.Location = new System.Drawing.Point(0, 0);
			this.DataGridViewMaker.Name = "DataGridViewMaker";
			this.DataGridViewMaker.Size = new System.Drawing.Size(1440, 785);
			this.DataGridViewMaker.TabIndex = 0;
			// 
			// tablemakerBindingSource
			// 
			this.tablemakerBindingSource.DataMember = "__table_maker";
			this.tablemakerBindingSource.DataSource = this.gigaBattlerDataSet;
			// 
			// gigaBattlerDataSet
			// 
			this.gigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.gigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ___table_makerTableAdapter
			// 
			this.___table_makerTableAdapter.ClearBeforeFill = true;
			// 
			// makerIDDataGridViewTextBoxColumn
			// 
			this.makerIDDataGridViewTextBoxColumn.DataPropertyName = "MakerID";
			this.makerIDDataGridViewTextBoxColumn.HeaderText = "MakerID";
			this.makerIDDataGridViewTextBoxColumn.Name = "makerIDDataGridViewTextBoxColumn";
			// 
			// makerNameDataGridViewTextBoxColumn
			// 
			this.makerNameDataGridViewTextBoxColumn.DataPropertyName = "MakerName";
			this.makerNameDataGridViewTextBoxColumn.HeaderText = "MakerName";
			this.makerNameDataGridViewTextBoxColumn.Name = "makerNameDataGridViewTextBoxColumn";
			// 
			// powerDataGridViewTextBoxColumn
			// 
			this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
			this.powerDataGridViewTextBoxColumn.HeaderText = "Power";
			this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
			// 
			// sHitDataGridViewTextBoxColumn
			// 
			this.sHitDataGridViewTextBoxColumn.DataPropertyName = "SHit";
			this.sHitDataGridViewTextBoxColumn.HeaderText = "SHit";
			this.sHitDataGridViewTextBoxColumn.Name = "sHitDataGridViewTextBoxColumn";
			// 
			// criticalDataGridViewTextBoxColumn
			// 
			this.criticalDataGridViewTextBoxColumn.DataPropertyName = "Critical";
			this.criticalDataGridViewTextBoxColumn.HeaderText = "Critical";
			this.criticalDataGridViewTextBoxColumn.Name = "criticalDataGridViewTextBoxColumn";
			// 
			// blurringDataGridViewTextBoxColumn
			// 
			this.blurringDataGridViewTextBoxColumn.DataPropertyName = "Blurring";
			this.blurringDataGridViewTextBoxColumn.HeaderText = "Blurring";
			this.blurringDataGridViewTextBoxColumn.Name = "blurringDataGridViewTextBoxColumn";
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
			// infoDataGridViewTextBoxColumn
			// 
			this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
			this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
			this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
			// 
			// FormMaker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 810);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "FormMaker";
			this.Text = "Maker Table";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMaker_FormClosed);
			this.Load += new System.EventHandler(this.FormMaker_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewMaker)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablemakerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolStripContainer toolStripContainer1;
		private DataGridView DataGridViewMaker;
		private GigaBattlerDataSet gigaBattlerDataSet;
		private BindingSource tablemakerBindingSource;
		private GigaBattlerDataSetTableAdapters.__table_makerTableAdapter ___table_makerTableAdapter;
		private DataGridViewTextBoxColumn makerIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn makerNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sHitDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn criticalDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn blurringDataGridViewTextBoxColumn;
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
		private DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
	}
}