namespace Dziennik_elektroniczny.Formularze.Przeglądanie.Terminy
{
    partial class Plan_zajęć
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan_zajęć));
            this.bazaDanychDataSet = new Dziennik_elektroniczny.BazaDanychDataSet();
            this.plan_zajęćBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_zajęćTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.Plan_zajęćTableAdapter();
            this.tableAdapterManager = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager();
            this.plan_zajęćBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.plan_zajęćBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.plan_zajęćDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćBindingNavigator)).BeginInit();
            this.plan_zajęćBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bazaDanychDataSet
            // 
            this.bazaDanychDataSet.DataSetName = "BazaDanychDataSet";
            this.bazaDanychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plan_zajęćBindingSource
            // 
            this.plan_zajęćBindingSource.DataMember = "Plan zajęć";
            this.plan_zajęćBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // plan_zajęćTableAdapter
            // 
            this.plan_zajęćTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Karty_ocenTableAdapter = null;
            this.tableAdapterManager.KlasyTableAdapter = null;
            this.tableAdapterManager.NauczycieleTableAdapter = null;
            this.tableAdapterManager.Plan_zajęćTableAdapter = this.plan_zajęćTableAdapter;
            this.tableAdapterManager.PrzedmiotyTableAdapter = null;
            this.tableAdapterManager.Rodzaje_pracTableAdapter = null;
            this.tableAdapterManager.UczniowieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // plan_zajęćBindingNavigator
            // 
            this.plan_zajęćBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plan_zajęćBindingNavigator.BindingSource = this.plan_zajęćBindingSource;
            this.plan_zajęćBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plan_zajęćBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plan_zajęćBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.plan_zajęćBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.plan_zajęćBindingNavigatorSaveItem});
            this.plan_zajęćBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.plan_zajęćBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plan_zajęćBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plan_zajęćBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plan_zajęćBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plan_zajęćBindingNavigator.Name = "plan_zajęćBindingNavigator";
            this.plan_zajęćBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plan_zajęćBindingNavigator.Size = new System.Drawing.Size(588, 25);
            this.plan_zajęćBindingNavigator.TabIndex = 0;
            this.plan_zajęćBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
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
            this.bindingNavigatorDeleteItem.Enabled = false;
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
            // plan_zajęćBindingNavigatorSaveItem
            // 
            this.plan_zajęćBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plan_zajęćBindingNavigatorSaveItem.Enabled = false;
            this.plan_zajęćBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plan_zajęćBindingNavigatorSaveItem.Image")));
            this.plan_zajęćBindingNavigatorSaveItem.Name = "plan_zajęćBindingNavigatorSaveItem";
            this.plan_zajęćBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.plan_zajęćBindingNavigatorSaveItem.Text = "Save Data";
            this.plan_zajęćBindingNavigatorSaveItem.Click += new System.EventHandler(this.plan_zajęćBindingNavigatorSaveItem_Click);
            // 
            // plan_zajęćDataGridView
            // 
            this.plan_zajęćDataGridView.AllowUserToAddRows = false;
            this.plan_zajęćDataGridView.AllowUserToDeleteRows = false;
            this.plan_zajęćDataGridView.AllowUserToResizeColumns = false;
            this.plan_zajęćDataGridView.AllowUserToResizeRows = false;
            this.plan_zajęćDataGridView.AutoGenerateColumns = false;
            this.plan_zajęćDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.plan_zajęćDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.plan_zajęćDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plan_zajęćDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.plan_zajęćDataGridView.DataSource = this.plan_zajęćBindingSource;
            this.plan_zajęćDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plan_zajęćDataGridView.Location = new System.Drawing.Point(0, 25);
            this.plan_zajęćDataGridView.Name = "plan_zajęćDataGridView";
            this.plan_zajęćDataGridView.ReadOnly = true;
            this.plan_zajęćDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.plan_zajęćDataGridView.Size = new System.Drawing.Size(588, 521);
            this.plan_zajęćDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Klasa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Klasa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Przedmiot";
            this.dataGridViewTextBoxColumn3.HeaderText = "Przedmiot";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sala";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sala";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prowadzący";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prowadzący";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rozpoczęcie";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rozpoczęcie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Zakończenie";
            this.dataGridViewTextBoxColumn7.HeaderText = "Zakończenie";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Temat";
            this.dataGridViewTextBoxColumn8.HeaderText = "Temat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Plan_zajęć
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 546);
            this.Controls.Add(this.plan_zajęćDataGridView);
            this.Controls.Add(this.plan_zajęćBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Plan_zajęć";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan_zajęć";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SygnalizujZamknięcie);
            this.Load += new System.EventHandler(this.Plan_zajęć_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćBindingNavigator)).EndInit();
            this.plan_zajęćBindingNavigator.ResumeLayout(false);
            this.plan_zajęćBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaDanychDataSet bazaDanychDataSet;
        private System.Windows.Forms.BindingSource plan_zajęćBindingSource;
        private BazaDanychDataSetTableAdapters.Plan_zajęćTableAdapter plan_zajęćTableAdapter;
        private BazaDanychDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator plan_zajęćBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton plan_zajęćBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView plan_zajęćDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}