using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento_Logica
{
    public class exList
    {
        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> list = new List<int>();
            int pontosAlice = 0;
            int pontosBob = 0;
            int naoRecebePontos = 0;


            for (int i = 0; i < 3; i++)
            {
                list.Add(i);

                if (a[i] > b[i])
                {
                    pontosAlice++;
                }
                else if (a[i] < b[i])
                {
                    pontosBob++;
                }
                else if (a == b)
                {
                    naoRecebePontos++;
                }

                Console.WriteLine("Alice tem " + pontosAlice + " pontos.");
                Console.WriteLine("Bob tem " + pontosBob + " pontos.");
                Console.WriteLine("Niguém recebe pontos. " + naoRecebePontos);



                Console.WriteLine("Nenhum ponto é ganho  pelos indices serem iguais" +
                   ": " + a[0] + " " + b[1]);

                Console.WriteLine("Nenhum ponto é ganho  pelos indices serem iguais" +
                   ": " + a[0] + " " + b[2]);

                Console.WriteLine("Nenhum ponto é ganho  pelos indices serem iguais" +
                  ": " + a[1] + " " + b[1]);



                //list1.Sort();

                //Console.WriteLine("Valor mínimo: {0}", list1[0]);
                //Console.WriteLine("Valor máximo: {0}", list1[list1.Count - 1]);



               
            }
            return list;
        }
       


    }
}
    



