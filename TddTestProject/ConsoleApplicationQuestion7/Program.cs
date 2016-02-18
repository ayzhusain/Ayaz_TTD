using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            TivoliGronaLund objTGL = new TivoliGronaLund();

            Console.WriteLine("Welcom to Tivoli Grona Lund :) \n");
            Console.WriteLine("Please Enter No of adults:");

         

        }
    }
    public class TivoliGronaLund
    {
        private int fair = 100;
        private string message;
        private int sum;
        private int child;
        private int youngster;
        private int adult;
        private string day;

        public TivoliGronaLund()
        { }

        public void addPersons()
        {
            
        }

        public void val(string v)
        {


            switch (v)
            {
                case "Yes":
                    Console.Write("Enter Age ");
                    var input = Convert.ToInt16(Console.ReadLine());
                    Older(input);
                    break;
                case "No":
                    Console.WriteLine("Enter WeekDay: ");
                    var dag = Console.ReadLine().ToLower();
                    Weekday(day);

                    break;
                default:
                    Console.WriteLine("Something got Wrong :P ");
                    break;
            }
        }

        public void choice(string v)
        {
            throw new NotImplementedException();
        }

        private void Weekday(string day)
        {
            if ((day == "friday") || (day == "saturday") || (day == "sunday"))
            {
                sum = (fair * 2 * adult) +  ((fair * 2) / 2 *youngster);
                
            }
        }

        public void Older(int v)
        {
            if (v <= 7)
            {
                message = "Congrats";
                child++;
            }
            else if (v > 7 && v <= 15)
            {
                message = "YoungMan";
                youngster++;
            }
            else if (v > 15)
            {
                message = "Adult";
                adult++;
            }
        }

        public int getYoungMan()
        {
            return youngster;
        }
        public int getVuxen()
        {
            return adult;
        }

        public string getMessage()
        {
            return message;
        }
    }


}
