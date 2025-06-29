using MarteNiuco.Interfaces;

namespace MarteNiuco.Commands
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
