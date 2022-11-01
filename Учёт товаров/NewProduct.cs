using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт_товаров
{
    public class NewProduct
    {
        public void Show(Products fm)
        {
            fm.Show();
        }
        public void Newprod(string tb1, string tb2, string tb3)
        {
            Daata.data1 = tb1;
            Daata.data2 = tb2;
            Daata.data3 = tb3;           
        }
        public void Cleartext(TextBox tb1,TextBox tb2, TextBox tb3)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
        }
        public void Take(DataGridView dat)
        {
            Daata.dat1 = dat;
        }
        public void Zap()
        {   
            Daata.dat1.Rows.Add(Daata.n, Daata.data1, Daata.data2, Convert.ToInt32(Daata.data3), (Convert.ToInt32(Daata.data2)* Convert.ToInt32(Daata.data3)));
            Daata.n++;
        }
        public void Charonly(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        public void Errzap(TextBox tb1, TextBox tb2, TextBox tb3, Label lb, Form fm)
        {
            if (tb1.Text.Length < 1 || tb2.Text.Length < 1 || tb3.Text.Length < 1)
            {
                lb.Visible = true;
            }
            else
            {
                lb.Visible = false;
                Newprod(tb1.Text, tb2.Text, tb3.Text);
                Zap();
                Cleartext(tb1, tb2, tb3);
                fm.Hide();
            }
        }
    }
}
