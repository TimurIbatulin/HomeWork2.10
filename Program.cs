//Создаем метод для создания массива

void FAR(int[] mas,int z, int f)
{
    int index=0;
    while (index<mas.Length)
    {
        mas[index] = new Random().Next(z, f);
        index++;
    }
}
void Print(int[]mas)
{
    int i=0;
    while (i<mas.Length)
    {
        Console.Write($"{mas[i]} ");
        i++;
    }
}



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Введите желаемую длинну массива - ");
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr= new int[a];
// FAR(arr,100,1000);
// Print(arr);
// int i=0;
// int count=0;
// while (i<arr.Length)
// {
//     if (arr[i]%2==0)
//     {
//         count++;
//     }
//     i++;

// }
// Console.WriteLine();
// Console.Write($"В настоящем массиве {count} четных чисел");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Write("Введите желаемую длинну массива - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение диапазона чисел массива - ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона чисел массива - ");
int f = Convert.ToInt32(Console.ReadLine());
int [] arr= new int [a];
FAR(arr, z, f);
int i=1;
int sum=0;
while (i<arr.Length)
{
    sum=sum+arr[i];
    i=i+2;
}
Print(arr);
Console.WriteLine();
Console.Write($"Сумма чисел на нечетных позициях массива равна {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76