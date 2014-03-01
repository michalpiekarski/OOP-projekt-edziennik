using System;
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
            this.nauczycieleTableAdapter.Fill(this.bazaDanychDataSet.Nauczyciele);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            SubForm.SygnalizuZamknięcie(ref main, CurrentSubForm.NauczycielePrzeglądanie);
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            SubForm.FiltrujTabelę(this.filterBy.Text, this.filterValue.Text, ref this.nauczycieleBindingSource, this.bazaDanychDataSet.Nauczyciele);
        }
        private void ResetujFiltr(object sender, EventArgs e)
        {
            SubForm.ResetujFiltr(ref this.filterValue, ref this.filterBy, ref this.nauczycieleBindingSource);
        }
    }
}
