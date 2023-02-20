using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    internal class Program
    {
        class Journal {

            public Journal(ref int count) {

                count++;
                Number = count;
                Users = 0;
            }


            private int number;

            public int Number
            {
                get { return number; }
                set { number = value; }
            }


            private int users;

            public int Users
            {
                get { return users; }
                set { users = value; }
            }



            public static Journal operator +(Journal obj, int val)
            {
            
                obj.Users += val;
                return obj;

            }

            public static Journal operator -(Journal obj, int val)
            {

                obj.Users -= val;
                return obj;

            }


            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (GetType() != obj.GetType())
                    return false;

                Journal obj1 = (Journal)obj;

                if (Users != obj1.Users)
                    return false;

                return Users == obj1.Users;
            }

            public static bool operator ==(Journal obj1, Journal obj2)
            {
                return obj1.Equals(obj2);
            }

            public static bool operator !=(Journal obj1, Journal obj2)
            {
                return !(obj1.Equals(obj2));
            }

            public static bool operator >(Journal obj1, Journal obj2)
            {

                if (obj1.Users > obj2.Users)
                {
                    return true;
                }
                else return false;

            }

            public static bool operator <(Journal obj1, Journal obj2)
            {

                if (obj1.Users < obj2.Users)
                {
                    return true;
                }
                else return false;

            }



            public void Print()
            {

                Console.WriteLine($"Номер журнала {Number}");
                Console.WriteLine($"Пользоватилей в журнале {Users}");
                Console.WriteLine();

            }

        }

        static void Main(string[] args)
        {
            int Journal_Count = 0;

            Journal j = new Journal(ref Journal_Count);
            Journal j1 = new Journal(ref Journal_Count);

            j += 10;
            j1 += 10;


            j.Print();
            j1.Print();
            if (j1 == j) 
            { 
                Console.WriteLine("Объекты равны"); 
                Console.WriteLine(); 
            }


            j += 20;
            j.Print();

            if (j!=j1)
            {
                Console.WriteLine("Объекты не равны");
                Console.WriteLine();
            }

            if (j>j1)
            {
                Console.WriteLine($"Журанл {j.Number} > {j1.Number}");
                Console.WriteLine();
            }

            if (j1 < j)
            {
                Console.WriteLine($"Журанл {j1.Number} < {j.Number}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
