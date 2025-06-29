# Niuco

Desafio para inserir sondas da NASA em Marte, permitindo movimentação de cada sonda, em linha reta, sendo possivel alterar o sentido de movimento das sondas de acordo com as direcoes N = Norte, S = Sul, E = Leste , W = Oeste. Nao e permitido inserir ou movimentar uma sonda em uma coordenada (x,y) em um ponto que ja tenha uma sonda. Considerando que uma sonda só anda para frente, mas e possivel alterar o sentido em 90 graus.

1 - O Desafio foi feito utilizando Projeto Console do .NET Core 8 (CLI - Command Line Interface).

2 - E permitido entrada de inumeras sondas para o planalto, encerrando as entradas apertando ENTER vazio ao preencher as coordenadas

3 - As sondas respeitam o limnite maximo do planalto definido previamente na execucao do projeto, caso a coordenada da sonda ultrapasse esse limite, uma exception e lancada.

4 - Utilizei os padroes de projeto Strategy e Factory. Segue justificativas:

4.1) Strategy: Julguei necessario seu uso pelo fato de ter varias instrucoes(Mover, Girar a Esquerda, Girar a direita) e cada instrucao tem um comportamento diferente, porem com um contrato em comum, evitando repeticao de codigo e facilitando a extensao do comportamento caso queira inserir novas instrucoes, respeitando o principio de aberto/fechado do SOLID.

4.2) Factory: Criei uma classe estatica pra centralizar e isolar a responsabilidade da escolha de cada comando. Um ponto central que gerencia os comandos necessarios de acordo com caracteres de entrada.
