int dividendo, divisor, resto;

Console.WriteLine("máximo divisor comun (método iterativo\n");

Console.Write("digite o primeiro numero (a)...: ");
dividendo = Convert.ToInt32(Console.ReadLine());

Console.Write("digite o segundo numero (b)...: ");
divisor = Convert.ToInt32(Console.ReadLine());

do
{
    resto = dividendo % divisor;
    dividendo = divisor;
    divisor = divisor = resto;

} while (resto != 0);

Console.WriteLine($"MDC (a,b) = {dividendo}");