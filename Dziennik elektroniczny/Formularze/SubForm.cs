using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik_elektroniczny.Formularze
{
    public class SubForm : Form
    {

        MainNav main;

        public SubForm(MainNav mn)
        {
            main = mn;
        }
        public static void FiltrujTabelę(string filterByText, string filterValueText, ref BindingSource bindingSource, TypedTableBase<DataRow> tabelaDanych) // TODO: Typ TypedTableBase<DataRow> się tutaj nie nadaje
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
            if(filterColumnType == typeof(int) || filterColumnType == typeof(float))
            {
                filterByText += " = " + int.Parse(filterValueText);
            }
            else if (filterColumnType == typeof(DateTime)) // TODO: Sprawdzić czy ten typ jest pooprawny dla dat
            {
            }
            else if (filterColumnType == typeof(string))
            {
                if(filterByText.Contains(" "))
                {
                    filterByText = "[" + filterByText + "]";
                }
                filterByText += " like '" + filterValueText + "'";
            }
            bindingSource.Filter = filterByText;
        }
        public static void ResetujFiltr(ref TextBox filterValue, ref ComboBox filterBy, ref BindingSource bindingSource)
        {
            filterValue.Text = "";
            filterBy.SelectedIndex = -1;
            bindingSource.RemoveFilter();
        }
    }
}
