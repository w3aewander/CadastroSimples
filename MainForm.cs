namespace CadastroSimples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnExcluir.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            // Salva os dados do formul�rio
            SaveData();

            // Recarrega os dados na ListBox
            LoadDataToListBox();

            // Recarrega os dados no DataGridView
            LoadDataToGridView();

            // Limpa os controles do formul�rio
            ClearControls();

        }

        private void SaveData()
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome � obrigat�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O campo Email � obrigat�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("O campo Email deve conter um '@'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtId.Text == "0")
            {
                // Atribui um novo Id
                int novoId = Cadastro.pessoas.Count + 1;
                txtId.Text = novoId.ToString();

                Pessoa p = new Pessoa(
                int.Parse(txtId.Text),
                txtNome.Text,
                DateOnly.FromDateTime(dtpDataNascimento.Value),
                txtEmail.Text
                );

                // Adiciona a pessoa no cadastro
                Cadastro.pessoas.Add(p);
            }
            else
            {
                // Atualiza os dados da pessoa existente
                int idExistente = int.Parse(txtId.Text);
                Pessoa p = Cadastro.pessoas.Find(x => x.Id == idExistente);
                if (p != null)
                {
                    p.Nome = txtNome.Text;
                    p.DataNascimento = DateOnly.FromDateTime(dtpDataNascimento.Value);
                    p.Email = txtEmail.Text;
                }

            }


        }

        private void LoadDataToGridView()
        {
            dgvTabela.Rows.Clear();
            foreach (Pessoa p in Cadastro.pessoas)
            {
                dgvTabela.Rows.Add(p.Id, p.Nome, p.DataNascimento.ToString("dd/MM/yyyy"), p.Email);
            }
        }
        private void LoadDataToListBox()
        {
            lstTabela.Items.Clear();
            foreach (Pessoa p in Cadastro.pessoas)
            {
                lstTabela.Items.Add($"Id: {p.Id}, Nome: {p.Nome}, " +
                     $"Data Nascimento: {p.DataNascimento.ToString("dd/MM/yyyy")}, " +
                     $"Email: {p.Email}");
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtNome.Clear();
            txtEmail.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            txtId.Text = "0";
        }

        private void loadDataFromGridView()
        {
            //Aqui recarrega os dados que est�o no DataGridView
            if (dgvTabela.CurrentRow != null)
            {
                txtId.Text = dgvTabela.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvTabela.CurrentRow.Cells[1].Value.ToString();
                dtpDataNascimento.Value = DateTime.Parse(dgvTabela.CurrentRow.Cells[2].Value.ToString());
                txtEmail.Text = dgvTabela.CurrentRow.Cells[3].Value.ToString();
            }
            //Se a linha atual for nula, n�o faz nada
            if (dgvTabela.CurrentRow == null)
            {
                return;
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lstTabela.Items.Clear();
        }

        private void dgvTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataFromGridView();
        }

        private void DeleteData()
        {

            //Confirmar se deseja realmente excluir
            if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }   

            if (txtId.Text == "0")
            {
                MessageBox.Show("Nenhum registro selecionado para exclus�o.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idToDelete = int.Parse(txtId.Text);
            Pessoa p = Cadastro.pessoas.Find(x => x.Id == idToDelete);
            if (p != null)
            {
                Cadastro.pessoas.Remove(p);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadDataToGridView();
            LoadDataToListBox();
            ClearControls();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            btnExcluir.Enabled = txtId.Text != "0";
        }
    }
}
