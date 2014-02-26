using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Plan_zajęć' table. You can move, or remove it, as needed.
            this.plan_zajęćTableAdapter.Fill(this.bazaDanychDataSet.Plan_zajęć);

        }

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.PlanZajęćPrzeglądanie] = false;
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            string filterString = filterBy.Text;
            if (filterString == "Id")
            {
                filterString += " = " + int.Parse(filterValue.Text);
            }
            else if(filterString == "Rozpoczęcie" || filterString == "Zakończenie")
            {
                /// TODO: Zdecydować o zachowaniu w praypadku podjęcia próby filtrowania z użyciem dat
            }
            else
            {
                filterString += " like '" + filterValue.Text + "'";
            }
            this.plan_zajęćBindingSource.Filter = filterString;
        }

        private void ResetujFiltr(object sender, EventArgs e)
        {
            filterBy.SelectedIndex = -1;
            filterValue.Text = "";
            this.plan_zajęćBindingSource.RemoveFilter();
        }
    }
}
