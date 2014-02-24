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
        public Uczniowie uczniowieWprowadzanie;
        public Nauczyciele nauczycieleWprowadzanie;
        public Plan_zajęć planZajęćWprowadzanie;
        public Karty_ocen kartyOcenWprowadzanie;
        public Klasy klasyWprowadzanie;
        public Przedmioty przedmiotyWprowadzanie;
        public Rodzaje_prac rodzajePracWprowadaznie;
        public Formularze.Przeglądanie.Kontakty.Uczniowie uczniowiePrzeglądanie;
        public Formularze.Przeglądanie.Kontakty.Nauczyciele nauczycielePrzeglądanie;
        public Formularze.Przeglądanie.Terminy.Plan_zajęć planZajęćPrzeglądanie;
        public Formularze.Przeglądanie.Oceny.Karty_ocen kartyOcenPrzeglądanie;
        public Formularze.Przeglądanie.Inne.Klasy klasyPrzeglądanie;
        public Formularze.Przeglądanie.Inne.Przedmioty przedmiotyPrzeglądanie;
        public Formularze.Przeglądanie.Inne.Rodzaje_prac rodzajePracPrzeglądanie;

        public MainNav()
        {
            InitializeComponent();
        }

        private void UczniowieWprowadzanieClick(object sender, EventArgs e)
        {
            if (uczniowieWprowadzanie == null)
            {
                uczniowieWprowadzanie = new Uczniowie();
                uczniowieWprowadzanie.Show();
                uczniowieWprowadzanie.parentRef = this;
            }
        }

        private void NauczycieleWprowadzanieClick(object sender, EventArgs e)
        {
            if (nauczycieleWprowadzanie == null)
            {
                nauczycieleWprowadzanie = new Nauczyciele();
                nauczycieleWprowadzanie.Show();
                nauczycieleWprowadzanie.parentRef = this;
            }
        }

        private void PlanZajęćWprowadzanieClick(object sender, EventArgs e)
        {
            if (planZajęćWprowadzanie == null)
            {
                planZajęćWprowadzanie = new Plan_zajęć();
                planZajęćWprowadzanie.Show();
                planZajęćWprowadzanie.parentRef = this;
            }
        }

        private void KartyOcenWprowadzanieClick(object sender, EventArgs e)
        {
            if (kartyOcenWprowadzanie == null)
            {
                kartyOcenWprowadzanie = new Karty_ocen();
                kartyOcenWprowadzanie.Show();
                kartyOcenWprowadzanie.parentRef = this;
            }
        }

        private void KlasyWprowadzanieClick(object sender, EventArgs e)
        {
            if (klasyWprowadzanie == null)
            {
                klasyWprowadzanie = new Klasy();
                klasyWprowadzanie.Show();
                klasyWprowadzanie.parentRef = this;
            }
        }

        private void PrzedmiotyWprowadzanieClick(object sender, EventArgs e)
        {
            if (przedmiotyWprowadzanie == null)
            {
                przedmiotyWprowadzanie = new Przedmioty();
                przedmiotyWprowadzanie.Show();
                przedmiotyWprowadzanie.parentRef = this;
            }
        }

        private void RodzajePracWprowadzanieClick(object sender, EventArgs e)
        {
            if (rodzajePracWprowadaznie == null)
            {
                rodzajePracWprowadaznie = new Rodzaje_prac();
                rodzajePracWprowadaznie.Show();
                rodzajePracWprowadaznie.parentRef = this;
            }
        }

        private void UczniowiePrzeglądanieClick(object sender, EventArgs e)
        {
            if (uczniowiePrzeglądanie == null)
            {
                uczniowiePrzeglądanie = new Formularze.Przeglądanie.Kontakty.Uczniowie();
                uczniowiePrzeglądanie.Show();
                uczniowiePrzeglądanie.parentRef = this;
            }
        }

        private void NauczycielePrzeglądanieClick(object sender, EventArgs e)
        {
            if (nauczycielePrzeglądanie == null)
            {
                nauczycielePrzeglądanie = new Formularze.Przeglądanie.Kontakty.Nauczyciele();
                nauczycielePrzeglądanie.Show();
                nauczycielePrzeglądanie.parentRef = this;
            }
        }

        private void PlanZajęćPrzeglądanieClick(object sender, EventArgs e)
        {
            if (planZajęćPrzeglądanie == null)
            {
                planZajęćPrzeglądanie = new Formularze.Przeglądanie.Terminy.Plan_zajęć();
                planZajęćPrzeglądanie.Show();
                planZajęćPrzeglądanie.parentRef = this;
            }
        }

        private void KartyOcenPrzeglądanieClick(object sender, EventArgs e)
        {
            if (kartyOcenPrzeglądanie == null)
            {
                kartyOcenPrzeglądanie = new Formularze.Przeglądanie.Oceny.Karty_ocen();
                kartyOcenPrzeglądanie.Show();
                kartyOcenPrzeglądanie.parentRef = this;
            }
        }

        private void KlasyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (klasyPrzeglądanie == null)
            {
                klasyPrzeglądanie = new Formularze.Przeglądanie.Inne.Klasy();
                klasyPrzeglądanie.Show();
                klasyPrzeglądanie.parentRef = this;
            }
        }

        private void PrzedmiotyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (przedmiotyPrzeglądanie == null)
            {
                przedmiotyPrzeglądanie = new Formularze.Przeglądanie.Inne.Przedmioty();
                przedmiotyPrzeglądanie.Show();
                przedmiotyPrzeglądanie.parentRef = this;
            }
        }

        private void RodzajePracPrzeglądanieClick(object sender, EventArgs e)
        {
            if (rodzajePracPrzeglądanie == null)
            {
                rodzajePracPrzeglądanie = new Formularze.Przeglądanie.Inne.Rodzaje_prac();
                rodzajePracPrzeglądanie.Show();
                rodzajePracPrzeglądanie.parentRef = this;
            }
        }
    }
}
