using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto03Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            txtA.Text = "0";
            txtB.Text = "0";
        }

        //Boton Suma
        private void btnSuma_Click(object sender, EventArgs e)
        {
            
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);

                double r = a + b;
                lblResultado.Text = r.ToString();
            }
            catch (Exception error)
            {
                lblResultado.Text = error.Message;
               
            }
        }


        //Boton Resta
        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);

                double r = a - b;
                lblResultado.Text = r.ToString();
            }
            catch (Exception error)
            {
                lblResultado.Text = error.Message;

            }
        }

        //Boton Multiplicación
        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);

                double r = a * b;
                lblResultado.Text = r.ToString();
            }
            catch (Exception error)
            {
                lblResultado.Text = error.Message;

            }
        }


        //Boton division
        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);

                double r = a / b;
                lblResultado.Text = r.ToString();
            }
            catch (Exception error)
            {
                lblResultado.Text = error.Message;

            }
        }


        //Boton Borrar
        private void btclear_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            txtA.Clear();
            txtB.Clear();
        }


        //Boton Cerrar
        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num2,num1,num3;


            try
            {
                num1 = int.Parse(txtA.Text);

                num2 = int.Parse(txtB.Text);

                num3 = num1;

                for (int i = 1; i < num2; i++)
                {
                    num1 = num1 * num3;
                }

                lblResultado.Text = num1.ToString();


            }
            catch (Exception error)
            {
                lblResultado.Text = error.Message;
                
            }
        }
    }
}
