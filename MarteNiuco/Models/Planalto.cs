namespace MarteNiuco.Models
{
    public class Planalto
    {
        public int CoordenadaX { get; }
        public int CoordenadaY { get; }
        private List<(int X, int Y)> sondas = new();

        public Planalto(int _coordenadaX, int _coordenadaY)
        {
            CoordenadaX = _coordenadaX;
            CoordenadaY = _coordenadaY;
        }

        /*
         Metodo que  verifica se a sonda ultrapassou o limite do planalto
         Retorna false nao ultrapassou e segue fluxo
         Retorna true se ultrapassou e invalida a movimentacao
         */
        public bool Ultrapassou(int x, int y)
        {
            if (x >= 0 && x <= CoordenadaX && y >= 0 && y <= CoordenadaY)
                return false;

            return true;
        }

        /*
         Metodo que verifica se existe uma sonda em determinada coordenada
         */
        public bool ExisteSonda(int x, int y)
        {
            if (sondas.Contains((x, y)))
                return true;

            return false;
        }

        /*
         Metodo que insere uma sonda em uma coordenada
         */
        public void InsereSonda(int x, int y)
        {
            sondas.Add((x, y));
        }

        /*
         Metodo que remove uma sonda ao realizar movimento
         */
        public void RemoveSonda(int x, int y)
        {
            sondas.Remove((x, y));
        }
    }
}
