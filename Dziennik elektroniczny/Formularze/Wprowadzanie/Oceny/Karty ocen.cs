using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
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
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Rodzaje_prac' table. You can move, or remove it, as needed.
            this.rodzaje_pracTableAdapter.Fill(this.bazaDanychDataSet.Rodzaje_prac);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Przedmioty' table. You can move, or remove it, as needed.
            this.przedmiotyTableAdapter.Fill(this.bazaDanychDataSet.Przedmioty);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Nauczyciele' table. You can move, or remove it, as needed.
            this.nauczycieleTableAdapter.Fill(this.bazaDanychDataSet.Nauczyciele);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Uczniowie' table. You can move, or remove it, as needed.
            this.uczniowieTableAdapter.Fill(this.bazaDanychDataSet.Uczniowie);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Karty_ocen' table. You can move, or remove it, as needed.
            this.karty_ocenTableAdapter.Fill(this.bazaDanychDataSet.Karty_ocen);
            this.karty_ocenBindingSource.Position = Math.Max(0, this.karty_ocenBindingSource.Count - 1);
        }

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.KartyOcenWprowadzanie] = false;
        }
    }
}
