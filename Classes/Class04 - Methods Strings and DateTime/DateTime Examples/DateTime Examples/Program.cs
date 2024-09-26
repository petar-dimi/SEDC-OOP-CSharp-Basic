using System.Globalization;
using System.Text;

namespace DateTime_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime date = new DateTime();
            DateTime date2 = new DateTime(2024, 3, 6);
            DateTime date3 = new DateTime(2024, 3, 6, 10, 30, 50);
            DateTime date4 = DateTime.Now;
            DateTime date5 = DateTime.UtcNow;
            DateTime date6 = date3.AddDays(1);
            Console.WriteLine(date6.DayOfWeek);
            DateTime date7 = date3.AddDays(-1);
            Console.WriteLine(date7.DayOfWeek);
            // format and printting

            Console.WriteLine(date3);
            Console.WriteLine(date3.ToString());
            Console.WriteLine(date3.ToString("ddd*MMMM*yyyy HH-mm-ss zz"));
            Console.WriteLine(date3.ToString(new CultureInfo("en-US")));


        }
    }
}
