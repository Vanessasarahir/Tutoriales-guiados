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
    public partial class FormaCalculadora : Form
    {
        public FormaCalculadora()
        {
            InitializeComponent();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textValor1.Text);
            float valor2 = float.Parse(textValor2.Text);
            float res;
            res = (valor1 + valor2);
            textTotal.Text = res.ToString();
        }
    }
}
