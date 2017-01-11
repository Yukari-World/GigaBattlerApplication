using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer {
	partial class FormSkill {
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
			this.DataGridViewSkill = new System.Windows.Forms.DataGridView();
			this.skillIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skillNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.percentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.useWeaponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sPCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tPCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aTCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.damagePercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.element1DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element2DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element3DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element4DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element5DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element6DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element7DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element8DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element9DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element10DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableskillBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gigaBattlerDataSet = new Status_Editer.GigaBattlerDataSet();
			this.___table_skillTableAdapter = new Status_Editer.GigaBattlerDataSetTableAdapters.@__table_skillTableAdapter();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewSkill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableskillBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.DataGridViewSkill);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1440, 785);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(1440, 810);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// DataGridViewSkill
			// 
			this.DataGridViewSkill.AutoGenerateColumns = false;
			this.DataGridViewSkill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillIDDataGridViewTextBoxColumn,
            this.skillNameDataGridViewTextBoxColumn,
            this.percentDataGridViewTextBoxColumn,
            this.firstDataGridViewTextBoxColumn,
            this.airDataGridViewTextBoxColumn,
            this.useWeaponDataGridViewTextBoxColumn,
            this.wTypeDataGridViewTextBoxColumn,
            this.sPCostDataGridViewTextBoxColumn,
            this.tPCostDataGridViewTextBoxColumn,
            this.aTCountDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.damagePercentDataGridViewTextBoxColumn,
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
            this.element1DataGridViewComboBoxColumn,
            this.element2DataGridViewComboBoxColumn,
            this.element3DataGridViewComboBoxColumn,
            this.element4DataGridViewComboBoxColumn,
            this.element5DataGridViewComboBoxColumn,
            this.element6DataGridViewComboBoxColumn,
            this.element7DataGridViewComboBoxColumn,
            this.element8DataGridViewComboBoxColumn,
            this.element9DataGridViewComboBoxColumn,
            this.element10DataGridViewComboBoxColumn,
            this.infoDataGridViewTextBoxColumn});
			this.DataGridViewSkill.DataSource = this.tableskillBindingSource;
			this.DataGridViewSkill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridViewSkill.Location = new System.Drawing.Point(0, 0);
			this.DataGridViewSkill.Name = "DataGridViewSkill";
			this.DataGridViewSkill.Size = new System.Drawing.Size(1440, 785);
			this.DataGridViewSkill.TabIndex = 0;
			// 
			// skillIDDataGridViewTextBoxColumn
			// 
			this.skillIDDataGridViewTextBoxColumn.DataPropertyName = "SkillID";
			this.skillIDDataGridViewTextBoxColumn.HeaderText = "SkillID";
			this.skillIDDataGridViewTextBoxColumn.Name = "skillIDDataGridViewTextBoxColumn";
			// 
			// skillNameDataGridViewTextBoxColumn
			// 
			this.skillNameDataGridViewTextBoxColumn.DataPropertyName = "SkillName";
			this.skillNameDataGridViewTextBoxColumn.HeaderText = "SkillName";
			this.skillNameDataGridViewTextBoxColumn.Name = "skillNameDataGridViewTextBoxColumn";
			// 
			// percentDataGridViewTextBoxColumn
			// 
			this.percentDataGridViewTextBoxColumn.DataPropertyName = "Percent";
			this.percentDataGridViewTextBoxColumn.HeaderText = "Percent";
			this.percentDataGridViewTextBoxColumn.Name = "percentDataGridViewTextBoxColumn";
			// 
			// firstDataGridViewTextBoxColumn
			// 
			this.firstDataGridViewTextBoxColumn.DataPropertyName = "First";
			this.firstDataGridViewTextBoxColumn.HeaderText = "First";
			this.firstDataGridViewTextBoxColumn.Name = "firstDataGridViewTextBoxColumn";
			// 
			// airDataGridViewTextBoxColumn
			// 
			this.airDataGridViewTextBoxColumn.DataPropertyName = "Air";
			this.airDataGridViewTextBoxColumn.HeaderText = "Air";
			this.airDataGridViewTextBoxColumn.Name = "airDataGridViewTextBoxColumn";
			// 
			// useWeaponDataGridViewTextBoxColumn
			// 
			this.useWeaponDataGridViewTextBoxColumn.DataPropertyName = "UseWeapon";
			this.useWeaponDataGridViewTextBoxColumn.HeaderText = "UseWeapon";
			this.useWeaponDataGridViewTextBoxColumn.Name = "useWeaponDataGridViewTextBoxColumn";
			// 
			// wTypeDataGridViewTextBoxColumn
			// 
			this.wTypeDataGridViewTextBoxColumn.DataPropertyName = "WType";
			this.wTypeDataGridViewTextBoxColumn.HeaderText = "WType";
			this.wTypeDataGridViewTextBoxColumn.Name = "wTypeDataGridViewTextBoxColumn";
			// 
			// sPCostDataGridViewTextBoxColumn
			// 
			this.sPCostDataGridViewTextBoxColumn.DataPropertyName = "SPCost";
			this.sPCostDataGridViewTextBoxColumn.HeaderText = "SPCost";
			this.sPCostDataGridViewTextBoxColumn.Name = "sPCostDataGridViewTextBoxColumn";
			// 
			// tPCostDataGridViewTextBoxColumn
			// 
			this.tPCostDataGridViewTextBoxColumn.DataPropertyName = "TPCost";
			this.tPCostDataGridViewTextBoxColumn.HeaderText = "TPCost";
			this.tPCostDataGridViewTextBoxColumn.Name = "tPCostDataGridViewTextBoxColumn";
			// 
			// aTCountDataGridViewTextBoxColumn
			// 
			this.aTCountDataGridViewTextBoxColumn.DataPropertyName = "ATCount";
			this.aTCountDataGridViewTextBoxColumn.HeaderText = "ATCount";
			this.aTCountDataGridViewTextBoxColumn.Name = "aTCountDataGridViewTextBoxColumn";
			// 
			// targetDataGridViewTextBoxColumn
			// 
			this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
			this.targetDataGridViewTextBoxColumn.HeaderText = "Target";
			this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			// 
			// powerDataGridViewTextBoxColumn
			// 
			this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
			this.powerDataGridViewTextBoxColumn.HeaderText = "Power";
			this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
			// 
			// damagePercentDataGridViewTextBoxColumn
			// 
			this.damagePercentDataGridViewTextBoxColumn.DataPropertyName = "DamagePercent";
			this.damagePercentDataGridViewTextBoxColumn.HeaderText = "DamagePercent";
			this.damagePercentDataGridViewTextBoxColumn.Name = "damagePercentDataGridViewTextBoxColumn";
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
			// element1DataGridViewComboBoxColumn
			// 
			this.element1DataGridViewComboBoxColumn.DataPropertyName = "Element1";
			this.element1DataGridViewComboBoxColumn.HeaderText = "Element1";
			this.element1DataGridViewComboBoxColumn.Name = "element1DataGridViewComboBoxColumn";
			this.element1DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element1DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element2DataGridViewComboBoxColumn
			// 
			this.element2DataGridViewComboBoxColumn.DataPropertyName = "Element2";
			this.element2DataGridViewComboBoxColumn.HeaderText = "Element2";
			this.element2DataGridViewComboBoxColumn.Name = "element2DataGridViewComboBoxColumn";
			this.element2DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element2DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element3DataGridViewComboBoxColumn
			// 
			this.element3DataGridViewComboBoxColumn.DataPropertyName = "Element3";
			this.element3DataGridViewComboBoxColumn.HeaderText = "Element3";
			this.element3DataGridViewComboBoxColumn.Name = "element3DataGridViewComboBoxColumn";
			this.element3DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element3DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element4DataGridViewComboBoxColumn
			// 
			this.element4DataGridViewComboBoxColumn.DataPropertyName = "Element4";
			this.element4DataGridViewComboBoxColumn.HeaderText = "Element4";
			this.element4DataGridViewComboBoxColumn.Name = "element4DataGridViewComboBoxColumn";
			this.element4DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element4DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element5DataGridViewComboBoxColumn
			// 
			this.element5DataGridViewComboBoxColumn.DataPropertyName = "Element5";
			this.element5DataGridViewComboBoxColumn.HeaderText = "Element5";
			this.element5DataGridViewComboBoxColumn.Name = "element5DataGridViewComboBoxColumn";
			this.element5DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element5DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element6DataGridViewComboBoxColumn
			// 
			this.element6DataGridViewComboBoxColumn.DataPropertyName = "Element6";
			this.element6DataGridViewComboBoxColumn.HeaderText = "Element6";
			this.element6DataGridViewComboBoxColumn.Name = "element6DataGridViewComboBoxColumn";
			this.element6DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element6DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element7DataGridViewComboBoxColumn
			// 
			this.element7DataGridViewComboBoxColumn.DataPropertyName = "Element7";
			this.element7DataGridViewComboBoxColumn.HeaderText = "Element7";
			this.element7DataGridViewComboBoxColumn.Name = "element7DataGridViewComboBoxColumn";
			this.element7DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element7DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element8DataGridViewComboBoxColumn
			// 
			this.element8DataGridViewComboBoxColumn.DataPropertyName = "Element8";
			this.element8DataGridViewComboBoxColumn.HeaderText = "Element8";
			this.element8DataGridViewComboBoxColumn.Name = "element8DataGridViewComboBoxColumn";
			this.element8DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element8DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element9DataGridViewComboBoxColumn
			// 
			this.element9DataGridViewComboBoxColumn.DataPropertyName = "Element9";
			this.element9DataGridViewComboBoxColumn.HeaderText = "Element9";
			this.element9DataGridViewComboBoxColumn.Name = "element9DataGridViewComboBoxColumn";
			this.element9DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element9DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// element10DataGridViewComboBoxColumn
			// 
			this.element10DataGridViewComboBoxColumn.DataPropertyName = "Element10";
			this.element10DataGridViewComboBoxColumn.HeaderText = "Element10";
			this.element10DataGridViewComboBoxColumn.Name = "element10DataGridViewComboBoxColumn";
			this.element10DataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.element10DataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// infoDataGridViewTextBoxColumn
			// 
			this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
			this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
			this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
			// 
			// tableskillBindingSource
			// 
			this.tableskillBindingSource.DataMember = "__table_skill";
			this.tableskillBindingSource.DataSource = this.gigaBattlerDataSet;
			// 
			// gigaBattlerDataSet
			// 
			this.gigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.gigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ___table_skillTableAdapter
			// 
			this.___table_skillTableAdapter.ClearBeforeFill = true;
			// 
			// FormSkill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 810);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "FormSkill";
			this.Text = "FormSkill";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSkill_FormClosed);
			this.Load += new System.EventHandler(this.FormSkill_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewSkill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableskillBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolStripContainer toolStripContainer1;
		private DataGridView DataGridViewSkill;
		private GigaBattlerDataSet gigaBattlerDataSet;
		private BindingSource tableskillBindingSource;
		private GigaBattlerDataSetTableAdapters.__table_skillTableAdapter ___table_skillTableAdapter;
		private DataGridViewTextBoxColumn skillIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skillNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn percentDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn firstDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn airDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn useWeaponDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn wTypeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sPCostDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn tPCostDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn aTCountDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn damagePercentDataGridViewTextBoxColumn;
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
		private DataGridViewComboBoxColumn element1DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element2DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element3DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element4DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element5DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element6DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element7DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element8DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element9DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element10DataGridViewComboBoxColumn;
		private DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
	}
}