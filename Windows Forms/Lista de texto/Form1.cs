using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void buttonIzquierda1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count != 0)
            {
                listBox1.Items.Add(listBox2.SelectedItems[0]);
                listBox2.Items.RemoveAt(0);
            }
        }

        private void buttonIzquierda2_Click(object sender, EventArgs e)
        {
            int cantidadEnBox2 = listBox2.Items.Count;
            for (int i = 0; i < cantidadEnBox2; i++)
            {
                listBox1.Items.Add(listBox2.Items[0]);
                listBox2.Items.RemoveAt(0);
            }
        }

        private void buttonDerecha1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count != 0)
            {
                listBox2.Items.Add(listBox1.SelectedItems[0]);
                listBox1.Items.RemoveAt(0);
            }
        }

        private void buttonDerecha2_Click(object sender, EventArgs e)
        {
            int cantidadEnBox2 = listBox1.Items.Count;
            for (int i = 0; i < cantidadEnBox2; i++)
            {
                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.RemoveAt(0);
            }
        }
    }
}
