using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie
{
    public partial class Karty_ocen : Form
    {
        MainNav main;
        public Karty_ocen()
        {
            InitializeComponent();
        }
        public Karty_ocen(MainNav mn)
        {
            main = mn;
            InitializeComponent();
        }
        private void karty_ocenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.karty_ocenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);
        }
        private void Karty_ocen_Load(object sender, EventArgs e)
        {
            this.karty_ocenTableAdapter.Fill(this.bazaDanychDataSet.Karty_ocen);
        }
        private void SygnalizuZamknięcie(object sender, FormClosedEventArgs e)
        {
            SubForm.SygnalizuZamknięcie(ref main, CurrentSubForm.KartyOcenPrzeglądanie);
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            SubForm.FiltrujTabelę(this.filterBy.Text, this.filterValue.Text, ref this.karty_ocenBindingSource, this.bazaDanychDataSet.Karty_ocen);
        }
        private void ResetujFiltr(object sender, EventArgs e)
        {
            SubForm.ResetujFiltr(ref this.filterValue, ref this.filterBy, ref this.karty_ocenBindingSource);
        }
    }
}
