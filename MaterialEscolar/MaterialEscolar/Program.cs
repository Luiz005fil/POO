using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Models.Caneta caneta = new Models.Caneta("Preto","Bic",100,"Plastico");

        caneta.escrever("Luiz");
        //caneta.exibir();

        Lapis lapis = new Lapis("2B");
        lapis.QuebrarPonta();
        lapis.Escrever("Teste");

    }
}