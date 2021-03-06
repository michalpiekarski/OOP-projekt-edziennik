﻿using System;
using System.Data;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze
{
    public class SubForm
    {
        public static void FiltrujTabelę(string filterByText, string filterValueText, ref BindingSource bindingSource, DataTable tabelaDanych)
        {
            if (filterValueText != "" && filterByText != "")
            {
                Type filterColumnType = typeof(void);
                foreach (DataColumn col in tabelaDanych.Columns)
                {
                    if (col.ColumnName == filterByText)
                    {
                        filterColumnType = col.DataType;
                        break;
                    }
                }
                if (filterByText.Contains(" "))
                {
                    filterByText = "[" + filterByText + "]";
                }
                if (filterColumnType.Name == "Int32" || filterColumnType.Name == "Double")
                {
                    filterByText += " = " + int.Parse(filterValueText);
                }
                else if (filterColumnType.Name == "DateTime")
                {
                    // UNDONE: Wymaga podania poprawnej daty. Trzeba bedzie zastosować podstawianie róznego typu pola wprowadzania dla konkretnych typów kolumn przy filtrowaniu
                }
                else if (filterColumnType.Name == "String")
                {
                    filterByText += " like '" + filterValueText + "'";
                }
                bindingSource.Filter = filterByText;
            }
        }
        public static void ResetujFiltr(ref TextBox filterValue, ref ComboBox filterBy, ref BindingSource bindingSource)
        {
            filterValue.Text = "";
            filterBy.SelectedIndex = -1;
            bindingSource.RemoveFilter();
        }
        public static void SygnalizuZamknięcie(ref MainNav main, CurrentSubForm indeks)
        {
            main.currentSubForm[(int)indeks] = false;
        }
    }
}
