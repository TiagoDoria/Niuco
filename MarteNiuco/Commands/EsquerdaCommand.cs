using MarteNiuco.Interfaces;
using MarteNiuco.Models;

namespace MarteNiuco.Commands
{
    public class EsquerdaCommand : ICommand
    {
        public void Movimentar(Sonda sonda)
        {
            sonda.Esquerda();
        }
    }
}
