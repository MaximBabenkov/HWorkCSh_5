// Написать программу масштабирования фигуры
Console.WriteLine("Enter a height of rectangle");
int h = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter a width of rectangle");
int w = int.Parse(Console.ReadLine()??"0");
for (int i=0;i<h;i++)
{
    for (int j=0;j<w;j++)
    {
        Console.Write("@");
    }
    Console.WriteLine();
}
Console.WriteLine("Enter a zoom factor");
double k = double.Parse(Console.ReadLine()??"0");
for (int i=0;i<(h*k);i++)
{
    for (int j=0;j<(w*k);j++)
    {
        Console.Write("@");
    }
    Console.WriteLine();
}
