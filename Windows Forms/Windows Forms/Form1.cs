using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form1 : Form
    {

        public bool _presionado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random _rnd = new Random();
            List<string> _titulo = new List<string>();
            _titulo.Add("Titulo 1.");
            _titulo.Add("Titulo 2.");
            _titulo.Add("Titulo 3.");
            List<string> _texto = new List<string>();
            _texto.Add("Hola Mundo.");
            _texto.Add("Floppa Falopa.");
            _texto.Add("Mundo Hola Falopa.");

            if (_presionado == true)
            {
                DialogResult _mSG = MessageBox.Show($"{_texto[_rnd.Next(0, 3)]}", $"{_titulo[_rnd.Next(0, 3)]}", MessageBoxButtons.OK);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random _rnd = new Random();

            if (_presionado == false)
            {
                button1.Location = new Point(_rnd.Next(0, 348), _rnd.Next(0, 239));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presionado = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point _button1Location = button1.Location;
            Point _button2Location = button2.Location;

            button1.Location = _button2Location;
            button2.Location = _button1Location;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult _mSG = MessageBox.Show("¿Quieres resetear las posiciones?", "Resetear Location.", MessageBoxButtons.YesNo);

            if (_mSG == DialogResult.Yes)
            {
                button1.Location = new Point(347, 184);
                button2.Location = new Point(347, 238);
                // button3.Location = new Point(347, 294);
            }
        }
    }
}
