using MarteNiuco.Models;
using MarteNiuco.Services;

namespace NiucoTests
{
    public class Testes
    {
        [Fact]
        public void Inserir_Varias_Sondas_Com_Sucesso()
        {
            var service = new SondaService();

            var planalto = new Planalto(5, 5);
            var sondas = new List<Sonda>();

            var local = new[] { "1", "2", "N" };
            service.CriarSonda(local, "LMLMLMLMM", planalto, sondas);
            Assert.Equal("1 3 N", sondas[0].ToString());

            local = new[] { "3", "3", "E" };
            service.CriarSonda(local, "MMRMMRMRRM", planalto, sondas);
            Assert.Equal("5 1 E", sondas[1].ToString());
        }

        [Fact]
        public void Mover_Sonda_Para_50N()
        {
            var planalto = new Planalto(5, 5);
            var sondas = new List<Sonda>();
            var service = new SondaService();

            var local = new[] { "5", "0", "N" };
            var comandos = "MMMMM"; // Vai até (5,5) na vertical

            service.CriarSonda(local, comandos, planalto, sondas);

            Assert.Equal("5 5 N", sondas[0].ToString());
        }

        [Fact]
        public void Girar_Sonda_360_Graus()
        {
            var planalto = new Planalto(5, 5);
            var sondas = new List<Sonda>();
            var service = new SondaService();

            var local = new[] { "2", "2", "N" };
            var comandos = "RRRR"; // Gira no próprio eixo

            service.CriarSonda(local, comandos, planalto, sondas);

            Assert.Equal("2 2 N", sondas[0].ToString());
        }

        [Fact]
        public void Mover_Sonda_Para_2_0_S()
        {
            var planalto = new Planalto(5, 5);
            var sondas = new List<Sonda>();
            var service = new SondaService();

            var local = new[] { "2", "2", "S" };
            var comandos = "MM"; // Vai para baixo

            service.CriarSonda(local, comandos, planalto, sondas);

            Assert.Equal("2 0 S", sondas[0].ToString());
        }

        [Fact]
        public void Lancar_Excecao_Se_Sonda_Ja_Existir_Na_Posicao()
        {
            var planalto = new Planalto(5, 5);
            var sondas = new List<Sonda>();
            var service = new SondaService();

            planalto.InsereSonda(1, 2);

            var local = new[] { "1", "2", "N" };

            var comandos = "LMLMLMLMM";

            var ex = Assert.Throws<Exception>(() =>
                 service.CriarSonda(local, comandos, planalto, sondas));

            Assert.Equal("Ja existe uma sonda na coordenada fornecida", ex.Message);
        }
    }
}