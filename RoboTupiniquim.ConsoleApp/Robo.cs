namespace RoboTupiniquim.ConsoleApp
{
    public static class Robo
    {
        public static int iniX;
        public static int iniY;
        public static char sentidoInicial;

        public static void Explorar(char[] instrucao)
        {
            for (int i = 0; i < instrucao.Length; i++)
            {
                if (instrucao[i] == 'M')
                {
                    Mover();
                }
                else if (instrucao[i] == 'E')
                {
                    VirarEsquerda();
                }
                else
                {
                    VirarDireita();
                }

            }
        }
        public static void VirarEsquerda()
        {
            if (sentidoInicial == 'N')
                sentidoInicial = 'O';

            else if (sentidoInicial == 'S')
                sentidoInicial = 'L';

            else if (sentidoInicial == 'L')
                sentidoInicial = 'N';

            else if (sentidoInicial == 'O')
                sentidoInicial = 'S';
        }

        public static void VirarDireita()
        {
            if (sentidoInicial == 'N')
                sentidoInicial = 'L';

            else if (sentidoInicial == 'S')
                sentidoInicial = 'O';

            else if (sentidoInicial == 'L')
                sentidoInicial = 'S';

            else if (sentidoInicial == 'O')
                sentidoInicial = 'N';
        }

        internal static void Mover()
        {
            if (sentidoInicial == 'O')
            {
                iniX--;
            }
            else if (sentidoInicial == 'N')
            {
                iniY++;
            }
            else if (sentidoInicial == 'S')
            {
                iniY--;
            }
            else
            {
                iniX++;
            }
        }

        public static void ExibirCoordenadas()
        {
            Console.WriteLine($"Você está na posição:{iniX} {iniY} {sentidoInicial}");
            Console.ReadLine();
        }
    }
}
