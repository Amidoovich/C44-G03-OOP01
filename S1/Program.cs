using System.Net.Http.Headers;
using Common;
using Common.Access_Modifiers;
namespace S1
{

    
    internal class Program
    {
        public static void PrintWeekDays()
        {
            foreach(WeekDays Day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(Day);
            }
        }
        static void Main(string[] args)
        {
            #region Q1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.
            PrintWeekDays();
            #endregion
        }
    }
}
