using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Borracha
    {
        private string cor;
        private string marca;
        private int percentualBorracha;

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


        public int PercentualBorracha
        {
            get { return percentualBorracha; }
            set { percentualBorracha = value; }
        }

        private bool apagado;

        public bool Apagado
        {
            get { return apagado; }
            set { apagado = value; }
        }


        public Borracha(string _cor, string _marca)
        {
            Cor = _cor;
            Marca = _marca;
            percentualBorracha = 100;
            apagado = false;

        }

        public void Apagar(bool _apagado)
        {
            apagado = true;

            if (PercentualBorracha == 0)
            {
                Console.WriteLine("A borracha acabou,compre outra");
                return;
            }

            if (apagado == true)
            {
                PercentualBorracha -= 1;
                return;
            }
        }


    }
}