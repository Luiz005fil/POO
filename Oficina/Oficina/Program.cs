using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro corcel = new Carro("Chevrolet", "2");
        corcel.LigarDesligar();
        corcel.Acelerar(5);
        //corcel.Abastecer(50);
        corcel.Frear(30); 
        for (int i = 0; i == 10; i++)
        {
            corcel.Acelerar(100);
            corcel.Frear(50);


        }
        corcel.Exibir();
        

    }
}