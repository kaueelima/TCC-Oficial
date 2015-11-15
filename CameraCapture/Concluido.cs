using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.AudioFormat;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace LiveFaceDetection
{
    public partial class Concluido : Form
    {
        public Concluido(String URL)
        {
            InitializeComponent();



            //Pega a foto do pc e coloca em uma variavel chamada "fotoPerfil"
            Image fotoPerfil = Image.FromFile(URL);

            //Verifica se a foto é nula
            if (fotoPerfil == null)
            {
                MessageBox.Show("Foto não adicionada");
            }
            else
            {
                //se não for, ele seta a imagem da variavel para a pictureBox do programa
                pictureBox1.Image = fotoPerfil;


                //Thread.Sleep(2000);
                //Ver como o delay funciona
            }
        }

          /*  Bitmap img1 = new Bitmap("C:/Users/u14280/Desktop/TCC/Level 4d Face Recognition System - half UNCODED/CameraCapture/bin/Debug/Face_.bmp");
            Bitmap img2 = new Bitmap(URL);

            if (img1.Size != img2.Size)
            {
                Console.Error.WriteLine("Images are of different sizes");
                return;
            }

            float diff = 0;

            //img1.Height
               //img1.Width

            for (int y = 0; y < 260; y++)
            {
                for (int x = 0; x < 270; x++)
                {
                    diff += (float)Math.Abs(img1.GetPixel(x, y).R - img2.GetPixel(x, y).R) / 255;
                    diff += (float)Math.Abs(img1.GetPixel(x, y).G - img2.GetPixel(x, y).G) / 255;
                    diff += (float)Math.Abs(img1.GetPixel(x, y).B - img2.GetPixel(x, y).B) / 255;
                }
            }

            MessageBox.Show("diff: {0} %"+  100 * diff / (img1.Width * img1.Height * 3));
            float dif = 100 * diff / (img1.Width * img1.Height * 3);
            //ARRUMAR

            if (dif <= 6){
 
            MessageBox.Show("É a mesma pessoa");
            }else {

                MessageBox.Show("Não é a mesma pessoa");
            }
        } */
        //SpeechRecognizer speechRecognizer = new SpeechRecognizer();
        private void Concluido_Load(object sender, EventArgs e)
        {
            
            
        }

    }
}
