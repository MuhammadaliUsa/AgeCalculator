namespace Birth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birthYear, birthMonth, birthDay;
            Console.Write("Enter the your birthYear:");
            birthYear = int.Parse(Console.ReadLine());

            Console.Write("Enter the your birthMonth:");
            birthMonth = int.Parse(Console.ReadLine());

            Console.Write("Enter the your birthDay:");
            birthDay = int.Parse(Console.ReadLine());
            Console.WriteLine();

            DateTime dateTime = new DateTime(birthYear, birthMonth, birthDay);
            Console.WriteLine($"Your birth:{dateTime}");

            DateTime now = DateTime.Now;
            int nowYear = now.Year;
            int nowMonth = now.Month;
            int nowDay = now.Day;
            Console.WriteLine();
            Console.WriteLine($"Now time:{nowMonth}/{nowDay}/{nowYear}");
            Console.WriteLine();
            if (nowDay < birthDay)
            {
                nowDay += 31 - birthDay;
                nowMonth -= 1;
            }
            else
            {
                nowDay -= birthDay;
            }
            if (nowMonth < birthMonth)
            {
                nowMonth = nowMonth + 12 - birthMonth;
                nowYear -= 1;
            }
            else
            {
                nowMonth -= birthMonth;
            }
            nowYear -= birthYear;
            Console.WriteLine($"{nowYear} years {nowMonth} months {nowDay} days");

        }
    }
}