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
    public partial class FormaLmp : Form
    {
        public FormaLmp()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int lpm;
                int edad;
                edad = int.Parse(textEdad.Text);
                int calcu;
                if (edad >0 )
                {
                    lpm = 220;
                    calcu = lpm - edad;
                    textLpm.Text = calcu.ToString();
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

        private void FormaLmp_Load(object sender, EventArgs e)
        {

        }
    }
}
