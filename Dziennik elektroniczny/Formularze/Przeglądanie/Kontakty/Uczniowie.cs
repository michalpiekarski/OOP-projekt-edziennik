using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie.Kontakty
{
    public partial class Uczniowie : Form
    {
        MainNav main;
        public Uczniowie()
        {
            InitializeComponent();
        }
        public Uczniowie(MainNav mn)
        {
            main = mn;
            InitializeComponent();
        }

        private void uczniowieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uczniowieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);

        }

        private void Uczniowie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Uczniowie' table. You can move, or remove it, as needed.
            this.uczniowieTableAdapter.Fill(this.bazaDanychDataSet.Uczniowie);

        }

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.UczniowiePrzeglądanie] = false;
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            string filterString = filterBy.Text;
            if (filterString == "Id")
            {
                filterString += " = " + int.Parse(filterValue.Text);
            }
            else
            {
                filterString += " like '" + filterValue.Text + "'";
            }
            this.uczniowieBindingSource.Filter = filterString;
        }

        private void ResetujFiltr(object sender, EventArgs e)
        {
            filterValue.Text = "";
            filterBy.SelectedIndex = -1;
            this.uczniowieBindingSource.RemoveFilter();
        }
    }
}
