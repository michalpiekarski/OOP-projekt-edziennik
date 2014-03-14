using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie.Terminy
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
            this.plan_zajęćTableAdapter.Fill(this.bazaDanychDataSet.Plan_zajęć);
        }
        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            SubForm.SygnalizuZamknięcie(ref main, CurrentSubForm.PlanZajęćPrzeglądanie);
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            SubForm.FiltrujTabelę(this.filterBy.Text, this.filterValue.Text, ref this.plan_zajęćBindingSource, this.bazaDanychDataSet.Plan_zajęć);
        }
        private void ResetujFiltr(object sender, EventArgs e)
        {
            SubForm.ResetujFiltr(ref this.filterValue, ref this.filterBy, ref this.plan_zajęćBindingSource);
        }
    }
}
