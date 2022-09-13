using System.Diagnostics.CodeAnalysis;
Console.WriteLine(Add(2,29));
Console.WriteLine(Multiply(2, 29));
Console.WriteLine(Subtract(29,2));
static int Add(int num1, int num2)
{
        return num1 + num2;
}
static int Multiply(int num1, int num2)
{
    return num1 * num2;
}
static int Subtract (int num1, int num2)
{
    return num1 - num2;
}
