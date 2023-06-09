﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExTestesEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)(13)) //tecla que foi precionada (enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if ((textBox2.Text=="") || (textBox2.TextLength<20))
            {
                MessageBox.Show("Endereço inválido!");
                textBox2.Focus();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text=="")
            {
                MessageBox.Show("E-mail vazio");
                e.Cancel = true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Celular perdeu o foco");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("CPF ganhou o foco");
        }
    }
}
