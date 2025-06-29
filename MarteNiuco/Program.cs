using MarteNiuco.Commands;
using MarteNiuco.Enums;
using MarteNiuco.Models;

var limites = Console.ReadLine()!.Split(' ');
var planalto = new Planalto(int.Parse(limites[0]), int.Parse(limites[1]));

var entradaPosicao = Console.ReadLine()!.Split(' ');
int x = int.Parse(entradaPosicao[0]);
int y = int.Parse(entradaPosicao[1]);
Direcao direcao = Enum.Parse<Direcao>(entradaPosicao[2]);

var sonda = new Sonda(x, y, direcao, planalto);

if (planalto.ExisteSonda(x, y)) throw new Exception("Ja existe uma sonda na coordenada fornecida");

planalto.InsereSonda(x, y);

string comandos = Console.ReadLine()!;

foreach (char c in comandos)
{
    var comando = Factory.Movimento(c);
    comando.Movimentar(sonda);
}

Console.WriteLine(sonda);
