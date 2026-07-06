namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);

            txtResultado.Text = (valor1 * valor2).ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);

                double soma = valor1 + valor2;

                txtResultado.Text = soma.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);

            txtResultado.Text = (valor1 / valor2).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);

                txtResultado.Text = (valor1 - valor2).ToString();
            
        }
    }
}

