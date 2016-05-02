using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protecao
{
    public partial class Dados : Form
    {
        public static string rtc_conce;

        public static double TMS_conce;
        public static string curva_conce;
        public static double I_partida_conce;
        public static double I_CC_tri_conce;

        public static double TMS_consu;
        public static string curva_consu;
        public static double I_partida_consu;
        public static double I_CC_tri_consu;


        public static string I_partida_conce_N;
        public static string I_CC_mono_conce;

        public Dados()
        {
            InitializeComponent();
        }

        private void Gerar_Grafico1_Click(object sender, EventArgs e)
        {
            // Dados pro cálculo da 51

            // Concessionária
            Dados.TMS_conce = Convert.ToDouble(tms_conce.Value);
            Dados.curva_conce = Curva_conce.Text;
            Dados.I_partida_conce = Convert.ToDouble(i_partida_conce.Text);
            Dados.I_CC_tri_conce = Convert.ToDouble(i_CC_trifasico_conce.Text);

            // Consumidor
            Dados.TMS_consu = Convert.ToDouble(tms_consu.Value);
            Dados.curva_consu = Curva_consu.Text;
            Dados.I_partida_consu = Convert.ToDouble(i_partida_consu.Text);
            Dados.I_CC_tri_consu = Convert.ToDouble(i_CC_trifasico_consu.Text);

            Grafico51 frm = new Grafico51();
            frm.ShowDialog();
            frm.Close();

        }

        private void Curva_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}