using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public bool IsNumeric(String num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public int Suma(int realA, int realB)
        {
            return realA + realB;
        }

        public int SumaIma(int imaA, int imaB)
        {
            return ((imaA + imaB));
        }

        public int Resta(int realA, int realB)
        {
            return realA - realB;
        }

        public int RestaIma(int realA, int realB)
        {
            return (realA - realB);
        }

        public int Multiplicar(int realA, int realB)
        {
            return realA * realB;
        }

        public int MultiplicarIma(int realA, int imaB, int realC, int imaD)
        {
            int rreal2 = (-(realA * imaD));
            int rimag2 = (imaB * realC);

            return (rreal2 + rimag2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(txt_realA.Text) && !IsNumeric(txt_realB.Text))
            {
                txt_result_real.Text = "Ingrese valores validos";
            } else
            {
                int resultadoReal = Suma(Convert.ToInt32(txt_realA.Text), Convert.ToInt32(txt_realB.Text));
                txt_result_real.Text = Convert.ToString(resultadoReal);
            }

            if (!IsNumeric(txt_imaA.Text) && !IsNumeric(txt_imaB.Text))
            {
                txt_result_ima.Text = "Ingrese valores validos";
            } else
            {
                int resultadoImaginario = Suma(Convert.ToInt32(txt_imaA.Text), Convert.ToInt32(txt_imaB.Text));
                txt_result_ima.Text = Convert.ToString(resultadoImaginario);
            }
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(txt_realA.Text) && !IsNumeric(txt_realB.Text))
            {
                txt_result_real.Text = "Ingrese valores validos";
            }
            else
            {
                int resultadoReal = Resta(Convert.ToInt32(txt_realA.Text), Convert.ToInt32(txt_realB.Text));
                txt_result_real.Text = Convert.ToString(resultadoReal);
            }

            if (!IsNumeric(txt_imaA.Text) && !IsNumeric(txt_imaB.Text))
            {
                txt_result_ima.Text = "Ingrese valores validos";
            }
            else
            {
                int resultadoIma = RestaIma(Convert.ToInt32(txt_realA.Text), Convert.ToInt32(txt_realB.Text));
                txt_result_ima.Text = Convert.ToString(resultadoIma);
            }
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(txt_realA.Text) && !IsNumeric(txt_realB.Text))
            {
                txt_result_real.Text = "Ingrese valores validos";
            }
            else
            {
                int resultadoReal = Multiplicar(Convert.ToInt32(txt_realA.Text), Convert.ToInt32(txt_realB.Text));
                txt_result_real.Text = Convert.ToString(resultadoReal);
            }

            if (!IsNumeric(txt_imaA.Text) && !IsNumeric(txt_imaB.Text))
            {
                txt_result_ima.Text = "Ingrese valores validos";
            }
            else
            {
                int resultadoIma = MultiplicarIma(Convert.ToInt32(txt_realA.Text), Convert.ToInt32(txt_realB.Text), Convert.ToInt32(txt_imaA.Text), Convert.ToInt32(txt_imaB.Text));
                txt_result_ima.Text = Convert.ToString(resultadoIma);
            }
        }
    }
}
