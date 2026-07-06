namespace RefazerCalculadora
{
    public partial class Form1 : Form
    {
        double num1;
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            num1 = 0;
            operacao = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox1.Text);
            operacao = "/";
            textBox1.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            double num2 = Convert.ToDouble(textBox1.Text);

            switch (operacao)
            {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;

                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;

                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;

                case "/":
                    textBox1.Text = (num1 / num2).ToString();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox1.Text);
            operacao = "*";
            textBox1.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox1.Text);
            operacao = "-";
            textBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox1.Text);
            operacao = "+";
            textBox1.Clear();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}

