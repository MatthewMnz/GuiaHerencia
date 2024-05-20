using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class BasicPhone : Phone
    {
        public bool PoseeRadio { get; set; }
        public bool PoseeLinterna { get; set; }

        public void ShowInfoBasic()
        {
            ShowInfo();
            Console.WriteLine($"Posee Radio {PoseeRadio}, Posee Linterna {PoseeLinterna}");
        }
    }
}
