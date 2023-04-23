using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer ensayo objetos + herencia + colecciones");
            List<Moto> ListaMotos = new List<Moto>();
            Moto m1 = new Moto();
            Moto m2 = new Moto();
            Moto m3 = new Moto();
            Moto m4 = new Moto();
            ListaMotos.Add(m1);
            ListaMotos.Add(m2);
            ListaMotos.Add(m3);
            ListaMotos.Add(m4);
            m1.ColorPrimario = "Azul";
            m2.ColorPrimario = "Rojo";
            m3.ColorPrimario = "Azul";
            m4.ColorPrimario = "Negro";
            m1.Año = 2000;
            m2.Año = 2006;
            m3.Año = 2002;
            m4.Año = 2004;
            AutoDeportivo AD1 = new AutoDeportivo();
            AutoDeportivo AD2 = new AutoDeportivo();
            
            int x = 0;
            foreach (Moto m in ListaMotos)
            {
                x++;
                Console.WriteLine("El color de la moto: " + x + "  " + m.ColorPrimario);
                Console.WriteLine("El año es: " + m.Año);
            }

            
            Console.ReadKey();  
        }
    }
}
