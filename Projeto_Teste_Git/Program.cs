using System;

namespace Projeto_Teste_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                Resumo sobre Git:
                1 - Criar o projeto;
                2 - Criar o arquivo Git.gitignore (txt e depois gitignore pelo cmd);
                3 - Popular o arquivo Git.gitignore com o recomendável para o visual studio (Google);
                4 - Git Bash na pasta do projeto
                --> git init --> Iniciando novo repositório do Git na pasta;
                5 - Identificando o usuário para o Git:
                --> git config --global user.nome 'Sandro Cari'
                -- > git config--global user.email 'sandrocari98@gmail.com'(Mesmo email do GitHub);

                Verificando o status do repositório:
                --> git status

                vermelho: arquivos não rastreados(untracked);
                verde: arquivos prontos para commit) (stage);

                Salvar uma versão do projeto com o Git:
                --> git add. (Coloca os arquivos vermelhos na área de 'stage');
                OBS: o '.' significa todos os arquivos, entretanto também é possível selecionar apenas os arquivos desejados;
                --> git commit - m 'Descrição do Commit'(Faz o commit em si);

                Verificando os commits existentes:
                --> git log(versão detalhada);
                --> git log--oneline(versão resumida);
            ");
        }
    }
}
