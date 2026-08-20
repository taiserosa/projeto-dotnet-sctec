# 🚗 AutoCheck: Sistema de Vistoria Veicular

O AutoCheck: Sistema de Vistoria Veicular foi desenvolvido como um projeto para pôr em prática os conceitos aprendidos no Módulo 1 do curso de Desenvolvimento Back-end .NET do Programa SCTEC.

Nessa fase do curso, aprendi desde a base da linguagem de programação C#, como tipos primitivos (int, string, double) até listas, estruturas de decisão e repetição e programação orientada a objetos (POO), colocando em prática seus pilares: abstração, herança, encapsulamento e polimorfismo.

---

## 🔎 O que o sistema faz e para que serve?

O sistema visa verificar se um veículo (carro, moto ou caminhão) está em boas condições para que uma concessionária, locadora de veículos ou seguradora se certifiquem do estado do veículo antes de fecharem negócio.

No primeiro momento, o usuário deverá digitar:

* 1 -> Realizar uma vistoria
* 2 -> Ver relatório
* 0 -> Sair

🛠️ Realizando uma vistoria

Se a opção 1 for escolhida, o programa pede que o usuário escolha um dentre os três tipos de veículos possíveis, preencha seus atributos (marca, modelo, ano, quilometragem, dentre outros específicos de cada veículo) e, após isso, informe "Bom", "Regular" ou "Ruim" para cada um dos itens a serem inspecionados, como:

Nível de Óleo do Motor
Estado da Bateria
Documentação Regularizada

Após isso, será possível escolher um dos três itens do menu inicial novamente.

📋 Visualizando o relatório

Se a opção 2 for escolhida e houver um ou mais veículos já vistoriados, um relatório detalhado será exibido no console. Caso contrário, uma mensagem informando que nenhum veículo foi vistoriado até o momento será exibida.

Esse relatório contém todos os atributos preenchidos, bem como os itens inspecionados e suas respectivas pontuações, que são definidas com base nas entradas "Bom", "Regular" ou "Ruim".

Além disso, são exibidos também:

Pontuação total atingida;
Percentual de aprovação;
Classificação final;
Relatório de manutenção e recomendações da oficina para os itens classificados como Ruim ou Regular.

Após isso, será possível escolher um dos três itens do menu inicial novamente.

🚪 Encerrando o sistema

Se a opção 0 for escolhida, será exibida uma mensagem de despedida e o programa será encerrado imediatamente.

---

## 🖥️ Aplicação em funcionamento

A aplicação funciona diretamente pelo terminal, permitindo realizar as vistorias, consultar os relatórios e validar as entradas informadas pelo usuário.

Exemplo de relatório das vistorias da aplicação:

![Imagem do terminal com o relatório de vistorias feitas](/img/menu-relatorio-autoCheck.png)

---

## ⚙️ Como executá-lo, passo a passo, do zero?

Este projeto poderá ser executado por qualquer pessoa, contanto que siga os seguintes passos:

Faça o download do projeto;
Instale o .NET SDK;
Abra a pasta do projeto no Visual Studio Code ou no editor de código da sua preferência;
Abra o terminal, digite cd src e dê Enter. Depois, digite cd .\AutoCheck.ConsoleApp\ e dê Enter novamente;
Então, digite dotnet run e o programa irá rodar.

---

## 🧮 Qual regra de cálculo da compatibilidade eu adotei e por quê?

A regra de cálculo utilizada nessa aplicação para definir o percentual de aprovação foi a seguinte:

(pontuação obtida / pontuação máxima possível) × 100

A pontuação máxima possível é feita multiplicando o total de itens por 10, já que a maior pontuação que um item pode receber é 10 pontos.

Esse cálculo expressa uma pontuação justa, se baseando no total de itens inspecionados de cada veículo, na pontuação máxima que seria possível obter e na pontuação obtida.

---

## 📚 Qual critério eu usei para priorizar as habilidades na recomendação de estudo?

No início, foi um pouco difícil priorizar o que fazer primeiro, mas aos poucos consegui pegar o ritmo.

Comecei montando a estrutura de pastas e arquivos do projeto, depois criei a classe Veiculo, com seus respectivos atributos e métodos, e em seguida as classes filhas herdando os atributos e métodos de Veiculo, mas também com seus próprios.

Depois veio a criação de ItemVistoria, do fluxo do menu principal na Program, dos métodos de controle do fluxo de vistoria em MotorVistoria, sempre seguindo os requisitos do projeto.

Fiz vários testes durante o desenvolvimento e, ao final, também.

---

## 💻 Quais conceitos do Módulo 01 do curso eu apliquei e onde?

Aprendi diversas coisas no Módulo 1 do curso e tentei aplicar o máximo delas nesse sistema.

POO foi a base do sistema, já que ele é inteiramente dividido em classes que possuem seus atributos e métodos, além de herança (classes Carro, Moto e Caminhao são filhas da classe Veiculo) e polimorfismo (classes filhas sobrescrevem (override) métodos da classe pai).

Algo que utilizei muito nessa aplicação também foram as estruturas de repetição, por exemplo, o do while, que controla o fluxo do menu, e o foreach, para percorrer listas.

Além disso, usei diversas vezes if, else if e else para decidir qual caminho seguir em relação à resposta do usuário inserida no terminal, entre outras decisões.

---

## 🌐 O que é a arquitetura cliente-servidor e como ela aparece no meu projeto?

A arquitetura cliente-servidor se baseia em requests (pedidos) e responses (respostas).

Funciona da seguinte forma: o cliente faz um pedido para o servidor, por exemplo, uma busca por algo específico, e o servidor buscará uma resposta para esse pedido e enviará novamente para o cliente (usuário).

Essa arquitetura não se faz presente no meu projeto, já que essa é uma aplicação onde o usuário informa dados pedidos por meio do terminal e, baseado nisso, a aplicação processa esse input e dá uma resposta relacionada.

A arquitetura cliente-servidor existe em aplicações web ou que interagem com APIs, por exemplo, mas não é o caso dessa aplicação.

---

## 🎥 Link do vídeo de apresentação

🔗 [Vídeo de apresentação do AutoCheck](https://drive.google.com/file/d/1aKAD56j2PQQEajhVRlpAy7qSOShTI7yL/view?usp=sharing)

---

## 🧰 Tecnologias utilizadas
* C#
* .NET
* Visual Studio Code
* Git
* GitHub

---

## Desenvolvido como projeto do Módulo 1 - Desenvolvimento Back-end .NET | Programa SCTEC