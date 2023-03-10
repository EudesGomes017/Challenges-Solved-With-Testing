namespace Treinamento_Logica
{
    public class Staircase
    {
        public int staircase(int n)
        {
            // Recebe o tamanho da escada do usuário
            Console.Write("Digite o tamanho da escada: ");
            int tamanho = int.Parse(Console.ReadLine());

            // Imprime a escada
            for (int i = 1; i <= tamanho; i++)
            {
                // Adiciona espaços em branco antes dos símbolos
                string espacos = new string(' ', tamanho - i);

                // Adiciona os símbolos para a escada
                string simbolos = new string('#', i);

                // Imprime a linha da escada
                Console.WriteLine(espacos + simbolos);
            }

            return tamanho;
        }
    }
}
