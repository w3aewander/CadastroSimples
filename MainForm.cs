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
                dgvTabela.Rows.Add(p.Nome, p.DataNascimento.ToString("dd/MM/yyyy"), p.Email);
            }
        }
        private void LoadDataToListBox()        
        {
            lstTabela.Items.Clear();
            foreach (Pessoa p in Cadastro.pessoas)
            {
                lstTabela.Items.Add($"Nome: {p.Nome}, " +
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
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            lstTabela.Items.Clear();
        }
    }
}
