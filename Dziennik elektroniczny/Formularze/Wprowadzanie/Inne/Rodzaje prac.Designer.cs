﻿namespace Dziennik_elektroniczny.Formularze.Wprowadzanie
{
    partial class Rodzaje_prac
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
            System.Windows.Forms.Label rodzaj_pracyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rodzaje_prac));
            this.bazaDanychDataSet = new Dziennik_elektroniczny.BazaDanychDataSet();
            this.rodzaje_pracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rodzaje_pracTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.Rodzaje_pracTableAdapter();
            this.tableAdapterManager = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager();
            this.rodzaje_pracBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rodzaje_pracBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.rodzaj_pracyTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            rodzaj_pracyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzaje_pracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzaje_pracBindingNavigator)).BeginInit();
            this.rodzaje_pracBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(7, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // rodzaj_pracyLabel
            // 
            rodzaj_pracyLabel.AutoSize = true;
            rodzaj_pracyLabel.Location = new System.Drawing.Point(7, 57);
            rodzaj_pracyLabel.Name = "rodzaj_pracyLabel";
            rodzaj_pracyLabel.Size = new System.Drawing.Size(72, 13);
            rodzaj_pracyLabel.TabIndex = 3;
            rodzaj_pracyLabel.Text = "Rodzaj pracy:";
            // 
            // bazaDanychDataSet
            // 
            this.bazaDanychDataSet.DataSetName = "BazaDanychDataSet";
            this.bazaDanychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rodzaje_pracBindingSource
            // 
            this.rodzaje_pracBindingSource.DataMember = "Rodzaje prac";
            this.rodzaje_pracBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // rodzaje_pracTableAdapter
            // 
            this.rodzaje_pracTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Karty_ocenTableAdapter = null;
            this.tableAdapterManager.KlasyTableAdapter = null;
            this.tableAdapterManager.NauczycieleTableAdapter = null;
            this.tableAdapterManager.Plan_zajęćTableAdapter = null;
            this.tableAdapterManager.PrzedmiotyTableAdapter = null;
            this.tableAdapterManager.Rodzaje_pracTableAdapter = this.rodzaje_pracTableAdapter;
            this.tableAdapterManager.UczniowieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rodzaje_pracBindingNavigator
            // 
            this.rodzaje_pracBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rodzaje_pracBindingNavigator.BindingSource = this.rodzaje_pracBindingSource;
            this.rodzaje_pracBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rodzaje_pracBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rodzaje_pracBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.rodzaje_pracBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rodzaje_pracBindingNavigatorSaveItem});
            this.rodzaje_pracBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rodzaje_pracBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rodzaje_pracBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rodzaje_pracBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rodzaje_pracBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rodzaje_pracBindingNavigator.Name = "rodzaje_pracBindingNavigator";
            this.rodzaje_pracBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rodzaje_pracBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.rodzaje_pracBindingNavigator.TabIndex = 0;
            this.rodzaje_pracBindingNavigator.Text = "bindingNavigator1";
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
            // rodzaje_pracBindingNavigatorSaveItem
            // 
            this.rodzaje_pracBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rodzaje_pracBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rodzaje_pracBindingNavigatorSaveItem.Image")));
            this.rodzaje_pracBindingNavigatorSaveItem.Name = "rodzaje_pracBindingNavigatorSaveItem";
            this.rodzaje_pracBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rodzaje_pracBindingNavigatorSaveItem.Text = "Save Data";
            this.rodzaje_pracBindingNavigatorSaveItem.Click += new System.EventHandler(this.rodzaje_pracBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rodzaje_pracBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(85, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(187, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // rodzaj_pracyTextBox
            // 
            this.rodzaj_pracyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rodzaje_pracBindingSource, "Rodzaj pracy", true));
            this.rodzaj_pracyTextBox.Location = new System.Drawing.Point(85, 54);
            this.rodzaj_pracyTextBox.Name = "rodzaj_pracyTextBox";
            this.rodzaj_pracyTextBox.Size = new System.Drawing.Size(187, 20);
            this.rodzaj_pracyTextBox.TabIndex = 4;
            // 
            // Rodzaje_prac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 84);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(rodzaj_pracyLabel);
            this.Controls.Add(this.rodzaj_pracyTextBox);
            this.Controls.Add(this.rodzaje_pracBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Rodzaje_prac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodzaje prac";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SygnalizujZamknięcie);
            this.Load += new System.EventHandler(this.Rodzaje_zajęć_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzaje_pracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzaje_pracBindingNavigator)).EndInit();
            this.rodzaje_pracBindingNavigator.ResumeLayout(false);
            this.rodzaje_pracBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaDanychDataSet bazaDanychDataSet;
        private System.Windows.Forms.BindingSource rodzaje_pracBindingSource;
        private BazaDanychDataSetTableAdapters.Rodzaje_pracTableAdapter rodzaje_pracTableAdapter;
        private BazaDanychDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rodzaje_pracBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rodzaje_pracBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox rodzaj_pracyTextBox;
    }
}