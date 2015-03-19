using System;
using System.Collections.Generic;

namespace DefineClass
{
    class CallHistoryTest
    {
        public void TestHistoryCalls()
        {
            GSM myGoodGSM = new GSM();
            List<Call> aFewCalls = new List<Call>();

            for (int i = 0; i < 6; i++)
            {
                aFewCalls.Add(new Call(DateTime.Now.AddHours(i + 2).AddMinutes(i+3), "0889876543", "0881234567", i + 0.3));
            }
            for (int i = 0; i < aFewCalls.Count; i++)
            {
                Console.WriteLine("{0} called {1} for {2} minutes at {3}", aFewCalls[i].Number, aFewCalls[i].DialedPhone, aFewCalls[i].Duration, aFewCalls[i].DateTime);
            }
            Console.WriteLine();

            foreach (var aFewCall in aFewCalls)
            {
                myGoodGSM.AddCalls(aFewCall);
            }

            double priceOfCall = 0.37;
            double money = myGoodGSM.CalculateTotalPrice(priceOfCall);
            Console.WriteLine("Spent money for calls: {0:C}", money);
            Console.WriteLine();

            double longestDuration = 0;
            int indexOfLongestCall = 0;

            for (int i = 0; i < aFewCalls.Count; i++)
            {
                if (aFewCalls[i].Duration >= longestDuration)
                {
                    longestDuration = aFewCalls[i].Duration;
                    indexOfLongestCall = i;
                }
            }

            myGoodGSM.CallDeleted += myGoodGSM_CallDeleted;
            myGoodGSM.DeleteCalls(aFewCalls[indexOfLongestCall]);

            money = myGoodGSM.CalculateTotalPrice(priceOfCall);
            Console.WriteLine("Spent money for calls after removing the longest: {0:C}", money);
            Console.WriteLine();

            myGoodGSM.callHistoryClaeared += myGoodGSM_callHistoryClaeared;
            myGoodGSM.ClearCallHistory();

            if (myGoodGSM.CallHistory.Count == 0)
            {
                Console.WriteLine("The call history is empty!");
            }
            
        }

        private void myGoodGSM_CallDeleted(object sender, EventArgs e)
        {
            Console.WriteLine("An entry was deleted!");
        }

        static void myGoodGSM_callHistoryClaeared(object sender, EventArgs e)
        {
            Console.WriteLine("Call History Cleared!");
        }
    }
}
