using ExemploDelegate.Entities;

Calcular somar = Calculadora.Somar;
Calcular subtrair = Calculadora.Subtrair;
Calcular dividir = Calculadora.Dividir;
Calcular multiplicar = Calculadora.Multiplicar;

while(true)
{
    System.Console.WriteLine("Informe a operacao: ");
    System.Console.WriteLine(
        """
            [1] - Somar;
            [2] - Subtrair;
            [3] - Dividir;
            [4] - Multiplicar;

        """);

    var operacao = Console.ReadLine();

    System.Console.WriteLine("Primeiro numero: \n");
    var n1 = int.Parse(Console.ReadLine()!);
    
    System.Console.WriteLine("Segundo numero: \n");
    var n2 = int.Parse(Console.ReadLine()!);

    var result = operacao switch 
    {
        "1" => somar(n1, n2),
        "2" => subtrair(n1, n2),
        "3" => dividir(n1, n2),
        "4" => multiplicar(n1, n2),
        _ => 0
    };
    
    System.Console.WriteLine($"Resultado: {result}\n\n");
}
delegate int Calcular(int n1, int n2);