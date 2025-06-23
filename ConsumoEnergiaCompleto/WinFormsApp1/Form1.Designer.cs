namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtBuscaDocumento;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtAnterior;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.Button btnAdicionarConta;
        private System.Windows.Forms.Button btnConsulta;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNome = new System.Windows.Forms.TextBox();
            txtDocumento = new System.Windows.Forms.TextBox();
            btnCadastrar = new System.Windows.Forms.Button();
            txtBuscaDocumento = new System.Windows.Forms.TextBox();
            cmbTipo = new System.Windows.Forms.ComboBox();
            txtAnterior = new System.Windows.Forms.TextBox();
            txtAtual = new System.Windows.Forms.TextBox();
            btnAdicionarConta = new System.Windows.Forms.Button();
            btnConsulta = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(30, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(200, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(30, 93);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(200, 23);
            txtDocumento.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new System.Drawing.Point(30, 122);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(75, 23);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar Consumidor";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtBuscaDocumento
            // 
            txtBuscaDocumento.Location = new System.Drawing.Point(30, 193);
            txtBuscaDocumento.Name = "txtBuscaDocumento";
            txtBuscaDocumento.Size = new System.Drawing.Size(100, 23);
            txtBuscaDocumento.TabIndex = 3;
            // 
            // cmbTipo
            // 
            cmbTipo.Items.AddRange(new object[] { "Residencial", "Comercial" });
            cmbTipo.Location = new System.Drawing.Point(30, 237);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(121, 23);
            cmbTipo.TabIndex = 4;
            // 
            // txtAnterior
            // 
            txtAnterior.Location = new System.Drawing.Point(30, 281);
            txtAnterior.Name = "txtAnterior";
            txtAnterior.Size = new System.Drawing.Size(100, 23);
            txtAnterior.TabIndex = 5;
            // 
            // txtAtual
            // 
            txtAtual.Location = new System.Drawing.Point(30, 325);
            txtAtual.Name = "txtAtual";
            txtAtual.Size = new System.Drawing.Size(100, 23);
            txtAtual.TabIndex = 6;
            // 
            // btnAdicionarConta
            // 
            btnAdicionarConta.Location = new System.Drawing.Point(30, 356);
            btnAdicionarConta.Name = "btnAdicionarConta";
            btnAdicionarConta.Size = new System.Drawing.Size(75, 23);
            btnAdicionarConta.TabIndex = 7;
            btnAdicionarConta.Text = "Adicionar Conta";
            btnAdicionarConta.Click += btnAdicionarConta_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new System.Drawing.Point(111, 356);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new System.Drawing.Size(75, 23);
            btnConsulta.TabIndex = 8;
            btnConsulta.Text = "Consultar Última Conta";
            btnConsulta.Click += btnConsulta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 21);
            label1.TabIndex = 9;
            label1.Text = "Cadastro de Usuário";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(30, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 15);
            label3.TabIndex = 11;
            label3.Text = "Documento (CPF ou CNPJ)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(30, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(274, 21);
            label4.TabIndex = 12;
            label4.Text = "Adição e Consulta de conta de Energia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(30, 175);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(194, 15);
            label5.TabIndex = 13;
            label5.Text = "Documento para busca (CPF/CNPJ)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(30, 219);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(79, 15);
            label6.TabIndex = 14;
            label6.Text = "Tipo da conta";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(29, 263);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(122, 15);
            label7.TabIndex = 15;
            label7.Text = "Leitura anterior (kWh)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(30, 307);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(107, 15);
            label8.TabIndex = 16;
            label8.Text = "Leitura atual (kWh)";
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(400, 400);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtDocumento);
            Controls.Add(btnCadastrar);
            Controls.Add(txtBuscaDocumento);
            Controls.Add(cmbTipo);
            Controls.Add(txtAnterior);
            Controls.Add(txtAtual);
            Controls.Add(btnAdicionarConta);
            Controls.Add(btnConsulta);
            Name = "Form1";
            Text = "Controle de Energia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
