using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTransporte
{
    internal class Onibus : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine($"veiculo da Placa {Placa} Está se movendo");
        }
    }
}
