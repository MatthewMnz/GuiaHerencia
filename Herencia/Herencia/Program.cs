namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone
            {
                Marca = "Apple",
                Modelo = "iPhone 11 Pro MAX",
                Precio = 399,
                Stock = 21,
                SistemaOperativo = "iOS",
                RAM = 4
            };

            BasicPhone basicPhone = new BasicPhone
            {
                Marca = "Samsung",
                Modelo = "J2 Prime",
                Precio = 79,
                Stock = 121,
                PoseeRadio = false,
                PoseeLinterna = true
            };

            Console.WriteLine("Info del telefono inteligente:");
            smartPhone.ShowInfoSmart();

            Console.WriteLine();

            Console.WriteLine("Info del telefono básico:");
            basicPhone.ShowInfoBasic();
        }
    }
}
