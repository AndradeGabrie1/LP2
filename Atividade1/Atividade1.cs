using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
      
    {
        double raio, altura, volume;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((!double.TryParse(textRaio.Text, out raio)) ||
                (!double.TryParse(textAltura.Text, out altura)))
                {
                MessageBox.Show("Valores inválidos");
            }
            else
            {
                if (altura<=0 || raio<=0)
                {
                    MessageBox.Show("Valores não podem ser <=0");
                }
                else
                {
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    textVolume.Text = volume.ToString("N2");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textRaio.Text, out raio))
            {
                MessageBox.Show("Raio inválido");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
            }
        }
    }
}
