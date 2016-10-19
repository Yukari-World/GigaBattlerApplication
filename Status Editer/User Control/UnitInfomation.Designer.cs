namespace Status_Editer.User_Control {
	partial class UnitInfomation {
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.numericRare = new System.Windows.Forms.NumericUpDown();
			this.labelRare = new System.Windows.Forms.Label();
			this.checkAirType = new System.Windows.Forms.CheckBox();
			this.textUnitName = new System.Windows.Forms.TextBox();
			this.labelUnitName = new System.Windows.Forms.Label();
			this.comboMonsterGroup = new System.Windows.Forms.ComboBox();
			this.labelMonsterGroup = new System.Windows.Forms.Label();
			this.textMonsterID = new System.Windows.Forms.TextBox();
			this.labelMonsterID = new System.Windows.Forms.Label();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.textInfo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupUnitInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRare)).BeginInit();
			this.SuspendLayout();
			// 
			// groupUnitInfo
			// 
			this.groupUnitInfo.Controls.Add(this.label1);
			this.groupUnitInfo.Controls.Add(this.textInfo);
			this.groupUnitInfo.Controls.Add(this.numericRare);
			this.groupUnitInfo.Controls.Add(this.labelRare);
			this.groupUnitInfo.Controls.Add(this.checkAirType);
			this.groupUnitInfo.Controls.Add(this.textUnitName);
			this.groupUnitInfo.Controls.Add(this.labelUnitName);
			this.groupUnitInfo.Controls.Add(this.comboMonsterGroup);
			this.groupUnitInfo.Controls.Add(this.labelMonsterGroup);
			this.groupUnitInfo.Controls.Add(this.textMonsterID);
			this.groupUnitInfo.Controls.Add(this.labelMonsterID);
			resources.ApplyResources(this.groupUnitInfo, "groupUnitInfo");
			this.groupUnitInfo.Name = "groupUnitInfo";
			this.groupUnitInfo.TabStop = false;
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
			// 
			// labelMonsterGroup
			// 
			resources.ApplyResources(this.labelMonsterGroup, "labelMonsterGroup");
			this.labelMonsterGroup.Name = "labelMonsterGroup";
			// 
			// textMonsterID
			// 
			resources.ApplyResources(this.textMonsterID, "textMonsterID");
			this.textMonsterID.Name = "textMonsterID";
			this.toolTipInfo.SetToolTip(this.textMonsterID, resources.GetString("textMonsterID.ToolTip"));
			// 
			// labelMonsterID
			// 
			resources.ApplyResources(this.labelMonsterID, "labelMonsterID");
			this.labelMonsterID.Name = "labelMonsterID";
			// 
			// toolTipInfo
			// 
			this.toolTipInfo.AutoPopDelay = 50000;
			this.toolTipInfo.InitialDelay = 500;
			this.toolTipInfo.IsBalloon = true;
			this.toolTipInfo.ReshowDelay = 100;
			// 
			// textInfo
			// 
			resources.ApplyResources(this.textInfo, "textInfo");
			this.textInfo.Name = "textInfo";
			this.toolTipInfo.SetToolTip(this.textInfo, resources.GetString("textInfo.ToolTip"));
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// UnitInfomation
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.groupUnitInfo);
			this.Name = "UnitInfomation";
			this.groupUnitInfo.ResumeLayout(false);
			this.groupUnitInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericRare)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupUnitInfo;
		private System.Windows.Forms.Label labelRare;
		private System.Windows.Forms.Label labelUnitName;
		private System.Windows.Forms.Label labelMonsterGroup;
		private System.Windows.Forms.Label labelMonsterID;
		private System.Windows.Forms.TextBox textMonsterID;
		private System.Windows.Forms.TextBox textUnitName;
		private System.Windows.Forms.CheckBox checkAirType;
		private System.Windows.Forms.ComboBox comboMonsterGroup;
		private System.Windows.Forms.NumericUpDown numericRare;
		private System.Windows.Forms.ToolTip toolTipInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textInfo;
	}
}
