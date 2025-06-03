#region Comparar idades
/*

int idade;
Console.WriteLine("Informe sua idade!");

idade = Convert.ToInt32
(
    Console.ReadLine();
);

if (idade >= 18)
{
    Console.WriteLine($"Sua idade é {idade}, você é maior de idade");
}
else
{
    Console.WriteLine($"Sua idade é {idade}, você é menor de idade");
}

//Console.WriteLine($"Sua idade é {idade}");
*/
#endregion

#region Salário mínimo ou salário comum
/*

const decimal salarioMinimo = 1518m;
decimal salarioUsuario;

Console.WriteLine("Informe seu salário:");

salarioUsuario = decimal.Parse
(
    Console.ReadLine()
);

if (salarioUsuario == salarioMinimo)
{
    Console.WriteLine($"O usúario recebe o salário mínimo. {salarioUsuario:C}");
}
else
{
    Console.WriteLine($"O usúario NÃo recebe o salário mínimo. {salarioUsuario:C}");
};
*/
#endregion

#region Variáveis
    float num1 = 0f;
    float num2 = 0f;
    string operacaoMatematica;
    string opcao;

while (true) { 
    Console.WriteLine("Informe a operação desejada: \n" + "'+' para adição | '-' para subtração | '*' para multiplicação | '/' para divisão");

    operacaoMatematica = Console.ReadLine();


    Console.WriteLine("Informe o primeiro valor");
    num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Informe o segundo valor");
    num2 = float.Parse(Console.ReadLine());
    #endregion

    #region Estrutura IF
    /*
        if (operacaoMatematica == "+")
        {
            Console.WriteLine($"Adição: {(num1 + num2):F2}");
        }
        else if (operacaoMatematica == "-")
        {
            Console.WriteLine($"Subtração: {(num1 - num2):F2}");
        }
        else if (operacaoMatematica == "*")
        {
            Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
        }
        else if (operacaoMatematica == "/")
        {
            Console.WriteLine($"Divisão: {(num1 / num2):F2}");
        }
    */
    #endregion

    #region Estrutura Switch

    switch (operacaoMatematica)
    {
        case ("+"):
            Console.WriteLine($"Soma: {(num1 + num2):F2}");
            break;

        case ("-"):
            Console.WriteLine($"Subtração: {(num1 - num2):F2}");
            break;

        case ("*"):
            Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
            break;

        case ("/"):
            Console.WriteLine($"Divisão: {(num1 / num2):F2}");
            break;
        default:
            Console.WriteLine($"Insira uma opção válida!");
            break;
    }

    Console.WriteLine("Deseja continuar s/n?");
    opcao = Console.ReadLine();

    if (opcao != "s")
    {
        break;
    }else
    {
        Console.Clear();
    }
}
#endregion
