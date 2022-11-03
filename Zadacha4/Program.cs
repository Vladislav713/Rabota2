//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int[10];
int temp = a;
int result=0;

for (int i = 0; i<array.Length; i++)
{
    a = temp;
    array[i] = a %= 10;
    temp /= 10;
    result=array[i]+result;
}
Console.WriteLine(result);