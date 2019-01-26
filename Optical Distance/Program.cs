

namespace Optical_Distance
{
    class Program
    {

        static decimal LightDistance(decimal time)
        {
            //----Define the distance variable for which it has a zero value----
            
            decimal Distance =0;

            //----Determine the distance----
            Distance = time * 300000;

            System.Console.WriteLine();


            //-------------------------------------------------------------------------------------------------
            //----.دستور شرطی که با استفاده از پارامتر زمان مسافت طی شده نور در فضا را مشخص میکند-----
            //-------------------------------------------------------------------------------------------------

            if (time<60)
            {

                System.Console.WriteLine
                    ("The distance that light travels in time {0} Second/Seconds is equal to: {1} Km", time, Distance.ToString("n0"));
                
            }

            //-------------------------------------------------------------------------------------------------
            //-------------------------اگر زمان بین 60 ثانیه تا 3600 ثانیه باشد---------------------------
            //----------------------.مسافت طی شده نور در چند دقیقه را تعیین میکند-------------------------
            //-------------------------------------------------------------------------------------------------

            else if (time>=60 && time < 3600)
            {
                
                System.Console.WriteLine
                    ("The distance to which light lasted for {0} Minute/Minutes: {1} Km", time/60, Distance.ToString("n0"));

             
            }

            //-------------------------------------------------------------------------------------------------
            //-------------------------اگر زمان بین 3600 ثانیه تا 86400 ثانیه باشد------------------------
            //------------------------.مسافت طی شده نور در چند ساعت را تعیین میکند------------------------
            //-------------------------------------------------------------------------------------------------

            else if (time>=3600 && time < 86400)
            {

                System.Console.WriteLine
                    ("The distance to which light lasted for {0} Houre/Houres: {1} Km", time/3600, Distance.ToString("n0"));

             
            }

            //-------------------------------------------------------------------------------------------------
            //-------------------------اگر زمان بین 86400 ثانیه تا 604800 ثانیه باشد----------------------
            //-------------------------.مسافت طی شده نور در چند روز را تعیین میکند-------------------------
            //-------------------------------------------------------------------------------------------------

            else if (time >= 86400 && time < 604800)
            {

                System.Console.WriteLine
                    ("The distance to which light lasted for {0} Day/Days: {1} Km", time / time/86400, Distance.ToString("n0"));


            }

            //-------------------------------------------------------------------------------------------------
            //-------------------------اگر زمان بین 604800 ثانیه تا 2592000 ثانیه باشد-------------------
            //-------------------------.مسافت طی شده نور در چند هفته را تعیین میکند-----------------------
            //-------------------------------------------------------------------------------------------------

            else if (time >=604800 && time < 2592000)
            {

                System.Console.WriteLine
                    ("The distance to which light lasted for {0} Week/Weeks: {1} Km", time / 604800, Distance.ToString("n0"));


            }

            //-------------------------------------------------------------------------------------------------
            //----------------------اگر زمان بین 2592000 ثانیه تا 31536000 ثانیه باشد--------------------
            //-------------------------.مسافت طی شده نور در چند ماه را تعیین میکند------------------------
            //-------------------------------------------------------------------------------------------------

            else if (time >= 2592000 && time < 31536000)
            {

                System.Console.WriteLine
                    ("The distance to which light lasted for {0} Month/Months: {1} Km", time / 3600, Distance.ToString("n0"));


            }

            //-------------------------------------------------------------------------------------------------
            //----------------------اگر زمان بین 31536000 ثانیه تا 3153600000 ثانیه باشد--------------------
            //-------------------------.مسافت طی شده نور در چند سال را تعیین میکند------------------------
            //-------------------------------------------------------------------------------------------------

            else if (time >= 31536000 && time < 3153600000)
            {

                System.Console.WriteLine
                    ("The distance to which light lasted for {0} Year/Years: {1} Km", time / 31536000, Distance.ToString("n0"));


            }

            //-------------------------------------------------------------------------------------------------
            //---------------------------------اگر زمان از 3153600000 بیشتر باشد---------------------------
            //----------------------------.مسافت طی شده نور در چند قرن را تعیین میکند---------------------
            //-------------------------------------------------------------------------------------------------

            else if (time >= 3153600000)
            {

                System.Console.WriteLine
                    ("The distance to which light lasted for {0} Centurie/Centuries: {1} Km", time / 3153600000, Distance.ToString("n0"));


            }


            return Distance;



        }



        static void Main(string[] args)
        {
            int TimeSec, TimeMin, TimeHur, TimeDay, TimeWek, TimeMon, TimeYer;
            long TimeCnt;

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
                        TimeHur = int.Parse(System.Console.ReadLine());

                        TimeHur = TimeHur * 3600;

                        LightDistance(TimeHur);
                        System.Console.WriteLine();

                        break;

                    case "4":

                        System.Console.WriteLine();
                        System.Console.Write("Please enter the DAY: ");
                        TimeDay = int.Parse(System.Console.ReadLine());

                        TimeDay = TimeDay * 86400;

                        LightDistance(TimeDay);
                        System.Console.WriteLine();

                        break;

                    case "5":

                        System.Console.WriteLine();
                        System.Console.Write("Please enter the WEEK: ");
                        TimeWek = int.Parse(System.Console.ReadLine());

                        TimeWek = TimeWek * 604800;

                        LightDistance(TimeWek);
                        System.Console.WriteLine();

                        break;

                    case "6":

                        System.Console.WriteLine();
                        System.Console.Write("Please enter the MONTH: ");
                        TimeMon = int.Parse(System.Console.ReadLine());

                        TimeMon = TimeMon * 2592000;

                        LightDistance(TimeMon);
                        System.Console.WriteLine();

                        break;

                    case "7":

                        System.Console.WriteLine();
                        System.Console.Write("Please enter the YEAR: ");
                        TimeYer = int.Parse(System.Console.ReadLine());

                        TimeYer = TimeYer * 31536000;

                        LightDistance(TimeYer);
                        System.Console.WriteLine();

                        break;

                    case "8":

                        System.Console.WriteLine();
                        System.Console.Write("Please enter the CENTURIES: ");
                        TimeCnt = int.Parse(System.Console.ReadLine());

                        TimeCnt = TimeCnt * 3153600000;

                        LightDistance(TimeCnt);
                        System.Console.WriteLine();

                        break;

                    case "Q":
                        System.Environment.Exit(0);
                        break;

                    case "q":
                        System.Environment.Exit(0);
                        break;

                    default:

                        System.Console.WriteLine("Please enter the correct order...!");

                        System.Console.WriteLine();

                        break;


                }

            } while (true);            
            
        }
    }
}
