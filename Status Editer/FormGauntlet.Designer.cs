﻿using CommonLibrary;
using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer {
	partial class FormGauntlet {
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
			this.DataGridViewGauntlet = new System.Windows.Forms.DataGridView();
			this.gauntletIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gauntletNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.physicsPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.magicPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.physicsDefenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.magicDefenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reductionRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.element1DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.element2DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.wTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.duabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.skill1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tablegauntletBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gigaBattlerDataSet = new CommonLibrary.GigaBattlerDataSet();
			this.___table_gauntletTableAdapter = new CommonLibrary.GigaBattlerDataSetTableAdapters.@__table_gauntletTableAdapter();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewGauntlet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablegauntletBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.DataGridViewGauntlet);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1440, 785);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(1440, 810);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// DataGridViewGauntlet
			// 
			this.DataGridViewGauntlet.AutoGenerateColumns = false;
			this.DataGridViewGauntlet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gauntletIDDataGridViewTextBoxColumn,
            this.gauntletNameDataGridViewTextBoxColumn,
            this.physicsPowerDataGridViewTextBoxColumn,
            this.magicPowerDataGridViewTextBoxColumn,
            this.physicsDefenceDataGridViewTextBoxColumn,
            this.magicDefenceDataGridViewTextBoxColumn,
            this.reductionRateDataGridViewTextBoxColumn,
            this.element1DataGridViewComboBoxColumn,
            this.element2DataGridViewComboBoxColumn,
            this.wTDataGridViewTextBoxColumn,
            this.eCDataGridViewTextBoxColumn,
            this.sSPDataGridViewTextBoxColumn,
            this.sPCDataGridViewTextBoxColumn,
            this.aTCDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.aTypeDataGridViewTextBoxColumn,
            this.eTypeDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.rareDataGridViewTextBoxColumn,
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
            this.duabilityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.buyDataGridViewCheckBoxColumn,
            this.skill1DataGridViewTextBoxColumn,
            this.skill2DataGridViewTextBoxColumn,
            this.skill3DataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn});
			this.DataGridViewGauntlet.DataSource = this.tablegauntletBindingSource;
			this.DataGridViewGauntlet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridViewGauntlet.Location = new System.Drawing.Point(0, 0);
			this.DataGridViewGauntlet.Name = "DataGridViewGauntlet";
			this.DataGridViewGauntlet.Size = new System.Drawing.Size(1440, 785);
			this.DataGridViewGauntlet.TabIndex = 0;
			// 
			// gauntletIDDataGridViewTextBoxColumn
			// 
			this.gauntletIDDataGridViewTextBoxColumn.DataPropertyName = "GauntletID";
			this.gauntletIDDataGridViewTextBoxColumn.HeaderText = "GauntletID";
			this.gauntletIDDataGridViewTextBoxColumn.Name = "gauntletIDDataGridViewTextBoxColumn";
			// 
			// gauntletNameDataGridViewTextBoxColumn
			// 
			this.gauntletNameDataGridViewTextBoxColumn.DataPropertyName = "GauntletName";
			this.gauntletNameDataGridViewTextBoxColumn.HeaderText = "GauntletName";
			this.gauntletNameDataGridViewTextBoxColumn.Name = "gauntletNameDataGridViewTextBoxColumn";
			// 
			// physicsPowerDataGridViewTextBoxColumn
			// 
			this.physicsPowerDataGridViewTextBoxColumn.DataPropertyName = "PhysicsPower";
			this.physicsPowerDataGridViewTextBoxColumn.HeaderText = "PhysicsPower";
			this.physicsPowerDataGridViewTextBoxColumn.Name = "physicsPowerDataGridViewTextBoxColumn";
			// 
			// magicPowerDataGridViewTextBoxColumn
			// 
			this.magicPowerDataGridViewTextBoxColumn.DataPropertyName = "MagicPower";
			this.magicPowerDataGridViewTextBoxColumn.HeaderText = "MagicPower";
			this.magicPowerDataGridViewTextBoxColumn.Name = "magicPowerDataGridViewTextBoxColumn";
			// 
			// physicsDefenceDataGridViewTextBoxColumn
			// 
			this.physicsDefenceDataGridViewTextBoxColumn.DataPropertyName = "PhysicsDefence";
			this.physicsDefenceDataGridViewTextBoxColumn.HeaderText = "PhysicsDefence";
			this.physicsDefenceDataGridViewTextBoxColumn.Name = "physicsDefenceDataGridViewTextBoxColumn";
			// 
			// magicDefenceDataGridViewTextBoxColumn
			// 
			this.magicDefenceDataGridViewTextBoxColumn.DataPropertyName = "MagicDefence";
			this.magicDefenceDataGridViewTextBoxColumn.HeaderText = "MagicDefence";
			this.magicDefenceDataGridViewTextBoxColumn.Name = "magicDefenceDataGridViewTextBoxColumn";
			// 
			// reductionRateDataGridViewTextBoxColumn
			// 
			this.reductionRateDataGridViewTextBoxColumn.DataPropertyName = "ReductionRate";
			this.reductionRateDataGridViewTextBoxColumn.HeaderText = "ReductionRate";
			this.reductionRateDataGridViewTextBoxColumn.Name = "reductionRateDataGridViewTextBoxColumn";
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
			// wTDataGridViewTextBoxColumn
			// 
			this.wTDataGridViewTextBoxColumn.DataPropertyName = "WT";
			this.wTDataGridViewTextBoxColumn.HeaderText = "WT";
			this.wTDataGridViewTextBoxColumn.Name = "wTDataGridViewTextBoxColumn";
			// 
			// eCDataGridViewTextBoxColumn
			// 
			this.eCDataGridViewTextBoxColumn.DataPropertyName = "EC";
			this.eCDataGridViewTextBoxColumn.HeaderText = "EC";
			this.eCDataGridViewTextBoxColumn.Name = "eCDataGridViewTextBoxColumn";
			// 
			// sSPDataGridViewTextBoxColumn
			// 
			this.sSPDataGridViewTextBoxColumn.DataPropertyName = "SSP";
			this.sSPDataGridViewTextBoxColumn.HeaderText = "SSP";
			this.sSPDataGridViewTextBoxColumn.Name = "sSPDataGridViewTextBoxColumn";
			// 
			// sPCDataGridViewTextBoxColumn
			// 
			this.sPCDataGridViewTextBoxColumn.DataPropertyName = "SPC";
			this.sPCDataGridViewTextBoxColumn.HeaderText = "SPC";
			this.sPCDataGridViewTextBoxColumn.Name = "sPCDataGridViewTextBoxColumn";
			// 
			// aTCDataGridViewTextBoxColumn
			// 
			this.aTCDataGridViewTextBoxColumn.DataPropertyName = "ATC";
			this.aTCDataGridViewTextBoxColumn.HeaderText = "ATC";
			this.aTCDataGridViewTextBoxColumn.Name = "aTCDataGridViewTextBoxColumn";
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
			// aTypeDataGridViewTextBoxColumn
			// 
			this.aTypeDataGridViewTextBoxColumn.DataPropertyName = "AType";
			this.aTypeDataGridViewTextBoxColumn.HeaderText = "AType";
			this.aTypeDataGridViewTextBoxColumn.Name = "aTypeDataGridViewTextBoxColumn";
			// 
			// eTypeDataGridViewTextBoxColumn
			// 
			this.eTypeDataGridViewTextBoxColumn.DataPropertyName = "EType";
			this.eTypeDataGridViewTextBoxColumn.HeaderText = "EType";
			this.eTypeDataGridViewTextBoxColumn.Name = "eTypeDataGridViewTextBoxColumn";
			// 
			// makerDataGridViewTextBoxColumn
			// 
			this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
			this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
			this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
			// 
			// rareDataGridViewTextBoxColumn
			// 
			this.rareDataGridViewTextBoxColumn.DataPropertyName = "Rare";
			this.rareDataGridViewTextBoxColumn.HeaderText = "Rare";
			this.rareDataGridViewTextBoxColumn.Name = "rareDataGridViewTextBoxColumn";
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
			// duabilityDataGridViewTextBoxColumn
			// 
			this.duabilityDataGridViewTextBoxColumn.DataPropertyName = "Duability";
			this.duabilityDataGridViewTextBoxColumn.HeaderText = "Duability";
			this.duabilityDataGridViewTextBoxColumn.Name = "duabilityDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// buyDataGridViewCheckBoxColumn
			// 
			this.buyDataGridViewCheckBoxColumn.DataPropertyName = "Buy";
			this.buyDataGridViewCheckBoxColumn.HeaderText = "Buy";
			this.buyDataGridViewCheckBoxColumn.Name = "buyDataGridViewCheckBoxColumn";
			// 
			// skill1DataGridViewTextBoxColumn
			// 
			this.skill1DataGridViewTextBoxColumn.DataPropertyName = "Skill1";
			this.skill1DataGridViewTextBoxColumn.HeaderText = "Skill1";
			this.skill1DataGridViewTextBoxColumn.Name = "skill1DataGridViewTextBoxColumn";
			// 
			// skill2DataGridViewTextBoxColumn
			// 
			this.skill2DataGridViewTextBoxColumn.DataPropertyName = "Skill2";
			this.skill2DataGridViewTextBoxColumn.HeaderText = "Skill2";
			this.skill2DataGridViewTextBoxColumn.Name = "skill2DataGridViewTextBoxColumn";
			// 
			// skill3DataGridViewTextBoxColumn
			// 
			this.skill3DataGridViewTextBoxColumn.DataPropertyName = "Skill3";
			this.skill3DataGridViewTextBoxColumn.HeaderText = "Skill3";
			this.skill3DataGridViewTextBoxColumn.Name = "skill3DataGridViewTextBoxColumn";
			// 
			// infoDataGridViewTextBoxColumn
			// 
			this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
			this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
			this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
			// 
			// tablegauntletBindingSource
			// 
			this.tablegauntletBindingSource.DataMember = "__table_gauntlet";
			this.tablegauntletBindingSource.DataSource = this.gigaBattlerDataSet;
			// 
			// gigaBattlerDataSet
			// 
			this.gigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.gigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ___table_gauntletTableAdapter
			// 
			this.___table_gauntletTableAdapter.ClearBeforeFill = true;
			// 
			// FormGauntlet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 810);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "FormGauntlet";
			this.Text = "Gauntlet Table";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGauntlet_FormClosed);
			this.Load += new System.EventHandler(this.FormGauntlet_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewGauntlet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablegauntletBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolStripContainer toolStripContainer1;
		private DataGridView DataGridViewGauntlet;
		private GigaBattlerDataSet gigaBattlerDataSet;
		private BindingSource tablegauntletBindingSource;
		private CommonLibrary.GigaBattlerDataSetTableAdapters.__table_gauntletTableAdapter ___table_gauntletTableAdapter;
		private DataGridViewTextBoxColumn gauntletIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn gauntletNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn physicsPowerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn magicPowerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn physicsDefenceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn magicDefenceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn reductionRateDataGridViewTextBoxColumn;
		private DataGridViewComboBoxColumn element1DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn element2DataGridViewComboBoxColumn;
		private DataGridViewTextBoxColumn wTDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn eCDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sSPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sPCDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn aTCDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn aTypeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn eTypeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rareDataGridViewTextBoxColumn;
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
		private DataGridViewTextBoxColumn duabilityDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private DataGridViewCheckBoxColumn buyDataGridViewCheckBoxColumn;
		private DataGridViewTextBoxColumn skill1DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill2DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill3DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
	}
}