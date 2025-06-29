using MarteNiuco.Commands;
using MarteNiuco.Interfaces;

namespace MarteNiuco.Factory
{
    public static class Factory
    {
        public static ICommand Movimento(char comando)
        {
            switch (comando)
            {
                case 'M': return new MoverCommand();
                case 'L': return new EsquerdaCommand();
                case 'R': return new DireitaCommand();
                default:
                    throw new ArgumentException("Comando inválido");
            }
        }
    }
}
