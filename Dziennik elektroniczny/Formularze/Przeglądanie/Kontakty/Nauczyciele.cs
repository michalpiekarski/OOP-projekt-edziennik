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
    public partial class Nauczyciele : Form
    {
        MainNav main;
        public Nauczyciele()
        {
            InitializeComponent();
        }
        public Nauczyciele(MainNav mn)
        {
            main = mn;
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

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.NauczycielePrzeglądanie] = false;
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
            this.nauczycieleBindingSource.Filter = filterString;
        }

        private void ResetujFiltr(object sender, EventArgs e)
        {
            filterBy.SelectedIndex = -1;
            filterValue.Text = "";
            this.nauczycieleBindingSource.RemoveFilter();
        }
    }
}
