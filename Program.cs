using System.Reflection.Emit;

class Program
    {
    static void Main(string[] args)
    {
        int[] numeros = new int[0];
        int opc;
        Console.Clear();
        do{
            opc = Menu();
            switch (opc)
            {
                case 1: 
                    Console.Clear();
                    ListaVetor(numeros); 
                    break;
                case 2:
                    Console.Write("Digite o número: ");
                    int numero = Convert.ToInt32(Console.ReadLine()); 
                    AdicionaNumeroVetor(numero, ref numeros);
                    Console.Clear();
                    ListaVetor(numeros);
                    break;
                case 3:
                    ExibeNumerosPares(numeros);
                    Console.WriteLine();
                    break;
                case 4:
                    ExibeNumerosImpares(numeros);
                    Console.WriteLine();
                    break;
                case 5:
                    double mediana = ExibeMedianaVetor(numeros);
                    if(mediana != 0){
                        Console.WriteLine("Valor da mediana: " + mediana);
                    }
                    Console.WriteLine();

                    break;
                case 6:
                    ExcluiUltimoNumero(ref numeros);
                    Console.Clear();
                    ListaVetor(numeros);
                    break;
                case 7:
                    break;
                default: 
                    Console.Clear();
                    Console.WriteLine("Opção inválida: " + opc); 
                    Console.WriteLine();
                    break;
            }
        }while (opc != 7);

    }

    static int Menu()
    {
        int opc;
        Console.WriteLine("1 - Listar Vetor");
        Console.WriteLine("2 - Adicionar número ao vetor");
        Console.WriteLine("3 - Exibir apenas os números pares do vetor");
        Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
        Console.WriteLine("5 - Exibir a mediana do vetor");
        Console.WriteLine("6 - Excluir o último número do vetor");
        Console.WriteLine("7 - Sair");
        Console.Write("Digite a opção desejada: ");
        opc = Convert.ToInt32(Console.ReadLine());
        return opc;  
    }

    static void ListaVetor(int[] numeros)
    {
        if (numeros.Count() == 0)
        {
            Console.WriteLine("Vetor Vazio!");
            Console.WriteLine();
        }else{
            numeros.ToList().ForEach(p => Console.WriteLine("Valor: " + p.ToString()));
            Console.WriteLine();
        }
    }

    static void AdicionaNumeroVetor(int numero, ref int[] numeros)
    {
        int[] numerosC = new int[numeros.Length + 1];
        for (int i = 0; i < numeros.Length; i++)
        {
            numerosC[i] = numeros[i];
        }

        numerosC[numerosC.Length-1] = numero;
        numeros = new int[numerosC.Length];
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = numerosC[i];
        }
    }

    static void ExibeNumerosPares(int[] numeros)
    {
        Console.Clear();
        if (numeros.Count() == 0)
        {
            Console.WriteLine("Vetor Vazio!");
        }else{
            int control = 0;
            foreach (var item in numeros)
            {
                if (item % 2 == 0)
                {
                    control++;
                    Console.WriteLine("Valor: " + item);
                }
            }
            if (control == 0)
                {
                    Console.WriteLine("Vetor não contém números pares!");
                }
        }
    }

    static void ExibeNumerosImpares(int[] numeros)
    {
        Console.Clear();
        if (numeros.Count() == 0)
        {
            Console.WriteLine("Vetor Vazio!");
        }else{
            int control = 0;
            foreach (var item in numeros)
            {
                if (item % 2 != 0)
                {
                    control++;
                    Console.WriteLine("Valor: " + item);
                }
            }
            if (control == 0)
                {
                    Console.WriteLine("Vetor não contém números ímpares!");
                }
        }
    }

    static double ExibeMedianaVetor(int[] numeros)
    {
        Console.Clear();
        double mediana = 0;
        if (numeros.Count() == 0)
        {
            Console.WriteLine("Vetor Vazio!");
        }else{
            int[] medianaSort = new int[numeros.Length];
            for (int i = 0; i < medianaSort.Length; i++)
            {
                medianaSort[i] = numeros[i];
            }
            Array.Sort<int>(medianaSort);
            int tam = medianaSort.Length;
        
            if (tam % 2 == 0)
            {
                tam = tam / 2;
                mediana = (medianaSort[tam - 1] + medianaSort[tam]) / 2.0;
            }else {
                tam = (tam + 1) / 2;
                mediana = medianaSort[tam - 1];
            }
        }

        return mediana;
    }

    static void ExcluiUltimoNumero(ref int[] numeros)
    {
        if (numeros.Count() == 0)
        {
            Console.WriteLine("Vetor Vazio!");
        }else{
            int[] numerosC = new int[numeros.Length - 1];
            for (int i = 0; i < numerosC.Length; i++)
            {
                numerosC[i] = numeros[i];
            }

            numeros = new int[numerosC.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numerosC[i];
            }
        }
    }

}


