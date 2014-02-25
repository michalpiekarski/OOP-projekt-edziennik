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
        public bool[] currentSubForm = new bool[20];

        public MainNav()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                currentSubForm[i] = false;
            }
        }

        private void UczniowieWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.UczniowieWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.UczniowieWprowadzanie] = true;
                new Uczniowie(this).Show();
            }
        }

        private void NauczycieleWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.NauczycieleWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.NauczycieleWprowadzanie] = true;
                new Nauczyciele(this).Show();
            }
        }

        private void PlanZajęćWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.PlanZajęćWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.PlanZajęćWprowadzanie] = true;
                new Plan_zajęć(this).Show();
            }
        }

        private void KartyOcenWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.KartyOcenWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.KartyOcenWprowadzanie] = true;
                new Karty_ocen(this).Show();
            }
        }

        private void KlasyWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.KlasyWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.KlasyWprowadzanie] = true;
                new Klasy(this).Show();
            }
        }

        private void PrzedmiotyWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.PrzedmiotyWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.PrzedmiotyWprowadzanie] = true;
                new Przedmioty(this).Show();
            }
        }

        private void RodzajePracWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.RodzajePracWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.RodzajePracWprowadzanie] = true;
                new Rodzaje_prac(this).Show();
            }
        }

        private void UczniowiePrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.UczniowiePrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.UczniowiePrzeglądanie] = true;
                new Formularze.Przeglądanie.Kontakty.Uczniowie(this).Show();
            }
        }

        private void NauczycielePrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.NauczycielePrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.NauczycielePrzeglądanie] = true;
                new Formularze.Przeglądanie.Kontakty.Nauczyciele(this).Show();
            }
        }

        private void PlanZajęćPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.PlanZajęćPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.PlanZajęćPrzeglądanie] = true;
                new Formularze.Przeglądanie.Terminy.Plan_zajęć(this).Show();
            }
        }

        private void KartyOcenPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.KartyOcenPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.KartyOcenPrzeglądanie] = true;
                new Formularze.Przeglądanie.Oceny.Karty_ocen(this).Show();
            }
        }

        private void KlasyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.KlasyPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.KlasyPrzeglądanie] = true;
                new Formularze.Przeglądanie.Inne.Klasy(this).Show();
            }
        }

        private void PrzedmiotyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.PrzedmiotyPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.PrzedmiotyPrzeglądanie] = true;
                new Formularze.Przeglądanie.Inne.Przedmioty(this).Show();
            }
        }

        private void RodzajePracPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.RodzajePracPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.RodzajePracPrzeglądanie] = true;
                new Formularze.Przeglądanie.Inne.Rodzaje_prac(this).Show();
            }
        }
    }
}
