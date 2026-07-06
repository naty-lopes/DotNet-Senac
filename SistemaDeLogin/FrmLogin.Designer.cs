namespace SistemaDeLogin
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            btnenviar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(374, 209);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 54);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(25, 63);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 39);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 118);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(27, 160);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 39);
            txtSenha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 202);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 5;
            label4.Click += label4_Click;
            // 
            // btnenviar
            // 
            btnenviar.Location = new Point(25, 225);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(112, 34);
            btnenviar.TabIndex = 6;
            btnenviar.Text = "Entrar";
            btnenviar.UseVisualStyleBackColor = true;
            btnenviar.Click += btnenviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1121, 576);
            Controls.Add(btnenviar);
            Controls.Add(label4);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtSenha;
        private Label label4;
        private Button btnenviar;
    }
}
