
namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            lblOperador = new Label();
            btnZero = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnIgual = new Button();
            btnPonto = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Font = new Font("DS-Digital", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.Black;
            txtResultado.Location = new Point(36, 25);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(274, 37);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOperador
            // 
            lblOperador.BackColor = Color.White;
            lblOperador.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOperador.ForeColor = Color.Black;
            lblOperador.Location = new Point(38, 27);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(37, 34);
            lblOperador.TabIndex = 1;
            lblOperador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZero.ForeColor = Color.Black;
            btnZero.Location = new Point(106, 361);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(64, 62);
            btnZero.TabIndex = 2;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUm.Location = new Point(36, 293);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(64, 62);
            btnUm.TabIndex = 3;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDois.Location = new Point(106, 293);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(64, 62);
            btnDois.TabIndex = 4;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTres.Location = new Point(176, 293);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(64, 62);
            btnTres.TabIndex = 5;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuatro.Location = new Point(36, 225);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(64, 62);
            btnQuatro.TabIndex = 6;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(106, 225);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(64, 62);
            btnCinco.TabIndex = 7;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(176, 225);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(64, 62);
            btnSeis.TabIndex = 8;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSete.Location = new Point(36, 157);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(64, 62);
            btnSete.TabIndex = 9;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOito.Location = new Point(106, 157);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(64, 62);
            btnOito.TabIndex = 10;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNove.Location = new Point(176, 157);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(64, 62);
            btnNove.TabIndex = 11;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(176, 361);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(64, 62);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnPonto
            // 
            btnPonto.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPonto.Location = new Point(36, 361);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(64, 62);
            btnPonto.TabIndex = 13;
            btnPonto.Text = ",";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(246, 361);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(64, 62);
            btnSoma.TabIndex = 14;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtracao.Location = new Point(246, 293);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(64, 62);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicacao.Location = new Point(246, 225);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(64, 62);
            btnMultiplicacao.TabIndex = 16;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivisao.Location = new Point(246, 157);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(64, 62);
            btnDivisao.TabIndex = 17;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(246, 101);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(64, 50);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(343, 450);
            Controls.Add(lblOperador);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btnPonto);
            Controls.Add(btnIgual);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnZero);
            Controls.Add(txtResultado);
            ForeColor = Color.Black;
            KeyPreview = true;
            Name = "Calculadora";
            Text = "Calculadora";
            KeyDown += Calculadora_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Label lblOperador;
        private Button btnZero;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnIgual;
        private Button btnPonto;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnLimpar;
    }
}
