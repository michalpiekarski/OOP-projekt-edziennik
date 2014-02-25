using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie.Inne
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
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Przedmioty' table. You can move, or remove it, as needed.
            this.przedmiotyTableAdapter.Fill(this.bazaDanychDataSet.Przedmioty);

        }

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.PrzedmiotyPrzeglądanie] = false;
        }
    }
}
