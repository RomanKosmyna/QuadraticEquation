public class Discriminant
{
    private double _a;
    private double _b;
    private double _c;

    public Discriminant()
    {
        GetFactor();
    }

    public void GetFactor()
    {
        try
        {
            Console.Write("Enter A factor value: ");
            double a = double.Parse(Console.ReadLine());
            _a = a;

            Console.Write("Enter B factor value: ");
            double b = double.Parse(Console.ReadLine());
            _b = b;

            Console.Write("Enter C factor value: ");
            double c = double.Parse(Console.ReadLine());
            _c = c;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public double GetDiscriminant()
    {
        double discriminant = Math.Pow(_b, 2) - 4 * _a * _c;

        return discriminant;
    }

    public void EvaluateDiscriminant(double discriminant)
    {
        if (discriminant > 0)
        {
            double x1 = (-_b + Math.Sqrt(discriminant)) / (2 * _a);
            double x2 = (-_b - Math.Sqrt(discriminant)) / (2 * _a);

            Console.WriteLine($"Два різних реальних корені: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -_b / (2 * _a);

            Console.WriteLine($"Один реальний корінь (кратності 2): x = {x}");
        }
        else
        {
            double realPart = -_b / (2 * _a);
            double imaginaryPart = Math.Sqrt(Math.Abs(discriminant)) / (2 * _a);

            Console.WriteLine($"Два комплексних корені: x1 = {realPart} + {imaginaryPart}i, x2 = {realPart} - {imaginaryPart}i");
        }
    }
}