using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie
{
    public partial class Przedmioty : Form
    {
        MainNav main;
        public Przedmioty()
        {
            InitializeComponent();
        }
        public Przedmioty(MainNav mn)
        {
            main = mn;
            InitializeComponent();
        }
        private void przedmiotyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.przedmiotyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);
        }
        private void Przedmioty_Load(object sender, EventArgs e)
        {
            this.przedmiotyTableAdapter.Fill(this.bazaDanychDataSet.Przedmioty);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            SubForm.SygnalizuZamknięcie(ref main, CurrentSubForm.PrzedmiotyPrzeglądanie);
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            SubForm.FiltrujTabelę(this.filterBy.Text, this.filterValue.Text, ref this.przedmiotyBindingSource, this.bazaDanychDataSet.Przedmioty);
        }
        private void ResetujFiltr(object sender, EventArgs e)
        {
            SubForm.ResetujFiltr(ref this.filterValue, ref this.filterBy, ref this.przedmiotyBindingSource);
        }
    }
}
