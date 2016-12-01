using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Status_Editer {
	partial class FormUnit {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tableunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gigaBattlerDataSet = new Status_Editer.GigaBattlerDataSet();
			this.___table_unitTableAdapter = new Status_Editer.GigaBattlerDataSetTableAdapters.@__table_unitTableAdapter();
			this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reqLvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minLvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxLvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.meleeATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.meleeDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rangeATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rangeDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.magicATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.magicDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lUKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvMeleeATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvMeleeDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvRangeATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvRangeDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvMagicATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvMagicDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvSPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvLUKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvHITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvEVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvEXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lvMNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hPPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.meleeATKPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.meleeDEFPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rangeATKPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rangeDEFPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.magicATKPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.magicDEFPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sPDPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eXPPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mNYPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dMGPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.verDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.algorithmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rare2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.item1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.per1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.item2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.per2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.item3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.per3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.item4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.per4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.item5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.per5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.item6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.per6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill16DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill17DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill18DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill21DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill22DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill23DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill24DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill25DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill26DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill27DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill28DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill29DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skill30DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability16DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability17DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability18DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability21DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability22DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability23DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability24DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability25DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability26DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability27DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability28DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability29DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ability30DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ToolStripContainer.ContentPanel.SuspendLayout();
			this.ToolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableunitBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// ToolStripContainer
			// 
			// 
			// ToolStripContainer.ContentPanel
			// 
			this.ToolStripContainer.ContentPanel.BackColor = System.Drawing.Color.Transparent;
			this.ToolStripContainer.ContentPanel.Controls.Add(this.dataGridView1);
			this.ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(1440, 785);
			this.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ToolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.ToolStripContainer.Name = "ToolStripContainer";
			this.ToolStripContainer.Size = new System.Drawing.Size(1440, 810);
			this.ToolStripContainer.TabIndex = 0;
			this.ToolStripContainer.Text = "toolStripContainer1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIDDataGridViewTextBoxColumn,
            this.unitNameDataGridViewTextBoxColumn,
            this.raceDataGridViewTextBoxColumn,
            this.reqLvDataGridViewTextBoxColumn,
            this.minLvDataGridViewTextBoxColumn,
            this.maxLvDataGridViewTextBoxColumn,
            this.startTPDataGridViewTextBoxColumn,
            this.maxTPDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.meleeATKDataGridViewTextBoxColumn,
            this.meleeDEFDataGridViewTextBoxColumn,
            this.rangeATKDataGridViewTextBoxColumn,
            this.rangeDEFDataGridViewTextBoxColumn,
            this.magicATKDataGridViewTextBoxColumn,
            this.magicDEFDataGridViewTextBoxColumn,
            this.sPDDataGridViewTextBoxColumn,
            this.lUKDataGridViewTextBoxColumn,
            this.hITDataGridViewTextBoxColumn,
            this.eVTDataGridViewTextBoxColumn,
            this.eXPDataGridViewTextBoxColumn,
            this.mNYDataGridViewTextBoxColumn,
            this.lvHPDataGridViewTextBoxColumn,
            this.lvMeleeATKDataGridViewTextBoxColumn,
            this.lvMeleeDEFDataGridViewTextBoxColumn,
            this.lvRangeATKDataGridViewTextBoxColumn,
            this.lvRangeDEFDataGridViewTextBoxColumn,
            this.lvMagicATKDataGridViewTextBoxColumn,
            this.lvMagicDEFDataGridViewTextBoxColumn,
            this.lvSPDDataGridViewTextBoxColumn,
            this.lvLUKDataGridViewTextBoxColumn,
            this.lvHITDataGridViewTextBoxColumn,
            this.lvEVTDataGridViewTextBoxColumn,
            this.lvEXPDataGridViewTextBoxColumn,
            this.lvMNYDataGridViewTextBoxColumn,
            this.hPPerDataGridViewTextBoxColumn,
            this.meleeATKPerDataGridViewTextBoxColumn,
            this.meleeDEFPerDataGridViewTextBoxColumn,
            this.rangeATKPerDataGridViewTextBoxColumn,
            this.rangeDEFPerDataGridViewTextBoxColumn,
            this.magicATKPerDataGridViewTextBoxColumn,
            this.magicDEFPerDataGridViewTextBoxColumn,
            this.sPDPerDataGridViewTextBoxColumn,
            this.eXPPerDataGridViewTextBoxColumn,
            this.mNYPerDataGridViewTextBoxColumn,
            this.wTDataGridViewTextBoxColumn,
            this.sSPDataGridViewTextBoxColumn,
            this.sPCDataGridViewTextBoxColumn,
            this.aTCDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dMGPerDataGridViewTextBoxColumn,
            this.airDataGridViewCheckBoxColumn,
            this.verDataGridViewTextBoxColumn,
            this.algorithmDataGridViewTextBoxColumn,
            this.aIIDDataGridViewTextBoxColumn,
            this.rareDataGridViewTextBoxColumn,
            this.rare2DataGridViewTextBoxColumn,
            this.item1DataGridViewTextBoxColumn,
            this.per1DataGridViewTextBoxColumn,
            this.item2DataGridViewTextBoxColumn,
            this.per2DataGridViewTextBoxColumn,
            this.item3DataGridViewTextBoxColumn,
            this.per3DataGridViewTextBoxColumn,
            this.item4DataGridViewTextBoxColumn,
            this.per4DataGridViewTextBoxColumn,
            this.item5DataGridViewTextBoxColumn,
            this.per5DataGridViewTextBoxColumn,
            this.item6DataGridViewTextBoxColumn,
            this.per6DataGridViewTextBoxColumn,
            this.skill1DataGridViewTextBoxColumn,
            this.skill2DataGridViewTextBoxColumn,
            this.skill3DataGridViewTextBoxColumn,
            this.skill4DataGridViewTextBoxColumn,
            this.skill5DataGridViewTextBoxColumn,
            this.skill6DataGridViewTextBoxColumn,
            this.skill7DataGridViewTextBoxColumn,
            this.skill8DataGridViewTextBoxColumn,
            this.skill9DataGridViewTextBoxColumn,
            this.skill10DataGridViewTextBoxColumn,
            this.skill11DataGridViewTextBoxColumn,
            this.skill12DataGridViewTextBoxColumn,
            this.skill13DataGridViewTextBoxColumn,
            this.skill14DataGridViewTextBoxColumn,
            this.skill15DataGridViewTextBoxColumn,
            this.skill16DataGridViewTextBoxColumn,
            this.skill17DataGridViewTextBoxColumn,
            this.skill18DataGridViewTextBoxColumn,
            this.skill19DataGridViewTextBoxColumn,
            this.skill20DataGridViewTextBoxColumn,
            this.skill21DataGridViewTextBoxColumn,
            this.skill22DataGridViewTextBoxColumn,
            this.skill23DataGridViewTextBoxColumn,
            this.skill24DataGridViewTextBoxColumn,
            this.skill25DataGridViewTextBoxColumn,
            this.skill26DataGridViewTextBoxColumn,
            this.skill27DataGridViewTextBoxColumn,
            this.skill28DataGridViewTextBoxColumn,
            this.skill29DataGridViewTextBoxColumn,
            this.skill30DataGridViewTextBoxColumn,
            this.ability1DataGridViewTextBoxColumn,
            this.ability2DataGridViewTextBoxColumn,
            this.ability3DataGridViewTextBoxColumn,
            this.ability4DataGridViewTextBoxColumn,
            this.ability5DataGridViewTextBoxColumn,
            this.ability6DataGridViewTextBoxColumn,
            this.ability7DataGridViewTextBoxColumn,
            this.ability8DataGridViewTextBoxColumn,
            this.ability9DataGridViewTextBoxColumn,
            this.ability10DataGridViewTextBoxColumn,
            this.ability11DataGridViewTextBoxColumn,
            this.ability12DataGridViewTextBoxColumn,
            this.ability13DataGridViewTextBoxColumn,
            this.ability14DataGridViewTextBoxColumn,
            this.ability15DataGridViewTextBoxColumn,
            this.ability16DataGridViewTextBoxColumn,
            this.ability17DataGridViewTextBoxColumn,
            this.ability18DataGridViewTextBoxColumn,
            this.ability19DataGridViewTextBoxColumn,
            this.ability20DataGridViewTextBoxColumn,
            this.ability21DataGridViewTextBoxColumn,
            this.ability22DataGridViewTextBoxColumn,
            this.ability23DataGridViewTextBoxColumn,
            this.ability24DataGridViewTextBoxColumn,
            this.ability25DataGridViewTextBoxColumn,
            this.ability26DataGridViewTextBoxColumn,
            this.ability27DataGridViewTextBoxColumn,
            this.ability28DataGridViewTextBoxColumn,
            this.ability29DataGridViewTextBoxColumn,
            this.ability30DataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tableunitBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1440, 785);
			this.dataGridView1.TabIndex = 0;
			// 
			// tableunitBindingSource
			// 
			this.tableunitBindingSource.DataMember = "__table_unit";
			this.tableunitBindingSource.DataSource = this.gigaBattlerDataSet;
			// 
			// gigaBattlerDataSet
			// 
			this.gigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.gigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ___table_unitTableAdapter
			// 
			this.___table_unitTableAdapter.ClearBeforeFill = true;
			// 
			// unitIDDataGridViewTextBoxColumn
			// 
			this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
			this.unitIDDataGridViewTextBoxColumn.HeaderText = "UnitID";
			this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
			this.unitIDDataGridViewTextBoxColumn.Width = 62;
			// 
			// unitNameDataGridViewTextBoxColumn
			// 
			this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
			this.unitNameDataGridViewTextBoxColumn.HeaderText = "UnitName";
			this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
			this.unitNameDataGridViewTextBoxColumn.Width = 80;
			// 
			// raceDataGridViewTextBoxColumn
			// 
			this.raceDataGridViewTextBoxColumn.DataPropertyName = "Race";
			this.raceDataGridViewTextBoxColumn.HeaderText = "Race";
			this.raceDataGridViewTextBoxColumn.Name = "raceDataGridViewTextBoxColumn";
			this.raceDataGridViewTextBoxColumn.Width = 56;
			// 
			// reqLvDataGridViewTextBoxColumn
			// 
			this.reqLvDataGridViewTextBoxColumn.DataPropertyName = "Req Lv";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "N0";
			dataGridViewCellStyle1.NullValue = null;
			this.reqLvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.reqLvDataGridViewTextBoxColumn.HeaderText = "Req Lv";
			this.reqLvDataGridViewTextBoxColumn.Name = "reqLvDataGridViewTextBoxColumn";
			this.reqLvDataGridViewTextBoxColumn.Width = 66;
			// 
			// minLvDataGridViewTextBoxColumn
			// 
			this.minLvDataGridViewTextBoxColumn.DataPropertyName = "Min Lv";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = null;
			this.minLvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.minLvDataGridViewTextBoxColumn.HeaderText = "Min Lv";
			this.minLvDataGridViewTextBoxColumn.Name = "minLvDataGridViewTextBoxColumn";
			this.minLvDataGridViewTextBoxColumn.Width = 64;
			// 
			// maxLvDataGridViewTextBoxColumn
			// 
			this.maxLvDataGridViewTextBoxColumn.DataPropertyName = "Max Lv";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = null;
			this.maxLvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.maxLvDataGridViewTextBoxColumn.HeaderText = "Max Lv";
			this.maxLvDataGridViewTextBoxColumn.Name = "maxLvDataGridViewTextBoxColumn";
			this.maxLvDataGridViewTextBoxColumn.Width = 67;
			// 
			// startTPDataGridViewTextBoxColumn
			// 
			this.startTPDataGridViewTextBoxColumn.DataPropertyName = "StartTP";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			this.startTPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.startTPDataGridViewTextBoxColumn.HeaderText = "StartTP";
			this.startTPDataGridViewTextBoxColumn.Name = "startTPDataGridViewTextBoxColumn";
			this.startTPDataGridViewTextBoxColumn.Width = 69;
			// 
			// maxTPDataGridViewTextBoxColumn
			// 
			this.maxTPDataGridViewTextBoxColumn.DataPropertyName = "MaxTP";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N0";
			this.maxTPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.maxTPDataGridViewTextBoxColumn.HeaderText = "MaxTP";
			this.maxTPDataGridViewTextBoxColumn.Name = "maxTPDataGridViewTextBoxColumn";
			this.maxTPDataGridViewTextBoxColumn.Width = 65;
			// 
			// hPDataGridViewTextBoxColumn
			// 
			this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.Format = "N2";
			this.hPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
			this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
			this.hPDataGridViewTextBoxColumn.Width = 45;
			// 
			// meleeATKDataGridViewTextBoxColumn
			// 
			this.meleeATKDataGridViewTextBoxColumn.DataPropertyName = "MeleeATK";
			this.meleeATKDataGridViewTextBoxColumn.HeaderText = "MeleeATK";
			this.meleeATKDataGridViewTextBoxColumn.Name = "meleeATKDataGridViewTextBoxColumn";
			this.meleeATKDataGridViewTextBoxColumn.Width = 82;
			// 
			// meleeDEFDataGridViewTextBoxColumn
			// 
			this.meleeDEFDataGridViewTextBoxColumn.DataPropertyName = "MeleeDEF";
			this.meleeDEFDataGridViewTextBoxColumn.HeaderText = "MeleeDEF";
			this.meleeDEFDataGridViewTextBoxColumn.Name = "meleeDEFDataGridViewTextBoxColumn";
			this.meleeDEFDataGridViewTextBoxColumn.Width = 82;
			// 
			// rangeATKDataGridViewTextBoxColumn
			// 
			this.rangeATKDataGridViewTextBoxColumn.DataPropertyName = "RangeATK";
			this.rangeATKDataGridViewTextBoxColumn.HeaderText = "RangeATK";
			this.rangeATKDataGridViewTextBoxColumn.Name = "rangeATKDataGridViewTextBoxColumn";
			this.rangeATKDataGridViewTextBoxColumn.Width = 84;
			// 
			// rangeDEFDataGridViewTextBoxColumn
			// 
			this.rangeDEFDataGridViewTextBoxColumn.DataPropertyName = "RangeDEF";
			this.rangeDEFDataGridViewTextBoxColumn.HeaderText = "RangeDEF";
			this.rangeDEFDataGridViewTextBoxColumn.Name = "rangeDEFDataGridViewTextBoxColumn";
			this.rangeDEFDataGridViewTextBoxColumn.Width = 84;
			// 
			// magicATKDataGridViewTextBoxColumn
			// 
			this.magicATKDataGridViewTextBoxColumn.DataPropertyName = "MagicATK";
			this.magicATKDataGridViewTextBoxColumn.HeaderText = "MagicATK";
			this.magicATKDataGridViewTextBoxColumn.Name = "magicATKDataGridViewTextBoxColumn";
			this.magicATKDataGridViewTextBoxColumn.Width = 82;
			// 
			// magicDEFDataGridViewTextBoxColumn
			// 
			this.magicDEFDataGridViewTextBoxColumn.DataPropertyName = "MagicDEF";
			this.magicDEFDataGridViewTextBoxColumn.HeaderText = "MagicDEF";
			this.magicDEFDataGridViewTextBoxColumn.Name = "magicDEFDataGridViewTextBoxColumn";
			this.magicDEFDataGridViewTextBoxColumn.Width = 82;
			// 
			// sPDDataGridViewTextBoxColumn
			// 
			this.sPDDataGridViewTextBoxColumn.DataPropertyName = "SPD";
			this.sPDDataGridViewTextBoxColumn.HeaderText = "SPD";
			this.sPDDataGridViewTextBoxColumn.Name = "sPDDataGridViewTextBoxColumn";
			this.sPDDataGridViewTextBoxColumn.Width = 52;
			// 
			// lUKDataGridViewTextBoxColumn
			// 
			this.lUKDataGridViewTextBoxColumn.DataPropertyName = "LUK";
			this.lUKDataGridViewTextBoxColumn.HeaderText = "LUK";
			this.lUKDataGridViewTextBoxColumn.Name = "lUKDataGridViewTextBoxColumn";
			this.lUKDataGridViewTextBoxColumn.Width = 51;
			// 
			// hITDataGridViewTextBoxColumn
			// 
			this.hITDataGridViewTextBoxColumn.DataPropertyName = "HIT";
			this.hITDataGridViewTextBoxColumn.HeaderText = "HIT";
			this.hITDataGridViewTextBoxColumn.Name = "hITDataGridViewTextBoxColumn";
			this.hITDataGridViewTextBoxColumn.Width = 48;
			// 
			// eVTDataGridViewTextBoxColumn
			// 
			this.eVTDataGridViewTextBoxColumn.DataPropertyName = "EVT";
			this.eVTDataGridViewTextBoxColumn.HeaderText = "EVT";
			this.eVTDataGridViewTextBoxColumn.Name = "eVTDataGridViewTextBoxColumn";
			this.eVTDataGridViewTextBoxColumn.Width = 52;
			// 
			// eXPDataGridViewTextBoxColumn
			// 
			this.eXPDataGridViewTextBoxColumn.DataPropertyName = "EXP";
			this.eXPDataGridViewTextBoxColumn.HeaderText = "EXP";
			this.eXPDataGridViewTextBoxColumn.Name = "eXPDataGridViewTextBoxColumn";
			this.eXPDataGridViewTextBoxColumn.Width = 51;
			// 
			// mNYDataGridViewTextBoxColumn
			// 
			this.mNYDataGridViewTextBoxColumn.DataPropertyName = "MNY";
			this.mNYDataGridViewTextBoxColumn.HeaderText = "MNY";
			this.mNYDataGridViewTextBoxColumn.Name = "mNYDataGridViewTextBoxColumn";
			this.mNYDataGridViewTextBoxColumn.Width = 54;
			// 
			// lvHPDataGridViewTextBoxColumn
			// 
			this.lvHPDataGridViewTextBoxColumn.DataPropertyName = "LvHP";
			this.lvHPDataGridViewTextBoxColumn.HeaderText = "LvHP";
			this.lvHPDataGridViewTextBoxColumn.Name = "lvHPDataGridViewTextBoxColumn";
			this.lvHPDataGridViewTextBoxColumn.Width = 57;
			// 
			// lvMeleeATKDataGridViewTextBoxColumn
			// 
			this.lvMeleeATKDataGridViewTextBoxColumn.DataPropertyName = "LvMeleeATK";
			this.lvMeleeATKDataGridViewTextBoxColumn.HeaderText = "LvMeleeATK";
			this.lvMeleeATKDataGridViewTextBoxColumn.Name = "lvMeleeATKDataGridViewTextBoxColumn";
			this.lvMeleeATKDataGridViewTextBoxColumn.Width = 94;
			// 
			// lvMeleeDEFDataGridViewTextBoxColumn
			// 
			this.lvMeleeDEFDataGridViewTextBoxColumn.DataPropertyName = "LvMeleeDEF";
			this.lvMeleeDEFDataGridViewTextBoxColumn.HeaderText = "LvMeleeDEF";
			this.lvMeleeDEFDataGridViewTextBoxColumn.Name = "lvMeleeDEFDataGridViewTextBoxColumn";
			this.lvMeleeDEFDataGridViewTextBoxColumn.Width = 94;
			// 
			// lvRangeATKDataGridViewTextBoxColumn
			// 
			this.lvRangeATKDataGridViewTextBoxColumn.DataPropertyName = "LvRangeATK";
			this.lvRangeATKDataGridViewTextBoxColumn.HeaderText = "LvRangeATK";
			this.lvRangeATKDataGridViewTextBoxColumn.Name = "lvRangeATKDataGridViewTextBoxColumn";
			this.lvRangeATKDataGridViewTextBoxColumn.Width = 96;
			// 
			// lvRangeDEFDataGridViewTextBoxColumn
			// 
			this.lvRangeDEFDataGridViewTextBoxColumn.DataPropertyName = "LvRangeDEF";
			this.lvRangeDEFDataGridViewTextBoxColumn.HeaderText = "LvRangeDEF";
			this.lvRangeDEFDataGridViewTextBoxColumn.Name = "lvRangeDEFDataGridViewTextBoxColumn";
			this.lvRangeDEFDataGridViewTextBoxColumn.Width = 96;
			// 
			// lvMagicATKDataGridViewTextBoxColumn
			// 
			this.lvMagicATKDataGridViewTextBoxColumn.DataPropertyName = "LvMagicATK";
			this.lvMagicATKDataGridViewTextBoxColumn.HeaderText = "LvMagicATK";
			this.lvMagicATKDataGridViewTextBoxColumn.Name = "lvMagicATKDataGridViewTextBoxColumn";
			this.lvMagicATKDataGridViewTextBoxColumn.Width = 94;
			// 
			// lvMagicDEFDataGridViewTextBoxColumn
			// 
			this.lvMagicDEFDataGridViewTextBoxColumn.DataPropertyName = "LvMagicDEF";
			this.lvMagicDEFDataGridViewTextBoxColumn.HeaderText = "LvMagicDEF";
			this.lvMagicDEFDataGridViewTextBoxColumn.Name = "lvMagicDEFDataGridViewTextBoxColumn";
			this.lvMagicDEFDataGridViewTextBoxColumn.Width = 94;
			// 
			// lvSPDDataGridViewTextBoxColumn
			// 
			this.lvSPDDataGridViewTextBoxColumn.DataPropertyName = "LvSPD";
			this.lvSPDDataGridViewTextBoxColumn.HeaderText = "LvSPD";
			this.lvSPDDataGridViewTextBoxColumn.Name = "lvSPDDataGridViewTextBoxColumn";
			this.lvSPDDataGridViewTextBoxColumn.Width = 64;
			// 
			// lvLUKDataGridViewTextBoxColumn
			// 
			this.lvLUKDataGridViewTextBoxColumn.DataPropertyName = "LvLUK";
			this.lvLUKDataGridViewTextBoxColumn.HeaderText = "LvLUK";
			this.lvLUKDataGridViewTextBoxColumn.Name = "lvLUKDataGridViewTextBoxColumn";
			this.lvLUKDataGridViewTextBoxColumn.Width = 63;
			// 
			// lvHITDataGridViewTextBoxColumn
			// 
			this.lvHITDataGridViewTextBoxColumn.DataPropertyName = "LvHIT";
			this.lvHITDataGridViewTextBoxColumn.HeaderText = "LvHIT";
			this.lvHITDataGridViewTextBoxColumn.Name = "lvHITDataGridViewTextBoxColumn";
			this.lvHITDataGridViewTextBoxColumn.Width = 60;
			// 
			// lvEVTDataGridViewTextBoxColumn
			// 
			this.lvEVTDataGridViewTextBoxColumn.DataPropertyName = "LvEVT";
			this.lvEVTDataGridViewTextBoxColumn.HeaderText = "LvEVT";
			this.lvEVTDataGridViewTextBoxColumn.Name = "lvEVTDataGridViewTextBoxColumn";
			this.lvEVTDataGridViewTextBoxColumn.Width = 64;
			// 
			// lvEXPDataGridViewTextBoxColumn
			// 
			this.lvEXPDataGridViewTextBoxColumn.DataPropertyName = "LvEXP";
			this.lvEXPDataGridViewTextBoxColumn.HeaderText = "LvEXP";
			this.lvEXPDataGridViewTextBoxColumn.Name = "lvEXPDataGridViewTextBoxColumn";
			this.lvEXPDataGridViewTextBoxColumn.Width = 63;
			// 
			// lvMNYDataGridViewTextBoxColumn
			// 
			this.lvMNYDataGridViewTextBoxColumn.DataPropertyName = "LvMNY";
			this.lvMNYDataGridViewTextBoxColumn.HeaderText = "LvMNY";
			this.lvMNYDataGridViewTextBoxColumn.Name = "lvMNYDataGridViewTextBoxColumn";
			this.lvMNYDataGridViewTextBoxColumn.Width = 66;
			// 
			// hPPerDataGridViewTextBoxColumn
			// 
			this.hPPerDataGridViewTextBoxColumn.DataPropertyName = "HP Per";
			this.hPPerDataGridViewTextBoxColumn.HeaderText = "HP Per";
			this.hPPerDataGridViewTextBoxColumn.Name = "hPPerDataGridViewTextBoxColumn";
			this.hPPerDataGridViewTextBoxColumn.Width = 66;
			// 
			// meleeATKPerDataGridViewTextBoxColumn
			// 
			this.meleeATKPerDataGridViewTextBoxColumn.DataPropertyName = "MeleeATKPer";
			this.meleeATKPerDataGridViewTextBoxColumn.HeaderText = "MeleeATKPer";
			this.meleeATKPerDataGridViewTextBoxColumn.Name = "meleeATKPerDataGridViewTextBoxColumn";
			this.meleeATKPerDataGridViewTextBoxColumn.Width = 99;
			// 
			// meleeDEFPerDataGridViewTextBoxColumn
			// 
			this.meleeDEFPerDataGridViewTextBoxColumn.DataPropertyName = "MeleeDEFPer";
			this.meleeDEFPerDataGridViewTextBoxColumn.HeaderText = "MeleeDEFPer";
			this.meleeDEFPerDataGridViewTextBoxColumn.Name = "meleeDEFPerDataGridViewTextBoxColumn";
			this.meleeDEFPerDataGridViewTextBoxColumn.Width = 99;
			// 
			// rangeATKPerDataGridViewTextBoxColumn
			// 
			this.rangeATKPerDataGridViewTextBoxColumn.DataPropertyName = "RangeATKPer";
			this.rangeATKPerDataGridViewTextBoxColumn.HeaderText = "RangeATKPer";
			this.rangeATKPerDataGridViewTextBoxColumn.Name = "rangeATKPerDataGridViewTextBoxColumn";
			this.rangeATKPerDataGridViewTextBoxColumn.Width = 101;
			// 
			// rangeDEFPerDataGridViewTextBoxColumn
			// 
			this.rangeDEFPerDataGridViewTextBoxColumn.DataPropertyName = "RangeDEFPer";
			this.rangeDEFPerDataGridViewTextBoxColumn.HeaderText = "RangeDEFPer";
			this.rangeDEFPerDataGridViewTextBoxColumn.Name = "rangeDEFPerDataGridViewTextBoxColumn";
			this.rangeDEFPerDataGridViewTextBoxColumn.Width = 101;
			// 
			// magicATKPerDataGridViewTextBoxColumn
			// 
			this.magicATKPerDataGridViewTextBoxColumn.DataPropertyName = "MagicATKPer";
			this.magicATKPerDataGridViewTextBoxColumn.HeaderText = "MagicATKPer";
			this.magicATKPerDataGridViewTextBoxColumn.Name = "magicATKPerDataGridViewTextBoxColumn";
			this.magicATKPerDataGridViewTextBoxColumn.Width = 99;
			// 
			// magicDEFPerDataGridViewTextBoxColumn
			// 
			this.magicDEFPerDataGridViewTextBoxColumn.DataPropertyName = "MagicDEFPer";
			this.magicDEFPerDataGridViewTextBoxColumn.HeaderText = "MagicDEFPer";
			this.magicDEFPerDataGridViewTextBoxColumn.Name = "magicDEFPerDataGridViewTextBoxColumn";
			this.magicDEFPerDataGridViewTextBoxColumn.Width = 99;
			// 
			// sPDPerDataGridViewTextBoxColumn
			// 
			this.sPDPerDataGridViewTextBoxColumn.DataPropertyName = "SPD Per";
			this.sPDPerDataGridViewTextBoxColumn.HeaderText = "SPD Per";
			this.sPDPerDataGridViewTextBoxColumn.Name = "sPDPerDataGridViewTextBoxColumn";
			this.sPDPerDataGridViewTextBoxColumn.Width = 73;
			// 
			// eXPPerDataGridViewTextBoxColumn
			// 
			this.eXPPerDataGridViewTextBoxColumn.DataPropertyName = "EXP Per";
			this.eXPPerDataGridViewTextBoxColumn.HeaderText = "EXP Per";
			this.eXPPerDataGridViewTextBoxColumn.Name = "eXPPerDataGridViewTextBoxColumn";
			this.eXPPerDataGridViewTextBoxColumn.Width = 72;
			// 
			// mNYPerDataGridViewTextBoxColumn
			// 
			this.mNYPerDataGridViewTextBoxColumn.DataPropertyName = "MNY Per";
			this.mNYPerDataGridViewTextBoxColumn.HeaderText = "MNY Per";
			this.mNYPerDataGridViewTextBoxColumn.Name = "mNYPerDataGridViewTextBoxColumn";
			this.mNYPerDataGridViewTextBoxColumn.Width = 75;
			// 
			// wTDataGridViewTextBoxColumn
			// 
			this.wTDataGridViewTextBoxColumn.DataPropertyName = "WT";
			this.wTDataGridViewTextBoxColumn.HeaderText = "WT";
			this.wTDataGridViewTextBoxColumn.Name = "wTDataGridViewTextBoxColumn";
			this.wTDataGridViewTextBoxColumn.Width = 46;
			// 
			// sSPDataGridViewTextBoxColumn
			// 
			this.sSPDataGridViewTextBoxColumn.DataPropertyName = "SSP";
			this.sSPDataGridViewTextBoxColumn.HeaderText = "SSP";
			this.sSPDataGridViewTextBoxColumn.Name = "sSPDataGridViewTextBoxColumn";
			this.sSPDataGridViewTextBoxColumn.Width = 51;
			// 
			// sPCDataGridViewTextBoxColumn
			// 
			this.sPCDataGridViewTextBoxColumn.DataPropertyName = "SPC";
			this.sPCDataGridViewTextBoxColumn.HeaderText = "SPC";
			this.sPCDataGridViewTextBoxColumn.Name = "sPCDataGridViewTextBoxColumn";
			this.sPCDataGridViewTextBoxColumn.Width = 52;
			// 
			// aTCDataGridViewTextBoxColumn
			// 
			this.aTCDataGridViewTextBoxColumn.DataPropertyName = "ATC";
			this.aTCDataGridViewTextBoxColumn.HeaderText = "ATC";
			this.aTCDataGridViewTextBoxColumn.Name = "aTCDataGridViewTextBoxColumn";
			this.aTCDataGridViewTextBoxColumn.Width = 53;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.Width = 55;
			// 
			// dMGPerDataGridViewTextBoxColumn
			// 
			this.dMGPerDataGridViewTextBoxColumn.DataPropertyName = "DMG Per";
			this.dMGPerDataGridViewTextBoxColumn.HeaderText = "DMG Per";
			this.dMGPerDataGridViewTextBoxColumn.Name = "dMGPerDataGridViewTextBoxColumn";
			this.dMGPerDataGridViewTextBoxColumn.Width = 76;
			// 
			// airDataGridViewCheckBoxColumn
			// 
			this.airDataGridViewCheckBoxColumn.DataPropertyName = "Air";
			this.airDataGridViewCheckBoxColumn.HeaderText = "Air";
			this.airDataGridViewCheckBoxColumn.Name = "airDataGridViewCheckBoxColumn";
			this.airDataGridViewCheckBoxColumn.Width = 26;
			// 
			// verDataGridViewTextBoxColumn
			// 
			this.verDataGridViewTextBoxColumn.DataPropertyName = "Ver";
			this.verDataGridViewTextBoxColumn.HeaderText = "Ver";
			this.verDataGridViewTextBoxColumn.Name = "verDataGridViewTextBoxColumn";
			this.verDataGridViewTextBoxColumn.Width = 48;
			// 
			// algorithmDataGridViewTextBoxColumn
			// 
			this.algorithmDataGridViewTextBoxColumn.DataPropertyName = "Algorithm";
			this.algorithmDataGridViewTextBoxColumn.HeaderText = "Algorithm";
			this.algorithmDataGridViewTextBoxColumn.Name = "algorithmDataGridViewTextBoxColumn";
			this.algorithmDataGridViewTextBoxColumn.Width = 79;
			// 
			// aIIDDataGridViewTextBoxColumn
			// 
			this.aIIDDataGridViewTextBoxColumn.DataPropertyName = "AI ID";
			this.aIIDDataGridViewTextBoxColumn.HeaderText = "AI ID";
			this.aIIDDataGridViewTextBoxColumn.Name = "aIIDDataGridViewTextBoxColumn";
			this.aIIDDataGridViewTextBoxColumn.Width = 56;
			// 
			// rareDataGridViewTextBoxColumn
			// 
			this.rareDataGridViewTextBoxColumn.DataPropertyName = "Rare";
			this.rareDataGridViewTextBoxColumn.HeaderText = "Rare";
			this.rareDataGridViewTextBoxColumn.Name = "rareDataGridViewTextBoxColumn";
			this.rareDataGridViewTextBoxColumn.Width = 54;
			// 
			// rare2DataGridViewTextBoxColumn
			// 
			this.rare2DataGridViewTextBoxColumn.DataPropertyName = "Rare2";
			this.rare2DataGridViewTextBoxColumn.HeaderText = "Rare2";
			this.rare2DataGridViewTextBoxColumn.Name = "rare2DataGridViewTextBoxColumn";
			this.rare2DataGridViewTextBoxColumn.Width = 60;
			// 
			// item1DataGridViewTextBoxColumn
			// 
			this.item1DataGridViewTextBoxColumn.DataPropertyName = "Item1";
			this.item1DataGridViewTextBoxColumn.HeaderText = "Item1";
			this.item1DataGridViewTextBoxColumn.Name = "item1DataGridViewTextBoxColumn";
			this.item1DataGridViewTextBoxColumn.Width = 58;
			// 
			// per1DataGridViewTextBoxColumn
			// 
			this.per1DataGridViewTextBoxColumn.DataPropertyName = "Per1";
			this.per1DataGridViewTextBoxColumn.HeaderText = "Per1";
			this.per1DataGridViewTextBoxColumn.Name = "per1DataGridViewTextBoxColumn";
			this.per1DataGridViewTextBoxColumn.Width = 53;
			// 
			// item2DataGridViewTextBoxColumn
			// 
			this.item2DataGridViewTextBoxColumn.DataPropertyName = "Item2";
			this.item2DataGridViewTextBoxColumn.HeaderText = "Item2";
			this.item2DataGridViewTextBoxColumn.Name = "item2DataGridViewTextBoxColumn";
			this.item2DataGridViewTextBoxColumn.Width = 58;
			// 
			// per2DataGridViewTextBoxColumn
			// 
			this.per2DataGridViewTextBoxColumn.DataPropertyName = "Per2";
			this.per2DataGridViewTextBoxColumn.HeaderText = "Per2";
			this.per2DataGridViewTextBoxColumn.Name = "per2DataGridViewTextBoxColumn";
			this.per2DataGridViewTextBoxColumn.Width = 53;
			// 
			// item3DataGridViewTextBoxColumn
			// 
			this.item3DataGridViewTextBoxColumn.DataPropertyName = "Item3";
			this.item3DataGridViewTextBoxColumn.HeaderText = "Item3";
			this.item3DataGridViewTextBoxColumn.Name = "item3DataGridViewTextBoxColumn";
			this.item3DataGridViewTextBoxColumn.Width = 58;
			// 
			// per3DataGridViewTextBoxColumn
			// 
			this.per3DataGridViewTextBoxColumn.DataPropertyName = "Per3";
			this.per3DataGridViewTextBoxColumn.HeaderText = "Per3";
			this.per3DataGridViewTextBoxColumn.Name = "per3DataGridViewTextBoxColumn";
			this.per3DataGridViewTextBoxColumn.Width = 53;
			// 
			// item4DataGridViewTextBoxColumn
			// 
			this.item4DataGridViewTextBoxColumn.DataPropertyName = "Item4";
			this.item4DataGridViewTextBoxColumn.HeaderText = "Item4";
			this.item4DataGridViewTextBoxColumn.Name = "item4DataGridViewTextBoxColumn";
			this.item4DataGridViewTextBoxColumn.Width = 58;
			// 
			// per4DataGridViewTextBoxColumn
			// 
			this.per4DataGridViewTextBoxColumn.DataPropertyName = "Per4";
			this.per4DataGridViewTextBoxColumn.HeaderText = "Per4";
			this.per4DataGridViewTextBoxColumn.Name = "per4DataGridViewTextBoxColumn";
			this.per4DataGridViewTextBoxColumn.Width = 53;
			// 
			// item5DataGridViewTextBoxColumn
			// 
			this.item5DataGridViewTextBoxColumn.DataPropertyName = "Item5";
			this.item5DataGridViewTextBoxColumn.HeaderText = "Item5";
			this.item5DataGridViewTextBoxColumn.Name = "item5DataGridViewTextBoxColumn";
			this.item5DataGridViewTextBoxColumn.Width = 58;
			// 
			// per5DataGridViewTextBoxColumn
			// 
			this.per5DataGridViewTextBoxColumn.DataPropertyName = "Per5";
			this.per5DataGridViewTextBoxColumn.HeaderText = "Per5";
			this.per5DataGridViewTextBoxColumn.Name = "per5DataGridViewTextBoxColumn";
			this.per5DataGridViewTextBoxColumn.Width = 53;
			// 
			// item6DataGridViewTextBoxColumn
			// 
			this.item6DataGridViewTextBoxColumn.DataPropertyName = "Item6";
			this.item6DataGridViewTextBoxColumn.HeaderText = "Item6";
			this.item6DataGridViewTextBoxColumn.Name = "item6DataGridViewTextBoxColumn";
			this.item6DataGridViewTextBoxColumn.Width = 58;
			// 
			// per6DataGridViewTextBoxColumn
			// 
			this.per6DataGridViewTextBoxColumn.DataPropertyName = "Per6";
			this.per6DataGridViewTextBoxColumn.HeaderText = "Per6";
			this.per6DataGridViewTextBoxColumn.Name = "per6DataGridViewTextBoxColumn";
			this.per6DataGridViewTextBoxColumn.Width = 53;
			// 
			// skill1DataGridViewTextBoxColumn
			// 
			this.skill1DataGridViewTextBoxColumn.DataPropertyName = "Skill1";
			this.skill1DataGridViewTextBoxColumn.HeaderText = "Skill1";
			this.skill1DataGridViewTextBoxColumn.Name = "skill1DataGridViewTextBoxColumn";
			this.skill1DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill2DataGridViewTextBoxColumn
			// 
			this.skill2DataGridViewTextBoxColumn.DataPropertyName = "Skill2";
			this.skill2DataGridViewTextBoxColumn.HeaderText = "Skill2";
			this.skill2DataGridViewTextBoxColumn.Name = "skill2DataGridViewTextBoxColumn";
			this.skill2DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill3DataGridViewTextBoxColumn
			// 
			this.skill3DataGridViewTextBoxColumn.DataPropertyName = "Skill3";
			this.skill3DataGridViewTextBoxColumn.HeaderText = "Skill3";
			this.skill3DataGridViewTextBoxColumn.Name = "skill3DataGridViewTextBoxColumn";
			this.skill3DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill4DataGridViewTextBoxColumn
			// 
			this.skill4DataGridViewTextBoxColumn.DataPropertyName = "Skill4";
			this.skill4DataGridViewTextBoxColumn.HeaderText = "Skill4";
			this.skill4DataGridViewTextBoxColumn.Name = "skill4DataGridViewTextBoxColumn";
			this.skill4DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill5DataGridViewTextBoxColumn
			// 
			this.skill5DataGridViewTextBoxColumn.DataPropertyName = "Skill5";
			this.skill5DataGridViewTextBoxColumn.HeaderText = "Skill5";
			this.skill5DataGridViewTextBoxColumn.Name = "skill5DataGridViewTextBoxColumn";
			this.skill5DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill6DataGridViewTextBoxColumn
			// 
			this.skill6DataGridViewTextBoxColumn.DataPropertyName = "Skill6";
			this.skill6DataGridViewTextBoxColumn.HeaderText = "Skill6";
			this.skill6DataGridViewTextBoxColumn.Name = "skill6DataGridViewTextBoxColumn";
			this.skill6DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill7DataGridViewTextBoxColumn
			// 
			this.skill7DataGridViewTextBoxColumn.DataPropertyName = "Skill7";
			this.skill7DataGridViewTextBoxColumn.HeaderText = "Skill7";
			this.skill7DataGridViewTextBoxColumn.Name = "skill7DataGridViewTextBoxColumn";
			this.skill7DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill8DataGridViewTextBoxColumn
			// 
			this.skill8DataGridViewTextBoxColumn.DataPropertyName = "Skill8";
			this.skill8DataGridViewTextBoxColumn.HeaderText = "Skill8";
			this.skill8DataGridViewTextBoxColumn.Name = "skill8DataGridViewTextBoxColumn";
			this.skill8DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill9DataGridViewTextBoxColumn
			// 
			this.skill9DataGridViewTextBoxColumn.DataPropertyName = "Skill9";
			this.skill9DataGridViewTextBoxColumn.HeaderText = "Skill9";
			this.skill9DataGridViewTextBoxColumn.Name = "skill9DataGridViewTextBoxColumn";
			this.skill9DataGridViewTextBoxColumn.Width = 58;
			// 
			// skill10DataGridViewTextBoxColumn
			// 
			this.skill10DataGridViewTextBoxColumn.DataPropertyName = "Skill10";
			this.skill10DataGridViewTextBoxColumn.HeaderText = "Skill10";
			this.skill10DataGridViewTextBoxColumn.Name = "skill10DataGridViewTextBoxColumn";
			this.skill10DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill11DataGridViewTextBoxColumn
			// 
			this.skill11DataGridViewTextBoxColumn.DataPropertyName = "Skill11";
			this.skill11DataGridViewTextBoxColumn.HeaderText = "Skill11";
			this.skill11DataGridViewTextBoxColumn.Name = "skill11DataGridViewTextBoxColumn";
			this.skill11DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill12DataGridViewTextBoxColumn
			// 
			this.skill12DataGridViewTextBoxColumn.DataPropertyName = "Skill12";
			this.skill12DataGridViewTextBoxColumn.HeaderText = "Skill12";
			this.skill12DataGridViewTextBoxColumn.Name = "skill12DataGridViewTextBoxColumn";
			this.skill12DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill13DataGridViewTextBoxColumn
			// 
			this.skill13DataGridViewTextBoxColumn.DataPropertyName = "Skill13";
			this.skill13DataGridViewTextBoxColumn.HeaderText = "Skill13";
			this.skill13DataGridViewTextBoxColumn.Name = "skill13DataGridViewTextBoxColumn";
			this.skill13DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill14DataGridViewTextBoxColumn
			// 
			this.skill14DataGridViewTextBoxColumn.DataPropertyName = "Skill14";
			this.skill14DataGridViewTextBoxColumn.HeaderText = "Skill14";
			this.skill14DataGridViewTextBoxColumn.Name = "skill14DataGridViewTextBoxColumn";
			this.skill14DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill15DataGridViewTextBoxColumn
			// 
			this.skill15DataGridViewTextBoxColumn.DataPropertyName = "Skill15";
			this.skill15DataGridViewTextBoxColumn.HeaderText = "Skill15";
			this.skill15DataGridViewTextBoxColumn.Name = "skill15DataGridViewTextBoxColumn";
			this.skill15DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill16DataGridViewTextBoxColumn
			// 
			this.skill16DataGridViewTextBoxColumn.DataPropertyName = "Skill16";
			this.skill16DataGridViewTextBoxColumn.HeaderText = "Skill16";
			this.skill16DataGridViewTextBoxColumn.Name = "skill16DataGridViewTextBoxColumn";
			this.skill16DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill17DataGridViewTextBoxColumn
			// 
			this.skill17DataGridViewTextBoxColumn.DataPropertyName = "Skill17";
			this.skill17DataGridViewTextBoxColumn.HeaderText = "Skill17";
			this.skill17DataGridViewTextBoxColumn.Name = "skill17DataGridViewTextBoxColumn";
			this.skill17DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill18DataGridViewTextBoxColumn
			// 
			this.skill18DataGridViewTextBoxColumn.DataPropertyName = "Skill18";
			this.skill18DataGridViewTextBoxColumn.HeaderText = "Skill18";
			this.skill18DataGridViewTextBoxColumn.Name = "skill18DataGridViewTextBoxColumn";
			this.skill18DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill19DataGridViewTextBoxColumn
			// 
			this.skill19DataGridViewTextBoxColumn.DataPropertyName = "Skill19";
			this.skill19DataGridViewTextBoxColumn.HeaderText = "Skill19";
			this.skill19DataGridViewTextBoxColumn.Name = "skill19DataGridViewTextBoxColumn";
			this.skill19DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill20DataGridViewTextBoxColumn
			// 
			this.skill20DataGridViewTextBoxColumn.DataPropertyName = "Skill20";
			this.skill20DataGridViewTextBoxColumn.HeaderText = "Skill20";
			this.skill20DataGridViewTextBoxColumn.Name = "skill20DataGridViewTextBoxColumn";
			this.skill20DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill21DataGridViewTextBoxColumn
			// 
			this.skill21DataGridViewTextBoxColumn.DataPropertyName = "Skill21";
			this.skill21DataGridViewTextBoxColumn.HeaderText = "Skill21";
			this.skill21DataGridViewTextBoxColumn.Name = "skill21DataGridViewTextBoxColumn";
			this.skill21DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill22DataGridViewTextBoxColumn
			// 
			this.skill22DataGridViewTextBoxColumn.DataPropertyName = "Skill22";
			this.skill22DataGridViewTextBoxColumn.HeaderText = "Skill22";
			this.skill22DataGridViewTextBoxColumn.Name = "skill22DataGridViewTextBoxColumn";
			this.skill22DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill23DataGridViewTextBoxColumn
			// 
			this.skill23DataGridViewTextBoxColumn.DataPropertyName = "Skill23";
			this.skill23DataGridViewTextBoxColumn.HeaderText = "Skill23";
			this.skill23DataGridViewTextBoxColumn.Name = "skill23DataGridViewTextBoxColumn";
			this.skill23DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill24DataGridViewTextBoxColumn
			// 
			this.skill24DataGridViewTextBoxColumn.DataPropertyName = "Skill24";
			this.skill24DataGridViewTextBoxColumn.HeaderText = "Skill24";
			this.skill24DataGridViewTextBoxColumn.Name = "skill24DataGridViewTextBoxColumn";
			this.skill24DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill25DataGridViewTextBoxColumn
			// 
			this.skill25DataGridViewTextBoxColumn.DataPropertyName = "Skill25";
			this.skill25DataGridViewTextBoxColumn.HeaderText = "Skill25";
			this.skill25DataGridViewTextBoxColumn.Name = "skill25DataGridViewTextBoxColumn";
			this.skill25DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill26DataGridViewTextBoxColumn
			// 
			this.skill26DataGridViewTextBoxColumn.DataPropertyName = "Skill26";
			this.skill26DataGridViewTextBoxColumn.HeaderText = "Skill26";
			this.skill26DataGridViewTextBoxColumn.Name = "skill26DataGridViewTextBoxColumn";
			this.skill26DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill27DataGridViewTextBoxColumn
			// 
			this.skill27DataGridViewTextBoxColumn.DataPropertyName = "Skill27";
			this.skill27DataGridViewTextBoxColumn.HeaderText = "Skill27";
			this.skill27DataGridViewTextBoxColumn.Name = "skill27DataGridViewTextBoxColumn";
			this.skill27DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill28DataGridViewTextBoxColumn
			// 
			this.skill28DataGridViewTextBoxColumn.DataPropertyName = "Skill28";
			this.skill28DataGridViewTextBoxColumn.HeaderText = "Skill28";
			this.skill28DataGridViewTextBoxColumn.Name = "skill28DataGridViewTextBoxColumn";
			this.skill28DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill29DataGridViewTextBoxColumn
			// 
			this.skill29DataGridViewTextBoxColumn.DataPropertyName = "Skill29";
			this.skill29DataGridViewTextBoxColumn.HeaderText = "Skill29";
			this.skill29DataGridViewTextBoxColumn.Name = "skill29DataGridViewTextBoxColumn";
			this.skill29DataGridViewTextBoxColumn.Width = 64;
			// 
			// skill30DataGridViewTextBoxColumn
			// 
			this.skill30DataGridViewTextBoxColumn.DataPropertyName = "Skill30";
			this.skill30DataGridViewTextBoxColumn.HeaderText = "Skill30";
			this.skill30DataGridViewTextBoxColumn.Name = "skill30DataGridViewTextBoxColumn";
			this.skill30DataGridViewTextBoxColumn.Width = 64;
			// 
			// ability1DataGridViewTextBoxColumn
			// 
			this.ability1DataGridViewTextBoxColumn.DataPropertyName = "Ability1";
			this.ability1DataGridViewTextBoxColumn.HeaderText = "Ability1";
			this.ability1DataGridViewTextBoxColumn.Name = "ability1DataGridViewTextBoxColumn";
			this.ability1DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability2DataGridViewTextBoxColumn
			// 
			this.ability2DataGridViewTextBoxColumn.DataPropertyName = "Ability2";
			this.ability2DataGridViewTextBoxColumn.HeaderText = "Ability2";
			this.ability2DataGridViewTextBoxColumn.Name = "ability2DataGridViewTextBoxColumn";
			this.ability2DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability3DataGridViewTextBoxColumn
			// 
			this.ability3DataGridViewTextBoxColumn.DataPropertyName = "Ability3";
			this.ability3DataGridViewTextBoxColumn.HeaderText = "Ability3";
			this.ability3DataGridViewTextBoxColumn.Name = "ability3DataGridViewTextBoxColumn";
			this.ability3DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability4DataGridViewTextBoxColumn
			// 
			this.ability4DataGridViewTextBoxColumn.DataPropertyName = "Ability4";
			this.ability4DataGridViewTextBoxColumn.HeaderText = "Ability4";
			this.ability4DataGridViewTextBoxColumn.Name = "ability4DataGridViewTextBoxColumn";
			this.ability4DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability5DataGridViewTextBoxColumn
			// 
			this.ability5DataGridViewTextBoxColumn.DataPropertyName = "Ability5";
			this.ability5DataGridViewTextBoxColumn.HeaderText = "Ability5";
			this.ability5DataGridViewTextBoxColumn.Name = "ability5DataGridViewTextBoxColumn";
			this.ability5DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability6DataGridViewTextBoxColumn
			// 
			this.ability6DataGridViewTextBoxColumn.DataPropertyName = "Ability6";
			this.ability6DataGridViewTextBoxColumn.HeaderText = "Ability6";
			this.ability6DataGridViewTextBoxColumn.Name = "ability6DataGridViewTextBoxColumn";
			this.ability6DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability7DataGridViewTextBoxColumn
			// 
			this.ability7DataGridViewTextBoxColumn.DataPropertyName = "Ability7";
			this.ability7DataGridViewTextBoxColumn.HeaderText = "Ability7";
			this.ability7DataGridViewTextBoxColumn.Name = "ability7DataGridViewTextBoxColumn";
			this.ability7DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability8DataGridViewTextBoxColumn
			// 
			this.ability8DataGridViewTextBoxColumn.DataPropertyName = "Ability8";
			this.ability8DataGridViewTextBoxColumn.HeaderText = "Ability8";
			this.ability8DataGridViewTextBoxColumn.Name = "ability8DataGridViewTextBoxColumn";
			this.ability8DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability9DataGridViewTextBoxColumn
			// 
			this.ability9DataGridViewTextBoxColumn.DataPropertyName = "Ability9";
			this.ability9DataGridViewTextBoxColumn.HeaderText = "Ability9";
			this.ability9DataGridViewTextBoxColumn.Name = "ability9DataGridViewTextBoxColumn";
			this.ability9DataGridViewTextBoxColumn.Width = 69;
			// 
			// ability10DataGridViewTextBoxColumn
			// 
			this.ability10DataGridViewTextBoxColumn.DataPropertyName = "Ability10";
			this.ability10DataGridViewTextBoxColumn.HeaderText = "Ability10";
			this.ability10DataGridViewTextBoxColumn.Name = "ability10DataGridViewTextBoxColumn";
			this.ability10DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability11DataGridViewTextBoxColumn
			// 
			this.ability11DataGridViewTextBoxColumn.DataPropertyName = "Ability11";
			this.ability11DataGridViewTextBoxColumn.HeaderText = "Ability11";
			this.ability11DataGridViewTextBoxColumn.Name = "ability11DataGridViewTextBoxColumn";
			this.ability11DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability12DataGridViewTextBoxColumn
			// 
			this.ability12DataGridViewTextBoxColumn.DataPropertyName = "Ability12";
			this.ability12DataGridViewTextBoxColumn.HeaderText = "Ability12";
			this.ability12DataGridViewTextBoxColumn.Name = "ability12DataGridViewTextBoxColumn";
			this.ability12DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability13DataGridViewTextBoxColumn
			// 
			this.ability13DataGridViewTextBoxColumn.DataPropertyName = "Ability13";
			this.ability13DataGridViewTextBoxColumn.HeaderText = "Ability13";
			this.ability13DataGridViewTextBoxColumn.Name = "ability13DataGridViewTextBoxColumn";
			this.ability13DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability14DataGridViewTextBoxColumn
			// 
			this.ability14DataGridViewTextBoxColumn.DataPropertyName = "Ability14";
			this.ability14DataGridViewTextBoxColumn.HeaderText = "Ability14";
			this.ability14DataGridViewTextBoxColumn.Name = "ability14DataGridViewTextBoxColumn";
			this.ability14DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability15DataGridViewTextBoxColumn
			// 
			this.ability15DataGridViewTextBoxColumn.DataPropertyName = "Ability15";
			this.ability15DataGridViewTextBoxColumn.HeaderText = "Ability15";
			this.ability15DataGridViewTextBoxColumn.Name = "ability15DataGridViewTextBoxColumn";
			this.ability15DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability16DataGridViewTextBoxColumn
			// 
			this.ability16DataGridViewTextBoxColumn.DataPropertyName = "Ability16";
			this.ability16DataGridViewTextBoxColumn.HeaderText = "Ability16";
			this.ability16DataGridViewTextBoxColumn.Name = "ability16DataGridViewTextBoxColumn";
			this.ability16DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability17DataGridViewTextBoxColumn
			// 
			this.ability17DataGridViewTextBoxColumn.DataPropertyName = "Ability17";
			this.ability17DataGridViewTextBoxColumn.HeaderText = "Ability17";
			this.ability17DataGridViewTextBoxColumn.Name = "ability17DataGridViewTextBoxColumn";
			this.ability17DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability18DataGridViewTextBoxColumn
			// 
			this.ability18DataGridViewTextBoxColumn.DataPropertyName = "Ability18";
			this.ability18DataGridViewTextBoxColumn.HeaderText = "Ability18";
			this.ability18DataGridViewTextBoxColumn.Name = "ability18DataGridViewTextBoxColumn";
			this.ability18DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability19DataGridViewTextBoxColumn
			// 
			this.ability19DataGridViewTextBoxColumn.DataPropertyName = "Ability19";
			this.ability19DataGridViewTextBoxColumn.HeaderText = "Ability19";
			this.ability19DataGridViewTextBoxColumn.Name = "ability19DataGridViewTextBoxColumn";
			this.ability19DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability20DataGridViewTextBoxColumn
			// 
			this.ability20DataGridViewTextBoxColumn.DataPropertyName = "Ability20";
			this.ability20DataGridViewTextBoxColumn.HeaderText = "Ability20";
			this.ability20DataGridViewTextBoxColumn.Name = "ability20DataGridViewTextBoxColumn";
			this.ability20DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability21DataGridViewTextBoxColumn
			// 
			this.ability21DataGridViewTextBoxColumn.DataPropertyName = "Ability21";
			this.ability21DataGridViewTextBoxColumn.HeaderText = "Ability21";
			this.ability21DataGridViewTextBoxColumn.Name = "ability21DataGridViewTextBoxColumn";
			this.ability21DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability22DataGridViewTextBoxColumn
			// 
			this.ability22DataGridViewTextBoxColumn.DataPropertyName = "Ability22";
			this.ability22DataGridViewTextBoxColumn.HeaderText = "Ability22";
			this.ability22DataGridViewTextBoxColumn.Name = "ability22DataGridViewTextBoxColumn";
			this.ability22DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability23DataGridViewTextBoxColumn
			// 
			this.ability23DataGridViewTextBoxColumn.DataPropertyName = "Ability23";
			this.ability23DataGridViewTextBoxColumn.HeaderText = "Ability23";
			this.ability23DataGridViewTextBoxColumn.Name = "ability23DataGridViewTextBoxColumn";
			this.ability23DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability24DataGridViewTextBoxColumn
			// 
			this.ability24DataGridViewTextBoxColumn.DataPropertyName = "Ability24";
			this.ability24DataGridViewTextBoxColumn.HeaderText = "Ability24";
			this.ability24DataGridViewTextBoxColumn.Name = "ability24DataGridViewTextBoxColumn";
			this.ability24DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability25DataGridViewTextBoxColumn
			// 
			this.ability25DataGridViewTextBoxColumn.DataPropertyName = "Ability25";
			this.ability25DataGridViewTextBoxColumn.HeaderText = "Ability25";
			this.ability25DataGridViewTextBoxColumn.Name = "ability25DataGridViewTextBoxColumn";
			this.ability25DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability26DataGridViewTextBoxColumn
			// 
			this.ability26DataGridViewTextBoxColumn.DataPropertyName = "Ability26";
			this.ability26DataGridViewTextBoxColumn.HeaderText = "Ability26";
			this.ability26DataGridViewTextBoxColumn.Name = "ability26DataGridViewTextBoxColumn";
			this.ability26DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability27DataGridViewTextBoxColumn
			// 
			this.ability27DataGridViewTextBoxColumn.DataPropertyName = "Ability27";
			this.ability27DataGridViewTextBoxColumn.HeaderText = "Ability27";
			this.ability27DataGridViewTextBoxColumn.Name = "ability27DataGridViewTextBoxColumn";
			this.ability27DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability28DataGridViewTextBoxColumn
			// 
			this.ability28DataGridViewTextBoxColumn.DataPropertyName = "Ability28";
			this.ability28DataGridViewTextBoxColumn.HeaderText = "Ability28";
			this.ability28DataGridViewTextBoxColumn.Name = "ability28DataGridViewTextBoxColumn";
			this.ability28DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability29DataGridViewTextBoxColumn
			// 
			this.ability29DataGridViewTextBoxColumn.DataPropertyName = "Ability29";
			this.ability29DataGridViewTextBoxColumn.HeaderText = "Ability29";
			this.ability29DataGridViewTextBoxColumn.Name = "ability29DataGridViewTextBoxColumn";
			this.ability29DataGridViewTextBoxColumn.Width = 75;
			// 
			// ability30DataGridViewTextBoxColumn
			// 
			this.ability30DataGridViewTextBoxColumn.DataPropertyName = "Ability30";
			this.ability30DataGridViewTextBoxColumn.HeaderText = "Ability30";
			this.ability30DataGridViewTextBoxColumn.Name = "ability30DataGridViewTextBoxColumn";
			this.ability30DataGridViewTextBoxColumn.Width = 75;
			// 
			// infoDataGridViewTextBoxColumn
			// 
			this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
			this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
			this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
			this.infoDataGridViewTextBoxColumn.Width = 49;
			// 
			// FormUnit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1440, 810);
			this.Controls.Add(this.ToolStripContainer);
			this.Name = "FormUnit";
			this.Text = "Unit Table";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUnit_FormClosed);
			this.Load += new System.EventHandler(this.TestForm_Load);
			this.ToolStripContainer.ContentPanel.ResumeLayout(false);
			this.ToolStripContainer.ResumeLayout(false);
			this.ToolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableunitBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolStripContainer ToolStripContainer;
		private DataGridView dataGridView1;
		private GigaBattlerDataSet gigaBattlerDataSet;
		private BindingSource tableunitBindingSource;
		private GigaBattlerDataSetTableAdapters.__table_unitTableAdapter ___table_unitTableAdapter;
		private DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn reqLvDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn minLvDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn maxLvDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn startTPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn maxTPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn meleeATKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn meleeDEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rangeATKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rangeDEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn magicATKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn magicDEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sPDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lUKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hITDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn eVTDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn eXPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mNYDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvHPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvMeleeATKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvMeleeDEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvRangeATKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvRangeDEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvMagicATKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvMagicDEFDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvSPDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvLUKDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvHITDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvEVTDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvEXPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lvMNYDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hPPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn meleeATKPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn meleeDEFPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rangeATKPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rangeDEFPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn magicATKPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn magicDEFPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sPDPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn eXPPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mNYPerDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn wTDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sSPDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sPCDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn aTCDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dMGPerDataGridViewTextBoxColumn;
		private DataGridViewCheckBoxColumn airDataGridViewCheckBoxColumn;
		private DataGridViewTextBoxColumn verDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn algorithmDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn aIIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rareDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn rare2DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn item1DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn per1DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn item2DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn per2DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn item3DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn per3DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn item4DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn per4DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn item5DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn per5DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn item6DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn per6DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill1DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill2DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill3DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill4DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill5DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill6DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill7DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill8DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill9DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill10DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill11DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill12DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill13DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill14DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill15DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill16DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill17DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill18DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill19DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill20DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill21DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill22DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill23DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill24DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill25DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill26DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill27DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill28DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill29DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn skill30DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability1DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability2DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability3DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability4DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability5DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability6DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability7DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability8DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability9DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability10DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability11DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability12DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability13DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability14DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability15DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability16DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability17DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability18DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability19DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability20DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability21DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability22DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability23DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability24DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability25DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability26DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability27DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability28DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability29DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ability30DataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
	}
}
