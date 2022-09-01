using System;

namespace Tipos.String.Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();
                string nomeValidado = nome.Trim();

                if (string.IsNullOrWhiteSpace(nomeValidado))
                    throw new Exception("Nome inválido.");

                Console.WriteLine("Primeira letra do meu nome:" + nomeValidado[0]);
                Console.WriteLine("Ultima letra do meu nome:" + nomeValidado[nomeValidado.Length -1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
