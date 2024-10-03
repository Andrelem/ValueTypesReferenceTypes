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

        Pessoa p2 = new Pessoa();
        p2.Documento = p1.Documento;
        p2.Nome = p1.Nome;
        p2.Idade = p1.Idade;
        
        TrocarNome(p1,"Paulo");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        o nome de p2 é: {p2.Nome}
        ");
    
    }
}