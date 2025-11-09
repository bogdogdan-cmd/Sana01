Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.Write("Введіть a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введіть b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введіть c: ");
double c = double.Parse(Console.ReadLine());

Console.Write("Введіть d: ");
double d = double.Parse(Console.ReadLine());

double x = (a + 2 * b - c + d) / (c * d)+ (a + b) / (Math.Pow(c, 2))- Math.Pow(b, 2) / (2 * a);

double y = (5 * (a + b) * (c - d)) / (Math.Pow(c, 2) - 2 * c * d + Math.Pow(d, 2))- (Math.Pow(b, 2) - 2 * Math.Pow(b, 2)) / (b - a);

double z = (Math.Pow(Math.Pow(a, 2) - 2 * a, 3) - 4 * (Math.Pow(a, 4) + 1)) * (1 - b)/ 5 * a + 3 * b;

double r = (Math.Pow(a, 2) + Math.Pow(b, 2)) / (3 * c + 1) + (1 / (a - c));
Console.WriteLine("Значення x = {0}, y = {1}, z = {2}, r = {3}", x, y, z, r);



