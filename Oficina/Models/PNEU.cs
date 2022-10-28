namespace Models
{
    public class Pneu
    {
        private string marca;
        private int aro;
        private bool furado;
        private int psi;
        private bool estourado;
        private double percentualBorracha;
        private int rotacao;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Aro
        {
            get { return aro; }
            set { aro = value; }
        }

        public bool Furado
        {
            get { return furado; }
            set { furado = value; }
        }

        public int Psi
        {
            get { return psi; }
            set { psi = value; }
        }

        public bool Estourado
        {
            get { return estourado; }
            set { estourado = value; }
        }

        public double PercentualBorracha
        {
            get { return percentualBorracha; }
            set { percentualBorracha = value; }
        }

        public int Rotacao
        {
            get { return rotacao; }
            set { rotacao = value; }
        }


        public Pneu(int aro, string marca)
        {
            Aro = aro;
            Marca = marca;
            Furado = false;
            psi = 33;
            estourado = false;
            percentualBorracha = 100;
            Rotacao = 0;
        }

        public void Girar(int _rotacao)
        {
            if (Furado || Estourado)
                return;

            Rotacao += _rotacao;
            GastarBorracha(_rotacao / 100.0);
        }

        public void Furar()
        {
            Furado = true;
            Psi = 0;
        }

        private void GastarBorracha(double _quantidade)
        {
            PercentualBorracha -= _quantidade;
            if (PercentualBorracha <= 0)
                Estourar();
        }

        private void Estourar()
        {
            Estourado = true;
            Psi = 0;
            PercentualBorracha = 0;
            Rotacao = 0;
        }

        public void Freiar(int _abatimento)
        {
            Rotacao -= _abatimento;
            GastarBorracha(_abatimento / 100);
        }

        public void Remendar()
        {
            Furado = false;
            Psi = 33;
        }

        public void Exibir()
        {
            Console.WriteLine("marca: " + Marca);
            Console.WriteLine("aro: " + Aro);
            Console.WriteLine("furado: " + Furado);
            Console.WriteLine("psi: " + Psi);
            Console.WriteLine("estourado: " + Estourado);
            Console.WriteLine("percentualBorracha: " + PercentualBorracha);
            Console.WriteLine("rotacao: " + Rotacao);
        }
    }
}