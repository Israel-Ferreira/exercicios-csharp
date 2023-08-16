// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Informe o seu salário atual: ");
double salarioAtual = double.Parse(Console.ReadLine()!);

double salarioComReajuste = ReajustarSalario(salarioAtual);

Console.WriteLine($"Salário Atual: {salarioAtual}");
Console.WriteLine($"Salário com Reajuste: {salarioComReajuste}");



double ReajustarSalario(double currentSalary)
{
    double incrementValue =  200.00;
    if(currentSalary < 1700.00)
    {
        incrementValue = 300.00;
    }
    
    return currentSalary + incrementValue;
}