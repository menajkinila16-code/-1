Console.WriteLine("введети конечное значение ");
double x = Convert.ToDouble(Console.ReadLine ());
double S = 0;
for(double i=1; i <= x; i++)
{

    S += i / (i++);

}
Console.WriteLine(S );


