namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            StopWatch stopWatch = new StopWatch();

            //for (int i = 0; i < 4; i++) // run the stop watch 4 times.
            //{
            //    stopWatch.Start();
            //    Thread.Sleep(1000);
            //    stopWatch.Stop();
            //    Console.WriteLine(stopWatch.GetTime());
            //    Console.WriteLine("Enter to run agein.");
            //    Console.ReadKey();
            //}
            
            //Run the stop watch only one time.
            stopWatch.Start();
            Thread.Sleep(1000);
         //   stopWatch.Start();

            stopWatch.Stop();
            Console.WriteLine(stopWatch.GetTime());
        }
    }
}