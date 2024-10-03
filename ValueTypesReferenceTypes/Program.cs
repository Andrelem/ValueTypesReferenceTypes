using static System.Console;

public class Progam
{
    static void Demo1()
    {
        int a = 52;
        a = Adicionar20(a);
        WriteLine($"O valor da varia sera {a}");
    }
    static int Adicionar20(int a)
    {
        return a + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    public static void Main()
    {
        Pessoa p1 =  new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "12345";

        TrocarNome(p1,"Paulo");

        WriteLine($"Seu novo nome é: {p1.Nome}");
    }
}