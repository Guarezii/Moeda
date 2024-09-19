namespace Programa_diretor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Capturando as informações dos TextBoxes
            string diretor = txbDirecao.Text;
            string produtor = txbProdutor.Text;
            string ator1 = txbAtor1.Text;
            string ator2 = txbAtor2.Text;
            string ator3 = txbAtor3.Text;
            string ator4 = txbAtor4.Text;
            string diretorFotografia = txbFoto.Text;
            string anoLancamento = txbLancamento.Text;
            string duracao = txbDuracao.Text;
            string bilheteira = txbBilheteria.Text;

            // Montando a string com as informações
            string content = $"Diretor: {diretor}; " + "\r\n" +
                             $"Produtor: {produtor}; " + "\r\n" +
                             $"Atores: {ator1}; {ator2}; {ator3}; {ator4}; " + "\r\n" +
                             $"Diretor Fotografia: {diretorFotografia}; " + "\r\n" +
                             $"Ano lançamento: {anoLancamento}; " + "\r\n" +
                             $"Duração: {duracao}; " + "\r\n" +
                             $"Bilheteira: {bilheteira};";

            // Escrevendo no arquivo de texto
            string caminhoArquivo = "filmes.txt"; // Caminho do arquivo
            try
            {
                // Append ao arquivo
                File.AppendAllText(caminhoArquivo, content + Environment.NewLine);
                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message);
            }
        }
    }
}


