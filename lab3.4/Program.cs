using Lab34;

namespace Lab34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(500, "FAX", "TM");
            Console.WriteLine(invoice.CalculateValueOrder());
        }
    }
}