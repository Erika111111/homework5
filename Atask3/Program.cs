// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[]myArray = {6.4, 5.8, 9.1, 1.4, 7.3};
PrintArray(myArray);
double max = myArray[0];
double min = myArray[0];
double sum = max - min;

for (int j = 0; j < myArray.Length; j++)
{
    if (myArray[j] > max)
    {
       max = myArray[j];
    }

    if (myArray[j] < min)
    {
        min = myArray[j];
    }
}


Console.WriteLine($"Разница {max} - {min} = {sum}");

void PrintArray(double[]myArray)
{
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
}
Console.WriteLine();