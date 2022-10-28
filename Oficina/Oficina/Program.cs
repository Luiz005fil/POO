using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro corcel = new Carro("Chevrolet", "2");
        corcel.LigarDesligar();
        corcel.Acelerar(5);
        corcel.Abastecer(50);
        corcel.Frear(30);
        corcel.Acelerar(500);
        corcel.Frear(300);
        corcel.Acelerar(500);
        corcel.Frear(200);
        corcel.Exibir();

    }
}