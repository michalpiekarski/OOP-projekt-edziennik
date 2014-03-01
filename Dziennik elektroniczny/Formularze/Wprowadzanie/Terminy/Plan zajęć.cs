using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
{
    public partial class Plan_zajęć : Form
    {
        MainNav main;
        public Plan_zajęć()
        {
            InitializeComponent();
        }
        public Plan_zajęć(MainNav mn)
        {
            main = mn;
            InitializeComponent();
        }
        private void plan_zajęćBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plan_zajęćBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);
        }
        private void Plan_zajęć_Load(object sender, EventArgs e)
        {
            this.nauczycieleTableAdapter.Fill(this.bazaDanychDataSet.Nauczyciele);
            this.przedmiotyTableAdapter.Fill(this.bazaDanychDataSet.Przedmioty);
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);
            this.plan_zajęćTableAdapter.Fill(this.bazaDanychDataSet.Plan_zajęć);
            this.plan_zajęćBindingSource.Position = Math.Max(0, this.plan_zajęćBindingSource.Count - 1);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.PlanZajęćWprowadzanie] = false;
        }
    }
}
