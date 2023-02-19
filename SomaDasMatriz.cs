using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento_Logica
{
    public class SomaDasMatriz
    {

        /*Neste desafio, você é obrigado a calcular e imprimir a soma dos elementos em uma matriz, tendo em mente que alguns desses inteiros podem ser bastante grandes.

        Descrição da função

        Conclua a função aVeryBigSum no editor abaixo. Ele deve retornar a soma de todos os elementos da matriz.

        aVeryBigSum tem o(s) seguinte(s) parâmetro(s):

        int ar[n]: uma matriz de inteiros .
        Retornar

        long: a soma de todos os elementos da matriz
        Formato de entrada

        A primeira linha da entrada consiste em um inteiro .
        A próxima linha contém inteiros separados por espaço contidos na matriz. 

        Formato de saída

        Retorne a soma inteira dos elementos na matriz.*/


        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach (long num in ar)
            {
                sum += num;
            }
            return sum;
        }
    }
}
