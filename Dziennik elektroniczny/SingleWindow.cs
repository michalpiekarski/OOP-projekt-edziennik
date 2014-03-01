using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
{
    using ForWpro = Formularze.Wprowadzanie;
    using ForPrze = Formularze.Przeglądanie;
    public partial class SingleWindow : Form
    {
        private CurrentSubForm currentSubForm = CurrentSubForm.None;
        public SingleWindow()
        {
            InitializeComponent();
        }
        #region Wprowadzanie
        private void UczniowieWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.UczniowieWprowadzanie)
            {
                currentSubForm = CurrentSubForm.UczniowieWprowadzanie;
                this.panel1.Controls.Clear();
                ForWpro.Uczniowie SubForm = new ForWpro.Uczniowie();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void NauczycieleWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.NauczycieleWprowadzanie)
            {
                currentSubForm = CurrentSubForm.NauczycieleWprowadzanie;
                this.panel1.Controls.Clear();
                ForWpro.Nauczyciele SubForm = new ForWpro.Nauczyciele();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void PlanZajęćWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.PlanZajęćWprowadzanie)
            {
                currentSubForm = CurrentSubForm.PlanZajęćWprowadzanie;
                this.panel1.Controls.Clear();
                ForWpro.Plan_zajęć SubForm = new ForWpro.Plan_zajęć();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void KartyOcenWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.KartyOcenWprowadzanie)
            {
                currentSubForm = CurrentSubForm.KartyOcenWprowadzanie;
                this.panel1.Controls.Clear();
                ForWpro.Karty_ocen SubForm = new ForWpro.Karty_ocen();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void KlasyWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.KlasyWprowadzanie)
            {
                currentSubForm = CurrentSubForm.KlasyWprowadzanie;
                this.panel1.Controls.Clear();
                ForWpro.Klasy SubForm = new ForWpro.Klasy();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void PrzedmiotyWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.PrzedmiotyWprowadzanie)
            {
                currentSubForm = CurrentSubForm.PrzedmiotyWprowadzanie;
                this.panel1.Controls.Clear();
                ForWpro.Przedmioty SubForm = new ForWpro.Przedmioty();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void RodzajePracWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.RodzajePracWprowadzanie)
            {
                currentSubForm = CurrentSubForm.RodzajePracWprowadzanie;
                this.panel1.Controls.Clear();
                ForWpro.Rodzaje_prac SubForm = new ForWpro.Rodzaje_prac();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        } 
        #endregion Wprowadzanie
        #region Przeglądanie
        private void UczniowiePrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.UczniowiePrzeglądanie)
            {
                currentSubForm = CurrentSubForm.UczniowiePrzeglądanie;
                this.panel1.Controls.Clear();
                ForPrze.Uczniowie SubForm = new ForPrze.Uczniowie();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void NauczycielePrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.NauczycielePrzeglądanie)
            {
                currentSubForm = CurrentSubForm.NauczycielePrzeglądanie;
                this.panel1.Controls.Clear();
                ForPrze.Nauczyciele SubForm = new ForPrze.Nauczyciele();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void PlanZajęćPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.PlanZajęćPrzeglądanie)
            {
                currentSubForm = CurrentSubForm.PlanZajęćPrzeglądanie;
                this.panel1.Controls.Clear();
                ForPrze.Plan_zajęć SubForm = new ForPrze.Plan_zajęć();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void KartyOcenPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.KartyOcenPrzeglądanie)
            {
                currentSubForm = CurrentSubForm.KartyOcenPrzeglądanie;
                this.panel1.Controls.Clear();
                ForPrze.Karty_ocen SubForm = new ForPrze.Karty_ocen();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void KlasyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.KlasyPrzeglądanie)
            {
                currentSubForm = CurrentSubForm.KlasyPrzeglądanie;
                this.panel1.Controls.Clear();
                ForPrze.Klasy SubForm = new ForPrze.Klasy();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void PrzedmiotyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.PrzedmiotyPrzeglądanie)
            {
                currentSubForm = CurrentSubForm.PrzedmiotyPrzeglądanie;
                this.panel1.Controls.Clear();
                ForPrze.Przedmioty SubForm = new ForPrze.Przedmioty();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        private void RodzajePracPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.RodzajePracPrzeglądanie)
            {
                currentSubForm = CurrentSubForm.RodzajePracPrzeglądanie;
                this.panel1.Controls.Clear();
                ForPrze.Rodzaje_prac SubForm = new ForPrze.Rodzaje_prac();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }
        #endregion Przeglądanie
        private void SetWidth(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    this.Width = 575;
                    this.CenterToScreen();
                    break;
                case 1:
                    this.Width = 1175;
                    this.CenterToScreen();
                    break;
                default:
                    break;
            }
            panel1.Controls.Clear();
        }
    }
}
