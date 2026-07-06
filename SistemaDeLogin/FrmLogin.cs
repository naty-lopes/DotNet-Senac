namespace SistemaDeLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (nomeUsuario == "admin" && senha == "1234")
            {
                this.Hide();
                new MenuPrincipal().Show();
                this.Show();
            }
            else
            {
                MessageBox.Show($"Usuário ou a senha estão incorretos!", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
