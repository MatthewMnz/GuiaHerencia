namespace Herencia
{
    internal class Program
    {
        static List<Phone> inventario = new List<Phone>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menú de Inventario de Teléfonos:");
                Console.WriteLine("1. Registrar Telefono");
                Console.WriteLine("2. Mostrar Telefonos Registrados");
                Console.WriteLine("3. Consultar Stock de un Telefono en Especifico");
                Console.WriteLine("4. Cerrar");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarTelefono();
                        break;
                    case "2":
                        MostrarTelefonosRegistrados();
                        break;
                    case "3":
                        ConsultarStockTelefono();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no disponible. Volve a intentarlo.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void RegistrarTelefono()
        {
            Console.WriteLine("1. Telefono Inteligente");
            Console.WriteLine("2. Telefono Basico");
            Console.Write("Seleccione el tipo de telefono: ");
            string tipo = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            if (tipo == "1")
            {
                Console.Write("Sistema Operativo: ");
                string sistemaOperativo = Console.ReadLine();
                Console.Write("RAM (GB): ");
                int ram = int.Parse(Console.ReadLine());

                inventario.Add(new SmartPhone
                {
                    Marca = marca,
                    Modelo = modelo,
                    Precio = precio,
                    Stock = stock,
                    SistemaOperativo = sistemaOperativo,
                    RAM = ram
                });
            }
            else if (tipo == "2")
            {
                Console.Write("Posee Radio (true/false): ");
                bool poseeRadio = bool.Parse(Console.ReadLine());
                Console.Write("Posee Linterna (true/false): ");
                bool poseeLinterna = bool.Parse(Console.ReadLine());

                inventario.Add(new BasicPhone
                {
                    Marca = marca,
                    Modelo = modelo,
                    Precio = precio,
                    Stock = stock,
                    PoseeRadio = poseeRadio,
                    PoseeLinterna = poseeLinterna
                });
            }
            else
            {
                Console.WriteLine("Tipo de telefono no valido.");
            }

            Console.WriteLine("Telefono registrado correctamente.");
        }

        static void MostrarTelefonosRegistrados()
        {
            if (inventario.Count == 0)
            {
                Console.WriteLine("No hay telefonos registrados.");
                return;
            }

            Console.WriteLine("Telefonos Registrados:");
            foreach (var telefono in inventario)
            {
                telefono.ShowInfo();
                Console.WriteLine();
            }
        }

        static void ConsultarStockTelefono()
        {
            Console.Write("Ingresa el modelo del telefono que deseas buscar: ");
            string modelo = Console.ReadLine();

            var telefono = inventario.FirstOrDefault(t => t.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));

            if (telefono == null)
            {
                Console.WriteLine("No se encontro ningun telefono de ese modelo.");
            }
            else
            {
                telefono.ShowInfo();
            }
        }
    }
}
