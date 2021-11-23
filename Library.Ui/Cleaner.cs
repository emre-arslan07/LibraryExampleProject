using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Ui
{
    static class Cleaner
    {
        //static olarak yazılan bir class sayesinde CRUD(CREATE,UPDATE,DELETE) işlemlerinden sonra formun control nesnelerinin temizlenmesi sağlanır
        public static void CleanForm(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    CleanForm(gb.Controls);
                }
                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.SelectedIndex = -1;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.Value = DateTime.Now;
                }
            }

        }
    }
}
