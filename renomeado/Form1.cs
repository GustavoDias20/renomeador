namespace renomeado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            var FolderDialog = new FolderBrowserDialog();
            // cria uma janela de procura de arquivos chamada FolderDialog

            DialogResult result = FolderDialog.ShowDialog();
            // abre a janela criada anteriormente 


            if (result == DialogResult.OK)
            // entra no if assim  que o usuario escolher o caminho pelo DialogResult
            {
                String folderPath = FolderDialog.SelectedPath;
                // pega o caminho selecionado e coloca numa variavel folderPath

                if (folderPath != null || folderPath != "")
                // se for diferente de null ou diferente de "", executa o bloco de códigos a baixo
                {
                    txtCaminho.Text = folderPath;
                    // coloca o conteudo da variavel folderPath dentro da textBox txtCaminho

                    txtCaminho.Focus();
                    String[] files = Directory.GetFiles(folderPath!);
                    // crio um array de strings para pegar o nome dos itens dentro do diretorio escolhido
                    // atribuo o diretorio escolhido para o array criado
                    // (lembrar de colocar ! no final da variavel, para garantir que não seja nulo o valor dentro dela)

                    int count = 0;
                    // crio um contador, para exibir ao usuario quantos arquivos tem dentro daquele diretorio

                    foreach (String file in files)
                    {
                        count++;
                        // acrescenta uma unidade para cada loop do foreach
                    }
                    lblArquivos.Text = String.Format("{0} Arquivos Encontrados", count);
                    // apresenta a formatação da lblArquvios junto da contagem dos arquivos
                }
            }
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Continuar?", "Confirmar", MessageBoxButtons.YesNo);
            // crio uma caixa de mensagem perguntando se o usuario quer continuar com o processo

            if (result == DialogResult.Yes && txtNome.Text != null && txtCaminho.Text != null)
            // se a resposta da caixa de mensagens for sim, e a textbox txtNome não estiver vazia, faça este bloco de código
            {
                String nome = txtNome.Text;
                // crio a variavel e atribuo o conteudo da textbox txtNome

                String newFolderPath = Path.Combine(txtCaminho.Text, "alterado");
                // modifico o caminho que foi dado para acrescentar um diretorio chamada "alterado"

                Directory.CreateDirectory(newFolderPath);
                // crio o novo diretorio

                int count = 0;
                // crio um contador para numerar os arquivos 

                String[] files = Directory.GetFiles(txtCaminho.Text!);
                // crio um array de strings e pego o nome dos arquivos dentro do path fornecido pelo usuario

                foreach (String file in files)
                {
                    String nomeAntigo = Path.GetFileName(file);
                    // uso a função GetFileName para colocar na string, lembrando que desta maneira, vem somente o nome do arquivo mesmo

                    String[] itens = nomeAntigo.Split('.');
                    // uso a função Split para separar o nome do arquivo, da extensão (normalmente ".exe" ".pdf" ".img", entre outros tipos de extensão)

                    String nomeNovo = $"{nome} ({count}).{itens[1]}";
                    // crio uma nova variavel e dou o nome antigo, o indice que está sendo renomeado e a extensão de volta para o arquivo
                    if (count == 0)
                    // se estiver no inicio do loop, não terá o indice 
                    {
                        nomeNovo = $"{nome}.{itens[1]}";
                    }
                    File.Move(file, Path.Combine(newFolderPath, nomeNovo));
                    // uso o File.Move para mover o arquivo nomeado para dentro da pasta nova, essa função também cria a pasta, caso ela não exista
                    count++;
                }
                MessageBox.Show("Operação concluida!", "Sucesso", MessageBoxButtons.OK);
            }
        }
    }
}
