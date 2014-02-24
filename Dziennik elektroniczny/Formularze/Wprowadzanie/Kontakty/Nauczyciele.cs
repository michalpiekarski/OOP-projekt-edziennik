﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
{
    public partial class Nauczyciele : Form
    {
        public MainNav parentRef;
        public Nauczyciele()
        {
            InitializeComponent();
        }

        private void nauczycieleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nauczycieleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);

        }

        private void Nauczyciele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Nauczyciele' table. You can move, or remove it, as needed.
            this.nauczycieleTableAdapter.Fill(this.bazaDanychDataSet.Nauczyciele);

        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            parentRef.nauczycieleWprowadzanie = null;
        }
    }
}