namespace CadastroSimples
{
    partial class MainForm
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
            txtNome = new TextBox();
            label2 = new Label();
            dtpDataNascimento = new DateTimePicker();
            btnNovo = new Button();
            btnAdicionar = new Button();
            Tabela = new Label();
            dgvTabela = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            dataNascimento = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtEmail = new TextBox();
            lstTabela = new ListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 74);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(347, 31);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 141);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 2;
            label2.Text = "Data Nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(71, 169);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(345, 31);
            dtpDataNascimento.TabIndex = 3;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(76, 333);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(152, 54);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(252, 333);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(143, 54);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // Tabela
            // 
            Tabela.AutoSize = true;
            Tabela.Location = new Point(556, 35);
            Tabela.Name = "Tabela";
            Tabela.Size = new Size(61, 25);
            Tabela.TabIndex = 7;
            Tabela.Text = "Tabela";
            // 
            // dgvTabela
            // 
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Columns.AddRange(new DataGridViewColumn[] { nome, dataNascimento, email });
            dgvTabela.Location = new Point(438, 74);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.RowHeadersWidth = 62;
            dgvTabela.Size = new Size(555, 185);
            dgvTabela.TabIndex = 8;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 8;
            nome.Name = "nome";
            nome.Width = 150;
            // 
            // dataNascimento
            // 
            dataNascimento.HeaderText = "Data Nascimento";
            dataNascimento.MinimumWidth = 8;
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Width = 150;
            // 
            // email
            // 
            email.HeaderText = "E-Mail";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 234);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 9;
            label1.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 262);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(341, 31);
            txtEmail.TabIndex = 10;
            // 
            // lstTabela
            // 
            lstTabela.FormattingEnabled = true;
            lstTabela.ItemHeight = 25;
            lstTabela.Location = new Point(438, 274);
            lstTabela.MultiColumn = true;
            lstTabela.Name = "lstTabela";
            lstTabela.Size = new Size(555, 154);
            lstTabela.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 42);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 12;
            label3.Text = "Nome";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 457);
            Controls.Add(label3);
            Controls.Add(lstTabela);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(dgvTabela);
            Controls.Add(Tabela);
            Controls.Add(btnAdicionar);
            Controls.Add(btnNovo);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Name = "MainForm";
            Text = "Cadastro Simples";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label label2;
        private DateTimePicker dtpDataNascimento;
        private Button btnNovo;
        private Button btnAdicionar;
        private ListBox listBox1;
        private Label Tabela;
        private DataGridView dgvTabela;
        private Label label1;
        private TextBox txtEmail;
        private ListBox lstTabela;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewTextBoxColumn email;
        private Label label3;
    }
}
