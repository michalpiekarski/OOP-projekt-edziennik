using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze
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
            backgroundWorker1.RunWorkerAsync(); // TO RÓWNIEŻ NIE DZIAŁA (PONAD TO SIĘ OKAZUJE ŻE NAWET NIE JEST TO ZALECANE PRZEZ MICROSOFT)
        }

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.PlanZajęćWprowadzanie] = false;
        }

        private void LoadData(object sender, DoWorkEventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Nauczyciele' table. You can move, or remove it, as needed.
            this.nauczycieleTableAdapter.Fill(this.bazaDanychDataSet.Nauczyciele);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Przedmioty' table. You can move, or remove it, as needed.
            this.przedmiotyTableAdapter.Fill(this.bazaDanychDataSet.Przedmioty);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Klasy' table. You can move, or remove it, as needed.
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Plan_zajęć' table. You can move, or remove it, as needed.
            this.plan_zajęćTableAdapter.Fill(this.bazaDanychDataSet.Plan_zajęć);
        }

        private void SetPositionInData(object sender, RunWorkerCompletedEventArgs e)
        {
            this.plan_zajęćBindingSource.Position = Math.Max(0, this.plan_zajęćBindingSource.Count - 1);
        }

    }
}
