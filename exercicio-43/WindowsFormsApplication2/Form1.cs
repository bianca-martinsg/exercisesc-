﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Usando o comando "FOR"
            int valorInicial;
            int valorFinal;
            int soma = 0;
            int quantidade = 0;
            int media = 0;

            //Limpar o textArea
            memTodos.Text = "";

            valorInicial = Convert.ToInt32(txtValorInicial.Text);
            valorFinal = Convert.ToInt32(txtValorFinal.Text);

            if (valorInicial > valorFinal)
            {
                MessageBox.Show("O valor inicial deve ser menor que o final", 
                    "Atenção", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                txtValorInicial.Focus();
                return;
            }

            //Calculando a somatória e a quantidade de elementos
            for (int i = valorInicial; i <= valorFinal; i++)
            {
                memTodos.AppendText(Convert.ToString(i) +
                    Environment.NewLine);

                soma += i;
                quantidade++;
            }

            //Só vai calcular a média se houver pelo menos um elemento
            if (quantidade > 0)
            {
                media = soma / quantidade;
            }

            lblMedia.Text = Convert.ToString(media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Usando o comando "WHILE"

            int valorInicial;
            int valorFinal;
            int soma = 0;
            int quantidade = 0;
            int media = 0;

            //Limpar o textArea
            memTodos.Text = "";

            valorInicial = Convert.ToInt32(txtValorInicial.Text);
            valorFinal = Convert.ToInt32(txtValorFinal.Text);

            if (valorInicial > valorFinal)
            {
                MessageBox.Show("O valor inicial deve ser menor que o final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValorInicial.Focus();
                return;
            }

            //Calculando a somatória e a quantidade de elementos
            int i = valorInicial;
            while (i <= valorFinal)
            {
                memTodos.AppendText(Convert.ToString(i) +
                    Environment.NewLine);

                soma += i;
                quantidade++;
                i++;
            }

            //Só vai calcular a média se houver pelo menos um elemento
            if (quantidade > 0)
            {
                media = soma / quantidade;
            }

            lblMedia.Text = Convert.ToString(media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValorInicial.Text = "";
            txtValorFinal.Text = "";
            memTodos.Text = "";
            lblMedia.Text = "0";

            txtValorInicial.Focus();
        }
    }
}
