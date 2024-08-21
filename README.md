Documenta��o para Execu��o dos projetos


Projeto de WebApi
Verifique se possui instalado o .NET Framework 4.7.2
�	Certifique-se de que o .NET Framework 4.7.2 est� instalado em sua m�quina. Voc� pode baix�-lo em :
https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472.2

Para o projeto em Angular:
1.	Instalar Node.js e npm
�	Baixe e instale o Node.js. A instala��o do Node.js inclui o npm (Node Package Manager):
https://nodejs.org/en

2.	Instalar Angular CLI
�	Abra o terminal ou prompt de comando e execute o seguinte comando para instalar a Angular CLI globalmente:
     npm install -g @angular/cli


Agora que est� tudo instalado, vamos realizar o Clone do projeto e a execu��o de cada um deles:

Clonar o Reposit�rio
�	Clone o reposit�rio do projeto para sua m�quina local usando o comando:
     git clone https://github.com/lhenriqueschneider/cdb.investiment.git
     

Execu��o do projeto em Angular:
1.	Navegar at� o Diret�rio do Projeto:
�	No terminal, navegue at� o diret�rio onde voc� clonou o reposit�rio:
     cd Cdb.Investment.Web
     
2.	Instalar Depend�ncias
�	Execute o seguinte comando para instalar todas as depend�ncias do projeto listadas no arquivo package.json:
     npm install

3.	Executar o Servidor de Desenvolvimento
�	Execute o seguinte comando para iniciar o servidor de desenvolvimento:  
     ng serve
�	O servidor de desenvolvimento estar� dispon�vel em http://localhost:4200/ por padr�o.

Testando o Projeto
1.	Acessar a Aplica��o
�	Abra um navegador web e navegue at� http://localhost:4200/ para ver a aplica��o em execu��o.

2.	Executar Testes Unit�rios
�	Para executar os testes unit�rios usando Karma, execute o comando:
     ng test

Solu��o de Problemas
�	Erros de Instala��o de Depend�ncias
  �	 Verifique se o Node.js e o npm est�o instalados corretamente.
  �	Certifique-se de que voc� est� no diret�rio correto do projeto.

�	Erros de Execu��o
  �	Verifique o console do navegador para mensagens de erro.
  �	Certifique-se de que todas as vari�veis de ambiente necess�rias est�o configuradas corretamente.

�	Erros de Teste
  �	Verifique a sa�da do terminal para detalhes sobre os erros nos testes.
  �	Certifique-se de que todas as depend�ncias de teste est�o instaladas.

Seguindo esses passos, voc� deve ser capaz de configurar e executar o projeto web em Angular com sucesso. Se encontrar problemas, consulte a documenta��o oficial do Angular e do Node.js para mais detalhes.


Execu��o do projeto WebApi
1.	Abrir o Projeto no Visual Studio
�	Abra o Visual Studio.
�	Selecione Arquivo > Abrir > Projeto/Solu��o.
�	Navegue at� o diret�rio onde voc� clonou o reposit�rio e selecione o arquivo .sln do projeto.

2.	Restaurar Pacotes NuGet
�	No Visual Studio, v� para Ferramentas > Gerenciador de Pacotes NuGet > Gerenciar Pacotes NuGet para a Solu��o.
�	Clique no bot�o Restaurar para baixar e instalar todos os pacotes NuGet necess�rios.

3.	Compilar o Projeto
�	No Visual Studio, selecione Compilar > Compilar Solu��o ou pressione Ctrl+Shift+B.

4.	Executar o Projeto
�	Defina o projeto de API (Cdb.Investment.Api) como o projeto de inicializa��o.
�	Pressione F5 ou clique no bot�o Iniciar para executar o projeto.

Testando a API
1.	Usar o Swagger
�	Acessar a documenta��o da API navegando at� http://localhost:44317/swagger.

Conclus�o
Seguindo esses passos, voc� deve ser capaz de configurar e executar o projeto de API em .NET Framework 4.7.2 com sucesso. 
Se encontrar problemas, consulte a documenta��o oficial do .NET Framework e do Visual Studio para mais detalhes.


Para que o projeto em Angular possa consultar a WebApi:
�	Com o projeto em Angular em execu��o, conforme definido nos passos acima, acessar a url http://localhost:4200/
�	Devemos tamb�m deixar em execu��o a WebApi. Para isso, devemos seguir o passo 4 do item Execu��o do projeto WebApi
�	Caso seja necess�rio alterar os valores do TB e CDI acessar o arquivos we.config, dispon�vel em Cdb.Investment.Api, e alterar o valor da respectiva chave
�	Se a porta da WebApi for alterada de 44317 para uma outra, dever� ser alterada o valor da vari�vel baseAdress, do arquivo cbd-investment.constants.ts, dispon�vel em Cdb.Investment.Web -> src -> app -> constants 


