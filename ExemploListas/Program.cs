using System;
using System.Collections.Generic;
namespace ExemploListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da lista
            //Instanciação da lista vazia
            List<string> list = new List<string>();

            //Adição de elementos na lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            //Para cada item na lista, imprime na tela
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }            
        }
    }
}
