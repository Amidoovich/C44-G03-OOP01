using System.Net.Http.Headers;
using Common;
using Common.Access_Modifiers;
namespace S1
{
    // Class
    // Struct
    // Interface
    // Enum

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Library
            Product product = new Product();
            #endregion
            #region Access Modifiers
            TypeA typeA = new TypeA();
            //typeA.X = 10;
            //typeA.Y = 10;
            typeA.Z = 10;
            #endregion
            #region Enum
            #region Example 01

            //Person person = new Person();

            //person.Id = 10;
            //person.Name = "Ahmed";
            //person.Gender = Gender.Male;

            //Grades Grd01 = Grades.B;


            //if(Grd01 == Grades.A)
            //    Console.WriteLine("Bravo");
            //else
            //    Console.WriteLine(":(");

            //Grd01 = (Grades)10;

            //Console.WriteLine(Grd01);

            //Grades Grd01 = new Grades();

            //Gender gender = new Gender();
            //Console.WriteLine(gender);

            #endregion
            #region Example 02
            //Student student = new Student();
            ////{
            ////    Id = 1,
            ////    Name = "Ahmed",
            ////    Gender = Gender.Male,
            ////    Grades = Grades.B,
            ////    Branch = Branch.Maddi
            ////};
            //bool IsParse;
            //Console.WriteLine("Enter Student Daata : ");
            //int id;
            //do
            //{
            //    Console.Write("Enter Id : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out id);
            //} while (!IsParse);
            //student.Id = id;

            //Console.Write("Enter the Name : ");
            //student.Name = Console.ReadLine();

            //object stdGender;

            //do
            //{
            //    Console.Write("Enter Gender : ");
            //    IsParse = Enum.TryParse(typeof(Gender), Console.ReadLine(), out stdGender);
            //} while (!IsParse);

            //student.Gender = (Gender)stdGender;

            //Branch stdBranch;

            //do
            //{
            //    Console.Write("Enter Branch : ");
            //    IsParse = Enum.TryParse<Branch>(Console.ReadLine(),out stdBranch);
            //}while (!IsParse);

            //student.Branch = stdBranch;
            //Grades stdGrade;

            //do
            //{

            //    Console.Write("Enter Grade : ");
            //    IsParse = Enum.TryParse(Console.ReadLine(), out stdGrade);
            //}while (!IsParse);

            //student.Grades = stdGrade;
            //Console.Clear();

            //Console.WriteLine($"Student ID : {student.Id}\nStudent Name : {student.Name}\nStudent Grade : {student.Grades}\nStudent Gender : {student.Gender}\nStudent Branch : {student.Branch}");

            #endregion
            #region Example 03
            //User user = new User();
            ////user.Id = 1;
            ////user.Premisions[0] = true;
            ////user.Premisions[1] = true;
            ////user.Premisions[2] = true;
            ////user.Premisions[3] = true;
            //user.Permissions = (Permissions)1; //Delete
            //Console.WriteLine(user.Permissions);

            //user.Permissions = user.Permissions ^ Permissions.Read; // DELETE AND READ
            //Console.WriteLine(user.Permissions);

            //user.Permissions = user.Permissions ^ Permissions.Read;
            //Console.WriteLine(user.Permissions); // Delete

            ////user.Permissions = user.Permissions ^ Permissions.Delete;
            ////Console.WriteLine(user.Permissions); // 0

            ////if ((user.Permissions & Permissions.Excute) == Permissions.Excute)
            ////    Console.WriteLine("permisions is exist");
            ////else
            ////    user.Permissions = user.Permissions ^ Permissions.Excute;

            //Console.WriteLine(user.Permissions);

            //user.Permissions |= Permissions.write;



            #endregion
            #endregion
        }
    }
}
