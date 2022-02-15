using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "";
            var y = "";
            int linha;
            int coluna;
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            while (campoMinado.JogoStatus == 0)
            {
                Console.WriteLine(campoMinado.Tabuleiro);
                Console.WriteLine();
                Console.WriteLine("Escolha uma linha de 1 a 9");
                x = Console.ReadLine();
                int.TryParse(x, out linha);

                while (linha <= 0 || linha > 9)
                {
                    Console.WriteLine();
                    Console.WriteLine("Linha invalida. Jogue novamente");
                    x = Console.ReadLine();
                    int.TryParse(x, out linha);
                }

                Console.WriteLine();
                Console.WriteLine("Escolha uma coluna de 1 a 9");
                y = Console.ReadLine();
                int.TryParse(y, out coluna);
                while (coluna <= 0 || coluna > 9)
                {
                    Console.WriteLine("Coluna invalida. Jogue novamente");
                    y = Console.ReadLine();
                    int.TryParse(y, out coluna);
                }
                campoMinado.Abrir(linha, coluna);
                switch (campoMinado.JogoStatus)
                {
                    case 0:
                        Console.WriteLine("Continue jogando");
                        break;
                    case 2:
                        Console.WriteLine("Game Over");
                        Console.WriteLine(campoMinado.Tabuleiro);
                        break;
                    case 1:
                        Console.WriteLine("Voce venceu o jogo");
                        Console.WriteLine(campoMinado.Tabuleiro);
                        break;
                }




            }

            Console.ReadLine();


        }
    }
}