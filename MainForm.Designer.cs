namespace IPOCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.button_calculate = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.grid_experience = new DevExpress.XtraGrid.GridControl();
            this.dataSet = new IPOCalculator.DataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnServingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit_servingTime = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit_servingTime111 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.combo_entrepreneurship = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtEdit_year = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_experience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_servingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_servingTime111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_entrepreneurship.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.button_calculate);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.grid_experience);
            this.layoutControl1.Controls.Add(this.combo_entrepreneurship);
            this.layoutControl1.Controls.Add(this.txtEdit_year);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(899, 180, 250, 345);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(453, 368);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(348, 334);
            this.button_calculate.MaximumSize = new System.Drawing.Size(100, 0);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(93, 22);
            this.button_calculate.StyleController = this.layoutControl1;
            this.button_calculate.TabIndex = 8;
            this.button_calculate.Text = "计算";
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(67, 60);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(374, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 7;
            // 
            // grid_experience
            // 
            this.grid_experience.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid_experience.DataMember = "WorkExperienceTable";
            this.grid_experience.DataSource = this.dataSet;
            this.grid_experience.Location = new System.Drawing.Point(67, 84);
            this.grid_experience.MainView = this.gridView1;
            this.grid_experience.Name = "grid_experience";
            this.grid_experience.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit_servingTime111,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit_servingTime});
            this.grid_experience.Size = new System.Drawing.Size(374, 246);
            this.grid_experience.TabIndex = 6;
            this.grid_experience.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnServingTime,
            this.gridColumnSalary});
            this.gridView1.GridControl = this.grid_experience;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumnServingTime
            // 
            this.gridColumnServingTime.Caption = "任职时间";
            this.gridColumnServingTime.ColumnEdit = this.repositoryItemTextEdit_servingTime;
            this.gridColumnServingTime.FieldName = "ServingTime";
            this.gridColumnServingTime.Name = "gridColumnServingTime";
            this.gridColumnServingTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnServingTime.OptionsFilter.AllowFilter = false;
            this.gridColumnServingTime.Visible = true;
            this.gridColumnServingTime.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit_servingTime
            // 
            this.repositoryItemTextEdit_servingTime.AutoHeight = false;
            this.repositoryItemTextEdit_servingTime.Name = "repositoryItemTextEdit_servingTime";
            // 
            // gridColumnSalary
            // 
            this.gridColumnSalary.Caption = "薪资（元/月）";
            this.gridColumnSalary.FieldName = "Salary";
            this.gridColumnSalary.Name = "gridColumnSalary";
            this.gridColumnSalary.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnSalary.OptionsFilter.AllowFilter = false;
            this.gridColumnSalary.Visible = true;
            this.gridColumnSalary.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit_servingTime111
            // 
            this.repositoryItemTextEdit_servingTime111.AutoHeight = false;
            this.repositoryItemTextEdit_servingTime111.Mask.EditMask = "\\d{4}年\\d{1,2}月 至 \\d{4}年\\d{1,2}月";
            this.repositoryItemTextEdit_servingTime111.Mask.IgnoreMaskBlank = false;
            this.repositoryItemTextEdit_servingTime111.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit_servingTime111.Name = "repositoryItemTextEdit_servingTime111";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // combo_entrepreneurship
            // 
            this.combo_entrepreneurship.Location = new System.Drawing.Point(67, 36);
            this.combo_entrepreneurship.Name = "combo_entrepreneurship";
            this.combo_entrepreneurship.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_entrepreneurship.Properties.Items.AddRange(new object[] {
            "是",
            "否"});
            this.combo_entrepreneurship.Properties.NullValuePrompt = "请选择";
            this.combo_entrepreneurship.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.combo_entrepreneurship.Size = new System.Drawing.Size(374, 20);
            this.combo_entrepreneurship.StyleController = this.layoutControl1;
            this.combo_entrepreneurship.TabIndex = 5;
            // 
            // txtEdit_year
            // 
            this.txtEdit_year.Location = new System.Drawing.Point(67, 12);
            this.txtEdit_year.Name = "txtEdit_year";
            this.txtEdit_year.Size = new System.Drawing.Size(374, 20);
            this.txtEdit_year.StyleController = this.layoutControl1;
            this.txtEdit_year.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(453, 368);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtEdit_year;
            this.layoutControlItem1.CustomizationFormText = "出生年份：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(433, 24);
            this.layoutControlItem1.Text = "出生年份:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.grid_experience;
            this.layoutControlItem3.CustomizationFormText = "工作经验：";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(433, 250);
            this.layoutControlItem3.Text = "工作经验:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.combo_entrepreneurship;
            this.layoutControlItem2.CustomizationFormText = "是否在创业：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(433, 24);
            this.layoutControlItem2.Text = "在创业否:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit1;
            this.layoutControlItem4.CustomizationFormText = "首发比例：";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(433, 24);
            this.layoutControlItem4.Text = "首发比例:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.button_calculate;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(336, 322);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 322);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(336, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 368);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MainForm";
            this.Text = "人才IPO计算器";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_experience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_servingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_servingTime111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_entrepreneurship.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl grid_experience;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit combo_entrepreneurship;
        private DevExpress.XtraEditors.TextEdit txtEdit_year;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServingTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSalary;
        private DataSet dataSet;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit_servingTime111;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton button_calculate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit_servingTime;
    }
}

