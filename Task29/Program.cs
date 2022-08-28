// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.WriteLine("Задайте размер массива числом");
int N = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[N];
for (int i = 0; i < N; i++)
{
    numbers[i]=Random.Shared.Next();
Console.Write(numbers[i] + " ");
}


