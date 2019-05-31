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

                E se eu esquecer de colocar a descrição do commit ???
	                O editor VIM será aberto, entretanto é melhor sair (abortar o commit e realiza-lo novamente com a mensagem)
	                --> :q! (sai do editor);
	
                E se eu me perder e quiser voltar ao estado do commit atual?
	                Primeiro cenário: Descartar todas as modificações, voltando ao estado do commit atual.
	                --> git clean -df
	                --> git checkout -- .

                E se eu quiser desfazer o último commit?
	                Primeiro cenário: Remover o último commit mantando as alterações nos arquivos:
	                --> git reset --soft HEAD~1
	                Segundo cenário: Remover o último commit DESCARTANDO as alterações nos arquivos: (Cuidado!)
	                --> git reset --hard HEAD~1
	
                E se eu quiser somente dar uma olhada em um commit anterior?
	                Importante: é preciso estar com o git status vazio, sem nada para commitar.
	                --> git checkout 00aa00a (usa o código do commit, que pode ser visto com o git log);
	                --> git checkout branch (volta ao último commit da branch (master neste caso));

                -------------------GitHub-------------------------
                1 - Crie um repositório em sua conta no GitHub, neste caso 'Curso - Git'

                Associando um repositório remoto ao seu repositório local

                    1 - Associar nosso repositório local ao repositório remoto, dando o apelido de 'origin' a ele:
                    --> git remote add origin https://github.com/SandroCari/Curso-Git.git
                    2 - Caso queira mudar o repositório remoto:
                    --> git remote set - url origin < nova URL >

                Subindo o repositório local para o github
	                --> git push -u origin master (primeira vez)
	                --> git push (próximas vezes)
                ------------------------------------------------------

                Copiando um repositório com histórico de commits para seu computador
	                --> git clone <URI do repositório>

                Atualizando seu repositório local
	                Quando se esta trabalhando em um projeto em equipe, 
	                sempre antes de iniciar um dia de trabalho é importante deixar seu repositório local 
	                igual ao remoto.
	                --> git pull origin master
            ");
        }
    }
}
