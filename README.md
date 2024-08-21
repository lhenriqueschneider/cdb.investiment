Documentação para Execução dos projetos


Projeto de WebApi
Verifique se possui instalado o .NET Framework 4.7.2
•	Certifique-se de que o .NET Framework 4.7.2 está instalado em sua máquina. Você pode baixá-lo em :
https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472.2

Para o projeto em Angular:
1.	Instalar Node.js e npm
•	Baixe e instale o Node.js. A instalação do Node.js inclui o npm (Node Package Manager):
https://nodejs.org/en

2.	Instalar Angular CLI
•	Abra o terminal ou prompt de comando e execute o seguinte comando para instalar a Angular CLI globalmente:
     npm install -g @angular/cli


Agora que está tudo instalado, vamos realizar o Clone do projeto e a execução de cada um deles:

Clonar o Repositório
•	Clone o repositório do projeto para sua máquina local usando o comando:
     git clone https://github.com/lhenriqueschneider/cdb.investiment.git
     

Execução do projeto em Angular:
1.	Navegar até o Diretório do Projeto:
•	No terminal, navegue até o diretório onde você clonou o repositório:
     cd Cdb.Investment.Web
     
2.	Instalar Dependências
•	Execute o seguinte comando para instalar todas as dependências do projeto listadas no arquivo package.json:
     npm install

3.	Executar o Servidor de Desenvolvimento
•	Execute o seguinte comando para iniciar o servidor de desenvolvimento:  
     ng serve
•	O servidor de desenvolvimento estará disponível em http://localhost:4200/ por padrão.

Testando o Projeto
1.	Acessar a Aplicação
•	Abra um navegador web e navegue até http://localhost:4200/ para ver a aplicação em execução.

2.	Executar Testes Unitários
•	Para executar os testes unitários usando Karma, execute o comando:
     ng test

Solução de Problemas
•	Erros de Instalação de Dependências
  •	 Verifique se o Node.js e o npm estão instalados corretamente.
  •	Certifique-se de que você está no diretório correto do projeto.

•	Erros de Execução
  •	Verifique o console do navegador para mensagens de erro.
  •	Certifique-se de que todas as variáveis de ambiente necessárias estão configuradas corretamente.

•	Erros de Teste
  •	Verifique a saída do terminal para detalhes sobre os erros nos testes.
  •	Certifique-se de que todas as dependências de teste estão instaladas.

Seguindo esses passos, você deve ser capaz de configurar e executar o projeto web em Angular com sucesso. Se encontrar problemas, consulte a documentação oficial do Angular e do Node.js para mais detalhes.


Execução do projeto WebApi
1.	Abrir o Projeto no Visual Studio
•	Abra o Visual Studio.
•	Selecione Arquivo > Abrir > Projeto/Solução.
•	Navegue até o diretório onde você clonou o repositório e selecione o arquivo .sln do projeto.

2.	Restaurar Pacotes NuGet
•	No Visual Studio, vá para Ferramentas > Gerenciador de Pacotes NuGet > Gerenciar Pacotes NuGet para a Solução.
•	Clique no botão Restaurar para baixar e instalar todos os pacotes NuGet necessários.

3.	Compilar o Projeto
•	No Visual Studio, selecione Compilar > Compilar Solução ou pressione Ctrl+Shift+B.

4.	Executar o Projeto
•	Defina o projeto de API (Cdb.Investment.Api) como o projeto de inicialização.
•	Pressione F5 ou clique no botão Iniciar para executar o projeto.

Testando a API
1.	Usar o Swagger
•	Acessar a documentação da API navegando até http://localhost:44317/swagger.

Conclusão
Seguindo esses passos, você deve ser capaz de configurar e executar o projeto de API em .NET Framework 4.7.2 com sucesso. 
Se encontrar problemas, consulte a documentação oficial do .NET Framework e do Visual Studio para mais detalhes.


Para que o projeto em Angular possa consultar a WebApi:
•	Com o projeto em Angular em execução, conforme definido nos passos acima, acessar a url http://localhost:4200/
•	Devemos também deixar em execução a WebApi. Para isso, devemos seguir o passo 4 do item Execução do projeto WebApi
•	Caso seja necessário alterar os valores do TB e CDI acessar o arquivos we.config, disponível em Cdb.Investment.Api, e alterar o valor da respectiva chave
•	Se a porta da WebApi for alterada de 44317 para uma outra, deverá ser alterada o valor da variável baseAdress, do arquivo cbd-investment.constants.ts, disponível em Cdb.Investment.Web -> src -> app -> constants 


