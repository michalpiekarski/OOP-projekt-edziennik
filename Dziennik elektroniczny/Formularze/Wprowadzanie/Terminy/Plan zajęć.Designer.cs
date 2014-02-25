namespace Dziennik_elektroniczny
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label klasaLabel;
            System.Windows.Forms.Label przedmiotLabel;
            System.Windows.Forms.Label salaLabel;
            System.Windows.Forms.Label prowadzącyLabel;
            System.Windows.Forms.Label rozpoczęcieLabel;
            System.Windows.Forms.Label zakończenieLabel;
            System.Windows.Forms.Label tematLabel;
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.salaTextBox = new System.Windows.Forms.TextBox();
            this.rozpoczęcieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.zakończenieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tematTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.klasyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.przedmiotyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.nauczycieleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klasyTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.KlasyTableAdapter();
            this.przedmiotyTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.PrzedmiotyTableAdapter();
            this.nauczycieleTableAdapter = new Dziennik_elektroniczny.BazaDanychDataSetTableAdapters.NauczycieleTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            klasaLabel = new System.Windows.Forms.Label();
            przedmiotLabel = new System.Windows.Forms.Label();
            salaLabel = new System.Windows.Forms.Label();
            prowadzącyLabel = new System.Windows.Forms.Label();
            rozpoczęcieLabel = new System.Windows.Forms.Label();
            zakończenieLabel = new System.Windows.Forms.Label();
            tematLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćBindingNavigator)).BeginInit();
            this.plan_zajęćBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingSource)).BeginInit();
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
            // klasaLabel
            // 
            klasaLabel.AutoSize = true;
            klasaLabel.Location = new System.Drawing.Point(9, 57);
            klasaLabel.Name = "klasaLabel";
            klasaLabel.Size = new System.Drawing.Size(36, 13);
            klasaLabel.TabIndex = 3;
            klasaLabel.Text = "Klasa:";
            // 
            // przedmiotLabel
            // 
            przedmiotLabel.AutoSize = true;
            przedmiotLabel.Location = new System.Drawing.Point(9, 83);
            przedmiotLabel.Name = "przedmiotLabel";
            przedmiotLabel.Size = new System.Drawing.Size(56, 13);
            przedmiotLabel.TabIndex = 5;
            przedmiotLabel.Text = "Przedmiot:";
            // 
            // salaLabel
            // 
            salaLabel.AutoSize = true;
            salaLabel.Location = new System.Drawing.Point(9, 109);
            salaLabel.Name = "salaLabel";
            salaLabel.Size = new System.Drawing.Size(31, 13);
            salaLabel.TabIndex = 7;
            salaLabel.Text = "Sala:";
            // 
            // prowadzącyLabel
            // 
            prowadzącyLabel.AutoSize = true;
            prowadzącyLabel.Location = new System.Drawing.Point(9, 135);
            prowadzącyLabel.Name = "prowadzącyLabel";
            prowadzącyLabel.Size = new System.Drawing.Size(68, 13);
            prowadzącyLabel.TabIndex = 9;
            prowadzącyLabel.Text = "Prowadzący:";
            // 
            // rozpoczęcieLabel
            // 
            rozpoczęcieLabel.AutoSize = true;
            rozpoczęcieLabel.Location = new System.Drawing.Point(9, 162);
            rozpoczęcieLabel.Name = "rozpoczęcieLabel";
            rozpoczęcieLabel.Size = new System.Drawing.Size(72, 13);
            rozpoczęcieLabel.TabIndex = 11;
            rozpoczęcieLabel.Text = "Rozpoczęcie:";
            // 
            // zakończenieLabel
            // 
            zakończenieLabel.AutoSize = true;
            zakończenieLabel.Location = new System.Drawing.Point(9, 188);
            zakończenieLabel.Name = "zakończenieLabel";
            zakończenieLabel.Size = new System.Drawing.Size(72, 13);
            zakończenieLabel.TabIndex = 13;
            zakończenieLabel.Text = "Zakończenie:";
            // 
            // tematLabel
            // 
            tematLabel.AutoSize = true;
            tematLabel.Location = new System.Drawing.Point(9, 213);
            tematLabel.Name = "tematLabel";
            tematLabel.Size = new System.Drawing.Size(40, 13);
            tematLabel.TabIndex = 15;
            tematLabel.Text = "Temat:";
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
            this.plan_zajęćBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.plan_zajęćBindingNavigator.TabIndex = 0;
            this.plan_zajęćBindingNavigator.Text = "bindingNavigator1";
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
            // plan_zajęćBindingNavigatorSaveItem
            // 
            this.plan_zajęćBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plan_zajęćBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plan_zajęćBindingNavigatorSaveItem.Image")));
            this.plan_zajęćBindingNavigatorSaveItem.Name = "plan_zajęćBindingNavigatorSaveItem";
            this.plan_zajęćBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.plan_zajęćBindingNavigatorSaveItem.Text = "Save Data";
            this.plan_zajęćBindingNavigatorSaveItem.Click += new System.EventHandler(this.plan_zajęćBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plan_zajęćBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(87, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(186, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // salaTextBox
            // 
            this.salaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plan_zajęćBindingSource, "Sala", true));
            this.salaTextBox.Location = new System.Drawing.Point(87, 106);
            this.salaTextBox.Name = "salaTextBox";
            this.salaTextBox.Size = new System.Drawing.Size(186, 20);
            this.salaTextBox.TabIndex = 8;
            // 
            // rozpoczęcieDateTimePicker
            // 
            this.rozpoczęcieDateTimePicker.CustomFormat = "d MMM yyyy - H:m";
            this.rozpoczęcieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.plan_zajęćBindingSource, "Rozpoczęcie", true));
            this.rozpoczęcieDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rozpoczęcieDateTimePicker.Location = new System.Drawing.Point(87, 158);
            this.rozpoczęcieDateTimePicker.Name = "rozpoczęcieDateTimePicker";
            this.rozpoczęcieDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.rozpoczęcieDateTimePicker.TabIndex = 12;
            // 
            // zakończenieDateTimePicker
            // 
            this.zakończenieDateTimePicker.CustomFormat = "d MMM yyyy - H:m";
            this.zakończenieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.plan_zajęćBindingSource, "Zakończenie", true));
            this.zakończenieDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.zakończenieDateTimePicker.Location = new System.Drawing.Point(87, 184);
            this.zakończenieDateTimePicker.Name = "zakończenieDateTimePicker";
            this.zakończenieDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.zakończenieDateTimePicker.TabIndex = 14;
            // 
            // tematTextBox
            // 
            this.tematTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plan_zajęćBindingSource, "Temat", true));
            this.tematTextBox.Location = new System.Drawing.Point(87, 210);
            this.tematTextBox.Multiline = true;
            this.tematTextBox.Name = "tematTextBox";
            this.tematTextBox.Size = new System.Drawing.Size(186, 60);
            this.tematTextBox.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plan_zajęćBindingSource, "Klasa", true));
            this.comboBox1.DataSource = this.klasyBindingSource;
            this.comboBox1.DisplayMember = "Klasa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "Klasa";
            // 
            // klasyBindingSource
            // 
            this.klasyBindingSource.DataMember = "Klasy";
            this.klasyBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plan_zajęćBindingSource, "Przedmiot", true));
            this.comboBox2.DataSource = this.przedmiotyBindingSource;
            this.comboBox2.DisplayMember = "Przedmiot";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "Przedmiot";
            // 
            // przedmiotyBindingSource
            // 
            this.przedmiotyBindingSource.DataMember = "Przedmioty";
            this.przedmiotyBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plan_zajęćBindingSource, "Prowadzący", true));
            this.comboBox3.DataSource = this.nauczycieleBindingSource;
            this.comboBox3.DisplayMember = "Nazwisko";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(87, 132);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 21);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.ValueMember = "Nazwisko";
            // 
            // nauczycieleBindingSource
            // 
            this.nauczycieleBindingSource.DataMember = "Nauczyciele";
            this.nauczycieleBindingSource.DataSource = this.bazaDanychDataSet;
            // 
            // klasyTableAdapter
            // 
            this.klasyTableAdapter.ClearBeforeFill = true;
            // 
            // przedmiotyTableAdapter
            // 
            this.przedmiotyTableAdapter.ClearBeforeFill = true;
            // 
            // nauczycieleTableAdapter
            // 
            this.nauczycieleTableAdapter.ClearBeforeFill = true;
            // 
            // Plan_zajęć
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(klasaLabel);
            this.Controls.Add(przedmiotLabel);
            this.Controls.Add(salaLabel);
            this.Controls.Add(this.salaTextBox);
            this.Controls.Add(prowadzącyLabel);
            this.Controls.Add(rozpoczęcieLabel);
            this.Controls.Add(this.rozpoczęcieDateTimePicker);
            this.Controls.Add(zakończenieLabel);
            this.Controls.Add(this.zakończenieDateTimePicker);
            this.Controls.Add(tematLabel);
            this.Controls.Add(this.tematTextBox);
            this.Controls.Add(this.plan_zajęćBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Plan_zajęć";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan_zajęć";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.Load += new System.EventHandler(this.Plan_zajęć_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDanychDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_zajęćBindingNavigator)).EndInit();
            this.plan_zajęćBindingNavigator.ResumeLayout(false);
            this.plan_zajęćBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycieleBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox salaTextBox;
        private System.Windows.Forms.DateTimePicker rozpoczęcieDateTimePicker;
        private System.Windows.Forms.DateTimePicker zakończenieDateTimePicker;
        private System.Windows.Forms.TextBox tematTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource klasyBindingSource;
        private BazaDanychDataSetTableAdapters.KlasyTableAdapter klasyTableAdapter;
        private System.Windows.Forms.BindingSource przedmiotyBindingSource;
        private BazaDanychDataSetTableAdapters.PrzedmiotyTableAdapter przedmiotyTableAdapter;
        private System.Windows.Forms.BindingSource nauczycieleBindingSource;
        private BazaDanychDataSetTableAdapters.NauczycieleTableAdapter nauczycieleTableAdapter;
    }
}