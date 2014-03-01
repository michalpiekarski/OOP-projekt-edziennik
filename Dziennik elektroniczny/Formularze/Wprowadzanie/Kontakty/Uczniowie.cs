using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Wprowadzanie
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
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);
            this.uczniowieTableAdapter.Fill(this.bazaDanychDataSet.Uczniowie);
            this.uczniowieBindingSource.Position = Math.Max(0, this.uczniowieBindingSource.Count - 1);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.UczniowieWprowadzanie] = false;
        }
    }
}
