Console.WriteLine("ведите конечное число ");
double x = Convert.ToDouble(Console.ReadLine());
double i = 1;
double S = 0;
while (i <= x)
{
    i++;
    S += i / (i++);

}
Console.WriteLine(S);