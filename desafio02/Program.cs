using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio02
{
    class Program
    {
        const int NUMERO_DE_REPETICOES = 5;
        static string sequencia;
        static int count;
        static string result;
        
        static void Main(string[] args)
        {
            sequencia = "1";
            Console.WriteLine(sequencia);
            Exec();
        }
        
        static void Exec()
        {
            for (int i = 0; i < NUMERO_DE_REPETICOES; i++)
            {
                Calcula();
            }

            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            Exec();
        }

        static void Calcula()
        {
            result = "";
            count = 1;

            char curr;
            char next;

            for (int i = 0; i < sequencia.Length; i++)
            {
                next = i == sequencia.Length - 1 ? ' ' : sequencia[i + 1];
                curr = sequencia[i];

                if (curr == next && next != ' ')
                {
                    count++;
                }
                else
                {
                    result += count.ToString() + curr;
                    count = 1;
                }
            }

            Console.WriteLine(result);
            sequencia = result;
        }

    }
}
