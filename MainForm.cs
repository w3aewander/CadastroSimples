namespace CadastroSimples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            // Salva os dados do formulário
            SaveData();

            // Recarrega os dados na ListBox
            LoadDataToListBox();

            // Recarrega os dados no DataGridView
            LoadDataToGridView();

            // Limpa os controles do formulário
            ClearControls();

        }

        private void SaveData()
        {

            Pessoa p = new Pessoa(
            int.Parse(txtId.Text),
            txtNome.Text,
            DateOnly.FromDateTime(dtpDataNascimento.Value),
            txtEmail.Text
            );

            // Adiciona a pessoa no cadastro
            Cadastro.pessoas.Add(p);

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
            //Aqui recarrega os dados que estão no DataGridView
            if (dgvTabela.CurrentRow != null)
            {
                txtId.Text = dgvTabela.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvTabela.CurrentRow.Cells[1].Value.ToString();
                dtpDataNascimento.Value = DateTime.Parse(dgvTabela.CurrentRow.Cells[2].Value.ToString());
                txtEmail.Text = dgvTabela.CurrentRow.Cells[3].Value.ToString();
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
    }
}
