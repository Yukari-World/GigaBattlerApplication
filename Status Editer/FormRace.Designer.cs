using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer {
	partial class FormRace {
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
			this.DataGridViewRace = new System.Windows.Forms.DataGridView();
			this.tableraceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gigaBattlerDataSet = new Status_Editer.GigaBattlerDataSet();
			this.___table_raceTableAdapter = new Status_Editer.GigaBattlerDataSetTableAdapters.@__table_raceTableAdapter();
			this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.raceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.raceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.lvHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvRATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvRDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvMDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvSPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvLUKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvHITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvEVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nextEXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewRace)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableraceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).BeginInit();
			this.ToolStripContainer.ContentPanel.SuspendLayout();
			this.ToolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataGridViewRace
			// 
			this.DataGridViewRace.AutoGenerateColumns = false;
			this.DataGridViewRace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raceIDDataGridViewTextBoxColumn,
            this.raceNameDataGridViewTextBoxColumn,
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
            this.lvHPDataGridViewTextBoxColumn,
            this.lvTPDataGridViewTextBoxColumn,
            this.lvATKDataGridViewTextBoxColumn,
            this.lvDEFDataGridViewTextBoxColumn,
            this.lvRATDataGridViewTextBoxColumn,
            this.lvRDFDataGridViewTextBoxColumn,
            this.lvMATDataGridViewTextBoxColumn,
            this.lvMDFDataGridViewTextBoxColumn,
            this.lvSPDDataGridViewTextBoxColumn,
            this.lvLUKDataGridViewTextBoxColumn,
            this.lvHITDataGridViewTextBoxColumn,
            this.lvEVTDataGridViewTextBoxColumn,
            this.nextEXPDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn});
			this.DataGridViewRace.DataSource = this.tableraceBindingSource;
			this.DataGridViewRace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridViewRace.Location = new System.Drawing.Point(0, 0);
			this.DataGridViewRace.Name = "DataGridViewRace";
			this.DataGridViewRace.Size = new System.Drawing.Size(1440, 785);
			this.DataGridViewRace.TabIndex = 0;
			// 
			// tableraceBindingSource
			// 
			this.tableraceBindingSource.DataMember = "__table_race";
			this.tableraceBindingSource.DataSource = this.gigaBattlerDataSet;
			// 
			// gigaBattlerDataSet
			// 
			this.gigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.gigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ___table_raceTableAdapter
			// 
			this.___table_raceTableAdapter.ClearBeforeFill = true;
			// 
			// ToolStripContainer
			// 
			// 
			// ToolStripContainer.ContentPanel
			// 
			this.ToolStripContainer.ContentPanel.Controls.Add(this.DataGridViewRace);
			this.ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(1440, 785);
			this.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ToolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.ToolStripContainer.Name = "ToolStripContainer";
			this.ToolStripContainer.Size = new System.Drawing.Size(1440, 810);
			this.ToolStripContainer.TabIndex = 1;
			this.ToolStripContainer.Text = "toolStripContainer1";
			// 
			// raceIDDataGridViewTextBoxColumn
			// 
			this.raceIDDataGridViewTextBoxColumn.DataPropertyName = "RaceID";
			this.raceIDDataGridViewTextBoxColumn.HeaderText = "Race ID";
			this.raceIDDataGridViewTextBoxColumn.Name = "raceIDDataGridViewTextBoxColumn";
			// 
			// raceNameDataGridViewTextBoxColumn
			// 
			this.raceNameDataGridViewTextBoxColumn.DataPropertyName = "RaceName";
			this.raceNameDataGridViewTextBoxColumn.HeaderText = "Race Name";
			this.raceNameDataGridViewTextBoxColumn.Name = "raceNameDataGridViewTextBoxColumn";
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
			// lvHPDataGridViewTextBoxColumn
			// 
			this.lvHPDataGridViewTextBoxColumn.DataPropertyName = "LvHP";
			this.lvHPDataGridViewTextBoxColumn.HeaderText = "HP/Lv";
			this.lvHPDataGridViewTextBoxColumn.Name = "lvHPDataGridViewTextBoxColumn";
			// 
			// lvTPDataGridViewTextBoxColumn
			// 
			this.lvTPDataGridViewTextBoxColumn.DataPropertyName = "LvTP";
			this.lvTPDataGridViewTextBoxColumn.HeaderText = "TP/Lv";
			this.lvTPDataGridViewTextBoxColumn.Name = "lvTPDataGridViewTextBoxColumn";
			// 
			// lvATKDataGridViewTextBoxColumn
			// 
			this.lvATKDataGridViewTextBoxColumn.DataPropertyName = "LvATK";
			this.lvATKDataGridViewTextBoxColumn.HeaderText = "ATK/Lv";
			this.lvATKDataGridViewTextBoxColumn.Name = "lvATKDataGridViewTextBoxColumn";
			// 
			// lvDEFDataGridViewTextBoxColumn
			// 
			this.lvDEFDataGridViewTextBoxColumn.DataPropertyName = "LvDEF";
			this.lvDEFDataGridViewTextBoxColumn.HeaderText = "DEF/Lv";
			this.lvDEFDataGridViewTextBoxColumn.Name = "lvDEFDataGridViewTextBoxColumn";
			// 
			// lvRATDataGridViewTextBoxColumn
			// 
			this.lvRATDataGridViewTextBoxColumn.DataPropertyName = "LvRAT";
			this.lvRATDataGridViewTextBoxColumn.HeaderText = "RAT/Lv";
			this.lvRATDataGridViewTextBoxColumn.Name = "lvRATDataGridViewTextBoxColumn";
			// 
			// lvRDFDataGridViewTextBoxColumn
			// 
			this.lvRDFDataGridViewTextBoxColumn.DataPropertyName = "LvRDF";
			this.lvRDFDataGridViewTextBoxColumn.HeaderText = "RDF/Lv";
			this.lvRDFDataGridViewTextBoxColumn.Name = "lvRDFDataGridViewTextBoxColumn";
			// 
			// lvMATDataGridViewTextBoxColumn
			// 
			this.lvMATDataGridViewTextBoxColumn.DataPropertyName = "LvMAT";
			this.lvMATDataGridViewTextBoxColumn.HeaderText = "MAT/Lv";
			this.lvMATDataGridViewTextBoxColumn.Name = "lvMATDataGridViewTextBoxColumn";
			// 
			// lvMDFDataGridViewTextBoxColumn
			// 
			this.lvMDFDataGridViewTextBoxColumn.DataPropertyName = "LvMDF";
			this.lvMDFDataGridViewTextBoxColumn.HeaderText = "MDF/Lv";
			this.lvMDFDataGridViewTextBoxColumn.Name = "lvMDFDataGridViewTextBoxColumn";
			// 
			// lvSPDDataGridViewTextBoxColumn
			// 
			this.lvSPDDataGridViewTextBoxColumn.DataPropertyName = "LvSPD";
			this.lvSPDDataGridViewTextBoxColumn.HeaderText = "SPD/Lv";
			this.lvSPDDataGridViewTextBoxColumn.Name = "lvSPDDataGridViewTextBoxColumn";
			// 
			// lvLUKDataGridViewTextBoxColumn
			// 
			this.lvLUKDataGridViewTextBoxColumn.DataPropertyName = "LvLUK";
			this.lvLUKDataGridViewTextBoxColumn.HeaderText = "LUK/Lv";
			this.lvLUKDataGridViewTextBoxColumn.Name = "lvLUKDataGridViewTextBoxColumn";
			// 
			// lvHITDataGridViewTextBoxColumn
			// 
			this.lvHITDataGridViewTextBoxColumn.DataPropertyName = "LvHIT";
			this.lvHITDataGridViewTextBoxColumn.HeaderText = "HIT/Lv";
			this.lvHITDataGridViewTextBoxColumn.Name = "lvHITDataGridViewTextBoxColumn";
			// 
			// lvEVTDataGridViewTextBoxColumn
			// 
			this.lvEVTDataGridViewTextBoxColumn.DataPropertyName = "LvEVT";
			this.lvEVTDataGridViewTextBoxColumn.HeaderText = "EVT/Lv";
			this.lvEVTDataGridViewTextBoxColumn.Name = "lvEVTDataGridViewTextBoxColumn";
			// 
			// nextEXPDataGridViewTextBoxColumn
			// 
			this.nextEXPDataGridViewTextBoxColumn.DataPropertyName = "NextEXP";
			this.nextEXPDataGridViewTextBoxColumn.HeaderText = "NextEXP";
			this.nextEXPDataGridViewTextBoxColumn.Name = "nextEXPDataGridViewTextBoxColumn";
			// 
			// infoDataGridViewTextBoxColumn
			// 
			this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
			this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
			this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
			// 
			// FormRace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 810);
			this.Controls.Add(this.ToolStripContainer);
			this.Name = "FormRace";
			this.Text = "Race Table";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRace_FormClosed);
			this.Load += new System.EventHandler(this.FormRace_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewRace)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableraceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).EndInit();
			this.ToolStripContainer.ContentPanel.ResumeLayout(false);
			this.ToolStripContainer.ResumeLayout(false);
			this.ToolStripContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView DataGridViewRace;
		private GigaBattlerDataSet gigaBattlerDataSet;
		private BindingSource tableraceBindingSource;
		private GigaBattlerDataSetTableAdapters.__table_raceTableAdapter ___table_raceTableAdapter;
		private ToolStripContainer ToolStripContainer;
		private DataGridViewTextBoxColumn raceIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn raceNameDataGridViewTextBoxColumn;
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
		private DataGridViewTextBoxColumn lvHPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvTPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvATKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvDEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvRATDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvRDFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvMATDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvMDFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvSPDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvLUKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvHITDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvEVTDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nextEXPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
	}
}