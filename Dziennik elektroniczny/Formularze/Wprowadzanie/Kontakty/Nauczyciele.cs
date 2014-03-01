using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
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
            this.nauczycieleBindingSource.Position = Math.Max(0, this.nauczycieleBindingSource.Count - 1);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.NauczycieleWprowadzanie] = false;
        }
    }
}
