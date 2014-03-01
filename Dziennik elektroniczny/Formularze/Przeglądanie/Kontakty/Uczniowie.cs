using System;
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
            this.uczniowieTableAdapter.Fill(this.bazaDanychDataSet.Uczniowie);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            SubForm.SygnalizuZamknięcie(ref main, CurrentSubForm.UczniowiePrzeglądanie);
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            SubForm.FiltrujTabelę(this.filterBy.Text, this.filterValue.Text, ref this.uczniowieBindingSource, this.bazaDanychDataSet.Uczniowie);
        }
        private void ResetujFiltr(object sender, EventArgs e)
        {
            SubForm.ResetujFiltr(ref this.filterValue, ref this.filterBy, ref this.uczniowieBindingSource);
        }
    }
}
