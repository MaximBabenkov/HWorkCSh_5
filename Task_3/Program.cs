// Написать программу копирования массива
int[]arr1 = new int[8];
for (int i=0;i<arr1.Length;i++)
{   
    arr1[i]=new Random().Next(0,10);
    Console.Write($"{arr1[i]} ");
    
}
Console.WriteLine();
int[]arr2 = new int[8];
for (int i=0;i<arr2.Length;i++)
{
    arr2[i]=arr1[i];
    Console.Write($"{arr2[i]} ");
}
