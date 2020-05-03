using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EjercicioRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("asd123", 11222333);
            string informacionDeAutos;

            informacionDeAutos = (string)auto1;
            Console.WriteLine(informacionDeAutos);
            Estacionamiento est = 10;
            //Auto auto1 = new Auto("asd 123", 11222333);
            //Console.WriteLine(auto1.GetInformacion());
            //auto1.SetInformacion(5);
            //auto1.SetInformacion("honda");

            Estacionamiento est1 = new Estacionamiento("Sector A", 5);
            Estacionamiento est2 = new Estacionamiento("Sector B", 8);
            //Console.WriteLine(Estacionamiento.GenerarPrecio());
            //Console.WriteLine(Estacionamiento.GenerarPrecio());
            //Console.WriteLine(Estacionamiento.GenerarPrecio());
            //Console.WriteLine(Estacionamiento.GenerarPrecio());
            //Console.WriteLine(Estacionamiento.GenerarPrecio());
            //Console.WriteLine(Estacionamiento.GenerarPrecio());
            
            
            
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
