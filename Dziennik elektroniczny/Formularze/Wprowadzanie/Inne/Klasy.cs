using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
{
    public partial class Klasy : Form
    {
        MainNav main;
        public Klasy()
        {
            InitializeComponent();
        }
        public Klasy(MainNav mn)
        {
            main = mn;
            InitializeComponent();
        }
        private void klasyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klasyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);
        }
        private void Klasy_Load(object sender, EventArgs e)
        {
            this.nauczycieleTableAdapter.Fill(this.bazaDanychDataSet.Nauczyciele);
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);
            this.klasyBindingSource.Position = Math.Max(0, this.klasyBindingSource.Count - 1);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.KlasyWprowadzanie] = false;
        }
    }
}
