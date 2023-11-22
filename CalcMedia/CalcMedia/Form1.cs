using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMedia
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)// Calcular
        {
            float soma, media, valor;
            soma = 0;

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                }

                media = soma / 3;
                this.Controls["label6"].Text = media.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Limpar
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }

                this.Controls["label6"].Text = "...";

            }
        }
    }
}
