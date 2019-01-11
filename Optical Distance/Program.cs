

namespace Optical_Distance
{
    class Program
    {

        static long LightDistance(int time)
        {
            long Distance=0;

            Distance = time * 300000;

            System.Console.WriteLine();

            if (time<=60)
            {

                System.Console.WriteLine
                    ("The distance that light travels in time {0} second/seconds is equal to: {1} Km", time, Distance.ToString("n0"));
                
            }

            else if (time>60)
            {
                
                System.Console.WriteLine
                    ("The distance to which light lasted for {0} minute/minutes: {1} Km", time/60, Distance.ToString("n0"));

             
            }

            else if (time>=3600)
            {

                System.Console.WriteLine
                    ("The distance to which light lasted for {0} houre/houres: {1} Km", time/3600, Distance.ToString("n0"));

             
            }

            return Distance;



        }



        static void Main(string[] args)
        {
            int TimeSec,TimeMin,TimeHur,TimeDay,TimeWek,TimeMon,TimeYer,TimeCnt;

            string SelectTime;

            System.Console.WriteLine("        ========Determine the distance traveled by light========");

            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("Please specify the time unit.");
            System.Console.WriteLine();

            do
            {
                System.Console.Write
                ("Secod[1], " + "Minute[2], " + "Hour[3], " +
                "Day[4], " + "Week[5], " + "Month[6], " +
                "Year[7], " + "Centuries[8]: ");
                SelectTime = System.Console.ReadLine();


                switch (SelectTime)
                {
                    case "1":

                        System.Console.WriteLine();
                        System.Console.Write("Please enter the SECONDS: ");
                        TimeSec = int.Parse(System.Console.ReadLine());

                        LightDistance(TimeSec);
                        System.Console.WriteLine();

                        break;

                    case "2":

                        System.Console.WriteLine();
                        System.Console.Write("Please enter the MINUTES: ");
                        TimeMin = int.Parse(System.Console.ReadLine());

                        TimeMin = TimeMin * 60;

                        LightDistance(TimeMin);
                        System.Console.WriteLine();

                        break;

                    case "3":

                        System.Console.WriteLine();
                        System.Console.Write("Please enter the HOURES: ");
                        TimeMin = int.Parse(System.Console.ReadLine());

                        TimeMin = TimeMin * 3600;

                        LightDistance(TimeMin);
                        System.Console.WriteLine();

                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                    case "6":

                        break;

                    case "7":

                        break;

                    case "8":

                        break;

                }

            } while (true);










            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }
}
