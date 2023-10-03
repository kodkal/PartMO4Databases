﻿namespace PartMO4Databases
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
      this.localPhoneDbDataSet1 = new PartMO4Databases.LocalPhoneDbDataSet1();
      this.phoneListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.phoneListTableTableAdapter = new PartMO4Databases.LocalPhoneDbDataSet1TableAdapters.PhoneListTableTableAdapter();
      this.tableAdapterManager = new PartMO4Databases.LocalPhoneDbDataSet1TableAdapters.TableAdapterManager();
      this.phoneListTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.phoneListTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.phoneListTableDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneDbDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingNavigator)).BeginInit();
      this.phoneListTableBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // localPhoneDbDataSet1
      // 
      this.localPhoneDbDataSet1.DataSetName = "LocalPhoneDbDataSet1";
      this.localPhoneDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // phoneListTableBindingSource
      // 
      this.phoneListTableBindingSource.DataMember = "PhoneListTable";
      this.phoneListTableBindingSource.DataSource = this.localPhoneDbDataSet1;
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
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // phoneListTableBindingNavigatorSaveItem
      // 
      this.phoneListTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.phoneListTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneListTableBindingNavigatorSaveItem.Image")));
      this.phoneListTableBindingNavigatorSaveItem.Name = "phoneListTableBindingNavigatorSaveItem";
      this.phoneListTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
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
      this.phoneListTableDataGridView.Size = new System.Drawing.Size(760, 378);
      this.phoneListTableDataGridView.TabIndex = 1;
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
      // LocalPhoneForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.phoneListTableDataGridView);
      this.Controls.Add(this.phoneListTableBindingNavigator);
      this.Name = "LocalPhoneForm";
      this.Text = "LocalPhoneForm";
      this.Load += new System.EventHandler(this.LocalPhoneForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneDbDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableBindingNavigator)).EndInit();
      this.phoneListTableBindingNavigator.ResumeLayout(false);
      this.phoneListTableBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.phoneListTableDataGridView)).EndInit();
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
  }
}