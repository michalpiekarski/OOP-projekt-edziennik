using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
{
    using ForWpro = Formularze.Wprowadzanie;
    using ForPrze = Formularze.Przeglądanie;
    // using ForRap = Formularze.Raportowanie; // TODO Usunąć komentarz po dodaniu podformularzy dla raportowania
    public partial class MainNav : Form
    {
        public bool[] currentSubForm = new bool[23];
        public MainNav()
        {
            InitializeComponent();
            for (int i = 0; i < currentSubForm.Length; i++)
            {
                currentSubForm[i] = false;
            }
        }
        private void OpenSubForm<T>(CurrentSubForm subFromType) where T : Form
        {
            if (!currentSubForm[(int)subFromType])
            {
                currentSubForm[(int)subFromType] = true;
                T SubForm = Activator.CreateInstance(typeof(T), new[]{this}) as T;
                SubForm.Show();
            }
        }
        #region Wprowadzanie
        private void UczniowieWprowadzanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForWpro.Uczniowie>(CurrentSubForm.UczniowieWprowadzanie);
        }
        private void NauczycieleWprowadzanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForWpro.Nauczyciele>(CurrentSubForm.NauczycieleWprowadzanie);
        }
        private void PlanZajęćWprowadzanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForWpro.Plan_zajęć>(CurrentSubForm.PlanZajęćWprowadzanie);
        }
        private void KartyOcenWprowadzanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForWpro.Karty_ocen>(CurrentSubForm.KartyOcenWprowadzanie);
        }
        private void KlasyWprowadzanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForWpro.Klasy>(CurrentSubForm.KlasyWprowadzanie);
        }
        private void PrzedmiotyWprowadzanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForWpro.Przedmioty>(CurrentSubForm.PrzedmiotyWprowadzanie);
        }
        private void RodzajePracWprowadzanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForWpro.Rodzaje_prac>(CurrentSubForm.RodzajePracWprowadzanie);
        }
        #endregion Wprowadzanie
        #region Przeglądanie
        private void UczniowiePrzeglądanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForPrze.Uczniowie>(CurrentSubForm.UczniowiePrzeglądanie);
        }
        private void NauczycielePrzeglądanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForPrze.Nauczyciele>(CurrentSubForm.NauczycielePrzeglądanie);
        }
        private void PlanZajęćPrzeglądanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForPrze.Plan_zajęć>(CurrentSubForm.PlanZajęćPrzeglądanie);
        }
        private void KartyOcenPrzeglądanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForPrze.Karty_ocen>(CurrentSubForm.KartyOcenPrzeglądanie);
        }
        private void KlasyPrzeglądanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForPrze.Klasy>(CurrentSubForm.KlasyPrzeglądanie);
        }
        private void PrzedmiotyPrzeglądanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForPrze.Przedmioty>(CurrentSubForm.PrzedmiotyPrzeglądanie);
        }
        private void RodzajePracPrzeglądanieClick(object sender, EventArgs e)
        {
            OpenSubForm<ForPrze.Rodzaje_prac>(CurrentSubForm.RodzajePracPrzeglądanie);
        }
        #endregion Przeglądanie
        #region Raportowanie
        // TODO Zaimplementować funkcjonalność dla przycisków w sekcji raportowanie
        #endregion Raportowanie
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
