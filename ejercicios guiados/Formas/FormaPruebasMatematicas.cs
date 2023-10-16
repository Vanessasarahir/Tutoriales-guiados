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
    public partial class FormaPruebasMatematicas : Form
    {
        Random randomizer = new Random();
        int suma1;
        int suma2;

        int resta1;
        int resta2;

        
        int multiplicacion1;
        int multiplicacion2;


        int division1;
        int division2;

        int timeLeft;

        public void StartTheQuiz()
        {
            suma1 = randomizer.Next(51);
            suma2 = randomizer.Next(51);


            labelPlusLeft.Text = suma1.ToString();
            labelPlusRight.Text = suma2.ToString();

            sumar.Value = 0;


            resta1 = randomizer.Next(1, 101);
            resta2 = randomizer.Next(1, resta1);
            labelMinusLeft.Text = resta1.ToString();
            labelMinusRight.Text = resta2.ToString();
            restar.Value = 0;

            
            multiplicacion1 = randomizer.Next(2, 11);
            multiplicacion2 = randomizer.Next(2, 11);
            labelTimesLeft.Text = multiplicacion1.ToString();
            labelTimesRight.Text = multiplicacion2.ToString();
            multiplicacion.Value = 0;

            
            division2 = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            division1 = division2 * temporaryQuotient;
            labelDividedLeft.Text = division1.ToString();
            labelDividedRight.Text = division2.ToString();
            division.Value = 0;

            timeLeft = 40;
            labelTime.Text = "40 segundos";
            timer1.Start();
        }


        public FormaPruebasMatematicas()
        {
            InitializeComponent();
        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            buttonEmpezar.Enabled = false;
        }
        private bool CheckTheAnswer()
        {
            if ((suma1 + suma2 == sumar.Value)
                && (resta1 - resta2 == restar.Value)
                && (multiplicacion1 * multiplicacion2 == multiplicacion.Value)
                && (division1 / division2 == division.Value))
                return true;
            else
                return false;
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {

                timer1.Stop();
                MessageBox.Show("Estan correctas tus respuestas!",
                                "Muchas felicidades!");
                buttonEmpezar.Enabled = true;
            }
            else if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;
                labelTime.Text = timeLeft + " segundos";
            }
            else
            {

                timer1.Stop();
                labelTime.Text = "Tiempo terminado!";
                MessageBox.Show("Tiempo finalizado.", "Lo siento!");
                sumar.Value = suma1 + suma2;
                restar.Value = resta1 - resta2;
                multiplicacion.Value = multiplicacion1 * multiplicacion2;
                division.Value = division1 / division2;
                buttonEmpezar.Enabled = true;
            }

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
