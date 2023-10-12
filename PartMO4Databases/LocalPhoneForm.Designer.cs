namespace PartMO4Databases
{
  partial class LocalPhoneForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPhoneForm));
      this.phoneListTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.phoneListTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.phoneListTableDataGridView = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.BtnSearch = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.TxtBoxFirstName = new System.Windows.Forms.TextBox();
      this.BtnSortLN = new System.Windows.Forms.Button();
      this.BtnAge30 = new System.Windows.Forms.Button();
      this.BtnClear = new System.Windows.Forms.Button();
      this.BtnAvgAge = new System.Windows.Forms.Button();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phoneListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.localPhoneDbDataSet1 = new PartMO4Databases.LocalPhoneDbDataSet1();
      this.phoneListTableTableAdapter = new PartMO4Databases.LocalPhoneDbDataSet1TableAdapters.PhoneListTableTableAdapter();
      this.tableAdapterManager = new PartMO4Databases.LocalPhoneDbDataSet1TableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingNavigator)).BeginInit();
      this.phoneListTableBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableDataGridView)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneDbDataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // phoneListTableBindingNavigator
      // 
      this.phoneListTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.phoneListTableBindingNavigator.BindingSource = this.phoneListTableBindingSource;
      this.phoneListTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.phoneListTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.phoneListTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.phoneListTableBindingNavigatorSaveItem});
      this.phoneListTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.phoneListTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.phoneListTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.phoneListTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.phoneListTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.phoneListTableBindingNavigator.Name = "phoneListTableBindingNavigator";
      this.phoneListTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.phoneListTableBindingNavigator.Size = new System.Drawing.Size(800, 25);
      this.phoneListTableBindingNavigator.TabIndex = 0;
      this.phoneListTableBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // phoneListTableBindingNavigatorSaveItem
      // 
      this.phoneListTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.phoneListTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneListTableBindingNavigatorSaveItem.Image")));
      this.phoneListTableBindingNavigatorSaveItem.Name = "phoneListTableBindingNavigatorSaveItem";
      this.phoneListTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.phoneListTableBindingNavigatorSaveItem.Text = "Save Data";
      this.phoneListTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.phoneListTableBindingNavigatorSaveItem_Click);
      // 
      // phoneListTableDataGridView
      // 
      this.phoneListTableDataGridView.AutoGenerateColumns = false;
      this.phoneListTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.phoneListTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.phoneListTableDataGridView.DataSource = this.phoneListTableBindingSource;
      this.phoneListTableDataGridView.Location = new System.Drawing.Point(12, 46);
      this.phoneListTableDataGridView.Name = "phoneListTableDataGridView";
      this.phoneListTableDataGridView.Size = new System.Drawing.Size(760, 208);
      this.phoneListTableDataGridView.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.TxtBoxFirstName);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.BtnSearch);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 273);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(378, 165);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Search";
      // 
      // BtnSearch
      // 
      this.BtnSearch.Location = new System.Drawing.Point(20, 105);
      this.BtnSearch.Name = "BtnSearch";
      this.BtnSearch.Size = new System.Drawing.Size(324, 43);
      this.BtnSearch.TabIndex = 0;
      this.BtnSearch.Text = "&Search";
      this.BtnSearch.UseVisualStyleBackColor = true;
      this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "First Name";
      // 
      // TxtBoxFirstName
      // 
      this.TxtBoxFirstName.Location = new System.Drawing.Point(134, 56);
      this.TxtBoxFirstName.Name = "TxtBoxFirstName";
      this.TxtBoxFirstName.Size = new System.Drawing.Size(210, 31);
      this.TxtBoxFirstName.TabIndex = 2;
      // 
      // BtnSortLN
      // 
      this.BtnSortLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnSortLN.Location = new System.Drawing.Point(407, 296);
      this.BtnSortLN.Name = "BtnSortLN";
      this.BtnSortLN.Size = new System.Drawing.Size(172, 49);
      this.BtnSortLN.TabIndex = 3;
      this.BtnSortLN.Text = "Sort by Last Name";
      this.BtnSortLN.UseVisualStyleBackColor = true;
      this.BtnSortLN.Click += new System.EventHandler(this.BtnSortLN_Click);
      // 
      // BtnAge30
      // 
      this.BtnAge30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnAge30.Location = new System.Drawing.Point(600, 296);
      this.BtnAge30.Name = "BtnAge30";
      this.BtnAge30.Size = new System.Drawing.Size(172, 49);
      this.BtnAge30.TabIndex = 3;
      this.BtnAge30.Text = "Age > 30";
      this.BtnAge30.UseVisualStyleBackColor = true;
      this.BtnAge30.Click += new System.EventHandler(this.BtnAge30_Click);
      // 
      // BtnClear
      // 
      this.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnClear.Location = new System.Drawing.Point(600, 372);
      this.BtnClear.Name = "BtnClear";
      this.BtnClear.Size = new System.Drawing.Size(172, 49);
      this.BtnClear.TabIndex = 3;
      this.BtnClear.Text = "Clea&r";
      this.BtnClear.UseVisualStyleBackColor = true;
      this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
      // 
      // BtnAvgAge
      // 
      this.BtnAvgAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnAvgAge.Location = new System.Drawing.Point(407, 372);
      this.BtnAvgAge.Name = "BtnAvgAge";
      this.BtnAvgAge.Size = new System.Drawing.Size(172, 49);
      this.BtnAvgAge.TabIndex = 3;
      this.BtnAvgAge.Text = "A&verage Age";
      this.BtnAvgAge.UseVisualStyleBackColor = true;
      this.BtnAvgAge.Click += new System.EventHandler(this.BtnAvgAge_Click);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonId";
      this.dataGridViewTextBoxColumn1.HeaderText = "PersonId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
      this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
      this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
      this.dataGridViewTextBoxColumn5.HeaderText = "Age";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // phoneListTableBindingSource
      // 
      this.phoneListTableBindingSource.DataMember = "PhoneListTable";
      this.phoneListTableBindingSource.DataSource = this.localPhoneDbDataSet1;
      // 
      // localPhoneDbDataSet1
      // 
      this.localPhoneDbDataSet1.DataSetName = "LocalPhoneDbDataSet1";
      this.localPhoneDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // phoneListTableTableAdapter
      // 
      this.phoneListTableTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.PhoneListTableTableAdapter = this.phoneListTableTableAdapter;
      this.tableAdapterManager.UpdateOrder = PartMO4Databases.LocalPhoneDbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // LocalPhoneForm
      // 
      this.AcceptButton = this.BtnSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnAvgAge);
      this.Controls.Add(this.BtnClear);
      this.Controls.Add(this.BtnAge30);
      this.Controls.Add(this.BtnSortLN);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.phoneListTableDataGridView);
      this.Controls.Add(this.phoneListTableBindingNavigator);
      this.Name = "LocalPhoneForm";
      this.Text = "LocalPhoneForm";
      this.Load += new System.EventHandler(this.LocalPhoneForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingNavigator)).EndInit();
      this.phoneListTableBindingNavigator.ResumeLayout(false);
      this.phoneListTableBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableDataGridView)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneDbDataSet1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private LocalPhoneDbDataSet1 localPhoneDbDataSet1;
    private System.Windows.Forms.BindingSource phoneListTableBindingSource;
    private LocalPhoneDbDataSet1TableAdapters.PhoneListTableTableAdapter phoneListTableTableAdapter;
    private LocalPhoneDbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator phoneListTableBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton phoneListTableBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView phoneListTableDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox TxtBoxFirstName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnSearch;
    private System.Windows.Forms.Button BtnSortLN;
    private System.Windows.Forms.Button BtnAge30;
    private System.Windows.Forms.Button BtnClear;
    private System.Windows.Forms.Button BtnAvgAge;
  }
}