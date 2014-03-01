using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Wprowadzanie
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
            this.przedmiotyBindingSource.Position = Math.Max(0, this.przedmiotyBindingSource.Count - 1);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.PrzedmiotyWprowadzanie] = false;
        }
    }
}
