using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Models
{
    public class Apontador
    {
        private string cor;
        private int tamanho;
        private string marca;
        private bool laminaAfiada;


        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }


        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }


        public bool LaminaAfiada
        {
            get { return laminaAfiada; }
            set { laminaAfiada = value; }
        }




        public Apontador(string _cor, int _tamanho, string _marca)
        {
            Cor = _cor;
            Tamanho = _tamanho;
            Marca = _marca;
            laminaAfiada = true;
        }

        public void Apontar()
        {
            if (LaminaAfiada == false)
            {
                Console.WriteLine("não é possível apontar, a lâmina não está afiada");
                return;
            }
            LaminaAfiada = true;


        }

        public void Afiar(bool _laminaAfiada)
        {
            if (LaminaAfiada == false)
            {
                Console.WriteLine(" a lâmina não está afiada)");
                return;
            }
            LaminaAfiada = true;
        }
    }

}