using bytebank_ATENDIMENTO.bytebank.Atendimento;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region ExemplosArrays
// TestaArrayInt();
// TestaBuscarPalavra();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array: {idades.Length}");

    int acumulador = 0;
    for(int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"No índice [{i}] a idade é {idades[i]}");
        acumulador += idades[i];
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"A média das idades é: {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for(int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite a {i + 1}ª palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada");
    string busca = Console.ReadLine();

    foreach(string palavra in arrayDePalavras)
    {
        if(palavra.Equals(busca))
        {
            Console.WriteLine("Palavra encontrada");
            break;
        }
    }
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
// [5.9], [1.8], [7.1], [10], [6.9]

// for(int i = 0; i < amostra.Length; i++)
// {
//     Console.WriteLine(amostra.GetValue(i));
// }

// TestaMediana(amostra);

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    // [1.8], [5.9], [6.9], [7.1], [10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana é {mediana}");
}

// void TestaArrayDeContasCorrentes()
// {
    // ContaCorrente[] listaDeContas = new ContaCorrente[]
    // {
    //     new ContaCorrente(874, "4545457-A"),
    //     new ContaCorrente(874, "5586548-B"),
    //     new ContaCorrente(874, "6658149-C")
    // };

    // for(int i = 0; i < listaDeContas.Length; i++)
    // {
    //     ContaCorrente contaAtual = listaDeContas[i];
    //     Console.WriteLine($"Índice{i} - Conta: {contaAtual.Conta}");
    // }

    // ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

    // listaDeContas.Adicionar(new ContaCorrente(874, "4545457-A"));
    // listaDeContas.Adicionar(new ContaCorrente(874, "5586548-B"));
    // listaDeContas.Adicionar(new ContaCorrente(874, "6658149-C"));
    // var contaTeste = new ContaCorrente(874, "5586548-G");
    // listaDeContas.Adicionar(contaTeste);
    // listaDeContas.Adicionar(new ContaCorrente(874, "4545457-D"));
    // listaDeContas.Adicionar(new ContaCorrente(874, "5586548-E"));
    // listaDeContas.Adicionar(new ContaCorrente(874, "6658149-F"));

    // listaDeContas.ExibeLista();
    // listaDeContas.Remover(contaTeste);
    // Console.WriteLine("Lista atualizada após exclusão.");
    // listaDeContas.ExibeLista();
    // listaDeContas.Remover(ContaCorrente("4545457-D"));


//     for(int i = 0; i < listaDeContas.Tamanho; i++)
//     {
//         ContaCorrente conta = listaDeContas[i];
//         Console.WriteLine($"Índice [{i}] - Conta {conta.Conta} / {conta.Numero_agencia}");
//     }
// }

// TestaArrayDeContasCorrentes();
#endregion

new ByteBankAtendimento().AtendimentoCliente();