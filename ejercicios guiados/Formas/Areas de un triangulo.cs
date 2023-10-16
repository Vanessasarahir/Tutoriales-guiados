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
    public partial class Areas_de_un_triangulo : Form
    {
        public Areas_de_un_triangulo()
        {
            InitializeComponent();
        }

        private void Areas_de_un_triangulo_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                float baseT = float.Parse(textBase.Text);
                float altura = float.Parse(textAltura.Text);
                float res;
                if ( baseT > 0 && altura > 0)
                {
                    res = (baseT * altura / 2);
                    textArea.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Error, deberas ingresar valores positivos");
                }
            }

            catch (Exception error)
            {
                MessageBox.Show("datos incorrectos");
            }


        }
    }
}
