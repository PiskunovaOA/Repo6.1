// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] numbers = new int[10];
FillArray(numbers);
PrintNumber(numbers);
PrintArray(numbers);


void PrintNumber (int[] number)

{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
{
    if (number[i] > 0) count ++;
}
    Console.WriteLine($" Колличество чисел больше 0: {count}");
}

void FillArray(int[] number)
{
for(int i = 0; i < number.Length; i++)
{
number[i] = new Random().Next(0,10);
}
}

void PrintArray(int[] number)
{
for(int i = 0; i < number.Length; i++)
{
Console.Write(number[i] + " ");
}
}