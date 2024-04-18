using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_desafio.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia: Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria) { }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            if (nome == null || nome == "")
            {
                throw new ArgumentNullException("O nome do aplicativo deve ser fornecido");
            }
            Console.WriteLine($"O Aplicativo \"{nome}\" foi instalado no Nokia");
        }
    }
}