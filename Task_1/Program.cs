 //Найти точку пересечения двух прямых,заданных уравнением y=k1*x+b1, y=k2*x+b2
Console.Write("Enter your first slope: ");
int k1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your first y-intercept: ");
int b1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your second slope: ");
int k2 = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your second y-intercept: ");
int b2 = int.Parse(Console.ReadLine()??"0");
int x=0;
int y=0;
if (k1!=k2)
{
    x=b2-b1/k1-k2; 
    y=k1*(b2-b1/k1-k2)+b1;
    Console.Write($"The point of intersection: ({x},{y})");
}  
else
{
    Console.Write($"These lines are parallel or identical");
}
