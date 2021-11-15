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
        private bool Haydispositivo;
        private FilterInfoCollection Misdispotiivos;
        private VideoCaptureDevice miwebcam;
        private bool onof = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
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
            if (onof ==false) { 
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

        private void Capturando(object sender,NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
        }
        private void webcam()
        {
            if(miwebcam!=null && miwebcam.IsRunning)
            {
                miwebcam.SignalToStop();
                miwebcam = null;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            webcam();
        }
    }
}
