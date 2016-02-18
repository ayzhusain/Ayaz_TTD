using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDQuestion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature(20);
            t.setTemp(21);
            Console.Write("Todays Temperature :"+t.getTemp());

            Console.ReadKey();
        }
    }
    public class Temperature
    {
        private double temp;
        public Temperature() { }
        public Temperature(double v)
        {
            temp = v;
        }
        public void setTemp(double x)
        {
            Console.WriteLine("Enter Temperature :");
            temp = x;
        }
        public double getTemp()
        {
            if(temp >=18 && temp <=25)
            {
                Console.Write("Lagom Temp");
                return temp;
            }
            else if (temp > 25)
            {
                Console.Write("For varmt");
                return temp;
            } 
            else
            {
                Console.Write("for kallt");
                return temp;
            }
            
        }
    }
}
