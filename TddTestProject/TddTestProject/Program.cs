using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddTestProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Immigrants objImmigrants = new Immigrants();
            objImmigrants.setStartYear();
            objImmigrants.setEndYear();

           // objImmigrants.addImmigrants();
            objImmigrants.printNumberOfImmigrants();
            Console.ReadKey();


        }
    }
    public class Immigrants
    {
        private double startyear;
        private double endyear;
        private double immigrants =26000.0;
        private double incoming =300.0;
        private double outgoing =325.0;
        public Immigrants()
        { }

        public double setStartYear()
        {
            startyear = Console.Read();
            return startyear;
        }
        public double setEndYear()
        {
            endyear = Console.Read();
            return endyear;
        }
        public double getStartYear()
        {
           
            if (startyear > endyear)
            {
                return 0;
            }
            return startyear;
        }
        public double getEndYear()
        {
            if (startyear < endyear)
            {
                return 0;
            }
            return endyear;
        }
        public void addImmigrants(double x)
        {
            immigrants = x;
        }

        public double getAddImmigrants()
        {
            return immigrants;
        }
        public void addIncoming(double y)
        {
            incoming = y;
            
        }

        public double getIncomingImmigrants()
        {
            return incoming;
        }

        public void addOutgoing(double z)
        { 
            outgoing=z;
        }
        public double getOutgoingImmigrants()
        {
            return outgoing;
        }


        public void printNumberOfImmigrants()
        {
            for(double i =getStartYear(); getStartYear()<getEndYear();i++)
            {
                double born = 0.007 * immigrants;
                double died = 0.006 * immigrants;
                immigrants = immigrants + (incoming - outgoing) + (born - died);
                
            }
            Console.WriteLine("Total Immigrants: " + immigrants);
        }



    }
}
