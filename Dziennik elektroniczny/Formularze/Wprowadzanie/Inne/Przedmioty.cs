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
    public partial class Przedmioty : Form
    {
        public MainNav parentRef;
        public Przedmioty()
        {
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
            this.przedmiotyBindingSource.Position = Math.Max(0, this.przedmiotyBindingSource.Count - 1);
        }

        private void Closed(object sender, FormClosedEventArgs e)
        {
            parentRef.przedmiotyWprowadzanie = null;
        }
    }
}
