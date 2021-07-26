using System;
using System.Windows.Forms;

namespace ConversoDeMoedas1
{
    public partial class ConversorDeMoedas : Form
    {
        public ConversorDeMoedas()
        {
            InitializeComponent();
        }

        #region Seleções de bandeiras
        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPaises.Text)
            {
                case "Peso Argentino":

                    pictureBoxPais.BackgroundImage = Properties.Resources.argentina;
                    pictureBoxPais.Visible = true;
                    break;

                case "Euro":

                    pictureBoxPais.BackgroundImage = Properties.Resources.spain;
                    pictureBoxPais.Visible = true;
                    break;

                case "Libra Esterlina":

                    pictureBoxPais.BackgroundImage = Properties.Resources.united;
                    pictureBoxPais.Visible = true;
                    break;

                case "Lira Turca":

                    pictureBoxPais.BackgroundImage = Properties.Resources.turkey;
                    pictureBoxPais.Visible = true;
                    break;

                case "Franco Suiço":

                    pictureBoxPais.BackgroundImage = Properties.Resources.switzerland;
                    pictureBoxPais.Visible = true;
                    break;

                case "Dolar Americano":

                    pictureBoxPais.BackgroundImage = Properties.Resources.united_states;
                    pictureBoxPais.Visible = true;
                    break;

                case "Dolar Canadense":

                    pictureBoxPais.BackgroundImage = Properties.Resources.canada;
                    pictureBoxPais.Visible = true;
                    break;

                case "Dolar Australiano":

                    pictureBoxPais.BackgroundImage = Properties.Resources.austallia;
                    pictureBoxPais.Visible = true;
                    break;

                case "Peso Boliviano":

                    pictureBoxPais.BackgroundImage = Properties.Resources.bolivia;
                    pictureBoxPais.Visible = true;
                    break;

                case "Coroa Sueca":

                    pictureBoxPais.BackgroundImage = Properties.Resources.sweden;
                    pictureBoxPais.Visible = true;
                    break;

                case "Iene japones":

                    pictureBoxPais.BackgroundImage = Properties.Resources.japan;
                    pictureBoxPais.Visible = true;
                    break;

                case "Renminbi":

                    pictureBoxPais.BackgroundImage = Properties.Resources.china;
                    pictureBoxPais.Visible = true;
                    break;

                default:
                    MessageBox.Show("Selecione uma Moeda.");
                    break;
            }
        }

        #endregion

        #region Calculo da conversão do Real para outra moeda.
        private void btnConverter_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtValorReal.Text) && !string.IsNullOrEmpty(cmbPaises.Text))
            {
                double valor;

                switch (cmbPaises.Text)
                {
                    case "Peso Argentino":

                        double pesoArgentino = 0.054;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / pesoArgentino;
                        txtValorConvertido.Text = ($"$:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.argentina;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Euro":

                        double euro = 6.15;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / euro;
                        txtValorConvertido.Text = ($"EUR:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.spain;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Libra Esterlina":

                        double libraEsterlina = 7.05;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / libraEsterlina;
                        txtValorConvertido.Text = ($"$:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.united;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Lira Turca":

                        double liraTruca = 0.59;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / liraTruca;
                        txtValorConvertido.Text = ($"KR:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.turkey;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Franco Suiço":

                        double fracoSuico = 5.56;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / fracoSuico;
                        txtValorConvertido.Text = ($"FR:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.switzerland;
                        pictureBoxPais.Visible = true;

                        MessageBox.Show("Preencha o Campo 'Valor em Real'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;

                    case "Dolar Americano":

                        double dolarAmericano = 5.18;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / dolarAmericano;
                        txtValorConvertido.Text = ($"US$:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.united_states;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Dolar Canadense":

                        double dolarCanadense = 4.16;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / dolarCanadense;
                        txtValorConvertido.Text = ($"C$:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.canada;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Dolar Australiano":

                        double dolarAustraliano = 3.88;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / dolarAustraliano;
                        txtValorConvertido.Text = ($"A$:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.austallia;
                        pictureBoxPais.Visible = true;
                        break;

                    case "Peso Boliviano":

                        double pesoBoliviano = 0.75;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / pesoBoliviano;
                        txtValorConvertido.Text = ($"$:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.bolivia;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Coroa Sueca":

                        double coraoSueca = 0.60;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / coraoSueca;
                        txtValorConvertido.Text = ($"SEK:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.sweden;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Iene japones":

                        double ieneJapones = 0.047;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / ieneJapones;
                        txtValorConvertido.Text = ($"$:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.japan;
                        pictureBoxPais.Visible = true;

                        break;

                    case "Renminbi":

                        double renminbi = 0.80;

                        valor = Convert.ToDouble(txtValorReal.Text);

                        valor = valor / renminbi;
                        txtValorConvertido.Text = ($"$:{Convert.ToString(valor.ToString("f2"))}");

                        pictureBoxPais.BackgroundImage = Properties.Resources.china;
                        pictureBoxPais.Visible = true;

                        break;

                    default:
                        MessageBox.Show("Selecione uma moeda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorReal.Text = string.Empty;
            txtValorConvertido.Text = string.Empty;
            pictureBoxPais.Visible = false;
        }
    }
}

