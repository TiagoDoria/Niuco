using MarteNiuco.Enums;
using MarteNiuco.Models;

namespace MarteNiuco.Services
{
    public class SondaService
    {
        public void CriarSonda(string[] local, string comandos, Planalto planalto, List<Sonda> sondas)
        {
            int x = int.Parse(local[0]);
            int y = int.Parse(local[1]);
            Direcao direcao = Enum.Parse<Direcao>(local[2]);

            var sonda = new Sonda(x, y, direcao, planalto);

            if (planalto.ExisteSonda(x, y)) throw new Exception("Ja existe uma sonda na coordenada fornecida");

            planalto.InsereSonda(x, y);


            foreach (char c in comandos)
            {
                var comando = MarteNiuco.Factory.Factory.Movimento(c);
                comando.Movimentar(sonda);
            }

            sondas.Add(sonda);
        }
    }
}
