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
}