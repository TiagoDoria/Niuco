using MarteNiuco.Enums;
using MarteNiuco.Factory;
using MarteNiuco.Models;

namespace NiucoTests
{
    public class Testes
    {
        [Fact]
        public void Deve_Mover_Sonda_Corretamente()
        {
            var planalto = new Planalto(5, 5);
            var rover = new Sonda(1, 2, Direcao.N, planalto);
            planalto.InsereSonda(1, 2);

            string comandos = "LMLMLMLMM";
            foreach (var c in comandos)
            {
                var comando = Factory.Movimento(c);
                comando.Movimentar(rover);
            }

            Assert.Equal("1 3 N", rover.ToString());
        }
    }
}