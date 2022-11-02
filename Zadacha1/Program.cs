Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];
int temp = number;

for (int i = 0; i<array.Length; i++)
{
    number = temp;
    array[i] = number %= 10;
    temp /= 10;
}

if (array[0] == array[4] && array[1] == array[3]) 
{ 
    Console.WriteLine("Является палиндромом"); 
}
else 
{ 
    Console.WriteLine("Не является палиндромом"); 
}
