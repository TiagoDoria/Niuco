using MarteNiuco.Enums;

namespace MarteNiuco.Models
{
    public class Sonda
    {
        public int CoordenadaX { get; private set; }
        public int CoordenadaY { get; private set; }
        public Direcao DirecaoAtual { get; private set; }
        private readonly Planalto _planalto;

        public Sonda(int _coordenadaX, int _coordenadaY, Direcao direcao, Planalto planalto)
        {
            CoordenadaX = _coordenadaX;
            CoordenadaY = _coordenadaY;
            DirecaoAtual = direcao;
            _planalto = planalto;
        }

        public void Movimentar()
        {
            int x = CoordenadaX;
            int y = CoordenadaY;

            switch (DirecaoAtual)
            {
                case Direcao.N: y++; break;
                case Direcao.S: y--; break;
                case Direcao.E: x++; break;
                case Direcao.W: x--; break;
            }

            if (_planalto.ExisteSonda(x, y))
                throw new Exception("Colisão detectada com outra sonda!");

            /*
                Se tiver ultrapassado o limite ele nao atualiza as coordenadas e lanca uma exception
             */
            if (!_planalto.Ultrapassou(x, y))
            {
                _planalto.RemoveSonda(CoordenadaX, CoordenadaY);
                CoordenadaX = x;
                CoordenadaY = y;
                _planalto.InsereSonda(CoordenadaX, CoordenadaY);
            }
            else
            {
                throw new Exception("Movimento fora dos limites do planalto");
            }
        }

        public void Esquerda()
        {
            switch (DirecaoAtual)
            {
                case Direcao.N:
                    DirecaoAtual = Direcao.W; break; // Se Sonda tiver para o Norte, vira para o Oeste
                case Direcao.W:
                    DirecaoAtual = Direcao.S; break; // Se Sonda tiver para o Oeste, vira para o Sul  
                case Direcao.S:
                    DirecaoAtual = Direcao.E; break; // Se Sonda tiver para o Sul, vira para o Leste
                case Direcao.E:
                    DirecaoAtual = Direcao.N; break; // Se Sonda tiver para o Leste, vira para o Norte  
            }       
        }

        public void Direita()
        {
            switch (DirecaoAtual)
            {
                case Direcao.N:
                    DirecaoAtual = Direcao.E; break;  // Se Sonda tiver para o Norte, vira para o Leste
                case Direcao.W:
                    DirecaoAtual = Direcao.N; break;  // Se Sonda tiver para o Oeste, vira para o Norte  
                case Direcao.S:
                    DirecaoAtual = Direcao.W; break;  // Se Sonda tiver para o Sul, vira para o Oeste
                case Direcao.E:
                    DirecaoAtual = Direcao.S; break;  // Se Sonda tiver para o Leste, vira para o Sul
            }
        }

        public override string ToString()
        {
            return $"{CoordenadaX} {CoordenadaY} {DirecaoAtual}";
        }
    }
}
