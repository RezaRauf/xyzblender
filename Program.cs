using System;
using static System.Console;
namespace BlenderXYZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            WriteLine("&                                            &");
            WriteLine("&           Make your things smooth          &");
            WriteLine("&                                            &");
            WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            ReadLine();

            //TASK 2
            string Name, Street_adress, City, State;
            int Postcode, quanity;
            const double TAX = 0.05;
            const double PRICE_OF_BLENDER = 35.50;
            double TOTAL_COST;
            double TOTAL_DUE;
            double TOTAL_TAX;


            WriteLine("ENTER NAME:");
            Name = ReadLine();

            WriteLine("ENTER STREET ADDRESS:");
            Street_adress = ReadLine();

            WriteLine("ENTER CITY:");
            City = ReadLine();

            WriteLine("ENTER STATE:");
            State = ReadLine();

            WriteLine("ENTER POSTCODE:");
            Postcode = Convert.ToInt32(ReadLine());

            WriteLine("ENTER NUMBER OF BLENDERS AT ${0} EACH", PRICE_OF_BLENDER.ToString("F2"));
            quanity = Convert.ToInt32(ReadLine());

            TOTAL_COST = quanity * PRICE_OF_BLENDER;
            TOTAL_TAX = TOTAL_COST * TAX;
            TOTAL_DUE = TOTAL_COST + TOTAL_TAX;

            //TASK 3  
            WriteLine("--------------------------INPUT DATA---------------------------");
            WriteLine("RECIEPT FOR:");
            WriteLine("NAME: {0}", Name);
            WriteLine("ADDRESS: {0}", Street_adress);
            WriteLine("CITY: {0}", City);
            WriteLine("STATE: {0}", State);
            WriteLine("ZIP code: {0}", Postcode);

            WriteLine("---------------------------------------------------------------");

            WriteLine("{0} Blenders ordered at ${1} each",quanity,PRICE_OF_BLENDER.ToString("F2"));

            WriteLine("Total:                                             ${0}        ", TOTAL_COST.ToString("F2"));
            WriteLine("TAX:                                               ${0}        ", TOTAL_TAX.ToString("F2"));

            WriteLine("---------------------------------------------------------------");
            WriteLine("Total Due:                                         ${0}        ", TOTAL_DUE.ToString("F2"));
            ReadLine();










        }
    }
}
