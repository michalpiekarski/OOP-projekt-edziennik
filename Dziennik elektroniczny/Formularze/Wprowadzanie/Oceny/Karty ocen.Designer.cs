namespace Dziennik_elektroniczny
{
    partial class Karty_ocen
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
            System.Windows.Forms.Label uczeńLabel;
            System.Windows.Forms.Label nauczycielLabel;
            System.Windows.Forms.Label przedmiotLabel;
            System.Windows.Forms.Label rodzaj_pracyLabel;
            System.Windows.Forms.Label ocenaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label uwagiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karty_ocen));
            this.bazaDanychDataSet = new Dziennik_elektroniczny.BazaDanychDataSet();
            this.karty_ocenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karty_ocenTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.Karty_ocenTableAdapter();
            this.tableAdapterManager = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager();
            this.karty_ocenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.karty_ocenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ocenaTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uwagiTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uczniowieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nauczycieleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.przedmiotyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.rodzajePracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uczniowieTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.UczniowieTableAdapter();
            this.nauczycieleTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.NauczycieleTableAdapter();
            this.przedmiotyTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.PrzedmiotyTableAdapter();
            this.rodzaje_pracTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.Rodzaje_pracTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            uczeńLabel = new System.Windows.Forms.Label();
            nauczycielLabel = new System.Windows.Forms.Label();
            przedmiotLabel = new System.Windows.Forms.Label();
            rodzaj_pracyLabel = new System.Windows.Forms.Label();
            ocenaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            uwagiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karty_ocenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karty_ocenBindingNavigator)).BeginInit();
            this.karty_ocenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajePracBindingSource)).BeginInit();
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
            // uczeńLabel
            // 
            uczeńLabel.AutoSize = true;
            uczeńLabel.Location = new System.Drawing.Point(7, 57);
            uczeńLabel.Name = "uczeńLabel";
            uczeńLabel.Size = new System.Drawing.Size(41, 13);
            uczeńLabel.TabIndex = 3;
            uczeńLabel.Text = "Uczeń:";
            // 
            // nauczycielLabel
            // 
            nauczycielLabel.AutoSize = true;
            nauczycielLabel.Location = new System.Drawing.Point(7, 83);
            nauczycielLabel.Name = "nauczycielLabel";
            nauczycielLabel.Size = new System.Drawing.Size(62, 13);
            nauczycielLabel.TabIndex = 5;
            nauczycielLabel.Text = "Nauczyciel:";
            // 
            // przedmiotLabel
            // 
            przedmiotLabel.AutoSize = true;
            przedmiotLabel.Location = new System.Drawing.Point(7, 109);
            przedmiotLabel.Name = "przedmiotLabel";
            przedmiotLabel.Size = new System.Drawing.Size(56, 13);
            przedmiotLabel.TabIndex = 7;
            przedmiotLabel.Text = "Przedmiot:";
            // 
            // rodzaj_pracyLabel
            // 
            rodzaj_pracyLabel.AutoSize = true;
            rodzaj_pracyLabel.Location = new System.Drawing.Point(7, 135);
            rodzaj_pracyLabel.Name = "rodzaj_pracyLabel";
            rodzaj_pracyLabel.Size = new System.Drawing.Size(72, 13);
            rodzaj_pracyLabel.TabIndex = 9;
            rodzaj_pracyLabel.Text = "Rodzaj pracy:";
            // 
            // ocenaLabel
            // 
            ocenaLabel.AutoSize = true;
            ocenaLabel.Location = new System.Drawing.Point(7, 161);
            ocenaLabel.Name = "ocenaLabel";
            ocenaLabel.Size = new System.Drawing.Size(42, 13);
            ocenaLabel.TabIndex = 11;
            ocenaLabel.Text = "Ocena:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(7, 188);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 13;
            dataLabel.Text = "Data:";
            // 
            // uwagiLabel
            // 
            uwagiLabel.AutoSize = true;
            uwagiLabel.Location = new System.Drawing.Point(7, 213);
            uwagiLabel.Name = "uwagiLabel";
            uwagiLabel.Size = new System.Drawing.Size(40, 13);
            uwagiLabel.TabIndex = 15;
            uwagiLabel.Text = "Uwagi:";
            // 
            // bazaDanychDataSet
            // 
            this.bazaDanychDataSet.DataSetName = "BazaDanychDataSet";
            this.bazaDanychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karty_ocenBindingSource
            // 
            this.karty_ocenBindingSource.DataMember = "Karty ocen";
            this.karty_ocenBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // karty_ocenTableAdapter
            // 
            this.karty_ocenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Karty_ocenTableAdapter = this.karty_ocenTableAdapter;
            this.tableAdapterManager.KlasyTableAdapter = null;
            this.tableAdapterManager.NauczycieleTableAdapter = null;
            this.tableAdapterManager.Plan_zajęćTableAdapter = null;
            this.tableAdapterManager.PrzedmiotyTableAdapter = null;
            this.tableAdapterManager.Rodzaje_pracTableAdapter = null;
            this.tableAdapterManager.UczniowieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // karty_ocenBindingNavigator
            // 
            this.karty_ocenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.karty_ocenBindingNavigator.BindingSource = this.karty_ocenBindingSource;
            this.karty_ocenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.karty_ocenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.karty_ocenBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.karty_ocenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.karty_ocenBindingNavigatorSaveItem});
            this.karty_ocenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.karty_ocenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.karty_ocenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.karty_ocenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.karty_ocenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.karty_ocenBindingNavigator.Name = "karty_ocenBindingNavigator";
            this.karty_ocenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.karty_ocenBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.karty_ocenBindingNavigator.TabIndex = 0;
            this.karty_ocenBindingNavigator.Text = "bindingNavigator1";
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
            // karty_ocenBindingNavigatorSaveItem
            // 
            this.karty_ocenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.karty_ocenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("karty_ocenBindingNavigatorSaveItem.Image")));
            this.karty_ocenBindingNavigatorSaveItem.Name = "karty_ocenBindingNavigatorSaveItem";
            this.karty_ocenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.karty_ocenBindingNavigatorSaveItem.Text = "Save Data";
            this.karty_ocenBindingNavigatorSaveItem.Click += new System.EventHandler(this.karty_ocenBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karty_ocenBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(85, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(186, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // ocenaTextBox
            // 
            this.ocenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karty_ocenBindingSource, "Ocena", true));
            this.ocenaTextBox.Location = new System.Drawing.Point(85, 158);
            this.ocenaTextBox.Name = "ocenaTextBox";
            this.ocenaTextBox.Size = new System.Drawing.Size(186, 20);
            this.ocenaTextBox.TabIndex = 12;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.karty_ocenBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(85, 184);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.dataDateTimePicker.TabIndex = 14;
            // 
            // uwagiTextBox
            // 
            this.uwagiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karty_ocenBindingSource, "Uwagi", true));
            this.uwagiTextBox.Location = new System.Drawing.Point(85, 210);
            this.uwagiTextBox.Multiline = true;
            this.uwagiTextBox.Name = "uwagiTextBox";
            this.uwagiTextBox.Size = new System.Drawing.Size(186, 78);
            this.uwagiTextBox.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.karty_ocenBindingSource, "Uczeń", true));
            this.comboBox1.DataSource = this.uczniowieBindingSource;
            this.comboBox1.DisplayMember = "PESEL";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "Id";
            // 
            // uczniowieBindingSource
            // 
            this.uczniowieBindingSource.DataMember = "Uczniowie";
            this.uczniowieBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.karty_ocenBindingSource, "Nauczyciel", true));
            this.comboBox2.DataSource = this.nauczycieleBindingSource;
            this.comboBox2.DisplayMember = "Nazwisko";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "Id";
            // 
            // nauczycieleBindingSource
            // 
            this.nauczycieleBindingSource.DataMember = "Nauczyciele";
            this.nauczycieleBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.karty_ocenBindingSource, "Przedmiot", true));
            this.comboBox3.DataSource = this.przedmiotyBindingSource;
            this.comboBox3.DisplayMember = "Przedmiot";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(85, 106);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 21);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.ValueMember = "Id";
            // 
            // przedmiotyBindingSource
            // 
            this.przedmiotyBindingSource.DataMember = "Przedmioty";
            this.przedmiotyBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.karty_ocenBindingSource, "Rodzaj pracy", true));
            this.comboBox4.DataSource = this.rodzajePracBindingSource;
            this.comboBox4.DisplayMember = "Rodzaj pracy";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(85, 131);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(186, 21);
            this.comboBox4.TabIndex = 20;
            this.comboBox4.ValueMember = "Id";
            // 
            // rodzajePracBindingSource
            // 
            this.rodzajePracBindingSource.DataMember = "Rodzaje prac";
            this.rodzajePracBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // uczniowieTableAdapter
            // 
            this.uczniowieTableAdapter.ClearBeforeFill = true;
            // 
            // nauczycieleTableAdapter
            // 
            this.nauczycieleTableAdapter.ClearBeforeFill = true;
            // 
            // przedmiotyTableAdapter
            // 
            this.przedmiotyTableAdapter.ClearBeforeFill = true;
            // 
            // rodzaje_pracTableAdapter
            // 
            this.rodzaje_pracTableAdapter.ClearBeforeFill = true;
            // 
            // Karty_ocen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(uczeńLabel);
            this.Controls.Add(nauczycielLabel);
            this.Controls.Add(przedmiotLabel);
            this.Controls.Add(rodzaj_pracyLabel);
            this.Controls.Add(ocenaLabel);
            this.Controls.Add(this.ocenaTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(uwagiLabel);
            this.Controls.Add(this.uwagiTextBox);
            this.Controls.Add(this.karty_ocenBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Karty_ocen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karty_ocen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.Load += new System.EventHandler(this.Karty_ocen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karty_ocenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karty_ocenBindingNavigator)).EndInit();
            this.karty_ocenBindingNavigator.ResumeLayout(false);
            this.karty_ocenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajePracBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaDanychDataSet bazaDanychDataSet;
        private System.Windows.Forms.BindingSource karty_ocenBindingSource;
        private BazaDanychDataSetTableAdapters.Karty_ocenTableAdapter karty_ocenTableAdapter;
        private BazaDanychDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator karty_ocenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton karty_ocenBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ocenaTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox uwagiTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource uczniowieBindingSource;
        private BazaDanychDataSetTableAdapters.UczniowieTableAdapter uczniowieTableAdapter;
        private System.Windows.Forms.BindingSource nauczycieleBindingSource;
        private BazaDanychDataSetTableAdapters.NauczycieleTableAdapter nauczycieleTableAdapter;
        private System.Windows.Forms.BindingSource przedmiotyBindingSource;
        private BazaDanychDataSetTableAdapters.PrzedmiotyTableAdapter przedmiotyTableAdapter;
        private System.Windows.Forms.BindingSource rodzajePracBindingSource;
        private BazaDanychDataSetTableAdapters.Rodzaje_pracTableAdapter rodzaje_pracTableAdapter;
    }
}