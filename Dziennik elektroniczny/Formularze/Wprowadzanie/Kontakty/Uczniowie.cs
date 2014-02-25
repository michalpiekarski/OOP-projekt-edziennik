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
    public partial class Uczniowie : Form
    {
        public MainNav parentRef;
        public Uczniowie()
        {
            InitializeComponent();
        }

        private void uczniowieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uczniowieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);

        }

        private void uczniowieBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uczniowieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);

        }

        private void uczniowieBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.uczniowieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);

        }

        private void Uczniowie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Klasy' table. You can move, or remove it, as needed.
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Uczniowie' table. You can move, or remove it, as needed.
            this.uczniowieTableAdapter.Fill(this.bazaDanychDataSet.Uczniowie);
            this.klasyBindingSource.Position = Math.Max(0, this.klasyBindingSource.Count - 1);
        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            parentRef.uczniowieWprowadzanie = null;
        }
    }
}
