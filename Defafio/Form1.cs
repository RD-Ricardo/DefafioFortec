using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i, j;
        int[,] matrizA = new int [4,4];
        int[,] matrizB = new int [4,4];
        int[,] soma = new int[4, 4];
     
        private void button3_Click(object sender, EventArgs e)
        {

           for(i = 0; i <= 2; i++)
            {
                for (j= 0; j <= 2;j++)
                {
                    soma[i, j] = matrizA[i,j] + matrizB[i,j];
                    listBox3.Items.Add(soma[i, j]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (i <= 2)
            {
                if (j <=2)
                {
                    matrizA[i, j] = int.Parse(textBox1.Text);
                    listBox1.Items.Add(matrizA[i, j]);
                    j++;
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else {j = 0; i++;}
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("A matriz já foi completa", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Information);
                i = 0;
                j = 0;
            }   
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (i <= 2)
            {
                if (j <= 2)
                {
                    matrizB[i, j] = int.Parse(textBox2.Text);
                    listBox2.Items.Add(matrizB[i, j]);
                    j++;
                    textBox2.Clear();
                    textBox2.Focus();
                }
                else{ j = 0; i++; }
            }
            else
            {
                textBox2.Clear();
                MessageBox.Show("A matriz já foi completa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                i = 0;
                j = 0;
            }
        }
    }
}
