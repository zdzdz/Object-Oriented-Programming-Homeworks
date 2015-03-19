using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class GSMTest
    {
        public void CreateAFewGSMs()
        {
            GSM test1 = new GSM("Samsung S4", "Samsung C&T Corporation", 1250, "HappyOwner",
                                new Battery("High-Tech-Battery", 600, 350, Battery.Type.NiCd),
                                new Display(5.5, 16000000));
            GSM test2 = new GSM("D500", "Samsung Corp");
            GSM test3 = new GSM("Sony Z3", "Sony Corporation", 1000, "Me&Myself", 
                        new Battery("Toshiba", Battery.Type.NiMH), new Display());
            GSM test4 = new GSM("One", "OnePlus", 1199, "Sammy");
            GSM[] allPhones = { test1, test2, test3 , test4};

            foreach (var gsm in allPhones)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4SInfo);
        }
    }
}

