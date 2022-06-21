// Напишите цикл, который принимает на вход два числа (A и B) и возводит число А в натуральную степень В

int Prompt(string message)
{
System.Console.WriteLine(message);
string param = Console.ReadLine();
return int.Parse(param);
}

int A = Prompt("Введите A => ");
int B = Prompt("Введите B => ");

int result = 1;


for (int i = 1; i <= B; i++)
{
    result = result * A;
}

 Console.WriteLine($"Результат возведения числа А в степень В - {result}");