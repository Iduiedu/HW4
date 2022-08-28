// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите целое положительное число");
string ? number = Console.ReadLine();
int i = 0;
int sum = 0;
if (number!=null){
    do 
    {
        sum+=Convert.ToInt32(number[i].ToString());
        i++;
    }
    while (i<=number.Length-1);
    Console.WriteLine("Сумма цифр числа " + sum);
}