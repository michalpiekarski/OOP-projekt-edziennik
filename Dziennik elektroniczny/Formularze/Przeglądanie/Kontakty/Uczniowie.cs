using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze.Przeglądanie.Kontakty
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

        private void Uczniowie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Uczniowie' table. You can move, or remove it, as needed.
            this.uczniowieTableAdapter.Fill(this.bazaDanychDataSet.Uczniowie);

        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            parentRef.uczniowiePrzeglądanie = null;
        }
    }
}
