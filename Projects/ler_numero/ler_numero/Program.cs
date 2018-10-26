using System;

namespace ler_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, sucessor, antecessor;
            string texto;

            Console.WriteLine("Informe um numero");
            valor = Int32.Parse(Console.ReadLine());
            antecessor = valor -1;
            sucessor = valor +1;
            texto = "numero:{0}, sucessor:{1}, antecessor: {2}";
            Console.WriteLine(texto,valor,sucessor,antecessor);
        }
    }
}
