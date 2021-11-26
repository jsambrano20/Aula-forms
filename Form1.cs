using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_WinForms
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

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1;
            int valor2;

            valor1 = Convert.ToInt32(txbnome.Text);
            valor2 = Convert.ToInt32(txtnum.Text);

            int resultado = valor1 + valor2;
            lbresultado.Text = "A soma " + resultado;

            if (resultado % 2 == 0)
            {
                btnconfirmar.BackColor = Color.Green;
            }
            else
            {
                btnconfirmar.BackColor = Color.White;

            }
            //MessageBox.Show("SOMA " + resultado);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Seu nome é " + txtnome.Text);


            int idade;
            idade = int.Parse(txtida.Text);
            MessageBox.Show("Sua idade é " + idade);


            if (idade >= 18)
            {
                lbsim.Font = new Font(lbsim.Font, FontStyle.Bold);
                lbnao.Font = new Font(lbnao.Font, FontStyle.Regular);

            }
            else
            {
                lbsim.Font = new Font(lbsim.Font, FontStyle.Regular);
                lbnao.Font = new Font(lbnao.Font, FontStyle.Bold);

            }




        }

        private void bt1_Click(object sender, EventArgs e)
        {
            bt3.Location =new Point(bt3.Location.X -5, bt3.Location.Y ) ;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            bt3.Location = new Point(bt3.Location.X +5, bt3.Location.Y);

        }
    }
}
