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
            //O função Add adiciona o elemento no FINAL da lista.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            //----------
            //A função Insert insere na posição escolhida
            list.Insert(2, "Marco");

            //Para cada item na lista, imprime na tela
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }            
        }
    }
}
