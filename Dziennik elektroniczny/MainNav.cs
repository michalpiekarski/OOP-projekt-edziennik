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
    public partial class MainNav : Form
    {
        private CurrentSubForm currentSubForm = CurrentSubForm.None;

        public MainNav()
        {
            InitializeComponent();
        }

        private void UczniowieWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.UczniowieWprowadzanie)
            {
                currentSubForm = CurrentSubForm.UczniowieWprowadzanie;
                new Uczniowie().Show();
            }
        }

        private void NauczycieleWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.NauczycieleWprowadzanie)
            {
                currentSubForm = CurrentSubForm.NauczycieleWprowadzanie;
                new Nauczyciele().Show();
            }
        }

        private void PlanZajęćWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.PlanZajęćWprowadzanie)
            {
                currentSubForm = CurrentSubForm.PlanZajęćWprowadzanie;
                new Plan_zajęć().Show();
            }
        }

        private void KartyOcenWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.KartyOcenWprowadzanie)
            {
                currentSubForm = CurrentSubForm.KartyOcenWprowadzanie;
                new Karty_ocen().Show();
            }
        }

        private void KlasyWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.KlasyWprowadzanie)
            {
                currentSubForm = CurrentSubForm.KlasyWprowadzanie;
                new Klasy().Show();
            }
        }

        private void PrzedmiotyWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.PrzedmiotyWprowadzanie)
            {
                currentSubForm = CurrentSubForm.PrzedmiotyWprowadzanie;
                new Przedmioty().Show();
            }
        }

        private void RodzajePracWprowadzanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.RodzajePracWprowadzanie)
            {
                currentSubForm = CurrentSubForm.RodzajePracWprowadzanie;
                new Rodzaje_prac().Show();
            }
        }

        private void UczniowiePrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.UczniowiePrzeglądanie)
            {
                currentSubForm = CurrentSubForm.UczniowiePrzeglądanie;
                new Formularze.Przeglądanie.Kontakty.Uczniowie().Show();
            }
        }

        private void NauczycielePrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.NauczycielePrzeglądanie)
            {
                currentSubForm = CurrentSubForm.NauczycielePrzeglądanie;
                new Formularze.Przeglądanie.Kontakty.Nauczyciele().Show();
            }
        }

        private void PlanZajęćPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.PlanZajęćPrzeglądanie)
            {
                currentSubForm = CurrentSubForm.PlanZajęćPrzeglądanie;
                new Formularze.Przeglądanie.Terminy.Plan_zajęć().Show();
            }
        }

        private void KartyOcenPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.KartyOcenPrzeglądanie)
            {
                currentSubForm = CurrentSubForm.KartyOcenPrzeglądanie;
                new Formularze.Przeglądanie.Oceny.Karty_ocen().Show();
            }
        }

        private void KlasyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.KlasyPrzeglądanie)
            {
                new Formularze.Przeglądanie.Inne.Klasy().Show();
            }
        }

        private void PrzedmiotyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.PrzedmiotyPrzeglądanie)
            {
                new Formularze.Przeglądanie.Inne.Przedmioty().Show();
            }
        }

        private void RodzajePracPrzeglądanieClick(object sender, EventArgs e)
        {
            if (currentSubForm != CurrentSubForm.RodzajePracPrzeglądanie)
            {
                new Formularze.Przeglądanie.Inne.Rodzaje_prac().Show();
            }
        }
    }
}
