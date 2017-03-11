using CommonLibrary;
using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer {
	partial class FormArea {
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
			this.DataGridViewArea = new System.Windows.Forms.DataGridView();
			this.tableAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gigaBattlerDataSet = new CommonLibrary.GigaBattlerDataSet();
			this.___table_areaTableAdapter = new CommonLibrary.GigaBattlerDataSetTableAdapters.@__table_areaTableAdapter();
			this.areaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.areaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.battleID1DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID2DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID3DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID4DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID5DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID6DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID7DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID8DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID9DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.battleID10DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea1DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea2DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea3DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea4DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea5DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea6DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea7DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea8DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea9DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.movetoArea10DataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.infoDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewArea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tableAreaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.DataGridViewArea);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1440, 785);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(1440, 810);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// DataGridViewArea
			// 
			this.DataGridViewArea.AutoGenerateColumns = false;
			this.DataGridViewArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaIDDataGridViewTextBoxColumn,
            this.areaNameDataGridViewTextBoxColumn,
            this.battleID1DataGridViewComboBoxColumn,
            this.battleID2DataGridViewComboBoxColumn,
            this.battleID3DataGridViewComboBoxColumn,
            this.battleID4DataGridViewComboBoxColumn,
            this.battleID5DataGridViewComboBoxColumn,
            this.battleID6DataGridViewComboBoxColumn,
            this.battleID7DataGridViewComboBoxColumn,
            this.battleID8DataGridViewComboBoxColumn,
            this.battleID9DataGridViewComboBoxColumn,
            this.battleID10DataGridViewComboBoxColumn,
            this.movetoArea1DataGridViewComboBoxColumn,
            this.movetoArea2DataGridViewComboBoxColumn,
            this.movetoArea3DataGridViewComboBoxColumn,
            this.movetoArea4DataGridViewComboBoxColumn,
            this.movetoArea5DataGridViewComboBoxColumn,
            this.movetoArea6DataGridViewComboBoxColumn,
            this.movetoArea7DataGridViewComboBoxColumn,
            this.movetoArea8DataGridViewComboBoxColumn,
            this.movetoArea9DataGridViewComboBoxColumn,
            this.movetoArea10DataGridViewComboBoxColumn,
            this.infoDataGridViewComboBoxColumn});
			this.DataGridViewArea.DataSource = this.tableAreaBindingSource;
			this.DataGridViewArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridViewArea.Location = new System.Drawing.Point(0, 0);
			this.DataGridViewArea.Name = "DataGridViewArea";
			this.DataGridViewArea.Size = new System.Drawing.Size(1440, 785);
			this.DataGridViewArea.TabIndex = 0;
			this.DataGridViewArea.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridViewArea_DataError);
			// 
			// tableAreaBindingSource
			// 
			this.tableAreaBindingSource.DataMember = "__table_area";
			this.tableAreaBindingSource.DataSource = this.gigaBattlerDataSet;
			// 
			// gigaBattlerDataSet
			// 
			this.gigaBattlerDataSet.DataSetName = "GigaBattlerDataSet";
			this.gigaBattlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ___table_areaTableAdapter
			// 
			this.___table_areaTableAdapter.ClearBeforeFill = true;
			// 
			// areaIDDataGridViewTextBoxColumn
			// 
			this.areaIDDataGridViewTextBoxColumn.DataPropertyName = "AreaID";
			this.areaIDDataGridViewTextBoxColumn.HeaderText = "AreaID";
			this.areaIDDataGridViewTextBoxColumn.Name = "areaIDDataGridViewTextBoxColumn";
			// 
			// areaNameDataGridViewTextBoxColumn
			// 
			this.areaNameDataGridViewTextBoxColumn.DataPropertyName = "AreaName";
			this.areaNameDataGridViewTextBoxColumn.HeaderText = "AreaName";
			this.areaNameDataGridViewTextBoxColumn.Name = "areaNameDataGridViewTextBoxColumn";
			// 
			// battleID1DataGridViewComboBoxColumn
			// 
			this.battleID1DataGridViewComboBoxColumn.DataPropertyName = "BattleID1";
			this.battleID1DataGridViewComboBoxColumn.HeaderText = "BattleID1";
			this.battleID1DataGridViewComboBoxColumn.Name = "battleID1DataGridViewComboBoxColumn";
			// 
			// battleID2DataGridViewComboBoxColumn
			// 
			this.battleID2DataGridViewComboBoxColumn.DataPropertyName = "BattleID2";
			this.battleID2DataGridViewComboBoxColumn.HeaderText = "BattleID2";
			this.battleID2DataGridViewComboBoxColumn.Name = "battleID2DataGridViewComboBoxColumn";
			// 
			// battleID3DataGridViewComboBoxColumn
			// 
			this.battleID3DataGridViewComboBoxColumn.DataPropertyName = "BattleID3";
			this.battleID3DataGridViewComboBoxColumn.HeaderText = "BattleID3";
			this.battleID3DataGridViewComboBoxColumn.Name = "battleID3DataGridViewComboBoxColumn";
			// 
			// battleID4DataGridViewComboBoxColumn
			// 
			this.battleID4DataGridViewComboBoxColumn.DataPropertyName = "BattleID4";
			this.battleID4DataGridViewComboBoxColumn.HeaderText = "BattleID4";
			this.battleID4DataGridViewComboBoxColumn.Name = "battleID4DataGridViewComboBoxColumn";
			// 
			// battleID5DataGridViewComboBoxColumn
			// 
			this.battleID5DataGridViewComboBoxColumn.DataPropertyName = "BattleID5";
			this.battleID5DataGridViewComboBoxColumn.HeaderText = "BattleID5";
			this.battleID5DataGridViewComboBoxColumn.Name = "battleID5DataGridViewComboBoxColumn";
			// 
			// battleID6DataGridViewComboBoxColumn
			// 
			this.battleID6DataGridViewComboBoxColumn.DataPropertyName = "BattleID6";
			this.battleID6DataGridViewComboBoxColumn.HeaderText = "BattleID6";
			this.battleID6DataGridViewComboBoxColumn.Name = "battleID6DataGridViewComboBoxColumn";
			// 
			// battleID7DataGridViewComboBoxColumn
			// 
			this.battleID7DataGridViewComboBoxColumn.DataPropertyName = "BattleID7";
			this.battleID7DataGridViewComboBoxColumn.HeaderText = "BattleID7";
			this.battleID7DataGridViewComboBoxColumn.Name = "battleID7DataGridViewComboBoxColumn";
			// 
			// battleID8DataGridViewComboBoxColumn
			// 
			this.battleID8DataGridViewComboBoxColumn.DataPropertyName = "BattleID8";
			this.battleID8DataGridViewComboBoxColumn.HeaderText = "BattleID8";
			this.battleID8DataGridViewComboBoxColumn.Name = "battleID8DataGridViewComboBoxColumn";
			// 
			// battleID9DataGridViewComboBoxColumn
			// 
			this.battleID9DataGridViewComboBoxColumn.DataPropertyName = "BattleID9";
			this.battleID9DataGridViewComboBoxColumn.HeaderText = "BattleID9";
			this.battleID9DataGridViewComboBoxColumn.Name = "battleID9DataGridViewComboBoxColumn";
			// 
			// battleID10DataGridViewComboBoxColumn
			// 
			this.battleID10DataGridViewComboBoxColumn.DataPropertyName = "BattleID10";
			this.battleID10DataGridViewComboBoxColumn.HeaderText = "BattleID10";
			this.battleID10DataGridViewComboBoxColumn.Name = "battleID10DataGridViewComboBoxColumn";
			// 
			// movetoArea1DataGridViewComboBoxColumn
			// 
			this.movetoArea1DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea1";
			this.movetoArea1DataGridViewComboBoxColumn.HeaderText = "MovetoArea1";
			this.movetoArea1DataGridViewComboBoxColumn.Name = "movetoArea1DataGridViewComboBoxColumn";
			// 
			// movetoArea2DataGridViewComboBoxColumn
			// 
			this.movetoArea2DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea2";
			this.movetoArea2DataGridViewComboBoxColumn.HeaderText = "MovetoArea2";
			this.movetoArea2DataGridViewComboBoxColumn.Name = "movetoArea2DataGridViewComboBoxColumn";
			// 
			// movetoArea3DataGridViewComboBoxColumn
			// 
			this.movetoArea3DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea3";
			this.movetoArea3DataGridViewComboBoxColumn.HeaderText = "MovetoArea3";
			this.movetoArea3DataGridViewComboBoxColumn.Name = "movetoArea3DataGridViewComboBoxColumn";
			// 
			// movetoArea4DataGridViewComboBoxColumn
			// 
			this.movetoArea4DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea4";
			this.movetoArea4DataGridViewComboBoxColumn.HeaderText = "MovetoArea4";
			this.movetoArea4DataGridViewComboBoxColumn.Name = "movetoArea4DataGridViewComboBoxColumn";
			// 
			// movetoArea5DataGridViewComboBoxColumn
			// 
			this.movetoArea5DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea5";
			this.movetoArea5DataGridViewComboBoxColumn.HeaderText = "MovetoArea5";
			this.movetoArea5DataGridViewComboBoxColumn.Name = "movetoArea5DataGridViewComboBoxColumn";
			// 
			// movetoArea6DataGridViewComboBoxColumn
			// 
			this.movetoArea6DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea6";
			this.movetoArea6DataGridViewComboBoxColumn.HeaderText = "MovetoArea6";
			this.movetoArea6DataGridViewComboBoxColumn.Name = "movetoArea6DataGridViewComboBoxColumn";
			// 
			// movetoArea7DataGridViewComboBoxColumn
			// 
			this.movetoArea7DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea7";
			this.movetoArea7DataGridViewComboBoxColumn.HeaderText = "MovetoArea7";
			this.movetoArea7DataGridViewComboBoxColumn.Name = "movetoArea7DataGridViewComboBoxColumn";
			// 
			// movetoArea8DataGridViewComboBoxColumn
			// 
			this.movetoArea8DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea8";
			this.movetoArea8DataGridViewComboBoxColumn.HeaderText = "MovetoArea8";
			this.movetoArea8DataGridViewComboBoxColumn.Name = "movetoArea8DataGridViewComboBoxColumn";
			// 
			// movetoArea9DataGridViewComboBoxColumn
			// 
			this.movetoArea9DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea9";
			this.movetoArea9DataGridViewComboBoxColumn.HeaderText = "MovetoArea9";
			this.movetoArea9DataGridViewComboBoxColumn.Name = "movetoArea9DataGridViewComboBoxColumn";
			// 
			// movetoArea10DataGridViewComboBoxColumn
			// 
			this.movetoArea10DataGridViewComboBoxColumn.DataPropertyName = "MovetoArea10";
			this.movetoArea10DataGridViewComboBoxColumn.HeaderText = "MovetoArea10";
			this.movetoArea10DataGridViewComboBoxColumn.Name = "movetoArea10DataGridViewComboBoxColumn";
			// 
			// infoDataGridViewComboBoxColumn
			// 
			this.infoDataGridViewComboBoxColumn.DataPropertyName = "Info";
			this.infoDataGridViewComboBoxColumn.HeaderText = "Info";
			this.infoDataGridViewComboBoxColumn.Name = "infoDataGridViewComboBoxColumn";
			// 
			// FormArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 810);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "FormArea";
			this.Text = "Area Table";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormArea_FormClosed);
			this.Load += new System.EventHandler(this.FormArea_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewArea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tableAreaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gigaBattlerDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ToolStripContainer toolStripContainer1;
		private DataGridView DataGridViewArea;
		private GigaBattlerDataSet gigaBattlerDataSet;
		private BindingSource tableAreaBindingSource;
		private CommonLibrary.GigaBattlerDataSetTableAdapters.__table_areaTableAdapter ___table_areaTableAdapter;
		private DataGridViewTextBoxColumn areaIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn areaNameDataGridViewTextBoxColumn;
		private DataGridViewComboBoxColumn battleID1DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID2DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID3DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID4DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID5DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID6DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID7DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID8DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID9DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn battleID10DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea1DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea2DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea3DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea4DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea5DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea6DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea7DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea8DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea9DataGridViewComboBoxColumn;
		private DataGridViewComboBoxColumn movetoArea10DataGridViewComboBoxColumn;
		private DataGridViewTextBoxColumn infoDataGridViewComboBoxColumn;
	}
}