using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDelElefante
{
    class Program
    {
        static void Main(string[] args)
        {
            int elefante;
            int contador = 1;
            Console.WriteLine("Ingrese la cantidad que decee cantar");
            elefante = int.Parse(Console.ReadLine());
            while(contador<=elefante){
                Console.WriteLine(contador+" Elefante se columpiaba sobre la tela de una araña");
                Console.WriteLine(" como beia que recistia fueron a llamar a otro elefante");
                contador++;

            }
            Console.ReadKey();

        }
    }
}
