using MarteNiuco.Enums;
using MarteNiuco.Factory;
using MarteNiuco.Models;

var limites = Console.ReadLine()!.Split(' ');
var planalto = new Planalto(int.Parse(limites[0]), int.Parse(limites[1]));
var sondas = new List<Sonda>();

/*
 Para encerrar execucao, pressione ENTER sem passar nenhum valor
 */
while (true) 
{
    var entradaPosicao = Console.ReadLine(); ;
    if (string.IsNullOrWhiteSpace(entradaPosicao)) break;
    var local = entradaPosicao.Split(' ');

    int x = int.Parse(local[0]);
    int y = int.Parse(local[1]);
    Direcao direcao = Enum.Parse<Direcao>(local[2]);

    var sonda = new Sonda(x, y, direcao, planalto);

    if (planalto.ExisteSonda(x, y)) throw new Exception("Ja existe uma sonda na coordenada fornecida");

    planalto.InsereSonda(x, y);

    string comandos = Console.ReadLine()!;

    foreach (char c in comandos)
    {
        var comando = Factory.Movimento(c);
        comando.Movimentar(sonda);
    }

    sondas.Add(sonda);
}

foreach (var sonda in sondas)
{
    Console.WriteLine(sonda);
}

