namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirTamanhoDeMarte();

            Console.WriteLine("Digite a posiçao inicial da espaçonave (X - Y - LETRA): ");
            string posicaoXYZ = Console.ReadLine();
            string[] posicaoInicial = posicaoXYZ.Split(' ');

            Robo.iniX = int.Parse(posicaoInicial[0].ToString());
            Robo.iniY = int.Parse(posicaoInicial[1].ToString());
            Robo.sentidoInicial = char.Parse(posicaoInicial[2]);

            //comando executado para a espaçonave percorrer o planeta e informar a coordenada que parou.
            char[] instrucao = Comando();
            Robo.Explorar(instrucao);
            Robo.ExibirCoordenadas();

        }

        public static char[] Comando()
        {
            Console.WriteLine("Digite a instrução de vôo (MMEMMMDM): ");
            string comando = Console.ReadLine();
            char[] instrucao = comando.ToCharArray();
            return instrucao;
        }

        public static void ExibirTamanhoDeMarte()
        {
            Console.WriteLine("Digite o tamanho do espaço a ser buscado em Marte (ex: 9 9)");
            string tamanhoMarte = Console.ReadLine();
            string[] posicaoMarte = tamanhoMarte.Split(' ');

            int finalX = int.Parse(posicaoMarte[0].ToString());
            int finalY = int.Parse(posicaoMarte[1].ToString());
        }
    }
}
