using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Delegate
    {
        public delegate void HomeBootle(string name);
        public void Bottle(string name)
        {
            Console.WriteLine(name);
        }
        public static void Bootle1(string bname)
        {
            Console.WriteLine(bname);
        }
        static void Main(string[] args)
        {
            Delegate ObjDel = new Delegate();
            ObjDel.Bottle("Zintle");
            Delegate.Bootle1("Ninbu Pani");

            //This is my delegare
            HomeBootle HB = new HomeBootle(ObjDel.Bottle);
            HB("This is my Delegate...");
            HB.Invoke("This is a invoke Method");

            // This is a static method
            HomeBootle HB1 = new HomeBootle(Bootle1);
            HB1("This is my static method Delegate...");
            HB1.Invoke("This is a invoke Method static method");
            Console.ReadLine();
        }
    }
}
