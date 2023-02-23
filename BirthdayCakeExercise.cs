using System.Reflection.Metadata;

namespace Treinamento_Logica
{
    /*Você é responsável pelo bolo para o aniversário de uma criança. Você decidiu que o bolo 
        terá uma vela para cada ano de sua idade total. Eles só serão capazes de soprar a mais alta 
        das velas. Conte quantas velas são mais altas.

        Exemplo

        As velas de altura máxima são unidades altas. Há deles, então volte.

        Descrição da função

        Conclua a função no editor abaixo. birthdayCakeCandles

        birthdayCakeCandles tem o(s) seguinte(s) parâmetro(s):

        int candles[n]: as alturas das velas
        Retorna

        int: o número de velas mais altas*/
    //bolo = 1 vela para cada ano de sua idade total
    //valas = Contagem da mais alta


    public class BirthdayCakeExercise
    {

        public int birthdayCakeCandles(List<int> candles)
        {
            int tallestCandle = 0; // inicializa a variável que armazenará a altura da vela mais alta
            int countTallestCandles = 0; // inicializa a variável que contará quantas velas são as mais altas

            foreach (int candle in candles)
            {
                if (candle > tallestCandle)
                {
                    tallestCandle = candle;
                    countTallestCandles = 1; // reset o contador se uma nova vela mais alta for encontrada
                }
                else if (candle == tallestCandle)
                {
                    countTallestCandles++; // incrementa o contador se uma vela com a mesma altura for encontrada
                }
            }

            Console.WriteLine("Número de velas mais altas: " + countTallestCandles);

            return countTallestCandles;
        }

    }
}
