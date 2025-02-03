using Microsoft.SqlServer.Server;
using System;
using System.Security.Cryptography;
using System.Linq;

namespace Syntax
{
    internal class Program
    {
        enum Enum : byte { Sun, Mon, Tue, Wed, Thu, Fri, Sat }

        static string FullName(string FirstName, string LastName)
        {
            return FirstName + LastName;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello world");
            Console.WriteLine("{0} + {1} = {2}", 5, 2, 7);
            Console.WriteLine("5 + 2 = " + 7);

            byte Byte = 55;
            sbyte sByte = -55;
            short Short = -5233;
            ushort uShort = 5242;
            int Int = -52343256;
            uint uInt = 53423242u;
            long Long = -43982832923323224l;
            ulong uLong = 28493824928932849ul;

            float Float = 42343.452f;
            double Double = 3289432943120.2348723983248923d;
            decimal Decimal = 234924828934892784378587728.32489237873287237832m;

            char Char = 'K';
            string String = "Hello World";
            bool Bool = false;

            int DefInt = default(int);
            int DefIntNew = default;

            Nullable<int> NullableInt = null;

            var Student = new { Id = 5, Name = "Kato", Grade = 98 };

            dynamic Meow = 5;
            Meow = "Hello";
            Meow = 5.55;

            DateTime dt = new DateTime(2002, 9, 15);
            Console.WriteLine(dt);

            dt = DateTime.Now;
            Console.WriteLine(dt);

            dt = DateTime.Today;
            Console.WriteLine(dt);

            dt = DateTime.UtcNow;
            Console.WriteLine(dt);

            dt = DateTime.MaxValue;
            Console.WriteLine(dt);

            dt = DateTime.MinValue;
            Console.WriteLine(dt);

            TimeSpan ts = new TimeSpan(15, 5, 22);
            Console.WriteLine(ts);

            dt = DateTime.Now;
            dt.Add(ts);
            Console.WriteLine(dt);

            DateTime dt2 = new DateTime(2002, 9, 15);
            ts = dt.Subtract(dt2);
            Console.WriteLine(ts);

            Console.WriteLine(dt2 + ts);
            Console.WriteLine(dt2 - dt);
            Console.WriteLine(dt == dt2);
            Console.WriteLine(dt != dt2);
            Console.WriteLine(dt > dt2);
            Console.WriteLine(dt < dt2);
            Console.WriteLine(dt >= dt2);
            Console.WriteLine(dt <= dt2);

            var isValidDate = DateTime.TryParse("1/9/2002", out dt);
            Console.WriteLine(dt);

            dt = DateTime.Parse("2/3/2025");
            Console.WriteLine(dt);

            string S1 = "Kato Meow Meow";
            Console.WriteLine(S1.Length);
            Console.WriteLine(S1.Substring(5, 4));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(6, "Kato "));
            Console.WriteLine(S1.Replace("Meow", "Kato"));
            Console.WriteLine(S1.IndexOf("Meow"));
            Console.WriteLine(S1.Contains("Meow"));
            Console.WriteLine(S1.LastIndexOf('M'));
            string[] Names = S1.Split(' ');
            Console.WriteLine(Names);
            S1 = "        Meow                 ";
            Console.WriteLine(S1.Trim());
            Console.WriteLine(S1.TrimStart());
            Console.WriteLine(S1.TrimEnd());

            int Implicit = 5;
            double Implicit2 = Implicit;
            Console.WriteLine(Implicit2);

            double Explicit = 5.4;
            int Explicit2 = (int)Explicit;
            Console.WriteLine(Explicit2);

            Console.WriteLine((int)Enum.Tue);

            S1 = Console.ReadLine();
            Console.WriteLine(S1);

            if (S1 == "A")
            {
                Console.WriteLine(S1);
            } 
            else if (S1 == "B")
            {
                Console.WriteLine("Meow");
            } 
            else
            {
                Console.WriteLine("Kato");
            }

            switch (S1)
            {
                case "A":
                    Console.WriteLine(S1);
                    break;
                case "B":
                    Console.WriteLine("Meow");
                    break;
                default:
                    Console.WriteLine("Kato");
                    break;
            }

            Console.WriteLine((S1 == "A") ? S1 : (S1 == "B") ? "Meow" : "Kato");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            while (S1 != "A")
            {
                Console.WriteLine("Enter A to exit");
                S1 = Console.ReadLine();
            }

            char[] gender = { 'm', 'f', 'f', 'm', 'm' };
            foreach(char g in gender)
            {
                Console.WriteLine(g);
            }

            int[,] Matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Matrix[i, j] = i;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    Console.Write("{0} ", Matrix[i, j]);
                }
                Console.WriteLine();
            }


            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Console.WriteLine(Numbers.Min());
            Console.WriteLine(Numbers.Max());
            Console.WriteLine(Numbers.Count());
            Console.WriteLine(Numbers.Sum());
            Console.WriteLine(Numbers.Average());

            Console.WriteLine(Math.Min(1, 5));
            Console.WriteLine(Math.Max(1, 5));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Round(0.5));

            Console.WriteLine(FullName(LastName: "Meow", FirstName: "Kato"));

            int Zero = 0;

            try { Console.WriteLine(5/Zero); } 
            catch(Exception e) { Console.WriteLine(e.Message); };

            Random rnd = new Random();
            Console.WriteLine(rnd.Next(0, 10));
        }
    }
}
