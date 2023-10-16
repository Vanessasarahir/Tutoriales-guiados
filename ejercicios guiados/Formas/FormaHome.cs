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
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuRegistroUsuario_Click(object sender, EventArgs e)
        {
            RegistroUsuario Usuario = new RegistroUsuario();
            Usuario.Show();
        }

        private void menuCalculadora_Click(object sender, EventArgs e)
        {
            FormaCalculadora Calcu = new FormaCalculadora();
            Calcu.Show();
        }

        private void areaDeUnTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Areas_de_un_triangulo Area = new Areas_de_un_triangulo();
            Area.Show();
        }

        private void pesosMexicanosADolaresYEurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPesos Pesos = new FormaPesos();
            Pesos.Show();
        }

        private void lpmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaLmp Lmp = new FormaLmp();
            Lmp.Show();
        }

        private void incrementoDeSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaSalario_ Salario = new FormaSalario_();
            Salario.Show();
        }

        private void ecuacionCuadraticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEcuacion Ecuacion = new FormaEcuacion();
            Ecuacion.Show();
        }

        private void visualizadosDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaVisualizadorDeImagenes Imagenes = new FormaVisualizadorDeImagenes();
            Imagenes.Show();
        }

        private void pruebasMatematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPruebasMatematicas PruebasMatematicas = new FormaPruebasMatematicas();
            PruebasMatematicas.Show();
        }
    }
}
