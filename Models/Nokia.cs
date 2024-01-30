using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaParaAbstracaoDeCelular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia()
        {

        }
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

         public override void InstalarAplicativo(string nome)
         {
            Console.WriteLine($"Instalando {nome} no Nokia...");
         }
    }
}