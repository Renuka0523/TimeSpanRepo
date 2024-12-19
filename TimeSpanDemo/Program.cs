namespace TimeSpanDemo
{
    internal class Program
    {
        //creating
        static void Main(string[] args)
        {
            var timespan = new TimeSpan(1, 2, 3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespane2 = TimeSpan.FromHours(1);

            

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration:" + duration);

            //properties

            Console.WriteLine("timespan: " + timespan.Minutes);
            Console.WriteLine("Total Timespan: " + timespan.TotalMinutes);

            //Add

            Console.WriteLine("Add TimeSpan: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Timespan: " + timespan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("Conver ToString: " + timespan.ToString());

            //perse

            Console.WriteLine("perse: " + TimeSpan.Parse("01:02:03"));
        
        }
    }
}
