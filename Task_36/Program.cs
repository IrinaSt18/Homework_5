/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int [] FillArray(int length,int start, int end)
{
int [] array = new int [length];
for (int i = 0; i < length; i++)
{
  array[i] = new Random().Next(start, end +1);  
}
return array;
}
int getUserData(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
int getSum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i%2 != 0)
       {
        sum+=array[i];
       } 
    }
    return sum;
}
void printArray(int []array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i]);
       if(i < array.Length - 1)
       {
        Console.Write(",");
       } 
    }
    Console.WriteLine("]");
}
int number = getUserData("Введите количество элементов массива");
int []array = FillArray(number, -10,10);
printArray(array);
int Sum = getSum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {Sum}");


