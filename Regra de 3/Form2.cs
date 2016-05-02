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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl2.Text = dateTime.ToString("dddd, HH:mm:ss");

        }

        private void Bfechar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Principal f1 = new Principal();
            f1.Show();
        }

        private void Blimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caso haja alguma dúvida ou problema na calculadora, envie um e-mail para andre.szlima@hotmail.com", "Dúvida?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char virgula = ',';

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !e.KeyChar.Equals(virgula))
            {
                e.Handled = true;
            }
        }

        private void Bcalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) | string.IsNullOrWhiteSpace(textBox2.Text) | string.IsNullOrWhiteSpace(textBox3.Text) | string.IsNullOrWhiteSpace(comboBox1.Text) | string.IsNullOrWhiteSpace(comboBox2.Text) | string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                MessageBox.Show("Pelo menos um dos campos de dados é nulo. Insira o valor correspondente e tente novamente.", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string box1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                string box2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
                string box3 = this.comboBox3.GetItemText(this.comboBox3.SelectedItem);

                double exp1 = 0;
                double exp2 = 0;
                double exp3 = 0;

                double not1 = 0;
                double not2 = 0;
                double not3 = 0;

                double result = 0;
                string notacao = "";

                if (box1 == "mili")
                {
                    exp1 = -3;
                    not1 = Math.Pow(10, exp1);
                }
                else if (box1 == "micro")
                {
                    exp1 = -6;
                    not1 = Math.Pow(10, exp1);
                }
                else if (box1 == "nano")
                {
                    exp1 = -9;
                    not1 = Math.Pow(10, exp1);
                }

                if (box2 == "mili")
                {
                    exp2 = -3;
                    not2 = Math.Pow(10, exp2);
                }
                else if (box2 == "micro")
                {
                    exp2 = -6;
                    not2 = Math.Pow(10, exp2);
                }
                else if (box2 == "nano")
                {
                    exp2 = -9;
                    not2 = Math.Pow(10, exp2);
                }

                if (box3 == "mili")
                {
                    exp3 = -3;
                    not3 = Math.Pow(10, exp3);
                }
                else if (box3 == "micro")
                {
                    exp3 = -6;
                    not3 = Math.Pow(10, exp3);
                }
                else if (box3 == "nano")
                {
                    exp3 = -9;
                    not3 = Math.Pow(10, exp3);
                }

                double txt1 = Convert.ToDouble(textBox1.Text);
                double txt2 = Convert.ToDouble(textBox2.Text);
                double txt3 = Convert.ToDouble(textBox3.Text);

                txt1 = txt1 * not1;
                txt2 = txt2 * not2;
                txt3 = txt3 * not3;

                result = (txt3 * txt2) / (txt1 * not2);

                if (result < 1000)
                {
                    textBox4.Text = Convert.ToString(result);
                    textBox5.Text = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
                }
                else if (result >= 1000)
                {
                    textBox4.Text = Convert.ToString(result/1000);
                    notacao = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
                    if (notacao == "micro")
                    {
                        textBox5.Text = "mili";
                    }
                    else if (notacao == "nano")
                    {
                        textBox5.Text = "micro";
                    }
                    else if (notacao == "mili")
                    {
                        textBox4.Text = Convert.ToString(result);
                        textBox5.Text = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
                    }
                }
               
            }
        }

    }
}
