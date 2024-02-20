using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeInstrumentos.Entities
{
    internal class Instrumentos
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Preco { get; set; }


        public Instrumentos(string tipo, string marca,string modelo, double preco) 
        {
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Preco = preco;
        }

        
        public void ExiberDetalhes()
        {
            Console.WriteLine("Tipo: " + Tipo + "Marca: " + Marca +
               "Modelo: " + Modelo + "Preco: " + Preco);     
        }
    }
}
