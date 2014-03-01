namespace Dziennik_elektroniczny.Formularze.Wprowadzanie
{
    partial class Nauczyciele
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imięLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nauczyciele));
            this.bazaDanychDataSet = new Dziennik_elektroniczny.BazaDanychDataSet();
            this.nauczycieleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nauczycieleTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.NauczycieleTableAdapter();
            this.tableAdapterManager = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager();
            this.nauczycieleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nauczycieleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imięTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            imięLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingNavigator)).BeginInit();
            this.nauczycieleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(8, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // imięLabel
            // 
            imięLabel.AutoSize = true;
            imięLabel.Location = new System.Drawing.Point(8, 57);
            imięLabel.Name = "imięLabel";
            imięLabel.Size = new System.Drawing.Size(29, 13);
            imięLabel.TabIndex = 3;
            imięLabel.Text = "Imię:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(8, 83);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(56, 13);
            nazwiskoLabel.TabIndex = 5;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // bazaDanychDataSet
            // 
            this.bazaDanychDataSet.DataSetName = "BazaDanychDataSet";
            this.bazaDanychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nauczycieleBindingSource
            // 
            this.nauczycieleBindingSource.DataMember = "Nauczyciele";
            this.nauczycieleBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // nauczycieleTableAdapter
            // 
            this.nauczycieleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Karty_ocenTableAdapter = null;
            this.tableAdapterManager.KlasyTableAdapter = null;
            this.tableAdapterManager.NauczycieleTableAdapter = this.nauczycieleTableAdapter;
            this.tableAdapterManager.Plan_zajęćTableAdapter = null;
            this.tableAdapterManager.PrzedmiotyTableAdapter = null;
            this.tableAdapterManager.Rodzaje_pracTableAdapter = null;
            this.tableAdapterManager.UczniowieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nauczycieleBindingNavigator
            // 
            this.nauczycieleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nauczycieleBindingNavigator.BindingSource = this.nauczycieleBindingSource;
            this.nauczycieleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nauczycieleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nauczycieleBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.nauczycieleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nauczycieleBindingNavigatorSaveItem});
            this.nauczycieleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nauczycieleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nauczycieleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nauczycieleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nauczycieleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nauczycieleBindingNavigator.Name = "nauczycieleBindingNavigator";
            this.nauczycieleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nauczycieleBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.nauczycieleBindingNavigator.TabIndex = 0;
            this.nauczycieleBindingNavigator.Text = "bindingNavigator1";
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
            // nauczycieleBindingNavigatorSaveItem
            // 
            this.nauczycieleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nauczycieleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nauczycieleBindingNavigatorSaveItem.Image")));
            this.nauczycieleBindingNavigatorSaveItem.Name = "nauczycieleBindingNavigatorSaveItem";
            this.nauczycieleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nauczycieleBindingNavigatorSaveItem.Text = "Save Data";
            this.nauczycieleBindingNavigatorSaveItem.Click += new System.EventHandler(this.nauczycieleBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nauczycieleBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(70, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(202, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // imięTextBox
            // 
            this.imięTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nauczycieleBindingSource, "Imię", true));
            this.imięTextBox.Location = new System.Drawing.Point(70, 54);
            this.imięTextBox.Name = "imięTextBox";
            this.imięTextBox.Size = new System.Drawing.Size(202, 20);
            this.imięTextBox.TabIndex = 4;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nauczycieleBindingSource, "Nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(70, 80);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(202, 20);
            this.nazwiskoTextBox.TabIndex = 6;
            // 
            // Nauczyciele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(imięLabel);
            this.Controls.Add(this.imięTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.nauczycieleBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Nauczyciele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nauczyciele";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SygnalizujZamknięcie);
            this.Load += new System.EventHandler(this.Nauczyciele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingNavigator)).EndInit();
            this.nauczycieleBindingNavigator.ResumeLayout(false);
            this.nauczycieleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaDanychDataSet bazaDanychDataSet;
        private System.Windows.Forms.BindingSource nauczycieleBindingSource;
        private BazaDanychDataSetTableAdapters.NauczycieleTableAdapter nauczycieleTableAdapter;
        private BazaDanychDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nauczycieleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nauczycieleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox imięTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
    }
}