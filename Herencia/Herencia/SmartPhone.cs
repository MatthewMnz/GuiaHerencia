using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class SmartPhone : Phone
    {
        public string SistemaOperativo { get; set; }
        public int RAM { get; set; } //GB

        public void ShowInfoSmart()
        {
            ShowInfo();
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, RAM: {RAM} GB");
        }
    }
}
