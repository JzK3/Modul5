namespace Itog5modul
{
    using System;
    using System.Drawing;
    using System.Xml.Linq;

    class Program
    {
        public static void Main(string[] args)
        {
            (string name, string surname, int age, string[] mpets, string[] mcolors) User = EnterUser();
            OutCortage(User);
        }
        static (string name, string surname, int age, string[] mpets, string[] mcolors) EnterUser()
        {
            (string name, string surname, int age, string[] mpets, string[] mcolors) User;
            Console.Write("Enter your name please - ");
            User.name = Console.ReadLine();
            Console.Write("Enter your Surname please - ");
            User.surname = Console.ReadLine();
            Console.Write("Enter your age - ");
            User.age = int.Parse(Console.ReadLine());
            Console.Write("Do you have a pet? - ");
            bool pet = bool.Parse(Console.ReadLine());
            if (pet == true)
            {
                Console.Write("How many pets do you have? - ");
                int petCount = int.Parse(Console.ReadLine());
                User.mpets = new string[petCount];
                Console.Write("What is your pet's name? - ");
                for (int i = 0; i < User.mpets.Length; i++) { User.mpets[i] = Console.ReadLine(); }
            }
            else { User.mpets = new string[0]; }
            Console.Write("How many favorite colors do you have? - ");
            int colCount = int.Parse(Console.ReadLine());
            User.mcolors = new string[colCount];
            Console.Write("list them\n");
            for (int i = 0; i < User.mcolors.Length; i++) { User.mcolors[i] = Console.ReadLine(); }
            Console.Write("\nlist them\n\n");
            return User;
        }



        static bool Check(string number, out int cornumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    cornumber = intnum;
                    return false;
                }
            }
            {
                cornumber = 0;
                return true;
            }
        }
        static void OutCortage((string name, string surname, int age, string[] mpets, string[] mcolors) User)
        {

            Console.Write("User name - {0}\n", User.name);
            Console.Write("User surname - {0}\n", User.surname);
            Console.Write("User age - {0}\n", User.age);
            Console.WriteLine("User pets: ");
            for (int i = 0; i < User.mpets.Length; i++)
            {
                Console.WriteLine(" " + User.mpets[i] + " ");
            }
            Console.WriteLine("User colors: ");
            for (int i = 0; i < User.mcolors.Length; i++)
            {
                Console.WriteLine(" "+User.mcolors[i] + " ");
            }
        }
    }
}