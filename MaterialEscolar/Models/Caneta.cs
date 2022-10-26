using System.Security.Cryptography.X509Certificates;

namespace Models
{
    public class Caneta
    {
        private string cor;
        private string marca;
        private int percentualCarga;
        private string material;
        private bool estourada;
        private bool caida;
        private bool tampada;
        

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }


        public int PercentualCarga
        {
            get { return percentualCarga; }
            set { percentualCarga = value; }
        }


        public string Material
        {
            get { return material; }
            set { material = value; }
        }


        public bool Estourada
        {
            get { return estourada; }
            set { estourada = value; }
        }


        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }


        public bool Tampada
        {
            get { return tampada; }
            set { tampada = value; }
        }

        public Caneta(string _cor, string _marca, int _percentualCarga, string _material)
        {
            cor = _cor;
            marca = _marca;
            percentualCarga = _percentualCarga;
            material = _material;
        }

        public void escrever(string _texto)
        {
            if (tampada)
            {

                Console.WriteLine("A caneta está tampada.");
                return;

            }
            if (caida)
            {
                Console.WriteLine("Pegue a caneta do chão.");
                return;
            }
            if (estourada)
            {
                Console.WriteLine("A caneta está estourada :( ");
            }
            Console.WriteLine(_texto);
        }
        private void gastarTinta()
        {
            percentualCarga -= 10;
        }
        public void exibir()
        {
            Console.WriteLine("Cor: " + cor);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("% de carga: " + percentualCarga);
            Console.WriteLine("Material: " + material);
            Console.WriteLine("Tampada: " + tampada);

        }
    }
}