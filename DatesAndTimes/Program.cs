namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {




            DateTime myValue = DateTime.Now;
            // Console.WriteLine(myValue.ToString());
            // Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            // Console.WriteLine(myValue.ToLongTimeString());

            // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            // Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            // Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            // Console.WriteLine(myValue.Month);


            // DateTime myBirthday = new DateTime(1995,12,31);
            // Console.WriteLine(myBirthday.ToShortDateString());


            DateTime myBirthday = DateTime.Parse("03/06/1995");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("Age in days: ");
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }

}
