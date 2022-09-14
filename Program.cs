Double a, t, D;
Console.Write("Введите a:");
a = int.Parse(Console.ReadLine());
Console.Write("Ввелите t:");
t = int.Parse(Console.ReadLine());
D = 9.8 * (a * a) + 5.52 * Math.Cos(t * t * t * t * t);
Console.WriteLine($"{D:F2}");