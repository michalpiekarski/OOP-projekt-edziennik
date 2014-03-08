namespace Dziennik_elektroniczny
{
    partial class SingleWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Wprowadzanie = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Przeglądanie = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Raportowanie = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Wprowadzanie.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Przeglądanie.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.Raportowanie.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Wprowadzanie);
            this.tabControl1.Controls.Add(this.Przeglądanie);
            this.tabControl1.Controls.Add(this.Raportowanie);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 444);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.SetWidth);
            // 
            // Wprowadzanie
            // 
            this.Wprowadzanie.Controls.Add(this.groupBox4);
            this.Wprowadzanie.Controls.Add(this.groupBox3);
            this.Wprowadzanie.Controls.Add(this.groupBox2);
            this.Wprowadzanie.Controls.Add(this.groupBox1);
            this.Wprowadzanie.Location = new System.Drawing.Point(4, 22);
            this.Wprowadzanie.Name = "Wprowadzanie";
            this.Wprowadzanie.Padding = new System.Windows.Forms.Padding(3);
            this.Wprowadzanie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Wprowadzanie.Size = new System.Drawing.Size(251, 418);
            this.Wprowadzanie.TabIndex = 0;
            this.Wprowadzanie.Text = "Wprowadzanie";
            this.Wprowadzanie.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(8, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 149);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inne";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 105);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 37);
            this.button8.TabIndex = 2;
            this.button8.Text = "Rodzaje prac";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.RodzajePracWprowadzanieClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 37);
            this.button7.TabIndex = 1;
            this.button7.Text = "Przedmioty";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PrzedmiotyWprowadzanieClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 37);
            this.button6.TabIndex = 0;
            this.button6.Text = "Klasy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.KlasyWprowadzanieClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(8, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 63);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oceny";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 37);
            this.button5.TabIndex = 0;
            this.button5.Text = "Karty ocen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.KartyOcenWprowadzanieClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(8, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 62);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminy";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Plan zajęć";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PlanZajęćWprowadzanieClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontakty";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nauczyciele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NauczycieleWprowadzanieClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Uczniowie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UczniowieWprowadzanieClick);
            // 
            // Przeglądanie
            // 
            this.Przeglądanie.Controls.Add(this.groupBox5);
            this.Przeglądanie.Controls.Add(this.groupBox6);
            this.Przeglądanie.Controls.Add(this.groupBox7);
            this.Przeglądanie.Controls.Add(this.groupBox8);
            this.Przeglądanie.Location = new System.Drawing.Point(4, 22);
            this.Przeglądanie.Name = "Przeglądanie";
            this.Przeglądanie.Padding = new System.Windows.Forms.Padding(3);
            this.Przeglądanie.Size = new System.Drawing.Size(251, 418);
            this.Przeglądanie.TabIndex = 1;
            this.Przeglądanie.Text = "Przeglądanie";
            this.Przeglądanie.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Location = new System.Drawing.Point(8, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 149);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inne";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rodzaje prac";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RodzajePracPrzeglądanieClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 62);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(223, 37);
            this.button9.TabIndex = 1;
            this.button9.Text = "Przedmioty";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PrzedmiotyPrzeglądanieClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(223, 37);
            this.button10.TabIndex = 0;
            this.button10.Text = "Klasy";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.KlasyPrzeglądanieClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button11);
            this.groupBox6.Location = new System.Drawing.Point(8, 189);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 63);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Oceny";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(223, 37);
            this.button11.TabIndex = 0;
            this.button11.Text = "Karty ocen";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.KartyOcenPrzeglądanieClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button12);
            this.groupBox7.Location = new System.Drawing.Point(8, 121);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(235, 62);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Terminy";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(223, 37);
            this.button12.TabIndex = 0;
            this.button12.Text = "Plan zajęć";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.PlanZajęćPrzeglądanieClick);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button13);
            this.groupBox8.Controls.Add(this.button14);
            this.groupBox8.Location = new System.Drawing.Point(8, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(235, 109);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kontakty";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 62);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(223, 37);
            this.button13.TabIndex = 2;
            this.button13.Text = "Nauczyciele";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.NauczycielePrzeglądanieClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 19);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(223, 37);
            this.button14.TabIndex = 0;
            this.button14.Text = "Uczniowie";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.UczniowiePrzeglądanieClick);
            // 
            // Raportowanie
            // 
            this.Raportowanie.Controls.Add(this.groupBox9);
            this.Raportowanie.Location = new System.Drawing.Point(4, 22);
            this.Raportowanie.Name = "Raportowanie";
            this.Raportowanie.Size = new System.Drawing.Size(251, 418);
            this.Raportowanie.TabIndex = 2;
            this.Raportowanie.Text = "Raportowanie";
            this.Raportowanie.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(259, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 444);
            this.panel1.TabIndex = 2;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button15);
            this.groupBox9.Controls.Add(this.button17);
            this.groupBox9.Controls.Add(this.button16);
            this.groupBox9.Location = new System.Drawing.Point(8, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(240, 186);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Raporty";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(6, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(228, 49);
            this.button15.TabIndex = 0;
            this.button15.Text = "Raport dla Ucznia";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 129);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(228, 49);
            this.button17.TabIndex = 2;
            this.button17.Text = "Raport dla Nauczyciela";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 74);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(228, 49);
            this.button16.TabIndex = 1;
            this.button16.Text = "Raport dla Klasy";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // SingleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(575, 483);
            this.Name = "SingleWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingleWindow";
            this.tabControl1.ResumeLayout(false);
            this.Wprowadzanie.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Przeglądanie.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.Raportowanie.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Wprowadzanie;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Przeglądanie;
        private System.Windows.Forms.TabPage Raportowanie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
    }
}