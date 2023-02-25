namespace WindowsFormsApp1
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gAMEIDLabel;
            System.Windows.Forms.Label nAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.gameRentalDataSet = new WindowsFormsApp1.GameRentalDataSet();
            this.bROWSINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bROWSINGTableAdapter = new WindowsFormsApp1.GameRentalDataSetTableAdapters.BROWSINGTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.GameRentalDataSetTableAdapters.TableAdapterManager();
            this.gAMETableAdapter = new WindowsFormsApp1.GameRentalDataSetTableAdapters.GAMETableAdapter();
            this.bROWSINGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bROWSINGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gAMEIDTextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.gAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            gAMEIDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bROWSINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bROWSINGBindingNavigator)).BeginInit();
            this.bROWSINGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gAMEIDLabel
            // 
            gAMEIDLabel.AutoSize = true;
            gAMEIDLabel.Location = new System.Drawing.Point(343, 61);
            gAMEIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gAMEIDLabel.Name = "gAMEIDLabel";
            gAMEIDLabel.Size = new System.Drawing.Size(96, 25);
            gAMEIDLabel.TabIndex = 1;
            gAMEIDLabel.Text = "GAMEID:";
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(343, 104);
            nAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(76, 25);
            nAMELabel.TabIndex = 3;
            nAMELabel.Text = "NAME:";
            // 
            // gameRentalDataSet
            // 
            this.gameRentalDataSet.DataSetName = "GameRentalDataSet";
            this.gameRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bROWSINGBindingSource
            // 
            this.bROWSINGBindingSource.DataMember = "BROWSING";
            this.bROWSINGBindingSource.DataSource = this.gameRentalDataSet;
            // 
            // bROWSINGTableAdapter
            // 
            this.bROWSINGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BROWSINGTableAdapter = this.bROWSINGTableAdapter;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DEVELOPTableAdapter = null;
            this.tableAdapterManager.GAMETableAdapter = this.gAMETableAdapter;
            this.tableAdapterManager.RENTTableAdapter = null;
            this.tableAdapterManager.RETURNTableAdapter = null;
            this.tableAdapterManager.SHOWLISTTableAdapter = null;
            this.tableAdapterManager.UPDATE_DETAILSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.GameRentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = null;
            this.tableAdapterManager.VENDORTableAdapter = null;
            // 
            // gAMETableAdapter
            // 
            this.gAMETableAdapter.ClearBeforeFill = true;
            // 
            // bROWSINGBindingNavigator
            // 
            this.bROWSINGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bROWSINGBindingNavigator.BindingSource = this.bROWSINGBindingSource;
            this.bROWSINGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bROWSINGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bROWSINGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bROWSINGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bROWSINGBindingNavigatorSaveItem});
            this.bROWSINGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bROWSINGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bROWSINGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bROWSINGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bROWSINGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bROWSINGBindingNavigator.Name = "bROWSINGBindingNavigator";
            this.bROWSINGBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bROWSINGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bROWSINGBindingNavigator.Size = new System.Drawing.Size(1077, 27);
            this.bROWSINGBindingNavigator.TabIndex = 0;
            this.bROWSINGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bROWSINGBindingNavigatorSaveItem
            // 
            this.bROWSINGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bROWSINGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bROWSINGBindingNavigatorSaveItem.Image")));
            this.bROWSINGBindingNavigatorSaveItem.Name = "bROWSINGBindingNavigatorSaveItem";
            this.bROWSINGBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bROWSINGBindingNavigatorSaveItem.Text = "Save Data";
            this.bROWSINGBindingNavigatorSaveItem.Click += new System.EventHandler(this.bROWSINGBindingNavigatorSaveItem_Click);
            // 
            // gAMEIDTextBox
            // 
            this.gAMEIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bROWSINGBindingSource, "GAMEID", true));
            this.gAMEIDTextBox.Location = new System.Drawing.Point(447, 56);
            this.gAMEIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gAMEIDTextBox.Name = "gAMEIDTextBox";
            this.gAMEIDTextBox.Size = new System.Drawing.Size(148, 30);
            this.gAMEIDTextBox.TabIndex = 2;
            this.gAMEIDTextBox.TextChanged += new System.EventHandler(this.gAMEIDTextBox_TextChanged);
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bROWSINGBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(445, 100);
            this.nAMETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(148, 30);
            this.nAMETextBox.TabIndex = 4;
            // 
            // gAMEBindingSource
            // 
            this.gAMEBindingSource.DataMember = "GAME";
            this.gAMEBindingSource.DataSource = this.gameRentalDataSet;
            // 
            // gAMEDataGridView
            // 
            this.gAMEDataGridView.AutoGenerateColumns = false;
            this.gAMEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gAMEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gAMEDataGridView.DataSource = this.gAMEBindingSource;
            this.gAMEDataGridView.Location = new System.Drawing.Point(50, 152);
            this.gAMEDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gAMEDataGridView.Name = "gAMEDataGridView";
            this.gAMEDataGridView.RowHeadersWidth = 51;
            this.gAMEDataGridView.RowTemplate.Height = 24;
            this.gAMEDataGridView.Size = new System.Drawing.Size(928, 344);
            this.gAMEDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "YEAR";
            this.dataGridViewTextBoxColumn1.HeaderText = "YEAR";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VENDORNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "VENDORNAME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CATEGORY";
            this.dataGridViewTextBoxColumn3.HeaderText = "CATEGORY";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GAMEID";
            this.dataGridViewTextBoxColumn5.HeaderText = "GAMEID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ADMINID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ADMINID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VENDOR_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "VENDOR_ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 519);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "Rent";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(567, 519);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "Return";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_abstract_gaming_color_5k_wallpaper_11625792127spo6ievzi6;
            this.ClientSize = new System.Drawing.Size(1077, 595);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gAMEDataGridView);
            this.Controls.Add(gAMEIDLabel);
            this.Controls.Add(this.gAMEIDTextBox);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(this.bROWSINGBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Browse";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bROWSINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bROWSINGBindingNavigator)).EndInit();
            this.bROWSINGBindingNavigator.ResumeLayout(false);
            this.bROWSINGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameRentalDataSet gameRentalDataSet;
        private System.Windows.Forms.BindingSource bROWSINGBindingSource;
        private GameRentalDataSetTableAdapters.BROWSINGTableAdapter bROWSINGTableAdapter;
        private GameRentalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bROWSINGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bROWSINGBindingNavigatorSaveItem;
        private GameRentalDataSetTableAdapters.GAMETableAdapter gAMETableAdapter;
        private System.Windows.Forms.TextBox gAMEIDTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.BindingSource gAMEBindingSource;
        private System.Windows.Forms.DataGridView gAMEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}