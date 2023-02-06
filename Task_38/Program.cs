double [] FillArray(int length, int start, int end)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1)/(new Random().Next(-100,100)+0.0);
    }
    return array;
}

void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int getUserData(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
double getMinAndMaxNumbers(double[] array)
{
    double min = array [0];
    double max = array [0];
    double result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        min = array[i];
    
        if (max < array[i])
        max = array[i];
        
        if(min<0)
        min=min*-1;
        result =  max-min;
    }
    return result;
}
int number = getUserData("Введите количество элементов массива");
double [] array = FillArray(number, -1000, 1000);
printArray(array);
double Dif = getMinAndMaxNumbers (array);
Console.WriteLine(Dif);






