//Напишите метод, который принимает на вход два числа (A и B) и 
//возводит число A в целую степень B

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result =a;
for (int i = 1 ; i<b ; i++)
{
    result=result*a;    
}
Console.WriteLine(result);