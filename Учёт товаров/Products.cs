using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт_товаров
{
    public partial class Products : Form
    {
        NewProduct np = new NewProduct();
        public Products()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            np.Errzap(textBoxN, textBoxQ, textBoxP, label4, this);
        }

        private void textBoxQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            np.Charonly(e);
        }

        private void textBoxP_KeyPress(object sender, KeyPressEventArgs e)
        {
            np.Charonly(e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
