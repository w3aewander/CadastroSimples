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
            ID = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            dataNascimento = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtEmail = new TextBox();
            lstTabela = new ListBox();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 200);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(347, 31);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 267);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 2;
            label2.Text = "Data Nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(48, 295);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(345, 31);
            dtpDataNascimento.TabIndex = 3;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(53, 459);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(112, 54);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(171, 460);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(106, 54);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Salvar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // Tabela
            // 
            Tabela.AutoSize = true;
            Tabela.Location = new Point(438, 67);
            Tabela.Name = "Tabela";
            Tabela.Size = new Size(61, 25);
            Tabela.TabIndex = 7;
            Tabela.Text = "Tabela";
            // 
            // dgvTabela
            // 
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Columns.AddRange(new DataGridViewColumn[] { ID, nome, dataNascimento, email });
            dgvTabela.Location = new Point(438, 104);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.RowHeadersWidth = 62;
            dgvTabela.Size = new Size(694, 250);
            dgvTabela.TabIndex = 8;
            dgvTabela.CellClick += dgvTabela_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID/Código";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
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
            label1.Location = new Point(49, 360);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 9;
            label1.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(52, 388);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(341, 31);
            txtEmail.TabIndex = 10;
            // 
            // lstTabela
            // 
            lstTabela.FormattingEnabled = true;
            lstTabela.ItemHeight = 25;
            lstTabela.Location = new Point(438, 360);
            lstTabela.MultiColumn = true;
            lstTabela.Name = "lstTabela";
            lstTabela.Size = new Size(694, 154);
            lstTabela.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 168);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 12;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 67);
            label4.Name = "label4";
            label4.Size = new Size(30, 25);
            label4.TabIndex = 13;
            label4.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(46, 98);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(347, 31);
            txtId.TabIndex = 14;
            txtId.Text = "0";
            txtId.TextChanged += txtId_TextChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(293, 464);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 49);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 560);
            Controls.Add(btnExcluir);
            Controls.Add(txtId);
            Controls.Add(label4);
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
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewTextBoxColumn email;
        private TextBox txtId;
        private Button btnExcluir;
    }
}
