using MarteNiuco.Interfaces;
using MarteNiuco.Models;

namespace MarteNiuco.Commands
{
    public class DireitaCommand : ICommand
    {
        public void Movimentar(Sonda sonda)
        {
            sonda.Direita();
        }
    }
}
