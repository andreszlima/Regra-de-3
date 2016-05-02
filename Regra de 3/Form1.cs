using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regra_de_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString("dddd, HH:mm:ss");

        }

        private void Bcalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) | string.IsNullOrWhiteSpace(textBox2.Text) | string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Pelo menos um dos campos de dados é nulo. Insira o valor correspondente e tente novamente.", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                double txt1;
                double txt2;
                double txt3;

                double exp1;
                double exp2;
                double exp3;
                double exp4;

                double result;

                txt1 = Convert.ToDouble(textBox1.Text);
                txt2 = Convert.ToDouble(textBox2.Text);
                txt3 = Convert.ToDouble(textBox3.Text);

                exp1 = Convert.ToDouble(numericUpDown1.Value);
                exp2 = Convert.ToDouble(numericUpDown2.Value);
                exp3 = Convert.ToDouble(numericUpDown3.Value);

                exp4 = Convert.ToDouble(numericUpDown4.Value);

                // Começo

                txt1 = txt1 * Math.Pow(10, exp1);
                txt2 = txt2 * Math.Pow(10, exp2);
                txt3 = txt3 * Math.Pow(10, exp3);

                result = (txt3 * txt2) / (txt1 * Math.Pow(10, exp2));

                textBox4.Text = Convert.ToString(result);
                numericUpDown4.Value = numericUpDown2.Value;

                result = (txt3 * txt2) / (txt1 * Math.Pow(10, exp2));

                textBox4.Text = Convert.ToString(result);
                numericUpDown4.Value = numericUpDown2.Value;

            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Clique no botão ''Calcular'' para que o resultado final seja encontrado. Após isso será possível alterar a notação do valor encontrado.", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numericUpDown4.ValueChanged -= numericUpDown4_ValueChanged;
                numericUpDown4.Value = 0;
                numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            }
            else
            {
                
                double txt4;

                txt4 = Convert.ToDouble(textBox4.Text);

                if (Convert.ToInt32(numericUpDown4.Text) < numericUpDown4.Value)
                { /*A seta para cima foi clicada*/
                    txt4 = Convert.ToDouble(textBox4.Text);
                    txt4 = txt4 / 10;
                    textBox4.Text = Convert.ToString(txt4);
                }
                else {/*A seta para baixo foi clicada*/
                    txt4 = Convert.ToDouble(textBox4.Text);
                    txt4 = txt4 * 10;
                    textBox4.Text = Convert.ToString(txt4);
                }
            }
        }

        private void Blimpar_Click(object sender, EventArgs e)
        {
            numericUpDown4.ValueChanged -= numericUpDown4_ValueChanged;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;

            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
        }

        private void Bfechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal f1 = new Principal();
            f1.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char virgula = ',';

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !e.KeyChar.Equals(virgula))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            char virgula = ',';

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !e.KeyChar.Equals(virgula))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            char virgula = ',';

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !e.KeyChar.Equals(virgula))
            {
                e.Handled = true;
            }
        }

        private void Bajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caso haja alguma dúvida ou problema na calculadora, envie um e-mail para andre.szlima@hotmail.com", "Dúvida?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
