#region Calculadora de Faltas
/*
//Se o aluno tiver mais que 3 falta
//Rodo

//Se a nota do aluno for menor que 60
//Rodo também

int nota;
int faltas;
string acao;

Console.WriteLine("Você deseja ver se foi aprovado s/n?");
acao = Console.ReadLine();

while (acao == "s")
{
    Console.WriteLine("Insira a média do aluno:");
    nota = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira a quantidade de faltas:");
    faltas = Convert.ToInt32(Console.ReadLine());

    if (nota < 60 || faltas > 3)
    {
        Console.WriteLine("Reprovado");
    }
    else
    {
        Console.WriteLine("Aprovado");
    }

    Console.WriteLine("Você deseja continuar s/n?");
    acao = Console.ReadLine();

    if (acao != "s")
    {
        break;
    }
    else
    {
        Console.Clear();
    }
}
*/
#endregion

#region Estruturas de Repetição
/* FOR
int contador = 0;
int tabuada;

Console.WriteLine("Informe a tabuada desejada:");
tabuada = Convert.ToInt32(Console.ReadLine());

for(contador = 0; contador <= 10; contador ++)
{
    Console.WriteLine
        (
            $"{tabuada} x {contador} = {(tabuada * contador)}"
        );
}
*/

/* WHILE
int contador = 0;

while (contador < 10)
{
    Console.WriteLine(contador++);
}
*/

/* DO WHILE
int contador = 0;

do
{
    Console.WriteLine(contador);
    contador++;
}
while (contador < 10);
*/

/* FOREACH
string[] nomes = { "Abacaxi", "Maçã", "Banana" };
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);

int[] numeros = { 5, 10, 15 };

foreach(int i in numeros)
{
    Console.WriteLine(i);
}

string[] cores = {"Vermelho", "Azul", "Verde"};

foreach(cores i in cores)
{
    Console.WriteLine(i);
}

*/

#endregion

#region Funções
/*
int idadeAluno;

bool MaiorDeIdade(int idade)
{
    if (idade >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
};

void MaiorDeIdade2(int idade)
{
    if (idade >= 18)
    {
        Console.WriteLine("O aluno é maior de idade!");
    }
    else
    {
        Console.WriteLine("O aluno é menor de idade!");
    }
}
;

Console.WriteLine("Informe sua idade:");
idadeAluno = Convert.ToInt32(Console.ReadLine());

if (MaiorDeIdade(idadeAluno) == true)
{
    Console.WriteLine("O aluno é maior de idade");
} else
{
    Console.WriteLine("O aluno é menor de idade");
}

MaiorDeIdade2(15);
*/
#endregion

#region Funções 2
//Função para somar do tipo void
//Função que retorne a multiplicação Resultado int

int num1;
int num2;

void Soma(int num1, int num2)
{
    Console.WriteLine($"A soma é {num1 + num2}");
}

Soma(10, 10);

int Mult(int num1, int num2)
{
    return num1 * num2;
}
int resultado = Mult(10, 10);
Console.WriteLine($"O resultado da multiplicação é {resultado}");


#endregion