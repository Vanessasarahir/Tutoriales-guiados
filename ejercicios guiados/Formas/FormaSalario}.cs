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
    public partial class FormaSalario_ : Form
    {
        public FormaSalario_()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            { 
                int salario = int.Parse(textSalario.Text);
                int incremento = int.Parse(textIncremento.Text);
                int total;
                int res;
                if (salario > 0 && incremento > 0)
                {
                    total = ((salario * incremento) / 100);
                    res = total + salario;
                    textTotal.Text = res.ToString();
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
