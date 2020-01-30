using System;
using System.Collections.Generic;

namespace Course10
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();


            Console.WriteLine("Quantos alunos possui o curso A? ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
            }

            Console.Write("Quantos os códigos dos alunos da curso B: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.Write("Quanto alunos possuir o cursos C ? ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }


            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);

            Console.WriteLine("Total de Alunos: " + Novo.Count);
            Console.ReadLine();

        }
    }
}
