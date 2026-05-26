namespace WFProj
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
            lblNome = new Label();
            txtNome = new TextBox();
            button1 = new Button();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button2 = new Button();
            txtAdicao = new TextBox();
            label4 = new Label();
            txtSubtracao = new TextBox();
            txtMultiplicacao = new TextBox();
            txtDivisao = new TextBox();
            txtMaior = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMenor = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(104, 122);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Tag = "";
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(104, 140);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite seu nome";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(407, 140);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "E&nviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(104, 213);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(93, 23);
            txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(214, 213);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(93, 23);
            txtN2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 195);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 5;
            label1.Text = "N1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 195);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 7;
            label3.Text = "N2";
            // 
            // button2
            // 
            button2.Location = new Point(348, 213);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "C&alcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtAdicao
            // 
            txtAdicao.Location = new Point(104, 302);
            txtAdicao.Name = "txtAdicao";
            txtAdicao.Size = new Size(59, 23);
            txtAdicao.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 251);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 10;
            label4.Text = "Resultado: ";
            // 
            // txtSubtracao
            // 
            txtSubtracao.Location = new Point(214, 302);
            txtSubtracao.Name = "txtSubtracao";
            txtSubtracao.Size = new Size(59, 23);
            txtSubtracao.TabIndex = 9;
            // 
            // txtMultiplicacao
            // 
            txtMultiplicacao.Location = new Point(104, 360);
            txtMultiplicacao.Name = "txtMultiplicacao";
            txtMultiplicacao.Size = new Size(59, 23);
            txtMultiplicacao.TabIndex = 9;
            // 
            // txtDivisao
            // 
            txtDivisao.Location = new Point(214, 360);
            txtDivisao.Name = "txtDivisao";
            txtDivisao.Size = new Size(59, 23);
            txtDivisao.TabIndex = 9;
            // 
            // txtMaior
            // 
            txtMaior.Location = new Point(104, 418);
            txtMaior.Name = "txtMaior";
            txtMaior.Size = new Size(59, 23);
            txtMaior.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 284);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "Adição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 284);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "Subtração";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 342);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 10;
            label7.Text = "Multiplicação";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(221, 342);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 10;
            label8.Text = "Divisão";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(222, 401);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 10;
            label9.Text = "Menor";
            // 
            // txtMenor
            // 
            txtMenor.Location = new Point(215, 418);
            txtMenor.Name = "txtMenor";
            txtMenor.Size = new Size(59, 23);
            txtMenor.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(113, 400);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 10;
            label10.Text = "Maior";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 802);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMenor);
            Controls.Add(txtMaior);
            Controls.Add(txtDivisao);
            Controls.Add(txtMultiplicacao);
            Controls.Add(txtSubtracao);
            Controls.Add(txtAdicao);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button button1;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label label1;
        private Label label3;
        private Button button2;
        private TextBox txtAdicao;
        private Label label4;
        private TextBox txtSubtracao;
        private TextBox txtMultiplicacao;
        private TextBox txtDivisao;
        private TextBox txtMaior;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtMenor;
        private Label label10;
    }
}
