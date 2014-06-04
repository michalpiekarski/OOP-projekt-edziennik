using System;
using System.Windows.Forms;

namespace Dziennik_elektroniczny
{
    using ForWpro = Formularze.Wprowadzanie;
    using ForPrze = Formularze.Przeglądanie;
    // using ForRap = Formularze.Raportowanie; // TODO Usunąć komentarz po dodaniu podformularzy dla raportowania
    public partial class SingleWindow : Form
    {
        private CurrentSubForm currentSubForm = CurrentSubForm.None;
        public SingleWindow()
        {
            InitializeComponent();
        }
        private void OpenSubForm<T>(CurrentSubForm subFormType) where T : Form, new()
        {
            if (currentSubForm != subFormType)
            {
                currentSubForm = subFormType;
                this.panel1.Controls.Clear();
                T SubForm = new T();
                SubForm.FormBorderStyle = FormBorderStyle.None;
                SubForm.TopLevel = false;
                SubForm.ShowInTaskbar = false;
                SubForm.Show();
                SubForm.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(SubForm);
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
