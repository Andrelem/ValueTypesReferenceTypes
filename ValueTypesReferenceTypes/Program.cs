using static System.Console;

public class Progam
{
    static void Demo6()
    {
         int[] numeros = new int[] {0,2,4,6,8};
        WriteLine($"Digite o numero que gostaria de procurar:");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros,numero);
      
        if(idxEncontrado >= 0)
        {
            WriteLine($"O numero digitado esta na posicao {idxEncontrado}");

        }
        else
        {
            WriteLine("O numero digitado nao foi encontrado!");
        }
    }
    static void Demo5()
    {
        int[] pares = new int[]{0,2,4,6,8};

       MudarParaImpar(pares);

       WriteLine($"Os impares {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Carlos";

       TrocarNome(nome, "Vitor");

       WriteLine($"O novo nome é {nome}");
    }
    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "1234",
            Idade = 30,
            Nome = "Ricardo"
        };
        
        var p2 = p1;

        p1 = TrocarNome(p1, "Mario");

        WriteLine($@"
         Nome do p1 {p1.Nome}
         nome do p2 {p2.Nome}
        ");
    }
    static void Demo2()
    {
        Pessoa p1 =  new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "12345";

        Pessoa p2 = p1.Clone();
        
        TrocarNome(p1,"Paulo");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        o nome de p2 é: {p2.Nome}
        ");
    }
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

    static StructPessoa TrocarNome(StructPessoa p1 ,string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }

    static void TrocarNome(string nome,string nomeNovo)
    {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumero(int[] numeros,int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
            return i;
        }
        return -1;
    }

    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
    {
        foreach (var item in pessoas)
        {
             if(item.Equals(pessoa))
             {
                return true;
             }
        }
        return false;
    }
    public static void Main()
    {
        List<StructPessoa> pessoas = new List<StructPessoa>()
        {
            new StructPessoa(){Nome = "Lopes"},
            new StructPessoa(){Nome = "Victor"},
            new StructPessoa(){Nome = "Maria"},
            new StructPessoa(){Nome = "Sabrina"},
            new StructPessoa(){Nome = "Heitor"},
            new StructPessoa(){Nome = "Carol"}
        };
        
        WriteLine("Digite a pessoa que queira localizar:");
        var nome = ReadLine();
        var pessoa = new StructPessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if(encontrado)
        {
            WriteLine("Pessoa localizada!");
        }
        else
        {
            WriteLine("Pessoa não localizada");
        }
    }
}