using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visor_de_imagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox caja;

        private void Form1_Load(object sender, EventArgs e)
        {
            Zoom.Minimum = 1;
            Zoom.Maximum = 6;
            Zoom.SmallChange = 1;
            Zoom.LargeChange = 1;

            this.DoubleBuffered = true;
            caja = new PictureBox();
            caja.Image = visorDeImagenes.Image;
        }

        private void seleccionarImagen_Click(object sender, EventArgs e)
        {
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                visorDeImagenes.Image = Image.FromFile(archivo.FileName);
                caja.Image = visorDeImagenes.Image;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEspejar_Click(object sender, EventArgs e)
        {
            Image imagenRotada = visorDeImagenes.Image;
            imagenRotada.RotateFlip(RotateFlipType.Rotate180FlipY);
            visorDeImagenes.Image = imagenRotada;
            caja.Image = visorDeImagenes.Image;
        }

        private void buttonGirarMenos_Click(object sender, EventArgs e)
        {
            Image imagenGirarMenos = visorDeImagenes.Image;
            imagenGirarMenos.RotateFlip(RotateFlipType.Rotate90FlipXY);
            visorDeImagenes.Image = imagenGirarMenos;
            caja.Image = visorDeImagenes.Image;
        }

        private void buttonGirarMas_Click(object sender, EventArgs e)
        {
            Image imagenGirarMas = visorDeImagenes.Image;
            imagenGirarMas.RotateFlip(RotateFlipType.Rotate270FlipXY);
            visorDeImagenes.Image = imagenGirarMas;
            caja.Image = visorDeImagenes.Image;
        }

        private void buttonZoom_Click(object sender, EventArgs e)
        {

        }

        private void Zoom_Scroll(object sender, EventArgs e)
        {
            if (Zoom.Value != 0)
            {
                visorDeImagenes.Image = zoomImagen(caja.Image, new Size(Zoom.Value, Zoom.Value));
            }
        }

        Image zoomImagen(Image imagen, Size tamaño)
        {
            Bitmap bm = new Bitmap(imagen, Convert.ToInt32(imagen.Width * tamaño.Width), Convert.ToInt32(imagen.Height * tamaño.Height));
            Graphics gpu = Graphics.FromImage(imagen);

            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }
    }
}
