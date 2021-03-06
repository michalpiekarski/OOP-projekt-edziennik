﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie
{
    public partial class Klasy : Form
    {
        MainNav main;
        public Klasy()
        {
            InitializeComponent();
        }
        public Klasy(MainNav mn)
        {
            main = mn;
            InitializeComponent();
        }
        private void klasyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klasyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);
        }
        private void Klasy_Load(object sender, EventArgs e)
        {
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            SubForm.SygnalizuZamknięcie(ref main, CurrentSubForm.KlasyPrzeglądanie);
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            SubForm.FiltrujTabelę(filterBy.Text, filterValue.Text, ref this.klasyBindingSource, this.bazaDanychDataSet.Klasy);
        }
        private void ResetujFiltr(object sender, EventArgs e)
        {
            SubForm.ResetujFiltr(ref this.filterValue, ref this.filterBy, ref this.klasyBindingSource);
        }
    }
}
