using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Учёт_товаров
{
    public class SoldProd
    {
        int num1;
        int num2;
        public void ChangeDataGrid(DataGridView dg1, DataGridView dg2)
        {
            if(dg1.Visible == true)
            {
                dg1.Visible = !dg1.Visible;
                dg2.Visible = !dg1.Visible;
            }
            else if(dg2.Visible == true)
            {
                dg2.Visible = !dg2.Visible;
                dg1.Visible = !dg2.Visible;
            }
        }
        public void CellsAdd(DataGridView dg1, DataGridView dg2, string n1, string n2, Label lb3, Label lb4)
        {
            num1 = Convert.ToInt32(n1);
            num2 = Convert.ToInt32(n2);
            if (num1 < Daata.n && num2 <= Convert.ToInt32(dg1[2, num1 - 1].Value))
            {
                lb3.Visible = false;
                lb4.Visible = false;
                dg2.Rows.Add();
                dg2[0, Daata.i].Value = Daata.i + 1;
                dg2[1, Daata.i].Value = dg1[1, num1 - 1].Value;
                dg2[2, Daata.i].Value = n2;
                dg2[3, Daata.i].Value = dg1[3, num1 - 1].Value;
                dg2[4, Daata.i].Value = Convert.ToInt32(dg2[2, Daata.i].Value) * Convert.ToInt32(dg2[3, Daata.i].Value);
                Daata.i++;
                dg1[2, num1 - 1].Value = Convert.ToInt32(dg1[2, num1 - 1].Value) - num2;
                dg1[4, num1 - 1].Value = Convert.ToInt32(dg1[2, num1 - 1].Value) * Convert.ToInt32(dg1[3, num1 - 1].Value);
                if (Convert.ToInt32(dg1[2, num1 - 1].Value) <= 0)
                {
                    for (int nm1 = num1; nm1 < Daata.n - 1; nm1++)
                    {
                        dg1[0, nm1].Value = nm1;
                    }
                    dg1.Rows.RemoveAt(num1 - 1);
                    Daata.n--;
                }             
                dg1.Refresh();
            }
            else if (num1 > Daata.n - 1)
            {
                lb3.Visible = true;
            }
            else if (num2 > Convert.ToInt32(dg1[2, num1 - 1].Value))
            {
                lb4.Visible = true;
            }             
        }
    }
}
