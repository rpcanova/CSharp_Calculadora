namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperador.Text = "";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            lblOperador.Text = "+";
            txtResultado.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            lblOperador.Text = "-";
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            lblOperador.Text = "x";
            txtResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            lblOperador.Text = "÷";
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            lblOperador.Text = "=";
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }

            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
                btnZero.PerformClick();

            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                btnUm.PerformClick();

            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                btnDois.PerformClick();

            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
                btnTres.PerformClick();

            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
                btnQuatro.PerformClick();

            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
                btnCinco.PerformClick();

            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
                btnSeis.PerformClick();

            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
                btnSete.PerformClick();

            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
                btnOito.PerformClick();

            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
                btnNove.PerformClick();

            if (e.KeyCode == Keys.Add)
                btnSoma.PerformClick();

            if (e.KeyCode == Keys.Subtract)
                btnSubtracao.PerformClick();

            if (e.KeyCode == Keys.Multiply)
                btnMultiplicacao.PerformClick();

            if (e.KeyCode == Keys.Divide)
                btnDivisao.PerformClick();

            if (e.KeyCode == Keys.Enter)
                btnIgual.PerformClick();

        }
    }
}
