# Niuco

Desafio para inserir sondas da NASA em Marte, permitindo movimentação de cada sonda, em linha reta, sendo possivel alterar o sentido de movimento das sondas de acordo com as direcoes N = Norte, S = Sul, E = Leste , W = Oeste. Nao e permitido inserir ou movimentar uma sonda em uma coordenada (x,y) em um ponto que ja tenha uma sonda. Considerando que uma sonda só anda para frente, mas e possivel alterar o sentido em 90 graus.

1 - O Desafio foi feito utilizando Projeto Console do .NET Core 8 (CLI - Command Line Interface).

2 - E permitido entrada de inumeras sondas para o planalto, encerrando as entradas apertando ENTER vazio ao preencher as coordenadas

3 - As sondas respeitam o limnite maximo do planalto definido previamente na execucao do projeto, caso a coordenada da sonda ultrapasse esse limite, uma exception e lancada.

4 - Utilizei os padroes de projeto Strategy e Factory. Segue justificativas:

4.1) Strategy: Julguei necessario seu uso pelo fato de ter varias instrucoes(Mover, Girar a Esquerda, Girar a direita) e cada instrucao tem um comportamento diferente, porem com um contrato em comum, evitando repeticao de codigo e facilitando a extensao do comportamento caso queira inserir novas instrucoes, respeitando o principio de aberto/fechado do SOLID

4.2) Factory: Criei uma classe estatica pra centralizar e isolar a responsabilidade da escolha de cada comando. Um ponto central que gerencia os comandos necessarios de acordo com caracteres de entrada

5) Foi utilizado o Visual Studio 2022, para depuracao e inspecao de variavel utilizei os breakpoints, onde foi necessario apenas clicar na linha desejada e apertar F9 para inserir o breakpoint e F5 para execucao

6) Utilizei o XUnit para criacao e execucao de testes unitarios, criando testes de sucesso e de erro

7) Foi criado arquivo de configuracao .github/workflows/ci.yml para execucao automatico dos testes. Para visualizar o resultado basta ir no repotorio do GitHub do projeto, na aba "Actions" clicar no worflow correspondete .NET CI.

8) Algumas consideracoes de boas praticas usadas:
   8.1) Encapsulamento: Os atributos das classes sao alterados atraves de metodos da propria classe
   8.2) Respeitado os principios do SOLID, cada classe possui uma unica responsabilidade, e possivel extender os comandos sem necessidade de alterar a classe principal, respeito a substituicao de Liskov na interface ICommand que pode ser substituida pelas classes referentes a cada comando, utilizacao de interfaces a exemplo do ICommand e ao uso de injecao de dependencia a exemplo da program que depende de abstracoes e nao de implementacoes concretas.
   8.3) Uso de conceitos do POO como encapsulamento, heranca, polimorfismo   
