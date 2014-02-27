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
    public partial class SingleWindow : Form
    {
        private CurrentSubForm currentSubForm = CurrentSubForm.None;
        public SingleWindow()
        {
            InitializeComponent();
        }

        private void UczniowieWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.UczniowieWprowadzanie)
            {
                currentSubForm = CurrentSubForm.UczniowieWprowadzanie;
                this.panel1.Controls.Clear();
                Uczniowie SubForm = new Uczniowie();
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
                Nauczyciele SubForm = new Nauczyciele();
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
                Plan_zajęć SubForm = new Plan_zajęć();
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
                Karty_ocen SubForm = new Karty_ocen();
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
                Klasy SubForm = new Klasy();
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
                Przedmioty SubForm = new Przedmioty();
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
                Rodzaje_prac SubForm = new Rodzaje_prac();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
            }
        }

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

        private void UczniowiePrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.UczniowiePrzeglądanie)
            {
                currentSubForm = CurrentSubForm.UczniowiePrzeglądanie;
                this.panel1.Controls.Clear();
                Formularze.Przeglądanie.Kontakty.Uczniowie SubForm = new Formularze.Przeglądanie.Kontakty.Uczniowie();
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
                Formularze.Przeglądanie.Kontakty.Nauczyciele SubForm = new Formularze.Przeglądanie.Kontakty.Nauczyciele();
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
                Formularze.Przeglądanie.Terminy.Plan_zajęć SubForm = new Formularze.Przeglądanie.Terminy.Plan_zajęć();
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
                Formularze.Przeglądanie.Oceny.Karty_ocen SubForm = new Formularze.Przeglądanie.Oceny.Karty_ocen();
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
                Formularze.Przeglądanie.Inne.Klasy SubForm = new Formularze.Przeglądanie.Inne.Klasy();
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
                Formularze.Przeglądanie.Inne.Przedmioty SubForm = new Formularze.Przeglądanie.Inne.Przedmioty();
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
                Formularze.Przeglądanie.Inne.Rodzaje_prac SubForm = new Formularze.Przeglądanie.Inne.Rodzaje_prac();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm); 
            }
        }

        private void OpenBW(object sender, EventArgs e)
        {
            new Formularze.backgroundWorker().Show();
        }
    }
}
