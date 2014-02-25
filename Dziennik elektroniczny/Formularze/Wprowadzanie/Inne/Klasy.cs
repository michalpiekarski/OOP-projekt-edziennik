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
    public partial class Klasy : Form
    {
        MainNav main;
        public Klasy()
        {
            InitializeComponent();
        }
        public Klasy(MainNav mn)
        {
            main = mn;
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
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Nauczyciele' table. You can move, or remove it, as needed.
            this.nauczycieleTableAdapter.Fill(this.bazaDanychDataSet.Nauczyciele);
            // TODO: This line of code loads data into the 'bazaDanychDataSet.Klasy' table. You can move, or remove it, as needed.
            this.klasyTableAdapter.Fill(this.bazaDanychDataSet.Klasy);
            this.klasyBindingSource.Position = Math.Max(0, this.klasyBindingSource.Count - 1);
        }

        private void SygnalizujZamknięcie(object sender, FormClosedEventArgs e)
        {
            main.currentSubForm[(int)CurrentSubForm.KlasyWprowadzanie] = false;
        }
    }
}
