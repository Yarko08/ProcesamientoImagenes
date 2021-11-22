using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace ProcesamientoImagenesAhoraSi
{
    public partial class Form1 : Form
    {
        //Variables destinadas ala captura de camara
        private bool Haydispositivo;
        private FilterInfoCollection Misdispotiivos;
        private VideoCaptureDevice miwebcam;
        private bool onof = false;

        //Variables Destinadas a los filtros
        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[,] conv3v3 = new int[3, 3];
        private int[,] conv5v5 = new int[5, 5];
        private int factor=0;
        private int offset=0;
        private int anchoVentana, altoVentana;
        private bool Tomo = false;

        public Form1()
        {
            InitializeComponent();

            //creamos el bitmap resultante del cuadrado
            resultante = new Bitmap(800, 800);

            anchoVentana = 800;
            altoVentana = 600;
        }

        private void Convolucion()
        {
            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;
            Color oColor;
            Color test;
            int sumaR = 0;
            int sumaG = 0;
            int sumaB = 0;
            for (x = 3; x < original.Width - 3; x++)
                for (y = 3; y < original.Height - 3; y++)
                {
                    sumaR = 0;
                    sumaG = 0;
                    sumaB = 0;
                    test = original.GetPixel(x, y);
                    for (a = -1; a < 4; a++)
                        for (b = -1;b<4;b++)
                        {
                            oColor = original.GetPixel(x+a, y+b);

                            sumaR = sumaR + (oColor.R * conv5v5[a + 1, b + 1]);
                            sumaG = sumaG + (oColor.G * conv5v5[a + 1, b + 1]);
                            sumaB = sumaB + (oColor.B * conv5v5[a + 1, b + 1]);
                        }

                    sumaR = (sumaR / factor) + offset;
                    sumaG = (sumaG / factor) + offset;
                    sumaB = (sumaB / factor) + offset;

                    if (sumaR > 255)
                        sumaR = 255;
                    if (sumaR < 0)
                        sumaR = 0;
                    if (sumaG > 255)
                        sumaG = 255;
                    if (sumaG < 0)
                        sumaG = 0;
                    if (sumaB > 255)
                        sumaB = 255;
                    if (sumaB < 0)
                        sumaB = 0;
                    resultante.SetPixel(x, y, Color.FromArgb(sumaR, sumaG, sumaB));
                    test = resultante.GetPixel(x, y);
                }
        }

        private void Convolucion3()
        {
            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;
            Color oColor;
            Color test;
            int sumaR = 0;
            int sumaG = 0;
            int sumaB = 0;
            for (x = 1; x < original.Width - 1; x++)
                for (y = 1; y < original.Height - 1; y++)
                {
                    sumaR = 0;
                    sumaG = 0;
                    sumaB = 0;
                    test = original.GetPixel(x, y);
                    for (a = -1; a < 2; a++)
                        for (b = -1; b < 2; b++)
                        {
                            oColor = original.GetPixel(x + a, y + b);

                            sumaR = sumaR + (oColor.R * conv3v3[a + 1, b + 1]);
                            sumaG = sumaG + (oColor.G * conv3v3[a + 1, b + 1]);
                            sumaB = sumaB + (oColor.B * conv3v3[a + 1, b + 1]);
                        }

                    sumaR = (sumaR / factor) + offset;
                    sumaG = (sumaG / factor) + offset;
                    sumaB = (sumaB / factor) + offset;

                    if (sumaR > 255)
                        sumaR = 255;
                    if (sumaR < 0)
                        sumaR = 0;
                    if (sumaG > 255)
                        sumaG = 255;
                    if (sumaG < 0)
                        sumaG = 0;
                    if (sumaB > 255)
                        sumaB = 255;
                    if (sumaB < 0)
                        sumaB = 0;
                    resultante.SetPixel(x, y, Color.FromArgb(sumaR, sumaG, sumaB));
                    test = resultante.GetPixel(x, y);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDispositivos();

            listBox1.Items.Add("Laplaciano");
            listBox1.Items.Add("Sepia");
            listBox1.Items.Add("Gausianno");
            listBox1.Items.Add("Direccional Arriba");
            listBox1.Items.Add("Detección de bordes");
            listBox1.Items.Add("Negativo");
            Cargando.Visible = false;

        }

        public void CargarDispositivos()
        {
            Misdispotiivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (Misdispotiivos.Count > 0)
            {
                Haydispositivo = true;
                for (int i = 0; i < Misdispotiivos.Count; i++)
                    comboBox1.Items.Add(Misdispotiivos[i].Name.ToString());
                comboBox1.Text = Misdispotiivos[0].ToString();
            }
            else
                Haydispositivo = false;
        }

        private void Camara_Click(object sender, EventArgs e)
        {
            if (onof == false) {
                webcam();
                int i = comboBox1.SelectedIndex;
                string NombreVideo = Misdispotiivos[i].MonikerString;
                miwebcam = new VideoCaptureDevice(NombreVideo);//hjm,g
                miwebcam.NewFrame += new NewFrameEventHandler(Capturando);
                miwebcam.Start();
                onof = true;
            }
            else
            {
                webcam();
                onof = false;

            }
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
        }
        private void webcam()
        {
            if (miwebcam != null && miwebcam.IsRunning)
            {
                miwebcam.SignalToStop();
                miwebcam = null;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            webcam();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoVentana = original.Width;
                altoVentana = original.Height;

                resultante = original;

                this.Invalidate();

                pictureBox1.Image = resultante;
                original = (Bitmap)pictureBox1.Image;
                Tomo = true;

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (resultante != null)
            {
                Graphics g = e.Graphics;

                AutoScrollMinSize = new Size(anchoVentana, altoVentana);

                /*g.DrawImage(resultante, new 
                    Rectangle(
                    this.AutoScrollPosition.X, 
                    this.AutoScrollPosition.Y + 30,
                    anchoVentana, altoVentana)
                    );*/

                g.Dispose();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Tomo == true)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            if (Tomo == true && listBox1.SelectedItem != null)
            {
                int x = 0;
                int y = 0;
                Cargando.Visible = true;
                Aplicar.Enabled = false;
                string Seleccion = listBox1.SelectedItem.ToString();

                resultante = new Bitmap(original.Width, original.Height);
               
                Color oColor = new Color();
                Color rColor = new Color();
                if (Seleccion == "Negativo")
                {
                    for (x = 0; x < original.Width; x++)
                        for (y = 0; y < original.Height; y++)
                        {
                            oColor = original.GetPixel(x, y);

                            rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);

                            resultante.SetPixel(x, y, rColor);

                        }
                }

                if (Seleccion == "Gausianno")
                {
                    /*  conv5v5 = new int[,] {
                        { 1, 4, 7,4,1 },
                        { 4,16, 26,16,4 },
                        { 7, 26, 41,26,7 },
                        { 4,16, 26,16,4  },
                        { 1, 4, 7,4,1  }
                        };*/
                    conv3v3 = new int[,] {
                      { 1, 4, 1 },
                      { 4,8, 4 },
                      { 1, 4, 1 }
                      };
                    factor = 28;
                    offset = 0;

                    Convolucion3();
                }

                if (Seleccion == "Detección de bordes")
                {
                    conv5v5 = new int[,] {
                      {2,4,5,4,1},
                      {4,9,12,9,4},
                      {5,12,15,12,5},
                      {4,9,12,9,4},
                      {2,4,5,4,2}
                      };
                    factor = 159;
                    offset = 0;

                    Convolucion();
                }

                original = resultante;
                Cargando.Visible = false;
                Aplicar.Enabled = true ;
                pictureBox2.Image = resultante;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
