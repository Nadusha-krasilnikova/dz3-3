// возвести число А в степень В
Console.WriteLine("введите число которое надо возвести в степень ");
 int a =int.Parse(Console.ReadLine());
Console.WriteLine("введите степень ");
int b=int.Parse(Console.ReadLine());
double distance;
distance=Math.Pow(a,b);
Console.WriteLine($"число в степени = {distance}");