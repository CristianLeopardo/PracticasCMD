using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Perro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro();
            Perro p2 = new Perro();
            Perro p3 = new Perro();
            Perro p4 = new Perro();
            Console.WriteLine("Nombre del perro 1: ");
            p1.Nombre = Console.ReadLine();
            Console.WriteLine("Color del perro 1: ");
            p1.Color = Console.ReadLine();
            Console.WriteLine("Origen del perro 1: ");
            p1.Origen = Console.ReadLine();
            Console.WriteLine("Nombre del perro 2: ");
            p2.Nombre = Console.ReadLine();
            Console.WriteLine("Color del perro 2: " );
            p2.Color = Console.ReadLine();
            Console.WriteLine("Origen del perro 2: ");
            p2.Origen = Console.ReadLine();
            Console.WriteLine("Nombre del perro 3: ");
            p3.Nombre = Console.ReadLine();
            Console.WriteLine("Color del perro 3: ");
            p3.Color = Console.ReadLine();
            Console.WriteLine("Origen del perro 3: ");
            p3.Origen = Console.ReadLine();
            Console.WriteLine("Nombre del perro 4: " );
            p4.Nombre = Console.ReadLine();
            Console.WriteLine("Color del perro 4: " );
            p4.Color = Console.ReadLine();
            Console.WriteLine("Origen del perro 4: ");
            p4.Origen = Console.ReadLine();
            Console.WriteLine("Informacion Perro 1:" + p1.Nombre + " - " + p1.Color + " - " + p1.Origen);
            Console.WriteLine("Informacion Perro 2:" + p2.Nombre + " - " + p2.Color + " - " + p2.Origen);
            Console.WriteLine("Informacion Perro 3:" + p3.Nombre + " - " + p3.Color + " - " + p3.Origen);
            Console.WriteLine("Informacion Perro 4:" + p4.Nombre + " - " + p4.Color + " - " + p4.Origen);


            Console.ReadKey();
        }
    }
}
