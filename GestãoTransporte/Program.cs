using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTransporte
{
    public class Program
    {
        Veiculo ocarro = new Carro();
        Veiculo ocaminhao = new Caminhão();
        Veiculo amoto = new Moto();
        Veiculo onibus = new Onibus();


        static void Main(string[] args)
        {
            Veiculo carro = new Carro();
            carro.Placa = "1gbfg";
            carro.Mover();

            Veiculo caminhao = new Caminhão();
            caminhao.Placa = "dzfg";
            caminhao.Mover();

            Veiculo moto = new Moto();
            carro.Placa = "dfgd";
            carro.Mover();

            Veiculo onibus = new Carro();
            caminhao.Placa = "tuytu";
            caminhao.Mover();


            List<Veiculo> veiculos = new List<Veiculo>();

            veiculos.Add(carro);
            veiculos.Add(caminhao);
            veiculos.Add(moto);
            veiculos.Add(onibus);

            foreach (Veiculo animal in veiculos)
            {
                animal.Mover();
            }

            Console.ReadLine();




        }
    }
}
