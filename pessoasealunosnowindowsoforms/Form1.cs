namespace pessoasealunosnowindowsoforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arquivo = new OpenFileDialog();
        }
        private void botao_Click(object sender, EventArgs e)
        {
            arquivo.Filter = "Arquivos de Texto|*.txt";
            arquivo.Title = "Selecione um arquivo de texto";

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(arquivo.FileName);
                List<Aluno> alunos = new List<Aluno>();
                List<Pessoa> pessoas = new List<Pessoa>();

                foreach (string line in lines)
                {
                    if (line.StartsWith("Z-"))
                    {
                        string[] dados = line.Split('-');
                        string nome = dados[1];
                        string telefone = dados[2];
                        string cidade = dados[3];
                        string RG = dados[4];
                        string CPF = dados[5];

                        Pessoa pessoa = new Pessoa
                        {
                            Nom = nome,
                            Tel = telefone,
                            Cid = cidade,
                            Rg = RG,
                            Cpf = CPF
                        };

                        pessoas.Add(pessoa);
                    }
                    else if (line.StartsWith("Y-"))
                    {
                        string[] dados = line.Split('-');
                        string matricula = dados[1];
                        string codigoCurso = dados[2];
                        string nomeCurso = dados[3];

                        Aluno aluno = new Aluno
                        {
                            Nom = pessoas[pessoas.Count - 1].Nom,
                            Cpf = pessoas[pessoas.Count - 1].Cpf,
                            Cid = pessoas[pessoas.Count - 1].Cid,
                            Rg = pessoas[pessoas.Count - 1].Rg,
                            Tel = pessoas[pessoas.Count - 1].Tel
                        };

                        aluno.Curso.Add(nomeCurso);
                        alunos.Add(aluno);
                    }
                }
                texto.Text = "Pessoas: " + pessoas.Count + "\nAlunos: " + alunos.Count;
            }
        }
    }
}
