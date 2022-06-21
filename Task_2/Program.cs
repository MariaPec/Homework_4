// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);
int length = paramString.Length;

int [] array = new int[length];

int index = array.Length -1;

int sum = 0;

while (index >= 0)
{
   array[index] = paramInt % 10;
   paramInt = paramInt / 10;
   sum = array[index] + sum;
   index--;
}

Console.WriteLine($"{sum}");