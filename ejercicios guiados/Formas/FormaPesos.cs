using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios_guiados.Formas
{
    public partial class FormaPesos : Form
    {
        public FormaPesos()
        {
            InitializeComponent();
        }

        private void FormaPesos_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso;
                double euro;
                double dolar;
                peso = float.Parse(textPeso.Text);
                if (peso > 0)
                {
                    dolar = peso / 16.5 / 2;
                    euro = peso / 18.5 / 2;
                    textdolar.Text = (dolar.ToString());
                    textEuro.Text = (euro.ToString());
                }
                else
                {
                    MessageBox.Show("Error, deberas ingresar valores positivos");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, datos incorrectos");
            }


        }
    }
}
