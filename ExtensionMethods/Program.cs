using String;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * EXTENSION METHODS
            - São métodos que estendem a funcionalidade de um tipo, sem precisar alterar o código fonte deste tipo, nem herdar desse tipo

            * Como fazer um extension method?
            - Criar uma classe estática
            - Na classe, criar um método estático
            - O primeiro parâmetro do método deverá ter o prefixo this, seguido da declaração de um parâmetro do tipo que se deseja estender. Esta será uma referência para o próprio objeto.
             
             * DEMO 1:
             - Vamos criar um extension method chamado "ElapsedTime()" no struct DateTime para apresentar um objeto DateTime na forma de tempo decorrido, podendo ser em horas (se menor que 24h) ou em dias caso contrário.             
             */

            DateTime dt = new DateTime(2018, 11, 16, 8, 19, 45);
            Console.WriteLine("Tempo decorrido desde a data " + dt + ": " + dt.ElapsedTime());

            /*
            * DEMO 2:
            - Vamos criar um extension method chamado "Cut(int) na classe String para receber um valor inteiro como parâmetro e gerar um recorte do string original daquele tamanho.
            */
            Console.WriteLine();
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
