using System.Net.Http.Headers;


namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prv = new int[3];
            int[] prv2 = new int[3];
            int[] prv3 = new int[3];
            int[] media = new int[3];
            string[] nome = new string[3];
            string sit = "Aluno aprovado";
            string sit2 = "Aluno reprovado";

            Console.WriteLine("-------- Escola Estadual de Minas Gerais ------------");
            Console.WriteLine("");

            for (int i =0; i < nome.Length; i++)
            {
                Console.Write("Insira o nome do aluno:");
                nome[i] = Console.ReadLine();
                Console.Write("Insira a 1ª nota do aluno:");
                prv[i] = int.Parse(Console.ReadLine());
                Console.Write("Insira a 2ª nota do aluno:");
                prv2[i] = int.Parse(Console.ReadLine());
                Console.Write("Insira a 3ª  nota do aluno:");
                prv3[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("__________________________");

                media[i] = (prv[i] + prv2[i] + prv3[i])/3;
                

              
            }

            for(int i =0; i< nome.Length; i++)
            {
                Console.WriteLine("Nome do Aluno:" + nome[i]);
                Console.WriteLine("1ª nota :" + prv[i]);
                Console.WriteLine("2ª nota :" + prv2[i]);
                Console.WriteLine("3ª nota :" + prv3[i]);
               
                Console.WriteLine("Media : " + media[i]);
               

                if (media[i] > 60)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(sit);
                    Console.ResetColor();
                    Console.WriteLine("______________________");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(sit2);
                    Console.ResetColor();
                    Console.WriteLine("______________________");

                }
            }
            
        }
    }
}