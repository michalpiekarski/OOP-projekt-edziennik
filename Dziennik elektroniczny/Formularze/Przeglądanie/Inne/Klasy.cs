using System;
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
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Klasy' table. You can move, or remove it, as needed.
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);

        }

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.KlasyPrzeglądanie] = false;
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            //string filterString = filterBy.Text;
            //if(filterString == "Id")
            //{
            //    filterString += " = " + int.Parse(filterValue.Text);
            //} else
            //{
            //    filterString += " like '" + filterValue.Text + "'";
            //}
            //this.klasyBindingSource.Filter = filterString;
            SubForm.FiltrujTabelę(filterBy.Text, filterValue.Text, ref this.klasyBindingSource, this.bazaDanychDataSet.Klasy); // TODO: Wyjaśnienie błędu - patrz definicja metody
        }

        private void ResetujFiltr(object sender, EventArgs e)
        {
            //filterValue.Text = "";
            //filterBy.SelectedIndex = -1;
            //this.klasyBindingSource.RemoveFilter();
            SubForm.ResetujFiltr(ref this.filterValue, ref this.filterBy, ref this.klasyBindingSource);
        }
    }
}
