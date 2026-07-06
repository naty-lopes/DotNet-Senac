namespace Calculadora
{
    partial class Form1
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "valor 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(131, 25);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 1;
            label2.Text = "valor 2 ";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(20, 70);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(86, 31);
            txtValor1.TabIndex = 2;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(128, 70);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(93, 31);
            txtValor2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(56, 125);
            button1.Name = "button1";
            button1.Size = new Size(50, 44);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(147, 125);
            button2.Name = "button2";
            button2.Size = new Size(50, 44);
            button2.TabIndex = 5;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(56, 188);
            button3.Name = "button3";
            button3.Size = new Size(50, 40);
            button3.TabIndex = 6;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(144, 182);
            button4.Name = "button4";
            button4.Size = new Size(53, 46);
            button4.TabIndex = 7;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(56, 253);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 8;
            txtResultado.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtResultado;
    }
}
