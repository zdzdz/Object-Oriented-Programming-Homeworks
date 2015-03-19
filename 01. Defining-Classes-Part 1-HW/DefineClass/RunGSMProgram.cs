//Problem 1. Define class

//    Define a class that holds information about a mobile phone device: 
//    model, manufacturer, price, owner, battery characteristics 
//    (model, hours idle and hours talk) and display characteristics 
//    (size and number of colors).
//    Define 3 separate classes (class GSM holding instances of the classes Battery 
//    and Display).


using System;

namespace DefineClass
{
    public class RunGSMProgram
    {

        private static void Main()
        {
            //GSM newPhone = new GSM();
            //newPhone.Model = "D500";
            //newPhone.Manufacturer = "Samsung";
            //newPhone.Owner = "Ivan";

            //Console.WriteLine(newPhone);
            //Console.WriteLine("Enter phone model:");
            //myPhone.Model = Console.ReadLine();
            //Console.WriteLine("Enter phone manufacturer:");
            //myPhone.Manufacturer = Console.ReadLine();
            //Battery myBattery = new Battery();
            //Console.WriteLine("Enter hours of idle: (Not necessery, press enter to skip!)");
            
            //myBattery.HoursIdle = null;
            //string currentIdle = Console.ReadLine();
            //if (currentIdle.Length != 0)
            //{
            //    myBattery.HoursIdle = double.Parse(currentIdle);
            //}

            //Console.WriteLine("Enter hours talked: (Not necessery, press enter to skip!)");
            //myBattery.HoursTalk = null;
            //string currentHours = Console.ReadLine();
            //if (currentIdle.Length != 0)
            //{
            //    myBattery.HoursTalk = double.Parse(currentHours);
            //}

            GSMTest someTest = new GSMTest();
            someTest.CreateAFewGSMs();
            Console.WriteLine(new string('#', 70));
            Console.WriteLine();
            CallHistoryTest newTest = new CallHistoryTest();
            newTest.TestHistoryCalls();
        }
    }
}

