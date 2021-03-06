﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Status_Editer.User_Control.tab03Unit {
	partial class UnitInfomation {
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

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitInfomation));
			this.groupUnitInfo = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericWT = new System.Windows.Forms.NumericUpDown();
			this.labelWT = new System.Windows.Forms.Label();
			this.numericRare2 = new System.Windows.Forms.NumericUpDown();
			this.labelRare2 = new System.Windows.Forms.Label();
			this.labelInfo = new System.Windows.Forms.Label();
			this.textInfo = new System.Windows.Forms.TextBox();
			this.numericRare = new System.Windows.Forms.NumericUpDown();
			this.labelRare = new System.Windows.Forms.Label();
			this.checkAirType = new System.Windows.Forms.CheckBox();
			this.textUnitName = new System.Windows.Forms.TextBox();
			this.labelUnitName = new System.Windows.Forms.Label();
			this.comboMonsterGroup = new System.Windows.Forms.ComboBox();
			this.labelMonsterGroup = new System.Windows.Forms.Label();
			this.textUnitID = new System.Windows.Forms.TextBox();
			this.labelUnitID = new System.Windows.Forms.Label();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.groupUnitInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericWT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRare2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRare)).BeginInit();
			this.SuspendLayout();
			// 
			// groupUnitInfo
			// 
			this.groupUnitInfo.Controls.Add(this.label2);
			this.groupUnitInfo.Controls.Add(this.numericWT);
			this.groupUnitInfo.Controls.Add(this.labelWT);
			this.groupUnitInfo.Controls.Add(this.numericRare2);
			this.groupUnitInfo.Controls.Add(this.labelRare2);
			this.groupUnitInfo.Controls.Add(this.labelInfo);
			this.groupUnitInfo.Controls.Add(this.textInfo);
			this.groupUnitInfo.Controls.Add(this.numericRare);
			this.groupUnitInfo.Controls.Add(this.labelRare);
			this.groupUnitInfo.Controls.Add(this.checkAirType);
			this.groupUnitInfo.Controls.Add(this.textUnitName);
			this.groupUnitInfo.Controls.Add(this.labelUnitName);
			this.groupUnitInfo.Controls.Add(this.comboMonsterGroup);
			this.groupUnitInfo.Controls.Add(this.labelMonsterGroup);
			this.groupUnitInfo.Controls.Add(this.textUnitID);
			this.groupUnitInfo.Controls.Add(this.labelUnitID);
			resources.ApplyResources(this.groupUnitInfo, "groupUnitInfo");
			this.groupUnitInfo.Name = "groupUnitInfo";
			this.groupUnitInfo.TabStop = false;
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Name = "label2";
			// 
			// numericWT
			// 
			resources.ApplyResources(this.numericWT, "numericWT");
			this.numericWT.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericWT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericWT.Name = "numericWT";
			this.toolTipInfo.SetToolTip(this.numericWT, resources.GetString("numericWT.ToolTip"));
			this.numericWT.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
			// 
			// labelWT
			// 
			resources.ApplyResources(this.labelWT, "labelWT");
			this.labelWT.Name = "labelWT";
			// 
			// numericRare2
			// 
			resources.ApplyResources(this.numericRare2, "numericRare2");
			this.numericRare2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericRare2.Name = "numericRare2";
			this.toolTipInfo.SetToolTip(this.numericRare2, resources.GetString("numericRare2.ToolTip"));
			// 
			// labelRare2
			// 
			resources.ApplyResources(this.labelRare2, "labelRare2");
			this.labelRare2.Name = "labelRare2";
			// 
			// labelInfo
			// 
			resources.ApplyResources(this.labelInfo, "labelInfo");
			this.labelInfo.Name = "labelInfo";
			// 
			// textInfo
			// 
			resources.ApplyResources(this.textInfo, "textInfo");
			this.textInfo.Name = "textInfo";
			this.toolTipInfo.SetToolTip(this.textInfo, resources.GetString("textInfo.ToolTip"));
			// 
			// numericRare
			// 
			resources.ApplyResources(this.numericRare, "numericRare");
			this.numericRare.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numericRare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericRare.Name = "numericRare";
			this.numericRare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelRare
			// 
			resources.ApplyResources(this.labelRare, "labelRare");
			this.labelRare.Name = "labelRare";
			// 
			// checkAirType
			// 
			resources.ApplyResources(this.checkAirType, "checkAirType");
			this.checkAirType.Name = "checkAirType";
			this.toolTipInfo.SetToolTip(this.checkAirType, resources.GetString("checkAirType.ToolTip"));
			this.checkAirType.UseVisualStyleBackColor = true;
			// 
			// textUnitName
			// 
			resources.ApplyResources(this.textUnitName, "textUnitName");
			this.textUnitName.Name = "textUnitName";
			this.toolTipInfo.SetToolTip(this.textUnitName, resources.GetString("textUnitName.ToolTip"));
			// 
			// labelUnitName
			// 
			resources.ApplyResources(this.labelUnitName, "labelUnitName");
			this.labelUnitName.Name = "labelUnitName";
			// 
			// comboMonsterGroup
			// 
			this.comboMonsterGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboMonsterGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboMonsterGroup.FormattingEnabled = true;
			resources.ApplyResources(this.comboMonsterGroup, "comboMonsterGroup");
			this.comboMonsterGroup.Name = "comboMonsterGroup";
			this.toolTipInfo.SetToolTip(this.comboMonsterGroup, resources.GetString("comboMonsterGroup.ToolTip"));
			// 
			// labelMonsterGroup
			// 
			resources.ApplyResources(this.labelMonsterGroup, "labelMonsterGroup");
			this.labelMonsterGroup.Name = "labelMonsterGroup";
			// 
			// textUnitID
			// 
			resources.ApplyResources(this.textUnitID, "textUnitID");
			this.textUnitID.Name = "textUnitID";
			this.toolTipInfo.SetToolTip(this.textUnitID, resources.GetString("textUnitID.ToolTip"));
			// 
			// labelUnitID
			// 
			resources.ApplyResources(this.labelUnitID, "labelUnitID");
			this.labelUnitID.Name = "labelUnitID";
			// 
			// toolTipInfo
			// 
			this.toolTipInfo.AutoPopDelay = 50000;
			this.toolTipInfo.InitialDelay = 500;
			this.toolTipInfo.IsBalloon = true;
			this.toolTipInfo.ReshowDelay = 100;
			this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipInfo.ToolTipTitle = "Infomation";
			// 
			// UnitInfomation
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupUnitInfo);
			this.Name = "UnitInfomation";
			this.groupUnitInfo.ResumeLayout(false);
			this.groupUnitInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericWT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRare2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRare)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupUnitInfo;
		private Label labelRare;
		private Label labelUnitName;
		private Label labelMonsterGroup;
		private Label labelUnitID;
		private TextBox textUnitID;
		private TextBox textUnitName;
		private CheckBox checkAirType;
		private ComboBox comboMonsterGroup;
		private NumericUpDown numericRare;
		private ToolTip toolTipInfo;
		private Label labelInfo;
		private TextBox textInfo;
		private NumericUpDown numericRare2;
		private Label labelRare2;
		private Label label2;
		private NumericUpDown numericWT;
		private Label labelWT;
	}
}
