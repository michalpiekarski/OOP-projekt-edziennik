using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
{
    using ForWpro = Formularze.Wprowadzanie;
    using ForPrze = Formularze.Przeglądanie;
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
        #region Wprowadzanie
        private void UczniowieWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.UczniowieWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.UczniowieWprowadzanie] = true;
                new ForWpro.Uczniowie(this).Show();
            }
        }
        private void NauczycieleWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.NauczycieleWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.NauczycieleWprowadzanie] = true;
                new ForWpro.Nauczyciele(this).Show();
            }
        }
        private void PlanZajęćWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.PlanZajęćWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.PlanZajęćWprowadzanie] = true;
                new ForWpro.Plan_zajęć(this).Show();
            }
        }
        private void KartyOcenWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.KartyOcenWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.KartyOcenWprowadzanie] = true;
                new ForWpro.Karty_ocen(this).Show();
            }
        }
        private void KlasyWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.KlasyWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.KlasyWprowadzanie] = true;
                new ForWpro.Klasy(this).Show();
            }
        }
        private void PrzedmiotyWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.PrzedmiotyWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.PrzedmiotyWprowadzanie] = true;
                new ForWpro.Przedmioty(this).Show();
            }
        }
        private void RodzajePracWprowadzanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.RodzajePracWprowadzanie])
            {
                currentSubForm[(int)CurrentSubForm.RodzajePracWprowadzanie] = true;
                new ForWpro.Rodzaje_prac(this).Show();
            }
        } 
        #endregion Wprowadzanie
        #region Przeglądanie
        private void UczniowiePrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.UczniowiePrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.UczniowiePrzeglądanie] = true;
                new ForPrze.Uczniowie(this).Show();
            }
        }
        private void NauczycielePrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.NauczycielePrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.NauczycielePrzeglądanie] = true;
                new ForPrze.Nauczyciele(this).Show();
            }
        }
        private void PlanZajęćPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.PlanZajęćPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.PlanZajęćPrzeglądanie] = true;
                new ForPrze.Plan_zajęć(this).Show();
            }
        }
        private void KartyOcenPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.KartyOcenPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.KartyOcenPrzeglądanie] = true;
                new ForPrze.Karty_ocen(this).Show();
            }
        }
        private void KlasyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.KlasyPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.KlasyPrzeglądanie] = true;
                new ForPrze.Klasy(this).Show();
            }
        }
        private void PrzedmiotyPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.PrzedmiotyPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.PrzedmiotyPrzeglądanie] = true;
                new ForPrze.Przedmioty(this).Show();
            }
        }
        private void RodzajePracPrzeglądanieClick(object sender, EventArgs e)
        {
            if (!currentSubForm[(int)CurrentSubForm.RodzajePracPrzeglądanie])
            {
                currentSubForm[(int)CurrentSubForm.RodzajePracPrzeglądanie] = true;
                new ForPrze.Rodzaje_prac(this).Show();
            }
        } 
        #endregion Przeglądanie
        private void DostosujPozycję(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    this.Location = new Point(300, 200);
                    break;
                case 1:
                    this.Location = new Point(100, 200);
                    break;
                default:
                    break;
            }
        }
    }
}
