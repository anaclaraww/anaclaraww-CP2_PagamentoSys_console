1. Objetivo
Desenvolver uma aplicação console em C# que simule um sistema de pagamentos. O sistema deve permitir a escolha entre Pagamento com Cartão ou Pagamento com Boleto, coletar os dados necessários, processar a operação e exibir um resumo.


2. Requisitos Funcionais
Fluxo de Navegação
Menu Principal: Ao iniciar, a aplicação deve exibir um menu utilizando obrigatoriamente uma classe estática: Menu.ExibirMenu().

Opções do Menu:

Processar Pagamento com Cartão

Processar Pagamento com Boleto

Sair

Ciclo de Vida: Utilize um laço de repetição para manter o menu ativo até que a opção "3-Sair" seja selecionada.

Coleta de Dados 
Para cada forma de pagamento, solicite:
Valor do pagamento (Atenção: garanta que o sistema aceite diferentes formatos numéricos).

Dados específicos:

Cartão: "Informe o número do cartão".

Boleto: "Informe o código de barras".



3. Requisitos Técnicos (Arquitetura e POO)
Modelagem: Crie uma classe correspondente para cada tipo de pagamento e preencha suas propriedades específicas.

Organização: Utilize boas práticas de mercado, organizando as classes em pasta.

Processamento: Implemente o método ProcessarPagamento() para simular a operação, retornando uma mensagem de confirmação ao usuário.

Tipagem: Atenção rigorosa à escolha dos tipos de dados para valores monetários e identificadores.



4. Exemplo de Funcionamento Esperado
Início da Aplicação:

***** Sistema de Processamento de Pagamentos ***** 
********** Escolha a forma de pagamento ********** 
1 - Cartão 
2 - Boleto 
3 - Sair 
Escolha uma opção:

Exemplos de Saída (após informar valor e dados):

Opção 1: Processando pagamento de R$ 150,50 via Cartão (Número: 1234-5678-9012-3456) na data 01/01/2025.

Opção 2: Processando pagamento de R$ 150,50 via Boleto (Cod Barra: 1111111122222223333333344444444) na data 01/01/2025.



5. Critérios de Avaliação e Entrega
A entrega será o link (público) do GitHub, onde deve conter no Readme o nome dos integrantes (até 5), documentação do projeto e prints das telas com evidência de testes de cada operação de pagamento.


Funcionamento da aplicação	2,0 pts
Tipos de variáveis utilizadas	2,0 pts
Boas práticas (Nomenclatura, organização)	2,0 pts
Conhecimento de POO	4,0 pts
