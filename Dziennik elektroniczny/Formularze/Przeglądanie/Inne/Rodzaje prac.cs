﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie.Inne
{
    public partial class Rodzaje_prac : Form
    {
        MainNav main;
        public Rodzaje_prac()
        {
            InitializeComponent();
        }
        public Rodzaje_prac(MainNav mn)
        {
            main = mn;
            InitializeComponent();
        }

        private void rodzaje_pracBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rodzaje_pracBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);

        }

        private void Rodzaje_prac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Rodzaje_prac' table. You can move, or remove it, as needed.
            this.rodzaje_pracTableAdapter.Fill(this.bazaDanychDataSet.Rodzaje_prac);

        }

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.RodzajePracPrzeglądanie] = false;
        }
    }
}
