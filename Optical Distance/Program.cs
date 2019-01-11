

namespace Optical_Distance
{
    class Program
    {

        static long LightDistance(int time)
        {
            long Distance=0;

            Distance = time * 300000;

            System.Console.WriteLine();

            System.Console.WriteLine("The distance to which light lasted for {0} seconds: {1} Km",time, Distance);

            return Distance;

            
        }



        static void Main(string[] args)
        {
            int Time;

            string SelectTime;

            System.Console.WriteLine("        ========Determine the distance traveled by light========");

            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("Please specify the time unit.");
            System.Console.WriteLine();
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
                    Time = int.Parse(System.Console.ReadLine());

                    LightDistance(Time);


                    break;
                
                
                
                    


            }











            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }
}
