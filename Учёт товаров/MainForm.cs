using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт_товаров
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        NewProduct np =  new NewProduct();
        Products pt = new Products();
        SoldProd sp = new SoldProd();
        SaveData sd = new SaveData();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            np.Show(pt);
            np.Take(dataGridView1);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            sp.ChangeDataGrid(dataGridView1, dataGridView2);
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            sp.CellsAdd(dataGridView1, dataGridView2, textBoxNp.Text, textBoxQp.Text, label3, label4);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            np.Charonly(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            np.Charonly(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sd.sData(dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            sd.lData(dataGridView1);
            sd.UpdN(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sd.sData(dataGridView2);      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sd.lData(dataGridView2);
        }
    }
}
