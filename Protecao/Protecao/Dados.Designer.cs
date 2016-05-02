namespace Protecao
{
    partial class Dados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.i_partida_conce = new System.Windows.Forms.TextBox();
            this.Gerar_Grafico1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.i_CC_trifasico_conce = new System.Windows.Forms.TextBox();
            this.i_CC_trifasico_consu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.i_partida_consu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Curva_consu = new System.Windows.Forms.ComboBox();
            this.Curva_conce = new System.Windows.Forms.ComboBox();
            this.tms_conce = new System.Windows.Forms.NumericUpDown();
            this.tms_consu = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tms_conce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tms_consu)).BeginInit();
            this.SuspendLayout();
            // 
            // i_partida_conce
            // 
            this.i_partida_conce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.i_partida_conce.Location = new System.Drawing.Point(123, 80);
            this.i_partida_conce.Name = "i_partida_conce";
            this.i_partida_conce.Size = new System.Drawing.Size(99, 20);
            this.i_partida_conce.TabIndex = 0;
            this.i_partida_conce.Text = "80";
            // 
            // Gerar_Grafico1
            // 
            this.Gerar_Grafico1.Location = new System.Drawing.Point(156, 155);
            this.Gerar_Grafico1.Name = "Gerar_Grafico1";
            this.Gerar_Grafico1.Size = new System.Drawing.Size(186, 23);
            this.Gerar_Grafico1.TabIndex = 1;
            this.Gerar_Grafico1.Text = "Gerar Coordenograma de Fase (51)";
            this.Gerar_Grafico1.UseVisualStyleBackColor = true;
            this.Gerar_Grafico1.Click += new System.EventHandler(this.Gerar_Grafico1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "I_partida_conce";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "I_partida_inst_conce";
            // 
            // i_CC_trifasico_conce
            // 
            this.i_CC_trifasico_conce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.i_CC_trifasico_conce.Location = new System.Drawing.Point(123, 106);
            this.i_CC_trifasico_conce.Name = "i_CC_trifasico_conce";
            this.i_CC_trifasico_conce.Size = new System.Drawing.Size(99, 20);
            this.i_CC_trifasico_conce.TabIndex = 5;
            this.i_CC_trifasico_conce.Text = "2000";
            // 
            // i_CC_trifasico_consu
            // 
            this.i_CC_trifasico_consu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.i_CC_trifasico_consu.Location = new System.Drawing.Point(379, 106);
            this.i_CC_trifasico_consu.Name = "i_CC_trifasico_consu";
            this.i_CC_trifasico_consu.Size = new System.Drawing.Size(99, 20);
            this.i_CC_trifasico_consu.TabIndex = 13;
            this.i_CC_trifasico_consu.Text = "1600";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "I_partida_consu";
            // 
            // i_partida_consu
            // 
            this.i_partida_consu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.i_partida_consu.Location = new System.Drawing.Point(379, 80);
            this.i_partida_consu.Name = "i_partida_consu";
            this.i_partida_consu.Size = new System.Drawing.Size(100, 20);
            this.i_partida_consu.TabIndex = 11;
            this.i_partida_consu.Text = "40";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "TMS_conce";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "TMS_consu";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Curva_conce";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Curva_consu";
            // 
            // Curva_consu
            // 
            this.Curva_consu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Curva_consu.FormattingEnabled = true;
            this.Curva_consu.Items.AddRange(new object[] {
            "NI - IEC",
            "MI - IEC",
            "EI - IEC"});
            this.Curva_consu.Location = new System.Drawing.Point(379, 53);
            this.Curva_consu.Name = "Curva_consu";
            this.Curva_consu.Size = new System.Drawing.Size(100, 21);
            this.Curva_consu.TabIndex = 24;
            this.Curva_consu.Text = "NI - IEC";
            this.Curva_consu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Curva_KeyPress);
            // 
            // Curva_conce
            // 
            this.Curva_conce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Curva_conce.FormattingEnabled = true;
            this.Curva_conce.Items.AddRange(new object[] {
            "NI - IEC",
            "MI - IEC",
            "EI - IEC"});
            this.Curva_conce.Location = new System.Drawing.Point(123, 53);
            this.Curva_conce.Name = "Curva_conce";
            this.Curva_conce.Size = new System.Drawing.Size(100, 21);
            this.Curva_conce.TabIndex = 25;
            this.Curva_conce.Text = "NI - IEC";
            this.Curva_conce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Curva_KeyPress);
            // 
            // tms_conce
            // 
            this.tms_conce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tms_conce.DecimalPlaces = 2;
            this.tms_conce.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tms_conce.Location = new System.Drawing.Point(123, 27);
            this.tms_conce.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tms_conce.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tms_conce.Name = "tms_conce";
            this.tms_conce.Size = new System.Drawing.Size(120, 20);
            this.tms_conce.TabIndex = 26;
            this.tms_conce.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // tms_consu
            // 
            this.tms_consu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tms_consu.DecimalPlaces = 2;
            this.tms_consu.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tms_consu.Location = new System.Drawing.Point(379, 27);
            this.tms_consu.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tms_consu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tms_consu.Name = "tms_consu";
            this.tms_consu.Size = new System.Drawing.Size(120, 20);
            this.tms_consu.TabIndex = 27;
            this.tms_consu.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "I_partida_inst_consu";
            // 
            // Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tms_consu);
            this.Controls.Add(this.tms_conce);
            this.Controls.Add(this.Curva_conce);
            this.Controls.Add(this.Curva_consu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.i_CC_trifasico_consu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.i_partida_consu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.i_CC_trifasico_conce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gerar_Grafico1);
            this.Controls.Add(this.i_partida_conce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados";
            ((System.ComponentModel.ISupportInitialize)(this.tms_conce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tms_consu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox i_partida_conce;
        private System.Windows.Forms.Button Gerar_Grafico1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox i_CC_trifasico_conce;
        private System.Windows.Forms.TextBox i_CC_trifasico_consu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox i_partida_consu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Curva_consu;
        private System.Windows.Forms.ComboBox Curva_conce;
        private System.Windows.Forms.NumericUpDown tms_conce;
        private System.Windows.Forms.NumericUpDown tms_consu;
        private System.Windows.Forms.Label label2;
    }
}