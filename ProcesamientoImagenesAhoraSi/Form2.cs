using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoImagenesAhoraSi
{
    public partial class Form2 : Form
    {
        private int[] histograma;
        private int mayor;

        public Form2(int[] pHistograma)
        {
            InitializeComponent();
            histograma = pHistograma;
            int n = 0;

            mayor = 0;
            for (n = 0; n < 256; n++)
            {
                if (histograma[n] > mayor)
                    mayor = histograma[n];
            }

            for (n = 0; n < 256; n++)
            {
                histograma[n] = (int)((float)histograma[n] / (float)mayor * 256.0f);
            }
        }

        private void Histograma_Load(object sender, EventArgs e)
        {

        }

        private void Histograma_Paint(object sender, PaintEventArgs e)
        {
            int n = 20;
            int altura = 0;
            Graphics g = e.Graphics;
            Pen plumaH = new Pen(Color.Black);
            Pen plumaEjes = new Pen(Color.Coral);

            g.DrawLine(plumaEjes, 19, 272, 277, 271);
            g.DrawLine(plumaEjes, 19, 270, 19, 14);

            for (n = 0; n < 256; n++)
            {
                g.DrawLine(plumaH, n + 20, 270, n + 20, 270 - histograma[n]);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
