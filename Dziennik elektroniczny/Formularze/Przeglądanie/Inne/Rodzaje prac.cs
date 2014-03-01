using System;
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
            this.rodzaje_pracTableAdapter.Fill(this.bazaDanychDataSet.Rodzaje_prac);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.RodzajePracPrzeglądanie] = false;
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            SubForm.FiltrujTabelę(this.filterBy.Text, this.filterValue.Text, ref this.rodzaje_pracBindingSource, this.bazaDanychDataSet.Rodzaje_prac);
        }
        private void ResetujFiltr(object sender, EventArgs e)
        {
            SubForm.ResetujFiltr(ref this.filterValue, ref this.filterBy, ref this.rodzaje_pracBindingSource);
        }
    }
}
