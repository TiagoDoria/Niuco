using MarteNiuco.Interfaces;
using MarteNiuco.Models;

namespace MarteNiuco.Commands
{
    public class MoverCommand : ICommand
    {
        public void Movimentar(Sonda sonda)
        {
            sonda.Movimentar();
        }
    }
}
