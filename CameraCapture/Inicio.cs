using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveFaceDetection
{
    public partial class Inicio : Form
    {
        public Inicio(String nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Facebook facebook = new Facebook();
            facebook.Show();
        }
    }
}
