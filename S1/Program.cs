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
            //PrintWeekDays();
            #endregion
            #region Q2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Season season;
            //bool IsParse;
            //do
            //{
            //    Console.Write("Enter the Season : ");
            //    IsParse = Enum.TryParse(Console.ReadLine(),out season);
            //}while (!IsParse);
            //if(season == Season.Spring)
            //    Console.WriteLine("spring march to may");
            //else if (season == Season.Summer)
            //    Console.WriteLine("summer june to august");
            //else if (season == Season.Autumn)
            //    Console.WriteLine("autumn September to November");
            //else if (season == Season.Winter)
            //    Console.WriteLine("winter December to February");



            #endregion
            #region Q3-3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable
            //bool IsParse;
            //int Input;
            //Permissions permissions = new Permissions();
            //while(true)
            //{
            //    int Case; 
            //    do
            //    {
            //        Console.Write("1 For add\n2 for remove\n3 for exit\nPlease Enter :");
            //        IsParse = int.TryParse(Console.ReadLine(), out Case);
            //    } while (!IsParse);

            //    if (Case == 3)
            //    {
            //        Console.WriteLine("Exiting program...");
            //        break;
            //    }

            //    do
            //    {
            //        Console.Write("1 For DELETE\n2 for EXCUTE\n3 for READ\n4 for WRITE\nPlease Enter : ");
            //        IsParse = int.TryParse(Console.ReadLine(), out Input);
            //    } while (!IsParse);

            //    if (Case == 1)
            //    {
            //        switch (Input)
            //        {
            //            case 1:
            //                permissions |= Permissions.Delete;
            //                break;
            //            case 2:
            //                permissions |= Permissions.Excute;
            //                break;
            //            case 3:
            //                permissions |= Permissions.Read;
            //                break;
            //            case 4:
            //                permissions |= Permissions.Write;
            //                break;
            //        } 
            //    }
            //    else if (Case == 2)
            //    {
            //        switch (Input)
            //        {
            //            case 1:
            //                if ((permissions & Permissions.Delete) == Permissions.Delete)
            //                    permissions ^= Permissions.Delete;
            //                else
            //                    Console.WriteLine("permisions is not exist");
            //                break;
            //            case 2:
            //                if ((permissions & Permissions.Excute) == Permissions.Excute)
            //                    permissions ^= Permissions.Excute;
            //                else
            //                    Console.WriteLine("permisions is not exist");
            //                break;
            //            case 3:
            //                if ((permissions & Permissions.Read) == Permissions.Read)
            //                    permissions ^= Permissions.Read;
            //                else
            //                    Console.WriteLine("permisions is not exist");
            //                break;
            //            case 4:
            //                if ((permissions & Permissions.Write) == Permissions.Write)
            //                    permissions ^= Permissions.Write;
            //                else
            //                    Console.WriteLine("permisions is not exist");
            //                break;
            //        }
            //    }
            //    Console.WriteLine($"the permissions exist is : {permissions}");
            //    Console.Write("please enter any thing to continue : ");
            //    Console.ReadKey();
            //    Console.Clear();

            //} 








            #endregion
            #region Q4- 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.Write("please enter the color : ");
            //string? Input = Console.ReadLine();

            //if(Enum.TryParse(Input, out Color color))
            //    Console.WriteLine($"the color {color} is primary");
            //else
            //    Console.WriteLine($"the color {Input} is not primary");
            #endregion

        }
    }
}
