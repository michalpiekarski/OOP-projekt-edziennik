namespace Dziennik_elektroniczny
{
    partial class Uczniowie
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
            System.Windows.Forms.Label pESELLabel;
            System.Windows.Forms.Label klasaLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label numer_domuLabel;
            System.Windows.Forms.Label numer_lokaluLabel;
            System.Windows.Forms.Label kod_pocztowyLabel;
            System.Windows.Forms.Label miejscowośćLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uczniowie));
            this.uczniowieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.uczniowieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDanychDataSet = new Dziennik_elektroniczny.BazaDanychDataSet();
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
            this.uczniowieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imięTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.pESELTextBox = new System.Windows.Forms.TextBox();
            this.uczniowieTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.UczniowieTableAdapter();
            this.tableAdapterManager = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.klasyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klasyTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.KlasyTableAdapter();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.numer_domuTextBox = new System.Windows.Forms.TextBox();
            this.numer_lokaluTextBox = new System.Windows.Forms.TextBox();
            this.kod_pocztowyTextBox = new System.Windows.Forms.TextBox();
            this.miejscowośćTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            imięLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            pESELLabel = new System.Windows.Forms.Label();
            klasaLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            numer_domuLabel = new System.Windows.Forms.Label();
            numer_lokaluLabel = new System.Windows.Forms.Label();
            kod_pocztowyLabel = new System.Windows.Forms.Label();
            miejscowośćLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingNavigator)).BeginInit();
            this.uczniowieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // imięLabel
            // 
            imięLabel.AutoSize = true;
            imięLabel.Location = new System.Drawing.Point(9, 57);
            imięLabel.Name = "imięLabel";
            imięLabel.Size = new System.Drawing.Size(29, 13);
            imięLabel.TabIndex = 3;
            imięLabel.Text = "Imię:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(9, 83);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(56, 13);
            nazwiskoLabel.TabIndex = 5;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // pESELLabel
            // 
            pESELLabel.AutoSize = true;
            pESELLabel.Location = new System.Drawing.Point(9, 109);
            pESELLabel.Name = "pESELLabel";
            pESELLabel.Size = new System.Drawing.Size(44, 13);
            pESELLabel.TabIndex = 7;
            pESELLabel.Text = "PESEL:";
            // 
            // klasaLabel
            // 
            klasaLabel.AutoSize = true;
            klasaLabel.Location = new System.Drawing.Point(9, 265);
            klasaLabel.Name = "klasaLabel";
            klasaLabel.Size = new System.Drawing.Size(36, 13);
            klasaLabel.TabIndex = 9;
            klasaLabel.Text = "Klasa:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(9, 135);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(34, 13);
            ulicaLabel.TabIndex = 11;
            ulicaLabel.Text = "Ulica:";
            // 
            // numer_domuLabel
            // 
            numer_domuLabel.AutoSize = true;
            numer_domuLabel.Location = new System.Drawing.Point(9, 161);
            numer_domuLabel.Name = "numer_domuLabel";
            numer_domuLabel.Size = new System.Drawing.Size(70, 13);
            numer_domuLabel.TabIndex = 13;
            numer_domuLabel.Text = "Numer domu:";
            // 
            // numer_lokaluLabel
            // 
            numer_lokaluLabel.AutoSize = true;
            numer_lokaluLabel.Location = new System.Drawing.Point(9, 187);
            numer_lokaluLabel.Name = "numer_lokaluLabel";
            numer_lokaluLabel.Size = new System.Drawing.Size(72, 13);
            numer_lokaluLabel.TabIndex = 15;
            numer_lokaluLabel.Text = "Numer lokalu:";
            // 
            // kod_pocztowyLabel
            // 
            kod_pocztowyLabel.AutoSize = true;
            kod_pocztowyLabel.Location = new System.Drawing.Point(9, 213);
            kod_pocztowyLabel.Name = "kod_pocztowyLabel";
            kod_pocztowyLabel.Size = new System.Drawing.Size(77, 13);
            kod_pocztowyLabel.TabIndex = 17;
            kod_pocztowyLabel.Text = "Kod pocztowy:";
            // 
            // miejscowośćLabel
            // 
            miejscowośćLabel.AutoSize = true;
            miejscowośćLabel.Location = new System.Drawing.Point(9, 239);
            miejscowośćLabel.Name = "miejscowośćLabel";
            miejscowośćLabel.Size = new System.Drawing.Size(71, 13);
            miejscowośćLabel.TabIndex = 19;
            miejscowośćLabel.Text = "Miejscowość:";
            // 
            // uczniowieBindingNavigator
            // 
            this.uczniowieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uczniowieBindingNavigator.BindingSource = this.uczniowieBindingSource;
            this.uczniowieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uczniowieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uczniowieBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.uczniowieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uczniowieBindingNavigatorSaveItem});
            this.uczniowieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uczniowieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uczniowieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uczniowieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uczniowieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uczniowieBindingNavigator.Name = "uczniowieBindingNavigator";
            this.uczniowieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uczniowieBindingNavigator.Size = new System.Drawing.Size(297, 25);
            this.uczniowieBindingNavigator.TabIndex = 0;
            this.uczniowieBindingNavigator.Text = "bindingNavigator1";
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
            // uczniowieBindingSource
            // 
            this.uczniowieBindingSource.DataMember = "Uczniowie";
            this.uczniowieBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // bazaDanychDataSet
            // 
            this.bazaDanychDataSet.DataSetName = "BazaDanychDataSet";
            this.bazaDanychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // uczniowieBindingNavigatorSaveItem
            // 
            this.uczniowieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uczniowieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uczniowieBindingNavigatorSaveItem.Image")));
            this.uczniowieBindingNavigatorSaveItem.Name = "uczniowieBindingNavigatorSaveItem";
            this.uczniowieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uczniowieBindingNavigatorSaveItem.Text = "Save Data";
            this.uczniowieBindingNavigatorSaveItem.Click += new System.EventHandler(this.uczniowieBindingNavigatorSaveItem_Click_2);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(96, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(189, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // imięTextBox
            // 
            this.imięTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "Imię", true));
            this.imięTextBox.Location = new System.Drawing.Point(96, 54);
            this.imięTextBox.Name = "imięTextBox";
            this.imięTextBox.Size = new System.Drawing.Size(189, 20);
            this.imięTextBox.TabIndex = 4;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "Nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(96, 80);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(189, 20);
            this.nazwiskoTextBox.TabIndex = 6;
            // 
            // pESELTextBox
            // 
            this.pESELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "PESEL", true));
            this.pESELTextBox.Location = new System.Drawing.Point(96, 106);
            this.pESELTextBox.Name = "pESELTextBox";
            this.pESELTextBox.Size = new System.Drawing.Size(189, 20);
            this.pESELTextBox.TabIndex = 8;
            // 
            // uczniowieTableAdapter
            // 
            this.uczniowieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Karty_ocenTableAdapter = null;
            this.tableAdapterManager.KlasyTableAdapter = null;
            this.tableAdapterManager.NauczycieleTableAdapter = null;
            this.tableAdapterManager.Plan_zajęćTableAdapter = null;
            this.tableAdapterManager.PrzedmiotyTableAdapter = null;
            this.tableAdapterManager.Rodzaje_pracTableAdapter = null;
            this.tableAdapterManager.UczniowieTableAdapter = this.uczniowieTableAdapter;
            this.tableAdapterManager.UpdateOrder = Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uczniowieBindingSource, "Klasa", true));
            this.comboBox1.DataSource = this.klasyBindingSource;
            this.comboBox1.DisplayMember = "Klasa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 262);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Klasa";
            // 
            // klasyBindingSource
            // 
            this.klasyBindingSource.DataMember = "Klasy";
            this.klasyBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // klasyTableAdapter
            // 
            this.klasyTableAdapter.ClearBeforeFill = true;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "Ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(96, 132);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(189, 20);
            this.ulicaTextBox.TabIndex = 12;
            // 
            // numer_domuTextBox
            // 
            this.numer_domuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "Numer domu", true));
            this.numer_domuTextBox.Location = new System.Drawing.Point(96, 158);
            this.numer_domuTextBox.Name = "numer_domuTextBox";
            this.numer_domuTextBox.Size = new System.Drawing.Size(189, 20);
            this.numer_domuTextBox.TabIndex = 14;
            // 
            // numer_lokaluTextBox
            // 
            this.numer_lokaluTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "Numer lokalu", true));
            this.numer_lokaluTextBox.Location = new System.Drawing.Point(96, 184);
            this.numer_lokaluTextBox.Name = "numer_lokaluTextBox";
            this.numer_lokaluTextBox.Size = new System.Drawing.Size(189, 20);
            this.numer_lokaluTextBox.TabIndex = 16;
            // 
            // kod_pocztowyTextBox
            // 
            this.kod_pocztowyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "Kod pocztowy", true));
            this.kod_pocztowyTextBox.Location = new System.Drawing.Point(96, 210);
            this.kod_pocztowyTextBox.Name = "kod_pocztowyTextBox";
            this.kod_pocztowyTextBox.Size = new System.Drawing.Size(189, 20);
            this.kod_pocztowyTextBox.TabIndex = 18;
            // 
            // miejscowośćTextBox
            // 
            this.miejscowośćTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "Miejscowość", true));
            this.miejscowośćTextBox.Location = new System.Drawing.Point(96, 236);
            this.miejscowośćTextBox.Name = "miejscowośćTextBox";
            this.miejscowośćTextBox.Size = new System.Drawing.Size(189, 20);
            this.miejscowośćTextBox.TabIndex = 20;
            // 
            // Uczniowie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 294);
            this.Controls.Add(miejscowośćLabel);
            this.Controls.Add(this.miejscowośćTextBox);
            this.Controls.Add(kod_pocztowyLabel);
            this.Controls.Add(this.kod_pocztowyTextBox);
            this.Controls.Add(numer_lokaluLabel);
            this.Controls.Add(this.numer_lokaluTextBox);
            this.Controls.Add(numer_domuLabel);
            this.Controls.Add(this.numer_domuTextBox);
            this.Controls.Add(ulicaLabel);
            this.Controls.Add(this.ulicaTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(imięLabel);
            this.Controls.Add(this.imięTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(pESELLabel);
            this.Controls.Add(this.pESELTextBox);
            this.Controls.Add(klasaLabel);
            this.Controls.Add(this.uczniowieBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Uczniowie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uczniowie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SygnalizujZamknięcie);
            this.Load += new System.EventHandler(this.Uczniowie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingNavigator)).EndInit();
            this.uczniowieBindingNavigator.ResumeLayout(false);
            this.uczniowieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaDanychDataSet bazaDanychDataSet;
        private System.Windows.Forms.BindingSource uczniowieBindingSource;
        private BazaDanychDataSetTableAdapters.UczniowieTableAdapter uczniowieTableAdapter;
        private BazaDanychDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uczniowieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uczniowieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox imięTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox pESELTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource klasyBindingSource;
        private BazaDanychDataSetTableAdapters.KlasyTableAdapter klasyTableAdapter;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox numer_domuTextBox;
        private System.Windows.Forms.TextBox numer_lokaluTextBox;
        private System.Windows.Forms.TextBox kod_pocztowyTextBox;
        private System.Windows.Forms.TextBox miejscowośćTextBox;


    }
}