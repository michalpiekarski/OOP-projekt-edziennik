using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Wprowadzanie
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
            this.rodzaje_pracTableAdapter.Fill(this.bazaDanychDataSet.Rodzaje_prac);
            this.przedmiotyTableAdapter.Fill(this.bazaDanychDataSet.Przedmioty);
            this.nauczycieleTableAdapter.Fill(this.bazaDanychDataSet.Nauczyciele);
            this.uczniowieTableAdapter.Fill(this.bazaDanychDataSet.Uczniowie);
            this.karty_ocenTableAdapter.Fill(this.bazaDanychDataSet.Karty_ocen);
            this.karty_ocenBindingSource.Position = Math.Max(0, this.karty_ocenBindingSource.Count - 1);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.KartyOcenWprowadzanie] = false;
        }
    }
}
