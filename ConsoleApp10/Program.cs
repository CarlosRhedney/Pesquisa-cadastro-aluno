using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int na, j;
            string rapesq, pesq;
            string[] ra = new string[50];
            string[] nome = new string[50];
            float[] p1 = new float[50];
            float[] p2 = new float[50];
            float[] ms = new float[50];
            string[] conc = new string[50];
            Console.Write("Digite o numero de alunos : max 50::>");
            na = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= na; i++)
            {
                Console.Write("\nDigite o nome do aluno::>");
                nome[i] = Console.ReadLine();
                Console.Write("\nDigite o ra do aluno::>");
                ra[i] = Console.ReadLine();
                Console.Write("\nDigite a nota p1 do aluno::>");
                p1[i] = Convert.ToSingle(Console.ReadLine());
                Console.Write("\nDigite a nota p2 do aluno::>");
                p2[i] = Convert.ToSingle(Console.ReadLine());
                ms[i] = (p1[i] + p2[i]) / 2;
                if (ms[i] >= 7.0f)
                    conc[i] = "Aprovado";
                else
                    conc[i] = "Exame";
            }
            Console.Write("\nAluno\tRA\tP1\tP2\tMédia\tConceito");
            for (int i = 1; i <= na; i++)
                Console.Write("\n{0}\t{1}\t{2:f1}\t{3:f1}\t{4:f1}\t{5}", nome[i], ra[i], p1[i], p2[i], ms[i], conc[i]);
            Console.Write("\nDigite \"p\" para pesquisa de um nome ou \"s\" para sair...");
            pesq = Console.ReadLine();
            while (pesq == "p")
            {
                Console.Write("\nDigite o ra a ser pesquisado::>");
                rapesq = Console.ReadLine();
                j = 0;
                do
                {
                    j++;
                } while (rapesq != ra[j]);
                Console.Write("\nNome:{0}\tP1:{1:f1}\tP2:{2:f1}\tMédia:{3:f1}\tConceito:{4}", nome[j], p1[j], p2[j], ms[j], conc[j]);
                Console.Write("\nDigite \"p\" para continuar::>");
                pesq = Console.ReadLine();
            }

        }
    }
}
