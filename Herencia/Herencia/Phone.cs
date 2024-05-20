using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Phone
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Precio: {Precio}, Stock: {Stock}");
        }

    }
}