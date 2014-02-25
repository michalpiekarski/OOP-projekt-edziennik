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
    public partial class Klasy : Form
    {
        public Klasy()
        {
            InitializeComponent();
        }

        private void klasyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klasyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDanychDataSet);

        }

        private void Klasy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Klasy' table. You can move, or remove it, as needed.
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);

        }
    }
}
