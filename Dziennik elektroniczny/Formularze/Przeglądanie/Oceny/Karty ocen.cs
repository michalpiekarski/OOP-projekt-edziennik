using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie.Oceny
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
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Karty_ocen' table. You can move, or remove it, as needed.
            this.karty_ocenTableAdapter.Fill(this.bazaDanychDataSet.Karty_ocen);

        }

        private void SygnalizuZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.KartyOcenPrzeglądanie] = false;
        }
        private void FiltrujTabelę(object sender, EventArgs e)
        {
            string filterString = filterBy.Text;
            if (filterString == "Id")
            {
                filterString += " = " + int.Parse(filterValue.Text);
            }
            else if(filterString == "Ocena")
            {
                filterString += " = " + float.Parse(filterValue.Text);
            }
            else if(filterString == "Data")
            {
                // UNDONE: Zdecydować nad zachowaniem w przypadku podjęcia próby filtrowania po dacie
            }
            else
            {
                if(filterString == "Rodzaj pracy")
                {
                    filterString = "[" + filterString + "]";
                }
                filterString += " like '" + filterValue.Text + "'";
            }
            this.karty_ocenBindingSource.Filter = filterString;
        }

        private void ResetujFiltr(object sender, EventArgs e)
        {
            filterValue.Text = "";
            filterBy.SelectedIndex = -1;
            this.karty_ocenBindingSource.RemoveFilter();
        }
    }
}
