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

            //----------------------------------------------------------------------------

            //Para cada item na lista, imprime na tela
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //A função count conta quantos itens tem na lista
            Console.WriteLine("List count: " + list.Count);
            //----------------------------------------------------------------------------
            
            //Função predicado: é uma função que pega um valor de uma função e retorna TRUE ou FALSE
            string s1 = list.Find(Test);
            Console.WriteLine("Primeiro 'A': " + s1);

            //Mas há outra forma de usar a função Find
            //É usando uma expressão Lambda
            //A expressão Lambda elimina a necessidade de ter um método para usar no predicado
            string s2 = list.Find(x => x[0] == 'A'); //objeto 'x' tal que 'x' na posição 0 seja igual a 'A'
            Console.WriteLine("Primeiro 'A': " + s2);
            //----------------------------------------------------------------------------

            //A funçao FindLast retorna a última ocorrência passada no predicado
            //No exemplo abaixo queremos que retorne a última palavra que começa com 'A'
            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último 'A': " + s3);

            //----------------------------------------------------------------------------

            //A função FindIndex é preciso passar um inteiro, pois irá procurar pelo número do indice
            //Abaixo foi usado a expressão Lambda para encontrar a primeira palavra que começa com 'A'
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição da primeira palavra que começa com 'A': " + pos1);

            //A função FindIndexLast retorna o último elemento que começa com 'A'
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição da última palavra que começa com 'A': " + pos2);

            Console.WriteLine("-------------------------------");
            //----------------------------------------------------------------------------

            //Filtrar lista
            //É necessário instanciar uma nova lista e passar recebendo a lista acima
            //No exemplo abaixo, foi usado a expressão Lambda no qual é necessário retornar somente os
            //caracteres cujo o tamanho é igual a 5
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach(string obj in list2)
            {
                Console.WriteLine("Nomes com cinco caracteres: " + obj);
            }
            Console.WriteLine("-------------------------------");
            //----------------------------------------------------------------------------
            
            //Função Remove, remove um elemento da lista quando passado no parâmetro
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine("Lista Remove: " + obj);
            }
            Console.WriteLine("-------------------------------");
            //----------------------------------------------------------------------------

            //Função RemoveAll espera que passe uma regra para remover elementos da lista
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine("Lista RemoveAll: " + obj);
            }
            Console.WriteLine("-------------------------------");
            //----------------------------------------------------------------------------

            //Função RemoveAt remove através do indice o elemento
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine("Lista RemoveAt: " + obj);
            }
            Console.WriteLine("-------------------------------");
            //----------------------------------------------------------------------------

            //adicionando novos elementos na lista
            list.Add("Katia");
            list.Add("Benedito");
            list.Add("Carlos");
            list.Add("Laura");

            //Imprimindo os novos elementos
            foreach (string obj in list)
            {
                Console.WriteLine("Nova Lista: " + obj);
            }
            Console.WriteLine("-------------------------------");

            //Função RemoveRange pega a posição e conta quantos itens irá remover na lista
            //Precisa passar a posição e a quantidade para remoção
            list.RemoveRange(2, 2);
            foreach(string obj in list)
            {
                Console.WriteLine("Lista Range: " + obj);
            }
            Console.WriteLine("-------------------------------");
            //----------------------------------------------------------------------------

        }
        //Método para retornar TRUE ou FALSE quando a primeira palavra começar com A
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
