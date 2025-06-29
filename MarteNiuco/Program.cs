using MarteNiuco.Models;
using MarteNiuco.Services;

var limites = Console.ReadLine()!.Split(' ');
var planalto = new Planalto(int.Parse(limites[0]), int.Parse(limites[1]));
var sondas = new List<Sonda>();
var service = new SondaService();


/*
 Para encerrar execucao, pressione ENTER sem passar nenhum valor
 */
while (true)
{
    var entradaPosicao = Console.ReadLine(); ;
    if (string.IsNullOrWhiteSpace(entradaPosicao)) break;
    var local = entradaPosicao.Split(' ');
    string comandos = Console.ReadLine()!;

    service.CriarSonda(local, comandos, planalto, sondas);
}

foreach (var sonda in sondas)
{
    Console.WriteLine(sonda);
}



