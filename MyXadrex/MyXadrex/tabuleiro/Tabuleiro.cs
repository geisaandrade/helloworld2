
namespace tabuleiro
{
    class Tabuleiro
    {

        public int linhas;
        public int colunas;
        private Peca[,] pecas;
        private int v1;
        private int v2;

        

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
